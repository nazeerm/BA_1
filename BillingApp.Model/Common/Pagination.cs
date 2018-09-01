using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingApp.Model.Common
{
    public class Pagination
    {
        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }

    }
}
