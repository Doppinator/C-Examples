// See https://aka.ms/new-console-template for more information

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)

        : this(id)
        {
            this.Name = name;
        }


        public class Order
        {

        }



    }
}
