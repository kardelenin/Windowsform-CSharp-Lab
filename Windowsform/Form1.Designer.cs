namespace Windowsform
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_birincinot = new System.Windows.Forms.TextBox();
            this.btn_ortalamaHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ikincinot = new System.Windows.Forms.TextBox();
            this.lbl_ort = new System.Windows.Forms.Label();
            this.lbl_ortsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Notunuzu giriniz :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_birincinot
            // 
            this.txt_birincinot.Location = new System.Drawing.Point(328, 67);
            this.txt_birincinot.Multiline = true;
            this.txt_birincinot.Name = "txt_birincinot";
            this.txt_birincinot.Size = new System.Drawing.Size(178, 31);
            this.txt_birincinot.TabIndex = 1;
            this.txt_birincinot.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_ortalamaHesapla
            // 
            this.btn_ortalamaHesapla.Location = new System.Drawing.Point(119, 167);
            this.btn_ortalamaHesapla.Name = "btn_ortalamaHesapla";
            this.btn_ortalamaHesapla.Size = new System.Drawing.Size(191, 40);
            this.btn_ortalamaHesapla.TabIndex = 2;
            this.btn_ortalamaHesapla.Text = "Ortalamayı Bul";
            this.btn_ortalamaHesapla.UseVisualStyleBackColor = true;
            this.btn_ortalamaHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(114, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "2. Notunuzu giriniz :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_ikincinot
            // 
            this.txt_ikincinot.Location = new System.Drawing.Point(328, 115);
            this.txt_ikincinot.Multiline = true;
            this.txt_ikincinot.Name = "txt_ikincinot";
            this.txt_ikincinot.Size = new System.Drawing.Size(178, 31);
            this.txt_ikincinot.TabIndex = 1;
            this.txt_ikincinot.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_ort
            // 
            this.lbl_ort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ort.Location = new System.Drawing.Point(341, 179);
            this.lbl_ort.Name = "lbl_ort";
            this.lbl_ort.Size = new System.Drawing.Size(93, 28);
            this.lbl_ort.TabIndex = 0;
            this.lbl_ort.Text = "Ortalama :";
            this.lbl_ort.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ortsonuc
            // 
            this.lbl_ortsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ortsonuc.Location = new System.Drawing.Point(440, 179);
            this.lbl_ortsonuc.Name = "lbl_ortsonuc";
            this.lbl_ortsonuc.Size = new System.Drawing.Size(66, 19);
            this.lbl_ortsonuc.TabIndex = 0;
            this.lbl_ortsonuc.Text = "0";
            this.lbl_ortsonuc.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.btn_ortalamaHesapla);
            this.Controls.Add(this.txt_ikincinot);
            this.Controls.Add(this.txt_birincinot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ortsonuc);
            this.Controls.Add(this.lbl_ort);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birincinot;
        private System.Windows.Forms.Button btn_ortalamaHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ikincinot;
        private System.Windows.Forms.Label lbl_ort;
        private System.Windows.Forms.Label lbl_ortsonuc;
    }
}

