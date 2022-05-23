using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
    public class Products
    {
        private List<int> requestIds = new List<int>();
        //private DateTime deliveringDate;
        private int productID;
        private string productName;
        private int quantity;
        private string productDescription;
        private decimal buyingPrice;
        private decimal sellingPrice;
        private int depId;
        private int inactive;
        private int sold;
        private string code;
        public Products(int productID, string productName, int quantity, string productDescription, decimal buyingPrice, decimal sellingPrice, int depID, int inactive, int sold, string code)
        {
            this.productName = productName;
            this.quantity = quantity;
            this.productID = productID;
            //this.deliveringDate = deliveringDate;
            this.productDescription = productDescription;
            this.buyingPrice = buyingPrice;
            this.sellingPrice = sellingPrice;
            this.depId = depID;
            this.inactive = inactive;
            this.sold = sold;
            this.code = code;
        }
        public Products()
        {

        }

        //public DateTime DeliveringDate { get { return deliveringDate; } }
        public int ProductID { get { return productID; } }
        public string ProductName { get { return productName; } }
        public int Quantity { get { return quantity; } }
        public string ProductDescription { get{ return productDescription; } }
        public decimal BuyingPrice { get{ return buyingPrice; } }
        public decimal SellingPrice { get{ return sellingPrice; } }
        public int DepID { get { return depId; } }
        public int Sold { get { return sold; } }
        public string Code { get { return code; } }
        public int Inactive { get { return inactive; } }

        public string GetProducts()
        {
            return $"{this.productID} - {this.productName} ({this.code}) x {this.quantity}, SP:{this.sellingPrice}, BP:{this.buyingPrice}, Sold:{this.sold}";
        }
        public string GetInfo()
        {
            return $"{this.productID}-{this.productName} x {this.quantity} {this.code}";
        }

        public override string ToString()
        {
            return $"{this.productID}-{this.productName} x {this.quantity}";
        }
    }
}
