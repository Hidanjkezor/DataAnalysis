using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GraphDataAnalysis.MyClasses;
using ZedGraph;

namespace GraphDataAnalysis
{
    public partial class AnalyserForm : Form
    {
        private readonly List<ZedGraphControl> _controlZgcList;

        public AnalyserForm(List<ZedGraphControl> controlZgcList)
        {
            InitializeComponent();
            _controlZgcList = controlZgcList;
        }

        private void calculateAllButton_Click(object sender, EventArgs e)
        {
            if (_controlZgcList[(int) numericUpDownGraphNo.Value - 1].GraphPane.CurveList.Count == 0)
                return;

            var list = GraphConverter.GetPointPairListFromCurve(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0]);

            minTextBox.Text = $"{Analyser.GetMinOnRange(list)}";
            maxTextBox.Text = $"{Analyser.GetMaxOnRange(list)}";

            var avrg = Analyser.GetAverageOnRange(list);
            avgTextBox.Text = $"{avrg}";

            var disp = Analyser.GetDispersionOnRange(list, avrg);
            DisperTextBox.Text = $"{disp}";

            stdDevTextBox.Text = $"{Analyser.GetSigmaByDispersion(disp)}";

            var mediumSquare = Analyser.GetMeanSquare(list);
            medSquareTextBox.Text = $"{mediumSquare}";

            AccumM3TextBox.Text = $"{Analyser.GetAsymmetryMoment(list)}";
            rmeTextBox.Text = $"{Analyser.GetRootMeanSquare(mediumSquare)}";

            kurtosisTextBox.Text = $"{Analyser.GetKurtosis(list)}";

            stationaryTextBox.Text = Analyser.CheckStationary(list) ? "Стационарен" : "Не стационарен";
        }

        private void plotDistributionButton_Click(object sender, EventArgs e)
        {
            if (_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList.Count == 0)
                return;

            var list = GraphConverter.GetPointPairListFromCurve(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0]);
            var res = Analyser.GetDistribution(list);

            Plotter.Clear(distributionZedGraphControl);
            Plotter.Draw(distributionZedGraphControl, res, "Распределение");
        }

        private void pltRxxButton_Click(object sender, EventArgs e)
        {
            if (_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList.Count == 0)
                return;

            var list = GraphConverter.GetPointPairListFromCurve(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0]);
            var res = Analyser.GetRxx(list);

            Plotter.Clear(rxxZedGraphControl);
            Plotter.Draw(rxxZedGraphControl, res, "Rxx");
        }

        private void rxyPlotButton_Click(object sender, EventArgs e)
        {
            if (_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList.Count == 0)
                return;

            if (_controlZgcList[(int)secondGraphNoNumericUpDown.Value - 1].GraphPane.CurveList.Count == 0)
                return;

            var list = GraphConverter.GetPointPairListFromCurve(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0]);
            var list2 = GraphConverter.GetPointPairListFromCurve(_controlZgcList[(int)secondGraphNoNumericUpDown.Value - 1].GraphPane.CurveList[0]);

            var res = Analyser.GetRxy(list, list2);

            Plotter.Clear(rxyZedGraphControl);
            Plotter.Draw(rxyZedGraphControl, res, "Rxy");
        }

        private void spectrePlotButton_Click(object sender, EventArgs e)
        {
            if (_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList.Count == 0)
                return;

            var list = GraphConverter.GetPointPairListFromCurve(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0]);
            var res = Analyser.GetSpectre(list);

            res.RemoveRange(list.Count / 2, list.Count - list.Count / 2);
            Plotter.Clear(spectreZedGraphControl);
            Plotter.Draw(spectreZedGraphControl, res, "Spectre");
        }
    }
}
