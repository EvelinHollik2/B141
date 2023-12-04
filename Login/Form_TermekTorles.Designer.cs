namespace Login
{
    partial class Form_TermekTorles
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
            this.listBox_termek = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_kivalasztottTermek = new System.Windows.Forms.TextBox();
            this.button_torles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Termék törlése";
            // 
            // listBox_termek
            // 
            this.listBox_termek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_termek.FormattingEnabled = true;
            this.listBox_termek.ItemHeight = 29;
            this.listBox_termek.Location = new System.Drawing.Point(18, 55);
            this.listBox_termek.Name = "listBox_termek";
            this.listBox_termek.Size = new System.Drawing.Size(180, 352);
            this.listBox_termek.TabIndex = 1;
            this.listBox_termek.SelectedIndexChanged += new System.EventHandler(this.listBox_termek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(231, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiválasztott termék:";
            // 
            // textBox_kivalasztottTermek
            // 
            this.textBox_kivalasztottTermek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kivalasztottTermek.Location = new System.Drawing.Point(236, 88);
            this.textBox_kivalasztottTermek.Name = "textBox_kivalasztottTermek";
            this.textBox_kivalasztottTermek.Size = new System.Drawing.Size(214, 35);
            this.textBox_kivalasztottTermek.TabIndex = 3;
            // 
            // button_torles
            // 
            this.button_torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_torles.Location = new System.Drawing.Point(236, 286);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(214, 43);
            this.button_torles.TabIndex = 4;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = true;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // Form_TermekTorles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_torles);
            this.Controls.Add(this.textBox_kivalasztottTermek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox_termek);
            this.Controls.Add(this.label1);
            this.Name = "Form_TermekTorles";
            this.Text = "Form_Torles";
            this.Load += new System.EventHandler(this.Form_TermekTorles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_termek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_kivalasztottTermek;
        private System.Windows.Forms.Button button_torles;
    }
}