using System;
using System.Collections.Generic;


namespace CRMBussinesLogic.Models
{
    class Product:IComparable
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public decimal Price  { get; set; }

        public int Count { get; set; }

        int IComparable.CompareTo(object obj)
        {
            Product temp = obj as Product;
            if (temp != null) 
            {
                if (this.ProductID > temp.ProductID) { return 1; }
                if (this.ProductID < temp.ProductID) { return -1; }
                else { return 0; }
            }
            else
            {
                throw new ArgumentException("Parametr is not a Product"); 
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
