using System.Linq;

namespace PRACTICE
{
    public class CustomerManager
    {
        public void RegisterCustomer(string login, string password)
        {
            using (var context = new ELECTRONICS_SHOPEntities3())
            {
                var customer = new Customers { Login = login, Password = password};
                context.Customers.Add(customer);
                context.SaveChanges();
            }
        }
        public bool CheckCredentials(string login, string password)
        {
            using (var context = new ELECTRONICS_SHOPEntities3())
            {
                var customer = context.Customers.FirstOrDefault(c => c.Login == login && c.Password == password);
                return customer != null;
            }
        }
    }
}
