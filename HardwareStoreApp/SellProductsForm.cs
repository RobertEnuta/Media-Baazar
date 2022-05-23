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
    public partial class SellProductsForm : Form
    {

        ProductsAndRequestManager productsAndRequestManager = new ProductsAndRequestManager();
        List<int> SoldItems = new List<int>();


        public void UpdateList()
        {
            //update product list with data from the database
            productsAndRequestManager.UpdateProductsList();
            allStock.Items.Clear();
            //display products in the listbox
            foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
            {
                if (p.Inactive == 0)
                {
                    allStock.Items.Add(p);
                }
            }
        }

        //public void FillComboBoxNames()
        //{
        //    cbStockCategory.Items.Clear();
        //    foreach (Department d in this.productsAndRequestManager.GetAllDepartments())
        //    {
        //        cbStockCategory.Items.Add(d);
        //    }
        //}

        public SellProductsForm()
        {
            InitializeComponent();
            UpdateList();
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
            if (tbStockSearch.Text != null)
            {
                string search = tbStockSearch.Text;
                productsAndRequestManager.UpdateProductsList();
                allStock.Items.Clear();
                //display searched products
                foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
                {
                    string upperName = p.ProductName.ToUpper();
                    search = search.ToUpper();
                    string barcode = p.Code;
                    if ((upperName.Contains(search)) || (barcode.Contains(search)))
                    {
                        if (p.Inactive == 0)
                        {
                            allStock.Items.Add(p);
                        }
                    }


                }
            }
        }
        //show the update form
        private void btUpdate_Click(object sender, EventArgs e)
        {
            ProductUpdate pu = new ProductUpdate();
            pu.Show();
            this.Hide();
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

        private void lbItemsSelling_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.lbItemsSelling, "List of items that have been added to transaction.");
        }

        private void allStock_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.allStock, "List of all available products.");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            int selling = Convert.ToInt32(nmSell.Value);
            if (allStock.SelectedItem != null)
            {
                lbItemsSelling.Items.Add(allStock.SelectedItem);
                lbSold.Items.Add(selling.ToString());
            }
            allStock.SelectedItem = null;
            nmSell.Value = 1;
        }
        //keep listboxes sinked
        private void SyncSelected(object sender, EventArgs e)
        {
            if (lbSold.Items.Count > 0)
            {
                try
                {
                    lbSold.SelectedIndex = lbItemsSelling.SelectedIndex;
                }
                catch (Exception)
                {
                    MessageBox.Show("All items have been removed.");
                }
            }
            
        }
        //finish transaction
        private void btSell_Click(object sender, EventArgs e)
        {
            foreach (Products prod in lbItemsSelling.Items)
            {
                int quantity = Convert.ToInt32(lbSold.Items[lbItemsSelling.Items.IndexOf(prod)]);
                productsAndRequestManager.SellProduct(prod.ProductID, quantity);
            }

            lbItemsSelling.Items.Clear();
            lbSold.Items.Clear();
            UpdateList();
        }

        private void btAdd_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btAdd, "Add item with selected amount to transaction.");
        }

        private void btSell_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btSell, "If there are not enough products available, all stock will be sold!");
        }

        private void lbSold_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.lbSold, "Quantity of each item.");
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbItemsSelling.SelectedItem != null)
            {
                lbSold.Items.Remove(lbSold.SelectedItem);
                lbItemsSelling.Items.Remove(lbItemsSelling.SelectedItem);
            }
        }

        private void btRemove_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btRemove, "Remove selected item.");
        }
    }
}
