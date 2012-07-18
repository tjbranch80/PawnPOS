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
            bool result = true;

            if (text == "")
            {
                errorMessage = "This is a required field";
                errorProvider.SetError(control, errorMessage);
            }
            else
            {
                errorProvider.SetError(control, "");
                result = false;
            }
           
            return result;
        }

        #endregion
    }
}
