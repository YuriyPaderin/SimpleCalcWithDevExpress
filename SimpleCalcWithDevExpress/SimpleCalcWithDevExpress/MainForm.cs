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

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseForSimpleCalcDataSet.Notes' table. You can move, or remove it, as needed.
            this.notesTableAdapter.Fill(this.dataBaseForSimpleCalcDataSet.Notes);
            foreach (var note in this.dataBaseForSimpleCalcDataSet.Notes)
            {
                if (note.IsResultNull())
                    note.Result = 0;

                UpdateRow(note);
            }
        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            if (txtExpression.EditValue != null)
            {
                var row = this.dataBaseForSimpleCalcDataSet.Notes.NewNotesRow();
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

                this.dataBaseForSimpleCalcDataSet.Notes.AddNotesRow(row);
                this.notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
                dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var row = (DataBaseForSimpleCalcDataSet.NotesRow)gridView1.GetFocusedDataRow();

            using (var editForm = new NoteEditForm(row.Id))
            {
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    this.notesTableAdapter.ClearBeforeFill = false;
                    this.notesTableAdapter.FillBy(dataBaseForSimpleCalcDataSet.Notes, row.Id);

                    UpdateRow(row);

                    this.notesTableAdapter.ClearBeforeFill = true;
                }
            }
        }
    }
}
