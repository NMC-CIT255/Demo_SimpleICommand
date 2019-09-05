using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_SimpleICommand.Models
{
    public class AppWindowViewModel
    {
        private IList<Riddle> riddleCollection { get; set; }


        public AppWindowViewModel(IList<Riddle> riddles)
        {
            riddleCollection = riddles;
        }

        private string _currentRiddle;

        public string CurrentRiddle
        {
            get { return GetRiddle().Question; }
        }


        public Riddle GetRiddle()
        {
            Random r = new Random();

            return riddleCollection.ElementAt(r.Next(riddleCollection.Count - 1));
        }
    }
}
