using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class ActualServices
    {
        private readonly UNFCYJEntities _dbContext;
        public ActualServices()
        {
            _dbContext = new UNFCYJEntities(); //STILL HAVE TO DISPOSE
        }
        public List<ACTUAL> GetAllActuals()
        {
            return _dbContext.ACTUALs.ToList();
        }

        public ACTUAL GetActualById(int id)
        {
            return _dbContext.ACTUALs.SingleOrDefault(t => t.actualID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }

    }
}