using Multishop.Cargo.DataAccessLayer.Concrete;
using Multishop.Cargo.DataAccessLayer.Repositories;
using Multishop.Cargo.EntityLayer.Concrete;
using MultiShop.Cargo.DataAccessLayer.Abstract;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoOperationDal : GenericRepository<CargoOperation>, ICargoOperationDal
    {
        public EfCargoOperationDal(CargoContext context) : base(context)
        {

        }
    }
}