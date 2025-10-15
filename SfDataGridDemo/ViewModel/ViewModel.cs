using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfoCollection
    {
        private ObservableCollection<OrderInfo> _orders;

        public ObservableCollection<OrderInfo> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        public OrderInfoCollection()
        {
            _orders = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();
        }

        private void GenerateOrders()
        {
            _orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin", new DateTime(2025,3,9)));
            _orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F.", new DateTime(2025, 3, 29)));
            _orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", new DateTime(2025, 4, 9)));
            _orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London", new DateTime(2025, 2, 2)));
            _orders.Add(new OrderInfo(1005, "Maria Anders", "Germany", "ALFKI", "Berlin", new DateTime(2025, 2, 9)));
            _orders.Add(new OrderInfo(1006, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F.", new DateTime(2025, 3, 29)));
            _orders.Add(new OrderInfo(1007, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F.", new DateTime(2025, 4, 9)));
            _orders.Add(new OrderInfo(1008, "Thomas Hardy", "UK", "AROUT", "London", new DateTime(2025, 2, 2)));
        }
    }
}
