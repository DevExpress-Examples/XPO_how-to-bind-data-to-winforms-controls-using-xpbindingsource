using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System;
using System.Data;
using System.IO;
using System.Linq;

namespace DXApplication
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            SetupLookupDataSources();
            DataSourceTypeComboBox.SelectedIndex = 0;
        }

        IDataLayer dataLayer;
        public IDataLayer DataLayer
        {
            get
            {
                if (dataLayer == null)
                {
                    InMemoryDataStore dataStore = new InMemoryDataStore();
                    dataStore.ReadXml(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.xml"));
                    dataLayer = new SimpleDataLayer(dataStore);
                    return dataLayer;
                }
                return dataLayer;
            }
        }

        UnitOfWork unitOfWork;
        public UnitOfWork UnitOfWork
        {
            get
            {
                if (unitOfWork == null)
                {
                    unitOfWork = new UnitOfWork(DataLayer);
                    unitOfWork.TrackPropertiesModifications = true;
                }
                return unitOfWork;
            }
        }

        void SetupMainDataSource(string dataSourceType)
        {
            IDisposable oldDataSource = ProductListSource.DataSource as IDisposable;
            if (oldDataSource != null)
            {
                oldDataSource.Dispose();
            }
            switch (dataSourceType)
            {
                case "XPCollection":
                    ProductListSource.DataSource = new XPCollection(UnitOfWork, typeof(Products));
                    break;
                case "List of Objects":
                    ProductListSource.DataSource = UnitOfWork.Query<Products>().ToList();
                    ProductListSource.ObjectClassInfo = UnitOfWork.GetClassInfo<Products>();
                    break;
                case "Single Object":
                    ProductListSource.DataSource = UnitOfWork.Query<Products>().First();
                    ProductListSource.ObjectClassInfo = UnitOfWork.GetClassInfo<Products>();
                    break;
            }
        }

        void SetupLookupDataSources()
        {
            CategoryListSource.DataSource = UnitOfWork.Query<Categories>().OrderBy(t => t.CategoryName).ToList();
            CategoryListSource.Dictionary = UnitOfWork.Dictionary;
            SupplierListSource.DataSource = new XPCollection<Suppliers>(UnitOfWork, null, new SortProperty("CompanyName", SortingDirection.Ascending));
        }

        public void ReCreateUnitOfWork()
        {
            unitOfWork.Dispose();
            unitOfWork = null;
            SetupLookupDataSources();
            SetupMainDataSource(DataSourceTypeComboBox.EditValue.ToString());
        }

        private void DataSourceTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupMainDataSource(DataSourceTypeComboBox.EditValue.ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ReCreateUnitOfWork();
        }
    }
}
