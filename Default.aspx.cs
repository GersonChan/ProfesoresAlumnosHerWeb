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
        static List<Alumno> alumnos = new List<Alumno>();
        static List<int> notasTemp = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leer();
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/Datos.json");
            string json = JsonConvert.SerializeObject(alumnos);
            System.IO.File.WriteAllText(archivo, json);
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/Datos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            alumnos = JsonConvert.DeserializeObject<List<Alumno>>(json);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Alumno alumnoTemp = new Alumno();
            alumnoTemp.nombre = TextBox1.Text;
            alumnoTemp.apellido = TextBox2.Text;
            alumnoTemp.numeroCarnet = Convert.ToInt16(TextBox3.Text);
            alumnoTemp.numeroNotas = notasTemp;

            alumnos.Add(alumnoTemp);

            guardar();

            notasTemp.Clear();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int nota = Convert.ToInt16(TextBox4.Text);
            notasTemp.Add(nota);

            GridView1.DataSource = notasTemp;
            GridView1.DataBind();

            TextBox4.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            leer();
            GridView2.DataSource = alumnos;
            GridView2.DataBind();
        }
    }
}