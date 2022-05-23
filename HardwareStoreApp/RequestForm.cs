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
    public partial class RequestForm : Form
    {
        public void LoadProductsList()
        {
            lwProducts.Items.Clear();
            //update product list with data from the database
            productsAndRequestManager.UpdateProductsList();
            foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
            {
                if (p.Inactive == 0)
                {
                    lwProducts.Items.Add(p.GetProducts());
                }
            }
            OutOfStock();
        }

        //make out of stock items orange
        public void OutOfStock()
        {   
           foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
           {
               if (p.Quantity == 0)
               {
                   for (int i = 0; i < lwProducts.Items.Count; i++)
                   {
                       if (lwProducts.Items[i].ToString().Contains(p.GetProducts()))
                       {
                           lwProducts.Items[i].ForeColor = Color.Orange;
                       }
                   }
               }
           }
        }

        ProductsAndRequestManager productsAndRequestManager = new ProductsAndRequestManager();
        public RequestForm()
        {
            InitializeComponent();
            LoadProductsList();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //send the request to the storage
        private void brnConfirmRequest_Click(object sender, EventArgs e)
        {
            int id, quantity;
            foreach (string p in lbRequested.Items)
            {
                int i = lbRequested.Items.IndexOf(p);
                id = Convert.ToInt32(lbRequested.Items[i].ToString().Remove(lbRequested.Items[i].ToString().IndexOf("-")));
                quantity = Convert.ToInt32(lbSold.Items[i]);
                productsAndRequestManager.CreateRequest(id, quantity);
            }
            lbRequested.Items.Clear();
            lbSold.Items.Clear();
            LoadProductsList();
        }
        //just realized i named a textbox sold and doesnt make sense, but this referes to the quantity of items requested
        private void btnAddProductRefill_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxQuantityRequest.Text))
            {
                foreach (ListViewItem items in lwProducts.SelectedItems)
                {
                    lbRequested.Items.Add(items.Text);
                    lbSold.Items.Add(tbxQuantityRequest.Value.ToString());
                }
            }
            
        }
        //keep lists synced
        private void SyncLists(object sender, EventArgs e)
        {
            if (lbSold.Items.Count > 0)
            {
                try
                {
                    lbSold.SelectedIndex = lbRequested.SelectedIndex;
                }
                catch (Exception)
                {
                    MessageBox.Show("All items have been removed.");
                }
            }
        }
        //search function
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (!string.IsNullOrEmpty(tbSearch.Text))
            {
                string search = tbSearch.Text;
                productsAndRequestManager.UpdateProductsList();
                lwProducts.Items.Clear();
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
                            lwProducts.Items.Add(p.GetProducts());
                        }
                    } 
                }
                OutOfStock();
            } else
            {
                LoadProductsList();
            }
        }
        //remove selected item from the list of requests
        private void btRemove_Click(object sender, EventArgs e)
        {
            if (lbRequested.SelectedItem != null)
            {
                lbSold.Items.Remove(lbSold.SelectedItem);
                lbRequested.Items.Remove(lbRequested.SelectedItem);
            }
        }

        private void btnAddProductRefill_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btnAddProductRefill, "Add selected products with the inputed amount to the request list.");
        }

        private void btRemove_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btRemove, "Remove products from the request list.");
        }

        private void brnConfirmRequest_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.brnConfirmRequest, "Send the stock request.");
        }
    }
}
