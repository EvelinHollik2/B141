﻿namespace WindowsFormsAppTagdij
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox_tagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.textBox_orsz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_szulev = new System.Windows.Forms.NumericUpDown();
            this.label_ = new System.Windows.Forms.Label();
            this.numericUpDown_irszam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_azon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_tagok
            // 
            this.listBox_tagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_tagok.FormattingEnabled = true;
            this.listBox_tagok.ItemHeight = 20;
            this.listBox_tagok.Location = new System.Drawing.Point(0, 0);
            this.listBox_tagok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_tagok.Name = "listBox_tagok";
            this.listBox_tagok.Size = new System.Drawing.Size(177, 566);
            this.listBox_tagok.TabIndex = 0;
            this.listBox_tagok.SelectedIndexChanged += new System.EventHandler(this.listBox_tagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox_orsz);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown_szulev);
            this.groupBox1.Controls.Add(this.label_);
            this.groupBox1.Controls.Add(this.numericUpDown_irszam);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_nev);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_azon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(177, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(424, 566);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiválasztott tag";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.button_delete);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.button_insert);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 223);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Műveletek";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete.Location = new System.Drawing.Point(8, 142);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(398, 36);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Törlés";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_update.Location = new System.Drawing.Point(8, 100);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(398, 36);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Módosítás";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(8, 58);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(398, 36);
            this.button_insert.TabIndex = 0;
            this.button_insert.Text = "Létrehozás";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // textBox_orsz
            // 
            this.textBox_orsz.Location = new System.Drawing.Point(11, 298);
            this.textBox_orsz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_orsz.Name = "textBox_orsz";
            this.textBox_orsz.Size = new System.Drawing.Size(100, 26);
            this.textBox_orsz.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Országkód";
            // 
            // numericUpDown_szulev
            // 
            this.numericUpDown_szulev.Location = new System.Drawing.Point(11, 232);
            this.numericUpDown_szulev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_szulev.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown_szulev.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown_szulev.Name = "numericUpDown_szulev";
            this.numericUpDown_szulev.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_szulev.TabIndex = 7;
            this.numericUpDown_szulev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_szulev.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label_
            // 
            this.label_.AutoSize = true;
            this.label_.Location = new System.Drawing.Point(7, 209);
            this.label_.Name = "label_";
            this.label_.Size = new System.Drawing.Size(94, 20);
            this.label_.TabIndex = 6;
            this.label_.Text = "Születési év";
            // 
            // numericUpDown_irszam
            // 
            this.numericUpDown_irszam.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Location = new System.Drawing.Point(11, 171);
            this.numericUpDown_irszam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_irszam.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_irszam.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_irszam.Name = "numericUpDown_irszam";
            this.numericUpDown_irszam.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_irszam.TabIndex = 5;
            this.numericUpDown_irszam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_irszam.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Irányítószám";
            // 
            // textBox_nev
            // 
            this.textBox_nev.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox_nev.Location = new System.Drawing.Point(11, 106);
            this.textBox_nev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(244, 26);
            this.textBox_nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // textBox_azon
            // 
            this.textBox_azon.Location = new System.Drawing.Point(11, 50);
            this.textBox_azon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_azon.Name = "textBox_azon";
            this.textBox_azon.ReadOnly = true;
            this.textBox_azon.Size = new System.Drawing.Size(100, 26);
            this.textBox_azon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_tagok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Tagok nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_szulev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_irszam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_tagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_azon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_;
        private System.Windows.Forms.NumericUpDown numericUpDown_irszam;
        private System.Windows.Forms.TextBox textBox_orsz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_szulev;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_insert;
    }
}

