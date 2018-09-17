using System;
using System.Linq;
using System.Collections.Generic;

namespace RosterManagement
{
    public class CodeSchool
    {
        Dictionary<int, List<string>> _roster;

        public CodeSchool()
        {
            _roster = new Dictionary<int, List<String>>();
        }

        /// <summary>
        /// Should be able to Add Student to a Particular Wave
        /// </summary>
        /// <param name="cadet">Refers to the name of the Cadet</param>
        /// <param name="wave">Refers to the Wave number</param>
        public void Add(string cadet, int wave)
        {
            //Checking if _roster has key or not
            if (!_roster.ContainsKey(wave))
            {
                //Creating new list if _roster doesnot have entered key
                List<string> Name = new List<string>();

                Name.Add(cadet);
                _roster.Add(wave, Name);
            }
            else
            {
                _roster[wave].Add(cadet);
            }
        }

        /// <summary>
        /// Returns all the Cadets in a given wave
        /// </summary>
        /// <param name="wave">Refers to the wave number from where cadet list is to be fetched</param>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Grade(int wave)
        {
            //Checking if _roster has key or not
            if (!_roster.ContainsKey(wave))
            {
                var list = new List<string>();
                return list;
            }
            else
            {
                _roster[wave].Sort();
                return _roster[wave];
            }
        }

        /// <summary>
        /// Return all the cadets in the CodeSchool
        /// </summary>
        /// <returns>List of Cadet's Name</returns>
        public List<string> Roster()
        {
            var cadets = new List<string>();
            // Sorting Listkey
            var listkey = _roster.Keys.ToList();
            listkey.Sort();
            // Sorting Values inside listkey
            foreach (int x in listkey)
            {
                _roster[x].Sort();
                cadets.AddRange(_roster[x]);
            }
            return cadets;
        }
    }
}
