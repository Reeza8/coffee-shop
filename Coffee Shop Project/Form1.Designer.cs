namespace Coffee_Shop_Project
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Food_chechBox = new System.Windows.Forms.CheckBox();
            this.salad_checkBox = new System.Windows.Forms.CheckBox();
            this.Drink_checkBox = new System.Windows.Forms.CheckBox();
            this.desert_checkBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(526, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "ثبت سفارش";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Sienna;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(271, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 73);
            this.button2.TabIndex = 2;
            this.button2.Text = "خروج";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Sienna;
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(396, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "ثبت";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Food_chechBox
            // 
            this.Food_chechBox.AutoSize = true;
            this.Food_chechBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Food_chechBox.Font = new System.Drawing.Font("MS PGothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food_chechBox.Location = new System.Drawing.Point(428, 12);
            this.Food_chechBox.Name = "Food_chechBox";
            this.Food_chechBox.Size = new System.Drawing.Size(77, 44);
            this.Food_chechBox.TabIndex = 4;
            this.Food_chechBox.Text = "غذا";
            this.Food_chechBox.UseVisualStyleBackColor = true;
            this.Food_chechBox.Visible = false;
            // 
            // salad_checkBox
            // 
            this.salad_checkBox.AutoSize = true;
            this.salad_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salad_checkBox.Font = new System.Drawing.Font("MS PGothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salad_checkBox.Location = new System.Drawing.Point(408, 85);
            this.salad_checkBox.Name = "salad_checkBox";
            this.salad_checkBox.Size = new System.Drawing.Size(97, 44);
            this.salad_checkBox.TabIndex = 5;
            this.salad_checkBox.Text = "سالاد";
            this.salad_checkBox.UseVisualStyleBackColor = true;
            this.salad_checkBox.Visible = false;
            // 
            // Drink_checkBox
            // 
            this.Drink_checkBox.AutoSize = true;
            this.Drink_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Drink_checkBox.Font = new System.Drawing.Font("MS PGothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Drink_checkBox.Location = new System.Drawing.Point(374, 164);
            this.Drink_checkBox.Name = "Drink_checkBox";
            this.Drink_checkBox.Size = new System.Drawing.Size(131, 44);
            this.Drink_checkBox.TabIndex = 6;
            this.Drink_checkBox.Text = "نوشیدنی";
            this.Drink_checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Drink_checkBox.UseVisualStyleBackColor = true;
            this.Drink_checkBox.Visible = false;
            // 
            // desert_checkBox
            // 
            this.desert_checkBox.AutoSize = true;
            this.desert_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.desert_checkBox.Font = new System.Drawing.Font("MS PGothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desert_checkBox.Location = new System.Drawing.Point(345, 248);
            this.desert_checkBox.Name = "desert_checkBox";
            this.desert_checkBox.Size = new System.Drawing.Size(160, 44);
            this.desert_checkBox.TabIndex = 7;
            this.desert_checkBox.Text = "دسر و کیک";
            this.desert_checkBox.UseVisualStyleBackColor = true;
            this.desert_checkBox.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(2, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(12, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(366, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Coffee_Shop_Project.Properties.Resources.cf_l4;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.desert_checkBox);
            this.Controls.Add(this.Drink_checkBox);
            this.Controls.Add(this.salad_checkBox);
            this.Controls.Add(this.Food_chechBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffe Shop";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox Food_chechBox;
        private System.Windows.Forms.CheckBox salad_checkBox;
        private System.Windows.Forms.CheckBox Drink_checkBox;
        private System.Windows.Forms.CheckBox desert_checkBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

