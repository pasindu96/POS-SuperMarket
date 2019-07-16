namespace posui
{
    partial class supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(supplier));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierMobile = new System.Windows.Forms.TextBox();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSupplierUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tblSupplier = new System.Windows.Forms.DataGridView();
            this.supplierid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSupplierDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(379, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADD NEW SUPPLIER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(180, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier NIC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(180, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(179, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(179, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(318, 161);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.Size = new System.Drawing.Size(161, 20);
            this.txtSupplierID.TabIndex = 6;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(318, 212);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(161, 20);
            this.txtSupplierName.TabIndex = 7;
            this.txtSupplierName.TextChanged += new System.EventHandler(this.supplierNametxt_TextChanged);
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Location = new System.Drawing.Point(317, 268);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(161, 46);
            this.txtSupplierAddress.TabIndex = 9;
            // 
            // txtSupplierMobile
            // 
            this.txtSupplierMobile.Location = new System.Drawing.Point(317, 349);
            this.txtSupplierMobile.Name = "txtSupplierMobile";
            this.txtSupplierMobile.Size = new System.Drawing.Size(161, 20);
            this.txtSupplierMobile.TabIndex = 10;
            // 
            // btnAddUser
            // 
            this.btnAddUser.ActiveBorderThickness = 1;
            this.btnAddUser.ActiveCornerRadius = 20;
            this.btnAddUser.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.btnAddUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddUser.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.BackgroundImage")));
            this.btnAddUser.ButtonText = "Add";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddUser.IdleBorderThickness = 1;
            this.btnAddUser.IdleCornerRadius = 20;
            this.btnAddUser.IdleFillColor = System.Drawing.Color.White;
            this.btnAddUser.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddUser.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddUser.Location = new System.Drawing.Point(318, 460);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(103, 41);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnSupplierUpdate
            // 
            this.btnSupplierUpdate.ActiveBorderThickness = 1;
            this.btnSupplierUpdate.ActiveCornerRadius = 20;
            this.btnSupplierUpdate.ActiveFillColor = System.Drawing.Color.Green;
            this.btnSupplierUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.btnSupplierUpdate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSupplierUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSupplierUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplierUpdate.BackgroundImage")));
            this.btnSupplierUpdate.ButtonText = "Update";
            this.btnSupplierUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSupplierUpdate.IdleBorderThickness = 1;
            this.btnSupplierUpdate.IdleCornerRadius = 20;
            this.btnSupplierUpdate.IdleFillColor = System.Drawing.Color.White;
            this.btnSupplierUpdate.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupplierUpdate.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupplierUpdate.Location = new System.Drawing.Point(450, 460);
            this.btnSupplierUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupplierUpdate.Name = "btnSupplierUpdate";
            this.btnSupplierUpdate.Size = new System.Drawing.Size(103, 41);
            this.btnSupplierUpdate.TabIndex = 11;
            this.btnSupplierUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupplierUpdate.Click += new System.EventHandler(this.BtnSupplierUpdate_Click);
            // 
            // tblSupplier
            // 
            this.tblSupplier.AllowUserToAddRows = false;
            this.tblSupplier.AllowUserToDeleteRows = false;
            this.tblSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierid,
            this.name,
            this.address,
            this.mobile});
            this.tblSupplier.Location = new System.Drawing.Point(632, 161);
            this.tblSupplier.Name = "tblSupplier";
            this.tblSupplier.ReadOnly = true;
            this.tblSupplier.Size = new System.Drawing.Size(443, 236);
            this.tblSupplier.TabIndex = 12;
            this.tblSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblSupplier_CellClick);
            this.tblSupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblSupplier_CellContentClick);
            // 
            // supplierid
            // 
            this.supplierid.HeaderText = "SupplierID";
            this.supplierid.Name = "supplierid";
            this.supplierid.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "Supplier name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // address
            // 
            this.address.HeaderText = "Supplier Address";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "Supplier mobile";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // btnSupplierDelete
            // 
            this.btnSupplierDelete.ActiveBorderThickness = 1;
            this.btnSupplierDelete.ActiveCornerRadius = 20;
            this.btnSupplierDelete.ActiveFillColor = System.Drawing.Color.Gold;
            this.btnSupplierDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnSupplierDelete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSupplierDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSupplierDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSupplierDelete.BackgroundImage")));
            this.btnSupplierDelete.ButtonText = "Delete";
            this.btnSupplierDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupplierDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplierDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSupplierDelete.IdleBorderThickness = 1;
            this.btnSupplierDelete.IdleCornerRadius = 20;
            this.btnSupplierDelete.IdleFillColor = System.Drawing.Color.White;
            this.btnSupplierDelete.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupplierDelete.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSupplierDelete.Location = new System.Drawing.Point(587, 460);
            this.btnSupplierDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupplierDelete.Name = "btnSupplierDelete";
            this.btnSupplierDelete.Size = new System.Drawing.Size(103, 41);
            this.btnSupplierDelete.TabIndex = 11;
            this.btnSupplierDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSupplierDelete.Click += new System.EventHandler(this.BtnSupplierDelete_Click);
            // 
            // supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1140, 660);
            this.Controls.Add(this.tblSupplier);
            this.Controls.Add(this.btnSupplierDelete);
            this.Controls.Add(this.btnSupplierUpdate);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtSupplierMobile);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supplier";
            this.Text = "supplier";
            ((System.ComponentModel.ISupportInitialize)(this.tblSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierMobile;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierID;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSupplierUpdate;
        private System.Windows.Forms.DataGridView tblSupplier;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSupplierDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierid;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
    }
}