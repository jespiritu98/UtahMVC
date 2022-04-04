using System;

namespace UtahMVC.Models.ViewModels
{
    public class PageInfo
    {

        public int TotalNumCrashes { get; set; }
        public int CrashesPerPage { get; set; }
        public int CurrentPage { get; set; }

        // calc how many pages you need for each instance
        public int TotalPages => (int)Math.Ceiling((double)TotalNumCrashes / CrashesPerPage);
    }
}