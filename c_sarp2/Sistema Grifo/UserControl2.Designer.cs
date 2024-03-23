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
            dgvconsulta = new DataGridView();
            cbservico = new ComboBox();
            label2 = new Label();
            nudaltura = new NumericUpDown();
            label3 = new Label();
            nudperimetro = new NumericUpDown();
            label4 = new Label();
            cbmaterial = new ComboBox();
            label5 = new Label();
            gbspda = new GroupBox();
            bcalc = new Button();
            bexc = new Button();
            cbaterramento = new CheckBox();
            cbcaptor = new CheckBox();
            cbdescidas = new CheckBox();
            label14 = new Label();
            nudpcaptor = new NumericUpDown();
            cbnp = new ComboBox();
            label13 = new Label();
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
            SuspendLayout();
            // 
            // dgvconsulta
            // 
            dgvconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulta.Location = new Point(31, 336);
            dgvconsulta.Name = "dgvconsulta";
            dgvconsulta.Size = new Size(769, 184);
            dgvconsulta.TabIndex = 18;
            // 
            // cbservico
            // 
            cbservico.FormattingEnabled = true;
            cbservico.Items.AddRange(new object[] { "SPDA", "Aterramento", "Laudo" });
            cbservico.Location = new Point(10, 54);
            cbservico.Name = "cbservico";
            cbservico.Size = new Size(70, 23);
            cbservico.TabIndex = 23;
            cbservico.SelectedIndexChanged += tbservico_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 31);
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
            nudaltura.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
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
            nudperimetro.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
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
            // gbspda
            // 
            gbspda.Controls.Add(bcalc);
            gbspda.Controls.Add(bexc);
            gbspda.Controls.Add(cbaterramento);
            gbspda.Controls.Add(cbcaptor);
            gbspda.Controls.Add(cbdescidas);
            gbspda.Controls.Add(label14);
            gbspda.Controls.Add(nudpcaptor);
            gbspda.Controls.Add(cbnp);
            gbspda.Controls.Add(label13);
            gbspda.Controls.Add(cbmaterial);
            gbspda.Controls.Add(nudaltura);
            gbspda.Controls.Add(label5);
            gbspda.Controls.Add(label3);
            gbspda.Controls.Add(nudperimetro);
            gbspda.Controls.Add(label4);
            gbspda.Location = new Point(494, 54);
            gbspda.Name = "gbspda";
            gbspda.Size = new Size(258, 215);
            gbspda.TabIndex = 34;
            gbspda.TabStop = false;
            gbspda.Text = "SPDA";
            // 
            // bcalc
            // 
            bcalc.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bcalc.Location = new Point(195, 181);
            bcalc.Name = "bcalc";
            bcalc.Size = new Size(39, 23);
            bcalc.TabIndex = 44;
            bcalc.Text = "calc";
            bcalc.UseVisualStyleBackColor = true;
            bcalc.Click += bcalc_Click;
            // 
            // bexc
            // 
            bexc.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bexc.Location = new Point(143, 181);
            bexc.Name = "bexc";
            bexc.Size = new Size(38, 23);
            bexc.TabIndex = 43;
            bexc.Text = "exc";
            bexc.UseVisualStyleBackColor = true;
            bexc.Click += button1_Click;
            // 
            // cbaterramento
            // 
            cbaterramento.AutoSize = true;
            cbaterramento.FlatStyle = FlatStyle.System;
            cbaterramento.Location = new Point(6, 188);
            cbaterramento.Name = "cbaterramento";
            cbaterramento.Size = new Size(97, 20);
            cbaterramento.TabIndex = 42;
            cbaterramento.Text = "aterramento";
            cbaterramento.UseVisualStyleBackColor = true;
            cbaterramento.CheckedChanged += cbaterramento_CheckedChanged;
            // 
            // cbcaptor
            // 
            cbcaptor.AutoSize = true;
            cbcaptor.FlatStyle = FlatStyle.System;
            cbcaptor.Location = new Point(6, 142);
            cbcaptor.Name = "cbcaptor";
            cbcaptor.Size = new Size(66, 20);
            cbcaptor.TabIndex = 41;
            cbcaptor.Text = "captor";
            cbcaptor.UseVisualStyleBackColor = true;
            cbcaptor.CheckedChanged += cbcaptor_CheckedChanged;
            // 
            // cbdescidas
            // 
            cbdescidas.AutoSize = true;
            cbdescidas.FlatStyle = FlatStyle.System;
            cbdescidas.Location = new Point(6, 164);
            cbdescidas.Name = "cbdescidas";
            cbdescidas.Size = new Size(77, 20);
            cbdescidas.TabIndex = 40;
            cbdescidas.Text = "descidas";
            cbdescidas.UseVisualStyleBackColor = true;
            cbdescidas.CheckedChanged += cbdescidas_CheckedChanged;
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
            nudpcaptor.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
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
            // gbaterramento
            // 
            gbaterramento.Controls.Add(cbarranjo);
            gbaterramento.Controls.Add(cbmaterialAterramento);
            gbaterramento.Controls.Add(nudpontos);
            gbaterramento.Controls.Add(label6);
            gbaterramento.Controls.Add(label7);
            gbaterramento.Controls.Add(label8);
            gbaterramento.Location = new Point(145, 54);
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
            nudpontos.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
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
            gblaudo.Location = new Point(145, 173);
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
            Controls.Add(gblaudo);
            Controls.Add(gbaterramento);
            Controls.Add(gbspda);
            Controls.Add(label2);
            Controls.Add(cbservico);
            Controls.Add(dgvconsulta);
            Name = "UserControl2";
            Size = new Size(840, 523);
            Load += UserControl2_Load;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox gbspda;
        private GroupBox gbaterramento;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox gblaudo;
        private Label label10;
        private Label label11;
        private RadioButton rbquantidade;
        private RadioButton rbperimetro;
        private Button button4;
        private Label label13;
        private Label label14;
        public DataGridView dgvconsulta;
        public ComboBox cbservico;
        public NumericUpDown nudaltura;
        public NumericUpDown nudperimetro;
        public ComboBox cbmaterial;
        public ComboBox cbmaterialAterramento;
        public NumericUpDown nudpontos;
        public ComboBox cbarranjo;
        public ComboBox cbedificacao;
        public ComboBox cbtipo;
        public NumericUpDown nudlaudo;
        public ComboBox cbnp;
        public NumericUpDown nudpcaptor;
        private CheckBox cbaterramento;
        private CheckBox cbcaptor;
        private CheckBox cbdescidas;
        private Button bexc;
        private Button bcalc;
    }
}
