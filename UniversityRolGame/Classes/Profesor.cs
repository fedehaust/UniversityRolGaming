using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityRolGame.Classes
{
    public class Profesor
    {
        string nombre;
        string apellido;
        int categoria;
        int legajo;
        string usuario;
        string contraseña;
        int curso;

        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public int pCategoria
        {
            set { categoria = value; }
            get { return categoria; }
        }
        public int pLegajo
        {
            set { legajo = value; }
            get { return legajo; }
        }
        public string pUsuario
        {
            set { usuario = value; }
            get { return usuario; }
        }
        public string pContraseña
        {
            set { contraseña = value; }
            get { return contraseña; }
        }
        public int pCurso
        {
            set { curso = value; }
            get { return curso; }
        }
    }
}