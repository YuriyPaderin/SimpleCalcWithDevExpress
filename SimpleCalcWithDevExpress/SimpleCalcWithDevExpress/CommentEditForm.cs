﻿using System;
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
        private BindingSource _noteDataSource = new BindingSource();
        private BindingSource _commentsDataSource = new BindingSource();
        private DataBaseForSimpleCalcDataSet.CommentsRow _commentRow;

        public DataBaseForSimpleCalcDataSet DataSet { get; private set; }

        public CommentEditForm(DataBaseForSimpleCalcDataSet dataSet, Guid id)
        {
            InitializeComponent();
            DataSet = (DataBaseForSimpleCalcDataSet)dataSet.Copy();
  
            AddCommentRow(id);

            _noteDataSource.DataSource = DataSet.Notes.Where(notesRow => notesRow.Id == id);
            _commentsDataSource.DataSource = DataSet.Comments.Where(commentsRow => commentsRow.NoteId == id).OrderBy(commentsRow => commentsRow.DateAndTime);
        }

        public void AddCommentRow(Guid noteId)
        {
            _commentRow = DataSet.Comments.NewCommentsRow();
            _commentRow.Id = Guid.NewGuid();
            _commentRow.NoteId = noteId;
            _commentRow.Comment = "<Добавить новую запись>";
            _commentRow.DateAndTime = DateTime.Now;
            DataSet.Comments.AddCommentsRow(_commentRow);
            _commentsDataSource.Add(_commentRow);
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

        private void GeneralNotesEditForm_Load(object sender, EventArgs e)
        {
            txtExpression.DataBindings.Add("Text", _noteDataSource, DataSet.Notes.ExpressionColumn.ColumnName);
            txtResult.DataBindings.Add("Text", _noteDataSource, DataSet.Notes.ResultColumn.ColumnName);
            txtDateAndTime.DataBindings.Add("Text", _noteDataSource, DataSet.Notes.DateAndTimeColumn.ColumnName);
            txtHostName.DataBindings.Add("Text", _noteDataSource, DataSet.Notes.HostNameColumn.ColumnName);
            cmbErrorCode.DataBindings.Add("Value", _noteDataSource, DataSet.Notes.ErrorCodeColumn.ColumnName);

            cmbComments.DataSource = _commentsDataSource;
            
            UpdateFormState();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                DialogResult = DialogResult.None;
            else
                DataSet.Comments.RemoveCommentsRow(_commentRow);
        }

        private void cmbErrorCode_EditValueChanged(object sender, EventArgs e)
        {
            UpdateFormState();
        }

        private void gridViewComments_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var index = gridViewComments.GetFocusedDataSourceRowIndex();

            if (index == gridViewComments.RowCount - 1)
                AddCommentRow(_commentRow.NoteId);
        }
    }
}
