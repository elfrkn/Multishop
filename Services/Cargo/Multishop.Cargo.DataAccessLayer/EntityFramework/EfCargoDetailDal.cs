using MultiShop.Cargo.DataAccessLayer.Abstract;
using Multishop.Cargo.DataAccessLayer.Concrete;
using Multishop.Cargo.DataAccessLayer.Repositories;
using Multishop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext context) : base(context)
        {

        }
    }
}
