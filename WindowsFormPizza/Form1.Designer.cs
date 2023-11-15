namespace WindowsFormPizza
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_pizza = new System.Windows.Forms.ListBox();
            this.button_kivalaszt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_kezoenz = new System.Windows.Forms.RadioButton();
            this.radioButton_bankkartya = new System.Windows.Forms.RadioButton();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.listView_termekek = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_db = new System.Windows.Forms.TextBox();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.button_atlag = new System.Windows.Forms.Button();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzák:";
            // 
            // listBox_pizza
            // 
            this.listBox_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_pizza.FormattingEnabled = true;
            this.listBox_pizza.ItemHeight = 20;
            this.listBox_pizza.Location = new System.Drawing.Point(15, 35);
            this.listBox_pizza.Name = "listBox_pizza";
            this.listBox_pizza.Size = new System.Drawing.Size(213, 204);
            this.listBox_pizza.TabIndex = 1;
            // 
            // button_kivalaszt
            // 
            this.button_kivalaszt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_kivalaszt.Location = new System.Drawing.Point(16, 265);
            this.button_kivalaszt.Name = "button_kivalaszt";
            this.button_kivalaszt.Size = new System.Drawing.Size(103, 36);
            this.button_kivalaszt.TabIndex = 2;
            this.button_kivalaszt.Text = "Kiválasztás";
            this.button_kivalaszt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_bankkartya);
            this.groupBox1.Controls.Add(this.radioButton_kezoenz);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(586, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mivel szeretne fizetni?";
            // 
            // radioButton_kezoenz
            // 
            this.radioButton_kezoenz.AutoSize = true;
            this.radioButton_kezoenz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_kezoenz.Location = new System.Drawing.Point(7, 20);
            this.radioButton_kezoenz.Name = "radioButton_kezoenz";
            this.radioButton_kezoenz.Size = new System.Drawing.Size(89, 24);
            this.radioButton_kezoenz.TabIndex = 0;
            this.radioButton_kezoenz.TabStop = true;
            this.radioButton_kezoenz.Text = "Kézpénz";
            this.radioButton_kezoenz.UseVisualStyleBackColor = true;
            // 
            // radioButton_bankkartya
            // 
            this.radioButton_bankkartya.AutoSize = true;
            this.radioButton_bankkartya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_bankkartya.Location = new System.Drawing.Point(7, 44);
            this.radioButton_bankkartya.Name = "radioButton_bankkartya";
            this.radioButton_bankkartya.Size = new System.Drawing.Size(107, 24);
            this.radioButton_bankkartya.TabIndex = 1;
            this.radioButton_bankkartya.TabStop = true;
            this.radioButton_bankkartya.Text = "Bankkártya";
            this.radioButton_bankkartya.UseVisualStyleBackColor = true;
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_szamla.Location = new System.Drawing.Point(593, 131);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(160, 24);
            this.checkBox_szamla.TabIndex = 4;
            this.checkBox_szamla.Text = "Szeretnék számlát";
            this.checkBox_szamla.UseVisualStyleBackColor = true;
            // 
            // listView_termekek
            // 
            this.listView_termekek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView_termekek.HideSelection = false;
            this.listView_termekek.Location = new System.Drawing.Point(301, 35);
            this.listView_termekek.Name = "listView_termekek";
            this.listView_termekek.Size = new System.Drawing.Size(208, 252);
            this.listView_termekek.TabIndex = 5;
            this.listView_termekek.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kérem számmal írja be hogy hány darabot szeretne:";
            // 
            // textBox_db
            // 
            this.textBox_db.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_db.Location = new System.Drawing.Point(15, 353);
            this.textBox_db.Name = "textBox_db";
            this.textBox_db.Size = new System.Drawing.Size(86, 26);
            this.textBox_db.TabIndex = 7;
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaad.Location = new System.Drawing.Point(121, 348);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(103, 36);
            this.button_hozzaad.TabIndex = 8;
            this.button_hozzaad.Text = "Hozzáadás";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            // 
            // button_rendeles
            // 
            this.button_rendeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rendeles.Location = new System.Drawing.Point(460, 385);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(172, 36);
            this.button_rendeles.TabIndex = 9;
            this.button_rendeles.Text = "Le adom a rendelést";
            this.button_rendeles.UseVisualStyleBackColor = true;
            // 
            // button_atlag
            // 
            this.button_atlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_atlag.Location = new System.Drawing.Point(125, 265);
            this.button_atlag.Name = "button_atlag";
            this.button_atlag.Size = new System.Drawing.Size(103, 36);
            this.button_atlag.TabIndex = 10;
            this.button_atlag.Text = "Átlag";
            this.button_atlag.UseVisualStyleBackColor = true;
            // 
            // button_betoltes
            // 
            this.button_betoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_betoltes.Location = new System.Drawing.Point(77, 5);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(87, 28);
            this.button_betoltes.TabIndex = 11;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            this.button_betoltes.Click += new System.EventHandler(this.button_betoltes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.button_atlag);
            this.Controls.Add(this.button_rendeles);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.textBox_db);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView_termekek);
            this.Controls.Add(this.checkBox_szamla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_kivalaszt);
            this.Controls.Add(this.listBox_pizza);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_pizza;
        private System.Windows.Forms.Button button_kivalaszt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_bankkartya;
        private System.Windows.Forms.RadioButton radioButton_kezoenz;
        private System.Windows.Forms.CheckBox checkBox_szamla;
        private System.Windows.Forms.ListView listView_termekek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_db;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.Button button_atlag;
        private System.Windows.Forms.Button button_betoltes;
    }
}

