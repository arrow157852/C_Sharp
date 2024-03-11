namespace Sistema_Grifo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            Pnpainel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1086, 13);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumSpringGreen;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(241, 535);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 64);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.AutoEllipsis = true;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 360);
            button3.Name = "button3";
            button3.Size = new Size(238, 82);
            button3.TabIndex = 2;
            button3.Text = "        laudos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(3, 256);
            button2.Name = "button2";
            button2.Size = new Size(238, 82);
            button2.TabIndex = 1;
            button2.Text = "                  Orçamentos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 152);
            button1.Name = "button1";
            button1.Size = new Size(238, 82);
            button1.TabIndex = 0;
            button1.Text = "         Registro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(1044, 12);
            button4.Name = "button4";
            button4.Size = new Size(42, 47);
            button4.TabIndex = 0;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(239, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(844, 535);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(239, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(844, 535);
            panel4.TabIndex = 2;
            // 
            // Pnpainel
            // 
            Pnpainel.Location = new Point(239, 12);
            Pnpainel.Name = "Pnpainel";
            Pnpainel.Size = new Size(847, 535);
            Pnpainel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1084, 548);
            Controls.Add(Pnpainel);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private UserControl1 PnRegistro;
        private PictureBox pictureBox1;
        private Button button4;
        private Panel panel3;
        private Panel panel4;
        private Panel Pnpainel;
    }
}
