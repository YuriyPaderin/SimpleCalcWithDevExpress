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
        private static string[] _errorTable = { "Вы ввели неизвестную операцию.", "Неверный формат строки.", "Неверное соотношение цифр и операций.", "Неизвестный тип ошибки." };

        public MainForm()
        {
            InitializeComponent();
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataBaseForSimpleCalcDataSet.Notes' table. You can move, or remove it, as needed.
            this.notesTableAdapter.Fill(this.dataBaseForSimpleCalcDataSet.Notes);
            foreach (var note in this.dataBaseForSimpleCalcDataSet.Notes)
            {
                if (!note.IsResultNull() || note.ErrorCode != 0)
                    note.Message = note.ErrorCode == 0 ? note.Result.ToString() : _errorTable[note.ErrorCode - 1];
            }
        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            if (txtExpression.EditValue != null)
            {
                int errorCode;
                var result = new Calculator().Evaluate(txtExpression.EditValue.ToString(), out errorCode);
                var expression = txtExpression.EditValue.ToString();
                var message = errorCode == 0 ? result.ToString() : _errorTable[errorCode - 1];

                if (errorCode == 0)
                    txtResult.EditValue = result.ToString();
                else
                    MessageBox.Show(_errorTable[errorCode - 1], "Error");

                this.dataBaseForSimpleCalcDataSet.Notes.AddNotesRow(Guid.NewGuid(), expression, result, DateTime.Now, "localhost", errorCode, message);
                this.notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
                dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var view = (DataRowView)gridView1.GetFocusedRow();

            using (var editForm = new NoteEditForm((Guid)view["Id"]))
            {
                editForm.ShowDialog();

                if (editForm.DialogResult == DialogResult.OK)
                {
                    this.notesTableAdapter.ClearBeforeFill = false;
                    this.notesTableAdapter.FillBy(dataBaseForSimpleCalcDataSet.Notes, (Guid)view["Id"]);

                    view["Message"] = (int)view["ErrorCode"] == 0 ? view["Result"].ToString() : _errorTable[(int)view["ErrorCode"] - 1];

                    this.notesTableAdapter.ClearBeforeFill = true;
                }
            }
        }
    }
}
