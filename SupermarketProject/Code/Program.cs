﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // New Sale
            var shoppingCart = new ShoppingCart("Miss Loyalty");

            // adding products
            var product1 = new Product1();
            shoppingCart.AddProduct(product1);

            var product2 = new Product2();
            shoppingCart.AddProduct(product2);

            var product3 = new Product3(2);
            shoppingCart.AddProduct(product3);

            // product quantity update
            shoppingCart.ProductQuantityUpdate(product3.ProductName, -3);

            // generating receipt
            var receipt = new GenerateReceipt(shoppingCart);
            receipt.GetReceiptPrintout();
        }
    }
}
