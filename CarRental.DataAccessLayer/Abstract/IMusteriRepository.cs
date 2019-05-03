using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Entities;

namespace CarRentalSoa.DataAccessLayer.Abstract
{
    public interface IMusteriRepository : IGenericRepository<Musteriler>
    {
        void Delete(Musteriler obj);
    }
}
