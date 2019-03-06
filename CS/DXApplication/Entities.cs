using System;
using System.Collections;
using System.Collections.Generic;
using DevExpress.Xpo;

namespace DXApplication
{
    [OptimisticLocking(false)]
    [NonPersistent]
    public abstract class BaseObject : PersistentBase {
        public BaseObject(Session session) : base(session) { }
        protected override void TriggerObjectChanged(ObjectChangeEventArgs args) {
            XPBaseObject.RaiseChangedEvent(this, args);
            if(IsInvalidated)
                return;
            base.TriggerObjectChanged(args);
        }
    }

	public class Suppliers : BaseObject {
        [Key]
        public int SupplierID;
        public string Address { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        [Association("Product_Supplier", typeof(Products))]
		public IList<Products> Products {
			get {
				return GetList<Products>(nameof(Products));
			}
		}
        public Suppliers(Session session)
            : base(session) {
        }
	}

	public class Categories : BaseObject {
		[Key]
		public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
        public Categories(Session session)
            : base(session) {
        }
	}

    public class Products : BaseObject {
        int fProductID;
        [Key(true)]
        public int ProductID
        {
            get { return fProductID; }
            set { SetPropertyValue<int>(nameof(ProductID), ref fProductID, value); }
        }
        string fProductName;
        [Size(40)]
        public string ProductName
        {
            get { return fProductName; }
            set { SetPropertyValue<string>(nameof(ProductName), ref fProductName, value); }
        }
        Suppliers fSupplierID;
        public Suppliers SupplierID
        {
            get { return fSupplierID; }
            set { SetPropertyValue<Suppliers>(nameof(SupplierID), ref fSupplierID, value); }
        }
        Categories fCategoryID;
        public Categories CategoryID
        {
            get { return fCategoryID; }
            set { SetPropertyValue<Categories>(nameof(CategoryID), ref fCategoryID, value); }
        }
        string fQuantityPerUnit;
        [Size(20)]
        public string QuantityPerUnit
        {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>(nameof(QuantityPerUnit), ref fQuantityPerUnit, value); }
        }
        decimal? fUnitPrice;
        public decimal? UnitPrice
        {
            get { return fUnitPrice; }
            set { SetPropertyValue<decimal?>(nameof(UnitPrice), ref fUnitPrice, value); }
        }
        short fUnitsInStock;
        public short UnitsInStock
        {
            get { return fUnitsInStock; }
            set { SetPropertyValue<short>(nameof(UnitsInStock), ref fUnitsInStock, value); }
        }
        short fUnitsOnOrder;
        public short UnitsOnOrder
        {
            get { return fUnitsOnOrder; }
            set { SetPropertyValue<short>(nameof(UnitsOnOrder), ref fUnitsOnOrder, value); }
        }
        short fReorderLevel;
        public short ReorderLevel
        {
            get { return fReorderLevel; }
            set { SetPropertyValue<short>(nameof(ReorderLevel), ref fReorderLevel, value); }
        }
        bool fDiscontinued;
        public bool Discontinued
        {
            get { return fDiscontinued; }
            set { SetPropertyValue<bool>(nameof(Discontinued), ref fDiscontinued, value); }
        }
        public Products(Session session) : base(session) { }
    }
}
