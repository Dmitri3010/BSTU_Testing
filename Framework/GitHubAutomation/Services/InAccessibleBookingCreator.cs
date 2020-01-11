using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubAutomation.Models;

namespace GitHubAutomation.Services
{
    class InAccessibleBookingCreator
    {
        public static Booking WithWronBooking()
        {
            return new Booking(TestDataReader.GetTestData("EmptyBooking"), TestDataReader.GetTestData("WrongBooking"), TestDataReader.GetTestData("EmptySurname"), TestDataReader.GetTestData("WrongSurname"));
        }
    }
}
