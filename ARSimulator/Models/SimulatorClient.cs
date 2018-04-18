using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace ARSimulator.Models
{
    public class SimulatorClient
    {
        private string signalRBaseUrl = System.Configuration.ConfigurationManager.AppSettings["signalRServiceBaseUrl"];
        private string webAPINotifyUrl = "http://localhost:62916" + "/AmazingRace/UpdateTeamPosition";

        public int UpdatePosition()
        {
            int i = 0;
            var client = new HttpClient();
            client.BaseAddress = new Uri(webAPINotifyUrl);

            TeamPosition tPos = new TeamPosition();
            tPos.eventId = "E01";
            tPos.teamId = "2";
            tPos.x = "1.285839";
            tPos.y = "103.824365";
            tPos.ptStpPass = "1";

            //client.DefaultRequestHeaders.Accept.Add()

            return i;
        }
    }
}