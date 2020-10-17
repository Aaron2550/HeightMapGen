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
            this.noticeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.widthInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octavesInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedInputBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionInputBox)).BeginInit();
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
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width of the height map";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(12, 35);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(123, 13);
            this.heightLabel.TabIndex = 2;
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
            this.heightInputBox.TabIndex = 3;
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
            this.octavesInputBox.TabIndex = 4;
            // 
            // octavesLabel
            // 
            this.octavesLabel.AutoSize = true;
            this.octavesLabel.Location = new System.Drawing.Point(12, 61);
            this.octavesLabel.Name = "octavesLabel";
            this.octavesLabel.Size = new System.Drawing.Size(97, 13);
            this.octavesLabel.TabIndex = 5;
            this.octavesLabel.Text = "Number of octaves";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(12, 137);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(246, 41);
            this.generateButton.TabIndex = 6;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // useFastLibraryRadioButton
            // 
            this.useFastLibraryRadioButton.AutoSize = true;
            this.useFastLibraryRadioButton.Checked = true;
            this.useFastLibraryRadioButton.Location = new System.Drawing.Point(264, 7);
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
            this.useSmoothLibraryRadioButton.Location = new System.Drawing.Point(264, 33);
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
            this.useRandomSeedCheckBox.Location = new System.Drawing.Point(264, 86);
            this.useRandomSeedCheckBox.Name = "useRandomSeedCheckBox";
            this.useRandomSeedCheckBox.Size = new System.Drawing.Size(109, 17);
            this.useRandomSeedCheckBox.TabIndex = 10;
            this.useRandomSeedCheckBox.Text = "Use random seed";
            this.useRandomSeedCheckBox.UseVisualStyleBackColor = true;
            this.useRandomSeedCheckBox.CheckedChanged += new System.EventHandler(this.useRandomSeedCheckBox_CheckedChanged);
            // 
            // seedInputBox
            // 
            this.seedInputBox.Location = new System.Drawing.Point(138, 85);
            this.seedInputBox.Name = "seedInputBox";
            this.seedInputBox.Size = new System.Drawing.Size(120, 20);
            this.seedInputBox.TabIndex = 11;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(12, 87);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(32, 13);
            this.seedLabel.TabIndex = 12;
            this.seedLabel.Text = "Seed";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "png";
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(12, 113);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(57, 13);
            this.resolutionLabel.TabIndex = 13;
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
            this.resolutionInputBox.TabIndex = 14;
            this.resolutionInputBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Location = new System.Drawing.Point(264, 113);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(162, 65);
            this.noticeLabel.TabIndex = 15;
            this.noticeLabel.Text = "I\'m not sure what to call this field.\r\nOpenSimplex2 uses a coordinate\r\nsystem wit" +
    "h decimal-numbers.\r\nAny point will be divided by this\r\nnumber.\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 190);
            this.Controls.Add(this.noticeLabel);
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
        private System.Windows.Forms.Label noticeLabel;
    }
}

