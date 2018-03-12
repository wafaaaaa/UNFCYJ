using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class GoalServices
    {
        private readonly CYJDashboardEntities1 _dbContext;
        public GoalServices()
        {
            _dbContext = new CYJDashboardEntities1();
        }

        public List<GOAL> GetAllGoal()
        {

            return _dbContext.GOALS.ToList();
        }

        public GOAL GetAGoalsById(int id)
        {
            return _dbContext.GOALS.SingleOrDefault(t => t.goalID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }

    }
}