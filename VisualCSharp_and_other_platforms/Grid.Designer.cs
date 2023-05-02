namespace VisualCSharp_and_other_platforms
{
    partial class Grid
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
            this.Reset_grid_btn = new System.Windows.Forms.Button();
            this.Exit_app_btn = new System.Windows.Forms.Button();
            this.Main_menu_btn = new System.Windows.Forms.Button();
            this.create_file_btn = new System.Windows.Forms.Button();
            this.file_dialog_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.add_column_btn = new System.Windows.Forms.Button();
            this.save_changes_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Reset_grid_btn
            // 
            this.Reset_grid_btn.BackColor = System.Drawing.Color.LightGray;
            this.Reset_grid_btn.Enabled = false;
            this.Reset_grid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset_grid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset_grid_btn.Location = new System.Drawing.Point(12, 367);
            this.Reset_grid_btn.Name = "Reset_grid_btn";
            this.Reset_grid_btn.Size = new System.Drawing.Size(144, 48);
            this.Reset_grid_btn.TabIndex = 26;
            this.Reset_grid_btn.Text = "Reset grid";
            this.Reset_grid_btn.UseVisualStyleBackColor = false;
            this.Reset_grid_btn.Click += new System.EventHandler(this.Reset_grid_btn_Click);
            // 
            // Exit_app_btn
            // 
            this.Exit_app_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Exit_app_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_app_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_app_btn.Location = new System.Drawing.Point(547, 416);
            this.Exit_app_btn.Name = "Exit_app_btn";
            this.Exit_app_btn.Size = new System.Drawing.Size(127, 31);
            this.Exit_app_btn.TabIndex = 25;
            this.Exit_app_btn.Text = "Exit App";
            this.Exit_app_btn.UseVisualStyleBackColor = false;
            this.Exit_app_btn.Click += new System.EventHandler(this.Exit_app_btn_Click);
            // 
            // Main_menu_btn
            // 
            this.Main_menu_btn.BackColor = System.Drawing.Color.Orange;
            this.Main_menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Main_menu_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_menu_btn.Location = new System.Drawing.Point(239, 416);
            this.Main_menu_btn.Name = "Main_menu_btn";
            this.Main_menu_btn.Size = new System.Drawing.Size(127, 31);
            this.Main_menu_btn.TabIndex = 24;
            this.Main_menu_btn.Text = "Main menu";
            this.Main_menu_btn.UseVisualStyleBackColor = false;
            this.Main_menu_btn.Click += new System.EventHandler(this.Main_menu_btn_Click);
            // 
            // create_file_btn
            // 
            this.create_file_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.create_file_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_file_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_file_btn.Location = new System.Drawing.Point(196, 3);
            this.create_file_btn.Name = "create_file_btn";
            this.create_file_btn.Size = new System.Drawing.Size(170, 28);
            this.create_file_btn.TabIndex = 23;
            this.create_file_btn.Text = "Create an Excel File";
            this.create_file_btn.UseVisualStyleBackColor = false;
            this.create_file_btn.Click += new System.EventHandler(this.create_file_btn_Click_1);
            // 
            // file_dialog_btn
            // 
            this.file_dialog_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.file_dialog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.file_dialog_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_dialog_btn.Location = new System.Drawing.Point(547, 3);
            this.file_dialog_btn.Name = "file_dialog_btn";
            this.file_dialog_btn.Size = new System.Drawing.Size(156, 30);
            this.file_dialog_btn.TabIndex = 22;
            this.file_dialog_btn.Text = "Open an Excel File";
            this.file_dialog_btn.UseVisualStyleBackColor = false;
            this.file_dialog_btn.Click += new System.EventHandler(this.file_dialog_btn_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "Remove a column";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_column_btn
            // 
            this.add_column_btn.BackColor = System.Drawing.Color.White;
            this.add_column_btn.Enabled = false;
            this.add_column_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_column_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_column_btn.Location = new System.Drawing.Point(12, 35);
            this.add_column_btn.Name = "add_column_btn";
            this.add_column_btn.Size = new System.Drawing.Size(144, 48);
            this.add_column_btn.TabIndex = 20;
            this.add_column_btn.Text = "Add a column";
            this.add_column_btn.UseVisualStyleBackColor = false;
            this.add_column_btn.Click += new System.EventHandler(this.add_column_btn_Click_1);
            // 
            // save_changes_btn
            // 
            this.save_changes_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save_changes_btn.Enabled = false;
            this.save_changes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_changes_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_changes_btn.Location = new System.Drawing.Point(12, 254);
            this.save_changes_btn.Name = "save_changes_btn";
            this.save_changes_btn.Size = new System.Drawing.Size(144, 55);
            this.save_changes_btn.TabIndex = 19;
            this.save_changes_btn.Text = "Save Changes To A New File";
            this.save_changes_btn.UseVisualStyleBackColor = false;
            this.save_changes_btn.Click += new System.EventHandler(this.save_changes_btn_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(162, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 380);
            this.dataGridView1.TabIndex = 18;
            // 
            // Grid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Reset_grid_btn);
            this.Controls.Add(this.Exit_app_btn);
            this.Controls.Add(this.Main_menu_btn);
            this.Controls.Add(this.create_file_btn);
            this.Controls.Add(this.file_dialog_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_column_btn);
            this.Controls.Add(this.save_changes_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Grid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid";
            this.Load += new System.EventHandler(this.ExcelGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reset_grid_btn;
        private System.Windows.Forms.Button Exit_app_btn;
        private System.Windows.Forms.Button Main_menu_btn;
        private System.Windows.Forms.Button create_file_btn;
        private System.Windows.Forms.Button file_dialog_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button add_column_btn;
        private System.Windows.Forms.Button save_changes_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}