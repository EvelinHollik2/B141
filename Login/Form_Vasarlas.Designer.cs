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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_raktarkeszlet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.termékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasználóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarkeszlet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_termek
            // 
            this.listBox_termek.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.ItemHeight = 20;
            this.listBox_termek.Location = new System.Drawing.Point(0, 24);
            this.listBox_termek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(224, 470);
            this.listBox_termek.TabIndex = 0;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // numericUpDown_db
            // 
            this.numericUpDown_db.Location = new System.Drawing.Point(12, 133);
            this.numericUpDown_db.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDown_db.Name = "numericUpDown_db";
            this.numericUpDown_db.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown_db.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Darabszám:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kiválasztott termék";
            // 
            // textBox_termek
            // 
            this.textBox_termek.Location = new System.Drawing.Point(12, 65);
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
            this.listBox_termekek.Location = new System.Drawing.Point(499, 24);
            this.listBox_termekek.Name = "listBox_termekek";
            this.listBox_termekek.Size = new System.Drawing.Size(316, 470);
            this.listBox_termekek.TabIndex = 5;
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Location = new System.Drawing.Point(12, 278);
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
            this.label3.Location = new System.Drawing.Point(13, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Össz. ár:";
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(12, 385);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.ReadOnly = true;
            this.textBox_ara.Size = new System.Drawing.Size(125, 26);
            this.textBox_ara.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.numericUpDown_raktarkeszlet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_ara);
            this.groupBox1.Controls.Add(this.textBox_termek);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_hozzaad);
            this.groupBox1.Controls.Add(this.numericUpDown_db);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(224, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 470);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Műveletek:";
            // 
            // numericUpDown_raktarkeszlet
            // 
            this.numericUpDown_raktarkeszlet.Location = new System.Drawing.Point(12, 197);
            this.numericUpDown_raktarkeszlet.Name = "numericUpDown_raktarkeszlet";
            this.numericUpDown_raktarkeszlet.ReadOnly = true;
            this.numericUpDown_raktarkeszlet.Size = new System.Drawing.Size(180, 26);
            this.numericUpDown_raktarkeszlet.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raktár készleten:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.termékToolStripMenuItem,
            this.felhasználóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // termékToolStripMenuItem
            // 
            this.termékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem,
            this.törlésToolStripMenuItem,
            this.módosításToolStripMenuItem});
            this.termékToolStripMenuItem.Name = "termékToolStripMenuItem";
            this.termékToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.termékToolStripMenuItem.Text = "Termék";
            // 
            // újToolStripMenuItem
            // 
            this.újToolStripMenuItem.Name = "újToolStripMenuItem";
            this.újToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem.Text = "Új";
            this.újToolStripMenuItem.Click += new System.EventHandler(this.újToolStripMenuItem_Click);
            // 
            // törlésToolStripMenuItem
            // 
            this.törlésToolStripMenuItem.Name = "törlésToolStripMenuItem";
            this.törlésToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem.Text = "Törlés";
            // 
            // felhasználóToolStripMenuItem
            // 
            this.felhasználóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újToolStripMenuItem1,
            this.módosításToolStripMenuItem1,
            this.törlésToolStripMenuItem1});
            this.felhasználóToolStripMenuItem.Name = "felhasználóToolStripMenuItem";
            this.felhasználóToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.felhasználóToolStripMenuItem.Text = "Felhasználó";
            // 
            // módosításToolStripMenuItem
            // 
            this.módosításToolStripMenuItem.Name = "módosításToolStripMenuItem";
            this.módosításToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem.Text = "Módosítás";
            // 
            // újToolStripMenuItem1
            // 
            this.újToolStripMenuItem1.Name = "újToolStripMenuItem1";
            this.újToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.újToolStripMenuItem1.Text = "Új";
            // 
            // módosításToolStripMenuItem1
            // 
            this.módosításToolStripMenuItem1.Name = "módosításToolStripMenuItem1";
            this.módosításToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.módosításToolStripMenuItem1.Text = "Módosítás";
            // 
            // törlésToolStripMenuItem1
            // 
            this.törlésToolStripMenuItem1.Name = "törlésToolStripMenuItem1";
            this.törlésToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.törlésToolStripMenuItem1.Text = "Törlés";
            // 
            // Form_Vasarlas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 494);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_termekek);
            this.Controls.Add(this.listBox_termek);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Vasarlas";
            this.Text = "Form_Vasarlas";
            this.Load += new System.EventHandler(this.Form_Vasarlas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_db)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_raktarkeszlet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_raktarkeszlet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem termékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasználóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem1;
    }
}