namespace Login
{
    partial class Form_FelhasznaloUj
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
            this.textBox_felhasznaloNev = new System.Windows.Forms.TextBox();
            this.textBox_Jelszo = new System.Windows.Forms.TextBox();
            this.button_letrehozas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regisztráció";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Felhasználó név:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelszó:";
            // 
            // textBox_felhasznaloNev
            // 
            this.textBox_felhasznaloNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_felhasznaloNev.Location = new System.Drawing.Point(17, 99);
            this.textBox_felhasznaloNev.Name = "textBox_felhasznaloNev";
            this.textBox_felhasznaloNev.Size = new System.Drawing.Size(186, 35);
            this.textBox_felhasznaloNev.TabIndex = 3;
            // 
            // textBox_Jelszo
            // 
            this.textBox_Jelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_Jelszo.Location = new System.Drawing.Point(18, 208);
            this.textBox_Jelszo.Name = "textBox_Jelszo";
            this.textBox_Jelszo.Size = new System.Drawing.Size(185, 35);
            this.textBox_Jelszo.TabIndex = 4;
            // 
            // button_letrehozas
            // 
            this.button_letrehozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_letrehozas.Location = new System.Drawing.Point(17, 297);
            this.button_letrehozas.Name = "button_letrehozas";
            this.button_letrehozas.Size = new System.Drawing.Size(186, 41);
            this.button_letrehozas.TabIndex = 5;
            this.button_letrehozas.Text = "Létrehozás";
            this.button_letrehozas.UseVisualStyleBackColor = true;
            this.button_letrehozas.Click += new System.EventHandler(this.button_letrehozas_Click);
            // 
            // Form_FelhasznaloUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 378);
            this.Controls.Add(this.button_letrehozas);
            this.Controls.Add(this.textBox_Jelszo);
            this.Controls.Add(this.textBox_felhasznaloNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_FelhasznaloUj";
            this.Text = "Form_FelhasznaloUj";
            this.Load += new System.EventHandler(this.Form_FelhasznaloUj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_felhasznaloNev;
        private System.Windows.Forms.TextBox textBox_Jelszo;
        private System.Windows.Forms.Button button_letrehozas;
    }
}