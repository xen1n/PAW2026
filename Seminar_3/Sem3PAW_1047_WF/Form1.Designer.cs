
namespace Sem3PAW_1047_WF
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.tbVarsta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(286, 71);
            this.tbCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(112, 28);
            this.tbCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sex:";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F",
            "N"});
            this.cbSex.Location = new System.Drawing.Point(286, 131);
            this.cbSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(136, 29);
            this.cbSex.TabIndex = 3;
            // 
            // tbVarsta
            // 
            this.tbVarsta.Location = new System.Drawing.Point(286, 210);
            this.tbVarsta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbVarsta.Name = "tbVarsta";
            this.tbVarsta.Size = new System.Drawing.Size(112, 28);
            this.tbVarsta.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Varsta:";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(286, 278);
            this.tbNume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(112, 28);
            this.tbNume.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nume:";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(286, 353);
            this.tbNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(112, 28);
            this.tbNote.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Note:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 79);
            this.button1.TabIndex = 10;
            this.button1.Text = "Creare student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVarsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox tbVarsta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

