namespace SimpleCalcWithDevExpress
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtExpression = new DevExpress.XtraEditors.TextEdit();
            this.btnEval = new DevExpress.XtraEditors.SimpleButton();
            this.cmbNotes = new DevExpress.XtraGrid.GridControl();
            this.notesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseForSimpleCalcDataSet = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSet();
            this.gridViewNotes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExpression = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateAndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.notesTableAdapter = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter();
            this.txtResult = new DevExpress.XtraEditors.TextEdit();
            this.lblExpression = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbComments = new DevExpress.XtraGrid.GridControl();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewComments = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.commentsTableAdapter = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSetTableAdapters.CommentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(12, 38);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExpression.Properties.Appearance.Options.UseFont = true;
            this.txtExpression.Size = new System.Drawing.Size(269, 26);
            this.txtExpression.TabIndex = 0;
            // 
            // btnEval
            // 
            this.btnEval.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEval.Appearance.Options.UseFont = true;
            this.btnEval.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEval.Location = new System.Drawing.Point(560, 37);
            this.btnEval.Name = "btnEval";
            this.btnEval.Size = new System.Drawing.Size(151, 28);
            this.btnEval.TabIndex = 1;
            this.btnEval.Text = "Расчет";
            this.btnEval.Click += new System.EventHandler(this.btnEval_Click);
            // 
            // cmbNotes
            // 
            this.cmbNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNotes.DataSource = this.notesBindingSource;
            this.cmbNotes.Location = new System.Drawing.Point(12, 71);
            this.cmbNotes.MainView = this.gridViewNotes;
            this.cmbNotes.Name = "cmbNotes";
            this.cmbNotes.Size = new System.Drawing.Size(931, 410);
            this.cmbNotes.TabIndex = 2;
            this.cmbNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNotes});
            // 
            // notesBindingSource
            // 
            this.notesBindingSource.DataMember = "Notes";
            this.notesBindingSource.DataSource = this.dataBaseForSimpleCalcDataSet;
            // 
            // dataBaseForSimpleCalcDataSet
            // 
            this.dataBaseForSimpleCalcDataSet.DataSetName = "DataBaseForSimpleCalcDataSet";
            this.dataBaseForSimpleCalcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridViewNotes
            // 
            this.gridViewNotes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExpression,
            this.colResult,
            this.DateAndTime});
            this.gridViewNotes.GridControl = this.cmbNotes;
            this.gridViewNotes.Name = "gridViewNotes";
            this.gridViewNotes.OptionsBehavior.Editable = false;
            this.gridViewNotes.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewNotes.OptionsView.ShowGroupPanel = false;
            this.gridViewNotes.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DateAndTime, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridViewNotes.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridViewNotes_RowCellClick);
            // 
            // colExpression
            // 
            this.colExpression.Caption = "Выражение";
            this.colExpression.FieldName = "Expression";
            this.colExpression.Name = "colExpression";
            this.colExpression.Visible = true;
            this.colExpression.VisibleIndex = 0;
            // 
            // colResult
            // 
            this.colResult.Caption = "Результат";
            this.colResult.FieldName = "Message";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.ShowInCustomizationForm = false;
            this.colResult.OptionsColumn.ShowInExpressionEditor = false;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 1;
            // 
            // DateAndTime
            // 
            this.DateAndTime.FieldName = "DateAndTime";
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Location = new System.Drawing.Point(717, 37);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 28);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(287, 38);
            this.txtResult.Name = "txtResult";
            this.txtResult.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Properties.Appearance.Options.UseFont = true;
            this.txtResult.Size = new System.Drawing.Size(267, 26);
            this.txtResult.TabIndex = 4;
            // 
            // lblExpression
            // 
            this.lblExpression.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpression.Appearance.Options.UseFont = true;
            this.lblExpression.Location = new System.Drawing.Point(12, 13);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(83, 19);
            this.lblExpression.TabIndex = 5;
            this.lblExpression.Text = "Выражение";
            // 
            // lblResult
            // 
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Location = new System.Drawing.Point(287, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 19);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Результат";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(833, 37);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbComments
            // 
            this.cmbComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbComments.DataSource = this.commentsBindingSource;
            this.cmbComments.Location = new System.Drawing.Point(12, 487);
            this.cmbComments.MainView = this.gridViewComments;
            this.cmbComments.Name = "cmbComments";
            this.cmbComments.Size = new System.Drawing.Size(931, 130);
            this.cmbComments.TabIndex = 9;
            this.cmbComments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComments});
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.dataBaseForSimpleCalcDataSet;
            // 
            // gridViewComments
            // 
            this.gridViewComments.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewComments.GridControl = this.cmbComments;
            this.gridViewComments.Name = "gridViewComments";
            this.gridViewComments.OptionsBehavior.Editable = false;
            this.gridViewComments.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save;
            this.gridViewComments.OptionsView.ShowGroupPanel = false;
            this.gridViewComments.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "DateAndTime";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Комментарии";
            this.gridColumn4.FieldName = "Comment";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 629);
            this.Controls.Add(this.cmbComments);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbNotes);
            this.Controls.Add(this.btnEval);
            this.Controls.Add(this.txtExpression);
            this.Name = "MainForm";
            this.Text = "SimpleCalcWithDevExpress";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtExpression;
        private DevExpress.XtraEditors.SimpleButton btnEval;
        private DevExpress.XtraGrid.GridControl cmbNotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colExpression;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DataBaseForSimpleCalcDataSet dataBaseForSimpleCalcDataSet;
        private System.Windows.Forms.BindingSource notesBindingSource;
        private DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn DateAndTime;
        private DevExpress.XtraEditors.TextEdit txtResult;
        private DevExpress.XtraEditors.LabelControl lblExpression;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraGrid.GridControl cmbComments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComments;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private DataBaseForSimpleCalcDataSetTableAdapters.CommentsTableAdapter commentsTableAdapter;
    }
}

