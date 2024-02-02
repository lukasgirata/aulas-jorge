namespace calculadora
{
    partial class Calculadora
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite um valor: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 52);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 1;
            label2.Text = "Digite outro valor: ";
            label2.Click += label2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // botaosoma
            // 
            botaosoma.Location = new Point(29, 92);
            botaosoma.Name = "botaosoma";
            botaosoma.Size = new Size(75, 23);
            botaosoma.TabIndex = 4;
            botaosoma.Text = "+";
            botaosoma.UseVisualStyleBackColor = true;
            botaosoma.Click += this.botaosoma;
            // 
            // botaomult
            // 
            botaomult.Location = new Point(29, 143);
            botaomult.Name = "botaomult";
            botaomult.Size = new Size(75, 23);
            botaomult.TabIndex = 5;
            botaomult.Text = "*";
            botaomult.UseVisualStyleBackColor = true;
            botaomult.Click += this.botaomult;
            // 
            // botaomenos
            // 
            botaomenos.Location = new Point(140, 92);
            botaomenos.Name = "botaomenos";
            botaomenos.Size = new Size(75, 23);
            botaomenos.TabIndex = 6;
            botaomenos.Text = "-";
            botaomenos.UseVisualStyleBackColor = true;
            botaomenos.Click += this.botaomenos;
            // 
            // botaodiv
            // 
            botaodiv.Location = new Point(140, 143);
            botaodiv.Name = "botaodiv";
            botaodiv.Size = new Size(75, 23);
            botaodiv.TabIndex = 7;
            botaodiv.Text = "/";
            botaodiv.UseVisualStyleBackColor = true;
            botaodiv.Click += this.botaodiv;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 450);
            Controls.Add(botaodiv);
            Controls.Add(botaomenos);
            Controls.Add(botaomult);
            Controls.Add(botaosoma);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Calculadora";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
       
    }
}
