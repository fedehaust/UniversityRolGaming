using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityRolGame.Classes
{
    public class Alumno
    {
        string nombre;
        string apellido;
        int legajo;
        string usuario;
        string contrasenia;
        int oro;
        int xp;
        Item item;
        Mision mision;
        int categoria;
        int curso;
        int nivel;

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
            set { contrasenia = value; }
            get { return contrasenia; }
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
        public Item pItem
        {
            set { item = value; }
            get { return item; }
        }
        public Mision pMision
        {
            set { mision = value; }
            get { return mision; }
        }
        public int pCategoria
        {
            set { categoria = value; }
            get { return categoria; }
        }
        public int pCurso
        {
            set { curso = value; }
            get { return curso; }
        }
        public int pNivel
        {
            set { nivel = value; }
            get { return nivel; }
        }
    }
}