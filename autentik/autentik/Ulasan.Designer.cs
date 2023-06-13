namespace autentik
{
    partial class Ulasan
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
            labelKomentar1 = new Label();
            labelKomentar2 = new Label();
            textBox1 = new TextBox();
            buttonKomentar = new Button();
            labelRating = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            SuspendLayout();
            // 
            // labelKomentar1
            // 
            labelKomentar1.AutoSize = true;
            labelKomentar1.Location = new Point(469, 138);
            labelKomentar1.Name = "labelKomentar1";
            labelKomentar1.Size = new Size(90, 15);
            labelKomentar1.TabIndex = 0;
            labelKomentar1.Text = "labelKomentar1";
            // 
            // labelKomentar2
            // 
            labelKomentar2.AutoSize = true;
            labelKomentar2.Location = new Point(469, 182);
            labelKomentar2.Name = "labelKomentar2";
            labelKomentar2.Size = new Size(90, 15);
            labelKomentar2.TabIndex = 1;
            labelKomentar2.Text = "labelKomentar2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(371, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(217, 23);
            textBox1.TabIndex = 2;
            // 
            // buttonKomentar
            // 
            buttonKomentar.Location = new Point(605, 75);
            buttonKomentar.Name = "buttonKomentar";
            buttonKomentar.Size = new Size(75, 23);
            buttonKomentar.TabIndex = 3;
            buttonKomentar.Text = "Komentar";
            buttonKomentar.UseVisualStyleBackColor = true;
            buttonKomentar.Click += buttonKomentar_Click;
            // 
            // labelRating
            // 
            labelRating.AutoSize = true;
            labelRating.Location = new Point(266, 9);
            labelRating.Name = "labelRating";
            labelRating.Size = new Size(66, 15);
            labelRating.TabIndex = 4;
            labelRating.Text = "labelRating";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(371, 52);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(408, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(445, 52);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(31, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(482, 52);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(31, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(519, 52);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(31, 19);
            radioButton5.TabIndex = 9;
            radioButton5.TabStop = true;
            radioButton5.Text = "5";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // Ulasan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(labelRating);
            Controls.Add(buttonKomentar);
            Controls.Add(textBox1);
            Controls.Add(labelKomentar2);
            Controls.Add(labelKomentar1);
            Name = "Ulasan";
            Text = "Ulasan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelKomentar1;
        private Label labelKomentar2;
        private TextBox textBox1;
        private Button buttonKomentar;
        private Label labelRating;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
    }
}