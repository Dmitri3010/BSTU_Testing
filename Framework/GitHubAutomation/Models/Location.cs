using System;
using System.Text;


namespace GitHubAutomation.Models
{
    public class Location
    {
        public string PickUpLocation { get; set; }
        public string ReturnLocation { get; set; }

        public Location(string pickUpPlace, string returnPlace)
        {
            PickUpLocation = pickUpPlace;
            ReturnLocation = returnPlace;
        }
    }
}
