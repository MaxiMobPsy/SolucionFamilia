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
        
        string origen = "";
        public AltaFamilia(string pOrigen, string pIdFamilia)
        {
            if (pOrigen == "M")
            {
                origen = pIdFamilia;
                flia.obtenerFamilia(pIdFamilia);

            }
          

            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            txtNombre.Text = flia.nombre;
            txtApellido.Text = flia.apellido;
            txtParentesco.Text = flia.parentesco;
            txtOcupacion.Text = flia.ocupacion;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            flia.nombre = txtNombre.Text;
            flia.apellido = txtApellido.Text;
            flia.parentesco = txtParentesco.Text;
            flia.ocupacion = txtOcupacion.Text;

            if (origen == "")
            {
                flia.agregarFAmilia(flia);
            }
            else
            {
                flia.actualizarFamilia(flia, origen);

            }
            this.Close();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
