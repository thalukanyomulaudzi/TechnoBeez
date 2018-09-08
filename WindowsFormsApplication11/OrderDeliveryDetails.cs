using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication11
{
    public class OrderDeliveryDetails
    {

        private int mPaymentId;
        private int mPaymentTypeId;
        private double mPaymentAmount;
        private DateTime mPaymentDate;

        private string mOrderStatus;
        private DateTime mOrderDate;
        private double mSaleVatAmount;
        private int mDeliveryStatusId;
        private string mOrderNotes;
        private double mOrderTotal;
        private int mOrdertotalItems;
        private int mCustomerId;

        private int mOrderLineId;
        private int mItemId;
        private int mOrderId;
        private int mItemQuantity;

        public static List< List<OrderDeliveryDetails>> OrderList = new List<List<OrderDeliveryDetails>>();


        public static List<OrderDeliveryDetails> comboLineProds = new List<OrderDeliveryDetails>();

        public static List<OrderDeliveryDetails> menuLineProds = new List<OrderDeliveryDetails>();

        public static List<OrderDeliveryDetails> stockLineProds = new List<OrderDeliveryDetails>();

        public int ItemQuantity
        {
            get { return mItemQuantity; }
            set { mItemQuantity = value; }

        }

        public int OrderId
        {
            get { return mOrderId; }
            set { mOrderId = value; }

        }

        public int ItemId
        {
            get { return mItemId; }

            set { mItemId = value; }

        }

        public int OrderLineId
        {
            get { return mOrderLineId; }
            set { mOrderLineId = value; }
        }

        public int CustomerId
        {
            get { return mCustomerId; }
            set { mCustomerId = value; }

        }
            
            

        public int OrdertotalItems
        {
            get { return mOrdertotalItems; }
            set { mOrdertotalItems = value; }


        }

        public double OrderTotal
        {
            get
            {
                return mOrderTotal;
            }

            set { mOrderTotal = value; }
        }

        public string OrderNotes
        {
            get { return mOrderNotes; }
            set { mOrderNotes = value; }

        }

        public int DeliveryStatusId
        {
            get { return mDeliveryStatusId; }
            set { mDeliveryStatusId = value; }

        }

        public double SaleVatAmount
        {
            get { return mSaleVatAmount; }
            set { mSaleVatAmount = value; }

        }

        public DateTime OrderDate
        {
            get { return mOrderDate; }
            set { mOrderDate = value; }

        }

        public string OrderStatus
        {
            get { return mOrderStatus; }
            set { mOrderStatus = value; }

        }

        public int PaymentId
        {
            get { return mPaymentId; }
            set { mPaymentId = value; }

        }

        public int PaymentTypeId
        {
            get { return mPaymentTypeId; }
            set { mPaymentTypeId = value; }

        }

        public double PaymentAmount
        {
            get{ return mPaymentAmount; }
            set { mPaymentAmount = value; }
        }

        public DateTime PaymentDate
        {
            get { return mPaymentDate; }
            set { mPaymentDate = value; }
        }


    }
}
