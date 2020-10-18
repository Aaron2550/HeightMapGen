using Noise;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace HeightMapGen {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        public double normalizeValue(double value, double max, double min, double newMax, double newMin) {
            return (value - min) * (newMax - newMin) / (max - min) + newMin;
        }

        private void generateButton_Click(object sender, EventArgs e) {
            if (widthInputBox.Value != 0 && heightInputBox.Value != 0) {
                Random random = new Random();
                Bitmap bitmap = new Bitmap(Convert.ToInt32(widthInputBox.Value), Convert.ToInt32(heightInputBox.Value));

                long seed = useRandomSeedCheckBox.Checked ? random.Next(int.MinValue, int.MaxValue) : Convert.ToInt64(seedInputBox.Value);

                int coordinateMultiplier = 1;
                int colorValue;

                double finalMax = 1d;
                double value;

                if (useFastLibraryRadioButton.Checked) {
                    OpenSimplex2F noiseLibrary = new OpenSimplex2F(seed);

                    for (int x = 0; x < widthInputBox.Value; x++) {
                        for (int y = 0; y < heightInputBox.Value; y++) {
                            value = normalizeValue(noiseLibrary.Noise2(x / Convert.ToDouble(resolutionInputBox.Value), y / Convert.ToDouble(resolutionInputBox.Value)), 1d, -1d, 1d, 0d);

                            for (int o = 1; o - 1 < octavesInputBox.Value; o++) {
                                finalMax += 1d / Math.Pow(2, o);

                                value += 1d / Math.Pow(2, o) * normalizeValue(noiseLibrary.Noise2(Math.Pow(2, o) * (x / Convert.ToDouble(resolutionInputBox.Value)), Math.Pow(2, o) * (y / Convert.ToDouble(resolutionInputBox.Value))), 1d, -1d, 1d, 0d);
                                coordinateMultiplier = coordinateMultiplier * 2;
                            }

                            colorValue = (int) normalizeValue(value, finalMax, 0d, 255d, 0d);
                            bitmap.SetPixel(x, y, Color.FromArgb(colorValue, colorValue, colorValue));

                            finalMax = 1d;
                        }
                    }
                } else {
                    OpenSimplex2S noiseLibrary = new OpenSimplex2S(seed);

                    for (int x = 0; x < widthInputBox.Value; x++) {
                        for (int y = 0; y < heightInputBox.Value; y++) {
                            value = normalizeValue(noiseLibrary.Noise2(x / Convert.ToDouble(resolutionInputBox.Value), y / Convert.ToDouble(resolutionInputBox.Value)), 1d, -1d, 1d, 0d);

                            for (int o = 1; o - 1 < octavesInputBox.Value; o++) {
                                finalMax += 1d / Math.Pow(2, o);

                                value += 1d / Math.Pow(2, o) * normalizeValue(noiseLibrary.Noise2(Math.Pow(2, o) * (x / Convert.ToDouble(resolutionInputBox.Value)), Math.Pow(2, o) * (y / Convert.ToDouble(resolutionInputBox.Value))), 1d, -1d, 1d, 0d);
                                coordinateMultiplier = coordinateMultiplier * 2;
                            }

                            colorValue = (int) normalizeValue(value, finalMax, 0d, 255d, 0d);
                            bitmap.SetPixel(x, y, Color.FromArgb(colorValue, colorValue, colorValue));

                            finalMax = 1d;
                        }
                    }
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
                }

                bitmap.Dispose();
            }
        }

        private void useFastLibraryRadioButton_CheckedChanged(object sender, EventArgs e) {
            useSmoothLibraryRadioButton.Checked = !useFastLibraryRadioButton.Checked;
        }

        private void useSmoothLibraryRadioButton_CheckedChanged(object sender, EventArgs e) {
            useFastLibraryRadioButton.Checked = !useSmoothLibraryRadioButton.Checked;
        }

        private void useRandomSeedCheckBox_CheckedChanged(object sender, EventArgs e) {
            seedInputBox.Enabled = !useRandomSeedCheckBox.Checked;
        }
    }
}
