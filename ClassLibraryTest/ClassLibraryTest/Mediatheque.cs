using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTest
{
    public class Mediatheque
    {
        /// <summary>
        /// une collection de CD
        /// </summary>
        private List<CD> mesCD;
        /// <summary>
        ///  retourne la collection de CD de la médiathèque courante
        /// </summary>
        /// <returns>List de CD</returns>
        public List<CD> getMesCD()
        {
            return this.mesCD;
        }
        /// <summary>
        /// retourne le nb de CD de la médiathèque
        /// </summary>
        /// <returns>un entier</returns>
        public int getNbCD()
        {
            return this.mesCD.Count;
        }
        /// <summary>
        /// constructeur
        /// </summary>
        public Mediatheque()
        {
            mesCD = new List<CD>();
        }

    }
}
