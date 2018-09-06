﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Data.Entity;


namespace WindowsFormsApplication11
{
    public class Globals
    {
        //General
        public static bool refresher = false;
        public static ContextMenuStrip menu;
       public static Image converBinToImage (byte[] Data)          
        {

            using (MemoryStream ms = new MemoryStream(Data)) 
            return Image.FromStream(ms);
        }

        public static byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {

                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }

        }

        public static bool refresher2 = false;
        private int mOrderItemId;
        private string mOrderItemName;
        private string mOrderItemDescription;
        private double mOrderItemPrice;
        private int mOrderQuantity;
        private string mOrderItemNotes;

        public string OrderItemNotes
        {
            get
            {
                return mOrderItemNotes;
            }
            set
            {
                mOrderItemNotes = value;
            }
        }

        public int OrderItemId
        {
            get
            {
                return mOrderItemId;
            }
            set
            {
                mOrderItemId = value;
            }
        }

        public int OrderQuantity
        {
            get
            {
                return mOrderQuantity;
            }
            set
            {
                mOrderQuantity = value;
            }
        }



        public string OrderItemName
        {
            get
            {
                return mOrderItemName;
            }
            set
            {
                mOrderItemName = value;
            }
        }


        public string OrderItemDescription
        {
            get
            {
                return mOrderItemDescription;
            }
            set
            {
                mOrderItemDescription = value;
            }
        }

        public double OrderItemPrice
        {
            get
            {
                return mOrderItemPrice;
            }
            set
            {
                mOrderItemPrice = value;
            }
        }

        public static List<Globals> ComboItems = new List<Globals>();
        public static List<Globals> MenuItems = new List<Globals>();
        public static List<Globals> StockItems = new List<Globals>();

        public static string fileName ;


        //Stock Passing
        public static dynamic MStockpassing = 0 ;
        public static int checkinout = 0;
        
        //Menu Passing
        public static dynamic MenuCombopassing = 0;

        //Combo Passing
        public static dynamic Combopassing = 0;
        public static bool browse = false;

        public static dynamic OrderPickUpItem = 0;
        public static dynamic OrderComboItem = 0;
        public static dynamic OrderMenuItem = 0;

        public static bool orderComboContinue = false;
        public static bool orderMenuContinue = false;
        public static bool orderItemContinue = false;

        public static List<int> combos;



        //Sales Passing
        public static dynamic Salespassing =0;

        public static dynamic SalesComboSelect = 0;
        public static dynamic SalesMenuSelect = 0;
        public static dynamic SalesShelfSelect = 0;

        public static bool DisplayCombos = false;
        public static bool DisplayMenus = false;
        public static bool DisplayShelfs = false;

        public static dynamic SalesPaymentID = 0;

        //Employee Passing
        public static dynamic Employeepassing =0;

        //Customer Passing
        public static dynamic Customerpassing =0;

        //Supplier Passing
        public static dynamic Supplierpassing =0;

        


    }
}