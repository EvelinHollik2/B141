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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_bankkartya = new System.Windows.Forms.RadioButton();
            this.radioButton_kezpenz = new System.Windows.Forms.RadioButton();
            this.checkBox_szamla = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_hozzaad = new System.Windows.Forms.Button();
            this.button_rendeles = new System.Windows.Forms.Button();
            this.button_atlag = new System.Windows.Forms.Button();
            this.button_betoltes = new System.Windows.Forms.Button();
            this.numericUpDown_mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.textBox_rendeles = new System.Windows.Forms.TextBox();
            this.textBox_ara = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox_kosar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzák:";
            // 
            // listBox_pizza
            // 
            this.listBox_pizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_pizza.FormattingEnabled = true;
            this.listBox_pizza.ItemHeight = 29;
            this.listBox_pizza.Location = new System.Drawing.Point(22, 54);
            this.listBox_pizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox_pizza.Name = "listBox_pizza";
            this.listBox_pizza.Size = new System.Drawing.Size(373, 294);
            this.listBox_pizza.TabIndex = 1;
            this.listBox_pizza.SelectedIndexChanged += new System.EventHandler(this.listBox_pizza_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_bankkartya);
            this.groupBox1.Controls.Add(this.radioButton_kezpenz);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(879, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(284, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mivel szeretne fizetni?";
            // 
            // radioButton_bankkartya
            // 
            this.radioButton_bankkartya.AutoSize = true;
            this.radioButton_bankkartya.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_bankkartya.Location = new System.Drawing.Point(10, 68);
            this.radioButton_bankkartya.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_bankkartya.Name = "radioButton_bankkartya";
            this.radioButton_bankkartya.Size = new System.Drawing.Size(155, 33);
            this.radioButton_bankkartya.TabIndex = 1;
            this.radioButton_bankkartya.TabStop = true;
            this.radioButton_bankkartya.Text = "Bankkártya";
            this.radioButton_bankkartya.UseVisualStyleBackColor = true;
            // 
            // radioButton_kezpenz
            // 
            this.radioButton_kezpenz.AutoSize = true;
            this.radioButton_kezpenz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_kezpenz.Location = new System.Drawing.Point(10, 31);
            this.radioButton_kezpenz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton_kezpenz.Name = "radioButton_kezpenz";
            this.radioButton_kezpenz.Size = new System.Drawing.Size(131, 33);
            this.radioButton_kezpenz.TabIndex = 0;
            this.radioButton_kezpenz.TabStop = true;
            this.radioButton_kezpenz.Text = "Kézpénz";
            this.radioButton_kezpenz.UseVisualStyleBackColor = true;
            // 
            // checkBox_szamla
            // 
            this.checkBox_szamla.AutoSize = true;
            this.checkBox_szamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox_szamla.Location = new System.Drawing.Point(890, 202);
            this.checkBox_szamla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_szamla.Name = "checkBox_szamla";
            this.checkBox_szamla.Size = new System.Drawing.Size(234, 33);
            this.checkBox_szamla.TabIndex = 4;
            this.checkBox_szamla.Text = "Szeretnék számlát";
            this.checkBox_szamla.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(18, 500);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kérem számmal írja be hogy hány darabot szeretne:";
            // 
            // button_hozzaad
            // 
            this.button_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_hozzaad.Location = new System.Drawing.Point(360, 535);
            this.button_hozzaad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_hozzaad.Name = "button_hozzaad";
            this.button_hozzaad.Size = new System.Drawing.Size(157, 43);
            this.button_hozzaad.TabIndex = 8;
            this.button_hozzaad.Text = "Hozzáadás";
            this.button_hozzaad.UseVisualStyleBackColor = true;
            this.button_hozzaad.Click += new System.EventHandler(this.button_hozzaad_Click);
            // 
            // button_rendeles
            // 
            this.button_rendeles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_rendeles.Location = new System.Drawing.Point(762, 487);
            this.button_rendeles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_rendeles.Name = "button_rendeles";
            this.button_rendeles.Size = new System.Drawing.Size(258, 55);
            this.button_rendeles.TabIndex = 9;
            this.button_rendeles.Text = "Le adom a rendelést";
            this.button_rendeles.UseVisualStyleBackColor = true;
            this.button_rendeles.Click += new System.EventHandler(this.button_rendeles_Click);
            // 
            // button_atlag
            // 
            this.button_atlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_atlag.Location = new System.Drawing.Point(116, 358);
            this.button_atlag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_atlag.Name = "button_atlag";
            this.button_atlag.Size = new System.Drawing.Size(154, 55);
            this.button_atlag.TabIndex = 10;
            this.button_atlag.Text = "Átlag";
            this.button_atlag.UseVisualStyleBackColor = true;
            this.button_atlag.Click += new System.EventHandler(this.button_atlag_Click);
            // 
            // button_betoltes
            // 
            this.button_betoltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_betoltes.Location = new System.Drawing.Point(116, 8);
            this.button_betoltes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_betoltes.Name = "button_betoltes";
            this.button_betoltes.Size = new System.Drawing.Size(130, 43);
            this.button_betoltes.TabIndex = 11;
            this.button_betoltes.Text = "Betöltés";
            this.button_betoltes.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_mennyiseg
            // 
            this.numericUpDown_mennyiseg.Location = new System.Drawing.Point(238, 552);
            this.numericUpDown_mennyiseg.Name = "numericUpDown_mennyiseg";
            this.numericUpDown_mennyiseg.Size = new System.Drawing.Size(78, 26);
            this.numericUpDown_mennyiseg.TabIndex = 12;
            // 
            // textBox_rendeles
            // 
            this.textBox_rendeles.Location = new System.Drawing.Point(69, 551);
            this.textBox_rendeles.Name = "textBox_rendeles";
            this.textBox_rendeles.Size = new System.Drawing.Size(137, 26);
            this.textBox_rendeles.TabIndex = 13;
            // 
            // textBox_ara
            // 
            this.textBox_ara.Location = new System.Drawing.Point(216, 609);
            this.textBox_ara.Name = "textBox_ara";
            this.textBox_ara.Size = new System.Drawing.Size(100, 26);
            this.textBox_ara.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(87, 605);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pizza ára:";
            // 
            // listBox_kosar
            // 
            this.listBox_kosar.FormattingEnabled = true;
            this.listBox_kosar.ItemHeight = 20;
            this.listBox_kosar.Location = new System.Drawing.Point(465, 54);
            this.listBox_kosar.Name = "listBox_kosar";
            this.listBox_kosar.Size = new System.Drawing.Size(346, 344);
            this.listBox_kosar.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.listBox_kosar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ara);
            this.Controls.Add(this.textBox_rendeles);
            this.Controls.Add(this.numericUpDown_mennyiseg);
            this.Controls.Add(this.button_betoltes);
            this.Controls.Add(this.button_atlag);
            this.Controls.Add(this.button_rendeles);
            this.Controls.Add(this.button_hozzaad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox_szamla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_pizza);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_pizza;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_bankkartya;
        private System.Windows.Forms.RadioButton radioButton_kezpenz;
        private System.Windows.Forms.CheckBox checkBox_szamla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_hozzaad;
        private System.Windows.Forms.Button button_rendeles;
        private System.Windows.Forms.Button button_atlag;
        private System.Windows.Forms.Button button_betoltes;
        private System.Windows.Forms.NumericUpDown numericUpDown_mennyiseg;
        private System.Windows.Forms.TextBox textBox_rendeles;
        private System.Windows.Forms.TextBox textBox_ara;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox_kosar;
    }
}

