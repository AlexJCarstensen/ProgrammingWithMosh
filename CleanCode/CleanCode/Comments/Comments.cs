using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace CleanCode.Comments
{
    public class Comments
    {
        private int _payFrequency;  
        private DbContext _dbContext;

        public Comments()
        {
            _dbContext = new DbContext();
        }

        
        public List<Customer> GetCustomers(int countryCode)
        {
            //TODO: We need to get rid of abcd once we revisit this method. Currently, it's 
            // creating a coupling betwen x and y and because of that we're not able to do 
            // xyz. 

            throw new NotImplementedException();
        }

        public void SubmitOrder(Order order)
        {
            SaveOrder(order);

            NotifyCustomer(order);
        }

        private void SaveOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        private static void NotifyCustomer(Order order)
        {
            var client = new SmtpClient();
            var message = new MailMessage("noreply@site.com", order.Customer.Email, "Your order was successfully placed.", ".");
            client.Send(message);
        }
    }

    public class DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public void SaveChanges()
        {


        }
    }

    public class DbSet<T>
    {
        public void Add(Order order)
        {


        }
    }
    public class Order
    {
        public Customer Customer { get; set; }
    }

    public class Customer
    {
        public string Email { get; set; }
    }
}
