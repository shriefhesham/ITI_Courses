using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DetailedView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection SqlCN;
        SqlCommand SqlCmdSelectAllProducts;
        SqlCommand SqlCmdSelectAllCategory;
        SqlDataAdapter SqlAdapter;
        SqlDataAdapter SqlAdapter2;
        DataTable DTCategories;
        DataTable DTProducts;
        BindingSource ProductBindingSource;
        BindingSource CategoryBindingSource;
        BindingNavigator Navigator;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();
            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
            "Integrated Security = true ; TrustServerCertificate=true";


            SqlCmdSelectAllProducts = new SqlCommand("SelectAllProducts", SqlCN);
            SqlCmdSelectAllProducts.CommandType = System.Data.CommandType.StoredProcedure;
            SqlAdapter = new SqlDataAdapter(SqlCmdSelectAllProducts);
            DTProducts= new DataTable();


            SqlCmdSelectAllCategory = new SqlCommand("Select CategoryID as CatID , CategoryName from Categories", SqlCN);
            SqlAdapter2 = new SqlDataAdapter(SqlCmdSelectAllCategory);
            DTCategories = new DataTable();





            ProductBindingSource = new BindingSource(DTProducts , "");
            //CategoryBindingSource = new BindingSource(DTCategories , "");

            Navigator = new BindingNavigator(ProductBindingSource);
            //Navigator = new BindingNavigator(CategoryBindingSource);
            Navigator.Dock = DockStyle.Top;
            this.Controls.Add(Navigator);
        }
        private void btnExcute_Click(object sender, EventArgs e)
        {
            SqlAdapter.Fill(DTProducts);
            SqlAdapter2.Fill(DTCategories);


          
                CategoryID.DataSource = ProductBindingSource;
                CategoryID.DisplayMember = "CategoryID";


                Categories.DataSource = DTCategories;
                Categories.DisplayMember = "CategoryName";
                Categories.ValueMember = "CatID";
                Categories.DataBindings.Add("SelectedValue" , ProductBindingSource , "CategoryID");
                
            


            //Categories.SelectedValue = CategoryID.ValueMember;


            //Categories.SelectedValue = "CategoryID"

            lblEmployeeID.DataBindings.Add("Text", ProductBindingSource, "ProductID");
            txtProductName.DataBindings.Add("Text", ProductBindingSource, "ProductName");
            txtQuntityPerUnit.DataBindings.Add("Text", ProductBindingSource, "QuantityPerUnit");
            txtDiscount.DataBindings.Add("Text", ProductBindingSource, "Discontinued");
            UDUnitsInStock.DataBindings.Add("Value", ProductBindingSource, "UnitsInStock");
            UDUnitsOnOrder.DataBindings.Add("Value", ProductBindingSource, "UnitsOnOrder");
            UDReorderLevel.DataBindings.Add("Value", ProductBindingSource, "ReorderLevel");
            UDUnitPrice.DataBindings.Add("Value", ProductBindingSource, "UnitPrice");

            SqlCommandBuilder builder = new SqlCommandBuilder(SqlAdapter);

            SqlAdapter.InsertCommand = builder.GetInsertCommand();
            SqlAdapter.UpdateCommand = builder.GetUpdateCommand();
            SqlAdapter.DeleteCommand = builder.GetDeleteCommand();
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            try 
            {
            this.Validate();
            this.ProductBindingSource.EndEdit();
            this.SqlAdapter.Update(this.DTProducts);
                MessageBox.Show("Save SuccesFully");

            }
            catch (Exception ex) 
            {
              MessageBox.Show("Invalid Operation");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow DR = DTProducts.NewRow();
            DR["ProductName"] = txtPnameAdd.Text;
            DR["QuantityPerUnit"] = txtQuantityAdd.Text;
            DR["UnitPrice"] = txtUnitPriceAdd.Text;
            DR["UnitsInStock"] = txtUnitStockAdd.Text;
            DR["UnitsOnOrder"] = txtUnitOrderAdd.Text;
            DR["ReorderLevel"] = txtRecoderlvlAdd.Text;
            DR["Discontinued"] = txtDiscountAdd.Text;
            DTProducts.Rows.Add(DR);
        }

    }
}