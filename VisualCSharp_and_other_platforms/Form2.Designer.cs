namespace VisualCSharp_and_other_platforms
{
    partial class Form2
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
            this.Excel_draw_btn = new System.Windows.Forms.Button();
            this.excel_grid_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.userControl11 = new VisualCSharp_and_other_platforms.UserControl1();
            this.SuspendLayout();
            // 
            // Excel_draw_btn
            // 
            this.Excel_draw_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Excel_draw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excel_draw_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excel_draw_btn.Location = new System.Drawing.Point(554, 142);
            this.Excel_draw_btn.Name = "Excel_draw_btn";
            this.Excel_draw_btn.Size = new System.Drawing.Size(192, 62);
            this.Excel_draw_btn.TabIndex = 6;
            this.Excel_draw_btn.Text = "Charts";
            this.Excel_draw_btn.UseVisualStyleBackColor = false;
            this.Excel_draw_btn.Click += new System.EventHandler(this.Excel_draw_btn_Click);
            // 
            // excel_grid_btn
            // 
            this.excel_grid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.excel_grid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excel_grid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excel_grid_btn.Location = new System.Drawing.Point(305, 142);
            this.excel_grid_btn.Name = "excel_grid_btn";
            this.excel_grid_btn.Size = new System.Drawing.Size(192, 62);
            this.excel_grid_btn.TabIndex = 5;
            this.excel_grid_btn.Text = "Grid";
            this.excel_grid_btn.UseVisualStyleBackColor = false;
            this.excel_grid_btn.Click += new System.EventHandler(this.excel_grid_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(259, 352);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(323, 69);
            this.userControl11.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Excel_draw_btn);
            this.Controls.Add(this.excel_grid_btn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programs using Microsoft Excel";
            this.Load += new System.EventHandler(this.ExcelForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Excel_draw_btn;
        private System.Windows.Forms.Button excel_grid_btn;
        private System.Windows.Forms.Button button1;
        private UserControl1 userControl11;
    }
}