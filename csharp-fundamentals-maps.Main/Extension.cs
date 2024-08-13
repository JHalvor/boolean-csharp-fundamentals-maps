using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps.Main
{
    public  class Extension
    {
        private Dictionary<string, float> _planets;

        public Extension()
        {
            _planets = new Dictionary<string, float>();
            _planets.Add("Jupiter", 5.2f);
            _planets.Add("Uranus", 19.2f);
            //_planets.Add("Pluto", 39f);
            _planets.Add("Mercury", 0.39f);
            _planets.Add("Saturn", 9.54f);
            _planets.Add("Earth", 1f);
            _planets.Add("Mars", 1.52f);
            _planets.Add("Venus", 0.72f);
            _planets.Add("Neptune", 30.06f);
        }
        //TODO   Pluto is unfortunately no longer a planet so please comment out the add line!

        
        public Dictionary<string,int> LettersInName()
        {
           
            Dictionary<string, int> result = new Dictionary<string, int>();

            //TODO   Complete this method to return an Dictionary of <string,int> which contains 
            //          the planet name and the number of letters in its name
            //          iterate the _planets using a foreach object to load the result dictionary.

            foreach (var planet in _planets)
            {
                result.Add(planet.Key, planet.Key.Length);
            }

            return result;
        }






        public Dictionary<string,float> OrderedPlanets()
        {           
                return _planets.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);                           
        }
        public Dictionary<string, float> OrderedPlanetsByDescending()
        {            
            return _planets.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }
        //TODO:  modify the OrderedPlanetsByDescending so it is not dictionary is not doing an OrderBy but OrderByDescending



        //      
        //TODO   using the OrderedPlanets method get the
        //       furthest from the sun.
        //       Update the method to return the correct KeyValuePair's Key (the string)!
        //       Use the ClosestToTheSun as a guide
        

        public string FurthestFromTheSun()
        {
            return _planets.First(x => x.Value == _planets.Max(y => y.Value)).Key;
            //return _planets.Max(x => x.Value).ToString();      
        }
        public string ClosestToTheSun()
        {
            KeyValuePair<string, float> result = OrderedPlanets().First();

            return result.Key;
        }

        public Dictionary<string,float> Planets { get { return _planets; } }


    }
}
