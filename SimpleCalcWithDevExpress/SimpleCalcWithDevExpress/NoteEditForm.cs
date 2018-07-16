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
    public partial class NoteEditForm : Form
    {
        private static string[] _errorTable = { "Вы ввели неизвестную операцию.", "Неверный формат строки.", "Неверное соотношение цифр и операций.", "Неизвестный тип ошибки." };
        private string _message;

        public DataRowView View { get; private set; }

        public NoteEditForm(DataRowView view)
        {
            InitializeComponent();

            View = view;
        }

        private bool ValidateForm()
        {
            var expressionIsEmpty = !(txtExpression.EditValue != null && txtExpression.EditValue.ToString().Length > 0);
            var dateAndTimeIsEmpty = !(txtDateAndTime.EditValue != null && txtDateAndTime.EditValue.ToString().Length > 0);
            var hostNameIsEmpty = !(txtHostName.EditValue != null && txtHostName.EditValue.ToString().Length > 0);

            if (expressionIsEmpty)
                MessageBox.Show("Полe \"Expression\" обзательно для заполнения", "Error");

            if (dateAndTimeIsEmpty)
                MessageBox.Show("Полe \"DateAndTime\" обзательно для заполнения", "Error");

            if (hostNameIsEmpty)
                MessageBox.Show("Полe \"HostName\" обзательно для заполнения");

            return !(expressionIsEmpty || dateAndTimeIsEmpty || hostNameIsEmpty);
        }

        private void SaveChanges()
        {
            View.BeginEdit();
            View.Row["Expression"] = txtExpression.EditValue;
            View.Row["Result"] = txtResult.EditValue;
            View.Row["DateAndTime"] = txtDateAndTime.EditValue;
            View.Row["HostName"] = txtHostName.EditValue;
            View.Row["ErrorCode"] = txtErrorCode.EditValue;
            View.Row["Message"] = _message;
            View.EndEdit();
        }

        private void GeneralNotesEditForm_Load(object sender, EventArgs e)
        {
            txtExpression.EditValue = View.Row["Expression"];
            txtResult.EditValue = View.Row["Result"];
            txtDateAndTime.EditValue = View.Row["DateAndTime"];
            txtHostName.EditValue = View.Row["HostName"];
            txtErrorCode.EditValue = View.Row["ErrorCode"];

            if ((int)txtErrorCode.EditValue != 0)
                txtResult.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                SaveChanges();
            else
                this.DialogResult = DialogResult.None;
        }

        private void txtMessage_EditValueChanged(object sender, EventArgs e)
        {
            var result = txtResult.EditValue ?? 0f;
            var errorCode = (int)txtErrorCode.EditValue;

            if(errorCode == 0)
            {
                _message = ((double)result).ToString();
                txtResult.Enabled = true;
            }
            else
            {
                _message = _errorTable[errorCode - 1];
            }
        }
    }
}
