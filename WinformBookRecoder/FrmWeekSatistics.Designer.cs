namespace WinformBookRecoder
{
    partial class FrmWeekSatistics
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
            this.btn_exp_resatistic = new System.Windows.Forms.Button();
            this.lvweek = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_exp_week = new System.Windows.Forms.Label();
            this.lb_exp_income_week = new System.Windows.Forms.Label();
            this.lb_exp_expand_week = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_exp_resatistic
            // 
            this.btn_exp_resatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exp_resatistic.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_exp_resatistic.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_exp_resatistic.Location = new System.Drawing.Point(796, 155);
            this.btn_exp_resatistic.Name = "btn_exp_resatistic";
            this.btn_exp_resatistic.Size = new System.Drawing.Size(199, 55);
            this.btn_exp_resatistic.TabIndex = 30;
            this.btn_exp_resatistic.Text = "重新统计";
            this.btn_exp_resatistic.UseVisualStyleBackColor = false;
            this.btn_exp_resatistic.Click += new System.EventHandler(this.btn_exp_resatistic_Click);
            // 
            // lvweek
            // 
            this.lvweek.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvweek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5});
            this.lvweek.Font = new System.Drawing.Font("宋体", 16F);
            this.lvweek.GridLines = true;
            this.lvweek.HideSelection = false;
            this.lvweek.Location = new System.Drawing.Point(24, 222);
            this.lvweek.Name = "lvweek";
            this.lvweek.Size = new System.Drawing.Size(971, 776);
            this.lvweek.TabIndex = 29;
            this.lvweek.UseCompatibleStateImageBehavior = false;
            this.lvweek.View = System.Windows.Forms.View.Details;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 16F);
            this.label11.Location = new System.Drawing.Point(18, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 33);
            this.label11.TabIndex = 28;
            this.label11.Text = "周统计数据：";
            // 
            // lb_exp_week
            // 
            this.lb_exp_week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_week.AutoSize = true;
            this.lb_exp_week.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_week.ForeColor = System.Drawing.Color.Green;
            this.lb_exp_week.Location = new System.Drawing.Point(231, 69);
            this.lb_exp_week.Name = "lb_exp_week";
            this.lb_exp_week.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_week.TabIndex = 26;
            this.lb_exp_week.Text = "2000 元";
            // 
            // lb_exp_income_week
            // 
            this.lb_exp_income_week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_income_week.AutoSize = true;
            this.lb_exp_income_week.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_income_week.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_exp_income_week.Location = new System.Drawing.Point(576, 72);
            this.lb_exp_income_week.Name = "lb_exp_income_week";
            this.lb_exp_income_week.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_income_week.TabIndex = 24;
            this.lb_exp_income_week.Text = "2000 元";
            // 
            // lb_exp_expand_week
            // 
            this.lb_exp_expand_week.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_expand_week.AutoSize = true;
            this.lb_exp_expand_week.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_expand_week.ForeColor = System.Drawing.Color.Chocolate;
            this.lb_exp_expand_week.Location = new System.Drawing.Point(867, 72);
            this.lb_exp_expand_week.Name = "lb_exp_expand_week";
            this.lb_exp_expand_week.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_expand_week.TabIndex = 23;
            this.lb_exp_expand_week.Text = "2000 元";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F);
            this.label3.Location = new System.Drawing.Point(761, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "支出：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.Location = new System.Drawing.Point(448, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "收入：";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(50, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "本周收支：";
            // 
            // c1
            // 
            this.c1.Text = "年份";
            this.c1.Width = 100;
            // 
            // c2
            // 
            this.c2.Text = "周数";
            this.c2.Width = 100;
            // 
            // c3
            // 
            this.c3.Text = "周收入";
            this.c3.Width = 150;
            // 
            // c4
            // 
            this.c4.Text = "周支出";
            this.c4.Width = 150;
            // 
            // c5
            // 
            this.c5.Text = "周收益";
            this.c5.Width = 150;
            // 
            // FrmWeekSatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 1010);
            this.Controls.Add(this.btn_exp_resatistic);
            this.Controls.Add(this.lvweek);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_exp_week);
            this.Controls.Add(this.lb_exp_income_week);
            this.Controls.Add(this.lb_exp_expand_week);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmWeekSatistics";
            this.Text = "记账助手 周统计数据";
            this.Load += new System.EventHandler(this.FrmWeekSatistics_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exp_resatistic;
        private System.Windows.Forms.ListView lvweek;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_exp_week;
        private System.Windows.Forms.Label lb_exp_income_week;
        private System.Windows.Forms.Label lb_exp_expand_week;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
        private System.Windows.Forms.ColumnHeader c5;
    }
}