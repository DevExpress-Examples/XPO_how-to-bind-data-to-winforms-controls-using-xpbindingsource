Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports DevExpress.Xpo

Namespace DXApplication
	<OptimisticLocking(False), NonPersistent>
	Public MustInherit Class BaseObject
		Inherits PersistentBase

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Protected Overrides Sub TriggerObjectChanged(ByVal args As ObjectChangeEventArgs)
			XPBaseObject.RaiseChangedEvent(Me, args)
			If IsInvalidated Then
				Return
			End If
			MyBase.TriggerObjectChanged(args)
		End Sub
	End Class

	Public Class Suppliers
		Inherits BaseObject

		<Key>
		Public SupplierID As Integer
		Public Property Address() As String
		Public Property City() As String
		Public Property CompanyName() As String
		Public Property ContactName() As String
		Public Property ContactTitle() As String
		Public Property Country() As String
		Public Property Fax() As String
		Public Property HomePage() As String
		Public Property Phone() As String
		Public Property PostalCode() As String
		Public Property Region() As String
		<Association("Product_Supplier", GetType(Products))>
		Public ReadOnly Property Products() As IList(Of Products)
			Get
				Return GetList(Of Products)(NameOf(Products))
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	Public Class Categories
		Inherits BaseObject

		<Key>
		Public Property CategoryID() As Integer
		Public Property CategoryName() As String
		Public Property Description() As String
		Public Property Picture() As Byte()
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class

	Public Class Products
		Inherits BaseObject

		Private fProductID As Integer
		<Key(True)>
		Public Property ProductID() As Integer
			Get
				Return fProductID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)(NameOf(ProductID), fProductID, value)
			End Set
		End Property
		Private fProductName As String
		<Size(40)>
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)(NameOf(ProductName), fProductName, value)
			End Set
		End Property
		Private fSupplierID As Suppliers
		Public Property SupplierID() As Suppliers
			Get
				Return fSupplierID
			End Get
			Set(ByVal value As Suppliers)
				SetPropertyValue(Of Suppliers)(NameOf(SupplierID), fSupplierID, value)
			End Set
		End Property
		Private fCategoryID As Categories
		Public Property CategoryID() As Categories
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Categories)
				SetPropertyValue(Of Categories)(NameOf(CategoryID), fCategoryID, value)
			End Set
		End Property
		Private fQuantityPerUnit As String
		<Size(20)>
		Public Property QuantityPerUnit() As String
			Get
				Return fQuantityPerUnit
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)(NameOf(QuantityPerUnit), fQuantityPerUnit, value)
			End Set
		End Property
		Private fUnitPrice? As Decimal
		Public Property UnitPrice() As Decimal?
			Get
				Return fUnitPrice
			End Get
			Set(ByVal value? As Decimal)
				SetPropertyValue(Of Decimal?)(NameOf(UnitPrice), fUnitPrice, value)
			End Set
		End Property
		Private fUnitsInStock As Short
		Public Property UnitsInStock() As Short
			Get
				Return fUnitsInStock
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)(NameOf(UnitsInStock), fUnitsInStock, value)
			End Set
		End Property
		Private fUnitsOnOrder As Short
		Public Property UnitsOnOrder() As Short
			Get
				Return fUnitsOnOrder
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)(NameOf(UnitsOnOrder), fUnitsOnOrder, value)
			End Set
		End Property
		Private fReorderLevel As Short
		Public Property ReorderLevel() As Short
			Get
				Return fReorderLevel
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)(NameOf(ReorderLevel), fReorderLevel, value)
			End Set
		End Property
		Private fDiscontinued As Boolean
		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)(NameOf(Discontinued), fDiscontinued, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
	End Class
End Namespace
