﻿namespace SimpleCalcWithDevExpress
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
            this.notesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseForSimpleCalcDataSet = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colExpression = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateAndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnEdit1 = new DevExpress.XtraEditors.SimpleButton();
            this.notesTableAdapter = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter();
            this.txtResult = new DevExpress.XtraEditors.TextEdit();
            this.lblExpression = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.btnEdit2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(21, 38);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExpression.Properties.Appearance.Options.UseFont = true;
            this.txtExpression.Size = new System.Drawing.Size(267, 26);
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
            this.cmbNotes.DataSource = this.notesBindingSource2;
            this.cmbNotes.Location = new System.Drawing.Point(12, 71);
            this.cmbNotes.MainView = this.gridView1;
            this.cmbNotes.Name = "cmbNotes";
            this.cmbNotes.Size = new System.Drawing.Size(931, 546);
            this.cmbNotes.TabIndex = 2;
            this.cmbNotes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // notesBindingSource2
            // 
            this.notesBindingSource2.DataMember = "Notes";
            this.notesBindingSource2.DataSource = this.dataBaseForSimpleCalcDataSet;
            // 
            // dataBaseForSimpleCalcDataSet
            // 
            this.dataBaseForSimpleCalcDataSet.DataSetName = "DataBaseForSimpleCalcDataSet";
            this.dataBaseForSimpleCalcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colExpression,
            this.colResult,
            this.DateAndTime});
            this.gridView1.GridControl = this.cmbNotes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.DateAndTime, DevExpress.Data.ColumnSortOrder.Descending)});
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
            // btnEdit1
            // 
            this.btnEdit1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit1.Appearance.Options.UseFont = true;
            this.btnEdit1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit1.Location = new System.Drawing.Point(717, 37);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(110, 28);
            this.btnEdit1.TabIndex = 3;
            this.btnEdit1.Text = "Изменить 1";
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit1_Click);
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
            this.lblResult.Location = new System.Drawing.Point(278, 13);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(73, 19);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Результат";
            // 
            // btnEdit2
            // 
            this.btnEdit2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit2.Appearance.Options.UseFont = true;
            this.btnEdit2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit2.Location = new System.Drawing.Point(833, 37);
            this.btnEdit2.Name = "btnEdit2";
            this.btnEdit2.Size = new System.Drawing.Size(110, 28);
            this.btnEdit2.TabIndex = 8;
            this.btnEdit2.Text = "Изменить 2";
            this.btnEdit2.Click += new System.EventHandler(this.btnEdit2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 629);
            this.Controls.Add(this.btnEdit2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEdit1);
            this.Controls.Add(this.cmbNotes);
            this.Controls.Add(this.btnEval);
            this.Controls.Add(this.txtExpression);
            this.Name = "MainForm";
            this.Text = "SimpleCalcWithDevExpress";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtExpression;
        private DevExpress.XtraEditors.SimpleButton btnEval;
        private DevExpress.XtraGrid.GridControl cmbNotes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colExpression;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraEditors.SimpleButton btnEdit1;
        private DataBaseForSimpleCalcDataSet dataBaseForSimpleCalcDataSet;
        private System.Windows.Forms.BindingSource notesBindingSource2;
        private DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn DateAndTime;
        private DevExpress.XtraEditors.TextEdit txtResult;
        private DevExpress.XtraEditors.LabelControl lblExpression;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.SimpleButton btnEdit2;
    }
}

