namespace DiceGame
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
            label1 = new Label();
            txtf_puan = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button_oyuncu1 = new Button();
            button_oyuncu2 = new Button();
            label_oyuncu1 = new Label();
            label3 = new Label();
            label_oyuncu2 = new Label();
            label5 = new Label();
            button_tekrar = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 31);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Oyun kaç punda bitsin";
            // 
            // txtf_puan
            // 
            txtf_puan.Location = new Point(254, 31);
            txtf_puan.Name = "txtf_puan";
            txtf_puan.Size = new Size(100, 23);
            txtf_puan.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(254, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(139, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button_oyuncu1
            // 
            button_oyuncu1.Location = new Point(52, 267);
            button_oyuncu1.Name = "button_oyuncu1";
            button_oyuncu1.Size = new Size(139, 34);
            button_oyuncu1.TabIndex = 4;
            button_oyuncu1.Text = "oyuncu 1";
            button_oyuncu1.UseVisualStyleBackColor = true;
            button_oyuncu1.Click += button_oyuncu1_Click;
            // 
            // button_oyuncu2
            // 
            button_oyuncu2.AccessibleName = "";
            button_oyuncu2.Location = new Point(254, 267);
            button_oyuncu2.Name = "button_oyuncu2";
            button_oyuncu2.Size = new Size(139, 34);
            button_oyuncu2.TabIndex = 5;
            button_oyuncu2.Text = "oyuncu 2";
            button_oyuncu2.UseVisualStyleBackColor = true;
            button_oyuncu2.Click += button_oyuncu2_Click;
            // 
            // label_oyuncu1
            // 
            label_oyuncu1.AutoSize = true;
            label_oyuncu1.Location = new Point(58, 247);
            label_oyuncu1.Name = "label_oyuncu1";
            label_oyuncu1.Size = new Size(59, 15);
            label_oyuncu1.TabIndex = 6;
            label_oyuncu1.Text = "oyuncu 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 247);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 7;
            label3.Text = "0";
            // 
            // label_oyuncu2
            // 
            label_oyuncu2.AutoSize = true;
            label_oyuncu2.Location = new Point(254, 247);
            label_oyuncu2.Name = "label_oyuncu2";
            label_oyuncu2.Size = new Size(59, 15);
            label_oyuncu2.TabIndex = 8;
            label_oyuncu2.Text = "oyuncu 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(352, 247);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 9;
            label5.Text = "0";
            // 
            // button_tekrar
            // 
            button_tekrar.Location = new Point(174, 332);
            button_tekrar.Name = "button_tekrar";
            button_tekrar.Size = new Size(139, 34);
            button_tekrar.TabIndex = 10;
            button_tekrar.Text = "oyuna tekrar başla";
            button_tekrar.UseVisualStyleBackColor = true;
            button_tekrar.Click += button_tekrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 314);
            label6.Name = "label6";
            label6.Size = new Size(139, 15);
            label6.TabIndex = 11;
            label6.Text = "oyunu 1. oyuncu kazandı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 378);
            Controls.Add(label6);
            Controls.Add(button_tekrar);
            Controls.Add(label5);
            Controls.Add(label_oyuncu2);
            Controls.Add(label3);
            Controls.Add(label_oyuncu1);
            Controls.Add(button_oyuncu2);
            Controls.Add(button_oyuncu1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtf_puan);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtf_puan;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button_oyuncu1;
        private Button button_oyuncu2;
        private Label label_oyuncu1;
        private Label label3;
        private Label label_oyuncu2;
        private Label label5;
        private Button button_tekrar;
        private Label label6;
    }
}