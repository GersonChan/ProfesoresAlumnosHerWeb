using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProfesoresAlumnosHerWeb
{
    public partial class _Default : Page
    {
        static List<Alumno> alumnostem = new List<Alumno>();
        static List<Nota> notasTemp = new List<Nota>();
        static List<Universidad> universidades = new List<Universidad>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/Datos.json");
            string json = JsonConvert.SerializeObject(universidades);
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Alumno alumnoTemp = new Alumno();
            alumnoTemp.nombre = txtNombre.Text;
            alumnoTemp.apellido = txtApellido.Text;
            alumnoTemp.numeroCarnet = Convert.ToInt16(txtCarnet.Text);
            alumnoTemp.notas = notasTemp.ToArray().ToList();

            alumnostem.Add(alumnoTemp);

            notasTemp.Clear();

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCarnet.Text = "";
            txtNota.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nota notas = new Nota();
            notas.curso = txtCurso.Text;
            notas.punteo = Convert.ToInt16(txtNota.Text);
            notasTemp.Add(notas);

            GridView1.DataSource = notasTemp;
            GridView1.DataBind();

            txtNota.Text = "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Universidad universidadTemp = new Universidad();
            universidadTemp.nombre = DropDownList1.SelectedValue;
            universidadTemp.sede = DropDownList2.SelectedValue;
            universidadTemp.alumnos = alumnostem.ToArray().ToList();

            universidades.Add(universidadTemp);
            guardar();
            alumnostem.Clear();
        }
    }
}