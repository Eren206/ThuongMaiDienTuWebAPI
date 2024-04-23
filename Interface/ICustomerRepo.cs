
using ThuongMaiDienTuWebAPI.Models;
namespace ThuongMaiDienTuWebAPI.Interface
{
    public interface ICustomerRepo
    {
        Customer GetCustomerByPhoneNumber(string PhoneNumber);
        bool CustomerExist(int id);
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(int id);
        bool Save();
    }
}
