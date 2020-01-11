using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubAutomation.Models
{
    public class Booking
    {
        public string EmptyBooking { get; set; }

        public string WrongBooking { get; set; }

        public string EmptySurname { get; set; }

        public string WrongSurname { get; set; }

        public Booking(string emptyBooking, string wrongBooking, string emptySurname, string wrongSurname)
        {
            EmptyBooking = emptyBooking;
            WrongBooking = wrongBooking;
            EmptySurname = emptySurname;
            WrongSurname = wrongSurname;
        }
    }
}
