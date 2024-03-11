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
            cbservico = new ComboBox();
            label2 = new Label();
            nudaltura = new NumericUpDown();
            label3 = new Label();
            nudperimetro = new NumericUpDown();
            label4 = new Label();
            rbaterramento = new RadioButton();
            cbmaterial = new ComboBox();
            label5 = new Label();
            rbdescidas = new RadioButton();
            gbspda = new GroupBox();
            label14 = new Label();
            nudpcaptor = new NumericUpDown();
            cbnp = new ComboBox();
            label13 = new Label();
            rbcaptor = new RadioButton();
            gbaterramento = new GroupBox();
            cbarranjo = new ComboBox();
            cbmaterialAterramento = new ComboBox();
            nudpontos = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            gblaudo = new GroupBox();
            rbquantidade = new RadioButton();
            rbperimetro = new RadioButton();
            nudlaudo = new NumericUpDown();
            cbtipo = new ComboBox();
            cbedificacao = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            nudquantidade = new NumericUpDown();
            nudvalor = new NumericUpDown();
            label12 = new Label();
            label9 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudaltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudperimetro).BeginInit();
            gbspda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudpcaptor).BeginInit();
            gbaterramento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudpontos).BeginInit();
            gblaudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudlaudo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudquantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudvalor).BeginInit();
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
            bsalvar.Click += bsalvar_Click;
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
            balterar.Click += balterar_Click;
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
            label1.Location = new Point(3, 428);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 20;
            label1.Text = "Adicionar";
            // 
            // tbconsulta
            // 
            tbconsulta.Location = new Point(91, 430);
            tbconsulta.Name = "tbconsulta";
            tbconsulta.Size = new Size(269, 23);
            tbconsulta.TabIndex = 19;
            // 
            // dgvconsulta
            // 
            dgvconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulta.Location = new Point(607, 75);
            dgvconsulta.Name = "dgvconsulta";
            dgvconsulta.Size = new Size(219, 426);
            dgvconsulta.TabIndex = 18;
            // 
            // cbservico
            // 
            cbservico.FormattingEnabled = true;
            cbservico.Items.AddRange(new object[] { "SPDA", "Aterramento", "Laudo" });
            cbservico.Location = new Point(3, 98);
            cbservico.Name = "cbservico";
            cbservico.Size = new Size(70, 23);
            cbservico.TabIndex = 23;
            cbservico.SelectedIndexChanged += tbservico_SelectedIndexChanged;
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
            // nudaltura
            // 
            nudaltura.DecimalPlaces = 2;
            nudaltura.Font = new Font("Century Gothic", 9.75F);
            nudaltura.Location = new Point(106, 104);
            nudaltura.Name = "nudaltura";
            nudaltura.Size = new Size(75, 23);
            nudaltura.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 80);
            label3.Name = "label3";
            label3.Size = new Size(20, 21);
            label3.TabIndex = 26;
            label3.Text = "h";
            // 
            // nudperimetro
            // 
            nudperimetro.DecimalPlaces = 2;
            nudperimetro.Font = new Font("Century Gothic", 9.75F);
            nudperimetro.Location = new Point(2, 47);
            nudperimetro.Name = "nudperimetro";
            nudperimetro.Size = new Size(87, 23);
            nudperimetro.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 23);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 28;
            label4.Text = "Perimetro";
            // 
            // rbaterramento
            // 
            rbaterramento.AutoSize = true;
            rbaterramento.Location = new Point(151, 174);
            rbaterramento.Name = "rbaterramento";
            rbaterramento.Size = new Size(90, 19);
            rbaterramento.TabIndex = 30;
            rbaterramento.TabStop = true;
            rbaterramento.Text = "aterramento";
            rbaterramento.UseVisualStyleBackColor = true;
            // 
            // cbmaterial
            // 
            cbmaterial.FormattingEnabled = true;
            cbmaterial.Items.AddRange(new object[] { "Barra chata", "Cobre", "Rebar", "Cordoalha" });
            cbmaterial.Location = new Point(106, 47);
            cbmaterial.Name = "cbmaterial";
            cbmaterial.Size = new Size(135, 23);
            cbmaterial.TabIndex = 31;
            cbmaterial.SelectedIndexChanged += cbmaterial_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(106, 23);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 32;
            label5.Text = "material";
            // 
            // rbdescidas
            // 
            rbdescidas.AutoSize = true;
            rbdescidas.Location = new Point(68, 174);
            rbdescidas.Name = "rbdescidas";
            rbdescidas.Size = new Size(70, 19);
            rbdescidas.TabIndex = 33;
            rbdescidas.TabStop = true;
            rbdescidas.Text = "descidas";
            rbdescidas.UseVisualStyleBackColor = true;
            // 
            // gbspda
            // 
            gbspda.Controls.Add(label14);
            gbspda.Controls.Add(nudpcaptor);
            gbspda.Controls.Add(cbnp);
            gbspda.Controls.Add(label13);
            gbspda.Controls.Add(cbmaterial);
            gbspda.Controls.Add(rbdescidas);
            gbspda.Controls.Add(nudaltura);
            gbspda.Controls.Add(label5);
            gbspda.Controls.Add(label3);
            gbspda.Controls.Add(nudperimetro);
            gbspda.Controls.Add(rbaterramento);
            gbspda.Controls.Add(label4);
            gbspda.Controls.Add(rbcaptor);
            gbspda.Location = new Point(3, 128);
            gbspda.Name = "gbspda";
            gbspda.Size = new Size(258, 215);
            gbspda.TabIndex = 34;
            gbspda.TabStop = false;
            gbspda.Text = "SPDA";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(3, 78);
            label14.Name = "label14";
            label14.Size = new Size(80, 21);
            label14.TabIndex = 39;
            label14.Text = "P/captor";
            // 
            // nudpcaptor
            // 
            nudpcaptor.DecimalPlaces = 2;
            nudpcaptor.Font = new Font("Century Gothic", 9.75F);
            nudpcaptor.Location = new Point(2, 104);
            nudpcaptor.Name = "nudpcaptor";
            nudpcaptor.Size = new Size(87, 23);
            nudpcaptor.TabIndex = 38;
            // 
            // cbnp
            // 
            cbnp.FormattingEnabled = true;
            cbnp.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbnp.Location = new Point(187, 104);
            cbnp.Name = "cbnp";
            cbnp.Size = new Size(54, 23);
            cbnp.TabIndex = 37;
            cbnp.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(187, 79);
            label13.Name = "label13";
            label13.Size = new Size(31, 21);
            label13.TabIndex = 36;
            label13.Text = "np";
            // 
            // rbcaptor
            // 
            rbcaptor.AutoSize = true;
            rbcaptor.Location = new Point(3, 174);
            rbcaptor.Name = "rbcaptor";
            rbcaptor.Size = new Size(59, 19);
            rbcaptor.TabIndex = 29;
            rbcaptor.TabStop = true;
            rbcaptor.Text = "captor";
            rbcaptor.UseVisualStyleBackColor = true;
            // 
            // gbaterramento
            // 
            gbaterramento.Controls.Add(cbarranjo);
            gbaterramento.Controls.Add(cbmaterialAterramento);
            gbaterramento.Controls.Add(nudpontos);
            gbaterramento.Controls.Add(label6);
            gbaterramento.Controls.Add(label7);
            gbaterramento.Controls.Add(label8);
            gbaterramento.Location = new Point(270, 128);
            gbaterramento.Name = "gbaterramento";
            gbaterramento.Size = new Size(315, 99);
            gbaterramento.TabIndex = 35;
            gbaterramento.TabStop = false;
            gbaterramento.Text = "Aterramento";
            // 
            // cbarranjo
            // 
            cbarranjo.FormattingEnabled = true;
            cbarranjo.Items.AddRange(new object[] { "triangular", "linear" });
            cbarranjo.Location = new Point(111, 69);
            cbarranjo.Name = "cbarranjo";
            cbarranjo.Size = new Size(74, 23);
            cbarranjo.TabIndex = 34;
            // 
            // cbmaterialAterramento
            // 
            cbmaterialAterramento.FormattingEnabled = true;
            cbmaterialAterramento.Location = new Point(222, 69);
            cbmaterialAterramento.Name = "cbmaterialAterramento";
            cbmaterialAterramento.Size = new Size(86, 23);
            cbmaterialAterramento.TabIndex = 31;
            // 
            // nudpontos
            // 
            nudpontos.Font = new Font("Century Gothic", 9.75F);
            nudpontos.Location = new Point(13, 69);
            nudpontos.Name = "nudpontos";
            nudpontos.Size = new Size(59, 23);
            nudpontos.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(222, 45);
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
            // gblaudo
            // 
            gblaudo.Controls.Add(rbquantidade);
            gblaudo.Controls.Add(rbperimetro);
            gblaudo.Controls.Add(nudlaudo);
            gblaudo.Controls.Add(cbtipo);
            gblaudo.Controls.Add(cbedificacao);
            gblaudo.Controls.Add(label10);
            gblaudo.Controls.Add(label11);
            gblaudo.Location = new Point(270, 247);
            gblaudo.Name = "gblaudo";
            gblaudo.Size = new Size(315, 96);
            gblaudo.TabIndex = 36;
            gblaudo.TabStop = false;
            gblaudo.Text = "Laudo";
            // 
            // rbquantidade
            // 
            rbquantidade.AutoSize = true;
            rbquantidade.Location = new Point(260, 23);
            rbquantidade.Name = "rbquantidade";
            rbquantidade.Size = new Size(52, 19);
            rbquantidade.TabIndex = 39;
            rbquantidade.TabStop = true;
            rbquantidade.Text = "qant.";
            rbquantidade.UseVisualStyleBackColor = true;
            // 
            // rbperimetro
            // 
            rbperimetro.AutoSize = true;
            rbperimetro.Location = new Point(212, 22);
            rbperimetro.Name = "rbperimetro";
            rbperimetro.Size = new Size(42, 19);
            rbperimetro.TabIndex = 34;
            rbperimetro.TabStop = true;
            rbperimetro.Text = "per";
            rbperimetro.UseVisualStyleBackColor = true;
            // 
            // nudlaudo
            // 
            nudlaudo.DecimalPlaces = 2;
            nudlaudo.Font = new Font("Century Gothic", 9.75F);
            nudlaudo.Location = new Point(222, 69);
            nudlaudo.Name = "nudlaudo";
            nudlaudo.Size = new Size(86, 23);
            nudlaudo.TabIndex = 38;
            // 
            // cbtipo
            // 
            cbtipo.FormattingEnabled = true;
            cbtipo.Location = new Point(10, 69);
            cbtipo.Name = "cbtipo";
            cbtipo.Size = new Size(74, 23);
            cbtipo.TabIndex = 35;
            // 
            // cbedificacao
            // 
            cbedificacao.FormattingEnabled = true;
            cbedificacao.Items.AddRange(new object[] { "Blocos", "Outras " });
            cbedificacao.Location = new Point(111, 69);
            cbedificacao.Name = "cbedificacao";
            cbedificacao.Size = new Size(94, 23);
            cbedificacao.TabIndex = 34;
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
            // nudquantidade
            // 
            nudquantidade.Font = new Font("Century Gothic", 9.75F);
            nudquantidade.Location = new Point(381, 430);
            nudquantidade.Name = "nudquantidade";
            nudquantidade.Size = new Size(74, 23);
            nudquantidade.TabIndex = 35;
            // 
            // nudvalor
            // 
            nudvalor.DecimalPlaces = 2;
            nudvalor.Font = new Font("Century Gothic", 9.75F);
            nudvalor.Location = new Point(492, 430);
            nudvalor.Name = "nudvalor";
            nudvalor.Size = new Size(86, 23);
            nudvalor.TabIndex = 37;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(381, 406);
            label12.Name = "label12";
            label12.Size = new Size(62, 21);
            label12.TabIndex = 38;
            label12.Text = "Quant";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(492, 406);
            label9.Name = "label9";
            label9.Size = new Size(49, 21);
            label9.TabIndex = 39;
            label9.Text = "valor";
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
            button4.TabIndex = 40;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(nudvalor);
            Controls.Add(nudquantidade);
            Controls.Add(gblaudo);
            Controls.Add(gbaterramento);
            Controls.Add(gbspda);
            Controls.Add(label2);
            Controls.Add(cbservico);
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
            ((System.ComponentModel.ISupportInitialize)nudaltura).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudperimetro).EndInit();
            gbspda.ResumeLayout(false);
            gbspda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudpcaptor).EndInit();
            gbaterramento.ResumeLayout(false);
            gbaterramento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudpontos).EndInit();
            gblaudo.ResumeLayout(false);
            gblaudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudlaudo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudquantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudvalor).EndInit();
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
        private ComboBox cbservico;
        private Label label2;
        private NumericUpDown nudaltura;
        private Label label3;
        private NumericUpDown nudperimetro;
        private Label label4;
        private RadioButton rbaterramento;
        private ComboBox cbmaterial;
        private Label label5;
        private RadioButton rbdescidas;
        private GroupBox gbspda;
        private GroupBox gbaterramento;
        private ComboBox cbmaterialAterramento;
        private NumericUpDown nudpontos;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbarranjo;
        private GroupBox gblaudo;
        private ComboBox cbedificacao;
        private Label label10;
        private Label label11;
        private ComboBox cbtipo;
        private NumericUpDown nudquantidade;
        private NumericUpDown nudvalor;
        private NumericUpDown nudlaudo;
        private RadioButton rbquantidade;
        private RadioButton rbperimetro;
        private Label label12;
        private Label label9;
        private Button button4;
        private RadioButton rbcaptor;
        private Label label13;
        private ComboBox cbnp;
        private NumericUpDown nudpcaptor;
        private Label label14;
    }
}
