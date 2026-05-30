namespace TugasProject_PBO
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            colorDialog1 = new ColorDialog();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(801, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(0, 64, 64);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(596, 285);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Keep Going Guys!!";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // colorDialog1
            // 
            colorDialog1.Color = Color.RosyBrown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 78);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(14, 25);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "YES";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(645, 25);
            button2.Name = "button2";
            button2.Size = new Size(145, 29);
            button2.TabIndex = 1;
            button2.Text = "I Don't Thing So";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Winter Draw", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(257, 20);
            label1.Name = "label1";
            label1.Size = new Size(263, 41);
            label1.TabIndex = 2;
            label1.Text = "Are You Crazy?!";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(121, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(134, 10);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(520, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(119, 10);
            panel3.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private ColorDialog colorDialog1;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private Panel panel3;
        private Panel panel2;
    }
}