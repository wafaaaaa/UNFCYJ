using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class GoalServices
    {
        private readonly UNFCYJEntities _dbContext;
        
        public GoalServices()
        {
            _dbContext = new UNFCYJEntities(); //STILL HAVE TO DISPOSE
        }
        public List<GOAL> GetAllSubCategories()
        {

            return _dbContext.GOALs.ToList();
        }

        /*public List<GOAL> GetAGoalsList(int subcategID)
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;

            return _dbContext.GOALs.Where(x => x.subcategID == subcategID).ToList();
        }*/
        public GOAL GetAGoalsById(int id)
        {
            return _dbContext.GOALs.SingleOrDefault(t => t.goalID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }
    }
}