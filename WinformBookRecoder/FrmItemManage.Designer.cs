namespace WinformBookRecoder
{
    partial class FrmItemManage
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_item_code = new System.Windows.Forms.TextBox();
            this.txt_item_name = new System.Windows.Forms.TextBox();
            this.btn_item_new = new System.Windows.Forms.Button();
            this.btn_item_clear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_item_delete = new System.Windows.Forms.Button();
            this.btn_item_save = new System.Windows.Forms.Button();
            this.cm_item_type = new System.Windows.Forms.ComboBox();
            this.Itemlist = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(147, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(163, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "名目信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "——————————————————————";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(30, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(30, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(404, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "——————————————————————";
            // 
            // txt_item_code
            // 
            this.txt_item_code.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_item_code.Location = new System.Drawing.Point(132, 246);
            this.txt_item_code.Name = "txt_item_code";
            this.txt_item_code.Size = new System.Drawing.Size(300, 39);
            this.txt_item_code.TabIndex = 8;
            // 
            // txt_item_name
            // 
            this.txt_item_name.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_item_name.Location = new System.Drawing.Point(132, 324);
            this.txt_item_name.Name = "txt_item_name";
            this.txt_item_name.Size = new System.Drawing.Size(300, 39);
            this.txt_item_name.TabIndex = 9;
            // 
            // btn_item_new
            // 
            this.btn_item_new.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_item_new.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_item_new.Location = new System.Drawing.Point(52, 435);
            this.btn_item_new.Name = "btn_item_new";
            this.btn_item_new.Size = new System.Drawing.Size(153, 63);
            this.btn_item_new.TabIndex = 10;
            this.btn_item_new.Text = "新增";
            this.btn_item_new.UseVisualStyleBackColor = false;
            this.btn_item_new.Click += new System.EventHandler(this.btn_item_new_Click);
            // 
            // btn_item_clear
            // 
            this.btn_item_clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_item_clear.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_item_clear.Location = new System.Drawing.Point(264, 435);
            this.btn_item_clear.Name = "btn_item_clear";
            this.btn_item_clear.Size = new System.Drawing.Size(153, 63);
            this.btn_item_clear.TabIndex = 11;
            this.btn_item_clear.Text = "清空";
            this.btn_item_clear.UseVisualStyleBackColor = false;
            this.btn_item_clear.Click += new System.EventHandler(this.btn_item_clear_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(503, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 28);
            this.label8.TabIndex = 12;
            this.label8.Text = "名目列表：";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(503, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(760, 50);
            this.label9.TabIndex = 14;
            this.label9.Text = "编号    类型    名称";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_item_delete
            // 
            this.btn_item_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_item_delete.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_item_delete.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_item_delete.Location = new System.Drawing.Point(1083, 12);
            this.btn_item_delete.Name = "btn_item_delete";
            this.btn_item_delete.Size = new System.Drawing.Size(153, 63);
            this.btn_item_delete.TabIndex = 15;
            this.btn_item_delete.Text = "删除";
            this.btn_item_delete.UseVisualStyleBackColor = false;
            this.btn_item_delete.Click += new System.EventHandler(this.btn_item_delete_Click);
            // 
            // btn_item_save
            // 
            this.btn_item_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_item_save.BackColor = System.Drawing.Color.Snow;
            this.btn_item_save.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_item_save.Location = new System.Drawing.Point(905, 12);
            this.btn_item_save.Name = "btn_item_save";
            this.btn_item_save.Size = new System.Drawing.Size(153, 63);
            this.btn_item_save.TabIndex = 16;
            this.btn_item_save.Text = "保存";
            this.btn_item_save.UseVisualStyleBackColor = false;
            this.btn_item_save.Click += new System.EventHandler(this.btn_item_save_Click);
            // 
            // cm_item_type
            // 
            this.cm_item_type.Font = new System.Drawing.Font("宋体", 16F);
            this.cm_item_type.FormattingEnabled = true;
            this.cm_item_type.Location = new System.Drawing.Point(132, 173);
            this.cm_item_type.Name = "cm_item_type";
            this.cm_item_type.Size = new System.Drawing.Size(300, 41);
            this.cm_item_type.TabIndex = 17;
            // 
            // Itemlist
            // 
            this.Itemlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Itemlist.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Itemlist.FormattingEnabled = true;
            this.Itemlist.ItemHeight = 28;
            this.Itemlist.Location = new System.Drawing.Point(504, 140);
            this.Itemlist.Name = "Itemlist";
            this.Itemlist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.Itemlist.Size = new System.Drawing.Size(759, 676);
            this.Itemlist.TabIndex = 18;
            this.Itemlist.SelectedIndexChanged += new System.EventHandler(this.Itemlist_SelectedIndexChanged);
            // 
            // FrmItemManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 826);
            this.Controls.Add(this.Itemlist);
            this.Controls.Add(this.cm_item_type);
            this.Controls.Add(this.btn_item_save);
            this.Controls.Add(this.btn_item_delete);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_item_clear);
            this.Controls.Add(this.btn_item_new);
            this.Controls.Add(this.txt_item_name);
            this.Controls.Add(this.txt_item_code);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmItemManage";
            this.Text = "记账助手 名目维护";
            this.Load += new System.EventHandler(this.FrmItemManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_item_code;
        private System.Windows.Forms.TextBox txt_item_name;
        private System.Windows.Forms.Button btn_item_new;
        private System.Windows.Forms.Button btn_item_clear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_item_delete;
        private System.Windows.Forms.Button btn_item_save;
        private System.Windows.Forms.ComboBox cm_item_type;
        private System.Windows.Forms.ListBox Itemlist;
    }
}