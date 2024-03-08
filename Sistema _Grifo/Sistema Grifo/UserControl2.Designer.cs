namespace Sistema_Grifo
{
    partial class UserControl2
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            bcancelar = new Button();
            bexcluir = new Button();
            bsalvar = new Button();
            balterar = new Button();
            bnovo = new Button();
            label1 = new Label();
            tbconsulta = new TextBox();
            dgvconsulta = new DataGridView();
            comboBox1 = new ComboBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            label5 = new Label();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            comboBox4 = new ComboBox();
            comboBox3 = new ComboBox();
            numericUpDown3 = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            comboBox7 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // bcancelar
            // 
            bcancelar.Font = new Font("Century Gothic", 12F);
            bcancelar.Image = (Image)resources.GetObject("bcancelar.Image");
            bcancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bcancelar.Location = new Point(607, 3);
            bcancelar.Name = "bcancelar";
            bcancelar.Size = new Size(126, 54);
            bcancelar.TabIndex = 9;
            bcancelar.Text = "Cancelar";
            bcancelar.TextAlign = ContentAlignment.MiddleRight;
            bcancelar.UseVisualStyleBackColor = true;
            // 
            // bexcluir
            // 
            bexcluir.Font = new Font("Century Gothic", 12F);
            bexcluir.Image = (Image)resources.GetObject("bexcluir.Image");
            bexcluir.ImageAlign = ContentAlignment.MiddleLeft;
            bexcluir.Location = new Point(475, 3);
            bexcluir.Name = "bexcluir";
            bexcluir.Size = new Size(126, 54);
            bexcluir.TabIndex = 8;
            bexcluir.Text = "Excluir";
            bexcluir.TextAlign = ContentAlignment.MiddleRight;
            bexcluir.UseVisualStyleBackColor = true;
            // 
            // bsalvar
            // 
            bsalvar.Font = new Font("Century Gothic", 12F);
            bsalvar.Image = (Image)resources.GetObject("bsalvar.Image");
            bsalvar.ImageAlign = ContentAlignment.MiddleLeft;
            bsalvar.Location = new Point(270, 3);
            bsalvar.Name = "bsalvar";
            bsalvar.Size = new Size(126, 54);
            bsalvar.TabIndex = 7;
            bsalvar.Text = "Salvar";
            bsalvar.TextAlign = ContentAlignment.MiddleRight;
            bsalvar.UseVisualStyleBackColor = true;
            // 
            // balterar
            // 
            balterar.Font = new Font("Century Gothic", 12F);
            balterar.Image = (Image)resources.GetObject("balterar.Image");
            balterar.ImageAlign = ContentAlignment.MiddleLeft;
            balterar.Location = new Point(138, 3);
            balterar.Name = "balterar";
            balterar.Size = new Size(126, 54);
            balterar.TabIndex = 6;
            balterar.Text = "Alterar";
            balterar.TextAlign = ContentAlignment.MiddleRight;
            balterar.UseVisualStyleBackColor = true;
            // 
            // bnovo
            // 
            bnovo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnovo.Image = (Image)resources.GetObject("bnovo.Image");
            bnovo.ImageAlign = ContentAlignment.MiddleLeft;
            bnovo.Location = new Point(6, 3);
            bnovo.Name = "bnovo";
            bnovo.Size = new Size(126, 54);
            bnovo.TabIndex = 5;
            bnovo.Text = " Novo";
            bnovo.TextAlign = ContentAlignment.MiddleRight;
            bnovo.UseVisualStyleBackColor = true;
            bnovo.Click += bnovo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 417);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 20;
            label1.Text = "Adicionar";
            // 
            // tbconsulta
            // 
            tbconsulta.Location = new Point(101, 417);
            tbconsulta.Name = "tbconsulta";
            tbconsulta.Size = new Size(725, 23);
            tbconsulta.TabIndex = 19;
            // 
            // dgvconsulta
            // 
            dgvconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulta.Location = new Point(15, 467);
            dgvconsulta.Name = "dgvconsulta";
            dgvconsulta.Size = new Size(811, 34);
            dgvconsulta.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SPDA", "Aterramento", "Laudo" });
            comboBox1.Location = new Point(3, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(70, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(5, 75);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 24;
            label2.Text = "Serviço";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(10, 39);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 23);
            numericUpDown1.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(10, 15);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 26;
            label3.Text = "Altura";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(9, 147);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(84, 23);
            numericUpDown2.TabIndex = 27;
            numericUpDown2.ValueChanged += this.numericUpDown2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 123);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 28;
            label4.Text = "Perimetro";
            label4.Click += this.label4_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(162, 43);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 19);
            radioButton1.TabIndex = 29;
            radioButton1.TabStop = true;
            radioButton1.Text = "captor";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(162, 147);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 19);
            radioButton2.TabIndex = 30;
            radioButton2.TabStop = true;
            radioButton2.Text = "aterramento";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(10, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(74, 23);
            comboBox2.TabIndex = 31;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 67);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 32;
            label5.Text = "material";
            label5.Click += this.label5_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(162, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(70, 19);
            radioButton3.TabIndex = 33;
            radioButton3.TabStop = true;
            radioButton3.Text = "descidas";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(3, 128);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 200);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBox4);
            groupBox2.Controls.Add(comboBox3);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(286, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(315, 99);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(111, 69);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(74, 23);
            comboBox4.TabIndex = 34;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(234, 69);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(74, 23);
            comboBox3.TabIndex = 31;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(13, 69);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(59, 23);
            numericUpDown3.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 45);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 32;
            label6.Text = "material";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 45);
            label7.Name = "label7";
            label7.Size = new Size(64, 21);
            label7.TabIndex = 26;
            label7.Text = "pontos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(111, 45);
            label8.Name = "label8";
            label8.Size = new Size(65, 21);
            label8.TabIndex = 28;
            label8.Text = "arranjo";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox7);
            groupBox3.Controls.Add(comboBox5);
            groupBox3.Controls.Add(comboBox6);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Location = new Point(286, 232);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(315, 96);
            groupBox3.TabIndex = 36;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Location = new Point(10, 69);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(74, 23);
            comboBox7.TabIndex = 35;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(111, 69);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(94, 23);
            comboBox5.TabIndex = 34;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Location = new Point(234, 69);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(74, 23);
            comboBox6.TabIndex = 31;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(10, 45);
            label10.Name = "label10";
            label10.Size = new Size(42, 21);
            label10.TabIndex = 26;
            label10.Text = "Tipo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(111, 45);
            label11.Name = "label11";
            label11.Size = new Size(94, 21);
            label11.TabIndex = 28;
            label11.Text = "edificação";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(tbconsulta);
            Controls.Add(dgvconsulta);
            Controls.Add(bcancelar);
            Controls.Add(bexcluir);
            Controls.Add(bsalvar);
            Controls.Add(balterar);
            Controls.Add(bnovo);
            Name = "UserControl2";
            Size = new Size(840, 523);
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bcancelar;
        private Button bexcluir;
        private Button bsalvar;
        private Button balterar;
        private Button bnovo;
        private Label label1;
        private TextBox tbconsulta;
        private DataGridView dgvconsulta;
        private ComboBox comboBox1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private Label label5;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox3;
        private NumericUpDown numericUpDown3;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox4;
        private GroupBox groupBox3;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label10;
        private Label label11;
        private ComboBox comboBox7;
    }
}
