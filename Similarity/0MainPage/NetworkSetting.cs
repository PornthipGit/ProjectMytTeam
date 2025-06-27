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

namespace ProjectTest.MainPage
{
    public partial class NetworkSetting : Form
    {
        public NetworkSetting()
        {
            InitializeComponent();
        }

        private void NetworkSetting_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Ip != "" && Properties.Settings.Default.pathpic != "")
            {
                tbIP.Text = Properties.Settings.Default.Ip;
                tbpathpicture.Text = Properties.Settings.Default.pathpic;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSavepath_Click(object sender, EventArgs e)
        {
            if (tbpathpicture.Text != "" && tbIP.Text != "")
            {
                Properties.Settings.Default.Ip = tbIP.Text;
                Properties.Settings.Default.pathpic = tbpathpicture.Text;
                ConnectMySQL.ip = tbIP.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Add Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Setting IP and Path picture!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
