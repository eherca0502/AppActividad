using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppActividad
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado =new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlmacenarRegistro_Click(object sender, EventArgs e)
        {
            //Valida que se ingrese un dato
            if(txtNombre.Text =="")
            {
                error1.SetError(txtNombre, "Debe ingresar un nombre");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            //Validar que solo permita ingresar datos numericos
            decimal AsignacionDia;
            if(!Decimal.TryParse(txtAsignaciondia.Text, out AsignacionDia))
            {
                error1.SetError(txtAsignaciondia, "Debe ingresar un numero");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtAsignaciondia, "");


            myEmpleado.Nombre =txtNombre.Text;
            myEmpleado.Identificacion = txtIdentificacion.Text;
            myEmpleado.AsignacionDia =Convert.ToDecimal(txtAsignaciondia.Text);
            myNomina.DiasLaborados =Convert.ToInt32(txtDiaslaborados.Text);
            MessageBox.Show("Se guardo el registro correctamente");

        }

        private void btnCalcularSalario_Click(object sender, EventArgs e)
        {
            txtTotalDevengado.Text =myNomina.CalcularNomina(Convert.ToInt32(myNomina.DiasLaborados),Convert.ToDecimal(myEmpleado.AsignacionDia)).ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIdentificacion.Clear();
            txtAsignaciondia.Clear();
            txtDiaslaborados.Clear();
            txtTotalDevengado.Clear();
        }
    }
}
