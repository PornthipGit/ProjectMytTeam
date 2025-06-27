namespace ProjectTest.MainPage
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            tbStyle = new TextBox();
            panel3 = new Panel();
            btminimize = new PictureBox();
            btClose = new PictureBox();
            panel2 = new Panel();
            panel7 = new Panel();
            pnDatabase = new Panel();
            btAllStyle = new Bunifu.Framework.UI.BunifuFlatButton();
            btNewStyle = new Bunifu.Framework.UI.BunifuFlatButton();
            btSimStyle = new Bunifu.Framework.UI.BunifuFlatButton();
            btactivity = new Bunifu.Framework.UI.BunifuFlatButton();
            btDatabase = new Guna.UI2.WinForms.Guna2GradientButton();
            cbbSimLo = new ComboBox();
            panel6 = new Panel();
            picLogo = new PictureBox();
            lbName2 = new Label();
            lbName1 = new Label();
            pnCenter = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            tabform = new TabControl();
            tabPage2 = new TabPage();
            pnGenerator = new Panel();
            panel22 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btminimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btClose).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            pnDatabase.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnCenter.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tabform.SuspendLayout();
            tabPage2.SuspendLayout();
            pnGenerator.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tbStyle);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1492, 10);
            panel1.TabIndex = 0;
            // 
            // tbStyle
            // 
            tbStyle.Location = new Point(1389, 53);
            tbStyle.Name = "tbStyle";
            tbStyle.Size = new Size(100, 23);
            tbStyle.TabIndex = 6;
            tbStyle.Visible = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(btminimize);
            panel3.Controls.Add(btClose);
            panel3.Location = new Point(1418, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(74, 41);
            panel3.TabIndex = 5;
            panel3.Visible = false;
            // 
            // btminimize
            // 
            btminimize.Image = (Image)resources.GetObject("btminimize.Image");
            btminimize.Location = new Point(3, 9);
            btminimize.Name = "btminimize";
            btminimize.Size = new Size(24, 24);
            btminimize.SizeMode = PictureBoxSizeMode.StretchImage;
            btminimize.TabIndex = 4;
            btminimize.TabStop = false;
            btminimize.Click += btminimize_Click;
            // 
            // btClose
            // 
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.Location = new Point(33, 9);
            btClose.Name = "btClose";
            btClose.Size = new Size(24, 24);
            btClose.SizeMode = PictureBoxSizeMode.StretchImage;
            btClose.TabIndex = 4;
            btClose.TabStop = false;
            btClose.Click += btClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 720);
            panel2.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(pnDatabase);
            panel7.Controls.Add(btDatabase);
            panel7.Controls.Add(cbbSimLo);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 152);
            panel7.Name = "panel7";
            panel7.Size = new Size(218, 568);
            panel7.TabIndex = 20;
            // 
            // pnDatabase
            // 
            pnDatabase.Controls.Add(btAllStyle);
            pnDatabase.Controls.Add(btNewStyle);
            pnDatabase.Controls.Add(btSimStyle);
            pnDatabase.Controls.Add(btactivity);
            pnDatabase.Dock = DockStyle.Top;
            pnDatabase.Location = new Point(0, 40);
            pnDatabase.Name = "pnDatabase";
            pnDatabase.Size = new Size(218, 136);
            pnDatabase.TabIndex = 10;
            // 
            // btAllStyle
            // 
            btAllStyle.Active = false;
            btAllStyle.Activecolor = Color.NavajoWhite;
            btAllStyle.AutoValidate = AutoValidate.EnablePreventFocusChange;
            btAllStyle.BackColor = Color.White;
            btAllStyle.BackgroundImageLayout = ImageLayout.Stretch;
            btAllStyle.BorderRadius = 0;
            btAllStyle.ButtonText = "Style List";
            btAllStyle.DisabledColor = Color.Gray;
            btAllStyle.Dock = DockStyle.Top;
            btAllStyle.Iconcolor = Color.Transparent;
            btAllStyle.Iconimage = (Image)resources.GetObject("btAllStyle.Iconimage");
            btAllStyle.Iconimage_right = null;
            btAllStyle.Iconimage_right_Selected = null;
            btAllStyle.Iconimage_Selected = null;
            btAllStyle.IconMarginLeft = 0;
            btAllStyle.IconMarginRight = 0;
            btAllStyle.IconRightVisible = true;
            btAllStyle.IconRightZoom = 0D;
            btAllStyle.IconVisible = true;
            btAllStyle.IconZoom = 40D;
            btAllStyle.IsTab = true;
            btAllStyle.Location = new Point(0, 90);
            btAllStyle.Margin = new Padding(4, 3, 4, 3);
            btAllStyle.Name = "btAllStyle";
            btAllStyle.Normalcolor = Color.White;
            btAllStyle.OnHovercolor = Color.NavajoWhite;
            btAllStyle.OnHoverTextColor = Color.White;
            btAllStyle.selected = false;
            btAllStyle.Size = new Size(218, 30);
            btAllStyle.TabIndex = 0;
            btAllStyle.Text = "Style List";
            btAllStyle.TextAlign = ContentAlignment.MiddleLeft;
            btAllStyle.Textcolor = Color.Gray;
            btAllStyle.TextFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btAllStyle.Click += btAllStyle_Click;
            // 
            // btNewStyle
            // 
            btNewStyle.Active = false;
            btNewStyle.Activecolor = Color.NavajoWhite;
            btNewStyle.BackColor = Color.White;
            btNewStyle.BackgroundImageLayout = ImageLayout.Stretch;
            btNewStyle.BorderRadius = 0;
            btNewStyle.ButtonText = "Manage Style";
            btNewStyle.DisabledColor = Color.Gray;
            btNewStyle.Dock = DockStyle.Top;
            btNewStyle.Iconcolor = Color.Transparent;
            btNewStyle.Iconimage = (Image)resources.GetObject("btNewStyle.Iconimage");
            btNewStyle.Iconimage_right = null;
            btNewStyle.Iconimage_right_Selected = null;
            btNewStyle.Iconimage_Selected = null;
            btNewStyle.IconMarginLeft = 0;
            btNewStyle.IconMarginRight = 0;
            btNewStyle.IconRightVisible = true;
            btNewStyle.IconRightZoom = 0D;
            btNewStyle.IconVisible = true;
            btNewStyle.IconZoom = 40D;
            btNewStyle.IsTab = true;
            btNewStyle.Location = new Point(0, 60);
            btNewStyle.Margin = new Padding(4, 3, 4, 3);
            btNewStyle.Name = "btNewStyle";
            btNewStyle.Normalcolor = Color.White;
            btNewStyle.OnHovercolor = Color.NavajoWhite;
            btNewStyle.OnHoverTextColor = Color.White;
            btNewStyle.selected = false;
            btNewStyle.Size = new Size(218, 30);
            btNewStyle.TabIndex = 1;
            btNewStyle.Text = "Manage Style";
            btNewStyle.TextAlign = ContentAlignment.MiddleLeft;
            btNewStyle.Textcolor = Color.Gray;
            btNewStyle.TextFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btNewStyle.Click += btNewStyle_Click;
            // 
            // btSimStyle
            // 
            btSimStyle.Active = false;
            btSimStyle.Activecolor = Color.NavajoWhite;
            btSimStyle.BackColor = Color.White;
            btSimStyle.BackgroundImageLayout = ImageLayout.Stretch;
            btSimStyle.BorderRadius = 0;
            btSimStyle.ButtonText = "Similarity Style";
            btSimStyle.DisabledColor = Color.Gray;
            btSimStyle.Dock = DockStyle.Top;
            btSimStyle.Iconcolor = Color.Transparent;
            btSimStyle.Iconimage = (Image)resources.GetObject("btSimStyle.Iconimage");
            btSimStyle.Iconimage_right = null;
            btSimStyle.Iconimage_right_Selected = null;
            btSimStyle.Iconimage_Selected = null;
            btSimStyle.IconMarginLeft = 0;
            btSimStyle.IconMarginRight = 0;
            btSimStyle.IconRightVisible = true;
            btSimStyle.IconRightZoom = 0D;
            btSimStyle.IconVisible = true;
            btSimStyle.IconZoom = 40D;
            btSimStyle.IsTab = true;
            btSimStyle.Location = new Point(0, 30);
            btSimStyle.Margin = new Padding(4, 3, 4, 3);
            btSimStyle.Name = "btSimStyle";
            btSimStyle.Normalcolor = Color.White;
            btSimStyle.OnHovercolor = Color.NavajoWhite;
            btSimStyle.OnHoverTextColor = Color.White;
            btSimStyle.selected = false;
            btSimStyle.Size = new Size(218, 30);
            btSimStyle.TabIndex = 2;
            btSimStyle.Text = "Similarity Style";
            btSimStyle.TextAlign = ContentAlignment.MiddleLeft;
            btSimStyle.Textcolor = Color.Gray;
            btSimStyle.TextFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btSimStyle.Click += btSimStyle_Click;
            // 
            // btactivity
            // 
            btactivity.Active = false;
            btactivity.Activecolor = Color.NavajoWhite;
            btactivity.BackColor = Color.White;
            btactivity.BackgroundImageLayout = ImageLayout.Stretch;
            btactivity.BorderRadius = 0;
            btactivity.ButtonText = "Activity Log";
            btactivity.DisabledColor = Color.Gray;
            btactivity.Dock = DockStyle.Top;
            btactivity.Iconcolor = Color.Transparent;
            btactivity.Iconimage = (Image)resources.GetObject("btactivity.Iconimage");
            btactivity.Iconimage_right = null;
            btactivity.Iconimage_right_Selected = null;
            btactivity.Iconimage_Selected = null;
            btactivity.IconMarginLeft = 0;
            btactivity.IconMarginRight = 0;
            btactivity.IconRightVisible = true;
            btactivity.IconRightZoom = 0D;
            btactivity.IconVisible = true;
            btactivity.IconZoom = 40D;
            btactivity.IsTab = true;
            btactivity.Location = new Point(0, 0);
            btactivity.Margin = new Padding(4, 3, 4, 3);
            btactivity.Name = "btactivity";
            btactivity.Normalcolor = Color.White;
            btactivity.OnHovercolor = Color.NavajoWhite;
            btactivity.OnHoverTextColor = Color.White;
            btactivity.selected = false;
            btactivity.Size = new Size(218, 30);
            btactivity.TabIndex = 3;
            btactivity.Text = "Activity Log";
            btactivity.TextAlign = ContentAlignment.MiddleLeft;
            btactivity.Textcolor = Color.Gray;
            btactivity.TextFont = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btactivity.Click += btactivity_Click;
            // 
            // btDatabase
            // 
            btDatabase.Animated = true;
            btDatabase.BorderRadius = 8;
            btDatabase.CustomizableEdges = customizableEdges3;
            btDatabase.DisabledState.BorderColor = Color.DarkGray;
            btDatabase.DisabledState.CustomBorderColor = Color.DarkGray;
            btDatabase.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btDatabase.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btDatabase.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btDatabase.Dock = DockStyle.Top;
            btDatabase.FillColor = Color.FromArgb(224, 224, 224);
            btDatabase.FillColor2 = Color.FromArgb(224, 224, 224);
            btDatabase.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btDatabase.ForeColor = Color.DimGray;
            btDatabase.Image = (Image)resources.GetObject("btDatabase.Image");
            btDatabase.ImageAlign = HorizontalAlignment.Left;
            btDatabase.ImageSize = new Size(25, 25);
            btDatabase.Location = new Point(0, 0);
            btDatabase.Name = "btDatabase";
            btDatabase.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btDatabase.Size = new Size(218, 40);
            btDatabase.TabIndex = 9;
            btDatabase.Text = "DATABASE";
            btDatabase.Click += btDatabase_Click;
            // 
            // cbbSimLo
            // 
            cbbSimLo.Dock = DockStyle.Bottom;
            cbbSimLo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSimLo.FormattingEnabled = true;
            cbbSimLo.Items.AddRange(new object[] { "STB", "STS", "TKM-S-" });
            cbbSimLo.Location = new Point(0, 539);
            cbbSimLo.Name = "cbbSimLo";
            cbbSimLo.Size = new Size(218, 29);
            cbbSimLo.TabIndex = 8;
            cbbSimLo.SelectedIndexChanged += cbbSimLo_SelectedIndexChanged;
            // 
            // panel6
            // 
            panel6.Controls.Add(picLogo);
            panel6.Controls.Add(lbName2);
            panel6.Controls.Add(lbName1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(218, 152);
            panel6.TabIndex = 19;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(82, 3);
            picLogo.Margin = new Padding(2, 3, 2, 3);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(78, 73);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 18;
            picLogo.TabStop = false;
            // 
            // lbName2
            // 
            lbName2.AutoSize = true;
            lbName2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbName2.ForeColor = Color.FromArgb(64, 64, 64);
            lbName2.Location = new Point(7, 104);
            lbName2.Margin = new Padding(2, 0, 2, 0);
            lbName2.Name = "lbName2";
            lbName2.Size = new Size(209, 16);
            lbName2.TabIndex = 10;
            lbName2.Text = "Operation Breakdown Analysis";
            // 
            // lbName1
            // 
            lbName1.AutoSize = true;
            lbName1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbName1.ForeColor = Color.FromArgb(64, 64, 64);
            lbName1.Location = new Point(68, 79);
            lbName1.Margin = new Padding(2, 0, 2, 0);
            lbName1.Name = "lbName1";
            lbName1.Size = new Size(102, 25);
            lbName1.TabIndex = 9;
            lbName1.Text = "Similarity";
            // 
            // pnCenter
            // 
            pnCenter.Controls.Add(panel4);
            pnCenter.Dock = DockStyle.Fill;
            pnCenter.Location = new Point(218, 10);
            pnCenter.Name = "pnCenter";
            pnCenter.Size = new Size(1274, 720);
            pnCenter.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1274, 720);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(tabform);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1274, 720);
            panel5.TabIndex = 0;
            // 
            // tabform
            // 
            tabform.Controls.Add(tabPage2);
            tabform.Dock = DockStyle.Fill;
            tabform.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabform.ItemSize = new Size(61, 30);
            tabform.Location = new Point(0, 0);
            tabform.Name = "tabform";
            tabform.SelectedIndex = 0;
            tabform.Size = new Size(1274, 720);
            tabform.TabIndex = 4;
            tabform.DrawItem += tabform_DrawItem;
            tabform.MouseClick += tabform_MouseClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(pnGenerator);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1266, 682);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnGenerator
            // 
            pnGenerator.Controls.Add(panel22);
            pnGenerator.Dock = DockStyle.Fill;
            pnGenerator.ForeColor = Color.Black;
            pnGenerator.Location = new Point(3, 3);
            pnGenerator.Name = "pnGenerator";
            pnGenerator.Size = new Size(1260, 676);
            pnGenerator.TabIndex = 0;
            // 
            // panel22
            // 
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(0, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(1260, 43);
            panel22.TabIndex = 17;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 730);
            Controls.Add(pnCenter);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            FormClosing += HomePage_FormClosing;
            FormClosed += HomePage_FormClosed;
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btminimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)btClose).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            pnDatabase.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnCenter.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tabform.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            pnGenerator.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnCenter;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private Panel panel3;
        private PictureBox btClose;
        private PictureBox btminimize;
        private TextBox tbStyle;
        private Panel panel4;
        private Panel panel5;
        private TabControl tabform;
        private TabPage tabPage2;
        private Panel pnGenerator;
        private Panel panel22;
        private Label lbName2;
        private Label lbName1;
        private Panel panel7;
        private Panel panel6;
        private PictureBox picLogo;
        private Bunifu.Framework.UI.BunifuFlatButton btAllStyle;
        private Bunifu.Framework.UI.BunifuFlatButton btactivity;
        private Bunifu.Framework.UI.BunifuFlatButton btSimStyle;
        private Bunifu.Framework.UI.BunifuFlatButton btNewStyle;
        private ComboBox cbbSimLo;
        private Guna.UI2.WinForms.Guna2GradientButton btDatabase;
        private Panel pnDatabase;
    }
}