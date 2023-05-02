namespace VisualCSharp_and_other_platforms
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main_menu_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Main_menu_btn
            // 
            this.Main_menu_btn.BackColor = System.Drawing.Color.Orange;
            this.Main_menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_menu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_menu_btn.Location = new System.Drawing.Point(3, 3);
            this.Main_menu_btn.Name = "Main_menu_btn";
            this.Main_menu_btn.Size = new System.Drawing.Size(130, 40);
            this.Main_menu_btn.TabIndex = 0;
            this.Main_menu_btn.Text = "Main Menu";
            this.Main_menu_btn.UseVisualStyleBackColor = false;
            this.Main_menu_btn.Click += new System.EventHandler(this.Main_menu_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.Location = new System.Drawing.Point(139, 3);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(177, 40);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.Text = "Exit Application";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Main_menu_btn);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(319, 46);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_menu_btn;
        private System.Windows.Forms.Button Exit_btn;
    }
}
