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
            label20 = new Label();
            nudcomissao = new NumericUpDown();
            label19 = new Label();
            label18 = new Label();
            nudmargemmaterial = new NumericUpDown();
            nudmargemmao = new NumericUpDown();
            label12 = new Label();
            nudimp = new NumericUpDown();
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
            nudtotalimposto = new NumericUpDown();
            nudimposto = new NumericUpDown();
            nudtotal = new NumericUpDown();
            label1 = new Label();
            label9 = new Label();
            nudmmaodeobra = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            nudmmaterial = new NumericUpDown();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvconsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudaltura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudperimetro).BeginInit();
            gbspda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudcomissao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudmargemmaterial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudmargemmao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudimp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudpcaptor).BeginInit();
            gbaterramento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudpontos).BeginInit();
            gblaudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudlaudo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudtotalimposto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudimposto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudtotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudmmaodeobra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudmmaterial).BeginInit();
            SuspendLayout();
            // 
            // dgvconsulta
            // 
            dgvconsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvconsulta.Location = new Point(31, 312);
            dgvconsulta.Name = "dgvconsulta";
            dgvconsulta.Size = new Size(637, 199);
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
            nudaltura.Location = new Point(101, 104);
            nudaltura.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudaltura.Name = "nudaltura";
            nudaltura.Size = new Size(45, 23);
            nudaltura.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(101, 80);
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
            cbmaterial.Location = new Point(101, 47);
            cbmaterial.Name = "cbmaterial";
            cbmaterial.Size = new Size(139, 23);
            cbmaterial.TabIndex = 31;
            cbmaterial.SelectedIndexChanged += cbmaterial_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 23);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 32;
            label5.Text = "material";
            // 
            // gbspda
            // 
            gbspda.Controls.Add(label20);
            gbspda.Controls.Add(nudcomissao);
            gbspda.Controls.Add(label19);
            gbspda.Controls.Add(label18);
            gbspda.Controls.Add(nudmargemmaterial);
            gbspda.Controls.Add(nudmargemmao);
            gbspda.Controls.Add(label12);
            gbspda.Controls.Add(nudimp);
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
            gbspda.Location = new Point(432, 31);
            gbspda.Name = "gbspda";
            gbspda.Size = new Size(370, 254);
            gbspda.TabIndex = 34;
            gbspda.TabStop = false;
            gbspda.Text = "SPDA";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.Location = new Point(270, 156);
            label20.Name = "label20";
            label20.Size = new Size(69, 17);
            label20.TabIndex = 57;
            label20.Text = "comissão";
            // 
            // nudcomissao
            // 
            nudcomissao.Font = new Font("Century Gothic", 9.75F);
            nudcomissao.Location = new Point(270, 175);
            nudcomissao.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudcomissao.Name = "nudcomissao";
            nudcomissao.Size = new Size(87, 23);
            nudcomissao.TabIndex = 56;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.Location = new Point(242, 84);
            label19.Name = "label19";
            label19.Size = new Size(122, 17);
            label19.TabIndex = 55;
            label19.Text = "margem material";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(246, 12);
            label18.Name = "label18";
            label18.Size = new Size(95, 34);
            label18.TabIndex = 53;
            label18.Text = "margem \r\nmão de obra\r\n";
            // 
            // nudmargemmaterial
            // 
            nudmargemmaterial.Font = new Font("Century Gothic", 9.75F);
            nudmargemmaterial.Location = new Point(247, 104);
            nudmargemmaterial.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudmargemmaterial.Name = "nudmargemmaterial";
            nudmargemmaterial.Size = new Size(106, 23);
            nudmargemmaterial.TabIndex = 52;
            // 
            // nudmargemmao
            // 
            nudmargemmao.Font = new Font("Century Gothic", 9.75F);
            nudmargemmao.Location = new Point(246, 47);
            nudmargemmao.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudmargemmao.Name = "nudmargemmao";
            nudmargemmao.Size = new Size(107, 23);
            nudmargemmao.TabIndex = 51;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(152, 80);
            label12.Name = "label12";
            label12.Size = new Size(39, 21);
            label12.TabIndex = 46;
            label12.Text = "imp";
            // 
            // nudimp
            // 
            nudimp.Font = new Font("Century Gothic", 9.75F);
            nudimp.Location = new Point(152, 104);
            nudimp.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudimp.Name = "nudimp";
            nudimp.Size = new Size(41, 23);
            nudimp.TabIndex = 45;
            // 
            // bcalc
            // 
            bcalc.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bcalc.Location = new Point(318, 210);
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
            bexc.Location = new Point(270, 210);
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
            cbaterramento.Location = new Point(6, 216);
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
            cbcaptor.Location = new Point(6, 170);
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
            cbdescidas.Location = new Point(6, 192);
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
            label14.Location = new Point(5, 78);
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
            cbnp.Location = new Point(199, 104);
            cbnp.Name = "cbnp";
            cbnp.Size = new Size(37, 23);
            cbnp.TabIndex = 37;
            cbnp.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(199, 80);
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
            gbaterramento.Location = new Point(111, 31);
            gbaterramento.Name = "gbaterramento";
            gbaterramento.Size = new Size(315, 122);
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
            gblaudo.Location = new Point(111, 175);
            gblaudo.Name = "gblaudo";
            gblaudo.Size = new Size(315, 110);
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
            button4.Location = new Point(808, 3);
            button4.Name = "button4";
            button4.Size = new Size(29, 37);
            button4.TabIndex = 40;
            button4.Text = "x";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // nudtotalimposto
            // 
            nudtotalimposto.DecimalPlaces = 2;
            nudtotalimposto.Enabled = false;
            nudtotalimposto.Font = new Font("Century Gothic", 9.75F);
            nudtotalimposto.Location = new Point(758, 488);
            nudtotalimposto.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudtotalimposto.Name = "nudtotalimposto";
            nudtotalimposto.Size = new Size(79, 23);
            nudtotalimposto.TabIndex = 45;
            // 
            // nudimposto
            // 
            nudimposto.DecimalPlaces = 2;
            nudimposto.Enabled = false;
            nudimposto.Font = new Font("Century Gothic", 9.75F);
            nudimposto.Location = new Point(675, 488);
            nudimposto.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudimposto.Name = "nudimposto";
            nudimposto.Size = new Size(75, 23);
            nudimposto.TabIndex = 46;
            // 
            // nudtotal
            // 
            nudtotal.DecimalPlaces = 2;
            nudtotal.Enabled = false;
            nudtotal.Font = new Font("Century Gothic", 9.75F);
            nudtotal.ImeMode = ImeMode.NoControl;
            nudtotal.Location = new Point(679, 329);
            nudtotal.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudtotal.Name = "nudtotal";
            nudtotal.Size = new Size(75, 23);
            nudtotal.TabIndex = 47;
            nudtotal.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(679, 305);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 48;
            label1.Text = "valor";
            label1.Click += label1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(677, 464);
            label9.Name = "label9";
            label9.Size = new Size(72, 21);
            label9.TabIndex = 49;
            label9.Text = "imposto";
            // 
            // nudmmaodeobra
            // 
            nudmmaodeobra.DecimalPlaces = 2;
            nudmmaodeobra.Enabled = false;
            nudmmaodeobra.Font = new Font("Century Gothic", 9.75F);
            nudmmaodeobra.Location = new Point(679, 436);
            nudmmaodeobra.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudmmaodeobra.Name = "nudmmaodeobra";
            nudmmaodeobra.Size = new Size(92, 23);
            nudmmaodeobra.TabIndex = 50;
            nudmmaodeobra.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(676, 401);
            label15.Name = "label15";
            label15.Size = new Size(95, 34);
            label15.TabIndex = 51;
            label15.Text = "m/ \r\nmao de obra\r\n";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(758, 464);
            label16.Name = "label16";
            label16.Size = new Size(48, 21);
            label16.TabIndex = 52;
            label16.Text = "total\r\n";
            // 
            // nudmmaterial
            // 
            nudmmaterial.DecimalPlaces = 2;
            nudmmaterial.Enabled = false;
            nudmmaterial.Font = new Font("Century Gothic", 9.75F);
            nudmmaterial.Location = new Point(679, 375);
            nudmmaterial.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            nudmmaterial.Name = "nudmmaterial";
            nudmmaterial.Size = new Size(83, 23);
            nudmmaterial.TabIndex = 53;
            nudmmaterial.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(679, 355);
            label17.Name = "label17";
            label17.Size = new Size(81, 17);
            label17.TabIndex = 54;
            label17.Text = "m/material";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label17);
            Controls.Add(nudmmaterial);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(nudmmaodeobra);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(nudtotal);
            Controls.Add(nudimposto);
            Controls.Add(nudtotalimposto);
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
            ((System.ComponentModel.ISupportInitialize)nudcomissao).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudmargemmaterial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudmargemmao).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudimp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudpcaptor).EndInit();
            gbaterramento.ResumeLayout(false);
            gbaterramento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudpontos).EndInit();
            gblaudo.ResumeLayout(false);
            gblaudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudlaudo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudtotalimposto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudimposto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudtotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudmmaodeobra).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudmmaterial).EndInit();
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
        public NumericUpDown nudtotalimposto;
        public NumericUpDown nudimposto;
        public NumericUpDown nudtotal;
        private Label label1;
        private Label label12;
        public NumericUpDown nudimp;
        private Label label9;
        public NumericUpDown nudmmaodeobra;
        private Label label15;
        private Label label16;
        public NumericUpDown nudmmaterial;
        private Label label17;
        public NumericUpDown nudmargemmaterial;
        public NumericUpDown nudmargemmao;
        private Label label19;
        private Label label18;
        private Label label20;
        public NumericUpDown nudcomissao;
    }
}
