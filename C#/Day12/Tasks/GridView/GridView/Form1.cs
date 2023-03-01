using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace GridView
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
        DataTable DTProducts;
        DataTable DTCategories;
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCN = new SqlConnection();
            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=Northwind; " +
            "Integrated Security = true ; TrustServerCertificate=true";

            SqlCmdSelectAllProducts = new SqlCommand("Select * from products", SqlCN);
            SqlAdapter = new SqlDataAdapter(SqlCmdSelectAllProducts);

            SqlCmdSelectAllCategory = new SqlCommand("Select CategoryID as CatID , CategoryName from Categories", SqlCN);
            SqlAdapter2 = new SqlDataAdapter(SqlCmdSelectAllCategory);


            DTProducts = new DataTable();
            DTCategories = new DataTable();

            SqlAdapter.Fill(DTProducts); 
            SqlAdapter2.Fill(DTCategories);


            GridViewProducts.DataSource = DTProducts;

            DataGridViewComboBoxColumn DC = new();
            DC.DataSource = DTCategories;
            DC.HeaderText = "Categories";
            DC.DisplayMember = "CategoryName";
            DC.ValueMember = "CatID";
            DC.DataPropertyName = "CategoryID";

            GridViewProducts.Columns.Add(DC);

            SqlCommandBuilder builder = new SqlCommandBuilder(SqlAdapter);
            SqlAdapter.InsertCommand = builder.GetInsertCommand();
            SqlAdapter.UpdateCommand = builder.GetUpdateCommand();
            SqlAdapter.DeleteCommand = builder.GetDeleteCommand();
            GridViewProducts.Columns[0].ReadOnly = true;
            GridViewProducts.Columns[2].ReadOnly = true;
            GridViewProducts.Columns[3].Visible = false;
            //GridViewProducts.Columns[2].ReadOnly = true;
            //GridViewProducts.Columns[3].ReadOnly = true;


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //call Insert Update insert Delete Command
            //Commit Changes from DataTable Into DataBase
            try 
            {
              SqlAdapter.Update(DTProducts);
                MessageBox.Show("Save Succuesfully ");


            }
            catch (Exception ex) 
            {
                MessageBox.Show("InValid Operation");
            }
        }

    }
}