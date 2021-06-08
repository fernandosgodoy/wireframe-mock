using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireframeMock.WinApp
{
    public partial class frmGenerateScreen : Form
    {

        private const string TITLE = "Wireframe Mock Tool";

        public frmGenerateScreen()
        {
            InitializeComponent();
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFieldName.Text))
            {
                ShowMessageAndFocus("Fill the Field Name field.", TITLE, txtFieldName);
                isValid = false;
            }

            if (cboType.SelectedValue == null)
            {
                ShowMessageAndFocus("Fill the Type field.", TITLE, cboType);
                isValid = false;
            }

            return isValid;
        }

        private static void ShowMessageAndFocus(string msg, string title, Control control)
        {
            MessageBox.Show(title, msg);
            control.Focus();
        }

    }
}
