using Noise;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightMapGen {
	public partial class MainForm : Form {

		public MainForm() {
			InitializeComponent();
		}

		private void generateButton_Click(object sender, EventArgs e) {
			if (widthInputBox.Value != 0 && heightInputBox.Value != 0) {
				Random random = new Random();
				Bitmap bitmap = new Bitmap(Convert.ToInt32(widthInputBox.Value), Convert.ToInt32(heightInputBox.Value));

				double[,] heightValues = new double[Convert.ToInt32(widthInputBox.Value), Convert.ToInt32(heightInputBox.Value)];
				long seed = useRandomSeedCheckBox.Checked ? random.Next(int.MinValue, int.MaxValue) : Convert.ToInt64(seedInputBox.Value);
				int value;

				if (useFastLibraryRadioButton.Checked) {
					OpenSimplex2F noiseLibrary = new OpenSimplex2F(seed);

					for (int x = 0; x < widthInputBox.Value; x++) {
						for (int y = 0; y < heightInputBox.Value; y++) {
							value = Convert.ToInt32(255 * (1 - (noiseLibrary.Noise2(x / Convert.ToDouble(resolutionInputBox.Value), y / Convert.ToDouble(resolutionInputBox.Value)) + 1) / 2));

							bitmap.SetPixel(x, y, Color.FromArgb(value, value, value));
						}
					}
				} else {
					OpenSimplex2S noiseLibrary = new OpenSimplex2S(seed);

					for (int x = 0; x < widthInputBox.Value; x++) {
						for (int y = 0; y < heightInputBox.Value; y++) {
							value = Convert.ToInt32(255 * (1 - (noiseLibrary.Noise2(x / Convert.ToDouble(resolutionInputBox.Value), y / Convert.ToDouble(resolutionInputBox.Value)) + 1) / 2));

							bitmap.SetPixel(x, y, Color.FromArgb(value, value, value));
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
