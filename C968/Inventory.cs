using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace C968
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>(); //+ <<prop>> Products: BindingList<Product>
        public static BindingList<Part> AllParts = new BindingList<Part>();    //+ <<prop>> AllParts: BindingList<Part> 

        public static void addProduct(Product product) //+ addProduct(Product): void
        {
            Products.Add(product);
        }

        public static bool removeProduct(int id)   //+ removeProduct(int): bool
        {
            Product product = lookupProduct(id);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            else return false;
        }

        public static Product lookupProduct(int id)    //+ lookupProduct(int): Product
        {
            IEnumerable<Product> filtered =
                from product in Products
                where product.ProductID == id
                select product;

            if (filtered != null)
                return filtered.First();
            else return null;
        }

        public static void updateProduct(int id, Product product)  //+ updateProduct(int, Product): void
        {
            if (lookupProduct(id) != null)
            {
                Products[Products.IndexOf(lookupProduct(id))] = product;
            }
        }

        public static void addPart(Part part)  //+ addPart(Part): void
        {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part)   //+ deletePart(Part): bool
        {
            Part checkParts = lookupPart(part.PartID);
            if (checkParts != null)
            {
                AllParts.Remove(part);
                return true;
            }
            else return false;
        }

        public static Part lookupPart(int id)  //+ lookupPart(int): Part
        {
            IEnumerable<Part> filtered =
                from part in AllParts
                where part.PartID == id
                select part;

            if (filtered != null)
                return filtered.First();
            else return null;
        }

        public static void updatePart(int id, Part part)   //+ updatePart(int, Part): void
        {
            if (lookupPart(id) != null)
            {
                AllParts[AllParts.IndexOf(lookupPart(id))] = part;
            }
        }
    }
}
