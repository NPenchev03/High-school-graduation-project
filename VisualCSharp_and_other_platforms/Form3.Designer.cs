namespace VisualCSharp_and_other_platforms
{
    partial class Form3
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
            this.userControl11 = new VisualCSharp_and_other_platforms.UserControl1();
            this.Text_form_btn = new System.Windows.Forms.Button();
            this.Generate_form_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(252, 391);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(319, 47);
            this.userControl11.TabIndex = 0;
            // 
            // Text_form_btn
            // 
            this.Text_form_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Text_form_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text_form_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_form_btn.Location = new System.Drawing.Point(81, 146);
            this.Text_form_btn.Name = "Text_form_btn";
            this.Text_form_btn.Size = new System.Drawing.Size(200, 108);
            this.Text_form_btn.TabIndex = 1;
            this.Text_form_btn.Text = "Simple text editor";
            this.Text_form_btn.UseVisualStyleBackColor = false;
            this.Text_form_btn.Click += new System.EventHandler(this.Text_form_btn_Click);
            // 
            // Generate_form_btn
            // 
            this.Generate_form_btn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Generate_form_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_form_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_form_btn.Location = new System.Drawing.Point(521, 146);
            this.Generate_form_btn.Name = "Generate_form_btn";
            this.Generate_form_btn.Size = new System.Drawing.Size(200, 108);
            this.Generate_form_btn.TabIndex = 2;
            this.Generate_form_btn.Text = "Generate Custom Document";
            this.Generate_form_btn.UseVisualStyleBackColor = false;
            this.Generate_form_btn.Click += new System.EventHandler(this.Generate_form_btn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Generate_form_btn);
            this.Controls.Add(this.Text_form_btn);
            this.Controls.Add(this.userControl11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs using Microsoft Word";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControl11;
        private System.Windows.Forms.Button Text_form_btn;
        private System.Windows.Forms.Button Generate_form_btn;
    }
}