using Noise;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace HeightMapGen {
	public partial class MainForm : Form {
		Bitmap heightBitmap, blendBitmap;

		public MainForm() {
			InitializeComponent();
		}

		public double normalizeValue(double value, double max, double min, double newMax, double newMin) {
			return (value - min) * (newMax - newMin) / (max - min) + newMin;
		}

		private void generateButton_Click(object sender, EventArgs e) {
			if (widthInputBox.Value != 0 && heightInputBox.Value != 0) {
				Random random = new Random();
				heightBitmap = new Bitmap(Convert.ToInt32(widthInputBox.Value), Convert.ToInt32(heightInputBox.Value));
				blendBitmap = new Bitmap(Convert.ToInt32(widthInputBox.Value), Convert.ToInt32(heightInputBox.Value));

				long seed = useRandomSeedCheckBox.Checked ? random.Next(int.MinValue, int.MaxValue) : Convert.ToInt64(seedInputBox.Value);

				int coordinateMultiplier = 1;
				int colorValue;

				double finalMax = 1d;
				double value;

				Text = "HeightMapGen - Working...";

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

							mapValue(x, y, value, finalMax, Convert.ToDouble(exponentInputBox.Value));
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

							mapValue(x, y, value, finalMax, Convert.ToDouble(exponentInputBox.Value));
							finalMax = 1d;
						}
					}
				}

				heightMapImageBox.Image = heightBitmap;
				blendMapImageBox.Image = blendBitmap;

				Text = "HeightMapGen";
			}
		}

		public void mapValue(int x, int y, double value, double finalMaximum, double exponent) {
			value = Math.Pow(normalizeValue(value, finalMaximum, 0d, 1d, 0d), exponent);

			if (value <= 0.33d) {
				blendBitmap.SetPixel(x, y, Color.FromArgb((int) normalizeValue(value, 0.33d, 0d, 255d, 0d), 0, 0));
			} else if (value <= 0.66d) {
				blendBitmap.SetPixel(x, y, Color.FromArgb(0, (int) normalizeValue(value, 0.66d, 0.33d, 255d, 0d), 0));
			} else {
				blendBitmap.SetPixel(x, y, Color.FromArgb(0, 0, (int) normalizeValue(value, 1d, 0.66d, 255d, 0d)));
			}

			heightBitmap.SetPixel(x, y, Color.FromArgb((int) (value * 255), (int) (value * 255), (int) (value * 255)));
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

		private void saveBlendmapButton_Click(object sender, EventArgs e) {
			saveImage(blendBitmap);
		}

		private void saveHeightmapButton_Click(object sender, EventArgs e) {
			saveImage(heightBitmap);
		}

		public void saveImage(Bitmap bitmap) {

			switch (imageFormatComboBox.SelectedIndex) {
				case 0:
					saveFileDialog.DefaultExt = "png";
					saveFileDialog.Filter = "png";
					break;
				case 1:
					saveFileDialog.DefaultExt = "jpeg";
					saveFileDialog.Filter = "jpeg";
					break;
				case 2:
					saveFileDialog.DefaultExt = "tiff";
					saveFileDialog.Filter = "tiff";
					break;
				case 3:
					saveFileDialog.DefaultExt = "bmp";
					saveFileDialog.Filter = "bmp";
					break;
				case 4:
					saveFileDialog.DefaultExt = "png";
					saveFileDialog.Filter = "png";
					break;
				default:
					saveFileDialog.DefaultExt = "png";
					saveFileDialog.Filter = "png";
					break;
			}

			if (saveFileDialog.ShowDialog() == DialogResult.OK) {

				switch (imageFormatComboBox.SelectedIndex) {
					case 0:
						bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
						break;
					case 1:
						bitmap.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
						break;
					case 2:
						bitmap.Save(saveFileDialog.FileName, ImageFormat.Tiff);
						break;
					case 3:
						bitmap.Save(saveFileDialog.FileName, ImageFormat.Bmp);
						break;
					case 4:
						bitmap.Save(saveFileDialog.FileName, ImageFormat.Gif);
						break;
					default:
						bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
						break;
				} 
			}

			bitmap.Dispose();
		}
	}
}
