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
        private string[] _errorTable = { "Вы ввели неизвестную операцию.", "Неверный формат строки.", "Неверное соотношение цифр и операций.", "Неизвестный тип ошибки" };

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

                txtExpression.EditValue = errorCode == 0 ? txtExpression.EditValue + " = " + result.ToString() : _errorTable[errorCode - 1];

                this.dataBaseForSimpleCalcDataSet.Notes.AddNotesRow(Guid.NewGuid(), expression, result, DateTime.Now, "localhost", errorCode, message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var view = (DataRowView)gridView1.GetFocusedRow();

            using (var editForm = new MainNotesEditForm(view))
            {
                editForm.ShowDialog();
            }

            this.notesTableAdapter.Update(dataBaseForSimpleCalcDataSet.Notes);
            dataBaseForSimpleCalcDataSet.Notes.AcceptChanges();
        }
    }
}
