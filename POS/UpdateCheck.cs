using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace POS
{
    public partial class UpdateCheck : Form
    {
        #region Global Components

        public UpdateCheck()
        {
            InitializeComponent();
            CenterToScreen();
        }

        Version newVersion = null;
        string websiteURL = string.Empty;
        string xmlURL = "http://www.branchsoftwareupdate.zxq.net/GIJOE/PawnPOSS.xml";
        XmlTextReader xmlReader;
        string elementName = string.Empty;
        Version currentVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

        #endregion

        #region Private Methods

        private void UpdateCheck_Load(object sender, EventArgs e)
        {
            YesButton.Enabled = false;
            NoButton.Enabled = false;
            StatusLabel.Text = "Checking For Updates...";
            GetWebVersion();
            CompareVersions();
            //test this change
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(websiteURL);
                StatusLabel.Text = "Update Has Been Downloaded";
                NoButton.Text = "Close";
                NoButton.Enabled = true;
                YesButton.Enabled = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Update Could Not Be Found");
            }
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Public Methods

        public void GetWebVersion()
        {
            try
            {
                xmlReader = new XmlTextReader(xmlURL);
                xmlReader.MoveToContent();

                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "GIJOEPOSS"))
                {
                    while (xmlReader.Read())
                    {
                        if (xmlReader.NodeType == XmlNodeType.Element)
                        {
                            elementName = xmlReader.Name;
                        }
                        else
                        {
                            if ((xmlReader.NodeType == XmlNodeType.Text) && (xmlReader.HasValue))
                            {
                                switch (elementName)
                                {
                                    case "version":
                                        newVersion = new Version(xmlReader.Value);
                                        break;
                                    case "url":
                                        websiteURL = xmlReader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem checking for updates");
            }
            finally
            {
                if (xmlReader != null) xmlReader.Close();
            }
        }

        public void CompareVersions()
        {
            if (currentVersion.CompareTo(newVersion) < 0)
            {
                StatusLabel.Text = "An Update Is Available. Click 'Yes' to download";
                YesButton.Enabled = true;
                NoButton.Enabled = true;
            }
            else
            {
                StatusLabel.Text = "No Update Is Available At This Time";
                NoButton.Text = "Close";
                NoButton.Enabled = true;
            }
        }

        #endregion
    }
}
