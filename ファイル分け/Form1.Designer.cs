
namespace ファイル分け
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.executionButton = new System.Windows.Forms.Button();
            this.extentionComboBox = new System.Windows.Forms.ComboBox();
            this.inputRefButton = new System.Windows.Forms.Button();
            this.splitSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.inputRefTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logDeleteRadioButton = new System.Windows.Forms.RadioButton();
            this.explanationTextBox03 = new System.Windows.Forms.Label();
            this.explanationLabel01 = new System.Windows.Forms.Label();
            this.explanationLabel02 = new System.Windows.Forms.Label();
            this.explanationLabel05 = new System.Windows.Forms.Label();
            this.generatedFolderTextBox = new System.Windows.Forms.TextBox();
            this.logBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitSizeUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // executionButton
            // 
            this.executionButton.Location = new System.Drawing.Point(509, 105);
            this.executionButton.Name = "executionButton";
            this.executionButton.Size = new System.Drawing.Size(260, 41);
            this.executionButton.TabIndex = 6;
            this.executionButton.Text = "実行";
            this.executionButton.UseVisualStyleBackColor = true;
            this.executionButton.Click += new System.EventHandler(this.executionButton_Click);
            // 
            // extentionComboBox
            // 
            this.extentionComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.extentionComboBox.FormattingEnabled = true;
            this.extentionComboBox.Items.AddRange(new object[] {
            "NONE",
            ".png",
            ".jpg",
            ".bmp",
            ".txt",
            ".pdf",
            "ALL"});
            this.extentionComboBox.Location = new System.Drawing.Point(631, 60);
            this.extentionComboBox.Name = "extentionComboBox";
            this.extentionComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.extentionComboBox.Size = new System.Drawing.Size(138, 20);
            this.extentionComboBox.TabIndex = 9;
            this.extentionComboBox.SelectedIndex = 0;
            // 
            // inputRefButton
            // 
            this.inputRefButton.Location = new System.Drawing.Point(694, 6);
            this.inputRefButton.Name = "inputRefButton";
            this.inputRefButton.Size = new System.Drawing.Size(75, 23);
            this.inputRefButton.TabIndex = 0;
            this.inputRefButton.Text = "参照";
            this.inputRefButton.UseVisualStyleBackColor = true;
            this.inputRefButton.Click += new System.EventHandler(this.inputRefButton_Click);
            // 
            // splitSizeUpDown
            // 
            this.splitSizeUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.splitSizeUpDown.Location = new System.Drawing.Point(632, 86);
            this.splitSizeUpDown.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.splitSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.splitSizeUpDown.Name = "splitSizeUpDown";
            this.splitSizeUpDown.Size = new System.Drawing.Size(137, 19);
            this.splitSizeUpDown.TabIndex = 10;
            this.splitSizeUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // inputRefTextBox
            // 
            this.inputRefTextBox.AllowDrop = true;
            this.inputRefTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.inputRefTextBox.Location = new System.Drawing.Point(51, 8);
            this.inputRefTextBox.Name = "inputRefTextBox";
            this.inputRefTextBox.Size = new System.Drawing.Size(637, 19);
            this.inputRefTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.logDeleteRadioButton);
            this.panel1.Controls.Add(this.explanationTextBox03);
            this.panel1.Controls.Add(this.explanationLabel01);
            this.panel1.Controls.Add(this.explanationLabel02);
            this.panel1.Controls.Add(this.explanationLabel05);
            this.panel1.Controls.Add(this.generatedFolderTextBox);
            this.panel1.Controls.Add(this.logBox);
            this.panel1.Controls.Add(this.executionButton);
            this.panel1.Controls.Add(this.inputRefTextBox);
            this.panel1.Controls.Add(this.splitSizeUpDown);
            this.panel1.Controls.Add(this.inputRefButton);
            this.panel1.Controls.Add(this.extentionComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 159);
            this.panel1.TabIndex = 11;
            // 
            // logDeleteRadioButton
            // 
            this.logDeleteRadioButton.AutoCheck = false;
            this.logDeleteRadioButton.AutoSize = true;
            this.logDeleteRadioButton.BackColor = System.Drawing.Color.Black;
            this.logDeleteRadioButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.logDeleteRadioButton.Location = new System.Drawing.Point(412, 33);
            this.logDeleteRadioButton.Name = "logDeleteRadioButton";
            this.logDeleteRadioButton.Size = new System.Drawing.Size(74, 16);
            this.logDeleteRadioButton.TabIndex = 17;
            this.logDeleteRadioButton.TabStop = true;
            this.logDeleteRadioButton.Text = "ログを消去";
            this.logDeleteRadioButton.UseVisualStyleBackColor = false;
            this.logDeleteRadioButton.Click += new System.EventHandler(this.logDeleteRadioButton_Click);
            // 
            // explanationTextBox03
            // 
            this.explanationTextBox03.AutoSize = true;
            this.explanationTextBox03.Location = new System.Drawing.Point(568, 90);
            this.explanationTextBox03.Name = "explanationTextBox03";
            this.explanationTextBox03.Size = new System.Drawing.Size(58, 12);
            this.explanationTextBox03.TabIndex = 16;
            this.explanationTextBox03.Text = "分割サイズ";
            // 
            // explanationLabel01
            // 
            this.explanationLabel01.AutoSize = true;
            this.explanationLabel01.Location = new System.Drawing.Point(9, 11);
            this.explanationLabel01.Name = "explanationLabel01";
            this.explanationLabel01.Size = new System.Drawing.Size(29, 12);
            this.explanationLabel01.TabIndex = 16;
            this.explanationLabel01.Text = "入力";
            // 
            // explanationLabel02
            // 
            this.explanationLabel02.AutoSize = true;
            this.explanationLabel02.Location = new System.Drawing.Point(509, 38);
            this.explanationLabel02.Name = "explanationLabel02";
            this.explanationLabel02.Size = new System.Drawing.Size(117, 12);
            this.explanationLabel02.TabIndex = 16;
            this.explanationLabel02.Text = "生成するフォルダの名前";
            // 
            // explanationLabel05
            // 
            this.explanationLabel05.AutoSize = true;
            this.explanationLabel05.Location = new System.Drawing.Point(585, 63);
            this.explanationLabel05.Name = "explanationLabel05";
            this.explanationLabel05.Size = new System.Drawing.Size(41, 12);
            this.explanationLabel05.TabIndex = 16;
            this.explanationLabel05.Text = "拡張子";
            // 
            // generatedFolderTextBox
            // 
            this.generatedFolderTextBox.Location = new System.Drawing.Point(631, 35);
            this.generatedFolderTextBox.Name = "generatedFolderTextBox";
            this.generatedFolderTextBox.Size = new System.Drawing.Size(138, 19);
            this.generatedFolderTextBox.TabIndex = 15;
            this.generatedFolderTextBox.Text = "Folder_";
            // 
            // logBox
            // 
            this.logBox.BackColor = System.Drawing.Color.Black;
            this.logBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox.Cursor = System.Windows.Forms.Cursors.No;
            this.logBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.logBox.Location = new System.Drawing.Point(11, 33);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logBox.Size = new System.Drawing.Size(492, 113);
            this.logBox.TabIndex = 14;
            this.logBox.Text = "ログ\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 183);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ファイル分け機";
            ((System.ComponentModel.ISupportInitialize)(this.splitSizeUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog inputFolderBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.Button executionButton;
        private System.Windows.Forms.ComboBox extentionComboBox;
        private System.Windows.Forms.Button inputRefButton;
        private System.Windows.Forms.NumericUpDown splitSizeUpDown;
        private System.Windows.Forms.TextBox inputRefTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox logBox;
        private System.Windows.Forms.TextBox generatedFolderTextBox;
        private System.Windows.Forms.Label explanationLabel05;
        private System.Windows.Forms.Label explanationTextBox03;
        private System.Windows.Forms.Label explanationLabel02;
        private System.Windows.Forms.Label explanationLabel01;
        private System.Windows.Forms.RadioButton logDeleteRadioButton;
    }
}

