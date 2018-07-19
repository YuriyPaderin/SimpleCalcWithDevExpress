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
    public partial class CommentEditForm : Form
    {
        private Guid _id;
        private BindingSource _noteDataSource = new BindingSource();
        private BindingSource _commentsDataSource = new BindingSource();
        private DataBaseForSimpleCalcDataSet _dataSet = new DataBaseForSimpleCalcDataSet();

        public CommentEditForm(DataBaseForSimpleCalcDataSet dataSet, Guid id)
        {
            InitializeComponent();

            _id = id;
            _dataSet = dataSet;

            _noteDataSource.DataSource = dataSet.Notes.OrderByDescending(c => c.DateAndTime);
            _commentsDataSource.DataSource = dataSet.Comments.Where(c => c.RowId == id);
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
            _noteDataSource.EndEdit();
            _commentsDataSource.EndEdit();
        }

        private void GeneralNotesEditForm_Load(object sender, EventArgs e)
        {
            _noteDataSource.Position = 0;
            txtExpression.DataBindings.Add("Text", _noteDataSource, _dataSet.Notes.ExpressionColumn.ColumnName);
            txtResult.DataBindings.Add("Text", _noteDataSource, _dataSet.Notes.ResultColumn.ColumnName);
            txtDateAndTime.DataBindings.Add("Text", _noteDataSource, _dataSet.Notes.DateAndTimeColumn.ColumnName);
            txtHostName.DataBindings.Add("Text", _noteDataSource, _dataSet.Notes.HostNameColumn.ColumnName);
            cmbErrorCode.DataBindings.Add("Value", _noteDataSource, _dataSet.Notes.ErrorCodeColumn.ColumnName);

            gridControl1.DataSource = _commentsDataSource;

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

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var row = (DataBaseForSimpleCalcDataSet.CommentsRow)gridView2.GetFocusedDataRow();
            row.RowId = _id; 
            row.EndEdit();
        }
    }
}
