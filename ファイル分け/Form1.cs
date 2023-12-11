using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace ファイル分け
{
    public partial class Form1 : Form
    {
        private string inputPath;
        public Form1()
        {
            inputFolderBrowserDialog = new FolderBrowserDialog();
            outputFolderBrowserDialog = new FolderBrowserDialog();

            InitializeComponent();
        }

        public int ToInt(string str)
        {
            return int.Parse(Regex.Replace(str, @"[^0-9]", ""));
        }

        private void inputRefButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = inputFolderBrowserDialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                inputRefTextBox.Text = inputFolderBrowserDialog.SelectedPath;
                inputPath = inputFolderBrowserDialog.SelectedPath;
            }
        }

        private void logDeleteRadioButton_Click(object sender, EventArgs e)
        {
            logBox.Text = "ログ" + Environment.NewLine;
        }

        private void executionButton_Click(object sender, EventArgs e)
        {
            //extension == 拡張子のこと
            var extension = extentionComboBox.SelectedItem;
            var generetedFolderName = generatedFolderTextBox.Text;
            var bound = splitSizeUpDown.Value;
            string[] files;
            var folderList = new List<string>();
            int folderCount = 0;
            int fileCount = 0;

            //----------例外処理----------
            if (inputPath == null)
            {
                MessageBox.Show("フォルダが選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (generetedFolderName == null)
            {
                MessageBox.Show("生成するフォルダーの名前が入力されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (extension == null || extension.ToString() == "NONE")
            {
                MessageBox.Show("拡張子が選択されていません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(bound == 0)
            {
                MessageBox.Show("分割サイズが0です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //-----------------------------

            //----------ファイルの取得----------
            if(extension.ToString() == "ALL")
            {
                files = Directory.GetFiles(inputPath, "*", SearchOption.TopDirectoryOnly).Select(f =>
                new
                {
                    name = Path.GetFileName(f),
                    index = ToInt(f)
                }).
                OrderBy(f => f.index).Select(f => f.name).ToArray();
            }
            else
            {
                files = Directory.GetFiles(inputPath, "*" + extension.ToString(), SearchOption.TopDirectoryOnly).Select(f =>
                new
                {
                    name = Path.GetFileName(f),
                    index = ToInt(f)
                }).
                OrderBy(f => f.index).Select(f => f.name).ToArray();
            }

            logBox.Text += string.Format("{0}に該当するファイル数は{1}です。", extension.ToString(), files.Length) + Environment.NewLine;
            if (files.Length == 0) return;
            //-----------------------------------

            //----------ファイル移動----------
            var folderBound = files.Length / bound;

            for(int i = 1; i <= bound; i++)
            {
                string folderName = generatedFolderTextBox.Text + i.ToString("000");
                if(!(Directory.Exists(inputPath + @"\" + folderName)))
                {
                    folderList.Add(inputPath + @"\" + folderName);
                    Directory.CreateDirectory(folderList[i - 1]);
                    logBox.Text += string.Format("{0}を作成しました。", folderList[i - 1].Replace(inputPath + @"\", "")) + Environment.NewLine;
                }
                else
                {
                    logBox.Text += string.Format("{0}はすでに存在しています。", folderName) + Environment.NewLine;
                    folderList.Add(inputPath + @"\" + folderName);
                }
            }

            foreach (string file in files)
            {
                fileCount += 1;
                if(fileCount < Math.Floor(folderBound) + 1)
                {
                    if(!(File.Exists(inputPath + @"\" + file)))
                    {
                        logBox.Text += string.Format("{0}が存在しません。", file);
                        return;
                    }
                    File.Move(inputPath + @"\" + file, folderList[folderCount] + @"\" + file);
                   logBox.Text += string.Format("{0}を{1}に移動しました。", file, folderList[folderCount].Replace(inputPath + @"\", "")) + Environment.NewLine;
                }
                else
                {
                    folderCount += 1;
                    folderBound += files.Length / bound;
                    if (!(File.Exists(inputPath + @"\" + file)))
                    {
                        logBox.Text += string.Format("{0}が存在しません。", file);
                        return;
                    }
                    File.Move(inputPath + @"\" + file, folderList[folderCount] + @"\" + file);
                    logBox.Text += string.Format("{0}を{1}に移動しました。", file, folderList[folderCount].Replace(inputPath + @"\", "")) + Environment.NewLine;
                }
            }
            //--------------------------------

            logBox.Text += Environment.NewLine;
            logBox.Text += "処理が終了しました。" + Environment.NewLine;
        }
    }
}
