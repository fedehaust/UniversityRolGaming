using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityRolGame.Classes
{
    public class Mision
    {
        string nombre;
        string descripcion;
        int xp;
        int oro;

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pDescripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public int pXp
        {
            set { xp = value; }
            get { return xp; }
        }
        public int pOro
        {
            set { oro = value; }
            get { return oro; }
        }
    }
}