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
        private DataBaseForSimpleCalcDataSet.NotesRow _row;

        public NoteEditForm(Guid id)
        {
            InitializeComponent();

            this.notesTableAdapter1.FillBy(this.dataBaseForSimpleCalcDataSet.Notes, id);
            _row = this.dataBaseForSimpleCalcDataSet.Notes.FindById(id);
        }

        private void UpdateFormState()
        {
            txtResult.Enabled = (int)intErrorCode.EditValue == 0 ? true : false;
        }   

        private bool ValidateForm()
        {
            var expressionIsEmpty = !(txtExpression.EditValue != null && txtExpression.EditValue.ToString().Length > 0);
            var resultIsEmpty = ((int)intErrorCode.EditValue == 0 && !(txtResult.EditValue != null && txtResult.EditValue.ToString().Length > 0));
            var dateAndTimeIsEmpty = !(txtDateAndTime.EditValue != null && txtDateAndTime.EditValue.ToString().Length > 0);
            var hostNameIsEmpty = !(txtHostName.EditValue != null && txtHostName.EditValue.ToString().Length > 0);

            if (expressionIsEmpty)
                MessageBox.Show("Полe \"Expression\" обзательно для заполнения", "Error");

            if (resultIsEmpty)
                MessageBox.Show("Поле \"Result\" обязательно для заполнения", "Error");

            if (dateAndTimeIsEmpty)
                MessageBox.Show("Полe \"DateAndTime\" обзательно для заполнения", "Error");

            if (hostNameIsEmpty)
                MessageBox.Show("Полe \"HostName\" обзательно для заполнения", "Error");

            return !(expressionIsEmpty || resultIsEmpty || dateAndTimeIsEmpty || hostNameIsEmpty);
        }

        private void SaveChanges()
        {
            _row.BeginEdit();
            _row.Expression = (string)txtExpression.EditValue.ToString();
            _row.Result = Double.Parse(txtResult.EditValue.ToString());
            _row.DateAndTime = (DateTime)txtDateAndTime.EditValue;
            _row.HostName = (string)txtHostName.EditValue;
            _row.ErrorCode = (int)intErrorCode.EditValue;

            var errorCode = (int)intErrorCode.EditValue;
            _row.Message = errorCode == 0 ? txtResult.EditValue.ToString() : _errorTable[errorCode - 1];
            _row.EndEdit();

            this.notesTableAdapter1.Update(this.dataBaseForSimpleCalcDataSet.Notes);
            this.dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
        }

        private void GeneralNotesEditForm_Load(object sender, EventArgs e)
        {
            txtExpression.EditValue = _row.Expression;
            txtResult.EditValue = _row.Result;
            txtDateAndTime.EditValue = _row.DateAndTime;
            txtHostName.EditValue = _row.HostName;
            intErrorCode.EditValue = _row.ErrorCode;

            UpdateFormState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                SaveChanges();
            else
                this.DialogResult = DialogResult.None;
        }

        private void intErrorCode_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFormState();
        }
    }
}
