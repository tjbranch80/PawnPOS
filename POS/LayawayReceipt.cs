using System;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class LayawayReceipt : Form
    {
        #region Global Components

        string connectionString;

        public LayawayReceipt()
        {
            InitializeComponent();
            CenterToScreen();
            var connectionStringSettings = ConfigurationManager.ConnectionStrings["PawnShopDB"];
            if (connectionStringSettings == null)
            {
                MessageBox.Show("Unable to connect to database.");
            }
            else
            {
                connectionString = connectionStringSettings.ConnectionString;
            }
        }

        #endregion

        #region Get Invoice Number

        private string invoiceNumberValue;
        public string InvoiceNumberValue
        {
            get
            {
                return invoiceNumberValue;
            }
            set
            {
                invoiceNumberValue = value;
                InvoiceNumberLabel.Text = invoiceNumberValue;
            }
        }

        #endregion

        #region Get Product Data

        private Dictionary<int, double> productData;
        public Dictionary<int, double> ProductData
        {
            get
            {
                return productData;
            }
            set
            {
                productData = value;
                DataManager dataManager = new DataManager(connectionString);
                foreach (KeyValuePair<int, double> pair in productData)
                {
                    ProductIDListBox.Items.Add(pair.Key.ToString());

                    var salePrice = pair.Value;
                    PriceListBox.Items.Add(string.Format("{0:C}", salePrice));

                    var productDescription = dataManager.GetProductDescription(pair.Key.ToString());
                    DescriptionListBox.Items.Add(productDescription);
                }
            }
        }

        #endregion

        #region Get Customer Information

        private string customerIDValue;
        public string CustomerIDValue
        {
            get
            {
                return customerIDValue;
            }
            set
            {
                customerIDValue = value;
                CustomerIDLabel.Text = customerIDValue;
                DataManager dataManager = new DataManager(connectionString);
                DataTable customerDataTable = new DataTable();
                customerDataTable = dataManager.GetCustomerInvoiceData(customerIDValue);

                for (int i = 0; i < customerDataTable.Rows.Count; i++)
                {
                    string firstName = customerDataTable.Rows[i]["FirstName"].ToString();
                    string lastName = customerDataTable.Rows[i]["LastName"].ToString();
                    string fullName = string.Format("{0} {1}", firstName, lastName);
                    CustomerNameLabel.Text = fullName;
                }
            }
        }


        #endregion

        #region Get Sales Data

        private string totalSale;
        public string TotalSale
        {
            get
            {
                return totalSale;
            }
            set
            {
                totalSale = value;
                TotalSaleLabel.Text = string.Format("{0:C}", totalSale);
            }
        }

        private string salesTax;
        public string SalesTax
        {
            get
            {
                return salesTax;
            }
            set
            {
                salesTax = value;
                SalesTaxLabel.Text = string.Format("{0:C}", salesTax);
            }
        }

        private string grandTotal;
        public string GrandTotal
        {
            get
            {
                return grandTotal;
            }
            set
            {
                grandTotal = value;
                GrandTotalLabel.Text = string.Format("{0:C}", grandTotal);
            }
        }

        private string saleDate;
        public string SaleDate
        {
            get
            {
                return saleDate;
            }
            set
            {
                saleDate = value;
                DateLabel.Text = string.Format("{0:MM/dd/yyyy}", saleDate);
            }
        }
                  
        #endregion

        #region Private Methods

        private void PrintButton_Click(object sender, EventArgs e)
        {
            SaveInvoiceToFile();
            PrintDocument();
            this.Close();
        }

        #endregion

        #region Save Invoice To File

        public Bitmap CreateInvoiceImage()
        {
            Rectangle invoice = this.Bounds;
            Bitmap invoiceImage = new Bitmap(invoice.Width, invoice.Height);
            Graphics invoiceGraphic = Graphics.FromImage(invoiceImage);
            invoiceGraphic.CopyFromScreen(invoice.Location, Point.Empty, invoice.Size);
            return invoiceImage;
        }

        public void SaveInvoiceToFile()
        {
            var invoicePath = ConfigurationManager.AppSettings["InvoicePath"];
            string invoiceNumber = InvoiceNumberLabel.Text;
            string savePath = invoicePath + invoiceNumber + ".jpg";
            Bitmap invoiceImage = CreateInvoiceImage();
            invoiceImage.Save(savePath, ImageFormat.Jpeg);
        }

        #endregion

        #region Print Invoice

        private System.IO.Stream streamToPrint;
        string streamType;
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt
        (

            IntPtr hdcDest, // handle to destination DC
            int nXDest, // x-coord of destination upper-left corner
            int nYDest, // y-coord of destination upper-left corner
            int nWidth, // width of destination rectangle
            int nHeight, // height of destination rectangle
            IntPtr hdcSrc, // handle to source DC
            int nXSrc, // x-coordinate of source upper-left corner
            int nYSrc, // y-coordinate of source upper-left corner
            System.Int32 dwRop // raster operation code
        );


        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Image image = Image.FromStream(streamToPrint);
            int x = e.MarginBounds.X;
            int y = e.MarginBounds.Y;
            int width = image.Width;
            int height = image.Height;
            if ((width / e.MarginBounds.Width) > (height / e.MarginBounds.Height))
            {
                width = e.MarginBounds.Width;
                height = image.Height * e.MarginBounds.Width / image.Width;
            }
            else
            {
                height = e.MarginBounds.Height;
                width = image.Width * e.MarginBounds.Height / image.Height;
            }
            System.Drawing.Rectangle destRect = new System.Drawing.Rectangle(x, y, width, height);
            e.Graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, System.Drawing.GraphicsUnit.Pixel);
        }

        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.printDocument.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        public void PrintDocument()
        {
            Graphics g1 = this.CreateGraphics();
            Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            MyImage.Save(@"c:\PrintPage.jpg", ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(@"c:\PrintPage.jpg", FileMode.Open, FileAccess.Read);
            StartPrint(fileStream, "Image");
            fileStream.Close();
            if (System.IO.File.Exists(@"c:\PrintPage.jpg"))
            {
                System.IO.File.Delete(@"c:\PrintPage.jpg");
            }
        }

        #endregion
    }
}
