using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleLot.DAL;
using VehicleLot.Repository;
using VehicleLot.Repository.Common;
using VehicleLot.Service.Common;

namespace VehicleLot.Service
{
    public class VehicleModelService : IVehicleService 
    {
        
        public VehicleModelService(IGenericRepository<VehicleModelRepository> repository)
        {
            this.Repository = repository;
        }
            
        protected IGenericRepository<VehicleModelRepository> Repository { get; set; }
        
        public void Add(VehicleModelRepository modelRepository)
        {
            if (!Repository.GetAll().Where(p => p.)
            {

            }
        }
        
    }
}
