using Application.Interfaces.Contexts;
using Domain.Visitors;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Visitors.GetTodayReport
{
    public interface IGetTodayReportService
    {
        ResultTodayReportDto Execute();
    }

    public class GetTodayReportService : IGetTodayReportService
    {
        private readonly IMongoDbContext<Visitor> _mongoDbContext;
        private readonly IMongoCollection<Visitor> VisitorMongoCollection;

        public GetTodayReportService(IMongoDbContext<Visitor> mongoDbContext)
        {
            _mongoDbContext = mongoDbContext;
            VisitorMongoCollection=_mongoDbContext.GetCollection();

        }

        public ResultTodayReportDto Execute()
        {
            DateTime start = DateTime.Now.Date;
            DateTime end = DateTime.Now.AddDays(1);

            var todayPageViewCount = VisitorMongoCollection.AsQueryable()
                .Where(p => p.Time >= start && p.Time < end).LongCount();

            var todayVisitorCount = VisitorMongoCollection.AsQueryable()
                .Where(p => p.Time >= start && p.Time < end)
                .GroupBy(p=>p.VisitorId).LongCount();

            var allPageViewCount = VisitorMongoCollection.AsQueryable().LongCount();
            var allVisitorCount = VisitorMongoCollection.AsQueryable().GroupBy(p=>p.VisitorId).LongCount();

            return new ResultTodayReportDto
            {
                generalState = new GeneralStateDto
                {
                    TotalVisitors = allVisitorCount,
                    TotalPageViews = allPageViewCount,
                    PageViewPerVisit = allPageViewCount / allVisitorCount
                },
                Today=new TodayDto
                {
                    PageViews=todayPageViewCount,
                    Visitors=todayVisitorCount,
                    ViewPerVisitor= todayPageViewCount / todayVisitorCount
                }
            };

        }
    }

    public class ResultTodayReportDto
    {
        public GeneralStateDto generalState {  get; set; }
        public TodayDto Today { get; set; }

    }

    public class TodayDto
    {
        public long PageViews { get; set; }
        public long Visitors { get; set; }
        public float ViewPerVisitor { get; set; }
    }

    public class GeneralStateDto
    {
        public long TotalPageViews { get; set; }
        public long TotalVisitors { get; set; }
        public float PageViewPerVisit { get; set; }
    }
}
