﻿namespace SimpleCalcWithDevExpress
{
    partial class NoteEditForm
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
            this.txtResult = new DevExpress.XtraEditors.TextEdit();
            this.lblExpression = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lblDateAndTime = new DevExpress.XtraEditors.LabelControl();
            this.txtDateAndTime = new DevExpress.XtraEditors.TextEdit();
            this.lblHostName = new DevExpress.XtraEditors.LabelControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.cmbErrorCode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.dataBaseForSimpleCalcDataSet = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSet();
            this.dataBaseForSimpleCalcDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notesTableAdapter = new SimpleCalcWithDevExpress.DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter();
            this.txtHostName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateAndTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbErrorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExpression.Location = new System.Drawing.Point(24, 55);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExpression.Properties.Appearance.Options.UseFont = true;
            this.txtExpression.Size = new System.Drawing.Size(392, 26);
            this.txtExpression.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.Location = new System.Drawing.Point(24, 129);
            this.txtResult.Name = "txtResult";
            this.txtResult.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtResult.Properties.Appearance.Options.UseFont = true;
            this.txtResult.Size = new System.Drawing.Size(392, 26);
            this.txtResult.TabIndex = 1;
            // 
            // lblExpression
            // 
            this.lblExpression.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblExpression.Appearance.Options.UseFont = true;
            this.lblExpression.Location = new System.Drawing.Point(24, 30);
            this.lblExpression.Name = "lblExpression";
            this.lblExpression.Size = new System.Drawing.Size(76, 19);
            this.lblExpression.TabIndex = 2;
            this.lblExpression.Text = "Expression";
            // 
            // lblResult
            // 
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Location = new System.Drawing.Point(24, 104);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 19);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(21, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(193, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateAndTime.Appearance.Options.UseFont = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(24, 181);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(97, 19);
            this.lblDateAndTime.TabIndex = 6;
            this.lblDateAndTime.Text = "DateAndTime";
            // 
            // txtDateAndTime
            // 
            this.txtDateAndTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateAndTime.Location = new System.Drawing.Point(24, 206);
            this.txtDateAndTime.Name = "txtDateAndTime";
            this.txtDateAndTime.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDateAndTime.Properties.Appearance.Options.UseFont = true;
            this.txtDateAndTime.Size = new System.Drawing.Size(392, 26);
            this.txtDateAndTime.TabIndex = 7;
            // 
            // lblHostName
            // 
            this.lblHostName.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHostName.Appearance.Options.UseFont = true;
            this.lblHostName.Location = new System.Drawing.Point(24, 263);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(73, 19);
            this.lblHostName.TabIndex = 8;
            this.lblHostName.Text = "HostName";
            // 
            // lblMessage
            // 
            this.lblMessage.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.Appearance.Options.UseFont = true;
            this.lblMessage.Location = new System.Drawing.Point(24, 345);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(59, 19);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "Message";
            // 
            // cmbErrorCode
            // 
            this.cmbErrorCode.Location = new System.Drawing.Point(21, 370);
            this.cmbErrorCode.Name = "cmbErrorCode";
            this.cmbErrorCode.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.cmbErrorCode.Properties.Appearance.Options.UseFont = true;
            this.cmbErrorCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbErrorCode.Properties.DropDownRows = 5;
            this.cmbErrorCode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("<Вывести результат>", 0, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Вы ввели неизвестную операцию.", 1, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Неверный формат строки.", 2, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Неверное соотношение цифр и операций.", 3, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Неизвестный тип ошибки.", 4, -1)});
            this.cmbErrorCode.Size = new System.Drawing.Size(395, 26);
            this.cmbErrorCode.TabIndex = 14;
            this.cmbErrorCode.EditValueChanged += new System.EventHandler(this.cmbErrorCode_EditValueChanged);
            // 
            // dataBaseForSimpleCalcDataSet
            // 
            this.dataBaseForSimpleCalcDataSet.DataSetName = "DataBaseForSimpleCalcDataSet";
            this.dataBaseForSimpleCalcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBaseForSimpleCalcDataSetBindingSource
            // 
            this.dataBaseForSimpleCalcDataSetBindingSource.DataSource = this.dataBaseForSimpleCalcDataSet;
            this.dataBaseForSimpleCalcDataSetBindingSource.Position = 0;
            // 
            // notesTableAdapter
            // 
            this.notesTableAdapter.ClearBeforeFill = true;
            // 
            // txtHostName
            // 
            this.txtHostName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHostName.Location = new System.Drawing.Point(24, 288);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHostName.Properties.Appearance.Options.UseFont = true;
            this.txtHostName.Size = new System.Drawing.Size(392, 26);
            this.txtHostName.TabIndex = 11;
            // 
            // NoteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(445, 468);
            this.Controls.Add(this.cmbErrorCode);
            this.Controls.Add(this.txtHostName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.txtDateAndTime);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblExpression);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NoteEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ChoiceDataDialog";
            this.Load += new System.EventHandler(this.GeneralNotesEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtExpression.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateAndTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbErrorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseForSimpleCalcDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHostName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtExpression;
        private DevExpress.XtraEditors.TextEdit txtResult;
        private DevExpress.XtraEditors.LabelControl lblExpression;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.LabelControl lblDateAndTime;
        private DevExpress.XtraEditors.TextEdit txtDateAndTime;
        private DevExpress.XtraEditors.LabelControl lblHostName;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private System.Windows.Forms.BindingSource dataBaseForSimpleCalcDataSetBindingSource;
        private DataBaseForSimpleCalcDataSet dataBaseForSimpleCalcDataSet;
        private DevExpress.XtraEditors.ImageComboBoxEdit cmbErrorCode;
        private DataBaseForSimpleCalcDataSetTableAdapters.NotesTableAdapter notesTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtHostName;
    }
}