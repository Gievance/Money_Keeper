namespace WinformBookRecoder
{
    partial class FrmIncomeManage
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
            this.btn_income_clear = new System.Windows.Forms.Button();
            this.btn_income_new = new System.Windows.Forms.Button();
            this.txt_income_desc = new System.Windows.Forms.TextBox();
            this.txt_income_code = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_income_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_income_save = new System.Windows.Forms.Button();
            this.btn_income_delete = new System.Windows.Forms.Button();
            this.txt_income_desc2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_income_price2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_income_none = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_income_allrecord = new System.Windows.Forms.Button();
            this.btn_income_query = new System.Windows.Forms.Button();
            this.cbx_income_name2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_income_name = new System.Windows.Forms.ComboBox();
            this.LV = new System.Windows.Forms.ListView();
            this.cid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cdesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_income_clear
            // 
            this.btn_income_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_income_clear.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_income_clear.Location = new System.Drawing.Point(356, 556);
            this.btn_income_clear.Name = "btn_income_clear";
            this.btn_income_clear.Size = new System.Drawing.Size(204, 84);
            this.btn_income_clear.TabIndex = 23;
            this.btn_income_clear.Text = "清空";
            this.btn_income_clear.UseVisualStyleBackColor = false;
            this.btn_income_clear.Click += new System.EventHandler(this.btn_income_clear_Click);
            // 
            // btn_income_new
            // 
            this.btn_income_new.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_income_new.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_income_new.Location = new System.Drawing.Point(91, 556);
            this.btn_income_new.Name = "btn_income_new";
            this.btn_income_new.Size = new System.Drawing.Size(204, 84);
            this.btn_income_new.TabIndex = 22;
            this.btn_income_new.Text = "新增";
            this.btn_income_new.UseVisualStyleBackColor = false;
            this.btn_income_new.Click += new System.EventHandler(this.btn_income_new_Click);
            // 
            // txt_income_desc
            // 
            this.txt_income_desc.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income_desc.Location = new System.Drawing.Point(190, 356);
            this.txt_income_desc.Name = "txt_income_desc";
            this.txt_income_desc.Size = new System.Drawing.Size(400, 39);
            this.txt_income_desc.TabIndex = 21;
            // 
            // txt_income_code
            // 
            this.txt_income_code.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income_code.Location = new System.Drawing.Point(190, 279);
            this.txt_income_code.Name = "txt_income_code";
            this.txt_income_code.Size = new System.Drawing.Size(400, 39);
            this.txt_income_code.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(61, 486);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(538, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "——————————————————————";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(65, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "描述：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(65, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "编号：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(65, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "名目：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(538, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "——————————————————————";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(147, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "收入记录";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(135, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = " ";
            // 
            // txt_income_price
            // 
            this.txt_income_price.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income_price.Location = new System.Drawing.Point(190, 428);
            this.txt_income_price.Name = "txt_income_price";
            this.txt_income_price.Size = new System.Drawing.Size(400, 39);
            this.txt_income_price.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(65, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "金额：";
            // 
            // btn_income_save
            // 
            this.btn_income_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_income_save.BackColor = System.Drawing.Color.Snow;
            this.btn_income_save.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_income_save.Location = new System.Drawing.Point(1605, 272);
            this.btn_income_save.Name = "btn_income_save";
            this.btn_income_save.Size = new System.Drawing.Size(108, 48);
            this.btn_income_save.TabIndex = 30;
            this.btn_income_save.Text = "保存";
            this.btn_income_save.UseVisualStyleBackColor = false;
            this.btn_income_save.Click += new System.EventHandler(this.btn_income_save_Click);
            // 
            // btn_income_delete
            // 
            this.btn_income_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_income_delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_income_delete.Font = new System.Drawing.Font("宋体", 14F);
            this.btn_income_delete.Location = new System.Drawing.Point(1728, 272);
            this.btn_income_delete.Name = "btn_income_delete";
            this.btn_income_delete.Size = new System.Drawing.Size(114, 48);
            this.btn_income_delete.TabIndex = 29;
            this.btn_income_delete.Text = "删除";
            this.btn_income_delete.UseVisualStyleBackColor = false;
            this.btn_income_delete.Click += new System.EventHandler(this.btn_income_delete_Click);
            // 
            // txt_income_desc2
            // 
            this.txt_income_desc2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income_desc2.Location = new System.Drawing.Point(872, 58);
            this.txt_income_desc2.Name = "txt_income_desc2";
            this.txt_income_desc2.Size = new System.Drawing.Size(256, 39);
            this.txt_income_desc2.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(770, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 31;
            this.label9.Text = "描述：";
            // 
            // txt_income_price2
            // 
            this.txt_income_price2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income_price2.Location = new System.Drawing.Point(872, 148);
            this.txt_income_price2.Name = "txt_income_price2";
            this.txt_income_price2.Size = new System.Drawing.Size(256, 39);
            this.txt_income_price2.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(770, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 28);
            this.label11.TabIndex = 33;
            this.label11.Text = "金额：";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(1177, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 28);
            this.label12.TabIndex = 35;
            this.label12.Text = "名目：";
            // 
            // txt_income_none
            // 
            this.txt_income_none.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_income_none.Location = new System.Drawing.Point(1279, 148);
            this.txt_income_none.Name = "txt_income_none";
            this.txt_income_none.Size = new System.Drawing.Size(281, 39);
            this.txt_income_none.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(1204, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 28);
            this.label13.TabIndex = 37;
            this.label13.Text = "-";
            // 
            // btn_income_allrecord
            // 
            this.btn_income_allrecord.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_income_allrecord.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_income_allrecord.Location = new System.Drawing.Point(1615, 44);
            this.btn_income_allrecord.Name = "btn_income_allrecord";
            this.btn_income_allrecord.Size = new System.Drawing.Size(183, 64);
            this.btn_income_allrecord.TabIndex = 39;
            this.btn_income_allrecord.Text = "所有记录";
            this.btn_income_allrecord.UseVisualStyleBackColor = false;
            this.btn_income_allrecord.Click += new System.EventHandler(this.btn_income_allrecord_Click);
            // 
            // btn_income_query
            // 
            this.btn_income_query.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_income_query.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_income_query.Location = new System.Drawing.Point(1615, 137);
            this.btn_income_query.Name = "btn_income_query";
            this.btn_income_query.Size = new System.Drawing.Size(183, 64);
            this.btn_income_query.TabIndex = 40;
            this.btn_income_query.Text = "查询";
            this.btn_income_query.UseVisualStyleBackColor = false;
            this.btn_income_query.Click += new System.EventHandler(this.btn_income_query_Click);
            // 
            // cbx_income_name2
            // 
            this.cbx_income_name2.Font = new System.Drawing.Font("宋体", 14F);
            this.cbx_income_name2.FormattingEnabled = true;
            this.cbx_income_name2.Location = new System.Drawing.Point(1279, 58);
            this.cbx_income_name2.Name = "cbx_income_name2";
            this.cbx_income_name2.Size = new System.Drawing.Size(281, 36);
            this.cbx_income_name2.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(736, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(407, 37);
            this.label10.TabIndex = 42;
            this.label10.Text = "收入记录列表：";
            // 
            // cbx_income_name
            // 
            this.cbx_income_name.Font = new System.Drawing.Font("宋体", 14F);
            this.cbx_income_name.FormattingEnabled = true;
            this.cbx_income_name.Location = new System.Drawing.Point(190, 206);
            this.cbx_income_name.Name = "cbx_income_name";
            this.cbx_income_name.Size = new System.Drawing.Size(400, 36);
            this.cbx_income_name.TabIndex = 43;
            // 
            // LV
            // 
            this.LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cid,
            this.cname,
            this.cdesc,
            this.cprice,
            this.ctime});
            this.LV.Font = new System.Drawing.Font("宋体", 14F);
            this.LV.FullRowSelect = true;
            this.LV.GridLines = true;
            this.LV.HideSelection = false;
            this.LV.Location = new System.Drawing.Point(741, 326);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(1101, 566);
            this.LV.TabIndex = 44;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.View = System.Windows.Forms.View.Details;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LvIncome_SelectedIndexChanged);
            // 
            // cid
            // 
            this.cid.Text = "编号";
            this.cid.Width = 100;
            // 
            // cname
            // 
            this.cname.Text = "名目";
            this.cname.Width = 100;
            // 
            // cdesc
            // 
            this.cdesc.Text = "描述";
            this.cdesc.Width = 100;
            // 
            // cprice
            // 
            this.cprice.Text = "金额";
            this.cprice.Width = 100;
            // 
            // ctime
            // 
            this.ctime.Text = "时间";
            this.ctime.Width = 300;
            // 
            // FrmIncomeManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1860, 933);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.cbx_income_name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_income_name2);
            this.Controls.Add(this.btn_income_query);
            this.Controls.Add(this.btn_income_allrecord);
            this.Controls.Add(this.txt_income_none);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_income_price2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_income_desc2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_income_save);
            this.Controls.Add(this.btn_income_delete);
            this.Controls.Add(this.txt_income_price);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_income_clear);
            this.Controls.Add(this.btn_income_new);
            this.Controls.Add(this.txt_income_desc);
            this.Controls.Add(this.txt_income_code);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "FrmIncomeManage";
            this.Text = "FrmIncomeManage";
            this.Load += new System.EventHandler(this.FrmIncomeManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_income_clear;
        private System.Windows.Forms.Button btn_income_new;
        private System.Windows.Forms.TextBox txt_income_desc;
        private System.Windows.Forms.TextBox txt_income_code;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_income_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_income_save;
        private System.Windows.Forms.Button btn_income_delete;
        private System.Windows.Forms.TextBox txt_income_desc2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_income_price2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_income_none;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btn_income_allrecord;
        private System.Windows.Forms.Button btn_income_query;
        private System.Windows.Forms.ComboBox cbx_income_name2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_income_name;
        private System.Windows.Forms.ColumnHeader cid;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.ColumnHeader cname;
        private System.Windows.Forms.ColumnHeader cdesc;
        private System.Windows.Forms.ColumnHeader cprice;
        private System.Windows.Forms.ColumnHeader ctime;
    }
}