using EFDropDown.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFDropDown.Shared.DataAccess
{
    public class DataAccessLayer
    {

        DataContext db = new DataContext();

        public IEnumerable<Region> GetAllRegion()
        {
            try
            {
                return db.Region.ToList();
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Territories> GetTerritoriesData(int? id)
        {
            try
            {
                List<Territories> lstTerritories = new List<Territories>();
                lstTerritories = (from TerritoriesName in db.Territories where TerritoriesName.RegionID == id select TerritoriesName).ToList();

                return lstTerritories;
            }
            catch
            {
                throw;
            }
        }

        public IEnumerable<Territories> GetAllTerritoriesData()
        {
            try
            {
                return db.Territories.ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
