namespace WindowsFormsApp_OrarendNyilvantartas
{
    partial class Form_Orarend
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
            this.Hetfo = new System.Windows.Forms.ListBox();
            this.Kedd = new System.Windows.Forms.ListBox();
            this.Szerda = new System.Windows.Forms.ListBox();
            this.Csutortok = new System.Windows.Forms.ListBox();
            this.Pentek = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Órarend:";
            // 
            // Hetfo
            // 
            this.Hetfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Hetfo.FormattingEnabled = true;
            this.Hetfo.ItemHeight = 20;
            this.Hetfo.Location = new System.Drawing.Point(12, 68);
            this.Hetfo.Name = "Hetfo";
            this.Hetfo.Size = new System.Drawing.Size(158, 344);
            this.Hetfo.TabIndex = 1;
            this.Hetfo.SelectedIndexChanged += new System.EventHandler(this.Hetfo_SelectedIndexChanged);
            // 
            // Kedd
            // 
            this.Kedd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kedd.FormattingEnabled = true;
            this.Kedd.ItemHeight = 20;
            this.Kedd.Location = new System.Drawing.Point(176, 68);
            this.Kedd.Name = "Kedd";
            this.Kedd.Size = new System.Drawing.Size(158, 344);
            this.Kedd.TabIndex = 2;
            // 
            // Szerda
            // 
            this.Szerda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Szerda.FormattingEnabled = true;
            this.Szerda.ItemHeight = 20;
            this.Szerda.Location = new System.Drawing.Point(340, 68);
            this.Szerda.Name = "Szerda";
            this.Szerda.Size = new System.Drawing.Size(158, 344);
            this.Szerda.TabIndex = 3;
            // 
            // Csutortok
            // 
            this.Csutortok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Csutortok.FormattingEnabled = true;
            this.Csutortok.ItemHeight = 20;
            this.Csutortok.Location = new System.Drawing.Point(504, 68);
            this.Csutortok.Name = "Csutortok";
            this.Csutortok.Size = new System.Drawing.Size(158, 344);
            this.Csutortok.TabIndex = 4;
            // 
            // Pentek
            // 
            this.Pentek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pentek.FormattingEnabled = true;
            this.Pentek.ItemHeight = 20;
            this.Pentek.Location = new System.Drawing.Point(668, 68);
            this.Pentek.Name = "Pentek";
            this.Pentek.Size = new System.Drawing.Size(158, 344);
            this.Pentek.TabIndex = 5;
            // 
            // Form_Orarend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 449);
            this.Controls.Add(this.Pentek);
            this.Controls.Add(this.Csutortok);
            this.Controls.Add(this.Szerda);
            this.Controls.Add(this.Kedd);
            this.Controls.Add(this.Hetfo);
            this.Controls.Add(this.label1);
            this.Name = "Form_Orarend";
            this.Text = "Form_Orarend";
            this.Load += new System.EventHandler(this.Form_Orarend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Hetfo;
        private System.Windows.Forms.ListBox Kedd;
        private System.Windows.Forms.ListBox Szerda;
        private System.Windows.Forms.ListBox Csutortok;
        private System.Windows.Forms.ListBox Pentek;
    }
}