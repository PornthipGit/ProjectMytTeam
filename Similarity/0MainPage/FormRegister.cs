using ProjectTest.Myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectTest._0MainPage
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (tbEmpID.Text == "")
            {
                MessageBox.Show("Incomplete information filled out");
            }
            else
            {
                if (MessageBox.Show("Are you sure want to add data ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) //colorCard
                {
                    ConnectMySQL.db = "similarity_db";
                    //  ConnectMySQL.addDB("ALTER TABLE user_tb auto_increment = 1;");
                    ConnectMySQL.PgQuery("INSERT INTO user_tb (EmpID, EmpName, UserName,Password, Department, Level) " +
                                                   "VALUES ('" + tbEmpID.Text + "','" + tbName.Text + "','" + tbUsername.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "'," +
                                                   "'" + cbblevel.Text + "')");
                    MessageBox.Show("Add Successfully", "Imformation", MessageBoxButtons.OK);

                    tbEmpID.Text = "";
                    tbName.Text = "";
                    tbUsername.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    cbblevel.Text = "";
                }
            }

        }
    }
}
