using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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


        private void ExecAntiTrendButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(WindowSizeTextBox.Text, out var Wsize);

            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            foreach (var curve in _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList)
            {
                GraphEditor.AntiTrend(curve, Wsize);
            }

            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].RestoreScale(_controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane);
            _controlZgcList[(int)numericUpDownGraphNo.Value - 1].Invalidate();
        }
            
        private void CardioPlotter_Click(object sender, EventArgs e)
        {
            var ppl = Analyser.Heart();
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Кардиограмма");
        }

        private void BadHeatButton_Click(object sender, EventArgs e)
        {
            var ppl = Analyser.BadHeart();
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Тахиокардия");
        }

        private void anti_noise_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= int.TryParse(anti_noise_n_text_box.Text, out var N);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            var ppl = Analyser.Accum(N, with_grph.Checked);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Анти-шум");

        }

        private void Potter_button_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(fc_textBox.Text.Replace('.', ','), out var fc);
            flag &= int.TryParse(m_textBox.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            var ppl = Analyser.GetHarryPotter(fc,m,dt);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Potter");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anti_noise_n_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Potter_HPF_button_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(fc_Hp.Text.Replace('.', ','), out var fc);
            flag &= int.TryParse(m_Hp.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            var ppl = Analyser.GetHarryPotter_HPF(fc, m, dt);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Potter_HPF");
        }

        private void Potter_BP_button_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(bp_fc1.Text.Replace('.', ','), out var fc);
            flag &= double.TryParse(bp_fc_2.Text.Replace('.', ','), out var fc2); 
            flag &= int.TryParse(bp_m.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            var ppl = Analyser.GetHarryPotter_BP(fc,fc2, m, dt);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Potter_BP");
        }

        private void Potter_BS_button_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(bs_fc1.Text.Replace('.', ','), out var fc);
            flag &= double.TryParse(bs_fc_2.Text.Replace('.', ','), out var fc2);
            flag &= int.TryParse(bs_m.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }
            var ppl = Analyser.GetHarryPotter_BS(fc,fc2, m, dt);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], ppl, "Potter_BS");
        }

        private void Open_File_button_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "data files (*.dat)|*.dat|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) { dataFilePath_textBox.Text = openFileDialog.FileName; }
            }
        }



        private void plotter_dat_button_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);

            if (!flag)
                return;

            var res = new PointPairList();
            if (File.Exists(dataFilePath_textBox.Text))
            {
                var i = 0;
                using (var reader = new BinaryReader(File.Open(dataFilePath_textBox.Text, FileMode.Open)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                        res.Add(dt * i++, reader.ReadSingle());
                }
            }
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], res, "Dat File");
        }

        private void applyLpFilterButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(fc_textBox.Text.Replace('.', ','), out var fc);
            flag &= int.TryParse(m_textBox.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var curve = _controlZgcList[(int) numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0];
            var x = new PointPairList();
            for (int i = 0; i < curve.Points.Count; i++)
                x.Add(curve.Points[i]);

            var h = Analyser.GetHarryPotter(fc, m, dt);
            var y = Analyser.GetConvolution(x, h);
            Plotter.Clear(_controlZgcList[(int)numericUpDownGraphNo.Value - 1]);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], y, "Pottered");
        }

        private void applyHpFilterButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(fc_Hp.Text.Replace('.', ','), out var fc);
            flag &= int.TryParse(m_Hp.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var curve = _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0];
            var x = new PointPairList();
            for (int i = 0; i < curve.Points.Count; i++)
                x.Add(curve.Points[i]);

            var h = Analyser.GetHarryPotter_HPF(fc, m, dt);
            var y = Analyser.GetConvolution(x, h);
            Plotter.Clear(_controlZgcList[(int)numericUpDownGraphNo.Value - 1]);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], y, "Pottered");
        }

        private void applyBpFilterButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(bp_fc1.Text.Replace('.', ','), out var fc);
            flag &= double.TryParse(bp_fc_2.Text.Replace('.', ','), out var fc2);
            flag &= int.TryParse(bp_m.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var curve = _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0];
            var x = new PointPairList();
            for (int i = 0; i < curve.Points.Count; i++)
                x.Add(curve.Points[i]);

            var h = Analyser.GetHarryPotter_BP(fc, fc2, m, dt);
            var y = Analyser.GetConvolution(x, h);
            Plotter.Clear(_controlZgcList[(int)numericUpDownGraphNo.Value - 1]);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], y, "Pottered");
        }

        private void applyBsPotterButton_Click(object sender, EventArgs e)
        {
            var flag = true;
            flag &= double.TryParse(bs_fc1.Text.Replace('.', ','), out var fc);
            flag &= double.TryParse(bs_fc_2.Text.Replace('.', ','), out var fc2);
            flag &= int.TryParse(bs_m.Text, out var m);
            flag &= double.TryParse(dtTextBox.Text.Replace('.', ','), out var dt);
            if (!flag)
            {
                MessageBox.Show("Не все данные в правильном формате!", "Ошибка", MessageBoxButtons.OK);
                return;
            }

            var curve = _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0];
            var x = new PointPairList();
            for (int i = 0; i < curve.Points.Count; i++)
                x.Add(curve.Points[i]);

            var h = Analyser.GetHarryPotter_BS(fc, fc2, m, dt);
            var y = Analyser.GetConvolution(x, h);
            Plotter.Clear(_controlZgcList[(int)numericUpDownGraphNo.Value - 1]);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], y, "Pottered");
        }

        private void Wav_OpenButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK) { Wav_textbox.Text = openFileDialog.FileName; }
            }
        }

        private void plot_for_wav_button_Click(object sender, EventArgs e)
        {
            var res = Wav.Wav_ReadFile(Wav_textbox.Text);
            Plotter.Draw(_controlZgcList[(int)numericUpDownGraphNo.Value - 1], res, "Wav File");
        }

        private void Save_wav_button_Click(object sender, EventArgs e)
        {
            var curve = _controlZgcList[(int)numericUpDownGraphNo.Value - 1].GraphPane.CurveList[0];
            var x = new PointPairList();
            for (int i = 0; i < curve.Points.Count; i++)
                x.Add(curve.Points[i]);

            using (var Save_wave = new SaveFileDialog())
            {
                Save_wave.InitialDirectory = "c:\\";
                Save_wave.Filter = "wav files (*.wav)|*.wav|All files (*.*)|*.*";
                Save_wave.FilterIndex = 1;
                Save_wave.RestoreDirectory = true;
                if (Save_wave.ShowDialog() == DialogResult.OK)
                {
                    Wav.WritePplToWav(Save_wave.FileName, x);
                }
            }
        }
    }
}
