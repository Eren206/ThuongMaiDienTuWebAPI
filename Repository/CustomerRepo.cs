using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Data;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Helper;
namespace ThuongMaiDienTuWebAPI.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly DataContext context;
        public CustomerRepo(DataContext context)
        {
            this.context = context;
        }

        public bool AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            return Save();

        }

        public bool DeleteCustomer(string PhoneNumber)
        {
            var customer = context.Customers.Where(p => p.PhoneNumber == PhoneNumber).FirstOrDefault();

            if (customer == null)
            {
                return false;
            }
            context.Customers.Update(customer);
            return Save();
        }

        public Customer GetCustomerByPhoneNumber(string PhoneNumer)
        {
            return context.Customers.Where(p => p.PhoneNumber == PhoneNumer).FirstOrDefault();
        }
        public bool CustomerExist(string PhoneNumber)
        {
            return context.Customers.Any(p => p.PhoneNumber == PhoneNumber);
        }

        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0 ? true : false;

        }

        public bool UpdateCustomer(Customer customer)
        {
            var ct = context.Customers.Where(c => c.CustomerId == customer.CustomerId).FirstOrDefault();
            ct.Name = customer.Name;
            ct.Email = customer.Email;
            ct.PhoneNumber = customer.PhoneNumber;
            ct.CreatedAt = customer.CreatedAt;
            ct.ModifiedAt = customer.CreatedAt;
            context.Customers.Update(customer);
            return Save();
        }

        public bool CustomerExist(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }
    }
}
