using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using UniversityRolGame.Classes;


namespace UniversityRolGame
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Conexion c = new Conexion();
        Alumno a = new Alumno();
        Alumno[] arr = new Alumno[tam];
        const int tam = 100;
        string sql = "";
        string user = "";
        

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            int cont = 0;
            c.leerTabla("Alumnos");
            while (c.pDataReader.Read())
            {
                a.pUsuario = c.pDataReader.GetString(0);
                a.pContraseña = c.pDataReader.GetString(1);
            }

            arr[cont] = a;
            cont++;

            for (int i = 0; i < cont; i++)
            {
                if(a.pUsuario == txtLogUser.Text && a.pContraseña == txtLogPass.Text)
                {
                    if (a.pCategoria == 0)
                    {
                        Response.Redirect("Admin_index.aspx");
                    }
                    else
                    if(a.pCategoria == 1)
                    {
                        Response.Redirect("Alumno_index.aspx");
                        sesion();
                    }
                    else
                    {
                        Response.Redirect("Profesor_index.aspx");
                    }
                }else
                {
                    Response.Redirect("Login.aspx");
                }
            }

        }
        public void sesion()
        {
            sql = "SELECT ID_USUARIO FROM USUARIOS";
            if (sql == "") {
                user = "";
            }else{
                user = "SELECT NOMBRE, APELLIDO FROM USUARIOS WHERE ID_USUARIO = " + sql;
            }
        }
    }
}