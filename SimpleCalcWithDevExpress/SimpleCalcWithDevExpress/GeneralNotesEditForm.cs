using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalcWithDevExpress
{
    public partial class GeneralNotesEditForm : Form
    {
        public DataRowView View { get; private set; }

        public GeneralNotesEditForm(DataRowView view)
        {
            InitializeComponent();

            View = view;
        }

        private void GeneralNotesEditForm_Load(object sender, EventArgs e)
        {
            txtExpression.EditValue = View.Row["Expression"];
            txtResult.EditValue = View.Row["Result"];
            txtDateAndTime.EditValue = View.Row["DateAndTime"];
            txtHostName.EditValue = View.Row["HostName"];
            txtErrorCode.EditValue = View.Row["ErrorCode"];
            txtMessage.EditValue = View.Row["Message"];
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var expressionIsNull = String.IsNullOrEmpty(txtExpression.EditValue.ToString());
            var dateAndTimeIsNull = String.IsNullOrEmpty(txtDateAndTime.EditValue.ToString());
            var hostNameIsNull = String.IsNullOrEmpty(txtHostName.EditValue.ToString());

            if(expressionIsNull || dateAndTimeIsNull || hostNameIsNull)
            {
                MessageBox.Show("Поля \"Expression\", \"DateAndTime\" и \"HostName\" обзательны для заполнения");
                this.DialogResult = DialogResult.None;
            }
            else
            {
                View.BeginEdit();
                View.Row["Expression"] = txtExpression.EditValue;
                View.Row["Result"] = txtResult.EditValue;
                View.Row["DateAndTime"] = txtDateAndTime.EditValue;
                View.Row["HostName"] = txtHostName.EditValue;
                View.Row["ErrorCode"] = txtErrorCode.EditValue;
                View.Row["Message"] = txtMessage.EditValue;
                View.EndEdit();
            }
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
