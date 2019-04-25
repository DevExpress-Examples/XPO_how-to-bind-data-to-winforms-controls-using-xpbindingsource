Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System
Imports System.Data
Imports System.IO
Imports System.Linq

Namespace DXApplication
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
			SetupLookupDataSources()
			DataSourceTypeComboBox.SelectedIndex = 0
		End Sub

        Private _dataLayer As IDataLayer
        Public ReadOnly Property DataLayer() As IDataLayer
			Get
                If _dataLayer Is Nothing Then
                    Dim dataStore As New InMemoryDataStore()
                    dataStore.ReadXml(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.xml"))
                    _dataLayer = New SimpleDataLayer(dataStore)
                    Return _dataLayer
                End If
                Return _dataLayer
            End Get
		End Property

        Private _unitOfWork As UnitOfWork
        Public ReadOnly Property UnitOfWork() As UnitOfWork
			Get
                If _unitOfWork Is Nothing Then
                    _unitOfWork = New UnitOfWork(DataLayer)
                    _unitOfWork.TrackPropertiesModifications = True
                End If
                Return _unitOfWork
            End Get
		End Property

		Private Sub SetupMainDataSource(ByVal dataSourceType As String)
			Dim oldDataSource As IDisposable = TryCast(ProductListSource.DataSource, IDisposable)
			If oldDataSource IsNot Nothing Then
				oldDataSource.Dispose()
			End If
			Select Case dataSourceType
				Case "XPCollection"
					ProductListSource.DataSource = New XPCollection(UnitOfWork, GetType(Products))
				Case "XPServerCollectionSource"
					Dim ds As New XPServerCollectionSource(UnitOfWork, GetType(Products))
					ds.AllowEdit = True
					ds.TrackChanges = True
					ProductListSource.DataSource = ds
				Case "List of Objects"
                    ProductListSource.DataSource = UnitOfWork.Query(Of Products)().ToList()
                    ProductListSource.ObjectClassInfo = UnitOfWork.GetClassInfo(Of Products)()
                Case "Single Object"
                    ProductListSource.DataSource = UnitOfWork.Query(Of Products)().First()
                    ProductListSource.ObjectClassInfo = UnitOfWork.GetClassInfo(Of Products)()
            End Select
		End Sub

		Private Sub SetupLookupDataSources()
            CategoryListSource.DataSource = UnitOfWork.Query(Of Categories)().OrderBy(Function(t) t.CategoryName).ToList()
            CategoryListSource.Dictionary = UnitOfWork.Dictionary
            SupplierListSource.DataSource = New XPCollection(Of Suppliers)(UnitOfWork, Nothing, New SortProperty("CompanyName", SortingDirection.Ascending))
		End Sub

		Public Sub ReCreateUnitOfWork()
            _unitOfWork.Dispose()
            _unitOfWork = Nothing
            SetupLookupDataSources()
			SetupMainDataSource(DataSourceTypeComboBox.EditValue.ToString())
		End Sub

		Private Sub DataSourceTypeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles DataSourceTypeComboBox.SelectedIndexChanged
			SetupMainDataSource(DataSourceTypeComboBox.EditValue.ToString())
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			ReCreateUnitOfWork()
		End Sub
	End Class
End Namespace
