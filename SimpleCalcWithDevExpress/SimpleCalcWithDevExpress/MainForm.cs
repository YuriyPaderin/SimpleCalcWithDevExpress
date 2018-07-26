using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SimpleCalc;

namespace SimpleCalcWithDevExpress
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateNotesRow(DataBaseForSimpleCalcDataSet.NotesRow notesRow)
        {
            string[] errorTable = { "Вы ввели неизвестную операцию.", "Неверный формат строки.", "Неверное соотношение цифр и операций.", "Неизвестный тип ошибки." };
            notesRow.Message =  notesRow.ErrorCode == 0 ? notesRow.Result.ToString() : errorTable[notesRow.ErrorCode - 1];
        }

        private void UpdateCommentsRow(DataBaseForSimpleCalcDataSet.NotesRow notesRow)
        {
            cmbComments.DataSource = dataBaseForSimpleCalcDataSet.Comments.Where(commentsRow => commentsRow.NoteId == notesRow.Id);
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseForSimpleCalcDataSet.Notes' table. You can move, or remove it, as needed.
            notesTableAdapter.Fill(dataBaseForSimpleCalcDataSet.Notes);
            commentsTableAdapter.Fill(dataBaseForSimpleCalcDataSet.Comments);

            var noteRow = (DataBaseForSimpleCalcDataSet.NotesRow)dataBaseForSimpleCalcDataSet.Notes.Rows[0];
            foreach (var note in dataBaseForSimpleCalcDataSet.Notes)
            {
                if (!note.IsResultNull())
                    UpdateNotesRow(note);

                if (noteRow.DateAndTime < note.DateAndTime)
                    noteRow = note;
            }

            UpdateCommentsRow(noteRow);
        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            if (txtExpression.EditValue != null)
            {
                var notesRow = dataBaseForSimpleCalcDataSet.Notes.NewNotesRow();
                notesRow.Id = Guid.NewGuid();
                notesRow.Result = new Calculator().Evaluate(txtExpression.EditValue.ToString(), out int errorCode);
                notesRow.ErrorCode = errorCode;
                notesRow.HostName = "localhost";
                notesRow.DateAndTime = DateTime.Now;

                UpdateNotesRow(notesRow);

                if (notesRow.ErrorCode == 0)
                    txtResult.EditValue = notesRow.Result.ToString();
                else
                    MessageBox.Show(notesRow.Message.ToString(), "Error");

                dataBaseForSimpleCalcDataSet.Notes.AddNotesRow(notesRow);
                notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
                dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var notesRow = (DataBaseForSimpleCalcDataSet.NotesRow)gridViewNotes.GetFocusedDataRow();

            using (var editForm = new CommentEditForm(dataBaseForSimpleCalcDataSet, notesRow.Id))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    dataBaseForSimpleCalcDataSet.Merge(editForm.DataSet, false, MissingSchemaAction.Add);
                    UpdateNotesRow(notesRow);
                    UpdateCommentsRow(notesRow);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
            commentsTableAdapter.Update(dataBaseForSimpleCalcDataSet.Comments);
            dataBaseForSimpleCalcDataSet.AcceptChanges();
        }

        private void gridViewNotes_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            var notesRow = (DataBaseForSimpleCalcDataSet.NotesRow)gridViewNotes.GetFocusedDataRow();
            UpdateCommentsRow(notesRow);
        }
    }
}
