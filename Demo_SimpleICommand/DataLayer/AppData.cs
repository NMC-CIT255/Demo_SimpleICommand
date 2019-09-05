using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo_SimpleICommand.Models;

namespace Demo_SimpleICommand.DataLayer
{
    public static class AppData
    {
        public static IList<Riddle> GetRiddles()
        {
            return new List<Riddle>()
            {
                new Riddle()
                {
                    Question = "Why don't zombies eat popcorn with their fingers?",
                    Answer = "Because they prefer to eat their fingers separately."
                },
                new Riddle()
                {
                    Question = "Why don't cows have money?",
                    Answer = "Because the farmer milks them dry."
                },
                new Riddle()
                {
                    Question = "What did the faucet say to the shower?",
                    Answer = "You're a big drip."
                },
                new Riddle()
                {
                    Question = "What happened when the butcher backed into the meat grinder?",
                    Answer = "He got a little behind in his work."
                }
            };
        }
    }
}
