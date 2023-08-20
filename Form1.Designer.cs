namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            ClearButton = new Button();
            signPlus = new Button();
            signMinus = new Button();
            signDivide = new Button();
            CrossSign = new Button();
            equal = new Button();
            divide = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(457, 55);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 85);
            button1.Name = "button1";
            button1.Size = new Size(110, 69);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(127, 85);
            button2.Name = "button2";
            button2.Size = new Size(110, 69);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(243, 85);
            button3.Name = "button3";
            button3.Size = new Size(110, 69);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(12, 170);
            button4.Name = "button4";
            button4.Size = new Size(110, 69);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(127, 170);
            button5.Name = "button5";
            button5.Size = new Size(110, 69);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Black;
            button6.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(243, 170);
            button6.Name = "button6";
            button6.Size = new Size(110, 69);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(15, 255);
            button7.Name = "button7";
            button7.Size = new Size(110, 69);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Black;
            button8.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(130, 255);
            button8.Name = "button8";
            button8.Size = new Size(110, 69);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.Black;
            button9.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(243, 255);
            button9.Name = "button9";
            button9.Size = new Size(110, 69);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button10.ForeColor = Color.White;
            button10.Location = new Point(15, 330);
            button10.Name = "button10";
            button10.Size = new Size(110, 69);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.Black;
            ClearButton.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = Color.White;
            ClearButton.Location = new Point(130, 330);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(110, 69);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // signPlus
            // 
            signPlus.BackColor = Color.Black;
            signPlus.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            signPlus.ForeColor = Color.White;
            signPlus.Location = new Point(359, 85);
            signPlus.Name = "signPlus";
            signPlus.Size = new Size(110, 69);
            signPlus.TabIndex = 13;
            signPlus.Text = "+";
            signPlus.UseVisualStyleBackColor = false;
            signPlus.Click += signPlus_Click;
            // 
            // signMinus
            // 
            signMinus.BackColor = Color.Black;
            signMinus.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            signMinus.ForeColor = Color.White;
            signMinus.Location = new Point(359, 170);
            signMinus.Name = "signMinus";
            signMinus.Size = new Size(110, 69);
            signMinus.TabIndex = 14;
            signMinus.Text = "-";
            signMinus.UseVisualStyleBackColor = false;
            signMinus.Click += signMinus_Click;
            // 
            // signDivide
            // 
            signDivide.BackColor = Color.Black;
            signDivide.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            signDivide.ForeColor = Color.White;
            signDivide.Location = new Point(359, 330);
            signDivide.Name = "signDivide";
            signDivide.Size = new Size(110, 69);
            signDivide.TabIndex = 16;
            signDivide.Text = "/";
            signDivide.UseVisualStyleBackColor = false;
            // 
            // CrossSign
            // 
            CrossSign.BackColor = Color.Black;
            CrossSign.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            CrossSign.ForeColor = Color.White;
            CrossSign.Location = new Point(359, 255);
            CrossSign.Name = "CrossSign";
            CrossSign.Size = new Size(110, 69);
            CrossSign.TabIndex = 15;
            CrossSign.Text = "*";
            CrossSign.UseVisualStyleBackColor = false;
            CrossSign.Click += CrossSign_Click;
            // 
            // equal
            // 
            equal.BackColor = Color.Black;
            equal.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            equal.ForeColor = Color.White;
            equal.Location = new Point(246, 330);
            equal.Name = "equal";
            equal.Size = new Size(110, 69);
            equal.TabIndex = 16;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += equal_Click;
            // 
            // divide
            // 
            divide.BackColor = Color.Black;
            divide.Font = new Font("MS UI Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            divide.ForeColor = Color.White;
            divide.Location = new Point(363, 330);
            divide.Name = "divide";
            divide.Size = new Size(110, 69);
            divide.TabIndex = 17;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            divide.Click += divide_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 418);
            Controls.Add(divide);
            Controls.Add(equal);
            Controls.Add(CrossSign);
            Controls.Add(signMinus);
            Controls.Add(signPlus);
            Controls.Add(ClearButton);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button ClearButton;
        private Button button12;
        private Button signPlus;
        private Button signMinus;
        private Button sign;
        private Button signDivide;
        private Button CrossSign;
        private Button equal;
        private Button divide;
    }
}