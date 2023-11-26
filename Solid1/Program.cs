using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Порушено принцип SRP(Single Responsibility Principle).
    //Виправлено розподілом окремих функцій по класам.
    public class Item
    {

    }
    public class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}

    }

    public class OrderPrinter
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }

    public class OrderManager
    {
        public void Load(Order order) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }

    class Program
    {
        static void Main()
        {
        }
    }
}
