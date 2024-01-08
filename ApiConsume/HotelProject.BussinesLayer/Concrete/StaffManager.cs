using HotelProject.BussinesLayer.Abstract;
using HotelProject.DataAccesLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BussinesLayer.Concrete
{
    public class StaffManager : IStaffService
        
    {
        private readonly IStaffDal _stafdal;

        public StaffManager(IStaffDal stafdal)
        {
            _stafdal = stafdal;
        }

        public void TDelete(Staff t)
        {
            _stafdal.Delete(t);
        }

        public Staff TGetByID(int id)
        {
            return _stafdal.GetByID(id);
        }

        public List<Staff> TGetList()
        {
            return new List<Staff>();
        }

        public void TInsert(Staff t)
        {
            _stafdal.Insert(t);
        }

        public void TUpdate(Staff t)
        {
            _stafdal.Update(t);
        }
    }
}
