namespace HeightMapGen {
    partial class MainForm {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.widthInputBox = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.heightInputBox = new System.Windows.Forms.NumericUpDown();
            this.octavesInputBox = new System.Windows.Forms.NumericUpDown();
            this.octavesLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.useFastLibraryRadioButton = new System.Windows.Forms.RadioButton();
            this.useSmoothLibraryRadioButton = new System.Windows.Forms.RadioButton();
            this.useRandomSeedCheckBox = new System.Windows.Forms.CheckBox();
            this.seedInputBox = new System.Windows.Forms.NumericUpDown();
            this.seedLabel = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.resolutionInputBox = new System.Windows.Forms.NumericUpDown();
            this.exponentInputBox = new System.Windows.Forms.NumericUpDown();
            this.exponentLabel = new System.Windows.Forms.Label();
            this.heightMapImageBox = new System.Windows.Forms.PictureBox();
            this.blendMapImageBox = new System.Windows.Forms.PictureBox();
            this.saveHeightmapButton = new System.Windows.Forms.Button();
            this.saveBlendmapButton = new System.Windows.Forms.Button();
            this.imageFormatComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octavesInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightMapImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blendMapImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // widthInputBox
            // 
            this.widthInputBox.Location = new System.Drawing.Point(138, 7);
            this.widthInputBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.widthInputBox.Name = "widthInputBox";
            this.widthInputBox.Size = new System.Drawing.Size(120, 20);
            this.widthInputBox.TabIndex = 0;
            this.widthInputBox.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 9);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(120, 13);
            this.widthLabel.TabIndex = 12;
            this.widthLabel.Text = "Width of the height map";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 35);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(123, 13);
            this.heightLabel.TabIndex = 13;
            this.heightLabel.Text = "Height of the height map";
            // 
            // heightInputBox
            // 
            this.heightInputBox.Location = new System.Drawing.Point(138, 33);
            this.heightInputBox.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.heightInputBox.Name = "heightInputBox";
            this.heightInputBox.Size = new System.Drawing.Size(120, 20);
            this.heightInputBox.TabIndex = 1;
            this.heightInputBox.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // octavesInputBox
            // 
            this.octavesInputBox.Location = new System.Drawing.Point(138, 59);
            this.octavesInputBox.Name = "octavesInputBox";
            this.octavesInputBox.Size = new System.Drawing.Size(120, 20);
            this.octavesInputBox.TabIndex = 2;
            // 
            // octavesLabel
            // 
            this.octavesLabel.AutoSize = true;
            this.octavesLabel.Location = new System.Drawing.Point(12, 61);
            this.octavesLabel.Name = "octavesLabel";
            this.octavesLabel.Size = new System.Drawing.Size(97, 13);
            this.octavesLabel.TabIndex = 14;
            this.octavesLabel.Text = "Number of octaves";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 278);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(246, 24);
            this.generateButton.TabIndex = 9;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // useFastLibraryRadioButton
            // 
            this.useFastLibraryRadioButton.AutoSize = true;
            this.useFastLibraryRadioButton.Checked = true;
            this.useFastLibraryRadioButton.Location = new System.Drawing.Point(138, 163);
            this.useFastLibraryRadioButton.Name = "useFastLibraryRadioButton";
            this.useFastLibraryRadioButton.Size = new System.Drawing.Size(94, 17);
            this.useFastLibraryRadioButton.TabIndex = 7;
            this.useFastLibraryRadioButton.TabStop = true;
            this.useFastLibraryRadioButton.Text = "Use fast library";
            this.useFastLibraryRadioButton.UseVisualStyleBackColor = true;
            this.useFastLibraryRadioButton.CheckedChanged += new System.EventHandler(this.useFastLibraryRadioButton_CheckedChanged);
            // 
            // useSmoothLibraryRadioButton
            // 
            this.useSmoothLibraryRadioButton.AutoSize = true;
            this.useSmoothLibraryRadioButton.Location = new System.Drawing.Point(138, 186);
            this.useSmoothLibraryRadioButton.Name = "useSmoothLibraryRadioButton";
            this.useSmoothLibraryRadioButton.Size = new System.Drawing.Size(111, 17);
            this.useSmoothLibraryRadioButton.TabIndex = 8;
            this.useSmoothLibraryRadioButton.Text = "Use smooth library";
            this.useSmoothLibraryRadioButton.UseVisualStyleBackColor = true;
            this.useSmoothLibraryRadioButton.CheckedChanged += new System.EventHandler(this.useSmoothLibraryRadioButton_CheckedChanged);
            // 
            // useRandomSeedCheckBox
            // 
            this.useRandomSeedCheckBox.AutoSize = true;
            this.useRandomSeedCheckBox.Location = new System.Drawing.Point(12, 164);
            this.useRandomSeedCheckBox.Name = "useRandomSeedCheckBox";
            this.useRandomSeedCheckBox.Size = new System.Drawing.Size(109, 17);
            this.useRandomSeedCheckBox.TabIndex = 6;
            this.useRandomSeedCheckBox.Text = "Use random seed";
            this.useRandomSeedCheckBox.UseVisualStyleBackColor = true;
            this.useRandomSeedCheckBox.CheckedChanged += new System.EventHandler(this.useRandomSeedCheckBox_CheckedChanged);
            // 
            // seedInputBox
            // 
            this.seedInputBox.Location = new System.Drawing.Point(138, 85);
            this.seedInputBox.Name = "seedInputBox";
            this.seedInputBox.Size = new System.Drawing.Size(120, 20);
            this.seedInputBox.TabIndex = 3;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(12, 87);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 15;
            this.seedLabel.Text = "Seed";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(12, 113);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.resolutionLabel.TabIndex = 16;
            this.resolutionLabel.Text = "Resolution";
            // 
            // resolutionInputBox
            // 
            this.resolutionInputBox.DecimalPlaces = 2;
            this.resolutionInputBox.Location = new System.Drawing.Point(138, 111);
            this.resolutionInputBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.resolutionInputBox.Name = "resolutionInputBox";
            this.resolutionInputBox.Size = new System.Drawing.Size(120, 20);
            this.resolutionInputBox.TabIndex = 4;
            this.resolutionInputBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // exponentInputBox
            // 
            this.exponentInputBox.DecimalPlaces = 2;
            this.exponentInputBox.Location = new System.Drawing.Point(138, 137);
            this.exponentInputBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.exponentInputBox.Name = "exponentInputBox";
            this.exponentInputBox.Size = new System.Drawing.Size(120, 20);
            this.exponentInputBox.TabIndex = 5;
            this.exponentInputBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // exponentLabel
            // 
            this.exponentLabel.AutoSize = true;
            this.exponentLabel.Location = new System.Drawing.Point(12, 139);
            this.exponentLabel.Name = "exponentLabel";
            this.exponentLabel.Size = new System.Drawing.Size(52, 13);
            this.exponentLabel.TabIndex = 17;
            this.exponentLabel.Text = "Exponent";
            // 
            // heightMapImageBox
            // 
            this.heightMapImageBox.BackColor = System.Drawing.SystemColors.Control;
            this.heightMapImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heightMapImageBox.BackgroundImage")));
            this.heightMapImageBox.Location = new System.Drawing.Point(264, 12);
            this.heightMapImageBox.Name = "heightMapImageBox";
            this.heightMapImageBox.Size = new System.Drawing.Size(256, 256);
            this.heightMapImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heightMapImageBox.TabIndex = 18;
            this.heightMapImageBox.TabStop = false;
            // 
            // blendMapImageBox
            // 
            this.blendMapImageBox.BackColor = System.Drawing.SystemColors.Control;
            this.blendMapImageBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blendMapImageBox.BackgroundImage")));
            this.blendMapImageBox.Location = new System.Drawing.Point(526, 12);
            this.blendMapImageBox.Name = "blendMapImageBox";
            this.blendMapImageBox.Size = new System.Drawing.Size(256, 256);
            this.blendMapImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blendMapImageBox.TabIndex = 19;
            this.blendMapImageBox.TabStop = false;
            // 
            // saveHeightmapButton
            // 
            this.saveHeightmapButton.Location = new System.Drawing.Point(264, 278);
            this.saveHeightmapButton.Name = "saveHeightmapButton";
            this.saveHeightmapButton.Size = new System.Drawing.Size(256, 24);
            this.saveHeightmapButton.TabIndex = 10;
            this.saveHeightmapButton.Text = "Save height map";
            this.saveHeightmapButton.UseVisualStyleBackColor = true;
            this.saveHeightmapButton.Click += new System.EventHandler(this.saveHeightmapButton_Click);
            // 
            // saveBlendmapButton
            // 
            this.saveBlendmapButton.Location = new System.Drawing.Point(526, 278);
            this.saveBlendmapButton.Name = "saveBlendmapButton";
            this.saveBlendmapButton.Size = new System.Drawing.Size(255, 24);
            this.saveBlendmapButton.TabIndex = 11;
            this.saveBlendmapButton.Text = "Save blend map";
            this.saveBlendmapButton.UseVisualStyleBackColor = true;
            this.saveBlendmapButton.Click += new System.EventHandler(this.saveBlendmapButton_Click);
            // 
            // imageFormatComboBox
            // 
            this.imageFormatComboBox.DisplayMember = "0";
            this.imageFormatComboBox.FormattingEnabled = true;
            this.imageFormatComboBox.Items.AddRange(new object[] {
            "png",
            "jpg",
            "tiff",
            "bmp",
            "gif"});
            this.imageFormatComboBox.Location = new System.Drawing.Point(12, 251);
            this.imageFormatComboBox.Name = "imageFormatComboBox";
            this.imageFormatComboBox.Size = new System.Drawing.Size(120, 21);
            this.imageFormatComboBox.TabIndex = 20;
            this.imageFormatComboBox.Text = "Select image format";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 313);
            this.Controls.Add(this.imageFormatComboBox);
            this.Controls.Add(this.saveBlendmapButton);
            this.Controls.Add(this.saveHeightmapButton);
            this.Controls.Add(this.blendMapImageBox);
            this.Controls.Add(this.heightMapImageBox);
            this.Controls.Add(this.exponentLabel);
            this.Controls.Add(this.exponentInputBox);
            this.Controls.Add(this.resolutionInputBox);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedInputBox);
            this.Controls.Add(this.useRandomSeedCheckBox);
            this.Controls.Add(this.useSmoothLibraryRadioButton);
            this.Controls.Add(this.useFastLibraryRadioButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.octavesLabel);
            this.Controls.Add(this.octavesInputBox);
            this.Controls.Add(this.heightInputBox);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.widthInputBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "HeightMapGen";
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octavesInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exponentInputBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightMapImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blendMapImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown widthInputBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown heightInputBox;
        private System.Windows.Forms.NumericUpDown octavesInputBox;
        private System.Windows.Forms.Label octavesLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RadioButton useFastLibraryRadioButton;
        private System.Windows.Forms.RadioButton useSmoothLibraryRadioButton;
        private System.Windows.Forms.CheckBox useRandomSeedCheckBox;
        private System.Windows.Forms.NumericUpDown seedInputBox;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.NumericUpDown resolutionInputBox;
        private System.Windows.Forms.NumericUpDown exponentInputBox;
        private System.Windows.Forms.Label exponentLabel;
        private System.Windows.Forms.PictureBox heightMapImageBox;
        private System.Windows.Forms.PictureBox blendMapImageBox;
        private System.Windows.Forms.Button saveHeightmapButton;
        private System.Windows.Forms.Button saveBlendmapButton;
        private System.Windows.Forms.ComboBox imageFormatComboBox;
    }
}

