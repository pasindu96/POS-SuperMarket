namespace posui
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReport = new System.Windows.Forms.DateTimePicker();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnGetReport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnTimeReport = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtReportPeriod = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(425, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Date";
            // 
            // dtpReport
            // 
            this.dtpReport.Location = new System.Drawing.Point(196, 161);
            this.dtpReport.Name = "dtpReport";
            this.dtpReport.Size = new System.Drawing.Size(200, 20);
            this.dtpReport.TabIndex = 3;
            // 
            // txtReport
            // 
            this.txtReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReport.Location = new System.Drawing.Point(607, 152);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(521, 127);
            this.txtReport.TabIndex = 4;
            // 
            // btnGetReport
            // 
            this.btnGetReport.ActiveBorderThickness = 1;
            this.btnGetReport.ActiveCornerRadius = 20;
            this.btnGetReport.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.btnGetReport.ActiveForecolor = System.Drawing.Color.White;
            this.btnGetReport.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGetReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetReport.BackgroundImage")));
            this.btnGetReport.ButtonText = "Show Report";
            this.btnGetReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReport.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnGetReport.IdleBorderThickness = 1;
            this.btnGetReport.IdleCornerRadius = 20;
            this.btnGetReport.IdleFillColor = System.Drawing.Color.White;
            this.btnGetReport.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGetReport.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGetReport.Location = new System.Drawing.Point(453, 152);
            this.btnGetReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(111, 41);
            this.btnGetReport.TabIndex = 11;
            this.btnGetReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGetReport.Click += new System.EventHandler(this.ReportAddbtn_Click);
            // 
            // btnTimeReport
            // 
            this.btnTimeReport.ActiveBorderThickness = 1;
            this.btnTimeReport.ActiveCornerRadius = 20;
            this.btnTimeReport.ActiveFillColor = System.Drawing.Color.DarkTurquoise;
            this.btnTimeReport.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimeReport.ActiveLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimeReport.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimeReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimeReport.BackgroundImage")));
            this.btnTimeReport.ButtonText = "Show Report in period";
            this.btnTimeReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeReport.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnTimeReport.IdleBorderThickness = 1;
            this.btnTimeReport.IdleCornerRadius = 20;
            this.btnTimeReport.IdleFillColor = System.Drawing.Color.White;
            this.btnTimeReport.IdleForecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTimeReport.IdleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTimeReport.Location = new System.Drawing.Point(438, 345);
            this.btnTimeReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimeReport.Name = "btnTimeReport";
            this.btnTimeReport.Size = new System.Drawing.Size(132, 60);
            this.btnTimeReport.TabIndex = 15;
            this.btnTimeReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimeReport.Click += new System.EventHandler(this.BtnTimeReport_Click);
            // 
            // txtReportPeriod
            // 
            this.txtReportPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReportPeriod.Location = new System.Drawing.Point(607, 336);
            this.txtReportPeriod.Multiline = true;
            this.txtReportPeriod.Name = "txtReportPeriod";
            this.txtReportPeriod.Size = new System.Drawing.Size(521, 127);
            this.txtReportPeriod.TabIndex = 14;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(196, 345);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Start Date";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(196, 390);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "End Date";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1140, 660);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTimeReport);
            this.Controls.Add(this.txtReportPeriod);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.dtpReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "report";
            this.Text = "report";
            this.Load += new System.EventHandler(this.Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReport;
        private System.Windows.Forms.TextBox txtReport;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGetReport;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimeReport;
        private System.Windows.Forms.TextBox txtReportPeriod;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label4;
    }
}