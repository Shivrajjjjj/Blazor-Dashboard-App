namespace BlazorDashboardApp.Services
{
    public class DashboardService
    {
        public List<DashboardItem> GetData() => new List<DashboardItem>
        {
            new() { Id = 1, Name = "Sales", Value = 5000, Status = "Active" },
            new() { Id = 2, Name = "Users", Value = 150, Status = "Pending" },
            new() { Id = 3, Name = "Revenue", Value = 12345, Status = "Completed" },
            new() { Id = 4, Name = "Orders", Value = 75, Status = "Hold" },
            new() { Id = 5, Name = "Products", Value = 1200, Status = "Active" },
            new() { Id = 6, Name = "Traffic", Value = 8600, Status = "Pending" },
            new() { Id = 7, Name = "Subscribers", Value = 310, Status = "Completed" },
            new() { Id = 8, Name = "Support Tickets", Value = 42, Status = "Hold" },
            new() { Id = 9, Name = "Returns", Value = 13, Status = "Pending" },
            new() { Id = 10, Name = "Complaints", Value = 7, Status = "Active" },
            new() { Id = 11, Name = "Inventory", Value = 640, Status = "Completed" },
            new() { Id = 12, Name = "Shipments", Value = 102, Status = "Hold" },
            new() { Id = 13, Name = "Invoices", Value = 77, Status = "Active" },
            new() { Id = 14, Name = "Expenses", Value = 4300, Status = "Pending" },
            new() { Id = 15, Name = "Profit", Value = 9600, Status = "Completed" },
            new() { Id = 16, Name = "Feedback", Value = 89, Status = "Hold" },
            new() { Id = 17, Name = "Marketing", Value = 2100, Status = "Active" },
            new() { Id = 18, Name = "Leads", Value = 375, Status = "Pending" },
            new() { Id = 19, Name = "Conversions", Value = 120, Status = "Completed" },
            new() { Id = 20, Name = "Visitors", Value = 9200, Status = "Active" },
            new() { Id = 21, Name = "Sessions", Value = 13400, Status = "Hold" },
            new() { Id = 22, Name = "Bounces", Value = 230, Status = "Pending" },
            new() { Id = 23, Name = "Cart Abandonment", Value = 58, Status = "Active" },
            new() { Id = 24, Name = "Notifications", Value = 104, Status = "Completed" },
            new() { Id = 25, Name = "Tasks", Value = 15, Status = "Hold" },
            new() { Id = 26, Name = "Team Members", Value = 28, Status = "Active" },
            new() { Id = 27, Name = "Clients", Value = 57, Status = "Pending" },
            new() { Id = 28, Name = "Partners", Value = 17, Status = "Completed" },
            new() { Id = 29, Name = "Projects", Value = 9, Status = "Hold" },
            new() { Id = 30, Name = "Tickets Resolved", Value = 40, Status = "Active" },
            new() { Id = 31, Name = "Deployments", Value = 6, Status = "Pending" },
            new() { Id = 32, Name = "Features", Value = 11, Status = "Completed" },
            new() { Id = 33, Name = "Milestones", Value = 5, Status = "Hold" },
            new() { Id = 34, Name = "Bugs", Value = 3, Status = "Active" },
            new() { Id = 35, Name = "Downloads", Value = 5300, Status = "Pending" },
            new() { Id = 36, Name = "Uploads", Value = 980, Status = "Completed" },
            new() { Id = 37, Name = "API Calls", Value = 16000, Status = "Hold" },
            new() { Id = 38, Name = "Emails Sent", Value = 2040, Status = "Active" },
            new() { Id = 39, Name = "Calls", Value = 104, Status = "Pending" },
            new() { Id = 40, Name = "Messages", Value = 88, Status = "Completed" },
            new() { Id = 41, Name = "Campaigns", Value = 19, Status = "Hold" },
            new() { Id = 42, Name = "Meetings", Value = 27, Status = "Active" },
            new() { Id = 43, Name = "Reminders", Value = 12, Status = "Pending" },
            new() { Id = 44, Name = "Deadlines", Value = 6, Status = "Completed" },
            new() { Id = 45, Name = "Events", Value = 13, Status = "Hold" },
            new() { Id = 46, Name = "Announcements", Value = 10, Status = "Active" },
            new() { Id = 47, Name = "Documents", Value = 40, Status = "Pending" },
            new() { Id = 48, Name = "Approvals", Value = 8, Status = "Completed" },
            new() { Id = 49, Name = "Quotes", Value = 22, Status = "Hold" },
            new() { Id = 50, Name = "Contracts", Value = 16, Status = "Active" },
        };
    }

    public class DashboardItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int Value { get; set; }
        public string Status { get; set; } = "";
    }
}
