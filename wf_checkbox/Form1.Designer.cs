namespace wf_checkbox
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
            this.checkbox_cay = new System.Windows.Forms.CheckBox();
            this.checkbox_kahve = new System.Windows.Forms.CheckBox();
            this.checkbox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkbox_pizza = new System.Windows.Forms.CheckBox();
            this.btn_tutarhesapla = new System.Windows.Forms.Button();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkbox_cay
            // 
            this.checkbox_cay.AutoSize = true;
            this.checkbox_cay.Location = new System.Drawing.Point(47, 30);
            this.checkbox_cay.Name = "checkbox_cay";
            this.checkbox_cay.Size = new System.Drawing.Size(75, 17);
            this.checkbox_cay.TabIndex = 0;
            this.checkbox_cay.Text = "Çay 50 TL";
            this.checkbox_cay.UseVisualStyleBackColor = true;
            // 
            // checkbox_kahve
            // 
            this.checkbox_kahve.AutoSize = true;
            this.checkbox_kahve.Location = new System.Drawing.Point(47, 53);
            this.checkbox_kahve.Name = "checkbox_kahve";
            this.checkbox_kahve.Size = new System.Drawing.Size(94, 17);
            this.checkbox_kahve.TabIndex = 1;
            this.checkbox_kahve.Text = "Kahve 200 TL";
            this.checkbox_kahve.UseVisualStyleBackColor = true;
            // 
            // checkbox_hamburger
            // 
            this.checkbox_hamburger.AutoSize = true;
            this.checkbox_hamburger.Location = new System.Drawing.Point(47, 76);
            this.checkbox_hamburger.Name = "checkbox_hamburger";
            this.checkbox_hamburger.Size = new System.Drawing.Size(115, 17);
            this.checkbox_hamburger.TabIndex = 1;
            this.checkbox_hamburger.Text = "Hamburger 300 TL";
            this.checkbox_hamburger.UseVisualStyleBackColor = true;
            // 
            // checkbox_pizza
            // 
            this.checkbox_pizza.AutoSize = true;
            this.checkbox_pizza.Location = new System.Drawing.Point(47, 99);
            this.checkbox_pizza.Name = "checkbox_pizza";
            this.checkbox_pizza.Size = new System.Drawing.Size(88, 17);
            this.checkbox_pizza.TabIndex = 1;
            this.checkbox_pizza.Text = "Pizza 350 TL";
            this.checkbox_pizza.UseVisualStyleBackColor = true;
            // 
            // btn_tutarhesapla
            // 
            this.btn_tutarhesapla.Location = new System.Drawing.Point(47, 122);
            this.btn_tutarhesapla.Name = "btn_tutarhesapla";
            this.btn_tutarhesapla.Size = new System.Drawing.Size(182, 23);
            this.btn_tutarhesapla.TabIndex = 2;
            this.btn_tutarhesapla.Text = "Fiyat Hesapla";
            this.btn_tutarhesapla.UseVisualStyleBackColor = true;
            this.btn_tutarhesapla.Click += new System.EventHandler(this.btn_tutarhesapla_Click);
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tutar.Location = new System.Drawing.Point(133, 159);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(14, 13);
            this.lbl_tutar.TabIndex = 3;
            this.lbl_tutar.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tutar : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.btn_tutarhesapla);
            this.Controls.Add(this.checkbox_pizza);
            this.Controls.Add(this.checkbox_hamburger);
            this.Controls.Add(this.checkbox_kahve);
            this.Controls.Add(this.checkbox_cay);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkbox_cay;
        private System.Windows.Forms.CheckBox checkbox_kahve;
        private System.Windows.Forms.CheckBox checkbox_hamburger;
        private System.Windows.Forms.CheckBox checkbox_pizza;
        private System.Windows.Forms.Button btn_tutarhesapla;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label label2;
    }
}

