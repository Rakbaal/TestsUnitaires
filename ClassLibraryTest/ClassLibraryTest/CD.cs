using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class CD
    {
        /// <summary>
        /// le numér0 du CD
        /// </summary>
        public string noCD;
        /// <summary>
        /// le nombre de pistes du CD
        /// </summary>
        public int nbPistes;
        /// <summary>
        /// constructeur
        /// </summary>
        /// <param name="unNo">une chaîne</param>
        /// <param name="unnbPistes">un entier</param>
        public CD(string unNo, int unnbPistes)
        {
            this.noCD = unNo;
            this.nbPistes = unnbPistes;
        }

    }
}
