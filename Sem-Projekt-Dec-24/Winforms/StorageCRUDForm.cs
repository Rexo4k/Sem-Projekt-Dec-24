﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sem_Projekt_Dec_24.Data;
using Sem_Projekt_Dec_24.Tables;
using Sem_Projekt_Dec_24.Winforms;

namespace Sem_Projekt_Dec_24.Winforms
{
    public partial class StorageCRUDForm : Form
    {
        private readonly string _connectionString;

        private readonly DatabaseManager _dbManager;
        public BindingList<Products> ProductList { get; set; } = new BindingList<Products>();
        public BindingList<Items> ItemList { get; set; } = new BindingList<Items>();

        // Connect and Load List
        public StorageCRUDForm()
        {
            InitializeComponent();
            string connectionString = "Server=mssql2.unoeuro.com;Database=ferrariconnie_dk_db_semprojectdb;User Id=ferrariconnie_dk;Password=bkngcw5BmR6DEx2ep4a3;";
            _dbManager = new DatabaseManager(connectionString);

            LoadProducts();
            dgvStorageProducts.DataSource = ProductList;

            LoadItems();
            dgvStorageItems.DataSource = ItemList;
        }
        // Loading Products Method
        private void LoadProducts()
        {
            List<Products> productsFromDB = _dbManager.GetProducts();
            foreach (var product in productsFromDB)
            {
                ProductList.Add(product);
            }
        }
        // Loading Items Method
        private void LoadItems()
        {
            List<Items> itemsFromDB = _dbManager.GetItems();
            foreach (var item in itemsFromDB)
            {
                ItemList.Add(item);
            }
        }
        // Go Back Button
        private void btnStorageGoBack_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.StartPosition = FormStartPosition.CenterScreen;
            employeeForm.Show();
            this.Hide();
        }
        // Clear Fields
        private void ClearInputFields()
        {
            txtbStorageItemsId.Clear();
            txtbStorageItemsName.Clear();
            txtbStorageItemsCategory.Clear();
        }

        // Create Item

        private void btnStorageItemsCreate_Click(object sender, EventArgs e)
        {

            string txtbStorageItemsIdString = txtbStorageItemsId.Text;
            string txtbStorageItemsNameString = txtbStorageItemsName.Text;
            string txtbStorageItemsCategoryString = txtbStorageItemsCategory.Text;

            int txtbStorageItemsIdInt;


            if (!int.TryParse(txtbStorageItemsIdString, out txtbStorageItemsIdInt))
            {
                MessageBox.Show("Please enter a valid ID.");
                return;
            }


            var existingItem = ItemList.FirstOrDefault(i => i.ItemId == txtbStorageItemsIdInt);

            if (existingItem != null)
            {
                MessageBox.Show("Item with this ID already exists.");
                ClearInputFields();
                return;
            }


            txtbStorageItemsIdInt = ItemList.Count > 0 ? ItemList.Max(c => c.ItemId) + 1 : 1;


            Items newItems = new Items(txtbStorageItemsIdInt, txtbStorageItemsNameString, txtbStorageItemsCategoryString, 0);


            ItemList.Add(newItems);


            try
            {
                _dbManager.AddItemsToStorage(newItems); 
                MessageBox.Show("Item added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the item: {ex.Message}");
            }

            ClearInputFields();
        }



        // Update Item
        private void btnStorageItemsUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query =
                   "SELECT ItemStock FROM Items" +
                   "WHERE ItemId = @ItemId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int txtbStorageItemsIdInt = Convert.ToInt32(txtbStorageItemsId.Text);
                    string txtbStorageItemsNameString = txtbStorageItemsName.Text;
                    string txtbStorageItemsCategoryString = txtbStorageItemsCategory.Text;
                    int itemStock = Convert.ToInt32(reader["ItemStock"]);

                    _dbManager.UpdateItemsInStorage(txtbStorageItemsIdInt, txtbStorageItemsNameString, txtbStorageItemsCategoryString, itemStock);

                }
                reader.Close();
                dgvStorageItems.DataSource = null;
                dgvStorageItems.DataSource = ItemList;
            }
        }

        // Delete Item

        private void btnStorageItemsDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query =
                   "SELECT ItemStock FROM Items" +
                   "WHERE ItemId = @ItemId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int txtbStorageItemsIdInt = Convert.ToInt32(txtbStorageItemsId.Text);
                string txtbStorageItemsNameString = txtbStorageItemsName.Text;
                string txtbStorageItemsCategoryString = txtbStorageItemsCategory.Text;
                int itemStock = Convert.ToInt32(reader["ItemStock"]);

                Items deletedItem = new Items(txtbStorageItemsIdInt, txtbStorageItemsNameString, txtbStorageItemsCategoryString, itemStock);

                _dbManager.DeleteItemsInStorage(deletedItem);
                }
                reader.Close();
                dgvStorageItems.DataSource = null;
                dgvStorageItems.DataSource = ItemList;
            }
        }

        //Create Product
        private void btnStorageProductCreate_Click(object sender, EventArgs e)
        {
            string txtbStorageProductsIdString = txtbStorageProductsId.Text;
            string txtbStorageProductsNameString = txtbStorageProductsName.Text;
            string txtbStorageProductsCategoryString = txtbStorageProductsCategory.Text;

            int txtbStorageProductIdInt = Convert.ToInt32(txtbStorageProductsIdString);
            for (int i = 0; i < ProductList.Count; i++)
            {
                if (ProductList[i].ProductId == txtbStorageProductIdInt)
                {
                    txtbStorageProductIdInt = ProductList[i].ProductId;
                    ClearInputFields();
                    return;


                }
                else
                {
                    txtbStorageProductIdInt = ProductList.Count > 0 ? ProductList.Max(c => c.ProductId) + 1 : 1;

                    Products newProducts = new Products(txtbStorageProductIdInt, txtbStorageProductsNameString, txtbStorageProductsCategoryString, 0);

                    ProductList.Add(newProducts);
                    _dbManager.AddProductToStorage(newProducts);

                    ClearInputFields();
                    dgvStorageProducts.DataSource = null;
                    dgvStorageProducts.DataSource = ItemList;
                    return;
                }
            }

        }

        // Update Product
        private void btnStorageProductsUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query =
                   "SELECT ProductStock FROM Products" +
                   "WHERE ProductId = @ItemId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int txtbStorageProductsIdInt = Convert.ToInt32(txtbStorageItemsId.Text);
                    string txtbStorageProductsNameString = txtbStorageItemsName.Text;
                    string txtbStorageProductsCategoryString = txtbStorageItemsCategory.Text;
                    int productStock = Convert.ToInt32(reader["ProductStock"]);

                    _dbManager.UpdateItemsInStorage(txtbStorageProductsIdInt, txtbStorageProductsNameString, txtbStorageProductsCategoryString, productStock);

                }
                reader.Close();
                dgvStorageProducts.DataSource = null;
                dgvStorageProducts.DataSource = ItemList;
            }
        }
        // Delete Product
        private void btnStorageProductsDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query =
                   "SELECT ProductStock FROM Products" +
                   "WHERE ProductId = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int txtbStorageProductIdInt = Convert.ToInt32(txtbStorageProductsId.Text);
                    string txtbStorageProductsNameString = txtbStorageProductsName.Text;
                    string txtbStorageProductsCategoryString = txtbStorageProductsCategory.Text;
                    int productStock = Convert.ToInt32(reader["ProductStock"]);

                    Products deletedProduct = new Products(txtbStorageProductIdInt, txtbStorageProductsNameString, txtbStorageProductsCategoryString, productStock);

                    _dbManager.DeleteProductsInStorage(deletedProduct);
                }
                reader.Close();
                dgvStorageProducts.DataSource = null;
                dgvStorageProducts.DataSource = ItemList;
            }
        }


     


    }

}