using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace POS
{
    public partial class DataBackUp : Form
    {
        #region Global Components

        public DataBackUp()
        {
            InitializeComponent();
            CenterToScreen();
        }

        string selectedSource;
        string selectedTarget;
        DirectoryInfo source;
        DirectoryInfo target;
        int totalSourceFiles;
        int totalCopied;
        List<string> sourceFileNameList = new List<string>();
        List<string> parsedSourceNameList = new List<string>();
        List<string> targetFileNameList = new List<string>();

        #endregion

        #region Private Methods

        private void TargetButton_Click(object sender, EventArgs e)
        {
            GetTarget();
        }

        private void BackUpButton_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Copying Files";
            GetSource();
            CreateFolders(source, target);
            GetFilesToCopy();
            ParseSourceFileNames();
            CreateTargetFileName();
            CopyFiles();
            StatusLabel.Text = "Job Completed";
            TargetFolderLabel.Text = string.Empty;
            TotalCopiedLabel.Text = string.Empty;
        }

        private void CloseLayawayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Public Methods

        public void GetTarget()
        {
            TargetFolderLabel.Text = string.Empty;
            FolderBrowserDialog targetFolderBrowser = new FolderBrowserDialog();
            if (targetFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                selectedTarget = targetFolderBrowser.SelectedPath;
                TargetFolderLabel.Text = selectedTarget;
                target = new DirectoryInfo(selectedTarget);
            }
        }

        public void GetSource()
        {
            if (TargetFolderLabel.Text != "")
            {
                selectedSource = @"C:\PawnShopData\";
                source = new DirectoryInfo(selectedSource);
            }
        }

        public void CreateFolders(DirectoryInfo source, DirectoryInfo target)
        {
            if (!Directory.Exists(target.FullName))
            {
                Directory.CreateDirectory(target.FullName);
            }

            foreach (DirectoryInfo sourceDirectory in source.GetDirectories())
            {
                DirectoryInfo nextSubDirectory = target.CreateSubdirectory(sourceDirectory.Name);
                CreateFolders(sourceDirectory, nextSubDirectory);
            }
        }

        public void GetFilesToCopy()
        {
            string[] sourceFiles = Directory.GetFiles(source.ToString(), "*.*", SearchOption.AllDirectories);
            foreach (string sourceFileName in sourceFiles)
            {
                sourceFileNameList.Add(sourceFileName);
                totalSourceFiles = sourceFileNameList.Count();
            }
        }

        public void ParseSourceFileNames()
        {
            foreach (string file in sourceFileNameList)
            {
                string fileName = file.Substring(source.ToString().Length);
                parsedSourceNameList.Add(fileName);
            }
        }

        public void CreateTargetFileName()
        {
            foreach (string file in parsedSourceNameList)
            {
                string targetFileName = Path.Combine(target.ToString(), file);
                targetFileNameList.Add(targetFileName);
            }
        }

        public void CopyFiles()
        {
            foreach (string file in parsedSourceNameList)
            {
                File.Copy(Path.Combine(source.ToString(), file), Path.Combine(target.ToString(), file), true);
                totalCopied = totalCopied + 1;
                TotalCopiedLabel.Text = totalCopied.ToString();
            }

            if (totalCopied == totalSourceFiles)
            {
                MessageBox.Show(string.Format("You Have Just Copied {0} Files", totalCopied));
            }
        }
        
        #endregion
    }
}