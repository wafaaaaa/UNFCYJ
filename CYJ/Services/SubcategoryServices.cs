using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class SubcategoryServices
    {
        private readonly CYJDashboardEntities1 _dbContext;

        public SubcategoryServices()
        {
            _dbContext = new CYJDashboardEntities1();
        }

        public List<SUBCATEGORY> GetAllSubCategories()
        {

            return _dbContext.SUBCATEGORies.ToList();
        }

        public SUBCATEGORY GetSubCategoryById(int id)
        {
            return _dbContext.SUBCATEGORies.SingleOrDefault(t => t.subcategoryID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }

    }
}