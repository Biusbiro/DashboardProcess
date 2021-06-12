using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace DashboardProcess.Models
{
    public class ResultPing
    {
        public int Id { get; set; }
        public IPStatus Status { get; set; }
        public int Ms { get; set; }

    }
}
