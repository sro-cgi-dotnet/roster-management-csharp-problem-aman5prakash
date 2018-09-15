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
            List<string> Name = new List<string>();
            if (!_roster.ContainsKey(wave))
            {
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
            if(!_roster.ContainsKey(wave))
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
            var listkey = _roster.Keys.ToList();
            listkey.Sort();
            foreach(int x in listkey)
            {
                _roster[x].Sort();
                cadets.AddRange(_roster[x]);
            }
            return cadets;
        }
    }
}
