﻿using OnTheSpot.Dal;
using OnTheSpot.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTheSpot.ViewModels
{
    public class QSSVM : BaseViewModel
    {
        public string Duedate { get; set; }
        public string store { get; set; }
        public string barcode { get; set; }
        public string reason { get; set; }
        public string Employeename { get; set; }
        public string Note { get; set; }
        public bool LoggedInState { get; set; }
        public AutoSortInfo assemblyInfo;
        bool bgotNewImage;
        public bool bGotNewImage
        {
            get { return bgotNewImage; }
            set
            {
                if (bgotNewImage != value)
                {
                    bgotNewImage = value;
                    NotifyPropertyChanged("bGotNewImage");
                }
            }
        }
        bool showButtons;
        public bool ShowButtons
        {
            get { return showButtons; }
            set
            {
                if (showButtons != value)
                {
                    showButtons = value;
                    NotifyPropertyChanged("ShowButtons");
                }
            }
        }
        List<string> connectionNames = new List<string>() { "Store1Entities", "Store2Entities", "Store3Entities", "Store4Entities" };
        //retrieve the connection string frpm app.config
        ConnectionStringSettingsCollection connections = ConfigurationManager.ConnectionStrings;
        public QSSVM()
        {

            bSimulatePhigetsMode = true;
            LoggedInState = false;
            bGotNewImage = false;


        }
        public Employee GetEmployee(int id)
        {
           

            DBAccess db = new DBAccess(connections[connectionNames[0]].ConnectionString);
            return db.GetEmployee(id);
        
        }
        public string saveQCS(string heatseal,string location)
        {
  
            DBAccess db = new DBAccess(connections[connectionNames[0]].ConnectionString);
            return db.SaveQCS(heatseal, location);
           
        }
        public void AddNote(string heatseal, string note)
        {
            DBAccess db = new DBAccess(connections[connectionNames[0]].ConnectionString);
            db.saveNote(heatseal, note);
         
        }
        public string getNotinAutoSort()
        {
            return "Item not found, call manager immediately! {0}";
        }

        public OnTheSpot.Models.InterogatorInfo getInfoForInterogator()
        {

            DBAccess db = new DBAccess(connections[connectionNames[0]].ConnectionString);
            
            assemblyInfo.HeatSeal = barcode;
          //  assemblyInfo.CustomerID = 100006;
            return db.getInfoForInterogator(assemblyInfo);
         
            
        }

    }
}
