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
    public partial class Update : System.Web.UI.Page
    {
        static List<Universidad> universidades = new List<Universidad>();

        int carnet;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                leer();
            }
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

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            foreach (var i in universidades)
            {
                int actualizarAlumno = i.alumnos.FindIndex(c => c.numeroCarnet == carnet);
                if (actualizarAlumno > -1)
                {
                    i.alumnos[actualizarAlumno].nombre = txtNombre.Text;
                    i.alumnos[actualizarAlumno].apellido = txtApellido.Text;

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