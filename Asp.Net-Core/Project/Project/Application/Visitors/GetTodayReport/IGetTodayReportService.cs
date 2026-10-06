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

            var todayPageViewList = VisitorMongoCollection.AsQueryable()
                .Where(p => p.Time >= start && p.Time < end)
                .Select(p => new
                {
                    p.Time
                }).ToList();


            VisitCountDto visitPerHour = new VisitCountDto
            {
                Display = new string[24],
                Value=new int[24]
            };

            for (int i = 0;i<=23;i++)
            {
                visitPerHour.Display[i] = $"H-{i}";
                visitPerHour.Value[i] = todayPageViewList.Where(p => p.Time.Hour == i).Count();
            }

            DateTime monthStart = DateTime.Now.Date.AddDays(-30);
            DateTime monthEnd = DateTime.Now.Date.AddDays(1);

            var month_PageViewList = VisitorMongoCollection.AsQueryable()
                                    .Where(p => p.Time >= monthStart && p.Time < monthEnd)
                                    .Select(p => new { p.Time }).ToList();

            VisitCountDto visitPerDay = new VisitCountDto
            {
                Display = new string[31],
                Value = new int[31]
            };

            for (int i=0;i<=30 ; i++)
            {
                var currentDay = DateTime.Now.AddDays(i * (-1));
                visitPerDay.Display[i] = i.ToString();
                visitPerDay.Value[i]=month_PageViewList.Where(p=>p.Time.Date==currentDay.Date).Count();
            }

            return new ResultTodayReportDto
            {
                GeneralStats = new GeneralStateDto
                {
                    TotalVisitors = allVisitorCount,
                    TotalPageViews = allPageViewCount,
                    PageViewsPerVisit =GetAvg(allPageViewCount, allVisitorCount),
                    VisitPerDay = visitPerDay
                },
                Today=new TodayDto
                {
                    PageViews=todayPageViewCount,
                    Visitors=todayVisitorCount,
                    ViewsPerVisitor=GetAvg( todayPageViewCount , todayVisitorCount),
                    VisitPerhour=visitPerHour
                }
            };

        }

        private float GetAvg(long VisitPage,long Visitor)
        {
            if (Visitor==0)
            {
                return 0;
            }
            else
            {
                return VisitPage / Visitor;
            }
        }
    }

    public class ResultTodayReportDto
    {
        public GeneralStateDto GeneralStats {  get; set; }
        public TodayDto Today { get; set; }

    }

    public class TodayDto
    {
        public long PageViews { get; set; }
        public long Visitors { get; set; }
        public float ViewsPerVisitor { get; set; }
        public VisitCountDto VisitPerhour { get; set; }
    }

    public class GeneralStateDto
    {
        public long TotalPageViews { get; set; }
        public long TotalVisitors { get; set; }
        public float PageViewsPerVisit { get; set; }
        public VisitCountDto VisitPerDay { get; set; }
    }

    public class VisitCountDto
    {
        public string[] Display { get; set; }
        public int[] Value { get; set; }
    }
}
