using System;
using System.Collections.Generic;

namespace CampaignDashboard.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string CreativeStatus { get; set; }
        public string AllocationStatus { get; set; }
        public string ValidatedStatus { get; set; }
        public string ProdStatus { get; set; }
        public decimal Cost { get; set; }
        public string Delta { get; set; }
        public List<CampaignItem> Items { get; set; }
    }

    public class CampaignItem
    {
        public string ItemCode { get; set; }
        public string ElementType { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Creative { get; set; }
        public string Artwork { get; set; }
        public string Allocation { get; set; }
        public string Validated { get; set; }
        public string Production { get; set; }
        public decimal Cost { get; set; }
    }
}