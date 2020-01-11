using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Models
{
    public class Destination
    {
        public string WrongDestination { get; set; }

        public string EmptyDestination { get; set; }

        public string WrongCity { get; set; }

        public Destination(string wrongLocation, string emptyDestination, string wrongCity)
        {
            WrongDestination = wrongLocation;
            EmptyDestination = emptyDestination;
            WrongCity = wrongCity;
        }
    }
}
