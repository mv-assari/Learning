using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Extract_Interface
{

    public interface Ilogger
    {
        void LogActivity(string message);
    }

    public interface INotifier
    {
        void SendNotification(string to, string text);
    }

    public interface IExportable
    {
        string ExportData(string format);
    }
    public class UserService:Ilogger,INotifier,IExportable
    {
        public void RegisterUser(string name, string email) { /* ... */ }
        public void DeleteUser(int id) { /* ... */ }
        public void LogActivity(string message) { /* ... */ }
        public void SendNotification(string to, string text) { /* ... */ }
        public string ExportData(string format) { /* ... */ }
    }

    public class ProductService : Ilogger, INotifier, IExportable
    {
        public void AddProduct(string name, decimal price) { /* ... */ }
        public void RemoveProduct(int id) { /* ... */ }
        public void LogActivity(string message) { /* ... */ }
        public void SendNotification(string to, string text) { /* ... */ }
        public string ExportData(string format) { /* ... */ }
    }

    public class ReportService : Ilogger, INotifier, IExportable
    {
        public void GenerateReport() { /* ... */ }
        public void LogActivity(string message) { /* ... */ }
        public void SendNotification(string to, string text) { /* ... */ }
        public string ExportData(string format) { /* ... */ }
        public void ScheduleReport(DateTime date) { /* ... */ }
    }

    public class test
    {
        public void testmethod()
        {
            INotifier notifss = new ReportService();
            notifss.SendNotification("madar", "salam");

            List<Ilogger> logers = new List<Ilogger>()
            {
                new UserService(),
                new ReportService(),
                new ProductService()
            };

            foreach (var loger in logers)
            {
                loger.LogActivity("system is run");
            }

            List<INotifier> notifs = new List<INotifier>()
            {
                new UserService(),
                new ReportService(),
                new ProductService()
            };

            foreach (var notif in notifs)
            {
                notif.SendNotification("system","salam");
            }
        }
    }
}
