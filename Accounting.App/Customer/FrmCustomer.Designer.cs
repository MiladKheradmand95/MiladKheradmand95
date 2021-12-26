namespace Accounting.App
{
    partial class FrmCustomer
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.BtnEditeCustomer = new System.Windows.Forms.ToolStripButton();
            this.BtnDeleteCustomer = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TxtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.DgCustomer = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CustomreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAddCustomer,
            this.BtnEditeCustomer,
            this.BtnDeleteCustomer,
            this.BtnRefresh,
            this.toolStripLabel1,
            this.TxtFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 62);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.BtnAddCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(70, 59);
            this.BtnAddCustomer.Text = "شخص جدید";
            this.BtnAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnEditeCustomer
            // 
            this.BtnEditeCustomer.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.BtnEditeCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnEditeCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditeCustomer.Name = "BtnEditeCustomer";
            this.BtnEditeCustomer.Size = new System.Drawing.Size(83, 59);
            this.BtnEditeCustomer.Text = "ویرایش شخص";
            this.BtnEditeCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnEditeCustomer.Click += new System.EventHandler(this.BtnEditeCustomer_Click);
            // 
            // BtnDeleteCustomer
            // 
            this.BtnDeleteCustomer.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.BtnDeleteCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDeleteCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDeleteCustomer.Name = "BtnDeleteCustomer";
            this.BtnDeleteCustomer.Size = new System.Drawing.Size(72, 59);
            this.BtnDeleteCustomer.Text = "حذف شخص";
            this.BtnDeleteCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnDeleteCustomer.Click += new System.EventHandler(this.BtnDeleteCustomer_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::Accounting.App.Properties.Resources._1371476368_Synchronize;
            this.BtnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(60, 59);
            this.BtnRefresh.Text = "بروزرسانی";
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(44, 59);
            this.toolStripLabel1.Text = "جستجو:";
            // 
            // TxtFilter
            // 
            this.TxtFilter.Name = "TxtFilter";
            this.TxtFilter.Size = new System.Drawing.Size(100, 62);
            this.TxtFilter.TextChanged += new System.EventHandler(this.TxtFilter_TextChanged);
            // 
            // DgCustomer
            // 
            this.DgCustomer.AllowUserToAddRows = false;
            this.DgCustomer.AllowUserToDeleteRows = false;
            this.DgCustomer.AllowUserToResizeColumns = false;
            this.DgCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomreID,
            this.FullName,
            this.Mobile,
            this.Email});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgCustomer.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DgCustomer.Location = new System.Drawing.Point(0, 62);
            this.DgCustomer.Name = "DgCustomer";
            this.DgCustomer.ReadOnly = true;
            this.DgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCustomer.Size = new System.Drawing.Size(627, 414);
            this.DgCustomer.TabIndex = 1;
            // 
            // CustomreID
            // 
            this.CustomreID.DataPropertyName = "CustomerID";
            this.CustomreID.HeaderText = "ردیف";
            this.CustomreID.Name = "CustomreID";
            this.CustomreID.ReadOnly = true;
            this.CustomreID.Visible = false;
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام ونام خانوادگی";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "ایمیل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 476);
            this.Controls.Add(this.DgCustomer);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAddCustomer;
        private System.Windows.Forms.ToolStripButton BtnEditeCustomer;
        private System.Windows.Forms.ToolStripButton BtnDeleteCustomer;
        private System.Windows.Forms.ToolStripButton BtnRefresh;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TxtFilter;
        private DevComponents.DotNetBar.Controls.DataGridViewX DgCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomreID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;


    }
}

