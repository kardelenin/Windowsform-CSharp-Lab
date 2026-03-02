namespace Combobox
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_gunseciniz = new System.Windows.Forms.Label();
            this.btn_gunsec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pazartesi ",
            "Salı ",
            "Çarşamba",
            "Perşembe"});
            this.comboBox1.Location = new System.Drawing.Point(305, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_gunseciniz
            // 
            this.lbl_gunseciniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_gunseciniz.Location = new System.Drawing.Point(176, 69);
            this.lbl_gunseciniz.Name = "lbl_gunseciniz";
            this.lbl_gunseciniz.Size = new System.Drawing.Size(100, 23);
            this.lbl_gunseciniz.TabIndex = 1;
            this.lbl_gunseciniz.Text = "Gün Seçiniz :";
            // 
            // btn_gunsec
            // 
            this.btn_gunsec.Location = new System.Drawing.Point(179, 115);
            this.btn_gunsec.Name = "btn_gunsec";
            this.btn_gunsec.Size = new System.Drawing.Size(253, 26);
            this.btn_gunsec.TabIndex = 2;
            this.btn_gunsec.Text = "Gün Seç";
            this.btn_gunsec.UseVisualStyleBackColor = true;
            this.btn_gunsec.Click += new System.EventHandler(this.btn_gunsec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 299);
            this.Controls.Add(this.btn_gunsec);
            this.Controls.Add(this.lbl_gunseciniz);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_gunseciniz;
        private System.Windows.Forms.Button btn_gunsec;
    }
}

