namespace VisualCSharp_and_other_platforms
{
    partial class Text_Editor
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
            this.Open_word_file = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.userControl11 = new VisualCSharp_and_other_platforms.UserControl1();
            this.SuspendLayout();
            // 
            // Open_word_file
            // 
            this.Open_word_file.BackColor = System.Drawing.Color.DodgerBlue;
            this.Open_word_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open_word_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open_word_file.Location = new System.Drawing.Point(532, 132);
            this.Open_word_file.Name = "Open_word_file";
            this.Open_word_file.Size = new System.Drawing.Size(149, 58);
            this.Open_word_file.TabIndex = 0;
            this.Open_word_file.Text = "Open a Word file";
            this.Open_word_file.UseVisualStyleBackColor = false;
            this.Open_word_file.Click += new System.EventHandler(this.Open_word_file_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 426);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(532, 223);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(149, 58);
            this.Save_btn.TabIndex = 3;
            this.Save_btn.Text = "Save to a new file";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(456, 390);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(319, 48);
            this.userControl11.TabIndex = 4;
            // 
            // Text_Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Open_word_file);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Text_Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.Text_Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_word_file;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Save_btn;
        private UserControl1 userControl11;
    }
}