namespace Csharp_Tinhdientichchuvihinhtron
{
    partial class Form1
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
            this.txtR = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnP = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdientich = new System.Windows.Forms.RadioButton();
            this.rdbchuvi = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkdientich = new System.Windows.Forms.CheckBox();
            this.chkchuvi = new System.Windows.Forms.CheckBox();
            this.btntinh1 = new System.Windows.Forms.Button();
            this.btntinh2 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(173, 41);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bán kính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(125, 91);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(75, 23);
            this.btnP.TabIndex = 3;
            this.btnP.Text = "chu vi";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(240, 91);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(75, 23);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "diện tích";
            this.btnS.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdientich);
            this.groupBox2.Controls.Add(this.rdbchuvi);
            this.groupBox2.Location = new System.Drawing.Point(355, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn";
            // 
            // rdbdientich
            // 
            this.rdbdientich.AutoSize = true;
            this.rdbdientich.Location = new System.Drawing.Point(31, 62);
            this.rdbdientich.Name = "rdbdientich";
            this.rdbdientich.Size = new System.Drawing.Size(67, 17);
            this.rdbdientich.TabIndex = 1;
            this.rdbdientich.TabStop = true;
            this.rdbdientich.Text = "diện tích";
            this.rdbdientich.UseVisualStyleBackColor = true;
            // 
            // rdbchuvi
            // 
            this.rdbchuvi.AutoSize = true;
            this.rdbchuvi.Location = new System.Drawing.Point(31, 30);
            this.rdbchuvi.Name = "rdbchuvi";
            this.rdbchuvi.Size = new System.Drawing.Size(54, 17);
            this.rdbchuvi.TabIndex = 0;
            this.rdbchuvi.TabStop = true;
            this.rdbchuvi.Text = "chu vi";
            this.rdbchuvi.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkdientich);
            this.groupBox3.Controls.Add(this.chkchuvi);
            this.groupBox3.Location = new System.Drawing.Point(355, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn";
            // 
            // chkdientich
            // 
            this.chkdientich.AutoSize = true;
            this.chkdientich.Location = new System.Drawing.Point(31, 62);
            this.chkdientich.Name = "chkdientich";
            this.chkdientich.Size = new System.Drawing.Size(68, 17);
            this.chkdientich.TabIndex = 1;
            this.chkdientich.Text = "diện tích";
            this.chkdientich.UseVisualStyleBackColor = true;
            // 
            // chkchuvi
            // 
            this.chkchuvi.AutoSize = true;
            this.chkchuvi.Location = new System.Drawing.Point(31, 30);
            this.chkchuvi.Name = "chkchuvi";
            this.chkchuvi.Size = new System.Drawing.Size(55, 17);
            this.chkchuvi.TabIndex = 0;
            this.chkchuvi.Text = "chu vi";
            this.chkchuvi.UseVisualStyleBackColor = true;
            // 
            // btntinh1
            // 
            this.btntinh1.Location = new System.Drawing.Point(404, 163);
            this.btntinh1.Name = "btntinh1";
            this.btntinh1.Size = new System.Drawing.Size(75, 23);
            this.btntinh1.TabIndex = 7;
            this.btntinh1.Text = "Tính loại 1";
            this.btntinh1.UseVisualStyleBackColor = true;
            this.btntinh1.Click += new System.EventHandler(this.btntinh1_Click);
            // 
            // btntinh2
            // 
            this.btntinh2.Location = new System.Drawing.Point(404, 300);
            this.btntinh2.Name = "btntinh2";
            this.btntinh2.Size = new System.Drawing.Size(75, 23);
            this.btntinh2.TabIndex = 8;
            this.btntinh2.Text = "Tính loại 2";
            this.btntinh2.UseVisualStyleBackColor = true;
            this.btntinh2.Click += new System.EventHandler(this.btntinh2_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(603, 335);
            this.Controls.Add(this.btntinh2);
            this.Controls.Add(this.btntinh1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtR);
            this.Name = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbankinh;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.Label lblbankinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton C;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnchuvi;
        private System.Windows.Forms.Button btndientich;
        private System.Windows.Forms.Label lblketqua;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnP;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbdientich;
        private System.Windows.Forms.RadioButton rdbchuvi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkdientich;
        private System.Windows.Forms.CheckBox chkchuvi;
        private System.Windows.Forms.Button btntinh1;
        private System.Windows.Forms.Button btntinh2;
    }
}

