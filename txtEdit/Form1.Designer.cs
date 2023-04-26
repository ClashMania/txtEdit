namespace TextEditing
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
            this.TxtBox = new System.Windows.Forms.RichTextBox();
            this.BtnUnder = new System.Windows.Forms.Button();
            this.BtnItalic = new System.Windows.Forms.Button();
            this.BtnBold = new System.Windows.Forms.Button();
            this.BtnSpremi = new System.Windows.Forms.Button();
            this.BtnOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(13, 13);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(775, 343);
            this.TxtBox.TabIndex = 0;
            this.TxtBox.Text = "";
            // 
            // BtnUnder
            // 
            this.BtnUnder.Location = new System.Drawing.Point(412, 375);
            this.BtnUnder.Name = "BtnUnder";
            this.BtnUnder.Size = new System.Drawing.Size(24, 23);
            this.BtnUnder.TabIndex = 10;
            this.BtnUnder.Text = "U";
            this.BtnUnder.UseVisualStyleBackColor = true;
            this.BtnUnder.Click += new System.EventHandler(this.BtnUnder_Click);
            // 
            // BtnItalic
            // 
            this.BtnItalic.Location = new System.Drawing.Point(382, 375);
            this.BtnItalic.Name = "BtnItalic";
            this.BtnItalic.Size = new System.Drawing.Size(24, 23);
            this.BtnItalic.TabIndex = 9;
            this.BtnItalic.Text = "I";
            this.BtnItalic.UseVisualStyleBackColor = true;
            this.BtnItalic.Click += new System.EventHandler(this.BtnItalic_Click);
            // 
            // BtnBold
            // 
            this.BtnBold.Location = new System.Drawing.Point(352, 375);
            this.BtnBold.Name = "BtnBold";
            this.BtnBold.Size = new System.Drawing.Size(24, 23);
            this.BtnBold.TabIndex = 8;
            this.BtnBold.Text = "B";
            this.BtnBold.UseVisualStyleBackColor = true;
            this.BtnBold.Click += new System.EventHandler(this.BtnBold_Click);
            // 
            // BtnSpremi
            // 
            this.BtnSpremi.Location = new System.Drawing.Point(680, 375);
            this.BtnSpremi.Name = "BtnSpremi";
            this.BtnSpremi.Size = new System.Drawing.Size(108, 48);
            this.BtnSpremi.TabIndex = 7;
            this.BtnSpremi.Text = "Spremi Dokument";
            this.BtnSpremi.UseVisualStyleBackColor = true;
            this.BtnSpremi.Click += new System.EventHandler(this.BtnSpremi_Click);
            // 
            // BtnOtvori
            // 
            this.BtnOtvori.Location = new System.Drawing.Point(12, 375);
            this.BtnOtvori.Name = "BtnOtvori";
            this.BtnOtvori.Size = new System.Drawing.Size(108, 48);
            this.BtnOtvori.TabIndex = 6;
            this.BtnOtvori.Text = "Otvori Text Dokument";
            this.BtnOtvori.UseVisualStyleBackColor = true;
            this.BtnOtvori.Click += new System.EventHandler(this.BtnOtvori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnUnder);
            this.Controls.Add(this.BtnItalic);
            this.Controls.Add(this.BtnBold);
            this.Controls.Add(this.BtnSpremi);
            this.Controls.Add(this.BtnOtvori);
            this.Controls.Add(this.TxtBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TxtBox;
        private System.Windows.Forms.Button BtnUnder;
        private System.Windows.Forms.Button BtnItalic;
        private System.Windows.Forms.Button BtnBold;
        private System.Windows.Forms.Button BtnSpremi;
        private System.Windows.Forms.Button BtnOtvori;
    }
}

