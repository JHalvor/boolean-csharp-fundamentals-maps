using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_fundamentals_maps.Main
{
     public class Core
     {
    
     /*
          The final fundamental building block of C# is a Dictionary. There is still much to learn about the language,
          but this component will allow you to start building lots of more complex pieces of software.
    
          Dictionary<K, V>
          K is where you'd put the data type of the key for an item, V is the data type of the value.
          If we wanted to map a persons details (their first name, last name, occupation etc.), we could use
          a Dictionary using a String key and a String value like so:
          Dictionary<string, string>
     */

        //TODO: Spend some time understanding the method below
        /*
            - It creates a Map of String, String key value pairs
            - It adds some keys with values
            - Under the hood, the Dictionary would look like this: { "firstName": "Nathan", "lastName": King, etc. }
            - It returns the Dictionary
            
         */
        public Dictionary<string, string> createPerson()
        {
            Dictionary<string, string> map = new Dictionary<string, string>();

            map.Add("firstName", "Nigel");
            map.Add("lastName", "Sibbert");
            map.Add("occupation", "Software Developer");

            return map;
        }

        //TODO: 1. Modify the method below named getValue that accepts one parameter:
        /*
            - a string key
            The method must return the value associated to the provided key from the HashMap created
            in the createPerson method
         */

        public string getValue(string key)
        {
            var person = createPerson();

            return person[key];


        }

        //TODO:  2. Modify below method named hasKey that accepts two parameters:
        /*
            - A Dictionary of string, string key value pairs            
            - string
            The method must return a boolean that represents whether the string provided exists as a key
            in the provided dictionary
         */
         public bool hasKey(Dictionary<string,string> dictionary, string isitthere)
         {
            return dictionary.ContainsKey(isitthere);
            
         }


        //TODO: 3. Modify method named getValueOrDefault that accepts two parameters:
        /*
            - A Dictionary<string,integer>
            - A string
            The method must use the string provided to return the integer contained in the provided HashMap,
            or -1 if the string provided is not a key in the HashMap
         */
        public int getValueOrDefault(Dictionary<string,int> dictionary, string isitthere)
        {
            if (!dictionary.ContainsKey(isitthere)) 
            {
                return -1;
            } else
            {
                return dictionary[isitthere];
            }
        }


        //TODO: 4. Complete the method below
        /*
            Example input & output:
            input                       output
            [42, 6712, 7]           |   ArrayList<String> ["universe", "bass", "muse"]
            [23, 19, 96, 23, 165]   |   ArrayList<String> ["chicken", "nice", "chicken", "soup"]
            [918, 71, 88]           |   ArrayList<String> []
         */
        public List<string> buildSecretPhrase(int[] numbers)
        {
            List<string> results = new List<string>();
            
            // Do not modify the map
            Dictionary<int, string> map = new Dictionary<int, string>();
            map.Add(23, "chicken");
            map.Add(42, "universe");
            map.Add(165, "soup");
            map.Add(6712, "bass");
            map.Add(7, "muse");
            map.Add(96, "nice");
            // Write your code below this comment...
            foreach (int number in numbers)
            {
                results.Add(map[number]);
            }

            //    // ...and above this comment
            return results;
        }            
    }
}
