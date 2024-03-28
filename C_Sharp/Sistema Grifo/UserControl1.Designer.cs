namespace Sistema_Grifo
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            bnovo = new Button();
            balterar = new Button();
            bsalvar = new Button();
            bexcluir = new Button();
            bcancelar = new Button();
            dgvconsulta = new DataGridView();
            cbtabela = new ComboBox();
            tbconsulta = new TextBox();
            label1 = new Label();
            tbid = new TextBox();
            tbdescricao = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            button4 = new Button();
            label15 = new Label();
            label12 = new Label();
            nudvalortotal = new NumericUpDown();
            nudquantidade = new NumericUpDown();
            cbcategoria = new ComboBox();
            label6 = new Label();
            gbTemporario = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudvalortotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudquantidade).BeginInit();
            gbTemporario.SuspendLayout();
            SuspendLayout();
            // 
            // bnovo
            // 
            bnovo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnovo.Image = (Image)resources.GetObject("bnovo.Image");
            bnovo.ImageAlign = ContentAlignment.MiddleLeft;
            bnovo.Location = new Point(15, 3);
            bnovo.Name = "bnovo";
            bnovo.Size = new Size(126, 54);
            bnovo.TabIndex = 0;
            bnovo.Text = " Novo";
            bnovo.TextAlign = ContentAlignment.MiddleRight;
            bnovo.UseVisualStyleBackColor = true;
            bnovo.Click += bnovo_Click_1;
            // 
            // balterar
            // 
            balterar.Font = new Font("Century Gothic", 12F);
            balterar.Image = (Image)resources.GetObject("balterar.Image");
            balterar.ImageAlign = ContentAlignment.MiddleLeft;
            balterar.Location = new Point(147, 3);
            balterar.Name = "balterar";
            balterar.Size = new Size(126, 54);
            balterar.TabIndex = 1;
            balterar.Text = "Alterar";
            balterar.TextAlign = ContentAlignment.MiddleRight;
            balterar.UseVisualStyleBackColor = true;
            balterar.Click += balterar_Click;
            // 
            // bsalvar
            // 
            bsalvar.Font = new Font("Century Gothic", 12F);
            bsalvar.Image = (Image)resources.GetObject("bsalvar.Image");
            bsalvar.ImageAlign = ContentAlignment.MiddleLeft;
            bsalvar.Location = new Point(279, 3);
            bsalvar.Name = "bsalvar";
            bsalvar.Size = new Size(126, 54);
            bsalvar.TabIndex = 2;
            bsalvar.Text = "Salvar";
            bsalvar.TextAlign = ContentAlignment.MiddleRight;
            bsalvar.UseVisualStyleBackColor = true;
            bsalvar.Click += button3_Click;
            // 
            // bexcluir
            // 
            bexcluir.Font = new Font("Century Gothic", 12F);
            bexcluir.Image = (Image)resources.GetObject("bexcluir.Image");
            bexcluir.ImageAlign = ContentAlignment.MiddleLeft;
            bexcluir.Location = new Point(484, 3);
            bexcluir.Name = "bexcluir";
            bexcluir.Size = new Size(126, 54);
            bexcluir.TabIndex = 3;
            bexcluir.Text = "Excluir";
            bexcluir.TextAlign = ContentAlignment.MiddleRight;
            bexcluir.UseVisualStyleBackColor = true;
            bexcluir.Click += bexcluir_Click_1;
            // 
            // bcancelar
            // 
            bcancelar.Font = new Font("Century Gothic", 12F);
            bcancelar.Image = (Image)resources.GetObject("bcancelar.Image");
            bcancelar.ImageAlign = ContentAlignment.MiddleLeft;
            bcancelar.Location = new Point(616, 3);
            bcancelar.Name = "bcancelar";
            bcancelar.Size = new Size(126, 54);
            bcancelar.TabIndex = 4;
            bcancelar.Text = "Cancelar";
            bcancelar.TextAlign = ContentAlignment.MiddleRight;
            bcancelar.UseVisualStyleBackColor = true;
            bcancelar.Click += bcancelar_Click_1;
            // 
            // dgvconsulta
            // 
            dgvconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulta.Location = new Point(15, 307);
            dgvconsulta.Name = "dgvconsulta";
            dgvconsulta.Size = new Size(811, 196);
            dgvconsulta.TabIndex = 5;
            dgvconsulta.CellContentClick += dgvconsulta_CellContentClick_1;
            // 
            // cbtabela
            // 
            cbtabela.FormattingEnabled = true;
            cbtabela.Items.AddRange(new object[] { "Mão de obra", "Material", "Diversos", "TabelaTemporaria" });
            cbtabela.Location = new Point(15, 110);
            cbtabela.Name = "cbtabela";
            cbtabela.Size = new Size(133, 23);
            cbtabela.TabIndex = 6;
            cbtabela.SelectedIndexChanged += cbtabela_SelectedIndexChanged_1;
            // 
            // tbconsulta
            // 
            tbconsulta.Location = new Point(101, 259);
            tbconsulta.Name = "tbconsulta";
            tbconsulta.Size = new Size(725, 23);
            tbconsulta.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 259);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 8;
            label1.Text = "Consulta";
            // 
            // tbid
            // 
            tbid.Location = new Point(15, 196);
            tbid.Name = "tbid";
            tbid.Size = new Size(47, 23);
            tbid.TabIndex = 9;
            // 
            // tbdescricao
            // 
            tbdescricao.Location = new Point(80, 196);
            tbdescricao.Name = "tbdescricao";
            tbdescricao.Size = new Size(510, 23);
            tbdescricao.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.Location = new Point(15, 172);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 12;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.Location = new Point(80, 172);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 13;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.Location = new Point(596, 172);
            label4.Name = "label4";
            label4.Size = new Size(50, 21);
            label4.TabIndex = 14;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.CausesValidation = false;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 83);
            label5.Name = "label5";
            label5.Size = new Size(133, 21);
            label5.TabIndex = 15;
            label5.Text = "Tipo de Registro";
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(596, 196);
            numericUpDown1.Maximum = new decimal(new int[] { 1316134911, 2328, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(105, 23);
            numericUpDown1.TabIndex = 16;
            numericUpDown1.Tag = "";
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged_2;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.Red;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(795, 3);
            button4.Name = "button4";
            button4.Size = new Size(42, 47);
            button4.TabIndex = 17;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(17, 117);
            label15.Name = "label15";
            label15.Size = new Size(91, 21);
            label15.TabIndex = 49;
            label15.Text = "valor total";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(41, 17);
            label12.Name = "label12";
            label12.Size = new Size(62, 21);
            label12.TabIndex = 48;
            label12.Text = "Quant";
            // 
            // nudvalortotal
            // 
            nudvalortotal.DecimalPlaces = 2;
            nudvalortotal.Font = new Font("Century Gothic", 9.75F);
            nudvalortotal.Location = new Point(10, 141);
            nudvalortotal.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudvalortotal.Name = "nudvalortotal";
            nudvalortotal.Size = new Size(93, 23);
            nudvalortotal.TabIndex = 47;
            // 
            // nudquantidade
            // 
            nudquantidade.Font = new Font("Century Gothic", 9.75F);
            nudquantidade.Location = new Point(29, 41);
            nudquantidade.Name = "nudquantidade";
            nudquantidade.Size = new Size(74, 23);
            nudquantidade.TabIndex = 46;
            nudquantidade.ValueChanged += nudquantidade_ValueChanged_1;
            // 
            // cbcategoria
            // 
            cbcategoria.FormattingEnabled = true;
            cbcategoria.Items.AddRange(new object[] { "Material", "Mão de obra", "Custos diversos" });
            cbcategoria.Location = new Point(12, 91);
            cbcategoria.Name = "cbcategoria";
            cbcategoria.Size = new Size(91, 23);
            cbcategoria.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.Location = new Point(20, 67);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 51;
            label6.Text = "categoria";
            // 
            // gbTemporario
            // 
            gbTemporario.Controls.Add(label6);
            gbTemporario.Controls.Add(nudquantidade);
            gbTemporario.Controls.Add(nudvalortotal);
            gbTemporario.Controls.Add(label12);
            gbTemporario.Controls.Add(cbcategoria);
            gbTemporario.Controls.Add(label15);
            gbTemporario.Location = new Point(708, 56);
            gbTemporario.Name = "gbTemporario";
            gbTemporario.Size = new Size(118, 197);
            gbTemporario.TabIndex = 52;
            gbTemporario.TabStop = false;
            gbTemporario.Text = "Temporario";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbdescricao);
            Controls.Add(tbid);
            Controls.Add(label1);
            Controls.Add(tbconsulta);
            Controls.Add(cbtabela);
            Controls.Add(dgvconsulta);
            Controls.Add(bcancelar);
            Controls.Add(bexcluir);
            Controls.Add(bsalvar);
            Controls.Add(balterar);
            Controls.Add(bnovo);
            Controls.Add(gbTemporario);
            Name = "UserControl1";
            Size = new Size(840, 523);
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudvalortotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudquantidade).EndInit();
            gbTemporario.ResumeLayout(false);
            gbTemporario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnovo;
        private Button balterar;
        private Button bsalvar;
        private Button bexcluir;
        private Button bcancelar;
        private DataGridView dgvconsulta;
        private Label label1;
       
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public NumericUpDown numericUpDown1;
        private Button button4;
        public ComboBox cbtabela;
        public TextBox tbconsulta;
        public TextBox tbid;
        public TextBox tbdescricao;
        private Label label15;
        private Label label12;
        public NumericUpDown nudvalortotal;
        public NumericUpDown nudquantidade;
        public ComboBox cbcategoria;
        private Label label6;
        private GroupBox gbTemporario;
    }
}
