using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace almacenamientoDeDatos
{
    public partial class frmTxt : Form
    {
        string gArchivoTxt = Environment.CurrentDirectory + "\\archivotxt.txt";

        public frmTxt()
        {
            InitializeComponent();
        } 
        private void btnCrear_Click(object sender, EventArgs e)
        {
            List<person> oPersonas = new List<person>(); 
            if (File.Exists(gArchivoTxt))
            {
                using (StreamReader sr = new StreamReader(gArchivoTxt))
                {
                    string lcLinea;
                    while ((lcLinea = sr.ReadLine()) != null)
                    {
                        string[] laCampos = lcLinea.Split(',');
                        oPersonas.Add(new person
                        {
                            id = int.Parse(laCampos[0]),
                            nombre = laCampos[1],
                            edad = int.Parse(laCampos[2])
                        });
                    }
                }
            } 
            int lnId = int.Parse(txtId.Text);
            if (oPersonas.Any(p => p.id == lnId))
            {
                MessageBox.Show("Ya hay un registro con ese ID");
                return;
            } 
            string lcNombre = txtNombre.Text;
            int lnEdad = int.Parse(txtEdad.Text);
            oPersonas.Add(new person() { id = lnId, nombre = lcNombre, edad = lnEdad }); 
            using (StreamWriter sw = new StreamWriter(gArchivoTxt, false))
            {
                foreach (var tcPersona in oPersonas)
                {
                    sw.WriteLine($"{tcPersona.id},{tcPersona.nombre},{tcPersona.edad}");
                }
            }

            MessageBox.Show("Registro agregado.");
        }
         
        private void btnLeer_Click(object sender, EventArgs e)
        {
            List<person> oPersonas = new List<person>(); 
            if (File.Exists(gArchivoTxt))
            {
                using (StreamReader sr = new StreamReader(gArchivoTxt))
                {
                    string lcLinea;
                    while ((lcLinea = sr.ReadLine()) != null)
                    {
                        string[] laCampos = lcLinea.Split(',');
                        oPersonas.Add(new person
                        {
                            id = int.Parse(laCampos[0]),
                            nombre = laCampos[1],
                            edad = int.Parse(laCampos[2])
                        });
                    }
                } govRegistros.DataSource = oPersonas;
            }
            else
            {
                MessageBox.Show("El archivo TXT no existe.");
            }
        } 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            List<person> oPersonas = new List<person>(); 
            if (File.Exists(gArchivoTxt))
            {
                using (StreamReader sr = new StreamReader(gArchivoTxt))
                {
                    string lcLinea;
                    while ((lcLinea = sr.ReadLine()) != null)
                    {
                        string[] laCampos = lcLinea.Split(',');
                        oPersonas.Add(new person
                        {
                            id = int.Parse(laCampos[0]),
                            nombre = laCampos[1],
                            edad = int.Parse(laCampos[2])
                        });
                    }
                } 
                int lnId = int.Parse(txtId.Text);
                var lcPersonaEliminar = oPersonas.FirstOrDefault(p => p.id == lnId);

                if (lcPersonaEliminar != null)
                {
                    oPersonas.Remove(lcPersonaEliminar); 
                    using (StreamWriter sw = new StreamWriter(gArchivoTxt, false))
                    {
                        foreach (var tcPersona in oPersonas)
                        {
                            sw.WriteLine($"{tcPersona.id},{tcPersona.nombre},{tcPersona.edad}");
                        }
                    }

                    MessageBox.Show("Registro eliminado.");
                }
                else
                {
                    MessageBox.Show("No hay registros con ese ID");
                }
            }
            else
            {
                MessageBox.Show("El archivo TXT no existe.");
            }
        } 
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            List<person> oPersonas = new List<person>(); 
            if (File.Exists(gArchivoTxt))
            {
                using (StreamReader sr = new StreamReader(gArchivoTxt))
                {
                    string lcLinea;
                    while ((lcLinea = sr.ReadLine()) != null)
                    {
                        string[] laCampos = lcLinea.Split(',');
                        oPersonas.Add(new person
                        {
                            id = int.Parse(laCampos[0]),
                            nombre = laCampos[1],
                            edad = int.Parse(laCampos[2])
                        });
                    }
                } 
                int lnId = int.Parse(txtId.Text);
                var lcPersonaActualizar = oPersonas.FirstOrDefault(p => p.id == lnId);

                if (lcPersonaActualizar != null)
                { 
                    lcPersonaActualizar.nombre = txtNombre.Text;
                    lcPersonaActualizar.edad = int.Parse(txtEdad.Text); 
                    using (StreamWriter sw = new StreamWriter(gArchivoTxt, false))
                    {
                        foreach (var tcPersona in oPersonas)
                        {
                            sw.WriteLine($"{tcPersona.id},{tcPersona.nombre},{tcPersona.edad}");
                        }
                    }

                    MessageBox.Show("Registro actualizado.");
                }
                else
                {
                    MessageBox.Show("No hay registros con ese ID");
                }
            }
            else
            {
                MessageBox.Show("El archivo TXT no existe.");
            }
        }
    }
}