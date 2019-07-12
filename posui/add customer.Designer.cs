namespace posui
{
    partial class add_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_user));
            this.adduser = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.titlelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.niclbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.mobilelbl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.addUserAddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addUserUpdatelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tblViewCustomer = new System.Windows.Forms.DataGridView();
            this.nicColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addUserDeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addUserCancalBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tblViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // adduser
            // 
            this.adduser.ElipseRadius = 5;
            this.adduser.TargetControl = this;
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titlelbl.Location = new System.Drawing.Point(425, 57);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(403, 39);
            this.titlelbl.TabIndex = 0;
            this.titlelbl.Text = "ADD NEW CUSTOMER";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Namelbl.Location = new System.Drawing.Point(180, 206);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(61, 24);
            this.Namelbl.TabIndex = 2;
            this.Namelbl.Text = "Name";
            // 
            // niclbl
            // 
            this.niclbl.AutoSize = true;
            this.niclbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.niclbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.niclbl.Location = new System.Drawing.Point(180, 248);
            this.niclbl.Name = "niclbl";
            this.niclbl.Size = new System.Drawing.Size(41, 24);
            this.niclbl.TabIndex = 2;
            this.niclbl.Text = "NIC";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addresslbl.Location = new System.Drawing.Point(180, 290);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(80, 24);
            this.addresslbl.TabIndex = 2;
            this.addresslbl.Text = "Address";
            // 
            // mobilelbl
            // 
            this.mobilelbl.AutoSize = true;
            this.mobilelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobilelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mobilelbl.Location = new System.Drawing.Point(180, 362);
            this.mobilelbl.Name = "mobilelbl";
            this.mobilelbl.Size = new System.Drawing.Size(72, 24);
            this.mobilelbl.TabIndex = 2;
            this.mobilelbl.Text = "Mobile ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(318, 208);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(318, 250);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(171, 20);
            this.txtNIC.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(318, 292);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 44);
            this.txtAddress.TabIndex = 6;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(318, 364);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(171, 20);
            this.txtMobile.TabIndex = 7;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Add";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(588, 707);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkCyan;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(159, 70);
            this.bunifuFlatButton1.TabIndex = 8;
            this.bunifuFlatButton1.Text = "Add";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Cancal";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(774, 707);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(159, 70);
            this.bunifuFlatButton2.TabIndex = 8;
            this.bunifuFlatButton2.Text = "Cancal";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Reset";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(957, 707);
            this.bunifuFlatButton4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.DarkTurquoise;
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(159, 70);
            this.bunifuFlatButton4.TabIndex = 8;
            this.bunifuFlatButton4.Text = "Reset";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // addUserAddBtn
            // 
            this.addUserAddBtn.ActiveBorderThickness = 1;
            this.addUserAddBtn.ActiveCornerRadius = 20;
            this.addUserAddBtn.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.addUserAddBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addUserAddBtn.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUserAddBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addUserAddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUserAddBtn.BackgroundImage")));
            this.addUserAddBtn.ButtonText = "Add";
            this.addUserAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserAddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserAddBtn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.addUserAddBtn.IdleBorderThickness = 1;
            this.addUserAddBtn.IdleCornerRadius = 20;
            this.addUserAddBtn.IdleFillColor = System.Drawing.Color.White;
            this.addUserAddBtn.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserAddBtn.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserAddBtn.Location = new System.Drawing.Point(318, 460);
            this.addUserAddBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addUserAddBtn.Name = "addUserAddBtn";
            this.addUserAddBtn.Size = new System.Drawing.Size(103, 41);
            this.addUserAddBtn.TabIndex = 9;
            this.addUserAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addUserAddBtn.Click += new System.EventHandler(this.AddUserAddBtn_Click);
            // 
            // addUserUpdatelBtn
            // 
            this.addUserUpdatelBtn.ActiveBorderThickness = 1;
            this.addUserUpdatelBtn.ActiveCornerRadius = 20;
            this.addUserUpdatelBtn.ActiveFillColor = System.Drawing.Color.Green;
            this.addUserUpdatelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addUserUpdatelBtn.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUserUpdatelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addUserUpdatelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUserUpdatelBtn.BackgroundImage")));
            this.addUserUpdatelBtn.ButtonText = "Update";
            this.addUserUpdatelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserUpdatelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserUpdatelBtn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.addUserUpdatelBtn.IdleBorderThickness = 1;
            this.addUserUpdatelBtn.IdleCornerRadius = 20;
            this.addUserUpdatelBtn.IdleFillColor = System.Drawing.Color.White;
            this.addUserUpdatelBtn.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserUpdatelBtn.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserUpdatelBtn.Location = new System.Drawing.Point(450, 460);
            this.addUserUpdatelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addUserUpdatelBtn.Name = "addUserUpdatelBtn";
            this.addUserUpdatelBtn.Size = new System.Drawing.Size(103, 41);
            this.addUserUpdatelBtn.TabIndex = 9;
            this.addUserUpdatelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addUserUpdatelBtn.Click += new System.EventHandler(this.AddUserUpdatelBtn_Click);
            // 
            // tblViewCustomer
            // 
            this.tblViewCustomer.AllowUserToAddRows = false;
            this.tblViewCustomer.AllowUserToDeleteRows = false;
            this.tblViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nicColumn,
            this.nameColumn,
            this.addressColumn,
            this.mobileColumn});
            this.tblViewCustomer.Location = new System.Drawing.Point(642, 159);
            this.tblViewCustomer.Name = "tblViewCustomer";
            this.tblViewCustomer.ReadOnly = true;
            this.tblViewCustomer.Size = new System.Drawing.Size(444, 236);
            this.tblViewCustomer.TabIndex = 10;
            this.tblViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblViewCustomer_CellClick);
            // 
            // nicColumn
            // 
            this.nicColumn.HeaderText = "NIC";
            this.nicColumn.Name = "nicColumn";
            this.nicColumn.ReadOnly = true;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            // 
            // addressColumn
            // 
            this.addressColumn.HeaderText = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.ReadOnly = true;
            // 
            // mobileColumn
            // 
            this.mobileColumn.HeaderText = "Mobile";
            this.mobileColumn.Name = "mobileColumn";
            this.mobileColumn.ReadOnly = true;
            // 
            // addUserDeleteBtn
            // 
            this.addUserDeleteBtn.ActiveBorderThickness = 1;
            this.addUserDeleteBtn.ActiveCornerRadius = 20;
            this.addUserDeleteBtn.ActiveFillColor = System.Drawing.Color.Gold;
            this.addUserDeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addUserDeleteBtn.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUserDeleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addUserDeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUserDeleteBtn.BackgroundImage")));
            this.addUserDeleteBtn.ButtonText = "Delete";
            this.addUserDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserDeleteBtn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.addUserDeleteBtn.IdleBorderThickness = 1;
            this.addUserDeleteBtn.IdleCornerRadius = 20;
            this.addUserDeleteBtn.IdleFillColor = System.Drawing.Color.White;
            this.addUserDeleteBtn.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserDeleteBtn.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserDeleteBtn.Location = new System.Drawing.Point(581, 460);
            this.addUserDeleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addUserDeleteBtn.Name = "addUserDeleteBtn";
            this.addUserDeleteBtn.Size = new System.Drawing.Size(103, 41);
            this.addUserDeleteBtn.TabIndex = 9;
            this.addUserDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addUserDeleteBtn.Click += new System.EventHandler(this.AddUserDeleteBtn_Click);
            // 
            // addUserCancalBtn
            // 
            this.addUserCancalBtn.ActiveBorderThickness = 1;
            this.addUserCancalBtn.ActiveCornerRadius = 20;
            this.addUserCancalBtn.ActiveFillColor = System.Drawing.Color.DarkRed;
            this.addUserCancalBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addUserCancalBtn.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addUserCancalBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addUserCancalBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addUserCancalBtn.BackgroundImage")));
            this.addUserCancalBtn.ButtonText = "Cancel";
            this.addUserCancalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUserCancalBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserCancalBtn.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.addUserCancalBtn.IdleBorderThickness = 1;
            this.addUserCancalBtn.IdleCornerRadius = 20;
            this.addUserCancalBtn.IdleFillColor = System.Drawing.Color.White;
            this.addUserCancalBtn.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserCancalBtn.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.addUserCancalBtn.Location = new System.Drawing.Point(712, 460);
            this.addUserCancalBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addUserCancalBtn.Name = "addUserCancalBtn";
            this.addUserCancalBtn.Size = new System.Drawing.Size(103, 41);
            this.addUserCancalBtn.TabIndex = 9;
            this.addUserCancalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1140, 660);
            this.Controls.Add(this.tblViewCustomer);
            this.Controls.Add(this.addUserCancalBtn);
            this.Controls.Add(this.addUserDeleteBtn);
            this.Controls.Add(this.addUserUpdatelBtn);
            this.Controls.Add(this.addUserAddBtn);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.mobilelbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.niclbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.titlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "add_user";
            this.Text = "add_user";
            this.Load += new System.EventHandler(this.add_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblViewCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse adduser;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label mobilelbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label niclbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtName;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 addUserAddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addUserUpdatelBtn;
        private System.Windows.Forms.DataGridView tblViewCustomer;
        private Bunifu.Framework.UI.BunifuThinButton2 addUserCancalBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addUserDeleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileColumn;
    }
}