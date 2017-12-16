using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OnTheSpot.EFStuff;// string StoreConnectionString = connections["Store1Entities"].ConnectionString;
                        //// AssemblyConnectionString = connections["AssemblyEntities"].ConnectionString;

// OTSAccess dal = new OTSAccess(StoreConnectionString);
// dal.GetEmployee(1);
// string error = string.Empty;
// System.Collections.ObjectModel.ObservableCollection<Category> cats = dal.GetCats(out error);
using OnTheSpot.Models;

namespace OnTheSpot.Dal
{
    
    public class AssemblyAccess
    {
        AssemblyEntities1 assemblyEnties;
        
        public AssemblyAccess(string connectionstring)
        {
            assemblyEnties = new AssemblyEntities1();
        }

        public AutoSortInfo GetCustomerInfoFromAssembly(string itemID)
        {
            AutoSortInfo AssemblyStuff = (from auto in assemblyEnties.AutoSorts
                        where auto.ArticleCode == itemID
                        join inv in assemblyEnties.Invoices on auto.InvoiceID equals inv.InvoiceID
                             select new AutoSortInfo() { CustomerID = auto.CustomerID, InvoiceNumber = inv.InvoiceID, dept = inv.Department, Duedate = auto.DueDate , rfid = auto.RFID, storeid = auto.StoreID}).SingleOrDefault();


            return AssemblyStuff;
        }

        public bool GetInfoFromAssembly(string itemID)
        {
            int id = Int32.Parse(itemID);
            Invoice item = assemblyEnties.Invoices.Where(i => i.OrderID == id).SingleOrDefault();
            if (item == null)
                return false;
            else
                return true;
        }
    }
}

