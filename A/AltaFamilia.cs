using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class AltaFamilia : Form
    {


        Familia flia = new Familia();
        string nombre = "";
        public AltaFamilia(string pOrigen)
        {
            if (pOrigen == "M")
            {
                nombre = "Probando si funka";
            }
          

            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            flia.nombre = txtNombre.Text;
            flia.apellido = txtApellido.Text;
            flia.parentesco = txtParentesco.Text;
            flia.ocupacion = txtOcupacion.Text;

            flia.agregarFAmilia(flia);

            this.Close();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
