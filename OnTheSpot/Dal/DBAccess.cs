﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using OnTheSpot.EFStuff;
using System.Diagnostics;
using NLog;


namespace OnTheSpot.Dal
{
    public class DBAccess
    {
        BCSEntities db = new BCSEntities();
        Logger logger = LogManager.GetLogger("OnTheSpot");
        Store1Entities2 dbOTS;

        public DBAccess(string connectionstring)
        {
            dbOTS = new Store1Entities2();
        }

        public  Employee GetEmployee(int empid)
        {
            OnTheSpot.EFStuff.Employees emp = null;
            string error = string.Empty;
            try
            {
                emp = dbOTS.Employees.Where(e2 => e2.EmployeeID == empid).SingleOrDefault();
            }
            catch (Exception e)
            {
                error = "Critical Error: Could not open Categories DataBase";
            }

            return new Employee()
                 {

                     FirstName = emp.FirstName,
                     LastName = emp.LastName
                 };
        }

        public ObservableCollection<Category> GetCats(out string error)
        {
            ObservableCollection<Category> modelCats = null;
            error = string.Empty;
            try
            {
                List<Category> dbCats = db.Categories.ToList();

                modelCats = new ObservableCollection<Category>();
                foreach (Category cat in dbCats)
                {
                    Category model = new Category()
                    {
                        ID = cat.ID,
                        Description = cat.Description,
                        Name = cat.Name
                    };
                    modelCats.Add(model);
                }
            }
            catch  (Exception e)
            {
                error = "Critical Error: Could not open Categories DataBase";
            }

            return modelCats;
        }

        public Item getItem(string barcode)
        {
   //        Item item = db.Items.Where(i => i.BarCode == barcode).SingleOrDefault();
            //these will be no record of this barcode if this is the first time the item is scanned
            //when it is categorized there should only be 1 occurance but there seems to a bug where the uncategoryized
            //record is left in the BCS DB, so if we find more than 1 record look for the first that is NOT the uncategorized record
            //we will still throw if there is more than 1 found as we are really messed up
           Item item = null;
           List<Item> items = db.Items.Where(i => i.BarCode == barcode).ToList();
           if (items.Count == 0)
               return null;
           if (items.Count > 1)   //if there are multiple this is ok if all the same category
           {

               List<Category> distinct = items.Select(c => c.Category).Distinct().ToList();
               if (distinct.Count > 1)
                   throw new Exception("barcode cannot have mutliple categories");

           }
           item = items.First();
           
           Item model = new Item()
           {
               ID = item.ID,
               BarCode = item.BarCode,
               CustID = item.CustID,
               Note = item.Note,
               picture = item.picture

           };
           model.Category = new Category()
           {
               ID = item.Category.ID,
               Description = item.Category.Description,
               Name = item.Category.Name
           };
           return model; 
        }

         public ObservableCollection<Item> GetItems()
        {
            List<Item> dbItems = db.Items.ToList();
            ObservableCollection<Item> modelItems = new ObservableCollection<Item>();
            foreach (Item item in dbItems)
            {
                Item model = new Item()
                {
                    ID = item.ID,
                    BarCode = item.BarCode,
                    CustID = item.CustID

                };
                model.Category = new Category()
                {
                    ID = item.Category.ID,
                    Description = item.Category.Description,
                    Name = item.Category.Name
                };
                modelItems.Add(model);
            }
            return modelItems;
        }
         public List<Printer> getPrinters()
         {
             List<Printer> dbprinters = db.Printers.ToList();
             List<Printer> modelItems = new List<Printer>();
             List<Printer> printerModels = new List<Printer>();
             foreach (Printer item in dbprinters)
             {
                 Printer model = new Printer()
                 {
                     PrinterName = item.printerName,
                     Store = item.storename
                 };
                 printerAdd(model);
             }
             return printerModels;            
         }
         public ObservableCollection<Bin> GetBins()
         {
             List<Bin> dbBins = db.Bins.ToList();
             ObservableCollection<Bin> modelItems = new ObservableCollection<Bin>();
             foreach (Bin item in dbBins)
             {
                 Bin model = new Bin()
                 {
                     ID = item.ID,
                     BarCode = item.BarCode,
 //                    Category = item.Category,
                     MaxWeight = item.MaxWeight,
                     PhidgetSlot = item.PhigidSlot

                 };
                 model.Category = new Category()
                 {
                     ID = item.Category1.ID,
                     Description = item.Category1.Description,
                     Name = item.Category1.Name
                 };
                 modelItems.Add(model);
             }
             return modelItems;
         }
         public void SaveItem(Item item, bool savingPicture = false)
         {
             
             logger.Info(string.Format("SaveItem {0}", item.ID));         
             Item dbItem = db.Items.Where(i => i.BarCode == item.BarCode).SingleOrDefault();
             if (dbItem == null)
             {
                
                 logger.Info(string.Format("Create new"));  
                 dbItem = new Item() { BarCode = item.BarCode, CustID = item.CustID, CreateDate = item.CreationDate };
                 dbItem.CatID = item.Category.ID;
                 db.Items.Add(dbItem);
             }
             else
             {
                 logger.Info(string.Format("Modify {0}", item.Category.ID));
                if (!savingPicture)
                {
                    if (dbItem.CatID == item.Category.ID)
                        return;
                    dbItem.CatID = item.Category.ID;
                }
                else
                    dbItem.picture = item.picture;
             }
             db.SaveChanges();
         }
         public void SaveGssItem(GSS gss)
         {

             logger.Info(string.Format("SaveItem {0}", gss.ID));
             OnTheSpot.EFStuff.GSS dbItem = new OnTheSpot.EFStuff.GSS() { barcode = gss.BarCode, bin = gss.bin, time = gss.CreationDate,temp3 = "temp"};
             db.GSSes.Add(dbItem);
             db.SaveChanges();
         }
         public string SaveQCS(string heatseal,string location)
         { 

             OnTheSpot.EFStuff.QCSInfo dbItem = new OnTheSpot.EFStuff.QCSInfo() {  HeatSeal=heatseal, Bin=location, Time = DateTime.Now };
             db.QCSInfoes.Add(dbItem);
             try
             {
                 db.SaveChanges();
             }
             catch (Exception e)
             {
                return e.InnerException.Message;
             }
             return string.Empty;
         }
         public void saveNote(string heatseal, string note)
         {
             Item item = db.Items.Where(i => i.BarCode == heatseal).SingleOrDefault();
             item.Note = note;
             db.SaveChanges();
         }
         public Customer GetCustomerInfo(int WorkOrderNumber)
        {
            //Order order = dbOTS.Orders.Where(o => o.OrderID == WorkOrderNumber).SingleOrDefault();
            //if (order == null)
            //{
            //    MessageBox("Work order {0} not found in database", WorkOrderNumber);
            //}
            //Customer cust =  dbOTS.Customers.Where(c => c.CustomerID == order.CustomerID).SingleOrDefault();
            Customer customer = null;
            try
            {
                customer = (from o in dbOTS.Orders
                                                where o.OrderID == WorkOrderNumber
                                                join cust in dbOTS.Customers on o.CustomerID equals cust.CustomerID
                                                select new Customer() { FirstName = cust.FirstName, LastName = cust.LastName, Starch = cust.Starch }).SingleOrDefault();
            }
            catch (Exception e)
            {
            }

            return customer;
        }

         public Customer GetCustomer(int id)
         {
             return (from cust in dbOTS.Customers
                                         where cust.CustomerID == id
                                         select new Customer() { FirstName = cust.FirstName, LastName = cust.LastName, Starch = cust.Starch }).SingleOrDefault();
         

         }

        public bool SaveBins(ObservableCollection< Bin> CleaningBins)
        {
            foreach (Bin bin in CleaningBins)
            {
                Bin binDB = db.Bins.Where(b => b.ID == bin.ID).SingleOrDefault();
                if (binDB == null)
                {
                    binDB = new Bin();
//                    binDB.Category1 = new Category();
                    db.Bins.Add(binDB);

                }
                binDB.MaxWeight = bin.MaxWeight;
                binDB.BarCode = bin.BarCode;
                binDB.PhigidSlot = bin.PhidgetSlot;
            }
                
            db.SaveChanges();
            return true;
        }
        public void SaveShowPass(int  Save)
        {
            
            Configuration   con = db.Configurations.First();
            con.ShowPass = Save;
            db.SaveChanges();
        }
        //there is only one config for the system
        public int? getPass()
        {
           
            return  db.Configurations.First().ShowPass;
           
        }
        public OnTheSpot.Models.InterogatorInfo getInfoForInterogator(OnTheSpot.Models.AutoSortInfo  customerstuff)
        {
            double heatseal = double.Parse(customerstuff.HeatSeal);
            OnTheSpot.Models.InterogatorInfo info = (from cust in dbOTS.Customers
                                                     where cust.CustomerID == customerstuff.CustomerID
                                                     from heat in dbOTS.Heatseals
                                                     where heat.HeatsealID == heatseal
                                                     select new OnTheSpot.Models.InterogatorInfo() {  HomePhone = cust.HomePhone, Email= cust.EMail, InvoiceReminder = cust.InvReminder,
                     LastOrder = cust.LastOrder, Notes= cust.Notes, OpenDate = cust.OpenDate, HeatSealMessage = heat.Message }).SingleOrDefault();

            List<OnTheSpot.EFStuff.Contacts> contacts = (from contact in dbOTS.Contacts
                                                      where contact.CustomerID == customerstuff.CustomerID
                                                         select contact).ToList();
            info.CustomerID = customerstuff.CustomerID.ToString();
            info.OpenDateString = info.OpenDate.Value.ToShortDateString();
            info.LastOrderString = info.LastOrder.Value.ToShortDateString();
            info.issues = new List<string>();
            info.resolutions = new List<string>();
            foreach(OnTheSpot.EFStuff.Contacts contact  in contacts)
            {
                info.issues.Add(contact.Issue);
                info.resolutions.Add(contact.Resolution);
            }
            info.currentIssue = info.issues[0];
            info.currentResolution = info.resolutions[0];
            return info;
        }


    }


}

   
