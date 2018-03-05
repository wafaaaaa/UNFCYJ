using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class TeamServices
    {
        private readonly UNFCYJEntities _dbContext;
        public TeamServices()
        {
            _dbContext = new UNFCYJEntities(); //STILL HAVE TO DISPOSE
        }
        public List<TEAM> GetAllTeams()
        {
            return _dbContext.TEAMs.ToList();
        }

        public TEAM GetTeamById(int id)
        {
            return _dbContext.TEAMs.SingleOrDefault(t => t.teamID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }

    }
}