using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Jonnier Grajales Alzate
06/09/2024
Almacenamiento de datos*/
namespace almacenamientoDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void msiTxt_Click(object sender, EventArgs e)
        {
            frmTxt frmTxt = new frmTxt();
            frmTxt.MdiParent = this;
            frmTxt.Show();
        }

        private void msiCsv_Click(object sender, EventArgs e)
        {
            frmCsv frmCsv = new frmCsv();
            frmCsv.MdiParent = this;
            frmCsv.Show();
        }

        private void msiXml_Click(object sender, EventArgs e)
        {
            frmXml frmXml = new frmXml();
            frmXml.MdiParent = this;
            frmXml.Show();
        }

        private void msiRtf_Click(object sender, EventArgs e)
        {
            frmRtf frmRtf = new frmRtf();
            frmRtf.MdiParent = this; 
            frmRtf.Show();
        }

    }
}
