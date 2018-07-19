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

        private void UpdateRow(DataBaseForSimpleCalcDataSet.NotesRow row)
        {
            string[] errorTable = { "Вы ввели неизвестную операцию.", "Неверный формат строки.", "Неверное соотношение цифр и операций.", "Неизвестный тип ошибки." };
            row.Message =  row.ErrorCode == 0 ? row.Result.ToString() : errorTable[row.ErrorCode - 1];
        }

        private void UpdateComment()
        {
            var row = (DataBaseForSimpleCalcDataSet.NotesRow)gridView1.GetFocusedDataRow();
            gridControl1.DataSource = dataBaseForSimpleCalcDataSet.Comments.Where(c => c.RowId == row.Id);
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseForSimpleCalcDataSet.Notes' table. You can move, or remove it, as needed.
            notesTableAdapter.Fill(dataBaseForSimpleCalcDataSet.Notes);
            commentsTableAdapter.Fill(dataBaseForSimpleCalcDataSet.Comments);

            foreach (var note in dataBaseForSimpleCalcDataSet.Notes)
            {
                if (note.IsResultNull())
                    note.Result = 0;

                UpdateRow(note);
            }

            gridView1.MoveFirst();
            UpdateComment();
        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            if (txtExpression.EditValue != null)
            {
                var row = dataBaseForSimpleCalcDataSet.Notes.NewNotesRow();
                row.Id = Guid.NewGuid();
                int errorCode;
                row.Result = new Calculator().Evaluate(txtExpression.EditValue.ToString(), out errorCode);
                row.ErrorCode = errorCode;
                row.HostName = "localhost";
                row.DateAndTime = DateTime.Now;

                UpdateRow(row);

                if (row.ErrorCode == 0)
                    txtResult.EditValue = row.Result.ToString();
                else
                    MessageBox.Show(row.Message.ToString(), "Error");

                dataBaseForSimpleCalcDataSet.Notes.AddNotesRow(row);
                notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
                dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
            }
        }

        private void btnEdit1_Click(object sender, EventArgs e)
        {
            var row = (DataBaseForSimpleCalcDataSet.NotesRow)gridView1.GetFocusedDataRow();

            using (var editForm = new NoteEditForm(row.Id))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    notesTableAdapter.ClearBeforeFill = false;
                    notesTableAdapter.FillBy(dataBaseForSimpleCalcDataSet.Notes, row.Id);

                    UpdateRow(row);

                    notesTableAdapter.ClearBeforeFill = true;
                }
            }
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            var row = (DataBaseForSimpleCalcDataSet.NotesRow)gridView1.GetFocusedDataRow();

            using (var editForm = new CommentEditForm(dataBaseForSimpleCalcDataSet ,row.Id))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
                    commentsTableAdapter.Update(dataBaseForSimpleCalcDataSet.Comments);
                    dataBaseForSimpleCalcDataSet.AcceptChanges();
                    UpdateComment();
                }
                else
                {
                    dataBaseForSimpleCalcDataSet.RejectChanges();
                }
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            UpdateComment();
        }
    }
}
