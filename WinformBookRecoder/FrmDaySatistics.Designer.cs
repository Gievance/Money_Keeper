namespace WinformBookRecoder
{
    partial class FrmDaySatistics
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_exp_expand = new System.Windows.Forms.Label();
            this.lb_exp_income = new System.Windows.Forms.Label();
            this.lb_exp_lowexp = new System.Windows.Forms.Label();
            this.lb_exp_day = new System.Windows.Forms.Label();
            this.lb_exp_highexp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvday = new System.Windows.Forms.ListView();
            this.c1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.c4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_exp_resatistic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(48, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日收支：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16F);
            this.label2.Location = new System.Drawing.Point(500, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "收入：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16F);
            this.label3.Location = new System.Drawing.Point(818, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "支出：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16F);
            this.label4.Location = new System.Drawing.Point(16, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "最高日支出：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16F);
            this.label5.Location = new System.Drawing.Point(404, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 33);
            this.label5.TabIndex = 4;
            this.label5.Text = "最低日支出：";
            // 
            // lb_exp_expand
            // 
            this.lb_exp_expand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_expand.AutoSize = true;
            this.lb_exp_expand.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_expand.ForeColor = System.Drawing.Color.Chocolate;
            this.lb_exp_expand.Location = new System.Drawing.Point(924, 76);
            this.lb_exp_expand.Name = "lb_exp_expand";
            this.lb_exp_expand.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_expand.TabIndex = 9;
            this.lb_exp_expand.Text = "2000 元";
            // 
            // lb_exp_income
            // 
            this.lb_exp_income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_income.AutoSize = true;
            this.lb_exp_income.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_income.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_exp_income.Location = new System.Drawing.Point(628, 76);
            this.lb_exp_income.Name = "lb_exp_income";
            this.lb_exp_income.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_income.TabIndex = 10;
            this.lb_exp_income.Text = "2000 元";
            // 
            // lb_exp_lowexp
            // 
            this.lb_exp_lowexp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_lowexp.AutoSize = true;
            this.lb_exp_lowexp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_lowexp.ForeColor = System.Drawing.Color.Green;
            this.lb_exp_lowexp.Location = new System.Drawing.Point(628, 188);
            this.lb_exp_lowexp.Name = "lb_exp_lowexp";
            this.lb_exp_lowexp.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_lowexp.TabIndex = 11;
            this.lb_exp_lowexp.Text = "2000 元";
            // 
            // lb_exp_day
            // 
            this.lb_exp_day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_day.AutoSize = true;
            this.lb_exp_day.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_day.ForeColor = System.Drawing.Color.Green;
            this.lb_exp_day.Location = new System.Drawing.Point(229, 73);
            this.lb_exp_day.Name = "lb_exp_day";
            this.lb_exp_day.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_day.TabIndex = 12;
            this.lb_exp_day.Text = "2000 元";
            // 
            // lb_exp_highexp
            // 
            this.lb_exp_highexp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_exp_highexp.AutoSize = true;
            this.lb_exp_highexp.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exp_highexp.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_exp_highexp.Location = new System.Drawing.Point(229, 191);
            this.lb_exp_highexp.Name = "lb_exp_highexp";
            this.lb_exp_highexp.Size = new System.Drawing.Size(120, 36);
            this.lb_exp_highexp.TabIndex = 13;
            this.lb_exp_highexp.Text = "2000 元";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 16F);
            this.label11.Location = new System.Drawing.Point(16, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 33);
            this.label11.TabIndex = 14;
            this.label11.Text = "日统计数据：";
            // 
            // lvday
            // 
            this.lvday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvday.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4});
            this.lvday.Font = new System.Drawing.Font("宋体", 16F);
            this.lvday.GridLines = true;
            this.lvday.HideSelection = false;
            this.lvday.Location = new System.Drawing.Point(22, 394);
            this.lvday.Name = "lvday";
            this.lvday.Size = new System.Drawing.Size(1030, 612);
            this.lvday.TabIndex = 15;
            this.lvday.UseCompatibleStateImageBehavior = false;
            this.lvday.View = System.Windows.Forms.View.Details;
            // 
            // c1
            // 
            this.c1.Text = "日期";
            this.c1.Width = 200;
            // 
            // c2
            // 
            this.c2.Text = "总收入";
            this.c2.Width = 150;
            // 
            // c3
            // 
            this.c3.Text = "总支出";
            this.c3.Width = 150;
            // 
            // c4
            // 
            this.c4.Text = "总收益";
            this.c4.Width = 150;
            // 
            // btn_exp_resatistic
            // 
            this.btn_exp_resatistic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exp_resatistic.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_exp_resatistic.Font = new System.Drawing.Font("宋体", 16F);
            this.btn_exp_resatistic.Location = new System.Drawing.Point(855, 327);
            this.btn_exp_resatistic.Name = "btn_exp_resatistic";
            this.btn_exp_resatistic.Size = new System.Drawing.Size(199, 55);
            this.btn_exp_resatistic.TabIndex = 17;
            this.btn_exp_resatistic.Text = "重新统计";
            this.btn_exp_resatistic.UseVisualStyleBackColor = false;
            this.btn_exp_resatistic.Click += new System.EventHandler(this.btn_exp_resatistic_Click);
            // 
            // FrmDaySatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 1011);
            this.Controls.Add(this.btn_exp_resatistic);
            this.Controls.Add(this.lvday);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_exp_highexp);
            this.Controls.Add(this.lb_exp_day);
            this.Controls.Add(this.lb_exp_lowexp);
            this.Controls.Add(this.lb_exp_income);
            this.Controls.Add(this.lb_exp_expand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmDaySatistics";
            this.Text = "记账助手 日统计数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_exp_expand;
        private System.Windows.Forms.Label lb_exp_income;
        private System.Windows.Forms.Label lb_exp_lowexp;
        private System.Windows.Forms.Label lb_exp_day;
        private System.Windows.Forms.Label lb_exp_highexp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvday;
        private System.Windows.Forms.Button btn_exp_resatistic;
        private System.Windows.Forms.ColumnHeader c1;
        private System.Windows.Forms.ColumnHeader c2;
        private System.Windows.Forms.ColumnHeader c3;
        private System.Windows.Forms.ColumnHeader c4;
    }
}