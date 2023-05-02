namespace VisualCSharp_and_other_platforms
{
    partial class Presentation_Export
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear_selection_btn = new System.Windows.Forms.Button();
            this.Export_PDF_btn = new System.Windows.Forms.Button();
            this.Export_XPS_btn = new System.Windows.Forms.Button();
            this.userControl11 = new VisualCSharp_and_other_platforms.UserControl1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select a powerpoint file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(208, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 29);
            this.textBox1.TabIndex = 1;
            // 
            // Clear_selection_btn
            // 
            this.Clear_selection_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Clear_selection_btn.Enabled = false;
            this.Clear_selection_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_selection_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_selection_btn.Location = new System.Drawing.Point(462, 94);
            this.Clear_selection_btn.Name = "Clear_selection_btn";
            this.Clear_selection_btn.Size = new System.Drawing.Size(143, 75);
            this.Clear_selection_btn.TabIndex = 2;
            this.Clear_selection_btn.Text = "Clear selection";
            this.Clear_selection_btn.UseVisualStyleBackColor = false;
            this.Clear_selection_btn.Click += new System.EventHandler(this.Clear_selection_btn_Click);
            // 
            // Export_PDF_btn
            // 
            this.Export_PDF_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Export_PDF_btn.Enabled = false;
            this.Export_PDF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_PDF_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_PDF_btn.Location = new System.Drawing.Point(208, 235);
            this.Export_PDF_btn.Name = "Export_PDF_btn";
            this.Export_PDF_btn.Size = new System.Drawing.Size(143, 69);
            this.Export_PDF_btn.TabIndex = 4;
            this.Export_PDF_btn.Text = "Export as PDF";
            this.Export_PDF_btn.UseVisualStyleBackColor = false;
            this.Export_PDF_btn.Click += new System.EventHandler(this.Export_PDF_btn_Click);
            // 
            // Export_XPS_btn
            // 
            this.Export_XPS_btn.BackColor = System.Drawing.Color.Cyan;
            this.Export_XPS_btn.Enabled = false;
            this.Export_XPS_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Export_XPS_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export_XPS_btn.Location = new System.Drawing.Point(462, 235);
            this.Export_XPS_btn.Name = "Export_XPS_btn";
            this.Export_XPS_btn.Size = new System.Drawing.Size(143, 69);
            this.Export_XPS_btn.TabIndex = 5;
            this.Export_XPS_btn.Text = "Export as XPS";
            this.Export_XPS_btn.UseVisualStyleBackColor = false;
            this.Export_XPS_btn.Click += new System.EventHandler(this.Export_XPS_btn_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(257, 393);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(324, 45);
            this.userControl11.TabIndex = 3;
            // 
            // Presentation_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Export_XPS_btn);
            this.Controls.Add(this.Export_PDF_btn);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Clear_selection_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Presentation_Export";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation Export";
            this.Load += new System.EventHandler(this.PowerPointExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear_selection_btn;
        private UserControl1 userControl11;
        private System.Windows.Forms.Button Export_PDF_btn;
        private System.Windows.Forms.Button Export_XPS_btn;
    }
}