namespace posui
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homepanel = new System.Windows.Forms.Panel();
            this.addCustomerbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.checkoutbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.settingsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportsbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.suppliersbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.inventorybtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.btnSignOut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSignOut.Image = ((System.Drawing.Image)(resources.GetObject("btnSignOut.Image")));
            this.btnSignOut.ImageActive = null;
            this.btnSignOut.Location = new System.Drawing.Point(1315, 0);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(30, 40);
            this.btnSignOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.TabStop = false;
            this.btnSignOut.Zoom = 10;
            this.btnSignOut.Click += new System.EventHandler(this.signoutbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(545, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "JAYANANDA SUPER";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsername.Location = new System.Drawing.Point(1159, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(85, 18);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1129, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homepanel
            // 
            this.homepanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homepanel.Location = new System.Drawing.Point(223, 58);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(1140, 660);
            this.homepanel.TabIndex = 2;
            this.homepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addCustomerbtn
            // 
            this.addCustomerbtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.addCustomerbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addCustomerbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCustomerbtn.BorderRadius = 0;
            this.addCustomerbtn.ButtonText = "Add Customer";
            this.addCustomerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addCustomerbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addCustomerbtn.Iconimage = global::posui.Properties.Resources.user;
            this.addCustomerbtn.Iconimage_right = null;
            this.addCustomerbtn.Iconimage_right_Selected = null;
            this.addCustomerbtn.Iconimage_Selected = null;
            this.addCustomerbtn.IconMarginLeft = 0;
            this.addCustomerbtn.IconMarginRight = 0;
            this.addCustomerbtn.IconRightVisible = true;
            this.addCustomerbtn.IconRightZoom = 0D;
            this.addCustomerbtn.IconVisible = true;
            this.addCustomerbtn.IconZoom = 90D;
            this.addCustomerbtn.IsTab = false;
            this.addCustomerbtn.Location = new System.Drawing.Point(0, 60);
            this.addCustomerbtn.Name = "addCustomerbtn";
            this.addCustomerbtn.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.addCustomerbtn.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.addCustomerbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addCustomerbtn.selected = false;
            this.addCustomerbtn.Size = new System.Drawing.Size(217, 48);
            this.addCustomerbtn.TabIndex = 1;
            this.addCustomerbtn.Text = "Add Customer";
            this.addCustomerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCustomerbtn.Textcolor = System.Drawing.Color.White;
            this.addCustomerbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerbtn.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.checkoutbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkoutbtn.BorderRadius = 0;
            this.checkoutbtn.ButtonText = "Checkout";
            this.checkoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbtn.DisabledColor = System.Drawing.Color.Gray;
            this.checkoutbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.checkoutbtn.Iconimage = global::posui.Properties.Resources.checkout;
            this.checkoutbtn.Iconimage_right = null;
            this.checkoutbtn.Iconimage_right_Selected = null;
            this.checkoutbtn.Iconimage_Selected = null;
            this.checkoutbtn.IconMarginLeft = 0;
            this.checkoutbtn.IconMarginRight = 0;
            this.checkoutbtn.IconRightVisible = true;
            this.checkoutbtn.IconRightZoom = 0D;
            this.checkoutbtn.IconVisible = true;
            this.checkoutbtn.IconZoom = 90D;
            this.checkoutbtn.IsTab = false;
            this.checkoutbtn.Location = new System.Drawing.Point(0, 330);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkoutbtn.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.checkoutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkoutbtn.selected = false;
            this.checkoutbtn.Size = new System.Drawing.Size(217, 48);
            this.checkoutbtn.TabIndex = 1;
            this.checkoutbtn.Text = "Checkout";
            this.checkoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkoutbtn.Textcolor = System.Drawing.Color.White;
            this.checkoutbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbtn.Click += new System.EventHandler(this.Checkoutbtn_Click);
            // 
            // settingsbtn
            // 
            this.settingsbtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.settingsbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsbtn.BorderRadius = 0;
            this.settingsbtn.ButtonText = "Settings";
            this.settingsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.settingsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.settingsbtn.Iconimage = global::posui.Properties.Resources.settings;
            this.settingsbtn.Iconimage_right = null;
            this.settingsbtn.Iconimage_right_Selected = null;
            this.settingsbtn.Iconimage_Selected = null;
            this.settingsbtn.IconMarginLeft = 0;
            this.settingsbtn.IconMarginRight = 0;
            this.settingsbtn.IconRightVisible = true;
            this.settingsbtn.IconRightZoom = 0D;
            this.settingsbtn.IconVisible = true;
            this.settingsbtn.IconZoom = 90D;
            this.settingsbtn.IsTab = false;
            this.settingsbtn.Location = new System.Drawing.Point(0, 276);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.settingsbtn.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.settingsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.settingsbtn.selected = false;
            this.settingsbtn.Size = new System.Drawing.Size(217, 48);
            this.settingsbtn.TabIndex = 1;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsbtn.Textcolor = System.Drawing.Color.White;
            this.settingsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsbtn.Click += new System.EventHandler(this.settingsbtn_Click);
            // 
            // reportsbtn
            // 
            this.reportsbtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.reportsbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reportsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportsbtn.BorderRadius = 0;
            this.reportsbtn.ButtonText = "Reports";
            this.reportsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsbtn.DisabledColor = System.Drawing.Color.Gray;
            this.reportsbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.reportsbtn.Iconimage = global::posui.Properties.Resources.reports;
            this.reportsbtn.Iconimage_right = null;
            this.reportsbtn.Iconimage_right_Selected = null;
            this.reportsbtn.Iconimage_Selected = null;
            this.reportsbtn.IconMarginLeft = 0;
            this.reportsbtn.IconMarginRight = 0;
            this.reportsbtn.IconRightVisible = true;
            this.reportsbtn.IconRightZoom = 0D;
            this.reportsbtn.IconVisible = true;
            this.reportsbtn.IconZoom = 90D;
            this.reportsbtn.IsTab = false;
            this.reportsbtn.Location = new System.Drawing.Point(0, 222);
            this.reportsbtn.Name = "reportsbtn";
            this.reportsbtn.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.reportsbtn.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.reportsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.reportsbtn.selected = false;
            this.reportsbtn.Size = new System.Drawing.Size(217, 48);
            this.reportsbtn.TabIndex = 1;
            this.reportsbtn.Text = "Reports";
            this.reportsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsbtn.Textcolor = System.Drawing.Color.White;
            this.reportsbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // suppliersbtn
            // 
            this.suppliersbtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.suppliersbtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.suppliersbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.suppliersbtn.BorderRadius = 0;
            this.suppliersbtn.ButtonText = "Suppliers";
            this.suppliersbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suppliersbtn.DisabledColor = System.Drawing.Color.Gray;
            this.suppliersbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.suppliersbtn.Iconimage = global::posui.Properties.Resources.supplier;
            this.suppliersbtn.Iconimage_right = null;
            this.suppliersbtn.Iconimage_right_Selected = null;
            this.suppliersbtn.Iconimage_Selected = null;
            this.suppliersbtn.IconMarginLeft = 0;
            this.suppliersbtn.IconMarginRight = 0;
            this.suppliersbtn.IconRightVisible = true;
            this.suppliersbtn.IconRightZoom = 0D;
            this.suppliersbtn.IconVisible = true;
            this.suppliersbtn.IconZoom = 90D;
            this.suppliersbtn.IsTab = false;
            this.suppliersbtn.Location = new System.Drawing.Point(0, 168);
            this.suppliersbtn.Name = "suppliersbtn";
            this.suppliersbtn.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.suppliersbtn.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.suppliersbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.suppliersbtn.selected = false;
            this.suppliersbtn.Size = new System.Drawing.Size(217, 48);
            this.suppliersbtn.TabIndex = 1;
            this.suppliersbtn.Text = "Suppliers";
            this.suppliersbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suppliersbtn.Textcolor = System.Drawing.Color.White;
            this.suppliersbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suppliersbtn.Click += new System.EventHandler(this.suppliersbtn_Click);
            // 
            // inventorybtn
            // 
            this.inventorybtn.Activecolor = System.Drawing.Color.DarkTurquoise;
            this.inventorybtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.inventorybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorybtn.BorderRadius = 0;
            this.inventorybtn.ButtonText = "Inventory";
            this.inventorybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inventorybtn.DisabledColor = System.Drawing.Color.Gray;
            this.inventorybtn.Iconcolor = System.Drawing.Color.Transparent;
            this.inventorybtn.Iconimage = global::posui.Properties.Resources.inventory;
            this.inventorybtn.Iconimage_right = null;
            this.inventorybtn.Iconimage_right_Selected = null;
            this.inventorybtn.Iconimage_Selected = null;
            this.inventorybtn.IconMarginLeft = 0;
            this.inventorybtn.IconMarginRight = 0;
            this.inventorybtn.IconRightVisible = true;
            this.inventorybtn.IconRightZoom = 0D;
            this.inventorybtn.IconVisible = true;
            this.inventorybtn.IconZoom = 90D;
            this.inventorybtn.IsTab = false;
            this.inventorybtn.Location = new System.Drawing.Point(0, 114);
            this.inventorybtn.Name = "inventorybtn";
            this.inventorybtn.Normalcolor = System.Drawing.SystemColors.ControlDarkDark;
            this.inventorybtn.OnHovercolor = System.Drawing.Color.DarkTurquoise;
            this.inventorybtn.OnHoverTextColor = System.Drawing.Color.White;
            this.inventorybtn.selected = false;
            this.inventorybtn.Size = new System.Drawing.Size(217, 48);
            this.inventorybtn.TabIndex = 1;
            this.inventorybtn.Text = "Inventory";
            this.inventorybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventorybtn.Textcolor = System.Drawing.Color.White;
            this.inventorybtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventorybtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1376, 730);
            this.Controls.Add(this.homepanel);
            this.Controls.Add(this.addCustomerbtn);
            this.Controls.Add(this.checkoutbtn);
            this.Controls.Add(this.settingsbtn);
            this.Controls.Add(this.reportsbtn);
            this.Controls.Add(this.suppliersbtn);
            this.Controls.Add(this.inventorybtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSignOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private Bunifu.Framework.UI.BunifuFlatButton addCustomerbtn;
        private Bunifu.Framework.UI.BunifuFlatButton checkoutbtn;
        private Bunifu.Framework.UI.BunifuFlatButton settingsbtn;
        private Bunifu.Framework.UI.BunifuFlatButton reportsbtn;
        private Bunifu.Framework.UI.BunifuFlatButton suppliersbtn;
        private Bunifu.Framework.UI.BunifuFlatButton inventorybtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel homepanel;
        private Bunifu.Framework.UI.BunifuImageButton btnSignOut;
    }
}

