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
    public partial class AddRemoveStock : Form
    {
        public void UpdateList()
        {
            //update product list with data from the database
            productsAndRequestManager.UpdateProductsList();
            allStock.Items.Clear();
            //display products in the listbox
            foreach (Products p in (List<Products>)productsAndRequestManager.GetAllProducts())
            {
                allStock.Items.Add(p);
            }
        }

        private void updateDepartments()
        {
            cbDepartmentID.Items.Clear();

            foreach (Department department in (List<Department>)productsAndRequestManager.GetAllDepartments())
            {
                cbDepartmentID.Items.Add(department.ToString());
            }
        }
        //clears texts in boxes
        public void EmptyBoxes()
        {
            tbxBuyingprice.Text = null;
            tbxID.Text = null;
            tbxName.Text = null;
            tbxQuantity.Text = null;
            tbxSellingPrice.Text = null;
            richTbxDescription.Text = null;
            cbDepartmentID.Text = null;
            tbBarCode.Text = null;
            tbInactive.Text = null;
            tbInactive.BackColor = Color.Gray;
        }

        ProductsAndRequestManager productsAndRequestManager = new ProductsAndRequestManager();
        public AddRemoveStock()
        {
            InitializeComponent();
            UpdateList();
            updateDepartments();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm productsForm = new ProductsForm();
            productsForm.Show();
        }

        private void btAddStock_Click(object sender, EventArgs e)
        {
            
            string productName;
            int quantity;
            string productDescription;
            decimal buyingPrice;
            decimal sellingPrice;
            int depID;
            string code;

            productName = tbxName.Text;
            quantity = Convert.ToInt32(tbxQuantity.Text);
            productDescription = richTbxDescription.Text;
            buyingPrice = Convert.ToInt32(tbxBuyingprice.Text);
            sellingPrice = Convert.ToInt32(tbxSellingPrice.Text);
            depID = Convert.ToInt32(cbDepartmentID.Text.Remove(cbDepartmentID.Text.IndexOf(" ")));
            code = Convert.ToString(tbBarCode.Text); if (code.Length > 20)
            {
                MessageBox.Show("Barcode is too long, try scanning again or manually adding it!", "Barcode exceedes character limit!", MessageBoxButtons.OK);
            }
            else if (Int32.TryParse(code, out int nr))
            {
                MessageBox.Show("Barcode can only contain numbers, try scanning again or manually adding it!", "Barcode incorect!", MessageBoxButtons.OK);
            }
            else
            {
                productsAndRequestManager.CreateProduct(productName, quantity, productDescription, buyingPrice, sellingPrice, depID, code);
            }

            UpdateList();
            EmptyBoxes();
        }
        //make product inactive if stock is 0
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (allStock.SelectedItem != null)
            {
                Products p = (Products)allStock.SelectedItem;
                if(p.Quantity == 0)
                {
                    productsAndRequestManager.DeleteProduct(p);
                }
                UpdateList();

            }
            EmptyBoxes();
        }

        private void allStock_SelectedValueChanged(object sender, EventArgs e)
        {
            if (allStock.SelectedItem != null)
            {
                tbxName.Text = ((Products)allStock.SelectedItem).ProductName;
                tbxID.Text = Convert.ToString(((Products)allStock.SelectedItem).ProductID);
                richTbxDescription.Text = ((Products)allStock.SelectedItem).ProductDescription;
                tbxQuantity.Text = Convert.ToString(((Products)allStock.SelectedItem).Quantity);
                tbxSellingPrice.Text = Convert.ToString(((Products)allStock.SelectedItem).SellingPrice);
                tbxBuyingprice.Text = Convert.ToString(((Products)allStock.SelectedItem).BuyingPrice);
                //cbDepartmentID.Text = Convert.ToString(((Products)allStock.SelectedItem).DepID);
                tbBarCode.Text = Convert.ToString(((Products)allStock.SelectedItem).Code);
                
                foreach (Department department in (List<Department>)productsAndRequestManager.GetAllDepartments())
                {
                    if (((Products)allStock.SelectedItem).DepID == department.DepartmentID)
                    {
                        cbDepartmentID.Text = department.ToString();
                    }
                    if (((Products)allStock.SelectedItem).Inactive == 1)
                    {
                        tbInactive.Text = " Yes";
                        tbInactive.BackColor = Color.Red;
                    } else
                    {
                        tbInactive.Text = " No";
                        tbInactive.BackColor = Color.Green;
                    }
                }
            }
        }
        //search for name of product
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
                        allStock.Items.Add(p);
                    }

                }
                EmptyBoxes();
            }
        }

        private void btnMenu_MouseHover(object sender, EventArgs e)
        {

            ToolTip back = new ToolTip();
            back.SetToolTip(this.btnMenu, "Go back to the previous window.");
        }

        private void tbxQuantity_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.tbxQuantity, "When creating a product quantity will be 0, this can be updated manually or stock can be requested.");
        }

        private void btAdd_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btAdd, "Create the product with the specified values.");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.btnDelete, "Make this product unavailable if its quantity is 0.");
        }

        private void allStock_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(this.allStock, "List of all products (includes discontinued).");
        }
    }
}
