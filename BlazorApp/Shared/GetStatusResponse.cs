using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared
{
    public class GetStatusResponse
    {
        public string StatusMessage { get; set; }
        public DateTime LastChecked { get; set; }
        public string CheckedBy { get; set; }
    }
}
