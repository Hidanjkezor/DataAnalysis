namespace GraphDataAnalysis
{
    partial class AnalyserForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.characteristicsTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.stationaryTextBox = new System.Windows.Forms.TextBox();
            this.calculateAllButton = new System.Windows.Forms.Button();
            this.kurtosisTextBox = new System.Windows.Forms.TextBox();
            this.rmeTextBox = new System.Windows.Forms.TextBox();
            this.AccumM3TextBox = new System.Windows.Forms.TextBox();
            this.medSquareTextBox = new System.Windows.Forms.TextBox();
            this.stdDevTextBox = new System.Windows.Forms.TextBox();
            this.DisperTextBox = new System.Windows.Forms.TextBox();
            this.avgTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.labelKurtosis = new System.Windows.Forms.Label();
            this.labelMS = new System.Windows.Forms.Label();
            this.labelAccumM3_1 = new System.Windows.Forms.Label();
            this.labelRME = new System.Windows.Forms.Label();
            this.labelSD = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.distributionTabPage = new System.Windows.Forms.TabPage();
            this.plotDistributionButton = new System.Windows.Forms.Button();
            this.distributionZedGraphControl = new ZedGraph.ZedGraphControl();
            this.RxxTabPage = new System.Windows.Forms.TabPage();
            this.pltRxxButton = new System.Windows.Forms.Button();
            this.rxxZedGraphControl = new ZedGraph.ZedGraphControl();
            this.rxyTabPage = new System.Windows.Forms.TabPage();
            this.secondGraphLabel = new System.Windows.Forms.Label();
            this.secondGraphNoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rxyPlotButton = new System.Windows.Forms.Button();
            this.rxyZedGraphControl = new ZedGraph.ZedGraphControl();
            this.spectreTabPage = new System.Windows.Forms.TabPage();
            this.spectrePlotButton = new System.Windows.Forms.Button();
            this.spectreZedGraphControl = new ZedGraph.ZedGraphControl();
            this.graphLabel = new System.Windows.Forms.Label();
            this.numericUpDownGraphNo = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.characteristicsTabPage.SuspendLayout();
            this.distributionTabPage.SuspendLayout();
            this.RxxTabPage.SuspendLayout();
            this.rxyTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondGraphNoNumericUpDown)).BeginInit();
            this.spectreTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphNo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.characteristicsTabPage);
            this.tabControl1.Controls.Add(this.distributionTabPage);
            this.tabControl1.Controls.Add(this.RxxTabPage);
            this.tabControl1.Controls.Add(this.rxyTabPage);
            this.tabControl1.Controls.Add(this.spectreTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // characteristicsTabPage
            // 
            this.characteristicsTabPage.Controls.Add(this.label1);
            this.characteristicsTabPage.Controls.Add(this.stationaryTextBox);
            this.characteristicsTabPage.Controls.Add(this.calculateAllButton);
            this.characteristicsTabPage.Controls.Add(this.kurtosisTextBox);
            this.characteristicsTabPage.Controls.Add(this.rmeTextBox);
            this.characteristicsTabPage.Controls.Add(this.AccumM3TextBox);
            this.characteristicsTabPage.Controls.Add(this.medSquareTextBox);
            this.characteristicsTabPage.Controls.Add(this.stdDevTextBox);
            this.characteristicsTabPage.Controls.Add(this.DisperTextBox);
            this.characteristicsTabPage.Controls.Add(this.avgTextBox);
            this.characteristicsTabPage.Controls.Add(this.maxTextBox);
            this.characteristicsTabPage.Controls.Add(this.minTextBox);
            this.characteristicsTabPage.Controls.Add(this.labelKurtosis);
            this.characteristicsTabPage.Controls.Add(this.labelMS);
            this.characteristicsTabPage.Controls.Add(this.labelAccumM3_1);
            this.characteristicsTabPage.Controls.Add(this.labelRME);
            this.characteristicsTabPage.Controls.Add(this.labelSD);
            this.characteristicsTabPage.Controls.Add(this.labelAvg);
            this.characteristicsTabPage.Controls.Add(this.label11);
            this.characteristicsTabPage.Controls.Add(this.labelMax);
            this.characteristicsTabPage.Controls.Add(this.labelMin);
            this.characteristicsTabPage.Location = new System.Drawing.Point(4, 22);
            this.characteristicsTabPage.Name = "characteristicsTabPage";
            this.characteristicsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.characteristicsTabPage.Size = new System.Drawing.Size(768, 379);
            this.characteristicsTabPage.TabIndex = 1;
            this.characteristicsTabPage.Text = "Характеристики";
            this.characteristicsTabPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(433, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 221;
            this.label1.Text = "Stationary";
            // 
            // stationaryTextBox
            // 
            this.stationaryTextBox.Location = new System.Drawing.Point(433, 62);
            this.stationaryTextBox.Name = "stationaryTextBox";
            this.stationaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.stationaryTextBox.TabIndex = 220;
            // 
            // calculateAllButton
            // 
            this.calculateAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateAllButton.Location = new System.Drawing.Point(687, 350);
            this.calculateAllButton.Name = "calculateAllButton";
            this.calculateAllButton.Size = new System.Drawing.Size(75, 23);
            this.calculateAllButton.TabIndex = 219;
            this.calculateAllButton.Text = "Посчитать";
            this.calculateAllButton.UseVisualStyleBackColor = true;
            this.calculateAllButton.Click += new System.EventHandler(this.calculateAllButton_Click);
            // 
            // kurtosisTextBox
            // 
            this.kurtosisTextBox.Location = new System.Drawing.Point(327, 62);
            this.kurtosisTextBox.Name = "kurtosisTextBox";
            this.kurtosisTextBox.Size = new System.Drawing.Size(100, 20);
            this.kurtosisTextBox.TabIndex = 218;
            // 
            // rmeTextBox
            // 
            this.rmeTextBox.Location = new System.Drawing.Point(221, 62);
            this.rmeTextBox.Name = "rmeTextBox";
            this.rmeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rmeTextBox.TabIndex = 217;
            // 
            // AccumM3TextBox
            // 
            this.AccumM3TextBox.Location = new System.Drawing.Point(115, 62);
            this.AccumM3TextBox.Name = "AccumM3TextBox";
            this.AccumM3TextBox.Size = new System.Drawing.Size(100, 20);
            this.AccumM3TextBox.TabIndex = 216;
            // 
            // medSquareTextBox
            // 
            this.medSquareTextBox.Location = new System.Drawing.Point(9, 62);
            this.medSquareTextBox.Name = "medSquareTextBox";
            this.medSquareTextBox.Size = new System.Drawing.Size(100, 20);
            this.medSquareTextBox.TabIndex = 215;
            // 
            // stdDevTextBox
            // 
            this.stdDevTextBox.Location = new System.Drawing.Point(433, 23);
            this.stdDevTextBox.Name = "stdDevTextBox";
            this.stdDevTextBox.Size = new System.Drawing.Size(100, 20);
            this.stdDevTextBox.TabIndex = 214;
            // 
            // DisperTextBox
            // 
            this.DisperTextBox.Location = new System.Drawing.Point(327, 23);
            this.DisperTextBox.Name = "DisperTextBox";
            this.DisperTextBox.Size = new System.Drawing.Size(100, 20);
            this.DisperTextBox.TabIndex = 213;
            // 
            // avgTextBox
            // 
            this.avgTextBox.Location = new System.Drawing.Point(221, 23);
            this.avgTextBox.Name = "avgTextBox";
            this.avgTextBox.Size = new System.Drawing.Size(100, 20);
            this.avgTextBox.TabIndex = 212;
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(115, 23);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(100, 20);
            this.maxTextBox.TabIndex = 211;
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(9, 23);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(100, 20);
            this.minTextBox.TabIndex = 210;
            // 
            // labelKurtosis
            // 
            this.labelKurtosis.AutoSize = true;
            this.labelKurtosis.Location = new System.Drawing.Point(324, 46);
            this.labelKurtosis.Name = "labelKurtosis";
            this.labelKurtosis.Size = new System.Drawing.Size(44, 13);
            this.labelKurtosis.TabIndex = 209;
            this.labelKurtosis.Text = "Kurtosis";
            // 
            // labelMS
            // 
            this.labelMS.AutoSize = true;
            this.labelMS.Location = new System.Drawing.Point(6, 46);
            this.labelMS.Name = "labelMS";
            this.labelMS.Size = new System.Drawing.Size(78, 13);
            this.labelMS.TabIndex = 208;
            this.labelMS.Text = "MediumSquare";
            // 
            // labelAccumM3_1
            // 
            this.labelAccumM3_1.AutoSize = true;
            this.labelAccumM3_1.Location = new System.Drawing.Point(112, 46);
            this.labelAccumM3_1.Name = "labelAccumM3_1";
            this.labelAccumM3_1.Size = new System.Drawing.Size(55, 13);
            this.labelAccumM3_1.TabIndex = 207;
            this.labelAccumM3_1.Text = "AccumM3";
            // 
            // labelRME
            // 
            this.labelRME.AutoSize = true;
            this.labelRME.Location = new System.Drawing.Point(218, 46);
            this.labelRME.Name = "labelRME";
            this.labelRME.Size = new System.Drawing.Size(79, 13);
            this.labelRME.TabIndex = 206;
            this.labelRME.Text = "RootMeanError";
            // 
            // labelSD
            // 
            this.labelSD.AutoSize = true;
            this.labelSD.Location = new System.Drawing.Point(430, 7);
            this.labelSD.Name = "labelSD";
            this.labelSD.Size = new System.Drawing.Size(95, 13);
            this.labelSD.TabIndex = 205;
            this.labelSD.Text = "StandardDeviation";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(218, 7);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(26, 13);
            this.labelAvg.TabIndex = 204;
            this.labelAvg.Text = "Avg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(324, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 203;
            this.label11.Text = "Disper";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Location = new System.Drawing.Point(112, 7);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(27, 13);
            this.labelMax.TabIndex = 202;
            this.labelMax.Text = "Max";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(6, 7);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(24, 13);
            this.labelMin.TabIndex = 201;
            this.labelMin.Text = "Min";
            // 
            // distributionTabPage
            // 
            this.distributionTabPage.Controls.Add(this.plotDistributionButton);
            this.distributionTabPage.Controls.Add(this.distributionZedGraphControl);
            this.distributionTabPage.Location = new System.Drawing.Point(4, 22);
            this.distributionTabPage.Name = "distributionTabPage";
            this.distributionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.distributionTabPage.Size = new System.Drawing.Size(768, 379);
            this.distributionTabPage.TabIndex = 0;
            this.distributionTabPage.Text = "Распределение";
            this.distributionTabPage.UseVisualStyleBackColor = true;
            // 
            // plotDistributionButton
            // 
            this.plotDistributionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.plotDistributionButton.Location = new System.Drawing.Point(687, 347);
            this.plotDistributionButton.Name = "plotDistributionButton";
            this.plotDistributionButton.Size = new System.Drawing.Size(75, 23);
            this.plotDistributionButton.TabIndex = 1;
            this.plotDistributionButton.Text = "Построить";
            this.plotDistributionButton.UseVisualStyleBackColor = true;
            this.plotDistributionButton.Click += new System.EventHandler(this.plotDistributionButton_Click);
            // 
            // distributionZedGraphControl
            // 
            this.distributionZedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.distributionZedGraphControl.Location = new System.Drawing.Point(6, 6);
            this.distributionZedGraphControl.Name = "distributionZedGraphControl";
            this.distributionZedGraphControl.ScrollGrace = 0D;
            this.distributionZedGraphControl.ScrollMaxX = 0D;
            this.distributionZedGraphControl.ScrollMaxY = 0D;
            this.distributionZedGraphControl.ScrollMaxY2 = 0D;
            this.distributionZedGraphControl.ScrollMinX = 0D;
            this.distributionZedGraphControl.ScrollMinY = 0D;
            this.distributionZedGraphControl.ScrollMinY2 = 0D;
            this.distributionZedGraphControl.Size = new System.Drawing.Size(756, 335);
            this.distributionZedGraphControl.TabIndex = 0;
            this.distributionZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // RxxTabPage
            // 
            this.RxxTabPage.Controls.Add(this.pltRxxButton);
            this.RxxTabPage.Controls.Add(this.rxxZedGraphControl);
            this.RxxTabPage.Location = new System.Drawing.Point(4, 22);
            this.RxxTabPage.Name = "RxxTabPage";
            this.RxxTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RxxTabPage.Size = new System.Drawing.Size(768, 379);
            this.RxxTabPage.TabIndex = 2;
            this.RxxTabPage.Text = "Rxx";
            this.RxxTabPage.UseVisualStyleBackColor = true;
            // 
            // pltRxxButton
            // 
            this.pltRxxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pltRxxButton.Location = new System.Drawing.Point(687, 348);
            this.pltRxxButton.Name = "pltRxxButton";
            this.pltRxxButton.Size = new System.Drawing.Size(75, 23);
            this.pltRxxButton.TabIndex = 3;
            this.pltRxxButton.Text = "Построить";
            this.pltRxxButton.UseVisualStyleBackColor = true;
            this.pltRxxButton.Click += new System.EventHandler(this.pltRxxButton_Click);
            // 
            // rxxZedGraphControl
            // 
            this.rxxZedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rxxZedGraphControl.Location = new System.Drawing.Point(6, 7);
            this.rxxZedGraphControl.Name = "rxxZedGraphControl";
            this.rxxZedGraphControl.ScrollGrace = 0D;
            this.rxxZedGraphControl.ScrollMaxX = 0D;
            this.rxxZedGraphControl.ScrollMaxY = 0D;
            this.rxxZedGraphControl.ScrollMaxY2 = 0D;
            this.rxxZedGraphControl.ScrollMinX = 0D;
            this.rxxZedGraphControl.ScrollMinY = 0D;
            this.rxxZedGraphControl.ScrollMinY2 = 0D;
            this.rxxZedGraphControl.Size = new System.Drawing.Size(756, 335);
            this.rxxZedGraphControl.TabIndex = 2;
            this.rxxZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // rxyTabPage
            // 
            this.rxyTabPage.Controls.Add(this.secondGraphLabel);
            this.rxyTabPage.Controls.Add(this.secondGraphNoNumericUpDown);
            this.rxyTabPage.Controls.Add(this.rxyPlotButton);
            this.rxyTabPage.Controls.Add(this.rxyZedGraphControl);
            this.rxyTabPage.Location = new System.Drawing.Point(4, 22);
            this.rxyTabPage.Name = "rxyTabPage";
            this.rxyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rxyTabPage.Size = new System.Drawing.Size(768, 379);
            this.rxyTabPage.TabIndex = 3;
            this.rxyTabPage.Text = "Rxy";
            this.rxyTabPage.UseVisualStyleBackColor = true;
            // 
            // secondGraphLabel
            // 
            this.secondGraphLabel.AutoSize = true;
            this.secondGraphLabel.Location = new System.Drawing.Point(518, 350);
            this.secondGraphLabel.Name = "secondGraphLabel";
            this.secondGraphLabel.Size = new System.Drawing.Size(83, 13);
            this.secondGraphLabel.TabIndex = 5;
            this.secondGraphLabel.Text = "Второй график";
            // 
            // secondGraphNoNumericUpDown
            // 
            this.secondGraphNoNumericUpDown.Location = new System.Drawing.Point(607, 348);
            this.secondGraphNoNumericUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.secondGraphNoNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondGraphNoNumericUpDown.Name = "secondGraphNoNumericUpDown";
            this.secondGraphNoNumericUpDown.Size = new System.Drawing.Size(74, 20);
            this.secondGraphNoNumericUpDown.TabIndex = 4;
            this.secondGraphNoNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rxyPlotButton
            // 
            this.rxyPlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rxyPlotButton.Location = new System.Drawing.Point(687, 346);
            this.rxyPlotButton.Name = "rxyPlotButton";
            this.rxyPlotButton.Size = new System.Drawing.Size(75, 23);
            this.rxyPlotButton.TabIndex = 3;
            this.rxyPlotButton.Text = "Построить";
            this.rxyPlotButton.UseVisualStyleBackColor = true;
            this.rxyPlotButton.Click += new System.EventHandler(this.rxyPlotButton_Click);
            // 
            // rxyZedGraphControl
            // 
            this.rxyZedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rxyZedGraphControl.Location = new System.Drawing.Point(6, 7);
            this.rxyZedGraphControl.Name = "rxyZedGraphControl";
            this.rxyZedGraphControl.ScrollGrace = 0D;
            this.rxyZedGraphControl.ScrollMaxX = 0D;
            this.rxyZedGraphControl.ScrollMaxY = 0D;
            this.rxyZedGraphControl.ScrollMaxY2 = 0D;
            this.rxyZedGraphControl.ScrollMinX = 0D;
            this.rxyZedGraphControl.ScrollMinY = 0D;
            this.rxyZedGraphControl.ScrollMinY2 = 0D;
            this.rxyZedGraphControl.Size = new System.Drawing.Size(756, 335);
            this.rxyZedGraphControl.TabIndex = 2;
            this.rxyZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // spectreTabPage
            // 
            this.spectreTabPage.Controls.Add(this.spectrePlotButton);
            this.spectreTabPage.Controls.Add(this.spectreZedGraphControl);
            this.spectreTabPage.Location = new System.Drawing.Point(4, 22);
            this.spectreTabPage.Name = "spectreTabPage";
            this.spectreTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.spectreTabPage.Size = new System.Drawing.Size(768, 379);
            this.spectreTabPage.TabIndex = 4;
            this.spectreTabPage.Text = "Spectre";
            this.spectreTabPage.UseVisualStyleBackColor = true;
            // 
            // spectrePlotButton
            // 
            this.spectrePlotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spectrePlotButton.Location = new System.Drawing.Point(687, 348);
            this.spectrePlotButton.Name = "spectrePlotButton";
            this.spectrePlotButton.Size = new System.Drawing.Size(75, 23);
            this.spectrePlotButton.TabIndex = 3;
            this.spectrePlotButton.Text = "Построить";
            this.spectrePlotButton.UseVisualStyleBackColor = true;
            this.spectrePlotButton.Click += new System.EventHandler(this.spectrePlotButton_Click);
            // 
            // spectreZedGraphControl
            // 
            this.spectreZedGraphControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spectreZedGraphControl.Location = new System.Drawing.Point(6, 7);
            this.spectreZedGraphControl.Name = "spectreZedGraphControl";
            this.spectreZedGraphControl.ScrollGrace = 0D;
            this.spectreZedGraphControl.ScrollMaxX = 0D;
            this.spectreZedGraphControl.ScrollMaxY = 0D;
            this.spectreZedGraphControl.ScrollMaxY2 = 0D;
            this.spectreZedGraphControl.ScrollMinX = 0D;
            this.spectreZedGraphControl.ScrollMinY = 0D;
            this.spectreZedGraphControl.ScrollMinY2 = 0D;
            this.spectreZedGraphControl.Size = new System.Drawing.Size(756, 335);
            this.spectreZedGraphControl.TabIndex = 2;
            this.spectreZedGraphControl.UseExtendedPrintDialog = true;
            // 
            // graphLabel
            // 
            this.graphLabel.AutoSize = true;
            this.graphLabel.Location = new System.Drawing.Point(13, 9);
            this.graphLabel.Name = "graphLabel";
            this.graphLabel.Size = new System.Drawing.Size(45, 13);
            this.graphLabel.TabIndex = 7;
            this.graphLabel.Text = "График";
            // 
            // numericUpDownGraphNo
            // 
            this.numericUpDownGraphNo.Location = new System.Drawing.Point(64, 7);
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
            this.numericUpDownGraphNo.TabIndex = 6;
            this.numericUpDownGraphNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AnalyserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graphLabel);
            this.Controls.Add(this.numericUpDownGraphNo);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnalyserForm";
            this.Text = "AnalyserForm";
            this.tabControl1.ResumeLayout(false);
            this.characteristicsTabPage.ResumeLayout(false);
            this.characteristicsTabPage.PerformLayout();
            this.distributionTabPage.ResumeLayout(false);
            this.RxxTabPage.ResumeLayout(false);
            this.rxyTabPage.ResumeLayout(false);
            this.rxyTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondGraphNoNumericUpDown)).EndInit();
            this.spectreTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage distributionTabPage;
        private System.Windows.Forms.TabPage characteristicsTabPage;
        private System.Windows.Forms.Button calculateAllButton;
        private System.Windows.Forms.TextBox kurtosisTextBox;
        private System.Windows.Forms.TextBox rmeTextBox;
        private System.Windows.Forms.TextBox AccumM3TextBox;
        private System.Windows.Forms.TextBox medSquareTextBox;
        private System.Windows.Forms.TextBox stdDevTextBox;
        private System.Windows.Forms.TextBox DisperTextBox;
        private System.Windows.Forms.TextBox avgTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.Label labelKurtosis;
        private System.Windows.Forms.Label labelMS;
        private System.Windows.Forms.Label labelAccumM3_1;
        private System.Windows.Forms.Label labelRME;
        private System.Windows.Forms.Label labelSD;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label graphLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownGraphNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox stationaryTextBox;
        private System.Windows.Forms.Button plotDistributionButton;
        private ZedGraph.ZedGraphControl distributionZedGraphControl;
        private System.Windows.Forms.TabPage RxxTabPage;
        private System.Windows.Forms.TabPage rxyTabPage;
        private System.Windows.Forms.TabPage spectreTabPage;
        private System.Windows.Forms.Button pltRxxButton;
        private ZedGraph.ZedGraphControl rxxZedGraphControl;
        private System.Windows.Forms.Button rxyPlotButton;
        private ZedGraph.ZedGraphControl rxyZedGraphControl;
        private System.Windows.Forms.Button spectrePlotButton;
        private ZedGraph.ZedGraphControl spectreZedGraphControl;
        private System.Windows.Forms.Label secondGraphLabel;
        private System.Windows.Forms.NumericUpDown secondGraphNoNumericUpDown;
    }
}