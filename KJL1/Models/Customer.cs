using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KJL1.Plumbing;

namespace KJL1.Models
{
    public partial class Customer
    {
     
     public void AddNewCustomer()
        {
            using (var dataAccessHelper = new Repository<Customer>())
            {
                dataAccessHelper.Add(this);
                dataAccessHelper.SaveChanges();
            }
        }

    }
}