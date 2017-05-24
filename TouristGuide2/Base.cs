using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristGuide2
{
    public class Base : List<Tour>
    {
        public Base() : base() { }

        // Метод для добавления путёвки.
        public void AddTour(Tour tour)
        {
            this.Add(tour);
        }

        // Метод для удаления путёвки.
        public void DeleteTour(Tour tour)
        {
            this.Remove(tour);
        }
    }

}
