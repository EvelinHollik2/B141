namespace Login
{
    partial class Form_TermekModositas
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
            this.button_termekModositas = new System.Windows.Forms.Button();
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_termek = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék módosítás:";
            // 
            // button_termekModositas
            // 
            this.button_termekModositas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_termekModositas.Location = new System.Drawing.Point(268, 353);
            this.button_termekModositas.Name = "button_termekModositas";
            this.button_termekModositas.Size = new System.Drawing.Size(245, 43);
            this.button_termekModositas.TabIndex = 1;
            this.button_termekModositas.Text = "Módosítás";
            this.button_termekModositas.UseVisualStyleBackColor = true;
            this.button_termekModositas.Click += new System.EventHandler(this.button_termekModositas_Click);
            // 
            // listBox_termek
            // 
            this.listBox_termek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.ItemHeight = 29;
            this.listBox_termek.Location = new System.Drawing.Point(18, 63);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(215, 352);
            this.listBox_termek.TabIndex = 2;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(264, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kiválasztott termék";
            // 
            // textBox_termek
            // 
            this.textBox_termek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_termek.Location = new System.Drawing.Point(268, 88);
            this.textBox_termek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_termek.Name = "textBox_termek";
            this.textBox_termek.Size = new System.Drawing.Size(180, 35);
            this.textBox_termek.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(264, 131);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Darabszám:";
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_db.Location = new System.Drawing.Point(268, 156);
            this.numericUpDown_db.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(180, 35);
            this.numericUpDown_db.TabIndex = 11;
            // 
            // Form_TermekModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_termek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_db);
            this.Controls.Add(this.listBox_termek);
            this.Controls.Add(this.button_termekModositas);
            this.Controls.Add(this.label1);
            this.Name = "Form_TermekModositas";
            this.Text = "Form_TermekModositas";
            this.Load += new System.EventHandler(this.Form_TermekModositas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_termekModositas;
        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_termek;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
    }
}