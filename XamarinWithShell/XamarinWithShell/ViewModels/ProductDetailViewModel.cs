using System;
using System.Collections.Generic;
using System.Text;
using XamarinWithShell.Models;

namespace XamarinWithShell.ViewModels
{
    public class ProductDetailViewModel
    {
        public Product SelectedProduct { get; set; }

        public ProductDetailViewModel(Product item = null)
        {
            if (item == null)
                SelectedProduct = new Product();

            SelectedProduct = (Models.Product)item;

        }
    }
}
