using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareStoreApp
{
    public partial class ProductsForm : Form
    {

        ProductsAndRequestManager productsAndRequestManager = new ProductsAndRequestManager();

        public void UpdateList()
        {
            //update product list with data from the database
            productsAndRequestManager.UpdateProductsList();
            lwAllProducts.Items.Clear();
            //display products in the listbox
            foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
            {
                //allStock.Items.Add(p.GetProducts());
                lwAllProducts.Items.Add(p.GetProducts());
            }
            Inactive();
        }

        public void FillComboBoxNames()
        {
            cbStockCategory.Items.Clear();
            foreach (Department d in this.productsAndRequestManager.GetAllDepartments())
            {
                cbStockCategory.Items.Add(d);
            }
        }
        //make out of stock items orange
        public void OutOfStock(Products p)
        {
            if (p.Quantity == 0)
            {
                for (int i = 0; i < lwAllProducts.Items.Count; i++)
                {
                    if (lwAllProducts.Items[i].ToString().Contains(p.GetProducts()))
                    {
                        lwAllProducts.Items[i].ForeColor = Color.Orange;
                    }
                }
            }
        }
        //makes inactive items red
        public void Inactive()
        {
            foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
            {
                OutOfStock(p);
                if (p.Inactive == 1) 
                {
                    for (int i = 0; i < lwAllProducts.Items.Count; i++)
                    {
                        if (lwAllProducts.Items[i].ToString().Contains(p.GetProducts()))
                        {
                            lwAllProducts.Items[i].ForeColor = Color.Red;
                        }
                    }
                }
                
            }
        }

        public void Search()
        {
            string search = tbStockSearch.Text;
            int category = 0;
            search = search.ToUpper();
            if (cbStockCategory.Text != "")
            {
                 category = Convert.ToInt32(cbStockCategory.Text.Remove(cbStockCategory.Text.IndexOf(" ")));
            }
            lwAllProducts.Items.Clear();
            //display searched products
            foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
            {
                string upperName = p.ProductName.ToUpper();
                string barcode = p.Code;
                //sort lists depending on category, name and barcode
                if (category == 0 && search == "")
                {
                    lwAllProducts.Items.Add(p.GetProducts());
                } else
                {
                    if (search == "")
                    {
                      if (p.DepID == category)
                        {
                            lwAllProducts.Items.Add(p.GetProducts());
                        }
                    } else if (category != 0)
                    {
                        if (((upperName.Contains(search)) || (barcode.Contains(search))) && (p.DepID == category))
                        {
                            lwAllProducts.Items.Add(p.GetProducts());
                        }
                    } else
                    {
                        if (((upperName.Contains(search)) || (barcode.Contains(search))))
                        {
                            lwAllProducts.Items.Add(p.GetProducts());
                        }
                    }
                }                
            }
            Inactive();
        }

        public ProductsForm()
        {
            InitializeComponent();
            FillComboBoxNames();
            UpdateList();
            Inactive();
        }


        private void btAddRemove_Click(object sender, EventArgs e)
        {
            AddRemoveStock addRemoveStock = new AddRemoveStock();
            addRemoveStock.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void tbStockSearch_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }
        //show the update form
        private void btUpdate_Click(object sender, EventArgs e)
        {
            ProductUpdate pu = new ProductUpdate();
            pu.Show();
            this.Hide();
        }

        private void btAddRemove_MouseHover(object sender, EventArgs e)
        {
            ToolTip add = new ToolTip();
            add.SetToolTip(this.btAddRemove, "Open the window for creating and deleting products from storage.");
        }

        private void btUpdate_MouseHover(object sender, EventArgs e)
        {
            ToolTip up = new ToolTip();
            up.SetToolTip(this.btUpdate, "Open the window for updating products information.");

        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {

            ToolTip back = new ToolTip();
            back.SetToolTip(this.btnMenu, "Go back to the previous window.");
        }

        private void tbStockSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.tbStockSearch, "Search products by name or barcode.");
        }

        private void cbStockCategory_SelectedValueChanged(object sender, EventArgs e)
        {
           Search();
        }

        private void btnShowAll_Click_1(object sender, EventArgs e)
        {
            cbStockCategory.Text = "";
            tbStockSearch.Clear();
            UpdateList();
        }

        private void lwAllProducts_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.lwAllProducts, "List of all products (discontinued items are red, items with 0 stock are orange).");
        }

        private void btHideUnavailable_Click(object sender, EventArgs e)
        {
            lwAllProducts.Items.Clear();
            foreach (Products p in productsAndRequestManager.GetAllProducts())
            {
                if (p.Inactive == 0)
                {
                    lwAllProducts.Items.Add(p.GetProducts());
                }
                OutOfStock(p);
            }
        }
    }
}
