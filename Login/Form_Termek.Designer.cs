namespace Login
{
    partial class Form_Termek
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
            this.textBox_hozzaad_nev = new System.Windows.Forms.TextBox();
            this.numericUpDown_hozzaad_db = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_hozzaad_ar = new System.Windows.Forms.NumericUpDown();
            this.button_hozzaad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hozzaad_db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hozzaad_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék hozzáadása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termék:";
            // 
            // textBox_hozzaad_nev
            // 
            this.textBox_hozzaad_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_hozzaad_nev.Location = new System.Drawing.Point(17, 66);
            this.textBox_hozzaad_nev.Name = "textBox_hozzaad_nev";
            this.textBox_hozzaad_nev.Size = new System.Drawing.Size(148, 26);
            this.textBox_hozzaad_nev.TabIndex = 2;
            // 
            // numericUpDown_hozzaad_db
            // 
            this.numericUpDown_hozzaad_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_hozzaad_db.Location = new System.Drawing.Point(16, 128);
            this.numericUpDown_hozzaad_db.Name = "numericUpDown_hozzaad_db";
            this.numericUpDown_hozzaad_db.Size = new System.Drawing.Size(149, 26);
            this.numericUpDown_hozzaad_db.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mennyiség:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ár:";
            // 
            // numericUpDown_hozzaad_ar
            // 
            this.numericUpDown_hozzaad_ar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_hozzaad_ar.Location = new System.Drawing.Point(16, 188);
            this.numericUpDown_hozzaad_ar.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_hozzaad_ar.Minimum = new decimal(new int[] {
            199,
            0,
            0,
            0});
            this.numericUpDown_hozzaad_ar.Name = "numericUpDown_hozzaad_ar";
            this.numericUpDown_hozzaad_ar.Size = new System.Drawing.Size(149, 26);
            this.numericUpDown_hozzaad_ar.TabIndex = 6;
            this.numericUpDown_hozzaad_ar.Value = new decimal(new int[] {
            199,
            0,
            0,
            0});
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaad.Location = new System.Drawing.Point(17, 233);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(149, 34);
            this.button_hozzaad.TabIndex = 7;
            this.button_hozzaad.Text = "Hozzáad";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // Form_Termek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 291);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.numericUpDown_hozzaad_ar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_hozzaad_db);
            this.Controls.Add(this.textBox_hozzaad_nev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Termek";
            this.Text = "Form_Termek";
            this.Load += new System.EventHandler(this.Form_Termek_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hozzaad_db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hozzaad_ar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_hozzaad_nev;
        private System.Windows.Forms.NumericUpDown numericUpDown_hozzaad_db;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_hozzaad_ar;
        private System.Windows.Forms.Button button_hozzaad;
    }
}