using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityRolGame.Classes;

namespace UniversityRolGame
{
    public partial class Registrar : System.Web.UI.Page
    {
        Conexion c = new Conexion();
        Alumno a = new Alumno();
        Profesor p = new Profesor();
        string sql = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            a.pUsuario = txtUsuario.Text;
            a.pContraseña = txtContrasenia.Text;
            a.pNombre = txtNombre.Text;
            a.pApellido = txtApellido.Text;
            a.pLegajo = Convert.ToInt32(txtLegajo.Text);
            a.pCategoria = 0;
            a.pCurso = Convert.ToInt32(ddlCurso.SelectedIndex);

            if (a.pCategoria == 0)
            {
                sql = "INSERT INTO Alumnos Values('" + a.pUsuario + "',"
                                                 + "'" + a.pContraseña + "',"
                                                 + "'" + a.pNombre + "',"
                                                 + "'" + a.pApellido + "',"
                                                 + a.pLegajo + ","
                                                 + a.pCategoria + ","
                                                 + a.pCurso + ")";

            }

            c.consultar(sql);
        }
    }
}