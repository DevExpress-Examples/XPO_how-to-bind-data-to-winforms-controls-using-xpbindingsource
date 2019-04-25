﻿Namespace DXApplication
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.DataSourceTypeComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.ProductListSource = New DevExpress.Xpo.XPBindingSource(Me.components)
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colSupplierName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			Me.lookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
			Me.SupplierListSource = New DevExpress.Xpo.XPBindingSource(Me.components)
			Me.lookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
			Me.CategoryListSource = New DevExpress.Xpo.XPBindingSource(Me.components)
			Me.spinEdit1 = New DevExpress.XtraEditors.SpinEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.DataSourceTypeComboBox.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ProductListSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.SupplierListSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.CategoryListSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 11)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(63, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Data Source:"
			' 
			' DataSourceTypeComboBox
			' 
			Me.DataSourceTypeComboBox.Location = New System.Drawing.Point(81, 8)
			Me.DataSourceTypeComboBox.Name = "DataSourceTypeComboBox"
			Me.DataSourceTypeComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.DataSourceTypeComboBox.Properties.Items.AddRange(New Object() { "XPCollection", "XPServerCollectionSource", "List of Objects", "Single Object"})
			Me.DataSourceTypeComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.DataSourceTypeComboBox.Size = New System.Drawing.Size(208, 20)
			Me.DataSourceTypeComboBox.TabIndex = 2
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.DataSourceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.DataSourceTypeComboBox_SelectedIndexChanged);
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.ProductListSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 35)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(644, 412)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' ProductListSource
			' 
			Me.ProductListSource.DisplayableProperties = "ProductID;ProductName;SupplierID!Key;SupplierID;CategoryID!Key;CategoryID;UnitPri" & "ce;Discontinued;CategoryID.CategoryName;SupplierID.CompanyName"
			Me.ProductListSource.ObjectType = GetType(DXApplication.Products)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductID, Me.colProductName, Me.colUnitPrice, Me.colSupplierName, Me.colCategoryName, Me.colDiscontinued})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colProductID
			' 
			Me.colProductID.FieldName = "ProductID"
			Me.colProductID.Name = "colProductID"
			Me.colProductID.OptionsColumn.ReadOnly = True
			Me.colProductID.Visible = True
			Me.colProductID.VisibleIndex = 0
			' 
			' colProductName
			' 
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 1
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 2
			' 
			' colSupplierName
			' 
			Me.colSupplierName.FieldName = "SupplierID.CompanyName"
			Me.colSupplierName.Name = "colSupplierName"
			Me.colSupplierName.Visible = True
			Me.colSupplierName.VisibleIndex = 3
			' 
			' colCategoryName
			' 
			Me.colCategoryName.FieldName = "CategoryID.CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 4
			' 
			' colDiscontinued
			' 
			Me.colDiscontinued.FieldName = "Discontinued"
			Me.colDiscontinued.Name = "colDiscontinued"
			Me.colDiscontinued.Visible = True
			Me.colDiscontinued.VisibleIndex = 5
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.simpleButton1)
			Me.panelControl1.Controls.Add(Me.DataSourceTypeComboBox)
			Me.panelControl1.Controls.Add(Me.labelControl1)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panelControl1.Location = New System.Drawing.Point(0, 0)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(844, 35)
			Me.panelControl1.TabIndex = 4
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(295, 5)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(142, 23)
			Me.simpleButton1.TabIndex = 3
			Me.simpleButton1.Text = "Re-create UnitOfWork"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.checkEdit1)
			Me.panelControl2.Controls.Add(Me.lookUpEdit2)
			Me.panelControl2.Controls.Add(Me.lookUpEdit1)
			Me.panelControl2.Controls.Add(Me.spinEdit1)
			Me.panelControl2.Controls.Add(Me.textEdit1)
			Me.panelControl2.Controls.Add(Me.labelControl5)
			Me.panelControl2.Controls.Add(Me.labelControl4)
			Me.panelControl2.Controls.Add(Me.labelControl3)
			Me.panelControl2.Controls.Add(Me.labelControl2)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelControl2.Location = New System.Drawing.Point(644, 35)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(200, 412)
			Me.panelControl2.TabIndex = 5
			' 
			' checkEdit1
			' 
			Me.checkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductListSource, "Discontinued", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.checkEdit1.Location = New System.Drawing.Point(9, 186)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Discontinued"
			Me.checkEdit1.Size = New System.Drawing.Size(182, 19)
			Me.checkEdit1.TabIndex = 8
			' 
			' lookUpEdit2
			' 
			Me.lookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductListSource, "SupplierID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.lookUpEdit2.Location = New System.Drawing.Point(9, 160)
			Me.lookUpEdit2.Name = "lookUpEdit2"
			Me.lookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit2.Properties.DataSource = Me.SupplierListSource
			Me.lookUpEdit2.Properties.DisplayMember = "CompanyName"
			Me.lookUpEdit2.Size = New System.Drawing.Size(182, 20)
			Me.lookUpEdit2.TabIndex = 7
			' 
			' SupplierListSource
			' 
			Me.SupplierListSource.DisplayableProperties = "This;SupplierID;CompanyName;Address"
			Me.SupplierListSource.ObjectType = GetType(DXApplication.Suppliers)
			' 
			' lookUpEdit1
			' 
			Me.lookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductListSource, "CategoryID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.lookUpEdit1.Location = New System.Drawing.Point(9, 115)
			Me.lookUpEdit1.Name = "lookUpEdit1"
			Me.lookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.lookUpEdit1.Properties.DataSource = Me.CategoryListSource
			Me.lookUpEdit1.Properties.DisplayMember = "CategoryName"
			Me.lookUpEdit1.Size = New System.Drawing.Size(182, 20)
			Me.lookUpEdit1.TabIndex = 6
			' 
			' CategoryListSource
			' 
			Me.CategoryListSource.DisplayableProperties = "This;CategoryID;CategoryName"
			Me.CategoryListSource.ObjectType = GetType(DXApplication.Categories)
			' 
			' spinEdit1
			' 
			Me.spinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductListSource, "UnitPrice", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.spinEdit1.EditValue = New Decimal(New Integer() { 0, 0, 0, 0})
			Me.spinEdit1.Location = New System.Drawing.Point(9, 70)
			Me.spinEdit1.Name = "spinEdit1"
			Me.spinEdit1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True
			Me.spinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.spinEdit1.Size = New System.Drawing.Size(182, 20)
			Me.spinEdit1.TabIndex = 5
			' 
			' textEdit1
			' 
			Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ProductListSource, "ProductName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
			Me.textEdit1.Location = New System.Drawing.Point(9, 25)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(182, 20)
			Me.textEdit1.TabIndex = 4
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(9, 141)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(42, 13)
			Me.labelControl5.TabIndex = 3
			Me.labelControl5.Text = "Supplier:"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(9, 96)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(49, 13)
			Me.labelControl4.TabIndex = 2
			Me.labelControl4.Text = "Category:"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(9, 51)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(49, 13)
			Me.labelControl3.TabIndex = 1
			Me.labelControl3.Text = "Unit Price:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(9, 6)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(71, 13)
			Me.labelControl2.TabIndex = 0
			Me.labelControl2.Text = "Product Name:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(844, 447)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.DataSourceTypeComboBox.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ProductListSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.panelControl2.PerformLayout()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.SupplierListSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.CategoryListSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private WithEvents DataSourceTypeComboBox As DevExpress.XtraEditors.ComboBoxEdit
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private ProductListSource As DevExpress.Xpo.XPBindingSource
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private colProductID As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colSupplierName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
		Private CategoryListSource As DevExpress.Xpo.XPBindingSource
		Private SupplierListSource As DevExpress.Xpo.XPBindingSource
		Private lookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
		Private lookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
		Private spinEdit1 As DevExpress.XtraEditors.SpinEdit
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private checkEdit1 As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace

