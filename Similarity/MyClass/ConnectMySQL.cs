using MySql.Data.MySqlClient;
using Npgsql;
using System.Data;
using System.Drawing.Drawing2D;

namespace ProjectTest.Myclass
{
    internal class ConnectMySQL
    {
        public static string ip = "", db = "";


        public static NpgsqlConnection GetPostgresConnection()
        {
            //   NpgsqlConnection con = new NpgsqlConnection("Host=" + ip + ";Port=5432;Username=postgres;Password=88888888;Database=" + db);  
            NpgsqlConnection con = new NpgsqlConnection("Host=" + ip + ";Port=5432;Username=root1;Password=88888888;Database=" + db);

            try
            {
                con.Open();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return con;
        }
        public static string Subtext(string query)
        {
            string txt = "";
            //string sql = query;
            //MySqlConnection con = GetPostgresConnection();
            //MySqlCommand cmd = new MySqlCommand(sql, con);
            //MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //MySqlDataReader myReder;
            //try
            //{
            //    myReder = cmd.ExecuteReader();
            //    while (myReder.Read())
            //    {
            //        txt = myReder.GetString(0);
            //    }
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    // lb.Text = "ไม่เจอ";
            //}
            //con.Close();
            return txt;
        }
        public static string SubtextPostgres(string query, Dictionary<string, object> parameters = null)
        {
            string txt = "0"; // เริ่มจากค่า default เป็น "0"
            using (NpgsqlConnection con = GetPostgresConnection())
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    // ใส่ parameters ถ้ามี
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // ใช้แค่ครั้งเดียว
                        {
                            txt = reader.IsDBNull(0) ? "0" : reader[0].ToString();
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show(ex.Message, "PostgreSQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }

            return txt;
        }

        public static DataTable GetData(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();

            using (NpgsqlConnection con = GetPostgresConnection())
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                try
                {
                    con.Open();

                    // Add parameters if any
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("PostgreSQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }

            return dt;
        }


        public static DataTable PostgrestoDataTable(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            using (NpgsqlConnection con = GetPostgresConnection())
            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    // Add parameters if any
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                        }
                    }

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (NpgsqlException ex)  // เปลี่ยนจาก MySqlException
                {
                    MessageBox.Show("PostgreSQL Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unknown Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
            return dt;
        }

        public static bool PgQuery(string sql, Dictionary<string, object> parameters = null)
        {
            bool status = false;

            using (NpgsqlConnection con = GetPostgresConnection())
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        // ถ้ามี parameter ให้ใส่เข้าไป
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        int affectedRows = cmd.ExecuteNonQuery();
                        status = affectedRows > 0;
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "PostgreSQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }

            return status;
        }

        public static object GetPostgresScalar(string sql, Dictionary<string, object> parameters)
        {
            using (var conn = GetPostgresConnection())
            using (var cmd = new NpgsqlCommand(sql, conn))
            {
                foreach (var param in parameters)
                {
                    cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                if (conn.State == ConnectionState.Closed)
                   conn.Open();

                return cmd.ExecuteScalar();
            }
        }


        public static void addDB(string sql)
        {
            //if (GetConnection().State != ConnectionState.Closed)
            //{
            //    // MessageBox.Show(sql);
            //    MySqlConnection con = GetConnection();
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    try
            //    {
            //        cmd.ExecuteNonQuery();
            //        //  MessageBox.Show("Added Successfully", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (MySqlException ex)
            //    {
            //      //  MessageBox.Show("Not Insert.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    con.Close();
            //}

        }
        public static void deleteDB(string sql)
        {
            //if (GetConnection().State != ConnectionState.Closed)
            //{
            //    MySqlConnection con = GetConnection();
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    try
            //    {
            //        cmd.ExecuteNonQuery();
            //        // MessageBox.Show("Delete Successfully", "Imformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (MySqlException ex)
            //    {
            //        // MessageBox.Show("Not Delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    con.Close();
            //}
        }
        public static void textTolable(string query, Label lb)
        {
            //if (GetConnection().State != ConnectionState.Closed)
            //{
            //    string sql = query;
            //    MySqlConnection con = GetConnection();
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //    MySqlDataReader myReder;

            //    try
            //    {
            //        myReder = cmd.ExecuteReader();
            //        while (myReder.Read())
            //        {
            //            lb.Text = myReder.GetString(0);
            //        }
            //    }
            //    catch (MySqlException ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        // lb.Text = "ไม่เจอ";
            //    }
            //    con.Close();
            //}
        }

        public static bool MysqlQuery(string sql)
        {
            bool status = false;

            //if (GetConnection().State != ConnectionState.Closed)
            //{

            //    MySqlConnection con = GetConnection();
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    try
            //    {
            //        cmd.ExecuteNonQuery();


            //        status = true;
            //    }
            //    catch (MySqlException ex)
            //    {

            //        status = false;
            //    }
            //    con.Close();

            //}
            return status;
        }

        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            //if (GetConnection().State != ConnectionState.Closed)
            //{
            //    string sql = query;
            //    MySqlConnection con = GetConnection();
            //    MySqlCommand cmd = new MySqlCommand(sql, con);
            //    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //    adp.Fill(dt);
            //    dgv.DataSource = dt;
            //    con.Close();
            //}
        }
        public static void DisplayAndSearchPostgres(string query, DataGridView dgv, Dictionary<string, object> parameters = null)
        {
            using (NpgsqlConnection con = GetPostgresConnection())
            {
                try
                {


                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                    {
                        // เพิ่ม parameters เฉพาะเมื่อมีการส่งเข้ามา
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (NpgsqlDataAdapter adp = new NpgsqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adp.Fill(dt);
                            dgv.DataSource = dt;
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public static DataTable MySQLtoDataTable(string query)
        {
            //if (GetConnection().State != ConnectionState.Closed)
            //{
            //    DataTable dt = new DataTable();
            //    string sql = query;
            //    using (MySqlConnection con = GetConnection())
            //    {

            //        using (MySqlCommand cmd = new MySqlCommand(sql, con))
            //        {
            //            using (MySqlDataAdapter adp = new MySqlDataAdapter(cmd))
            //            {
            //                cmd.CommandType = CommandType.Text;
            //                cmd.Connection = con;
            //                adp.SelectCommand = cmd;
            //                adp.Fill(dt);
            //                return dt;
            //            }
            //        }

            //    }
            //}
            return null;
        }


        public static void ComboboxListPostgres(string query, Dictionary<string, object> parameters, ComboBox cbb)
        {
            using (NpgsqlConnection con = GetPostgresConnection())
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
                {
                    try
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        using (NpgsqlDataReader myReader = cmd.ExecuteReader())
                        {
                            cbb.Items.Clear(); // เคลียร์ของเก่าก่อน (ถ้าต้องการ)
                            while (myReader.Read())
                            {
                                string itemCombo = myReader[0].ToString();
                                cbb.Items.Add(itemCombo);
                            }
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public static Panel CreateResize(string headerText, int width, int height, int cornerRadius = 20)
        {
            Panel panel = new Panel();
            panel.Width = width;
            panel.Height = height;
            panel.BackColor = Color.Gainsboro;

            Label label = new Label();
            label.Text = headerText;
            label.ForeColor = Color.Black;
            label.Font = new Font("Arial Rounded MT", 20, FontStyle.Bold);
            label.AutoSize = true;
            label.TextAlign = ContentAlignment.MiddleCenter;

            // ตำแหน่งเริ่มต้นของ Label (กลาง Panel)
            label.Location = new Point((panel.Width - label.PreferredWidth) / 2, (panel.Height - label.PreferredHeight) / 2);

            panel.Controls.Add(label);

            // เมื่อ Panel ถูก Resize, ปรับ Label ให้อยู่ตรงกลาง
            panel.Resize += (s, e) =>
            {
                label.Location = new Point((panel.Width - label.Width) / 2, (panel.Height - label.Height) / 2);
                panel.Region = new Region(GetRoundedRectPath(new Rectangle(0, 0, panel.Width, panel.Height), cornerRadius));
            };

            // ตั้งค่าเริ่มต้นของมุมโค้ง
            panel.Region = new Region(GetRoundedRectPath(new Rectangle(0, 0, panel.Width, panel.Height), cornerRadius));

            return panel;
        }
        private static GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            // 4 มุม
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
