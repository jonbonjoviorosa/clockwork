using System;
using Microsoft.AspNetCore.Mvc;
using Clockwork.API.Models;
using System.Data;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

namespace Clockwork.API.Controllers
{
    public class CurrentTimeController : Controller
    {
        [Route("api/[action]")]
        [EnableCors("MyPolicy")]
        [HttpGet()]
        public string dbList(string cutoff_id, string month, string pay_date)
        {
            List<CurrentTimeQuery> items = new List<CurrentTimeQuery>();
           
            int ctr = 0;
            using (var db = new ClockworkContext())
            {
                foreach (var col in db.CurrentTimeQueries)
                {
                    CurrentTimeQuery row = new CurrentTimeQuery();
                    row.CurrentTimeQueryId = col.CurrentTimeQueryId;
                    row.Time = col.Time;
                    row.ClientIp = col.ClientIp;
                    row.UTCTime = col.UTCTime;
                    items.Add(row);
                    ctr++;
                }
            }
            return JsonConvert.SerializeObject(items);
        }

        [Route("api/[action]")]
        [EnableCors("MyPolicy")]
        [HttpPost()]
        public int dbSave()
        {
            int ret = 0;
            DateTimeOffset localServerTime = DateTimeOffset.Now;
            DateTimeOffset utc = localServerTime.ToUniversalTime();

            var utcTime = utc.UtcDateTime;
            var serverTime = localServerTime.LocalDateTime;
            var ip = this.HttpContext.Connection.RemoteIpAddress.ToString();

            var returnVal = new CurrentTimeQuery
            {
                UTCTime = utcTime,
                ClientIp = ip,
                Time = serverTime
            };

            using (var db = new ClockworkContext())
            {
                db.CurrentTimeQueries.Add(returnVal);
                var count = db.SaveChanges();
                ret = 1;
            }
            return ret;
        }
    }
}
