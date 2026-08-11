namespace WinformBookRecoder
{
    partial class FrmPathConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPathConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_config_storepath = new System.Windows.Forms.TextBox();
            this.txt_config_namefile = new System.Windows.Forms.TextBox();
            this.txt_config_incomefile = new System.Windows.Forms.TextBox();
            this.txt_config_outcomefile = new System.Windows.Forms.TextBox();
            this.txt_config_dayfile = new System.Windows.Forms.TextBox();
            this.txt_config_weekfile = new System.Windows.Forms.TextBox();
            this.txt_config_monthfile = new System.Windows.Forms.TextBox();
            this.btn_config_confirm = new System.Windows.Forms.Button();
            this.btn_config_select = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(136, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "存储路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "名目数据文件：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(80, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "收入数据文件：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(80, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "支出数据文件：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(52, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "日统计数据文件：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(52, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "月统计数据文件：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(52, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "周统计数据文件：";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(125, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 604);
            this.panel1.TabIndex = 7;
            // 
            // txt_config_storepath
            // 
            this.txt_config_storepath.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_storepath.Location = new System.Drawing.Point(435, 155);
            this.txt_config_storepath.Name = "txt_config_storepath";
            this.txt_config_storepath.Size = new System.Drawing.Size(417, 35);
            this.txt_config_storepath.TabIndex = 8;
            this.txt_config_storepath.Text = "请选择";
            // 
            // txt_config_namefile
            // 
            this.txt_config_namefile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_namefile.Location = new System.Drawing.Point(435, 230);
            this.txt_config_namefile.Name = "txt_config_namefile";
            this.txt_config_namefile.Size = new System.Drawing.Size(417, 35);
            this.txt_config_namefile.TabIndex = 9;
            // 
            // txt_config_incomefile
            // 
            this.txt_config_incomefile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_incomefile.Location = new System.Drawing.Point(435, 314);
            this.txt_config_incomefile.Name = "txt_config_incomefile";
            this.txt_config_incomefile.Size = new System.Drawing.Size(417, 35);
            this.txt_config_incomefile.TabIndex = 10;
            // 
            // txt_config_outcomefile
            // 
            this.txt_config_outcomefile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_outcomefile.Location = new System.Drawing.Point(435, 403);
            this.txt_config_outcomefile.Name = "txt_config_outcomefile";
            this.txt_config_outcomefile.Size = new System.Drawing.Size(417, 35);
            this.txt_config_outcomefile.TabIndex = 11;
            // 
            // txt_config_dayfile
            // 
            this.txt_config_dayfile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_dayfile.Location = new System.Drawing.Point(435, 483);
            this.txt_config_dayfile.Name = "txt_config_dayfile";
            this.txt_config_dayfile.Size = new System.Drawing.Size(417, 35);
            this.txt_config_dayfile.TabIndex = 12;
            // 
            // txt_config_weekfile
            // 
            this.txt_config_weekfile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_weekfile.Location = new System.Drawing.Point(435, 568);
            this.txt_config_weekfile.Name = "txt_config_weekfile";
            this.txt_config_weekfile.Size = new System.Drawing.Size(417, 35);
            this.txt_config_weekfile.TabIndex = 13;
            // 
            // txt_config_monthfile
            // 
            this.txt_config_monthfile.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_config_monthfile.Location = new System.Drawing.Point(435, 655);
            this.txt_config_monthfile.Name = "txt_config_monthfile";
            this.txt_config_monthfile.Size = new System.Drawing.Size(417, 35);
            this.txt_config_monthfile.TabIndex = 14;
            // 
            // btn_config_confirm
            // 
            this.btn_config_confirm.BackColor = System.Drawing.Color.Orange;
            this.btn_config_confirm.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_config_confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_config_confirm.Location = new System.Drawing.Point(588, 758);
            this.btn_config_confirm.Name = "btn_config_confirm";
            this.btn_config_confirm.Size = new System.Drawing.Size(231, 71);
            this.btn_config_confirm.TabIndex = 15;
            this.btn_config_confirm.Text = "确定";
            this.btn_config_confirm.UseVisualStyleBackColor = false;
            this.btn_config_confirm.Click += new System.EventHandler(this.btn_config_confirm_Click);
            // 
            // btn_config_select
            // 
            this.btn_config_select.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_config_select.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_config_select.Location = new System.Drawing.Point(858, 147);
            this.btn_config_select.Name = "btn_config_select";
            this.btn_config_select.Size = new System.Drawing.Size(150, 53);
            this.btn_config_select.TabIndex = 16;
            this.btn_config_select.Text = "选择..";
            this.btn_config_select.UseVisualStyleBackColor = false;
            this.btn_config_select.Click += new System.EventHandler(this.btn_config_select_Click);
            // 
            // FrmPathConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 917);
            this.Controls.Add(this.btn_config_select);
            this.Controls.Add(this.btn_config_confirm);
            this.Controls.Add(this.txt_config_monthfile);
            this.Controls.Add(this.txt_config_weekfile);
            this.Controls.Add(this.txt_config_dayfile);
            this.Controls.Add(this.txt_config_outcomefile);
            this.Controls.Add(this.txt_config_incomefile);
            this.Controls.Add(this.txt_config_namefile);
            this.Controls.Add(this.txt_config_storepath);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPathConfig";
            this.Text = "记账助手 路径配置";
            this.Load += new System.EventHandler(this.FrmPathConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_config_storepath;
        private System.Windows.Forms.TextBox txt_config_namefile;
        private System.Windows.Forms.TextBox txt_config_incomefile;
        private System.Windows.Forms.TextBox txt_config_outcomefile;
        private System.Windows.Forms.TextBox txt_config_dayfile;
        private System.Windows.Forms.TextBox txt_config_weekfile;
        private System.Windows.Forms.TextBox txt_config_monthfile;
        private System.Windows.Forms.Button btn_config_confirm;
        private System.Windows.Forms.Button btn_config_select;
    }
}