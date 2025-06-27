using Microsoft.Office.Interop.Excel;
using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using Application = System.Windows.Forms.Application;
using Rectangle = System.Drawing.Rectangle;
using ProjectTest._0MainPage;
using DataTable = System.Data.DataTable;



namespace ProjectTest.MainPage
{
    public partial class HomePage : Form
    {

        public static HomePage ins;
        public DataGridView gvSubData = new DataGridView();
        private static HomePage _instance;
        public HomePage()
        {
            InitializeComponent();
            ins = this;
            string stNo = tbStyle.Text;
            string sSimLo = cbbSimLo.Text;
        }

        private void btminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit program ?", "Information", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void HomePage_Load(object sender, EventArgs e)
        {

            tabform.Controls.Clear();
            IntroProgram frm = new IntroProgram();
            themtabpage(frm, tabName: "Standby");
            tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            cbbSimLo.Text = Properties.Settings.Default.sSimLo;
            hideSubMenu();
        }


        public void themtabpage(UserControl control, string tabName)
        {
            int index = kiemtratontai(tabform, tabName);
            if (index >= 0)
            {
                tabform.TabIndex = index;
            }
            else
            {
                TabPage tabpage = new TabPage { Text = "    " + tabName + "        " };
                tabpage.BorderStyle = BorderStyle.None;
                tabform.TabPages.Add(tabpage);
                //  control.TopLevel = false;
                control.Parent = tabpage;
                control.Dock = DockStyle.Fill;
                control.AutoScaleMode = AutoScaleMode.None;
                control.Show();
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            pnDatabase.Visible = false;

        }
        private void TabPageShowAgain(TabControl tabForm, string frm)
        {
            int indexStandby = -1;
            for (int i = 0; i < tabForm.TabPages.Count; i++)
            {
                if (tabForm.TabPages[i].Text.Trim() == "Standby")
                {
                    indexStandby = i;
                    break;
                }
            }
            if (indexStandby > -1)
                tabform.TabPages.Remove(tabform.TabPages[indexStandby]);
            for (int i = 0; i < tabForm.TabPages.Count; i++)
            {
                // MessageBox.Show(tabForm.TabPages[i].Text.Trim().Length.ToString()+"||"+ frm.Text.Trim().Substring);
                if (tabForm.TabPages[i].Text.Trim() == frm.Trim())
                {
                    tabForm.SelectedIndex = i;
                    // MessageBox.Show(tabForm.TabPages[i].Size.ToString());
                }
            }
        }
        public int kiemtratontai(TabControl tabForm, string frm)
        {
            for (int i = 0; i < tabForm.TabPages.Count; i++)
            {
                if (tabForm.TabPages[i].Text.Trim() == frm.Trim())
                {
                    return i;
                }
            }
            return -1;
        }

        System.Drawing.Rectangle closeX = Rectangle.Empty;
        private void tabform_MouseClick(object sender, MouseEventArgs e)
        {
            if (closeX.Contains(e.Location))
                tabform.TabPages.Remove(tabform.SelectedTab);

            if (tabform.TabCount == 0)
            {
                IntroProgram frm = new IntroProgram();
                themtabpage(frm, tabName: "Standby");
            }
        }

        private void tabform_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (tabform.TabPages[e.Index].Text.Trim() != "Standby")
            {
                System.Drawing.Image img = new Bitmap(Properties.Resources.close1);
                Size xSize = new Size(32, 32);
                TabPage tp = tabform.TabPages[e.Index];
                e.DrawBackground();
                using (SolidBrush brush = new SolidBrush(e.ForeColor))
                    e.Graphics.DrawString(tp.Text + "   ", e.Font, brush,
                                          e.Bounds.X + 3, e.Bounds.Y + 8);
                if (e.State == DrawItemState.Selected)
                {
                    closeX = new System.Drawing.Rectangle(e.Bounds.Right - xSize.Width,
                                           e.Bounds.Top + 4, xSize.Width, xSize.Height);
                    e.Graphics.DrawImage(img, closeX,
                                         new System.Drawing.Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel);
                }
            }
        }
        public bool checkPermiss(string perMissinFunc)
        {
            DataTable dt = Form1.ins.dtPermissList;
            if (dt.Rows.Count > 0)
            {
                bool st = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == perMissinFunc || dt.Rows[i][0].ToString() == "superUser")
                    {
                        st = true;
                    }
                }
                if (st)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {

                return false;
            }
        }

        private void btAllStyle_Click(object sender, EventArgs e)
        {
            //ucAllStyle frm = new ucAllStyle();
            //themtabpage(frm, tabName: "Style List");
            //tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            //TabPageShowAgain(tabform, "Style List");
        }

        private void btNewStyle_Click(object sender, EventArgs e)
        {
            //ucNewStyle frm = new ucNewStyle();
            //themtabpage(frm, tabName: "Style Form");
            //tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            //TabPageShowAgain(tabform, "Style Form");
        }

        private void btSimStyle_Click(object sender, EventArgs e)
        {
            //ucCompare frm = new ucCompare();
            //themtabpage(frm, tabName: "Similarity Style");
            //tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            //TabPageShowAgain(tabform, "Similarity Style");

        }

        private void btactivity_Click(object sender, EventArgs e)
        {
            //ucActivity frm = new ucActivity();
            //themtabpage(frm, tabName: "Activity Log");
            //tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            //TabPageShowAgain(tabform, "Activity Log");
        }

        private void cbbSimLo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.sSimLo = cbbSimLo.Text;
            Properties.Settings.Default.Save();
        }

        private void btDatabase_Click(object sender, EventArgs e)
        {
            showSubMenu(pnDatabase);
        }
    }
}
