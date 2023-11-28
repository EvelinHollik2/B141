namespace Login
{
    partial class Form_Vasarlas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Vasarlas));
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.numericUpDown_db = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_termek = new System.Windows.Forms.TextBox();
            this.listBox_termekek = new System.Windows.Forms.ListBox();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.ItemHeight = 20;
            this.listBox_termek.Location = new System.Drawing.Point(0, 0);
            this.listBox_termek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(224, 475);
            this.listBox_termek.TabIndex = 0;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(247, 155);
            this.numericUpDown_db.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown_db.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Darabszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiválasztott termék";
            // 
            // textBox_termek
            // 
            this.textBox_termek.Location = new System.Drawing.Point(247, 63);
            this.textBox_termek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_termek.Name = "textBox_termek";
            this.textBox_termek.Size = new System.Drawing.Size(180, 26);
            this.textBox_termek.TabIndex = 4;
            // 
            // listBox_termekek
            // 
            this.listBox_termekek.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox_termekek.FormattingEnabled = true;
            this.listBox_termekek.ItemHeight = 20;
            this.listBox_termekek.Location = new System.Drawing.Point(465, 0);
            this.listBox_termekek.Name = "listBox_termekek";
            this.listBox_termekek.Size = new System.Drawing.Size(240, 475);
            this.listBox_termekek.TabIndex = 5;
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(247, 244);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(180, 39);
            this.button_hozzaad.TabIndex = 6;
            this.button_hozzaad.Text = "Hozzáadás";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Össz. ár:";
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(247, 360);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.ReadOnly = true;
            this.textBox_ara.Size = new System.Drawing.Size(100, 26);
            this.textBox_ara.TabIndex = 8;
            // 
            // Form_Vasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 475);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.listBox_termekek);
            this.Controls.Add(this.textBox_termek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_db);
            this.Controls.Add(this.listBox_termek);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Vasarlas";
            this.Text = "Form_Vasarlas";
            this.Load += new System.EventHandler(this.Form_Vasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.NumericUpDown numericUpDown_db;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_termek;
        private System.Windows.Forms.ListBox listBox_termekek;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ara;
    }
}