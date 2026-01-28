namespace ImageFramer
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
            this.loadButton = new System.Windows.Forms.Button();
            this.frameButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.grayscaleButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(397, 8);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(83, 30);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Качи снимка";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // frameButton
            // 
            this.frameButton.Location = new System.Drawing.Point(397, 92);
            this.frameButton.Margin = new System.Windows.Forms.Padding(2);
            this.frameButton.Name = "frameButton";
            this.frameButton.Size = new System.Drawing.Size(98, 42);
            this.frameButton.TabIndex = 1;
            this.frameButton.Text = "Рамка";
            this.frameButton.UseVisualStyleBackColor = true;
            this.frameButton.Click += new System.EventHandler(this.frameButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(397, 49);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(83, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Запази";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Location = new System.Drawing.Point(72, 18);
            this.PictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(275, 241);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(397, 201);
            this.sizeNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.sizeNumericUpDown.TabIndex = 4;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.Location = new System.Drawing.Point(445, 195);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 26);
            this.label.TabIndex = 5;
            this.label.Text = "Дебелина \r\nна рамката";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // colorButton
            // 
            this.colorButton.Location = new System.Drawing.Point(397, 142);
            this.colorButton.Margin = new System.Windows.Forms.Padding(2);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(70, 29);
            this.colorButton.TabIndex = 6;
            this.colorButton.Text = "Цвят";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // grayscaleButton
            // 
            this.grayscaleButton.Location = new System.Drawing.Point(397, 236);
            this.grayscaleButton.Margin = new System.Windows.Forms.Padding(2);
            this.grayscaleButton.Name = "grayscaleButton";
            this.grayscaleButton.Size = new System.Drawing.Size(98, 35);
            this.grayscaleButton.TabIndex = 7;
            this.grayscaleButton.Text = "Черно-бял филтър";
            this.grayscaleButton.UseVisualStyleBackColor = true;
            this.grayscaleButton.Click += new System.EventHandler(this.grayscaleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.grayscaleButton);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.frameButton);
            this.Controls.Add(this.loadButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button frameButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button grayscaleButton;
    }
}

