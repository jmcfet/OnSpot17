using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTheSpot.Models
{
    public class InterogatorInfo
    {
        public string CustomerID { get; set; }
        public string HomePhone { get; set; }
        public string InvoiceReminder { get; set; }
        public DateTime? OpenDate { get; set; }
        public string OpenDateString { get; set; }
        public DateTime? LastOrder { get; set; }
        public string LastOrderString { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public string HeatSealMessage { get; set; }
        public List<string> issues { get; set; }
        public List<string> resolutions { get; set; }
        public string currentIssue { get; set; }
        public string currentResolution { get; set; }
    }
}
