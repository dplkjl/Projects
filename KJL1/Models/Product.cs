using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KJL1.Plumbing;

namespace KJL1.Models
{
    public partial class Product
    {
     
     public void AddNewProduct()
        {
            using (var dataAccessHelper = new Repository<Product>())
            {
                dataAccessHelper.Add(this);
                dataAccessHelper.SaveChanges();
            }
        }

    }
}