using System;

namespace Replace_Type_Code_with_Class
{
    public class After { }
    public class Ticket
    {
        public TicketType Type { get; set; }
        public string Title { get; set; }

        public decimal GetEstimateHours()
        {
            return Type.EstimateHours;
        }
    }
    public class TicketType
    {
        
        private TicketType(string name,decimal estimateHours)
        {
            Name = name;
            EstimateHours = estimateHours;
        }

        public string Name { get; }
        public decimal EstimateHours { get; }

        public static readonly TicketType Bug = new("Bug",4);
        public static readonly TicketType Feature = new("Feature", 20);
        public static readonly TicketType Task = new("Task", 8);
        public static readonly TicketType Improvment = new("Improvment", 4);

        public override string ToString()
        {
            return Name;
        }

    }
}
