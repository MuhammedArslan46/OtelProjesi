using HotelProject.DataAccesLayer.Abstract;
using HotelProject.DataAccesLayer.Concrete;
using HotelProject.DataAccesLayer.Repositories;
using HotelProject.Entitylayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccesLayer.EntityFramework
{ 
    public class EfServiceDal : GenericRepository<Service>,IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
               
        }
    }
}
