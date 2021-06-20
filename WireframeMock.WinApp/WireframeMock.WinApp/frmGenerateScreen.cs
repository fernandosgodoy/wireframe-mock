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
        private IList<ScreenFieldInfo> ViewGrid { get; set; }

        public frmGenerateScreen()
        {
            InitializeComponent();
            ViewGrid = new List<ScreenFieldInfo>();
        }

        private void frmGenerateScreen_Load(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void btnInclude_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Populate();
                FillDataGrid();
                CleanFields();
            }
        }

        private void Populate()
        {
            ViewGrid.Add(new ScreenFieldInfo()
            {
                FieldName = txtFieldName.Text,
                Type = cboType.SelectedValue.ToString(),
                ClassInfo = txtClass.Text,
                IsRequired = chkRequired.Checked
            });
        }

        private void FillDataGrid()
        {
            dgvFields.DataSource = ViewGrid;
            dgvFields.Refresh();
        }

        private bool ValidateForm()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(txtFieldName.Text))
            {
                ShowMessageAndFocus(TITLE, "Fill the Field Name field.", txtFieldName);
                isValid = false;
            }

            if ((cboType.SelectedValue == null) || ((int)cboType.SelectedValue == 0))
            {
                ShowMessageAndFocus(TITLE, "Fill the Type field.", cboType);
                isValid = false;
            }

            return isValid;
        }

        private void FillComboBox()
        {
            cboType.DataSource = Enum.GetValues(typeof(FieldType));
        }

        private static void ShowMessageAndFocus(string msg, string title, Control control)
        {
            MessageBox.Show(title, msg);
            control.Focus();
        }

        private void btnGenerateFile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPathInfo.Text))
            {

            }
            else
                ShowMessageAndFocus("Fill the path where'll be generated the files.", TITLE, txtPathInfo);
        }

        private void CleanFields()
        {
            this.txtFieldName.Text =
                this.lblClass.Text = "";
            this.cboType.SelectedIndex = -1;
            this.chkRequired.Checked = false;
        }

    }
}
