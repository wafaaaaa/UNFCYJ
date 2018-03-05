using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class ConnectionServices
    {
        private readonly UNFCYJEntities _dbContext;
        public ConnectionServices()
        {
            _dbContext = new UNFCYJEntities(); //STILL HAVE TO DISPOSE
        }
        public List<CONNECTION> GetAllConnections()
        {
            return _dbContext.CONNECTIONs.ToList();
        }

        public CONNECTION GetConnectionById(int id)
        {
            return _dbContext.CONNECTIONs.SingleOrDefault(t => t.connectID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }

    }
}