using DashboardProcess.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DashboardProcess.Services
{
    public class ProcessService
    {
        public ResultPing PingAddres(int round, String addres)
        {
            var result = new ResultPing();
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();
            options.DontFragment = true;

            byte[] buffer = Encoding.ASCII.GetBytes("");
            int timeout = 120;
            PingReply reply = pingSender.Send(addres, timeout, buffer, options);

            result.Id = round;
            result.Status = reply.Status;
            result.Ms = reply.Options.Ttl;

            return result;
        }
    }
}
