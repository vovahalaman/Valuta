namespace Valuta
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(94, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 0;
            textBox1.Text = "37.250";
            toolTip1.SetToolTip(textBox1, "Введіть курс купівлі.");
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(545, 105);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 21);
            textBox2.TabIndex = 1;
            textBox2.Text = "37.750";
            toolTip1.SetToolTip(textBox2, "Введіть курс продажу.");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(330, 51);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Обмін валют";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(350, 105);
            label2.Name = "label2";
            label2.Size = new Size(40, 26);
            label2.TabIndex = 3;
            label2.Text = "<=";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(330, 156);
            label3.Name = "label3";
            label3.Size = new Size(96, 17);
            label3.TabIndex = 4;
            label3.Text = "Курси валют";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(106, 80);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(71, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "Купівля";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(562, 80);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Продаж";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 242);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 7;
            label4.Text = "USD";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(94, 265);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 21);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(545, 265);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 21);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(545, 242);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 10;
            label5.Text = "Гривні";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(94, 358);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 11;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(545, 358);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 12;
            button2.Text = "Вихід";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(330, 358);
            button3.Name = "button3";
            button3.Size = new Size(100, 29);
            button3.TabIndex = 13;
            button3.Text = "Очищення";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Convertor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
    }
}