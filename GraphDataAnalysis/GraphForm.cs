using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphDataAnalysis.MyClasses;
using ZedGraph;

namespace GraphDataAnalysis
{
    public partial class GraphForm : Form
    {
        private readonly List<ZedGraphControl> _controlZgcList;

        public GraphForm()
        {
            InitializeComponent();
            _controlZgcList = new List<ZedGraphControl>
            {
                zedGraphControl1,
                zedGraphControl2,
                zedGraphControl3,
                zedGraphControl4
            };
        }

        private void DoubleParamTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox) sender;
            textBox.BackColor = !double.TryParse(textBox.Text.Replace('.', ','), out var value) ? Color.Red : Color.White;
        }

        private void IntParamTextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;
            textBox.BackColor = !int.TryParse(textBox.Text, out var value) ? Color.Red : Color.White;
        }

        #region add_graph
        private void addLinearButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(nTextBox.Text, out var N);
            flag &= double.TryParse(fromTextBox.Text.Replace('.', ','), out var from);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            flag &= double.TryParse(cTextBox.Text.Replace('.', ','), out var c);
            flag &= double.TryParse(dTextBox.Text.Replace('.', ','), out var d);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var ppl = Plotter.GetLinear(c, d, from, dt, N);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Линейный");
        }

        private void addExpButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(nTextBox.Text, out var N);
            flag &= double.TryParse(fromTextBox.Text.Replace('.', ','), out var from);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            flag &= double.TryParse(aTextBox.Text.Replace('.', ','), out var a);
            flag &= double.TryParse(bTextBox.Text.Replace('.', ','), out var b);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var ppl = Plotter.GetExp(a, b, from, dt, N);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Экспонента");
        }

        #endregion

        private void addRandomButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(nTextBox.Text, out var N);
            flag &= double.TryParse(fromTextBox.Text.Replace('.', ','), out var from);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            flag &= double.TryParse(sTextBox.Text.Replace('.', ','), out var s);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            if (RandomTypeCheckBox.Checked)
            {
                var ppl = Plotter.GetMyRandom(s, from, dt, N);
                Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Мой рандом");
            }
            else
            {
                var ppl = Plotter.GetRandom(s, from, dt, N);
                Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Рандом");
            }
        }

        private void addSinButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(nTextBox.Text, out var N);
            flag &= double.TryParse(fromTextBox.Text.Replace('.', ','), out var from);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            flag &= double.TryParse(ampTextBox.Text.Replace('.', ','), out var a);
            flag &= double.TryParse(fTextBox.Text.Replace('.', ','), out var f);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var ppl = Plotter.GetSin(a, f, from, dt, N);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Синус");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Plotter.Clear(_controlZgcList[(int)numericUpDownGraphNo.Value - 1]);
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            Plotter.Merge(_controlZgcList[(int)numericUpDownGraphNo.Value - 1]);
        }

        private void openAnalyserButton_Click(object sender, EventArgs e)
        {
            var form = new AnalyserForm(_controlZgcList);
            form.Show();
        }

        private void shiftButton_Click(object sender, EventArgs e)
        {
            var flag = double.TryParse(shiftValueTextBox.Text.Replace('.', ','), out var shift);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            foreach (var curve in _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList)
            {
                GraphEditor.Shift(curve, shift);
            }

            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].RestoreScale(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane);
            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].Invalidate();
        }

        private void antiShiftButton_Click(object sender, EventArgs e)
        {
            foreach (var curve in _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList)
            {
                GraphEditor.AntiShift(curve);
            }

            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].RestoreScale(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane);
            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].Invalidate();
        }

        private void addSpikesButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(nTextBox.Text, out var N);
            flag &= double.TryParse(spikeSizeTextbox.Text.Replace('.', ','), out var size);
            flag &= int.TryParse(spikeCountTextbox.Text, out var count);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            foreach (var curve in _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList)
            {
                GraphEditor.AddRandomSpikes(curve, size, count);
            }

            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].RestoreScale(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane);
            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].Invalidate();
        }

        private void proceedAntiSpikeButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(nTextBox.Text, out var N);
            flag &= double.TryParse(antiSpikeSTextBox.Text.Replace('.', ','), out var s);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            foreach (var curve in _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList)
            {
                GraphEditor.RemoveSpikes(curve, s);
            }

            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].RestoreScale(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane);
            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].Invalidate();
        }
    }
}
