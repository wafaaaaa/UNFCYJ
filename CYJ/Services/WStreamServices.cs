using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CYJ.Models;

namespace CYJ.Services
{
    public class WStreamServices
    {
        private readonly UNFCYJEntities _dbContext;
        public WStreamServices()
        {
            _dbContext = new UNFCYJEntities(); //STILL HAVE TO DISPOSE
        }
        public List<WORKSTREAM> GetAllWStreams()
        {
            return _dbContext.WORKSTREAMs.ToList();
        }

        public List<WORKSTREAM> GetWStreamsList(int teamID)
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;

            return _dbContext.WORKSTREAMs.Where(x => x.teamID == teamID).ToList();
        }
        public WORKSTREAM GetWStreamsById(int id)
        {
            _dbContext.Configuration.ProxyCreationEnabled = false;
            return _dbContext.WORKSTREAMs.SingleOrDefault(t => t.workstreamID == id);
        }

        public void Dispose()
        {
            //Cleanup Resources
            _dbContext.Dispose();
        }
    }
}