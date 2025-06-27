using ProjectTest.MainPage;
using ProjectTest.Myclass;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjectTest._0MainPage;
using Npgsql;

namespace ProjectTest
{
    public partial class Form1 : Form
    {
        public DataTable UserDt;
        public static Form1 ins;
        public string empID, Name, Username, Password, Department, Permiss;
        public DataTable StyleRef;
        public string UserGroup = "";
        public DataTable dtPermissList;

        public Form1()
        {
            InitializeComponent();
            ins = this;
        }
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible)
            {
                if (MessageBox.Show("Are you sure you want to exit program ?", "Information", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btIpSetting_Click(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            signIn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Ip != "")
            {
                ConnectMySQL.ip = Properties.Settings.Default.Ip;
                tbUsername1.Text = Properties.Settings.Default.Username;
                tbPass1.Text = Properties.Settings.Default.Password;
                lbIP.Text = Properties.Settings.Default.Ip;
            }
        }
        private void signIn()
        {
            if (tbUsername1.Text != "" && tbPass1.Text != "")
            {
                ConnectMySQL.db = "pts_db";
                getData();

                if (tbUsername1.Text == Username)
                {
                    if (tbPass1.Text == Password)
                    {
                        if (Permiss == "login")
                        {
                            Properties.Settings.Default.Username = tbUsername1.Text;
                            Properties.Settings.Default.Password = tbPass1.Text;

                            string sql = @"
                                                SELECT UserGroup 
                                                FROM user_tb 
                                                WHERE Username = @username AND Password = @password;
                                            ";

                            var parameters = new Dictionary<string, object>
                                            {
                                                { "@username", tbUsername1.Text },
                                                { "@password", tbPass1.Text }
                                            };

                            Properties.Settings.Default.UserGroup = ConnectMySQL.SubtextPostgres(sql, parameters);

                            string sqlUser = "UPDATE user_tb SET login = '1' WHERE empID = @empID";
                            var ptsqlUser = new Dictionary<string, object>
                            {
                                { "@empID", empID }
                            };
                            ConnectMySQL.PgQuery(sqlUser, ptsqlUser);

                            string queryPermissList = "SELECT Permiss FROM user_match_persmiss WHERE EmpID = @empID;";
                            var ptempPermissList = new Dictionary<string, object>
                            {
                                { "@empID", empID }
                            };

                            dtPermissList = ConnectMySQL.PostgrestoDataTable(queryPermissList, ptempPermissList);

                            Properties.Settings.Default.Save();
                            HomePage homePage = new HomePage();
                            homePage.Show();

                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Check Your Access Right Please.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User ID Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void getData()
        {
            string sql = @"
                            SELECT a.empid, a.username, a.password, a.name, a.department, b.permiss, a.usergroup
                            FROM user_tb a
                            LEFT JOIN user_match_persmiss b ON a.empid = b.empid AND b.permiss = 'login'
                            WHERE a.username = @username AND a.password = @password;
                          ";

            using (var connection = ConnectMySQL.GetPostgresConnection()) // สมมุติว่า PostgresDB.GetPostgresConnection() มีอยู่แล้ว
            using (var cmd = new NpgsqlCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@username", tbUsername1.Text);
                cmd.Parameters.AddWithValue("@password", tbPass1.Text);

                try
                {
                    // connection.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empID = reader.GetString(0);
                            Username = reader.GetString(1);
                            Password = reader.GetString(2);
                            Name = reader.GetString(3);
                            Department = reader.GetString(4);
                            Permiss = reader.IsDBNull(5) ? null : reader.GetString(5); // handle LEFT JOIN null
                            UserGroup = reader.GetString(6);
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("PostgreSQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void tbUsername1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signIn();
            }
        }

        private void tbPass1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signIn();
            }
        }

        private void btSetting_Click(object sender, EventArgs e)
        {
            using (NetworkSetting con = new NetworkSetting())
            {
                if (DialogResult.OK == con.ShowDialog())
                {

                }
            }
        }
    }
}