using Application.Interfaces.Contexts;
using Domain.Visitors;
using MongoDB.Driver;
using System;
using System.Linq;

namespace Application.Visitors.VisitorOnline
{
    public class VisitorOnlineService : IVisitorOnlineService
    {
        private readonly IMongoDbContext<OnlineVisitor> mongoDbContext;
        private readonly IMongoCollection<OnlineVisitor> mongoCollection;

        public VisitorOnlineService(IMongoDbContext<OnlineVisitor> mongoDbContext)
        {
            this.mongoDbContext = mongoDbContext;
            mongoCollection = mongoDbContext.GetCollection();
        }

        public void ConnectUser(string clientId)
        {
            var exict=mongoCollection.AsQueryable().FirstOrDefault(p=>p.ClientId== clientId);
            if (exict==null)
            {
                mongoCollection.InsertOne(new OnlineVisitor
                {
                    ClientId = clientId,
                    Time = DateTime.Now,

                });
            }
        }

        public void DisConnectUser(string clientId)
        {
            mongoCollection.FindOneAndDelete(p=>p.ClientId == clientId);
        }

        public int GetCount()
        {
            return mongoCollection.AsQueryable().Count();
        }
    }
}
