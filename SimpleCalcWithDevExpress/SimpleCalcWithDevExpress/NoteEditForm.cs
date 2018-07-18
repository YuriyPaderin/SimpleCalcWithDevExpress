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
        private BindingSource formDataSource = new BindingSource();

        public NoteEditForm(Guid id)
        {
            InitializeComponent();

            this.notesTableAdapter.FillBy(this.dataBaseForSimpleCalcDataSet.Notes, id);
            formDataSource.DataSource = this.dataBaseForSimpleCalcDataSet.Notes.FindById(id);
        }

        private void UpdateFormState()
        {
            txtResult.Enabled = (int)cmbErrorCode.EditValue == 0 ? true : false;
        }   

        private bool ValidateForm()
        {
            var expressionIsEmpty = !(txtExpression.EditValue != null && txtExpression.EditValue.ToString().Length > 0);
            var resultIsEmpty = ((int)cmbErrorCode.EditValue == 0 && !(txtResult.EditValue != null && txtResult.EditValue.ToString().Length > 0));
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
            this.notesTableAdapter.Update(this.dataBaseForSimpleCalcDataSet.Notes);
            this.dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
        }

        private void GeneralNotesEditForm_Load(object sender, EventArgs e)
        {
            txtExpression.DataBindings.Add("Text", formDataSource, "Expression");
            txtResult.DataBindings.Add("Text", formDataSource, "Result");
            txtDateAndTime.DataBindings.Add("Text", formDataSource, "DateAndTime");
            txtHostName.DataBindings.Add("Text", formDataSource, "HostName");
            cmbErrorCode.DataBindings.Add("Value", formDataSource, "ErrorCode");
  
            UpdateFormState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                SaveChanges();
            else
                this.DialogResult = DialogResult.None;
        }

        private void cmbErrorCode_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFormState();
        }
    }
}
