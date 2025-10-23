using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int orderID;
        private string customerId;
        private string country;
        private string customerName;
        private string shippingCity;
        private DateTime orderDate;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int OrderID
        {
            get => orderID;
            set
            {
                if (orderID != value)
                {
                    orderID = value;
                    OnPropertyChanged(nameof(OrderID));
                }
            }
        }

        public string CustomerID
        {
            get => customerId;
            set
            {
                if (customerId != value)
                {
                    customerId = value;
                    OnPropertyChanged(nameof(CustomerID));
                }
            }
        }

        public string CustomerName
        {
            get => customerName;
            set
            {
                if (customerName != value)
                {
                    customerName = value;
                    OnPropertyChanged(nameof(CustomerName));
                }
            }
        }

        public string Country
        {
            get => country;
            set
            {
                if (country != value)
                {
                    country = value;
                    OnPropertyChanged(nameof(Country));
                }
            }
        }

        public string ShipCity
        {
            get => shippingCity;
            set
            {
                if (shippingCity != value)
                {
                    shippingCity = value;
                    OnPropertyChanged(nameof(ShipCity));
                }
            }
        }

        public DateTime OrderDate
        {
            get => orderDate;
            set
            {
                if (orderDate != value)
                {
                    orderDate = value;
                    OnPropertyChanged(nameof(OrderDate));
                }
            }
        }

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity, DateTime orderDate)
        {
            OrderID = orderId;
            CustomerName = customerName;
            Country = country;
            CustomerID = customerId;
            ShipCity = shipCity;
            OrderDate = orderDate;
        }
    }
}
