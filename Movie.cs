using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabaseLab
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int RunTime { get; set; }
        public int YearReleased { get; set; }

        public Movie(string title, string category, int runTime, int yearReleased)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            YearReleased = yearReleased;
        }
    }
}
