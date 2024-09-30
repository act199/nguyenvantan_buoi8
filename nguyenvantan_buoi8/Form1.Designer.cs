namespace nguyenvantan_buoi8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_IT = new Button();
            btn_biz = new Button();
            txt_ketoan = new TextBox();
            txt_banhang = new TextBox();
            txt_marketting = new TextBox();
            txt_diemcss = new TextBox();
            txt_diemjava = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_IT
            // 
            btn_IT.Location = new Point(168, 286);
            btn_IT.Name = "btn_IT";
            btn_IT.Size = new Size(75, 23);
            btn_IT.TabIndex = 0;
            btn_IT.Text = "SinhVienIT";
            btn_IT.UseVisualStyleBackColor = true;
            btn_IT.Click += btn_IT_Click;
            // 
            // btn_biz
            // 
            btn_biz.Location = new Point(531, 286);
            btn_biz.Name = "btn_biz";
            btn_biz.Size = new Size(89, 23);
            btn_biz.TabIndex = 1;
            btn_biz.Text = "SinhVienBiz";
            btn_biz.UseVisualStyleBackColor = true;
            btn_biz.Click += btn_biz_Click;
            // 
            // txt_ketoan
            // 
            txt_ketoan.Location = new Point(531, 199);
            txt_ketoan.Name = "txt_ketoan";
            txt_ketoan.Size = new Size(100, 23);
            txt_ketoan.TabIndex = 2;
            // 
            // txt_banhang
            // 
            txt_banhang.Location = new Point(531, 257);
            txt_banhang.Name = "txt_banhang";
            txt_banhang.Size = new Size(100, 23);
            txt_banhang.TabIndex = 2;
            // 
            // txt_marketting
            // 
            txt_marketting.Location = new Point(531, 228);
            txt_marketting.Name = "txt_marketting";
            txt_marketting.Size = new Size(100, 23);
            txt_marketting.TabIndex = 2;
            // 
            // txt_diemcss
            // 
            txt_diemcss.Location = new Point(168, 257);
            txt_diemcss.Name = "txt_diemcss";
            txt_diemcss.Size = new Size(100, 23);
            txt_diemcss.TabIndex = 2;
            // 
            // txt_diemjava
            // 
            txt_diemjava.Location = new Point(168, 228);
            txt_diemjava.Name = "txt_diemjava";
            txt_diemjava.Size = new Size(100, 23);
            txt_diemjava.TabIndex = 2;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Location = new Point(118, 233);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 3;
            label1.Text = "Java";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 265);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 3;
            label2.Text = "Css";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 202);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "kế toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 233);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "marketting";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 260);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 3;
            label5.Text = "Bán hàng";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_diemjava);
            Controls.Add(txt_diemcss);
            Controls.Add(txt_marketting);
            Controls.Add(txt_banhang);
            Controls.Add(txt_ketoan);
            Controls.Add(btn_biz);
            Controls.Add(btn_IT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_IT;
        private Button btn_biz;
        private TextBox txt_ketoan;
        private TextBox txt_banhang;
        private TextBox txt_marketting;
        private TextBox txt_diemcss;
        private TextBox txt_diemjava;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
