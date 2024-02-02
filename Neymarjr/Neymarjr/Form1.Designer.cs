namespace Neymarjr
{
    partial class Neymarjr
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
            button1 = new Button();
            imagem2 = new PictureBox();
            textBox1 = new TextBox();
            imagem1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imagem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagem1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 0;
            label1.Text = "Neymar Junior";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(171, 43);
            button1.Name = "button1";
            button1.Size = new Size(125, 44);
            button1.TabIndex = 1;
            button1.Text = "Sim";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imagem2
            // 
            imagem2.Image = Neymarjr.Properties.Resources.neymar;
            imagem2.Location = new Point(12, 104);
            imagem2.Name = "imagem2";
            imagem2.Size = new Size(720, 267);
            imagem2.TabIndex = 2;
            imagem2.TabStop = false;
            imagem2.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Digite aqui";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // imagem1
            // 
            imagem1.Image = Neymarjr.Properties.Resources.neyney;
            imagem1.Location = new Point(814, 54);
            imagem1.Name = "imagem1";
            imagem1.Size = new Size(375, 370);
            imagem1.SizeMode = PictureBoxSizeMode.StretchImage;
            imagem1.TabIndex = 4;
            imagem1.TabStop = false;
            // 
            // Neymarjr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1238, 501);
            Controls.Add(imagem1);
            Controls.Add(textBox1);
            Controls.Add(imagem2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Neymarjr";
            Text = "Neymarjr";
            ((System.ComponentModel.ISupportInitialize)imagem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagem1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private PictureBox imagem2;
        private TextBox textBox1;
        private PictureBox imagem1;
    }
}
