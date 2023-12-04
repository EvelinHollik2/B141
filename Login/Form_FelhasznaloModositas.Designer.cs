namespace Login
{
    partial class Form_FelhasznaloModositas
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kivalaszottFrlhasznalo = new System.Windows.Forms.TextBox();
            this.listBox_felhasznalo = new System.Windows.Forms.ListBox();
            this.button_termekModositas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_jelszo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(258, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kiválasztott felhasználó:";
            // 
            // textBox_kivalaszottFrlhasznalo
            // 
            this.textBox_kivalaszottFrlhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kivalaszottFrlhasznalo.Location = new System.Drawing.Point(262, 99);
            this.textBox_kivalaszottFrlhasznalo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_kivalaszottFrlhasznalo.Name = "textBox_kivalaszottFrlhasznalo";
            this.textBox_kivalaszottFrlhasznalo.Size = new System.Drawing.Size(180, 35);
            this.textBox_kivalaszottFrlhasznalo.TabIndex = 21;
            // 
            // listBox_felhasznalo
            // 
            this.listBox_felhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_felhasznalo.FormattingEnabled = true;
            this.listBox_felhasznalo.ItemHeight = 29;
            this.listBox_felhasznalo.Location = new System.Drawing.Point(12, 65);
            this.listBox_felhasznalo.Name = "listBox_felhasznalo";
            this.listBox_felhasznalo.Size = new System.Drawing.Size(215, 352);
            this.listBox_felhasznalo.TabIndex = 17;
            this.listBox_felhasznalo.SelectedIndexChanged += new System.EventHandler(this.listBox_felhasznalo_SelectedIndexChanged);
            // 
            // button_termekModositas
            // 
            this.button_termekModositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_termekModositas.Location = new System.Drawing.Point(262, 355);
            this.button_termekModositas.Name = "button_termekModositas";
            this.button_termekModositas.Size = new System.Drawing.Size(245, 43);
            this.button_termekModositas.TabIndex = 16;
            this.button_termekModositas.Text = "Módosítás";
            this.button_termekModositas.UseVisualStyleBackColor = true;
            this.button_termekModositas.Click += new System.EventHandler(this.button_termekModositas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Felhasználó módosítás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(259, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Jelszó:";
            // 
            // textBox_jelszo
            // 
            this.textBox_jelszo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_jelszo.Location = new System.Drawing.Point(263, 198);
            this.textBox_jelszo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_jelszo.Name = "textBox_jelszo";
            this.textBox_jelszo.Size = new System.Drawing.Size(180, 35);
            this.textBox_jelszo.TabIndex = 23;
            // 
            // Form_FelhasznaloModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_jelszo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_kivalaszottFrlhasznalo);
            this.Controls.Add(this.listBox_felhasznalo);
            this.Controls.Add(this.button_termekModositas);
            this.Controls.Add(this.label1);
            this.Name = "Form_FelhasznaloModositas";
            this.Text = "Form_FelhasznaloModositas";
            this.Load += new System.EventHandler(this.Form_FelhasznaloModositas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kivalaszottFrlhasznalo;
        private System.Windows.Forms.ListBox listBox_felhasznalo;
        private System.Windows.Forms.Button button_termekModositas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_jelszo;
    }
}