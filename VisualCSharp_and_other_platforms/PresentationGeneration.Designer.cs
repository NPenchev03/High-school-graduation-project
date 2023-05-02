namespace VisualCSharp_and_other_platforms
{
    partial class Presentation_Generation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Clear_theme_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Select_theme_btn = new System.Windows.Forms.Button();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Clear_img_Selection_btn = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.userControl11 = new VisualCSharp_and_other_platforms.UserControl1();
            this.Select_backgroundImg_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Clear_theme_btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Select_theme_btn);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.Clear_img_Selection_btn);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.userControl11);
            this.groupBox1.Controls.Add(this.Select_backgroundImg_btn);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Generate_btn);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options - Опции";
            // 
            // Clear_theme_btn
            // 
            this.Clear_theme_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Clear_theme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_theme_btn.Location = new System.Drawing.Point(667, 183);
            this.Clear_theme_btn.Name = "Clear_theme_btn";
            this.Clear_theme_btn.Size = new System.Drawing.Size(88, 53);
            this.Clear_theme_btn.TabIndex = 14;
            this.Clear_theme_btn.Text = "Clear selection";
            this.Clear_theme_btn.UseVisualStyleBackColor = false;
            this.Clear_theme_btn.Click += new System.EventHandler(this.Clear_theme_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 249);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(764, 26);
            this.textBox1.TabIndex = 13;
            // 
            // Select_theme_btn
            // 
            this.Select_theme_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Select_theme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_theme_btn.Location = new System.Drawing.Point(478, 183);
            this.Select_theme_btn.Name = "Select_theme_btn";
            this.Select_theme_btn.Size = new System.Drawing.Size(157, 53);
            this.Select_theme_btn.TabIndex = 12;
            this.Select_theme_btn.Text = "Select a theme *.potx *.thmx";
            this.Select_theme_btn.UseVisualStyleBackColor = false;
            this.Select_theme_btn.Click += new System.EventHandler(this.Select_theme_btn_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 198);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(465, 24);
            this.checkBox5.TabIndex = 11;
            this.checkBox5.Text = "Add a custom theme - Добавяне на персонализирана тема";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 157);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(432, 24);
            this.checkBox4.TabIndex = 10;
            this.checkBox4.Text = "Add a sources slide - Добавяне на слайд за източници";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 113);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(536, 24);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Add an exemplary last slide - Добавяне на примерен последен слайд";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Clear_img_Selection_btn
            // 
            this.Clear_img_Selection_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Clear_img_Selection_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_img_Selection_btn.Location = new System.Drawing.Point(573, 15);
            this.Clear_img_Selection_btn.Name = "Clear_img_Selection_btn";
            this.Clear_img_Selection_btn.Size = new System.Drawing.Size(88, 53);
            this.Clear_img_Selection_btn.TabIndex = 8;
            this.Clear_img_Selection_btn.Text = "Clear selection";
            this.Clear_img_Selection_btn.UseVisualStyleBackColor = false;
            this.Clear_img_Selection_btn.Click += new System.EventHandler(this.Clear_img_Selection_btn_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(376, 44);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Add a slide for an exemplary table of contents - \r\nДобавяне на примерна слайд за " +
    "съдържание";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select the number of slides - Изберете броя на слайдовете";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 301);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // userControl11
            // 
            this.userControl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControl11.Location = new System.Drawing.Point(194, 345);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(332, 51);
            this.userControl11.TabIndex = 4;
            // 
            // Select_backgroundImg_btn
            // 
            this.Select_backgroundImg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Select_backgroundImg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select_backgroundImg_btn.Location = new System.Drawing.Point(448, 15);
            this.Select_backgroundImg_btn.Name = "Select_backgroundImg_btn";
            this.Select_backgroundImg_btn.Size = new System.Drawing.Size(119, 53);
            this.Select_backgroundImg_btn.TabIndex = 3;
            this.Select_backgroundImg_btn.Text = "Select Background Picture";
            this.Select_backgroundImg_btn.UseVisualStyleBackColor = false;
            this.Select_backgroundImg_btn.Click += new System.EventHandler(this.Select_backgroundImg_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(667, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Generate_btn
            // 
            this.Generate_btn.BackColor = System.Drawing.Color.DarkRed;
            this.Generate_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Generate_btn.Location = new System.Drawing.Point(532, 325);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(166, 71);
            this.Generate_btn.TabIndex = 1;
            this.Generate_btn.Text = "Generate presentation with the selected options";
            this.Generate_btn.UseVisualStyleBackColor = false;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(435, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Add a background image -  Добавяне на снимка за фон";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Presentation_Generation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.Name = "Presentation_Generation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Presentation Generation";
            this.Load += new System.EventHandler(this.PowerPointGenerate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.Button Select_backgroundImg_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button Clear_img_Selection_btn;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button Select_theme_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear_theme_btn;
    }
}