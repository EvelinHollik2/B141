namespace WindowsFormsApp_OrarendNyilvantartas
{
    partial class Form_Login
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
            this.button_bejelentkezes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FelhasznaloNev = new System.Windows.Forms.TextBox();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_bejelentkezes
            // 
            this.button_bejelentkezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_bejelentkezes.Location = new System.Drawing.Point(17, 173);
            this.button_bejelentkezes.Name = "button_bejelentkezes";
            this.button_bejelentkezes.Size = new System.Drawing.Size(164, 39);
            this.button_bejelentkezes.TabIndex = 1;
            this.button_bejelentkezes.Text = "Bejelentkezés";
            this.button_bejelentkezes.UseVisualStyleBackColor = true;
            this.button_bejelentkezes.Click += new System.EventHandler(this.button_bejelentkezes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználó név:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó:";
            // 
            // textBox_FelhasznaloNev
            // 
            this.textBox_FelhasznaloNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_FelhasznaloNev.Location = new System.Drawing.Point(16, 40);
            this.textBox_FelhasznaloNev.Name = "textBox_FelhasznaloNev";
            this.textBox_FelhasznaloNev.Size = new System.Drawing.Size(165, 26);
            this.textBox_FelhasznaloNev.TabIndex = 5;
            this.textBox_FelhasznaloNev.Text = "Lajos";
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_jelszo.Location = new System.Drawing.Point(16, 98);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(165, 26);
            this.textBox_jelszo.TabIndex = 6;
            this.textBox_jelszo.Text = "1234";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 263);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.textBox_FelhasznaloNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_bejelentkezes);
            this.Name = "Form_Login";
            this.Text = "Bejelentkezes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_bejelentkezes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FelhasznaloNev;
        private System.Windows.Forms.TextBox textBox_jelszo;
    }
}

