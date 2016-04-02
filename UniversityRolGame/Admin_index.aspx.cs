using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UniversityRolGame.Classes;


namespace UniversityRolGame
{
    public partial class Admin_index : System.Web.UI.Page
    {
        Conexion c = new Conexion();
        string sql = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            //controlar el id del usuario
           /* if(a.pUsuario != "Admin")//ver
            {
                Response.Redirect("Index.aspx");
            }
            */
        }
        public void btnCargarAlumno_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.pUsuario = txtUsuarioA.Text;
            a.pContraseña = txtContraseniaA.Text;
            a.pNombre = txtNombreA.Text;
            a.pApellido = txtApellidoA.Text;
            a.pLegajo = Convert.ToInt32(txtLegajoA.Text);
            a.pCategoria = Convert.ToInt32(ddlCategoriaA.Text);
            a.pCurso = Convert.ToInt32(ddlCursoA.Text);

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
        public void btnCargarProfesor_Click(object sender, EventArgs e)
        {
            Profesor p = new Profesor();
            p.pUsuario = txtUsuarioA.Text;
            p.pContraseña = txtContraseniaA.Text;
            p.pNombre = txtNombreA.Text;
            p.pApellido = txtApellidoA.Text;
            p.pLegajo = Convert.ToInt32(txtLegajoA.Text);
            p.pCategoria = Convert.ToInt32(ddlCategoriaA.Text);
            p.pCurso = Convert.ToInt32(ddlCursoA.Text);

            {
                sql = "INSERT INTO Profesores Values('" + p.pUsuario + "',"
                                                 + "'" + p.pContraseña + "',"
                                                 + "'" + p.pNombre + "',"
                                                 + "'" + p.pApellido + "',"
                                                 + p.pLegajo + ","
                                                 + p.pCategoria + ","
                                                 + p.pCurso + ")";
            }
        }
        public void btnCargarMision_Click(object sender, EventArgs e)
        {
            Mision q = new Mision();

            q.pNombre = txtNombreQ.Text;
            q.pDescripcion = txtDescripcionQ.Text;
            q.pOro = Convert.ToInt32(txtOroQ.Text);
            q.pXp = Convert.ToInt32(txtXpQ.Text);

            sql = "INSERT INTO QUESTS VALUES('" + q.pNombre + "'," +
                                              "'" + q.pDescripcion + "',"
                                              + q.pOro + ","
                                              + q.pXp + ")";
            c.consultar(sql);
        }
        public void btnCargarItems_Click(object sender, EventArgs e)
        {
            Item i = new Item();

            i.pNombre = txtNombreI.Text;
            i.pOro = Convert.ToInt32(txtOroI.Text);
            i.pXp = Convert.ToInt32(txtXpI.Text);

            sql = "INSERT INTO ITEMS VALUES('" + i.pNombre + "',"
                                              + i.pOro + ","
                                              + i.pXp + ")";
            c.consultar(sql);
        }
       /* public void buscarAlumno()
        {
            int legajo;
            legajo = Convert.ToInt32(txtLegBusqueda.Text);

            sql = "SELECT * FROM ALUMNOS WHERE LEGAJO = " + legajo;
            c.consultar(sql);

        }*/
        public void btnDeleteAlumno_Click(object sender, EventArgs e)
        {
            int legajo;
            legajo = Convert.ToInt32(txtLegEliminar.Text);
            if (legajo != 0)
            {
                sql = "DELETE ALUMNOS WHERE LEGAJO = " + legajo;
                c.consultar(sql);
            }
        }
        public void btnEditAlumno_Click(object sender, EventArgs e)
        {

        }
        public void btnCargaAlu_Click(object sender, EventArgs e)
        {
            cAlumno.Visible = true;
            cItem.Visible = false;
            cQuest.Visible = false;
            eAlumno.Visible = false;
            edAlumno.Visible = false;
        }
        public void btnCargaQuest_Click(object sender, EventArgs e)
        {
            cAlumno.Visible = false;
            cItem.Visible = false;
            cQuest.Visible = true;
            eAlumno.Visible = false;
            edAlumno.Visible = false;
        }
        public void btnCargaItem_Click(object sender, EventArgs e)
        {
            cAlumno.Visible = false;
            cItem.Visible = true;
            cQuest.Visible = false;
            eAlumno.Visible = false;
            edAlumno.Visible = false;
        }
        public void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            cAlumno.Visible = false;
            cItem.Visible = false;
            cQuest.Visible = false;
            eAlumno.Visible = true;
            edAlumno.Visible = false;
        }
        public void btnEditarAlumno_Click(object sender, EventArgs e)
        {
            cAlumno.Visible = false;
            cItem.Visible = false;
            cQuest.Visible = false;
            eAlumno.Visible = false;
            edAlumno.Visible = true;
        }

    }
}