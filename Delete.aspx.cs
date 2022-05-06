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
    public partial class Delete : System.Web.UI.Page
    {

        static List<Universidad> universidades = new List<Universidad>();

        int carnet;

        protected void Page_Load(object sender, EventArgs e)
        {
            leer();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            carnet = Convert.ToInt16(txtBuscar.Text);
            bool alumnoEncontrado = false;
            foreach (var i in universidades)
            {
                Alumno al = i.alumnos.Find(c => c.numeroCarnet == carnet);
                if (al != null)
                {
                    txtNombre.Text = al.nombre;
                    txtApellido.Text = al.apellido;
                    alumnoEncontrado = true;
                }
            }
            if (!alumnoEncontrado)
            {
                Response.Write("<script>alert('No se encotro al alumno')</script>");
                txtBuscar.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
        }

        private void leer()
        {
            string archivo = Server.MapPath("~/universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
        }

        protected void btnAlumno_Click(object sender, EventArgs e)
        {
            foreach (var i in universidades)
            {
                Alumno borrarAlumno = i.alumnos.Find(c => c.numeroCarnet == carnet);
                if (borrarAlumno != null)
                {
                    i.alumnos.Remove(borrarAlumno);
                    guardar();
                }
            }           
        }

        private void guardar()
        {
            string archivo = Server.MapPath("~/universidades.json");
            string json = JsonConvert.SerializeObject(universidades);
            System.IO.File.WriteAllText(archivo, json);
        }
    }
}