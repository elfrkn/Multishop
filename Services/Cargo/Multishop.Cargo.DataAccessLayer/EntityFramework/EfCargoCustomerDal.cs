using Multishop.Cargo.DataAccessLayer.Concrete;
using Multishop.Cargo.DataAccessLayer.Repositories;
using Multishop.Cargo.EntityLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Abstract;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCustomerDal : GenericRepository<CargoCustomer>, ICargoCustomerDal
    {
       
        public EfCargoCustomerDal(CargoContext context) : base(context)
        {
           
        }
      
    }
}
