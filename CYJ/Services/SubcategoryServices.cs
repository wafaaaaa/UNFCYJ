using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;


namespace CYJ.Services
{
    public class SubcategoryServices
    {
        private readonly UNFCYJEntities _dbContext;

        public SubcategoryServices()
        {
            _dbContext = new UNFCYJEntities(); //STILL HAVE TO DISPOSE
        }
        public List<SUBCATEGORY> GetAllSubCategories()
        {

            return _dbContext.SUBCATEGORies.ToList();
        }

        /*public List<SUBCATEGORY> GetSubCategoriesList(int categID)
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;

            return _dbContext.SUBCATEGORies.Where(x => x.categID == categID).ToList();
        }*/
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