namespace Accounting.App.Accounting
{
    partial class frmReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdite = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPirint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RbSettlmentAccount = new System.Windows.Forms.RadioButton();
            this.RbCurrentAccount = new System.Windows.Forms.RadioButton();
            this.RbAllAccount = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtEDate = new System.Windows.Forms.MaskedTextBox();
            this.txtBDate = new System.Windows.Forms.MaskedTextBox();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgReport = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostumerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amuont = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SetlmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiReport = new Stimulsoft.Report.StiReport();
            this.lblSum = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.BtnSettlment = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chTodey = new System.Windows.Forms.CheckBox();
            this.TarikhTasvih = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdite
            // 
            this.btnEdite.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.btnEdite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEdite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdite.Name = "btnEdite";
            this.btnEdite.Size = new System.Drawing.Size(47, 59);
            this.btnEdite.Text = "ویرایش";
            this.btnEdite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdite.Click += new System.EventHandler(this.btnEdite_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 59);
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 59);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdite,
            this.btnDelete,
            this.btnRefresh,
            this.btnPirint,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(575, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPirint
            // 
            this.btnPirint.Image = global::Accounting.App.Properties.Resources._1371476276_Print;
            this.btnPirint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPirint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPirint.Name = "btnPirint";
            this.btnPirint.Size = new System.Drawing.Size(44, 59);
            this.btnPirint.Text = "چاپ";
            this.btnPirint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPirint.Click += new System.EventHandler(this.btnPirint_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtEDate);
            this.groupBox1.Controls.Add(this.txtBDate);
            this.groupBox1.Controls.Add(this.cbCustomer);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RbSettlmentAccount);
            this.groupBox4.Controls.Add(this.RbCurrentAccount);
            this.groupBox4.Controls.Add(this.RbAllAccount);
            this.groupBox4.Location = new System.Drawing.Point(160, 55);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 55);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // RbSettlmentAccount
            // 
            this.RbSettlmentAccount.AutoSize = true;
            this.RbSettlmentAccount.Location = new System.Drawing.Point(110, 20);
            this.RbSettlmentAccount.Name = "RbSettlmentAccount";
            this.RbSettlmentAccount.Size = new System.Drawing.Size(126, 17);
            this.RbSettlmentAccount.TabIndex = 0;
            this.RbSettlmentAccount.TabStop = true;
            this.RbSettlmentAccount.Text = "نمایش تسویه شده ها";
            this.RbSettlmentAccount.UseVisualStyleBackColor = true;
            // 
            // RbCurrentAccount
            // 
            this.RbCurrentAccount.AutoSize = true;
            this.RbCurrentAccount.Location = new System.Drawing.Point(242, 20);
            this.RbCurrentAccount.Name = "RbCurrentAccount";
            this.RbCurrentAccount.Size = new System.Drawing.Size(140, 17);
            this.RbCurrentAccount.TabIndex = 0;
            this.RbCurrentAccount.TabStop = true;
            this.RbCurrentAccount.Text = "نمایش حساب های جاری";
            this.RbCurrentAccount.UseVisualStyleBackColor = true;
            // 
            // RbAllAccount
            // 
            this.RbAllAccount.AutoSize = true;
            this.RbAllAccount.Location = new System.Drawing.Point(6, 20);
            this.RbAllAccount.Name = "RbAllAccount";
            this.RbAllAccount.Size = new System.Drawing.Size(79, 17);
            this.RbAllAccount.TabIndex = 0;
            this.RbAllAccount.TabStop = true;
            this.RbAllAccount.Text = "نمایش همه";
            this.RbAllAccount.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(8, 20);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(57, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "انجام";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtEDate
            // 
            this.txtEDate.Location = new System.Drawing.Point(71, 22);
            this.txtEDate.Mask = "0000/00/00";
            this.txtEDate.Name = "txtEDate";
            this.txtEDate.Size = new System.Drawing.Size(100, 21);
            this.txtEDate.TabIndex = 3;
            // 
            // txtBDate
            // 
            this.txtBDate.Location = new System.Drawing.Point(224, 22);
            this.txtBDate.Mask = "0000/00/00";
            this.txtBDate.Name = "txtBDate";
            this.txtBDate.Size = new System.Drawing.Size(100, 21);
            this.txtBDate.TabIndex = 3;
            // 
            // cbCustomer
            // 
            this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(373, 22);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(102, 21);
            this.cbCustomer.TabIndex = 2;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(177, 20);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(39, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "تا تاریخ:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(330, 20);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "ازتاریخ:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(481, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "طرف حساب:";
            // 
            // dgReport
            // 
            this.dgReport.AllowUserToAddRows = false;
            this.dgReport.AllowUserToDeleteRows = false;
            this.dgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CostumerID,
            this.Amuont,
            this.DateTime,
            this.Description,
            this.Status,
            this.SetlmentDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgReport.Location = new System.Drawing.Point(12, 230);
            this.dgReport.Name = "dgReport";
            this.dgReport.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgReport.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReport.Size = new System.Drawing.Size(551, 220);
            this.dgReport.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // CostumerID
            // 
            this.CostumerID.DataPropertyName = "FullName";
            this.CostumerID.HeaderText = "طرف حساب";
            this.CostumerID.Name = "CostumerID";
            this.CostumerID.ReadOnly = true;
            // 
            // Amuont
            // 
            this.Amuont.DataPropertyName = "Amuont";
            this.Amuont.HeaderText = "مبلغ";
            this.Amuont.Name = "Amuont";
            this.Amuont.ReadOnly = true;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "تاریخ";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "وضعیت";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // SetlmentDate
            // 
            this.SetlmentDate.DataPropertyName = "SettlmentDate";
            this.SetlmentDate.HeaderText = "تاریخ تسویه";
            this.SetlmentDate.Name = "SetlmentDate";
            this.SetlmentDate.ReadOnly = true;
            // 
            // stiReport
            // 
            this.stiReport.CookieContainer = null;
            this.stiReport.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport.ReportAlias = "Report";
            this.stiReport.ReportGuid = "3c8a5ec13fc9416face0398818a85dc7";
            this.stiReport.ReportName = "Report";
            this.stiReport.ReportSource = null;
            this.stiReport.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport.UseProgressInThread = false;
            // 
            // lblSum
            // 
            this.lblSum.BackColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // 
            // 
            this.lblSum.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSum.Location = new System.Drawing.Point(27, 29);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(161, 23);
            this.lblSum.TabIndex = 0;
            this.lblSum.Tag = "0";
            this.lblSum.Text = "0";
            this.lblSum.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(194, 29);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(56, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "مجموع =>";
            // 
            // BtnSettlment
            // 
            this.BtnSettlment.Location = new System.Drawing.Point(188, 24);
            this.BtnSettlment.Name = "BtnSettlment";
            this.BtnSettlment.Size = new System.Drawing.Size(75, 32);
            this.BtnSettlment.TabIndex = 3;
            this.BtnSettlment.Text = "تسویه حساب";
            this.BtnSettlment.UseVisualStyleBackColor = true;
            this.BtnSettlment.Click += new System.EventHandler(this.BtnSettlment_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chTodey);
            this.groupBox2.Controls.Add(this.BtnSettlment);
            this.groupBox2.Controls.Add(this.TarikhTasvih);
            this.groupBox2.Location = new System.Drawing.Point(12, 456);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 68);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // chTodey
            // 
            this.chTodey.AutoSize = true;
            this.chTodey.Location = new System.Drawing.Point(124, 33);
            this.chTodey.Name = "chTodey";
            this.chTodey.Size = new System.Drawing.Size(49, 17);
            this.chTodey.TabIndex = 6;
            this.chTodey.Text = "امروز";
            this.chTodey.UseVisualStyleBackColor = true;
            this.chTodey.CheckedChanged += new System.EventHandler(this.ChTodey_CheckedChanged);
            // 
            // TarikhTasvih
            // 
            this.TarikhTasvih.Location = new System.Drawing.Point(6, 31);
            this.TarikhTasvih.Mask = "0000/00/00";
            this.TarikhTasvih.Name = "TarikhTasvih";
            this.TarikhTasvih.Size = new System.Drawing.Size(100, 21);
            this.TarikhTasvih.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSum);
            this.groupBox3.Controls.Add(this.labelX4);
            this.groupBox3.Location = new System.Drawing.Point(295, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 68);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 536);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReport)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnEdite;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPirint;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtBDate;
        private System.Windows.Forms.ComboBox cbCustomer;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.MaskedTextBox txtEDate;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgReport;
        private Stimulsoft.Report.StiReport stiReport;
        private DevComponents.DotNetBar.LabelX lblSum;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.Button BtnSettlment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox TarikhTasvih;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostumerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amuont;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SetlmentDate;
        private System.Windows.Forms.CheckBox chTodey;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RbSettlmentAccount;
        private System.Windows.Forms.RadioButton RbCurrentAccount;
        private System.Windows.Forms.RadioButton RbAllAccount;
    }
}