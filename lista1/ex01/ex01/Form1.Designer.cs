namespace ex01
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(56, 450);
            button1.Name = "button1";
            button1.Size = new Size(123, 54);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(126, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(126, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(126, 195);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(126, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 68);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 5;
            label1.Text = "nome do aluno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 130);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 6;
            label2.Text = "1° nota";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 195);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "2° nota";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 264);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "3° nota";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(126, 328);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(75, 331);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "4° nota";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(371, 65);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 68);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 12;
            label6.Text = "aulas dadas";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(371, 130);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 135);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 14;
            label7.Text = "faltas";
            // 
            // button2
            // 
            button2.Location = new Point(305, 450);
            button2.Name = "button2";
            button2.Size = new Size(123, 54);
            button2.TabIndex = 15;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 559);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Button button2;
    }
}
