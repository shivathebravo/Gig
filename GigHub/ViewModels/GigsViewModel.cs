using GigHub.Models;
using System.Collections.Generic;
using System.Linq;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpComingGigs;
        public bool ShowActions;
        public string Heading { get; set; }
        public string SearchTerm { get; set; }
        public ILookup<int, Attendance> Attendances { get; set; }
    }
}