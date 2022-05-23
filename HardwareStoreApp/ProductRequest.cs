using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreApp
{
   public class ProductRequest
    {
        private int productID;
        private int requestID;
        private int  quantity;
        private List<Products> product;
        private DateTime demandedDate;

        public ProductRequest(int requestID,DateTime demandedDate,int quantity,int productID)
        {
            this.demandedDate = demandedDate;
            this.requestID = requestID;
            this.quantity = quantity;
            this.productID = productID;
        }

        public long RequestID { get{ return this.requestID; } }
        public int Quantity { get { return this.quantity; } }
        public  DateTime DemandedDate { get{ return this.demandedDate; } }
        public List<Products> Product { get{ return this.product; } }

        public int ProductID {get { return this.productID; } }

       public void AddProducttoRequest(List<Products> product)
        {
            this.product = product;
        }
        public string GetProductRequest()
        { 
            string getProducts = string.Empty;
            foreach (Products products in this.product)
            {
                getProducts += products.ToString();
            }
            getProducts = getProducts.Trim(',', ' ');
            return getProducts;
        }
    }
}
