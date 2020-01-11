using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitHubAutomation.Models;

namespace GitHubAutomation.Services
{
    class InAccessibleDestination
    {
        public static Destination WithWronDestination()
        {
            return new Destination(TestDataReader.GetTestData("WrongDestination"), TestDataReader.GetTestData("EmptyDestination"), TestDataReader.GetTestData("WrongCity"));
        }
    }
}
