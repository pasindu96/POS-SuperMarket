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
            this.cmbItemCode = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQtyOnHand = new System.Windows.Forms.TextBox();
            this.tblCheckOut = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCustomerSearch = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRemoveItems = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.tblCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titlelbl.Location = new System.Drawing.Point(425, 57);
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
            this.Namelbl.Location = new System.Drawing.Point(186, 148);
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
            this.label1.Location = new System.Drawing.Point(186, 192);
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
            this.label2.Location = new System.Drawing.Point(614, 148);
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
            this.label3.Location = new System.Drawing.Point(615, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order date";
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(345, 152);
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerMobile.TabIndex = 4;
            this.txtCustomerMobile.Click += new System.EventHandler(this.TxtCustomerMobile_Click);
            this.txtCustomerMobile.Enter += new System.EventHandler(this.TxtCustomerMobile_Enter);
            this.txtCustomerMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCustomerMobile_KeyDown);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(345, 192);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(156, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(727, 148);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(156, 20);
            this.txtOrderID.TabIndex = 4;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(727, 196);
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
            this.label4.Location = new System.Drawing.Point(167, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Item Code";
            // 
            // cmbItemCode
            // 
            this.cmbItemCode.FormattingEnabled = true;
            this.cmbItemCode.Location = new System.Drawing.Point(157, 283);
            this.cmbItemCode.Name = "cmbItemCode";
            this.cmbItemCode.Size = new System.Drawing.Size(121, 21);
            this.cmbItemCode.TabIndex = 5;
            this.cmbItemCode.SelectedIndexChanged += new System.EventHandler(this.CmbItemCode_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(308, 258);
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
            this.label6.Location = new System.Drawing.Point(505, 258);
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
            this.label7.Location = new System.Drawing.Point(625, 258);
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
            this.label8.Location = new System.Drawing.Point(625, 258);
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
            this.label9.Location = new System.Drawing.Point(760, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Qty on Hand";
            this.label9.Click += new System.EventHandler(this.Label8_Click);
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(472, 285);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 6;
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Location = new System.Drawing.Point(301, 286);
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = true;
            this.txtItemDescription.Size = new System.Drawing.Size(152, 20);
            this.txtItemDescription.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(620, 285);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 6;
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.Location = new System.Drawing.Point(764, 286);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.ReadOnly = true;
            this.txtQtyOnHand.Size = new System.Drawing.Size(112, 20);
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
            this.tblCheckOut.Location = new System.Drawing.Point(157, 338);
            this.tblCheckOut.Name = "tblCheckOut";
            this.tblCheckOut.Size = new System.Drawing.Size(822, 150);
            this.tblCheckOut.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(704, 522);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(832, 512);
            this.txtTotalAmount.Multiline = true;
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.Size = new System.Drawing.Size(146, 42);
            this.txtTotalAmount.TabIndex = 8;
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
            // btnAdd
            // 
            this.btnAdd.Image = global::posui.Properties.Resources.plus;
            this.btnAdd.Location = new System.Drawing.Point(900, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 49);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnCustomerSearch
            // 
            this.btnCustomerSearch.Image = global::posui.Properties.Resources.icons8_search_26;
            this.btnCustomerSearch.Location = new System.Drawing.Point(510, 141);
            this.btnCustomerSearch.Name = "btnCustomerSearch";
            this.btnCustomerSearch.Size = new System.Drawing.Size(33, 31);
            this.btnCustomerSearch.TabIndex = 12;
            this.btnCustomerSearch.UseVisualStyleBackColor = true;
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
            this.btnPlaceOrder.Location = new System.Drawing.Point(854, 584);
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
            this.btnRemoveItems.ActiveFillColor = System.Drawing.Color.Gold;
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
            this.btnRemoveItems.Location = new System.Drawing.Point(621, 584);
            this.btnRemoveItems.Margin = new System.Windows.Forms.Padding(5);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(148, 41);
            this.btnRemoveItems.TabIndex = 10;
            this.btnRemoveItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1140, 660);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCustomerSearch);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.tblCheckOut);
            this.Controls.Add(this.txtItemDescription);
            this.Controls.Add(this.txtQtyOnHand);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.cmbItemCode);
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
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtQtyOnHand;
        private System.Windows.Forms.DataGridView tblCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRemoveItems;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPlaceOrder;
        private System.Windows.Forms.ComboBox cmbItemCode;
        private System.Windows.Forms.Button btnCustomerSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnAdd;
    }
}