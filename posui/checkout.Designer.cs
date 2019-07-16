namespace posui
{
    partial class checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkout));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.titlelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbItemDescription = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQtyOnHand = new System.Windows.Forms.TextBox();
            this.tblCheckOut = new System.Windows.Forms.DataGridView();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemoveItems = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titlelbl.Location = new System.Drawing.Point(425, 21);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(219, 39);
            this.titlelbl.TabIndex = 1;
            this.titlelbl.Text = "CHECKOUT";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Namelbl.Location = new System.Drawing.Point(186, 86);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(153, 24);
            this.Namelbl.TabIndex = 3;
            this.Namelbl.Text = "Customer Mobile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(186, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(614, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(615, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order date";
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(345, 90);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerMobile.TabIndex = 4;
            this.txtCustomerMobile.Click += new System.EventHandler(this.TxtCustomerMobile_Click);
            this.txtCustomerMobile.Enter += new System.EventHandler(this.TxtCustomerMobile_Enter);
            this.txtCustomerMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCustomerMobile_KeyDown);
            this.txtCustomerMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCustomerMobile_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(345, 130);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(727, 86);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(156, 20);
            this.txtOrderID.TabIndex = 4;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(727, 134);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(156, 20);
            this.txtOrderDate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(332, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Code";
            // 
            // cmbItemDescription
            // 
            this.cmbItemDescription.FormattingEnabled = true;
            this.cmbItemDescription.Location = new System.Drawing.Point(57, 200);
            this.cmbItemDescription.Name = "cmbItemDescription";
            this.cmbItemDescription.Size = new System.Drawing.Size(224, 21);
            this.cmbItemDescription.TabIndex = 5;
            this.cmbItemDescription.SelectedIndexChanged += new System.EventHandler(this.CmbItemCode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(116, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(838, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(489, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Qty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(489, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "Unit Price";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(632, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Qty on Hand";
            this.label9.Click += new System.EventHandler(this.Label8_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(800, 201);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(121, 20);
            this.txtQty.TabIndex = 6;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(304, 203);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = true;
            this.txtItemCode.Size = new System.Drawing.Size(152, 20);
            this.txtItemCode.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(484, 202);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.Location = new System.Drawing.Point(628, 203);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.ReadOnly = true;
            this.txtQtyOnHand.Size = new System.Drawing.Size(129, 20);
            this.txtQtyOnHand.TabIndex = 6;
            // 
            // tblCheckOut
            // 
            this.tblCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemcode,
            this.description,
            this.unitprice,
            this.quantity,
            this.total});
            this.tblCheckOut.Location = new System.Drawing.Point(160, 255);
            this.tblCheckOut.MultiSelect = false;
            this.tblCheckOut.Name = "tblCheckOut";
            this.tblCheckOut.Size = new System.Drawing.Size(822, 150);
            this.tblCheckOut.TabIndex = 7;
            // 
            // itemcode
            // 
            this.itemcode.HeaderText = "Item Code";
            this.itemcode.Name = "itemcode";
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "Unit Price";
            this.unitprice.Name = "unitprice";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(704, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(832, 422);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(146, 42);
            this.txtTotalAmount.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::posui.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(943, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 49);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Image = global::posui.Properties.Resources.icons8_search_26;
            this.btnCustomerSearch.Location = new System.Drawing.Point(510, 79);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(33, 31);
            this.btnCustomerSearch.TabIndex = 12;
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
            this.btnCustomerSearch.Visible = false;
            this.btnCustomerSearch.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.ActiveBorderThickness = 1;
            this.btnPlaceOrder.ActiveCornerRadius = 20;
            this.btnPlaceOrder.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.btnPlaceOrder.ActiveForecolor = System.Drawing.Color.White;
            this.btnPlaceOrder.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlaceOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaceOrder.BackgroundImage")));
            this.btnPlaceOrder.ButtonText = "Place Order";
            this.btnPlaceOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnPlaceOrder.IdleBorderThickness = 1;
            this.btnPlaceOrder.IdleCornerRadius = 20;
            this.btnPlaceOrder.IdleFillColor = System.Drawing.Color.White;
            this.btnPlaceOrder.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlaceOrder.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPlaceOrder.Location = new System.Drawing.Point(846, 605);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(119, 41);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPlaceOrder.Click += new System.EventHandler(this.BtnCheckoutPrint_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.ActiveBorderThickness = 1;
            this.btnRemoveItems.ActiveCornerRadius = 20;
            this.btnRemoveItems.ActiveFillColor = System.Drawing.Color.Red;
            this.btnRemoveItems.ActiveForecolor = System.Drawing.Color.White;
            this.btnRemoveItems.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveItems.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRemoveItems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveItems.BackgroundImage")));
            this.btnRemoveItems.ButtonText = "Remove Item";
            this.btnRemoveItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnRemoveItems.IdleBorderThickness = 1;
            this.btnRemoveItems.IdleCornerRadius = 20;
            this.btnRemoveItems.IdleFillColor = System.Drawing.Color.White;
            this.btnRemoveItems.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveItems.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRemoveItems.Location = new System.Drawing.Point(160, 432);
            this.btnRemoveItems.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(148, 41);
            this.btnRemoveItems.TabIndex = 10;
            this.btnRemoveItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRemoveItems.Click += new System.EventHandler(this.BtnRemoveItems_Click);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(832, 481);
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(146, 42);
            this.txtCash.TabIndex = 15;
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCash_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(704, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cash";
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(832, 542);
            this.txtBalance.Multiline = true;
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(146, 42);
            this.txtBalance.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(704, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Balance";
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1140, 660);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.tblCheckOut);
            this.Controls.Add(this.txtItemCode);
            this.Controls.Add(this.txtQtyOnHand);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cmbItemDescription);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerMobile);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.titlelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkout";
            this.Text = "checkout";
            ((System.ComponentModel.ISupportInitialize)(this.tblCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQtyOnHand;
        private System.Windows.Forms.DataGridView tblCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveItems;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPlaceOrder;
        private System.Windows.Forms.ComboBox cmbItemDescription;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label12;
    }
}