namespace Relase_1._0_fersploit
{
    partial class Updater_English
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
            this.flatTextBox1 = new FlatUI.FlatTextBox();
            this.SuspendLayout();
            // 
            // flatTextBox1
            // 
            this.flatTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatTextBox1.FocusOnHover = false;
            this.flatTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatTextBox1.Hint = "";
            this.flatTextBox1.Location = new System.Drawing.Point(144, 111);
            this.flatTextBox1.MaxLength = 32767;
            this.flatTextBox1.Multiline = false;
            this.flatTextBox1.Name = "flatTextBox1";
            this.flatTextBox1.ReadOnly = true;
            this.flatTextBox1.Size = new System.Drawing.Size(168, 34);
            this.flatTextBox1.TabIndex = 0;
            this.flatTextBox1.Text = "Close this window";
            this.flatTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.flatTextBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.flatTextBox1.UseSystemPasswordChar = false;
            this.flatTextBox1.TextChanged += new System.EventHandler(this.FlatTextBox1_TextChanged);
            // 
            // Updater_English
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 250);
            this.Controls.Add(this.flatTextBox1);
            this.Name = "Updater_English";
            this.Text = "Updater_English";
            this.Load += new System.EventHandler(this.Updater_English_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatTextBox flatTextBox1;
    }
}