namespace Login
{
    partial class Form_FelhasznaloTorles
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
            this.button_torles = new System.Windows.Forms.Button();
            this.textBox_kivalasztottFelhasznalo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_felhasznalo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_torles
            // 
            this.button_torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_torles.Location = new System.Drawing.Point(318, 318);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(214, 43);
            this.button_torles.TabIndex = 9;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // textBox_kivalasztottFelhasznalo
            // 
            this.textBox_kivalasztottFelhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kivalasztottFelhasznalo.Location = new System.Drawing.Point(318, 120);
            this.textBox_kivalasztottFelhasznalo.Name = "textBox_kivalasztottFelhasznalo";
            this.textBox_kivalasztottFelhasznalo.Size = new System.Drawing.Size(214, 35);
            this.textBox_kivalasztottFelhasznalo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(313, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kiválasztott felhasználó";
            // 
            // listBox_felhasznalo
            // 
            this.listBox_felhasznalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_felhasznalo.FormattingEnabled = true;
            this.listBox_felhasznalo.ItemHeight = 29;
            this.listBox_felhasznalo.Location = new System.Drawing.Point(28, 65);
            this.listBox_felhasznalo.Name = "listBox_felhasznalo";
            this.listBox_felhasznalo.Size = new System.Drawing.Size(232, 352);
            this.listBox_felhasznalo.TabIndex = 6;
            this.listBox_felhasznalo.SelectedIndexChanged += new System.EventHandler(this.listBox_felhasznalo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Felhasználó törlése";
            // 
            // Form_FelhasznaloTorles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.textBox_kivalasztottFelhasznalo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_felhasznalo);
            this.Controls.Add(this.label1);
            this.Name = "Form_FelhasznaloTorles";
            this.Text = "Form_FelhasznaloTorles";
            this.Load += new System.EventHandler(this.Form_FelhasznaloTorles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.TextBox textBox_kivalasztottFelhasznalo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_felhasznalo;
        private System.Windows.Forms.Label label1;
    }
}