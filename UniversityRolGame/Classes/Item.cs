using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityRolGame.Classes
{
    public class Item
    {
        string nombre;
        int oro;
        int xp;

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int pOro
        {
            set { oro = value; }
            get { return oro; }
        }
        public int pXp
        {
            set { xp = value; }
            get { return xp; }
        }
    }
}