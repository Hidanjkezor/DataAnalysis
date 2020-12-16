namespace GraphDataAnalysis
{
    partial class GraphForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.numericUpDownGraphNo = new System.Windows.Forms.NumericUpDown();
            this.graphLabel = new System.Windows.Forms.Label();
            this.dtLabel = new System.Windows.Forms.Label();
            this.dtTextBox = new System.Windows.Forms.TextBox();
            this.nTextBox = new System.Windows.Forms.TextBox();
            this.nLabel = new System.Windows.Forms.Label();
            this.linearGroupBox = new System.Windows.Forms.GroupBox();
            this.addLinearButton = new System.Windows.Forms.Button();
            this.dTextBox = new System.Windows.Forms.TextBox();
            this.dLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.bLabel = new System.Windows.Forms.Label();
            this.aLabel = new System.Windows.Forms.Label();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.ExpGoupBox = new System.Windows.Forms.GroupBox();
            this.addExpButton = new System.Windows.Forms.Button();
            this.randomGroupBox = new System.Windows.Forms.GroupBox();
            this.RandomTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.addRandomButton = new System.Windows.Forms.Button();
            this.sLabel = new System.Windows.Forms.Label();
            this.sTextBox = new System.Windows.Forms.TextBox();
            this.sinGroupBox = new System.Windows.Forms.GroupBox();
            this.addSinButton = new System.Windows.Forms.Button();
            this.fTextBox = new System.Windows.Forms.TextBox();
            this.fLabel = new System.Windows.Forms.Label();
            this.AmpLabel = new System.Windows.Forms.Label();
            this.ampTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.openAnalyserButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.plotter_dat_button = new System.Windows.Forms.Button();
            this.dataFilePath_textBox = new System.Windows.Forms.TextBox();
            this.Open_File_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.anti_noise = new System.Windows.Forms.Button();
            this.with_grph = new System.Windows.Forms.CheckBox();
            this.anti_noise_n = new System.Windows.Forms.Label();
            this.anti_noise_n_text_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shiftButton = new System.Windows.Forms.Button();
            this.shiftValueLabel = new System.Windows.Forms.Label();
            this.shiftValueTextBox = new System.Windows.Forms.TextBox();
            this.AntiShiftGroupBox = new System.Windows.Forms.GroupBox();
            this.antiShiftButton = new System.Windows.Forms.Button();
            this.BadHeatButton = new System.Windows.Forms.Button();
            this.spikeGroupBox = new System.Windows.Forms.GroupBox();
            this.spikeCountTextbox = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.spikeSizeLabel = new System.Windows.Forms.Label();
            this.spikeSizeTextbox = new System.Windows.Forms.TextBox();
            this.addSpikesButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.antiSpikeGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.antiSpikeSTextBox = new System.Windows.Forms.TextBox();
            this.proceedAntiSpikeButton = new System.Windows.Forms.Button();
            this.CardioPlotter = new System.Windows.Forms.Button();
            this.AntiTrendGroupBox = new System.Windows.Forms.GroupBox();
            this.ExecAntiTrendButton = new System.Windows.Forms.Button();
            this.WindowSizeLabel = new System.Windows.Forms.Label();
            this.WindowSizeTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.applyBsPotterButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.bs_fc_2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bs_m = new System.Windows.Forms.TextBox();
            this.Potter_BS_button = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.bs_fc1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.applyBpFilterButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.bp_fc_2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bp_m = new System.Windows.Forms.TextBox();
            this.Potter_BP_button = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.bp_fc1 = new System.Windows.Forms.TextBox();
            this.Potter_HPF = new System.Windows.Forms.GroupBox();
            this.applyHpFilterButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.m_Hp = new System.Windows.Forms.TextBox();
            this.Potter_HPF_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.fc_Hp = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.applyLpFilterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_textBox = new System.Windows.Forms.TextBox();
            this.Potter_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fc_textBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Save_wav_button = new System.Windows.Forms.Button();
            this.plot_for_wav_button = new System.Windows.Forms.Button();
            this.Wav_textbox = new System.Windows.Forms.TextBox();
            this.Wav_OpenButton = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.Rate_Texbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmf_plot_button = new System.Windows.Forms.Button();
            this.dtmf_textbox = new System.Windows.Forms.TextBox();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.Rate_to_dt_textBox = new System.Windows.Forms.TextBox();
            this.convert_rateDT_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cut_button = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cut_from_textbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cut_to_texbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphNo)).BeginInit();
            this.linearGroupBox.SuspendLayout();
            this.ExpGoupBox.SuspendLayout();
            this.randomGroupBox.SuspendLayout();
            this.sinGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AntiShiftGroupBox.SuspendLayout();
            this.spikeGroupBox.SuspendLayout();
            this.antiSpikeGroupBox.SuspendLayout();
            this.AntiTrendGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Potter_HPF.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(416, 282);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(434, 12);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(416, 282);
            this.zedGraphControl2.TabIndex = 1;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(12, 300);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(416, 282);
            this.zedGraphControl3.TabIndex = 2;
            this.zedGraphControl3.UseExtendedPrintDialog = true;
            // 
            // numericUpDownGraphNo
            // 
            this.numericUpDownGraphNo.Location = new System.Drawing.Point(907, 12);
            this.numericUpDownGraphNo.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownGraphNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGraphNo.Name = "numericUpDownGraphNo";
            this.numericUpDownGraphNo.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownGraphNo.TabIndex = 4;
            this.numericUpDownGraphNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(856, 14);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(45, 13);
            this.graphLabel.TabIndex = 5;
            this.graphLabel.Text = "График";
            // 
            // dtLabel
            // 
            this.dtLabel.AutoSize = true;
            this.dtLabel.Location = new System.Drawing.Point(977, 41);
            this.dtLabel.Name = "dtLabel";
            this.dtLabel.Size = new System.Drawing.Size(16, 13);
            this.dtLabel.TabIndex = 6;
            this.dtLabel.Text = "dt";
            // 
            // dtTextBox
            // 
            this.dtTextBox.Location = new System.Drawing.Point(999, 38);
            this.dtTextBox.Name = "dtTextBox";
            this.dtTextBox.Size = new System.Drawing.Size(79, 20);
            this.dtTextBox.TabIndex = 7;
            this.dtTextBox.Text = "0,001";
            this.dtTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // nTextBox
            // 
            this.nTextBox.Location = new System.Drawing.Point(1105, 38);
            this.nTextBox.Name = "nTextBox";
            this.nTextBox.Size = new System.Drawing.Size(79, 20);
            this.nTextBox.TabIndex = 9;
            this.nTextBox.Text = "1000";
            this.nTextBox.TextChanged += new System.EventHandler(this.IntParamTextBox_TextChanged);
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Location = new System.Drawing.Point(1084, 41);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(15, 13);
            this.nLabel.TabIndex = 8;
            this.nLabel.Text = "N";
            // 
            // linearGroupBox
            // 
            this.linearGroupBox.Controls.Add(this.addLinearButton);
            this.linearGroupBox.Controls.Add(this.dTextBox);
            this.linearGroupBox.Controls.Add(this.dLabel);
            this.linearGroupBox.Controls.Add(this.cLabel);
            this.linearGroupBox.Controls.Add(this.cTextBox);
            this.linearGroupBox.Location = new System.Drawing.Point(0, 3);
            this.linearGroupBox.Name = "linearGroupBox";
            this.linearGroupBox.Size = new System.Drawing.Size(344, 51);
            this.linearGroupBox.TabIndex = 10;
            this.linearGroupBox.TabStop = false;
            this.linearGroupBox.Text = "Линейный";
            // 
            // addLinearButton
            // 
            this.addLinearButton.Location = new System.Drawing.Point(261, 17);
            this.addLinearButton.Name = "addLinearButton";
            this.addLinearButton.Size = new System.Drawing.Size(75, 23);
            this.addLinearButton.TabIndex = 15;
            this.addLinearButton.Text = "Добавить";
            this.addLinearButton.UseVisualStyleBackColor = true;
            this.addLinearButton.Click += new System.EventHandler(this.addLinearButton_Click);
            // 
            // dTextBox
            // 
            this.dTextBox.Location = new System.Drawing.Point(155, 19);
            this.dTextBox.Name = "dTextBox";
            this.dTextBox.Size = new System.Drawing.Size(100, 20);
            this.dTextBox.TabIndex = 14;
            this.dTextBox.Text = "1";
            this.dTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(134, 22);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(13, 13);
            this.dLabel.TabIndex = 13;
            this.dLabel.Text = "d";
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Location = new System.Drawing.Point(6, 22);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(13, 13);
            this.cLabel.TabIndex = 11;
            this.cLabel.Text = "c";
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(28, 19);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(100, 20);
            this.cTextBox.TabIndex = 12;
            this.cTextBox.Text = "1";
            this.cTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(892, 38);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(79, 20);
            this.fromTextBox.TabIndex = 12;
            this.fromTextBox.Text = "0";
            this.fromTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(856, 41);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(30, 13);
            this.fromLabel.TabIndex = 11;
            this.fromLabel.Text = "From";
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(155, 19);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(100, 20);
            this.bTextBox.TabIndex = 14;
            this.bTextBox.Text = "1";
            this.bTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(134, 22);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(13, 13);
            this.bLabel.TabIndex = 13;
            this.bLabel.Text = "b";
            // 
            // aLabel
            // 
            this.aLabel.AutoSize = true;
            this.aLabel.Location = new System.Drawing.Point(6, 22);
            this.aLabel.Name = "aLabel";
            this.aLabel.Size = new System.Drawing.Size(13, 13);
            this.aLabel.TabIndex = 11;
            this.aLabel.Text = "a";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(28, 19);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(100, 20);
            this.aTextBox.TabIndex = 12;
            this.aTextBox.Text = "1";
            this.aTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // ExpGoupBox
            // 
            this.ExpGoupBox.Controls.Add(this.addExpButton);
            this.ExpGoupBox.Controls.Add(this.bTextBox);
            this.ExpGoupBox.Controls.Add(this.bLabel);
            this.ExpGoupBox.Controls.Add(this.aLabel);
            this.ExpGoupBox.Controls.Add(this.aTextBox);
            this.ExpGoupBox.Location = new System.Drawing.Point(0, 60);
            this.ExpGoupBox.Name = "ExpGoupBox";
            this.ExpGoupBox.Size = new System.Drawing.Size(344, 51);
            this.ExpGoupBox.TabIndex = 16;
            this.ExpGoupBox.TabStop = false;
            this.ExpGoupBox.Text = "Экспонента";
            // 
            // addExpButton
            // 
            this.addExpButton.Location = new System.Drawing.Point(261, 17);
            this.addExpButton.Name = "addExpButton";
            this.addExpButton.Size = new System.Drawing.Size(75, 23);
            this.addExpButton.TabIndex = 15;
            this.addExpButton.Text = "Добавить";
            this.addExpButton.UseVisualStyleBackColor = true;
            this.addExpButton.Click += new System.EventHandler(this.addExpButton_Click);
            // 
            // randomGroupBox
            // 
            this.randomGroupBox.Controls.Add(this.RandomTypeCheckBox);
            this.randomGroupBox.Controls.Add(this.addRandomButton);
            this.randomGroupBox.Controls.Add(this.sLabel);
            this.randomGroupBox.Controls.Add(this.sTextBox);
            this.randomGroupBox.Location = new System.Drawing.Point(0, 117);
            this.randomGroupBox.Name = "randomGroupBox";
            this.randomGroupBox.Size = new System.Drawing.Size(344, 51);
            this.randomGroupBox.TabIndex = 17;
            this.randomGroupBox.TabStop = false;
            this.randomGroupBox.Text = "Рандом";
            // 
            // RandomTypeCheckBox
            // 
            this.RandomTypeCheckBox.AutoSize = true;
            this.RandomTypeCheckBox.Location = new System.Drawing.Point(134, 21);
            this.RandomTypeCheckBox.Name = "RandomTypeCheckBox";
            this.RandomTypeCheckBox.Size = new System.Drawing.Size(88, 17);
            this.RandomTypeCheckBox.TabIndex = 16;
            this.RandomTypeCheckBox.Text = "Мой рандом";
            this.RandomTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // addRandomButton
            // 
            this.addRandomButton.Location = new System.Drawing.Point(261, 17);
            this.addRandomButton.Name = "addRandomButton";
            this.addRandomButton.Size = new System.Drawing.Size(75, 23);
            this.addRandomButton.TabIndex = 15;
            this.addRandomButton.Text = "Добавить";
            this.addRandomButton.UseVisualStyleBackColor = true;
            this.addRandomButton.Click += new System.EventHandler(this.addRandomButton_Click);
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(6, 22);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(14, 13);
            this.sLabel.TabIndex = 11;
            this.sLabel.Text = "S";
            // 
            // sTextBox
            // 
            this.sTextBox.Location = new System.Drawing.Point(28, 19);
            this.sTextBox.Name = "sTextBox";
            this.sTextBox.Size = new System.Drawing.Size(100, 20);
            this.sTextBox.TabIndex = 12;
            this.sTextBox.Text = "100";
            this.sTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // sinGroupBox
            // 
            this.sinGroupBox.Controls.Add(this.addSinButton);
            this.sinGroupBox.Controls.Add(this.fTextBox);
            this.sinGroupBox.Controls.Add(this.fLabel);
            this.sinGroupBox.Controls.Add(this.AmpLabel);
            this.sinGroupBox.Controls.Add(this.ampTextBox);
            this.sinGroupBox.Location = new System.Drawing.Point(0, 174);
            this.sinGroupBox.Name = "sinGroupBox";
            this.sinGroupBox.Size = new System.Drawing.Size(344, 51);
            this.sinGroupBox.TabIndex = 17;
            this.sinGroupBox.TabStop = false;
            this.sinGroupBox.Text = "Синус";
            // 
            // addSinButton
            // 
            this.addSinButton.Location = new System.Drawing.Point(261, 17);
            this.addSinButton.Name = "addSinButton";
            this.addSinButton.Size = new System.Drawing.Size(75, 23);
            this.addSinButton.TabIndex = 15;
            this.addSinButton.Text = "Добавить";
            this.addSinButton.UseVisualStyleBackColor = true;
            this.addSinButton.Click += new System.EventHandler(this.addSinButton_Click);
            // 
            // fTextBox
            // 
            this.fTextBox.Location = new System.Drawing.Point(155, 19);
            this.fTextBox.Name = "fTextBox";
            this.fTextBox.Size = new System.Drawing.Size(100, 20);
            this.fTextBox.TabIndex = 14;
            this.fTextBox.Text = "1";
            this.fTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // fLabel
            // 
            this.fLabel.AutoSize = true;
            this.fLabel.Location = new System.Drawing.Point(134, 22);
            this.fLabel.Name = "fLabel";
            this.fLabel.Size = new System.Drawing.Size(10, 13);
            this.fLabel.TabIndex = 13;
            this.fLabel.Text = "f";
            // 
            // AmpLabel
            // 
            this.AmpLabel.AutoSize = true;
            this.AmpLabel.Location = new System.Drawing.Point(6, 22);
            this.AmpLabel.Name = "AmpLabel";
            this.AmpLabel.Size = new System.Drawing.Size(14, 13);
            this.AmpLabel.TabIndex = 11;
            this.AmpLabel.Text = "A";
            // 
            // ampTextBox
            // 
            this.ampTextBox.Location = new System.Drawing.Point(28, 19);
            this.ampTextBox.Name = "ampTextBox";
            this.ampTextBox.Size = new System.Drawing.Size(100, 20);
            this.ampTextBox.TabIndex = 12;
            this.ampTextBox.Text = "100";
            this.ampTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1066, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mergeButton
            // 
            this.mergeButton.Location = new System.Drawing.Point(977, 9);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(83, 23);
            this.mergeButton.TabIndex = 19;
            this.mergeButton.TabStop = false;
            this.mergeButton.Text = "Объединить";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // openAnalyserButton
            // 
            this.openAnalyserButton.Location = new System.Drawing.Point(1118, 548);
            this.openAnalyserButton.Name = "openAnalyserButton";
            this.openAnalyserButton.Size = new System.Drawing.Size(116, 34);
            this.openAnalyserButton.TabIndex = 20;
            this.openAnalyserButton.Text = "Анализатор";
            this.openAnalyserButton.UseVisualStyleBackColor = true;
            this.openAnalyserButton.Click += new System.EventHandler(this.openAnalyserButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(856, 107);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(364, 379);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.sinGroupBox);
            this.tabPage1.Controls.Add(this.linearGroupBox);
            this.tabPage1.Controls.Add(this.ExpGoupBox);
            this.tabPage1.Controls.Add(this.randomGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(356, 346);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Classic func _data";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.plotter_dat_button);
            this.groupBox6.Controls.Add(this.dataFilePath_textBox);
            this.groupBox6.Controls.Add(this.Open_File_button);
            this.groupBox6.Location = new System.Drawing.Point(0, 231);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(344, 78);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "dat-File";
            // 
            // plotter_dat_button
            // 
            this.plotter_dat_button.Location = new System.Drawing.Point(261, 45);
            this.plotter_dat_button.Name = "plotter_dat_button";
            this.plotter_dat_button.Size = new System.Drawing.Size(75, 23);
            this.plotter_dat_button.TabIndex = 28;
            this.plotter_dat_button.Text = "Построить график";
            this.plotter_dat_button.UseVisualStyleBackColor = true;
            this.plotter_dat_button.Click += new System.EventHandler(this.plotter_dat_button_Click);
            // 
            // dataFilePath_textBox
            // 
            this.dataFilePath_textBox.Location = new System.Drawing.Point(9, 19);
            this.dataFilePath_textBox.Name = "dataFilePath_textBox";
            this.dataFilePath_textBox.Size = new System.Drawing.Size(246, 20);
            this.dataFilePath_textBox.TabIndex = 27;
            // 
            // Open_File_button
            // 
            this.Open_File_button.Location = new System.Drawing.Point(261, 16);
            this.Open_File_button.Name = "Open_File_button";
            this.Open_File_button.Size = new System.Drawing.Size(75, 23);
            this.Open_File_button.TabIndex = 26;
            this.Open_File_button.Text = "Открыть файл";
            this.Open_File_button.UseVisualStyleBackColor = true;
            this.Open_File_button.Click += new System.EventHandler(this.Open_File_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.cut_to_texbox);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.cut_from_textbox);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cut_button);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.AntiShiftGroupBox);
            this.tabPage2.Controls.Add(this.BadHeatButton);
            this.tabPage2.Controls.Add(this.spikeGroupBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.antiSpikeGroupBox);
            this.tabPage2.Controls.Add(this.CardioPlotter);
            this.tabPage2.Controls.Add(this.AntiTrendGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(356, 353);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Trend/spikes/cardio";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.anti_noise);
            this.groupBox2.Controls.Add(this.with_grph);
            this.groupBox2.Controls.Add(this.anti_noise_n);
            this.groupBox2.Controls.Add(this.anti_noise_n_text_box);
            this.groupBox2.Location = new System.Drawing.Point(101, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 47);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Анти-шум";
            // 
            // anti_noise
            // 
            this.anti_noise.Location = new System.Drawing.Point(62, 17);
            this.anti_noise.Name = "anti_noise";
            this.anti_noise.Size = new System.Drawing.Size(75, 23);
            this.anti_noise.TabIndex = 15;
            this.anti_noise.Text = "Выполнить";
            this.anti_noise.UseVisualStyleBackColor = true;
            this.anti_noise.Click += new System.EventHandler(this.anti_noise_Click);
            // 
            // with_grph
            // 
            this.with_grph.AutoSize = true;
            this.with_grph.Location = new System.Drawing.Point(143, 22);
            this.with_grph.Name = "with_grph";
            this.with_grph.Size = new System.Drawing.Size(72, 17);
            this.with_grph.TabIndex = 16;
            this.with_grph.Text = "with_grph";
            this.with_grph.UseVisualStyleBackColor = true;
            // 
            // anti_noise_n
            // 
            this.anti_noise_n.AutoSize = true;
            this.anti_noise_n.Location = new System.Drawing.Point(6, 22);
            this.anti_noise_n.Name = "anti_noise_n";
            this.anti_noise_n.Size = new System.Drawing.Size(13, 13);
            this.anti_noise_n.TabIndex = 11;
            this.anti_noise_n.Text = "n";
            // 
            // anti_noise_n_text_box
            // 
            this.anti_noise_n_text_box.Location = new System.Drawing.Point(21, 19);
            this.anti_noise_n_text_box.Name = "anti_noise_n_text_box";
            this.anti_noise_n_text_box.Size = new System.Drawing.Size(35, 20);
            this.anti_noise_n_text_box.TabIndex = 12;
            this.anti_noise_n_text_box.Text = "30";
            this.anti_noise_n_text_box.TextChanged += new System.EventHandler(this.anti_noise_n_text_box_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shiftButton);
            this.groupBox1.Controls.Add(this.shiftValueLabel);
            this.groupBox1.Controls.Add(this.shiftValueTextBox);
            this.groupBox1.Location = new System.Drawing.Point(-3, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 51);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Шифт";
            // 
            // shiftButton
            // 
            this.shiftButton.Location = new System.Drawing.Point(134, 17);
            this.shiftButton.Name = "shiftButton";
            this.shiftButton.Size = new System.Drawing.Size(75, 23);
            this.shiftButton.TabIndex = 15;
            this.shiftButton.Text = "Сдвинуть";
            this.shiftButton.UseVisualStyleBackColor = true;
            this.shiftButton.Click += new System.EventHandler(this.shiftButton_Click);
            // 
            // shiftValueLabel
            // 
            this.shiftValueLabel.AutoSize = true;
            this.shiftValueLabel.Location = new System.Drawing.Point(6, 22);
            this.shiftValueLabel.Name = "shiftValueLabel";
            this.shiftValueLabel.Size = new System.Drawing.Size(34, 13);
            this.shiftValueLabel.TabIndex = 11;
            this.shiftValueLabel.Text = "Value";
            // 
            // shiftValueTextBox
            // 
            this.shiftValueTextBox.Location = new System.Drawing.Point(46, 19);
            this.shiftValueTextBox.Name = "shiftValueTextBox";
            this.shiftValueTextBox.Size = new System.Drawing.Size(82, 20);
            this.shiftValueTextBox.TabIndex = 12;
            this.shiftValueTextBox.Text = "100";
            this.shiftValueTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // AntiShiftGroupBox
            // 
            this.AntiShiftGroupBox.Controls.Add(this.antiShiftButton);
            this.AntiShiftGroupBox.Location = new System.Drawing.Point(228, 108);
            this.AntiShiftGroupBox.Name = "AntiShiftGroupBox";
            this.AntiShiftGroupBox.Size = new System.Drawing.Size(113, 51);
            this.AntiShiftGroupBox.TabIndex = 19;
            this.AntiShiftGroupBox.TabStop = false;
            this.AntiShiftGroupBox.Text = "Антишифт";
            // 
            // antiShiftButton
            // 
            this.antiShiftButton.Location = new System.Drawing.Point(22, 19);
            this.antiShiftButton.Name = "antiShiftButton";
            this.antiShiftButton.Size = new System.Drawing.Size(75, 23);
            this.antiShiftButton.TabIndex = 15;
            this.antiShiftButton.Text = "Сдвинуть";
            this.antiShiftButton.UseVisualStyleBackColor = true;
            this.antiShiftButton.Click += new System.EventHandler(this.antiShiftButton_Click);
            // 
            // BadHeatButton
            // 
            this.BadHeatButton.Location = new System.Drawing.Point(9, 269);
            this.BadHeatButton.Name = "BadHeatButton";
            this.BadHeatButton.Size = new System.Drawing.Size(83, 23);
            this.BadHeatButton.TabIndex = 24;
            this.BadHeatButton.Text = "Тахиокардия";
            this.BadHeatButton.UseVisualStyleBackColor = true;
            this.BadHeatButton.Click += new System.EventHandler(this.BadHeatButton_Click);
            // 
            // spikeGroupBox
            // 
            this.spikeGroupBox.Controls.Add(this.spikeCountTextbox);
            this.spikeGroupBox.Controls.Add(this.countLabel);
            this.spikeGroupBox.Controls.Add(this.spikeSizeLabel);
            this.spikeGroupBox.Controls.Add(this.spikeSizeTextbox);
            this.spikeGroupBox.Controls.Add(this.addSpikesButton);
            this.spikeGroupBox.Location = new System.Drawing.Point(-3, 2);
            this.spikeGroupBox.Name = "spikeGroupBox";
            this.spikeGroupBox.Size = new System.Drawing.Size(344, 47);
            this.spikeGroupBox.TabIndex = 21;
            this.spikeGroupBox.TabStop = false;
            this.spikeGroupBox.Text = "Спайк";
            // 
            // spikeCountTextbox
            // 
            this.spikeCountTextbox.Location = new System.Drawing.Point(176, 18);
            this.spikeCountTextbox.Name = "spikeCountTextbox";
            this.spikeCountTextbox.Size = new System.Drawing.Size(67, 20);
            this.spikeCountTextbox.TabIndex = 6;
            this.spikeCountTextbox.Text = "10";
            this.spikeCountTextbox.TextChanged += new System.EventHandler(this.IntParamTextBox_TextChanged);
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(134, 22);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(39, 13);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "Число";
            // 
            // spikeSizeLabel
            // 
            this.spikeSizeLabel.AutoSize = true;
            this.spikeSizeLabel.Location = new System.Drawing.Point(9, 22);
            this.spikeSizeLabel.Name = "spikeSizeLabel";
            this.spikeSizeLabel.Size = new System.Drawing.Size(46, 13);
            this.spikeSizeLabel.TabIndex = 4;
            this.spikeSizeLabel.Text = "Размер";
            // 
            // spikeSizeTextbox
            // 
            this.spikeSizeTextbox.Location = new System.Drawing.Point(61, 19);
            this.spikeSizeTextbox.Name = "spikeSizeTextbox";
            this.spikeSizeTextbox.Size = new System.Drawing.Size(67, 20);
            this.spikeSizeTextbox.TabIndex = 2;
            this.spikeSizeTextbox.Text = "10000";
            this.spikeSizeTextbox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // addSpikesButton
            // 
            this.addSpikesButton.Location = new System.Drawing.Point(261, 16);
            this.addSpikesButton.Name = "addSpikesButton";
            this.addSpikesButton.Size = new System.Drawing.Size(75, 23);
            this.addSpikesButton.TabIndex = 0;
            this.addSpikesButton.Text = "Добавить";
            this.addSpikesButton.UseVisualStyleBackColor = true;
            this.addSpikesButton.Click += new System.EventHandler(this.addSpikesButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Кардиограмма";
            // 
            // antiSpikeGroupBox
            // 
            this.antiSpikeGroupBox.Controls.Add(this.label2);
            this.antiSpikeGroupBox.Controls.Add(this.antiSpikeSTextBox);
            this.antiSpikeGroupBox.Controls.Add(this.proceedAntiSpikeButton);
            this.antiSpikeGroupBox.Location = new System.Drawing.Point(-3, 55);
            this.antiSpikeGroupBox.Name = "antiSpikeGroupBox";
            this.antiSpikeGroupBox.Size = new System.Drawing.Size(216, 47);
            this.antiSpikeGroupBox.TabIndex = 22;
            this.antiSpikeGroupBox.TabStop = false;
            this.antiSpikeGroupBox.Text = "Анти Спайк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "S";
            // 
            // antiSpikeSTextBox
            // 
            this.antiSpikeSTextBox.Location = new System.Drawing.Point(26, 20);
            this.antiSpikeSTextBox.Name = "antiSpikeSTextBox";
            this.antiSpikeSTextBox.Size = new System.Drawing.Size(100, 20);
            this.antiSpikeSTextBox.TabIndex = 7;
            this.antiSpikeSTextBox.Text = "100";
            this.antiSpikeSTextBox.TextChanged += new System.EventHandler(this.DoubleParamTextBox_TextChanged);
            // 
            // proceedAntiSpikeButton
            // 
            this.proceedAntiSpikeButton.Location = new System.Drawing.Point(132, 18);
            this.proceedAntiSpikeButton.Name = "proceedAntiSpikeButton";
            this.proceedAntiSpikeButton.Size = new System.Drawing.Size(75, 23);
            this.proceedAntiSpikeButton.TabIndex = 0;
            this.proceedAntiSpikeButton.Text = "Убрать";
            this.proceedAntiSpikeButton.UseVisualStyleBackColor = true;
            this.proceedAntiSpikeButton.Click += new System.EventHandler(this.proceedAntiSpikeButton_Click);
            // 
            // CardioPlotter
            // 
            this.CardioPlotter.Location = new System.Drawing.Point(6, 240);
            this.CardioPlotter.Name = "CardioPlotter";
            this.CardioPlotter.Size = new System.Drawing.Size(75, 23);
            this.CardioPlotter.TabIndex = 16;
            this.CardioPlotter.Text = "Выполнить";
            this.CardioPlotter.UseVisualStyleBackColor = true;
            this.CardioPlotter.Click += new System.EventHandler(this.CardioPlotter_Click);
            // 
            // AntiTrendGroupBox
            // 
            this.AntiTrendGroupBox.Controls.Add(this.ExecAntiTrendButton);
            this.AntiTrendGroupBox.Controls.Add(this.WindowSizeLabel);
            this.AntiTrendGroupBox.Controls.Add(this.WindowSizeTextBox);
            this.AntiTrendGroupBox.Location = new System.Drawing.Point(0, 165);
            this.AntiTrendGroupBox.Name = "AntiTrendGroupBox";
            this.AntiTrendGroupBox.Size = new System.Drawing.Size(222, 51);
            this.AntiTrendGroupBox.TabIndex = 19;
            this.AntiTrendGroupBox.TabStop = false;
            this.AntiTrendGroupBox.Text = "Антитренд";
            // 
            // ExecAntiTrendButton
            // 
            this.ExecAntiTrendButton.Location = new System.Drawing.Point(134, 17);
            this.ExecAntiTrendButton.Name = "ExecAntiTrendButton";
            this.ExecAntiTrendButton.Size = new System.Drawing.Size(75, 23);
            this.ExecAntiTrendButton.TabIndex = 15;
            this.ExecAntiTrendButton.Text = "Выполнить";
            this.ExecAntiTrendButton.UseVisualStyleBackColor = true;
            this.ExecAntiTrendButton.Click += new System.EventHandler(this.ExecAntiTrendButton_Click);
            // 
            // WindowSizeLabel
            // 
            this.WindowSizeLabel.AutoSize = true;
            this.WindowSizeLabel.Location = new System.Drawing.Point(6, 22);
            this.WindowSizeLabel.Name = "WindowSizeLabel";
            this.WindowSizeLabel.Size = new System.Drawing.Size(36, 13);
            this.WindowSizeLabel.TabIndex = 11;
            this.WindowSizeLabel.Text = "Wsize";
            // 
            // WindowSizeTextBox
            // 
            this.WindowSizeTextBox.Location = new System.Drawing.Point(46, 19);
            this.WindowSizeTextBox.Name = "WindowSizeTextBox";
            this.WindowSizeTextBox.Size = new System.Drawing.Size(82, 20);
            this.WindowSizeTextBox.TabIndex = 12;
            this.WindowSizeTextBox.Text = "30";
            this.WindowSizeTextBox.TextChanged += new System.EventHandler(this.IntParamTextBox_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.Potter_HPF);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(356, 346);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Potter";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.applyBsPotterButton);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.bs_fc_2);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.bs_m);
            this.groupBox5.Controls.Add(this.Potter_BS_button);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.bs_fc1);
            this.groupBox5.Location = new System.Drawing.Point(6, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(318, 75);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Поттер РФ";
            // 
            // applyBsPotterButton
            // 
            this.applyBsPotterButton.Location = new System.Drawing.Point(237, 46);
            this.applyBsPotterButton.Name = "applyBsPotterButton";
            this.applyBsPotterButton.Size = new System.Drawing.Size(75, 23);
            this.applyBsPotterButton.TabIndex = 23;
            this.applyBsPotterButton.Text = "Применить";
            this.applyBsPotterButton.UseVisualStyleBackColor = true;
            this.applyBsPotterButton.Click += new System.EventHandler(this.applyBsPotterButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "fc2";
            // 
            // bs_fc_2
            // 
            this.bs_fc_2.Location = new System.Drawing.Point(91, 19);
            this.bs_fc_2.Name = "bs_fc_2";
            this.bs_fc_2.Size = new System.Drawing.Size(23, 20);
            this.bs_fc_2.TabIndex = 20;
            this.bs_fc_2.Text = "60";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(120, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "m";
            // 
            // bs_m
            // 
            this.bs_m.Location = new System.Drawing.Point(141, 19);
            this.bs_m.Name = "bs_m";
            this.bs_m.Size = new System.Drawing.Size(23, 20);
            this.bs_m.TabIndex = 17;
            this.bs_m.Text = "64";
            // 
            // Potter_BS_button
            // 
            this.Potter_BS_button.Location = new System.Drawing.Point(237, 19);
            this.Potter_BS_button.Name = "Potter_BS_button";
            this.Potter_BS_button.Size = new System.Drawing.Size(75, 23);
            this.Potter_BS_button.TabIndex = 15;
            this.Potter_BS_button.Text = "Выполнить";
            this.Potter_BS_button.UseVisualStyleBackColor = true;
            this.Potter_BS_button.Click += new System.EventHandler(this.Potter_BS_button_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "fc1";
            // 
            // bs_fc1
            // 
            this.bs_fc1.Location = new System.Drawing.Point(28, 19);
            this.bs_fc1.Name = "bs_fc1";
            this.bs_fc1.Size = new System.Drawing.Size(23, 20);
            this.bs_fc1.TabIndex = 12;
            this.bs_fc1.Text = "25";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.applyBpFilterButton);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.bp_fc_2);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.bp_m);
            this.groupBox4.Controls.Add(this.Potter_BP_button);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.bp_fc1);
            this.groupBox4.Location = new System.Drawing.Point(6, 183);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 76);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поттер ПФ";
            // 
            // applyBpFilterButton
            // 
            this.applyBpFilterButton.Location = new System.Drawing.Point(239, 48);
            this.applyBpFilterButton.Name = "applyBpFilterButton";
            this.applyBpFilterButton.Size = new System.Drawing.Size(75, 23);
            this.applyBpFilterButton.TabIndex = 22;
            this.applyBpFilterButton.Text = "Применить";
            this.applyBpFilterButton.UseVisualStyleBackColor = true;
            this.applyBpFilterButton.Click += new System.EventHandler(this.applyBpFilterButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(63, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "fc2";
            // 
            // bp_fc_2
            // 
            this.bp_fc_2.Location = new System.Drawing.Point(85, 19);
            this.bp_fc_2.Name = "bp_fc_2";
            this.bp_fc_2.Size = new System.Drawing.Size(23, 20);
            this.bp_fc_2.TabIndex = 21;
            this.bp_fc_2.Text = "40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "m";
            // 
            // bp_m
            // 
            this.bp_m.Location = new System.Drawing.Point(140, 18);
            this.bp_m.Name = "bp_m";
            this.bp_m.Size = new System.Drawing.Size(23, 20);
            this.bp_m.TabIndex = 17;
            this.bp_m.Text = "64";
            // 
            // Potter_BP_button
            // 
            this.Potter_BP_button.Location = new System.Drawing.Point(237, 19);
            this.Potter_BP_button.Name = "Potter_BP_button";
            this.Potter_BP_button.Size = new System.Drawing.Size(75, 23);
            this.Potter_BP_button.TabIndex = 15;
            this.Potter_BP_button.Text = "Выполнить";
            this.Potter_BP_button.UseVisualStyleBackColor = true;
            this.Potter_BP_button.Click += new System.EventHandler(this.Potter_BP_button_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "fc";
            // 
            // bp_fc1
            // 
            this.bp_fc1.Location = new System.Drawing.Point(28, 19);
            this.bp_fc1.Name = "bp_fc1";
            this.bp_fc1.Size = new System.Drawing.Size(23, 20);
            this.bp_fc1.TabIndex = 12;
            this.bp_fc1.Text = "25";
            // 
            // Potter_HPF
            // 
            this.Potter_HPF.Controls.Add(this.applyHpFilterButton);
            this.Potter_HPF.Controls.Add(this.label7);
            this.Potter_HPF.Controls.Add(this.m_Hp);
            this.Potter_HPF.Controls.Add(this.Potter_HPF_button);
            this.Potter_HPF.Controls.Add(this.label8);
            this.Potter_HPF.Controls.Add(this.fc_Hp);
            this.Potter_HPF.Location = new System.Drawing.Point(6, 94);
            this.Potter_HPF.Name = "Potter_HPF";
            this.Potter_HPF.Size = new System.Drawing.Size(264, 83);
            this.Potter_HPF.TabIndex = 21;
            this.Potter_HPF.TabStop = false;
            this.Potter_HPF.Text = "Поттер ФВЧ";
            // 
            // applyHpFilterButton
            // 
            this.applyHpFilterButton.Location = new System.Drawing.Point(174, 49);
            this.applyHpFilterButton.Name = "applyHpFilterButton";
            this.applyHpFilterButton.Size = new System.Drawing.Size(75, 23);
            this.applyHpFilterButton.TabIndex = 21;
            this.applyHpFilterButton.Text = "Применить";
            this.applyHpFilterButton.UseVisualStyleBackColor = true;
            this.applyHpFilterButton.Click += new System.EventHandler(this.applyHpFilterButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "m";
            // 
            // m_Hp
            // 
            this.m_Hp.Location = new System.Drawing.Point(76, 19);
            this.m_Hp.Name = "m_Hp";
            this.m_Hp.Size = new System.Drawing.Size(23, 20);
            this.m_Hp.TabIndex = 17;
            this.m_Hp.Text = "64";
            // 
            // Potter_HPF_button
            // 
            this.Potter_HPF_button.Location = new System.Drawing.Point(173, 20);
            this.Potter_HPF_button.Name = "Potter_HPF_button";
            this.Potter_HPF_button.Size = new System.Drawing.Size(75, 23);
            this.Potter_HPF_button.TabIndex = 15;
            this.Potter_HPF_button.Text = "Выполнить";
            this.Potter_HPF_button.UseVisualStyleBackColor = true;
            this.Potter_HPF_button.Click += new System.EventHandler(this.Potter_HPF_button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "fc";
            // 
            // fc_Hp
            // 
            this.fc_Hp.Location = new System.Drawing.Point(28, 19);
            this.fc_Hp.Name = "fc_Hp";
            this.fc_Hp.Size = new System.Drawing.Size(23, 20);
            this.fc_Hp.TabIndex = 12;
            this.fc_Hp.Text = "25";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.applyLpFilterButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.m_textBox);
            this.groupBox3.Controls.Add(this.Potter_button);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.fc_textBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 82);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поттер ФНЧ";
            // 
            // applyLpFilterButton
            // 
            this.applyLpFilterButton.Location = new System.Drawing.Point(174, 49);
            this.applyLpFilterButton.Name = "applyLpFilterButton";
            this.applyLpFilterButton.Size = new System.Drawing.Size(75, 23);
            this.applyLpFilterButton.TabIndex = 20;
            this.applyLpFilterButton.Text = "Применить";
            this.applyLpFilterButton.UseVisualStyleBackColor = true;
            this.applyLpFilterButton.Click += new System.EventHandler(this.applyLpFilterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "m";
            // 
            // m_textBox
            // 
            this.m_textBox.Location = new System.Drawing.Point(76, 19);
            this.m_textBox.Name = "m_textBox";
            this.m_textBox.Size = new System.Drawing.Size(23, 20);
            this.m_textBox.TabIndex = 17;
            this.m_textBox.Text = "64";
            // 
            // Potter_button
            // 
            this.Potter_button.Location = new System.Drawing.Point(173, 20);
            this.Potter_button.Name = "Potter_button";
            this.Potter_button.Size = new System.Drawing.Size(75, 23);
            this.Potter_button.TabIndex = 15;
            this.Potter_button.Text = "Выполнить";
            this.Potter_button.UseVisualStyleBackColor = true;
            this.Potter_button.Click += new System.EventHandler(this.Potter_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "fc";
            // 
            // fc_textBox
            // 
            this.fc_textBox.Location = new System.Drawing.Point(28, 19);
            this.fc_textBox.Name = "fc_textBox";
            this.fc_textBox.Size = new System.Drawing.Size(23, 20);
            this.fc_textBox.TabIndex = 12;
            this.fc_textBox.Text = "25";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox7);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(356, 346);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Wav";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Save_wav_button);
            this.groupBox7.Controls.Add(this.plot_for_wav_button);
            this.groupBox7.Controls.Add(this.Wav_textbox);
            this.groupBox7.Controls.Add(this.Wav_OpenButton);
            this.groupBox7.Location = new System.Drawing.Point(1, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(344, 78);
            this.groupBox7.TabIndex = 32;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Wav-File";
            // 
            // Save_wav_button
            // 
            this.Save_wav_button.Location = new System.Drawing.Point(180, 45);
            this.Save_wav_button.Name = "Save_wav_button";
            this.Save_wav_button.Size = new System.Drawing.Size(75, 23);
            this.Save_wav_button.TabIndex = 29;
            this.Save_wav_button.Text = "Сохранить";
            this.Save_wav_button.UseVisualStyleBackColor = true;
            this.Save_wav_button.Click += new System.EventHandler(this.Save_wav_button_Click);
            // 
            // plot_for_wav_button
            // 
            this.plot_for_wav_button.Location = new System.Drawing.Point(261, 45);
            this.plot_for_wav_button.Name = "plot_for_wav_button";
            this.plot_for_wav_button.Size = new System.Drawing.Size(75, 23);
            this.plot_for_wav_button.TabIndex = 28;
            this.plot_for_wav_button.Text = "Построить график";
            this.plot_for_wav_button.UseVisualStyleBackColor = true;
            this.plot_for_wav_button.Click += new System.EventHandler(this.plot_for_wav_button_Click);
            // 
            // Wav_textbox
            // 
            this.Wav_textbox.Location = new System.Drawing.Point(9, 19);
            this.Wav_textbox.Name = "Wav_textbox";
            this.Wav_textbox.Size = new System.Drawing.Size(246, 20);
            this.Wav_textbox.TabIndex = 27;
            // 
            // Wav_OpenButton
            // 
            this.Wav_OpenButton.Location = new System.Drawing.Point(261, 16);
            this.Wav_OpenButton.Name = "Wav_OpenButton";
            this.Wav_OpenButton.Size = new System.Drawing.Size(75, 23);
            this.Wav_OpenButton.TabIndex = 26;
            this.Wav_OpenButton.Text = "Открыть файл";
            this.Wav_OpenButton.UseVisualStyleBackColor = true;
            this.Wav_OpenButton.Click += new System.EventHandler(this.Wav_OpenButton_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.Rate_Texbox);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.dtmf_plot_button);
            this.tabPage5.Controls.Add(this.dtmf_textbox);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(356, 346);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Coursework";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sample Rate";
            // 
            // Rate_Texbox
            // 
            this.Rate_Texbox.Location = new System.Drawing.Point(16, 82);
            this.Rate_Texbox.Name = "Rate_Texbox";
            this.Rate_Texbox.Size = new System.Drawing.Size(100, 20);
            this.Rate_Texbox.TabIndex = 3;
            this.Rate_Texbox.Text = "22050";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Введите последовательность:";
            // 
            // dtmf_plot_button
            // 
            this.dtmf_plot_button.Location = new System.Drawing.Point(214, 28);
            this.dtmf_plot_button.Name = "dtmf_plot_button";
            this.dtmf_plot_button.Size = new System.Drawing.Size(75, 23);
            this.dtmf_plot_button.TabIndex = 1;
            this.dtmf_plot_button.Text = "Построить";
            this.dtmf_plot_button.UseVisualStyleBackColor = true;
            this.dtmf_plot_button.Click += new System.EventHandler(this.dtmf_plot_button_Click);
            // 
            // dtmf_textbox
            // 
            this.dtmf_textbox.Location = new System.Drawing.Point(16, 31);
            this.dtmf_textbox.Name = "dtmf_textbox";
            this.dtmf_textbox.Size = new System.Drawing.Size(158, 20);
            this.dtmf_textbox.TabIndex = 0;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Location = new System.Drawing.Point(434, 300);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(416, 282);
            this.zedGraphControl4.TabIndex = 3;
            this.zedGraphControl4.UseExtendedPrintDialog = true;
            // 
            // Rate_to_dt_textBox
            // 
            this.Rate_to_dt_textBox.Location = new System.Drawing.Point(876, 81);
            this.Rate_to_dt_textBox.Name = "Rate_to_dt_textBox";
            this.Rate_to_dt_textBox.Size = new System.Drawing.Size(100, 20);
            this.Rate_to_dt_textBox.TabIndex = 5;
            this.Rate_to_dt_textBox.Text = "22050";
            // 
            // convert_rateDT_button
            // 
            this.convert_rateDT_button.Location = new System.Drawing.Point(985, 79);
            this.convert_rateDT_button.Name = "convert_rateDT_button";
            this.convert_rateDT_button.Size = new System.Drawing.Size(101, 23);
            this.convert_rateDT_button.TabIndex = 26;
            this.convert_rateDT_button.Text = "Конвертировать";
            this.convert_rateDT_button.UseVisualStyleBackColor = true;
            this.convert_rateDT_button.Click += new System.EventHandler(this.convert_rateDT_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(876, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Rate to DT";
            // 
            // cut_button
            // 
            this.cut_button.Location = new System.Drawing.Point(206, 324);
            this.cut_button.Name = "cut_button";
            this.cut_button.Size = new System.Drawing.Size(75, 23);
            this.cut_button.TabIndex = 25;
            this.cut_button.Text = "Обрезать запись";
            this.cut_button.UseVisualStyleBackColor = true;
            this.cut_button.Click += new System.EventHandler(this.cut_button_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(97, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Обрезание графика";
            // 
            // cut_from_textbox
            // 
            this.cut_from_textbox.Location = new System.Drawing.Point(104, 326);
            this.cut_from_textbox.Name = "cut_from_textbox";
            this.cut_from_textbox.Size = new System.Drawing.Size(30, 20);
            this.cut_from_textbox.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 329);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "От";
            // 
            // cut_to_texbox
            // 
            this.cut_to_texbox.Location = new System.Drawing.Point(170, 325);
            this.cut_to_texbox.Name = "cut_to_texbox";
            this.cut_to_texbox.Size = new System.Drawing.Size(30, 20);
            this.cut_to_texbox.TabIndex = 29;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(142, 329);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "До";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 592);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.convert_rateDT_button);
            this.Controls.Add(this.Rate_to_dt_textBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.openAnalyserButton);
            this.Controls.Add(this.mergeButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.nTextBox);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.dtTextBox);
            this.Controls.Add(this.dtLabel);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.numericUpDownGraphNo);
            this.Controls.Add(this.zedGraphControl4);
            this.Controls.Add(this.zedGraphControl3);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "GraphForm";
            this.Text = "Графики";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphNo)).EndInit();
            this.linearGroupBox.ResumeLayout(false);
            this.linearGroupBox.PerformLayout();
            this.ExpGoupBox.ResumeLayout(false);
            this.ExpGoupBox.PerformLayout();
            this.randomGroupBox.ResumeLayout(false);
            this.randomGroupBox.PerformLayout();
            this.sinGroupBox.ResumeLayout(false);
            this.sinGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AntiShiftGroupBox.ResumeLayout(false);
            this.spikeGroupBox.ResumeLayout(false);
            this.spikeGroupBox.PerformLayout();
            this.antiSpikeGroupBox.ResumeLayout(false);
            this.antiSpikeGroupBox.PerformLayout();
            this.AntiTrendGroupBox.ResumeLayout(false);
            this.AntiTrendGroupBox.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Potter_HPF.ResumeLayout(false);
            this.Potter_HPF.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraphNo;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.Label dtLabel;
        private System.Windows.Forms.TextBox dtTextBox;
        private System.Windows.Forms.TextBox nTextBox;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.GroupBox linearGroupBox;
        private System.Windows.Forms.Button addLinearButton;
        private System.Windows.Forms.TextBox dTextBox;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label aLabel;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.GroupBox ExpGoupBox;
        private System.Windows.Forms.Button addExpButton;
        private System.Windows.Forms.GroupBox randomGroupBox;
        private System.Windows.Forms.Button addRandomButton;
        private System.Windows.Forms.Label sLabel;
        private System.Windows.Forms.TextBox sTextBox;
        private System.Windows.Forms.CheckBox RandomTypeCheckBox;
        private System.Windows.Forms.GroupBox sinGroupBox;
        private System.Windows.Forms.Button addSinButton;
        private System.Windows.Forms.TextBox fTextBox;
        private System.Windows.Forms.Label fLabel;
        private System.Windows.Forms.Label AmpLabel;
        private System.Windows.Forms.TextBox ampTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Button openAnalyserButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m_textBox;
        private System.Windows.Forms.Button Potter_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fc_textBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button anti_noise;
        private System.Windows.Forms.CheckBox with_grph;
        private System.Windows.Forms.Label anti_noise_n;
        private System.Windows.Forms.TextBox anti_noise_n_text_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button shiftButton;
        private System.Windows.Forms.Label shiftValueLabel;
        private System.Windows.Forms.TextBox shiftValueTextBox;
        private System.Windows.Forms.GroupBox AntiShiftGroupBox;
        private System.Windows.Forms.Button antiShiftButton;
        private System.Windows.Forms.Button BadHeatButton;
        private System.Windows.Forms.GroupBox spikeGroupBox;
        private System.Windows.Forms.TextBox spikeCountTextbox;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label spikeSizeLabel;
        private System.Windows.Forms.TextBox spikeSizeTextbox;
        private System.Windows.Forms.Button addSpikesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox antiSpikeGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox antiSpikeSTextBox;
        private System.Windows.Forms.Button proceedAntiSpikeButton;
        private System.Windows.Forms.Button CardioPlotter;
        private System.Windows.Forms.GroupBox AntiTrendGroupBox;
        private System.Windows.Forms.Button ExecAntiTrendButton;
        private System.Windows.Forms.Label WindowSizeLabel;
        private System.Windows.Forms.TextBox WindowSizeTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox Potter_HPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_Hp;
        private System.Windows.Forms.Button Potter_HPF_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fc_Hp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bp_m;
        private System.Windows.Forms.Button Potter_BP_button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bp_fc1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox bs_m;
        private System.Windows.Forms.Button Potter_BS_button;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bs_fc1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox bs_fc_2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox bp_fc_2;
        private System.Windows.Forms.Button Open_File_button;
        private System.Windows.Forms.TextBox dataFilePath_textBox;
        private System.Windows.Forms.Button plotter_dat_button;
        private System.Windows.Forms.Button applyLpFilterButton;
        private System.Windows.Forms.Button applyHpFilterButton;
        private System.Windows.Forms.Button applyBpFilterButton;
        private System.Windows.Forms.Button applyBsPotterButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button plot_for_wav_button;
        private System.Windows.Forms.TextBox Wav_textbox;
        private System.Windows.Forms.Button Wav_OpenButton;
        private System.Windows.Forms.Button Save_wav_button;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button dtmf_plot_button;
        private System.Windows.Forms.TextBox dtmf_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Rate_Texbox;
        private System.Windows.Forms.TextBox Rate_to_dt_textBox;
        private System.Windows.Forms.Button convert_rateDT_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cut_button;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox cut_to_texbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox cut_from_textbox;
    }
}

