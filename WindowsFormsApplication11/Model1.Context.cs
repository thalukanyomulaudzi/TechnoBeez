﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication11
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MmasweEntities5 : DbContext
    {
        public MmasweEntities5()
            : base("name=MmasweEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Adress_Type> Adress_Type { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<Banking_Details> Banking_Details { get; set; }
        public virtual DbSet<Check_In> Check_In { get; set; }
        public virtual DbSet<Check_In_Line> Check_In_Line { get; set; }
        public virtual DbSet<Check_Out> Check_Out { get; set; }
        public virtual DbSet<Check_Out_Line> Check_Out_Line { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Combo> Comboes { get; set; }
        public virtual DbSet<Combo_Price> Combo_Price { get; set; }
        public virtual DbSet<Combo_Type> Combo_Type { get; set; }
        public virtual DbSet<Company_Information> Company_Information { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Customer_Order> Customer_Order { get; set; }
        public virtual DbSet<Customer_Order_Line> Customer_Order_Line { get; set; }
        public virtual DbSet<Delivery_Status> Delivery_Status { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Attendence_Status> Employee_Attendence_Status { get; set; }
        public virtual DbSet<Employee_Booking_Shift> Employee_Booking_Shift { get; set; }
        public virtual DbSet<Employee_Gender_> Employee_Gender_ { get; set; }
        public virtual DbSet<Employee_Shifts> Employee_Shifts { get; set; }
        public virtual DbSet<ItemsPicture> ItemsPictures { get; set; }
        public virtual DbSet<Menu_Item> Menu_Item { get; set; }
        public virtual DbSet<Menu_Item_Price> Menu_Item_Price { get; set; }
        public virtual DbSet<Menu_Item_Type> Menu_Item_Type { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Payment_Type> Payment_Type { get; set; }
        public virtual DbSet<Quantity> Quantities { get; set; }
        public virtual DbSet<Special> Specials { get; set; }
        public virtual DbSet<Stock_Combo_Line> Stock_Combo_Line { get; set; }
        public virtual DbSet<Stock_Item> Stock_Item { get; set; }
        public virtual DbSet<Stock_Order> Stock_Order { get; set; }
        public virtual DbSet<Stock_Order_Line> Stock_Order_Line { get; set; }
        public virtual DbSet<Stock_Order_Status> Stock_Order_Status { get; set; }
        public virtual DbSet<Stock_Price> Stock_Price { get; set; }
        public virtual DbSet<Stock_Type> Stock_Type { get; set; }
        public virtual DbSet<Stock_Write_Off> Stock_Write_Off { get; set; }
        public virtual DbSet<Stock_WriteOff_Line> Stock_WriteOff_Line { get; set; }
        public virtual DbSet<Suburb> Suburbs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supplier_Contact_Details> Supplier_Contact_Details { get; set; }
        public virtual DbSet<Supplier_Type> Supplier_Type { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Log> User_Log { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }
    }
}
