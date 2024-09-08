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
        string xmlArchivo = Environment.CurrentDirectory + "\\datosxml.xml"; 

        public frmXml()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        { 
            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
 
            if (File.Exists(xmlArchivo)) {
                using (FileStream fs = new FileStream(xmlArchivo, FileMode.Open, FileAccess.Read))
                {
                    p1 = serial.Deserialize(fs) as List<person>;
                }
            }
 
            int lnId = int.Parse(txtId.Text);
            string lcNombre = txtNombre.Text;
            int lnEdad = int.Parse(txtEdad.Text);
 
            var lcPersonaExistente = p1.FirstOrDefault(p => p.id == lnId);

            if (lcPersonaExistente != null)
            { 
                MessageBox.Show("Ese id ya se ha utilizado.");
                return;
            }
             
            p1.Add(new person() { id = lnId, nombre = lcNombre, edad = lnEdad });
 
            using (FileStream fs = new FileStream(xmlArchivo, FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, p1);
                MessageBox.Show("Registro agregado.");
            }

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
 
            if (File.Exists(xmlArchivo))
            {
                using (FileStream fs = new FileStream(xmlArchivo, FileMode.Open, FileAccess.Read))
                {
                    p1 = serial.Deserialize(fs) as List<person>;
                }
                govRegistros.DataSource = p1;
            }
            else
            {
                MessageBox.Show("El archivo XML no existe.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<person> p1 = new List<person>();
            XmlSerializer serial = new XmlSerializer(typeof(List<person>));
 
            if (File.Exists(xmlArchivo))
            { 
                using (FileStream fs = new FileStream(xmlArchivo, FileMode.Open, FileAccess.Read))
                {
                    p1 = serial.Deserialize(fs) as List<person>;
                }
 
                int lnId = int.Parse(txtId.Text);

                var lcPersonaEliminar = p1.FirstOrDefault(p => p.id == lnId);

                if (lcPersonaEliminar != null)
                {
                    p1.Remove(lcPersonaEliminar);
                    using (FileStream fs = new FileStream(xmlArchivo, FileMode.Create, FileAccess.Write))
                    {
                        serial.Serialize(fs, p1);
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
                List<person> p1 = new List<person>();
                XmlSerializer serial = new XmlSerializer(typeof(List<person>));

                if (File.Exists(xmlArchivo))
                {
                    using (FileStream fs = new FileStream(xmlArchivo, FileMode.Open, FileAccess.Read))
                    {
                        p1 = serial.Deserialize(fs) as List<person>;
                    }

                    int lnId = int.Parse(txtId.Text);
                    var lcPersonaActualizar = p1.FirstOrDefault(p => p.id == lnId);

                    if (lcPersonaActualizar != null)
                    {
                        lcPersonaActualizar.nombre = txtNombre.Text;
                        lcPersonaActualizar.edad = int.Parse(txtEdad.Text);

                        using (FileStream fs = new FileStream(xmlArchivo, FileMode.Create, FileAccess.Write))
                        {
                            serial.Serialize(fs, p1);
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
