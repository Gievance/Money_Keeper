namespace WinformBookRecoder
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.funcbox = new System.Windows.Forms.GroupBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_year = new System.Windows.Forms.Button();
            this.btn_month = new System.Windows.Forms.Button();
            this.btn_day = new System.Windows.Forms.Button();
            this.btn_outcome = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.btn_store = new System.Windows.Forms.Button();
            this.btn_name = new System.Windows.Forms.Button();
            this.funcbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // funcbox
            // 
            this.funcbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.funcbox.Controls.Add(this.btn_exit);
            this.funcbox.Controls.Add(this.btn_year);
            this.funcbox.Controls.Add(this.btn_month);
            this.funcbox.Controls.Add(this.btn_day);
            this.funcbox.Controls.Add(this.btn_outcome);
            this.funcbox.Controls.Add(this.btn_income);
            this.funcbox.Controls.Add(this.btn_store);
            this.funcbox.Controls.Add(this.btn_name);
            this.funcbox.Dock = System.Windows.Forms.DockStyle.Left;
            this.funcbox.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.funcbox.Location = new System.Drawing.Point(0, 0);
            this.funcbox.Name = "funcbox";
            this.funcbox.Size = new System.Drawing.Size(337, 920);
            this.funcbox.TabIndex = 1;
            this.funcbox.TabStop = false;
            this.funcbox.Text = "功能栏";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_exit.Location = new System.Drawing.Point(64, 745);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(206, 68);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "退出系统";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_year
            // 
            this.btn_year.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_year.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_year.Location = new System.Drawing.Point(64, 598);
            this.btn_year.Name = "btn_year";
            this.btn_year.Size = new System.Drawing.Size(206, 68);
            this.btn_year.TabIndex = 6;
            this.btn_year.Text = "月统计";
            this.btn_year.UseVisualStyleBackColor = true;
            this.btn_year.Click += new System.EventHandler(this.btn_year_Click);
            // 
            // btn_month
            // 
            this.btn_month.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_month.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_month.Location = new System.Drawing.Point(64, 513);
            this.btn_month.Name = "btn_month";
            this.btn_month.Size = new System.Drawing.Size(206, 68);
            this.btn_month.TabIndex = 5;
            this.btn_month.Text = "周统计";
            this.btn_month.UseVisualStyleBackColor = true;
            this.btn_month.Click += new System.EventHandler(this.btn_month_Click);
            // 
            // btn_day
            // 
            this.btn_day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_day.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_day.Location = new System.Drawing.Point(64, 427);
            this.btn_day.Name = "btn_day";
            this.btn_day.Size = new System.Drawing.Size(206, 68);
            this.btn_day.TabIndex = 4;
            this.btn_day.Text = "日统计";
            this.btn_day.UseVisualStyleBackColor = true;
            this.btn_day.Click += new System.EventHandler(this.btn_day_Click);
            // 
            // btn_outcome
            // 
            this.btn_outcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_outcome.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_outcome.Location = new System.Drawing.Point(64, 313);
            this.btn_outcome.Name = "btn_outcome";
            this.btn_outcome.Size = new System.Drawing.Size(206, 68);
            this.btn_outcome.TabIndex = 3;
            this.btn_outcome.Text = "支出管理";
            this.btn_outcome.UseVisualStyleBackColor = true;
            this.btn_outcome.Click += new System.EventHandler(this.btn_outcome_Click);
            // 
            // btn_income
            // 
            this.btn_income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_income.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_income.Location = new System.Drawing.Point(64, 227);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(206, 68);
            this.btn_income.TabIndex = 2;
            this.btn_income.Text = "收入管理";
            this.btn_income.UseVisualStyleBackColor = true;
            this.btn_income.Click += new System.EventHandler(this.btn_income_Click);
            // 
            // btn_store
            // 
            this.btn_store.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_store.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_store.Location = new System.Drawing.Point(64, 141);
            this.btn_store.Name = "btn_store";
            this.btn_store.Size = new System.Drawing.Size(206, 68);
            this.btn_store.TabIndex = 1;
            this.btn_store.Text = "存储路径";
            this.btn_store.UseVisualStyleBackColor = true;
            this.btn_store.Click += new System.EventHandler(this.btn_store_Click);
            // 
            // btn_name
            // 
            this.btn_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_name.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_name.Location = new System.Drawing.Point(64, 54);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(206, 68);
            this.btn_name.TabIndex = 0;
            this.btn_name.Text = "名目维护";
            this.btn_name.UseVisualStyleBackColor = true;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1531, 920);
            this.Controls.Add(this.funcbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "记账助手";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.funcbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox funcbox;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_year;
        private System.Windows.Forms.Button btn_month;
        private System.Windows.Forms.Button btn_day;
        private System.Windows.Forms.Button btn_outcome;
        private System.Windows.Forms.Button btn_income;
        private System.Windows.Forms.Button btn_store;
        private System.Windows.Forms.Button btn_name;
    }
}

