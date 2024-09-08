using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Linq;

namespace almacenamientoDeDatos
{
    public partial class frmXml : Form
    {
        string gArchivoXml = Environment.CurrentDirectory + "\\datosxml.xml"; 

        public frmXml()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        { 
            List<person> oPersonas = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
 
            if (File.Exists(gArchivoXml)) {
                using (FileStream fs = new FileStream(gArchivoXml, FileMode.Open, FileAccess.Read))
                {
                    oPersonas = serial.Deserialize(fs) as List<person>;
                }
            }
 
            int lnId = int.Parse(txtId.Text);
            string lcNombre = txtNombre.Text;
            int lnEdad = int.Parse(txtEdad.Text);
 
            var lcPersonasExistente = oPersonas.FirstOrDefault(p => p.id == lnId);

            if (lcPersonasExistente != null)
            { 
                MessageBox.Show("Ese id ya se ha utilizado.");
                return;
            }
             
            oPersonas.Add(new person() { id = lnId, nombre = lcNombre, edad = lnEdad });
 
            using (FileStream fs = new FileStream(gArchivoXml, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, oPersonas);
                MessageBox.Show("Registro agregado.");
            }

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<person> oPersonas = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
 
            if (File.Exists(gArchivoXml))
            {
                using (FileStream fs = new FileStream(gArchivoXml, FileMode.Open, FileAccess.Read))
                {
                    oPersonas = serial.Deserialize(fs) as List<person>;
                }
                govRegistros.DataSource = oPersonas;
            }
            else
            {
                MessageBox.Show("El archivo XML no existe.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<person> oPersonas = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
 
            if (File.Exists(gArchivoXml))
            { 
                using (FileStream fs = new FileStream(gArchivoXml, FileMode.Open, FileAccess.Read))
                {
                    oPersonas = serial.Deserialize(fs) as List<person>;
                }
 
                int lnId = int.Parse(txtId.Text);

                var lcPersonaEliminar = oPersonas.FirstOrDefault(p => p.id == lnId);

                if (lcPersonaEliminar != null)
                {
                    oPersonas.Remove(lcPersonaEliminar);
                    using (FileStream fs = new FileStream(gArchivoXml, FileMode.Create, FileAccess.Write))
                    {
                        serial.Serialize(fs, oPersonas);
                    }

                    MessageBox.Show("Registro eliminado.");
                }
                else
                {
                    MessageBox.Show("No hay registro con el id ingresado.");
                }
            }
            else
            {
                MessageBox.Show("El archivo XML no existe.");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        { 
                List<person> oPersonas = new List<person>();
                XmlSerializer serial = new XmlSerializer(typeof(List<person>));

                if (File.Exists(gArchivoXml))
                {
                    using (FileStream fs = new FileStream(gArchivoXml, FileMode.Open, FileAccess.Read))
                    {
                        oPersonas = serial.Deserialize(fs) as List<person>;
                    }

                    int lnId = int.Parse(txtId.Text);
                    var lcPersonaActualizar = oPersonas.FirstOrDefault(p => p.id == lnId);

                    if (lcPersonaActualizar != null)
                    {
                        lcPersonaActualizar.nombre = txtNombre.Text;
                        lcPersonaActualizar.edad = int.Parse(txtEdad.Text);

                        using (FileStream fs = new FileStream(gArchivoXml, FileMode.Create, FileAccess.Write))
                        {
                            serial.Serialize(fs, oPersonas);
                        }

                        MessageBox.Show("Registro actualizado.");
                    }
                    else
                    {
                        MessageBox.Show("No hay registro con el id ingresado.");
                }
            }
        }

    }
}
