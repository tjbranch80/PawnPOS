using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    class DataVerification : System.Windows.Forms.UserControl
    {

        #region Public Methods

        public bool IsEmpty(Control control, string text, ErrorProvider errorProvider)
        {
            string errorMessage = "";
            
            if (string.IsNullOrEmpty(text))
            {
                errorMessage = "This is a required field";
                errorProvider.SetError(control, errorMessage);
                return true;
            }
           
            return false;
        }

        #endregion
    }
}
