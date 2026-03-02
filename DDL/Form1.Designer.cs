namespace DDL
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
            this.lbl_birgir = new System.Windows.Forms.Label();
            this.lbl_ikigir = new System.Windows.Forms.Label();
            this.txt_birincisayi = new System.Windows.Forms.TextBox();
            this.txt_ikincisayi = new System.Windows.Forms.TextBox();
            this.btn_topla = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.lbl_yazisonuc = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_birgir
            // 
            this.lbl_birgir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_birgir.Location = new System.Drawing.Point(58, 50);
            this.lbl_birgir.Name = "lbl_birgir";
            this.lbl_birgir.Size = new System.Drawing.Size(114, 23);
            this.lbl_birgir.TabIndex = 0;
            this.lbl_birgir.Text = "1. Sayıyı Giriniz : ";
            // 
            // lbl_ikigir
            // 
            this.lbl_ikigir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikigir.Location = new System.Drawing.Point(58, 76);
            this.lbl_ikigir.Name = "lbl_ikigir";
            this.lbl_ikigir.Size = new System.Drawing.Size(114, 23);
            this.lbl_ikigir.TabIndex = 0;
            this.lbl_ikigir.Text = "2. Sayıyı Giriniz : ";
            // 
            // txt_birincisayi
            // 
            this.txt_birincisayi.Location = new System.Drawing.Point(178, 49);
            this.txt_birincisayi.Name = "txt_birincisayi";
            this.txt_birincisayi.Size = new System.Drawing.Size(100, 20);
            this.txt_birincisayi.TabIndex = 1;
            // 
            // txt_ikincisayi
            // 
            this.txt_ikincisayi.Location = new System.Drawing.Point(178, 75);
            this.txt_ikincisayi.Name = "txt_ikincisayi";
            this.txt_ikincisayi.Size = new System.Drawing.Size(100, 20);
            this.txt_ikincisayi.TabIndex = 1;
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(61, 111);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(48, 39);
            this.btn_topla.TabIndex = 2;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.btn_topla_Click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(115, 111);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(48, 39);
            this.btn_cikar.TabIndex = 2;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.btn_cikar_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(223, 111);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(48, 39);
            this.btn_bol.TabIndex = 2;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(169, 111);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(48, 39);
            this.btn_carp.TabIndex = 2;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // lbl_yazisonuc
            // 
            this.lbl_yazisonuc.AutoSize = true;
            this.lbl_yazisonuc.Location = new System.Drawing.Point(118, 172);
            this.lbl_yazisonuc.Name = "lbl_yazisonuc";
            this.lbl_yazisonuc.Size = new System.Drawing.Size(45, 13);
            this.lbl_yazisonuc.TabIndex = 3;
            this.lbl_yazisonuc.Text = "SONUÇ";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(175, 172);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(14, 13);
            this.lbl_sonuc.TabIndex = 3;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 234);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.lbl_yazisonuc);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.txt_ikincisayi);
            this.Controls.Add(this.txt_birincisayi);
            this.Controls.Add(this.lbl_ikigir);
            this.Controls.Add(this.lbl_birgir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_birgir;
        private System.Windows.Forms.Label lbl_ikigir;
        private System.Windows.Forms.TextBox txt_birincisayi;
        private System.Windows.Forms.TextBox txt_ikincisayi;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Label lbl_yazisonuc;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

