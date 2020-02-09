namespace CodeFirst
{
    using System.Collections.Generic;

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public byte[] Photo { get; set; }

        // Ссылка на заказы
        public virtual List<Order> Orders { get; set; }
    }
}
