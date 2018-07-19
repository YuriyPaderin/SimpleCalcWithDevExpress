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
    public partial class NoteEditSecondForm : Form
    {
        private BindingSource _formDataSource = new BindingSource();

        public NoteEditSecondForm(DataBaseForSimpleCalcDataSet.NotesDataTable notes, Guid id)
        {
            InitializeComponent();

            _formDataSource.DataSource = notes.FindById(id);
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

        private void GeneralNotesEditSecondForm_Load(object sender, EventArgs e)
        {
            _formDataSource.Position = 0;
            txtExpression.DataBindings.Add("Text", _formDataSource, dataBaseForSimpleCalcDataSet.Notes.ExpressionColumn.ColumnName);
            txtResult.DataBindings.Add("Text", _formDataSource, dataBaseForSimpleCalcDataSet.Notes.ResultColumn.ColumnName);
            txtDateAndTime.DataBindings.Add("Text", _formDataSource, dataBaseForSimpleCalcDataSet.Notes.DateAndTimeColumn.ColumnName);
            txtHostName.DataBindings.Add("Text", _formDataSource, dataBaseForSimpleCalcDataSet.Notes.HostNameColumn.ColumnName);
            cmbErrorCode.DataBindings.Add("Value", _formDataSource, dataBaseForSimpleCalcDataSet.Notes.ErrorCodeColumn.ColumnName);
  
            UpdateFormState();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                this.DialogResult = DialogResult.None;
        }

        private void cmbErrorCode_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFormState();
        }
    }
}
