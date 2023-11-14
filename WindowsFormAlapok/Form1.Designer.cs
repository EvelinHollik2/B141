namespace WindowsFormAlapok
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
            this.textBox1_Forrasfajl = new System.Windows.Forms.TextBox();
            this.button1_betoltes = new System.Windows.Forms.Button();
            this.button1_teruletekatlaga = new System.Windows.Forms.Button();
            this.listBox_OrszagokLista = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_szazezerfelett = new System.Windows.Forms.RadioButton();
            this.radioButton_legfeljebbszazezer = new System.Windows.Forms.RadioButton();
            this.button_megszamolas = new System.Windows.Forms.Button();
            this.label_eredmenyszam = new System.Windows.Forms.Label();
            this.textBox_eredmenyszamneve = new System.Windows.Forms.TextBox();
            this.button_kiiras = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_minvagymax = new System.Windows.Forms.Button();
            this.textBox_orszagkereses = new System.Windows.Forms.TextBox();
            this.checkBox_talalatkijeloles = new System.Windows.Forms.CheckBox();
            this.button_kereses = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forrásfájl neve:";
            // 
            // textBox1_Forrasfajl
            // 
            this.textBox1_Forrasfajl.Location = new System.Drawing.Point(16, 40);
            this.textBox1_Forrasfajl.Name = "textBox1_Forrasfajl";
            this.textBox1_Forrasfajl.Size = new System.Drawing.Size(269, 20);
            this.textBox1_Forrasfajl.TabIndex = 1;
            // 
            // button1_betoltes
            // 
            this.button1_betoltes.Location = new System.Drawing.Point(16, 66);
            this.button1_betoltes.Name = "button1_betoltes";
            this.button1_betoltes.Size = new System.Drawing.Size(269, 23);
            this.button1_betoltes.TabIndex = 2;
            this.button1_betoltes.Text = "Betöltés";
            this.button1_betoltes.UseVisualStyleBackColor = true;
            this.button1_betoltes.Click += new System.EventHandler(this.button1_betoltes_Click);
            // 
            // button1_teruletekatlaga
            // 
            this.button1_teruletekatlaga.Location = new System.Drawing.Point(16, 400);
            this.button1_teruletekatlaga.Name = "button1_teruletekatlaga";
            this.button1_teruletekatlaga.Size = new System.Drawing.Size(269, 23);
            this.button1_teruletekatlaga.TabIndex = 4;
            this.button1_teruletekatlaga.Text = "Területek átlaga";
            this.button1_teruletekatlaga.UseVisualStyleBackColor = true;
            // 
            // listBox_OrszagokLista
            // 
            this.listBox_OrszagokLista.FormattingEnabled = true;
            this.listBox_OrszagokLista.Location = new System.Drawing.Point(16, 105);
            this.listBox_OrszagokLista.Name = "listBox_OrszagokLista";
            this.listBox_OrszagokLista.Size = new System.Drawing.Size(269, 277);
            this.listBox_OrszagokLista.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_legfeljebbszazezer);
            this.groupBox1.Controls.Add(this.radioButton_szazezerfelett);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(309, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mit számoljunk?";
            // 
            // radioButton_szazezerfelett
            // 
            this.radioButton_szazezerfelett.AutoSize = true;
            this.radioButton_szazezerfelett.Location = new System.Drawing.Point(6, 30);
            this.radioButton_szazezerfelett.Name = "radioButton_szazezerfelett";
            this.radioButton_szazezerfelett.Size = new System.Drawing.Size(195, 20);
            this.radioButton_szazezerfelett.TabIndex = 0;
            this.radioButton_szazezerfelett.TabStop = true;
            this.radioButton_szazezerfelett.Text = "100.000-nél nagyobb területű";
            this.radioButton_szazezerfelett.UseVisualStyleBackColor = true;
            // 
            // radioButton_legfeljebbszazezer
            // 
            this.radioButton_legfeljebbszazezer.AutoSize = true;
            this.radioButton_legfeljebbszazezer.Location = new System.Drawing.Point(6, 62);
            this.radioButton_legfeljebbszazezer.Name = "radioButton_legfeljebbszazezer";
            this.radioButton_legfeljebbszazezer.Size = new System.Drawing.Size(179, 20);
            this.radioButton_legfeljebbszazezer.TabIndex = 1;
            this.radioButton_legfeljebbszazezer.TabStop = true;
            this.radioButton_legfeljebbszazezer.Text = "legfeljebb 100.000 területű";
            this.radioButton_legfeljebbszazezer.UseVisualStyleBackColor = true;
            // 
            // button_megszamolas
            // 
            this.button_megszamolas.Location = new System.Drawing.Point(309, 117);
            this.button_megszamolas.Name = "button_megszamolas";
            this.button_megszamolas.Size = new System.Drawing.Size(250, 23);
            this.button_megszamolas.TabIndex = 7;
            this.button_megszamolas.Text = "Megszámolás";
            this.button_megszamolas.UseVisualStyleBackColor = true;
            // 
            // label_eredmenyszam
            // 
            this.label_eredmenyszam.AutoSize = true;
            this.label_eredmenyszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_eredmenyszam.Location = new System.Drawing.Point(306, 157);
            this.label_eredmenyszam.Name = "label_eredmenyszam";
            this.label_eredmenyszam.Size = new System.Drawing.Size(132, 18);
            this.label_eredmenyszam.TabIndex = 8;
            this.label_eredmenyszam.Text = "Eredményfájl neve:";
            // 
            // textBox_eredmenyszamneve
            // 
            this.textBox_eredmenyszamneve.Location = new System.Drawing.Point(309, 178);
            this.textBox_eredmenyszamneve.Name = "textBox_eredmenyszamneve";
            this.textBox_eredmenyszamneve.Size = new System.Drawing.Size(250, 20);
            this.textBox_eredmenyszamneve.TabIndex = 9;
            // 
            // button_kiiras
            // 
            this.button_kiiras.Location = new System.Drawing.Point(309, 204);
            this.button_kiiras.Name = "button_kiiras";
            this.button_kiiras.Size = new System.Drawing.Size(250, 23);
            this.button_kiiras.TabIndex = 10;
            this.button_kiiras.Text = "Kiírás";
            this.button_kiiras.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(306, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Minimum vagy maximum?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Minimum",
            "Maximum"});
            this.comboBox1.Location = new System.Drawing.Point(309, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(306, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ország keresése:";
            // 
            // button_minvagymax
            // 
            this.button_minvagymax.Location = new System.Drawing.Point(309, 288);
            this.button_minvagymax.Name = "button_minvagymax";
            this.button_minvagymax.Size = new System.Drawing.Size(250, 23);
            this.button_minvagymax.TabIndex = 14;
            this.button_minvagymax.Text = "Minimum / maximum kiválasztása";
            this.button_minvagymax.UseVisualStyleBackColor = true;
            // 
            // textBox_orszagkereses
            // 
            this.textBox_orszagkereses.Location = new System.Drawing.Point(309, 347);
            this.textBox_orszagkereses.Name = "textBox_orszagkereses";
            this.textBox_orszagkereses.Size = new System.Drawing.Size(250, 20);
            this.textBox_orszagkereses.TabIndex = 15;
            // 
            // checkBox_talalatkijeloles
            // 
            this.checkBox_talalatkijeloles.AutoSize = true;
            this.checkBox_talalatkijeloles.Location = new System.Drawing.Point(309, 377);
            this.checkBox_talalatkijeloles.Name = "checkBox_talalatkijeloles";
            this.checkBox_talalatkijeloles.Size = new System.Drawing.Size(164, 17);
            this.checkBox_talalatkijeloles.TabIndex = 16;
            this.checkBox_talalatkijeloles.Text = "Találatok kijelölése a listában";
            this.checkBox_talalatkijeloles.UseVisualStyleBackColor = true;
            // 
            // button_kereses
            // 
            this.button_kereses.Location = new System.Drawing.Point(309, 400);
            this.button_kereses.Name = "button_kereses";
            this.button_kereses.Size = new System.Drawing.Size(250, 23);
            this.button_kereses.TabIndex = 17;
            this.button_kereses.Text = "Keresés";
            this.button_kereses.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(586, 454);
            this.Controls.Add(this.button_kereses);
            this.Controls.Add(this.checkBox_talalatkijeloles);
            this.Controls.Add(this.textBox_orszagkereses);
            this.Controls.Add(this.button_minvagymax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_kiiras);
            this.Controls.Add(this.textBox_eredmenyszamneve);
            this.Controls.Add(this.label_eredmenyszam);
            this.Controls.Add(this.button_megszamolas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox_OrszagokLista);
            this.Controls.Add(this.button1_teruletekatlaga);
            this.Controls.Add(this.button1_betoltes);
            this.Controls.Add(this.textBox1_Forrasfajl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Példa Windows Forms alkalmazás";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_Forrasfajl;
        private System.Windows.Forms.Button button1_betoltes;
        private System.Windows.Forms.Button button1_teruletekatlaga;
        private System.Windows.Forms.ListBox listBox_OrszagokLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_szazezerfelett;
        private System.Windows.Forms.RadioButton radioButton_legfeljebbszazezer;
        private System.Windows.Forms.Button button_megszamolas;
        private System.Windows.Forms.Label label_eredmenyszam;
        private System.Windows.Forms.TextBox textBox_eredmenyszamneve;
        private System.Windows.Forms.Button button_kiiras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_minvagymax;
        private System.Windows.Forms.TextBox textBox_orszagkereses;
        private System.Windows.Forms.CheckBox checkBox_talalatkijeloles;
        private System.Windows.Forms.Button button_kereses;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

