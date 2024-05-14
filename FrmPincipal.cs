using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaErapa4
{
    public partial class FrmPincipal : Form
    {
        public FrmPincipal()
        {
            InitializeComponent();
        }
        //Listado
        List<clsVehiculos> ListadoDeVehiculos = new List<clsVehiculos>();
        clsVehiculos objAuto = new clsVehiculos(); clsVehiculos objAvion = new clsVehiculos(); clsVehiculos objBarco = new clsVehiculos();
        bool Auto  = false; bool Avion = false; bool Barco = false;
        private void FrmPincipal_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculos(); objAvion = new clsVehiculos(); objBarco = new clsVehiculos();
        }

        private void btnBarco_Click(object sender, EventArgs e)
        {
            objBarco.CrearBarco();
            objBarco.pctBarco.Location = new Point(220, -25);
            Controls.Add(objBarco.pctBarco);
            Barco = true;
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            LstListadoDeVehiculos.Items.Clear();
            ListadoDeVehiculos.Clear();
            ListadoDeVehiculos.Add(objBarco);
            foreach (clsVehiculos vehiculos in ListadoDeVehiculos)
            {
                LstListadoDeVehiculos.Items.Add(vehiculos.TipoDeVehiculo);
            }
        }

        private void BtnAvion_Click(object sender, EventArgs e)
        {
            objAvion.CrearAvion();
            objAvion.pctAvion.Location = new Point(90, -20);
            Controls.Add(objAvion.pctAvion);
            Avion = true;
            if (Auto == true)
            {
                objAuto.pctAuto.Dispose();
                Auto = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
            }
            LstListadoDeVehiculos.Items.Clear();
            ListadoDeVehiculos.Clear();
            ListadoDeVehiculos.Add(objAvion);
            foreach (clsVehiculos vehiculos in ListadoDeVehiculos)
            {
                LstListadoDeVehiculos.Items.Add(vehiculos.TipoDeVehiculo);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            objAuto.CrearAuto();
            objAuto.pctAuto.Location = new Point(-5,-20);
            Controls.Add(objAuto.pctAuto);
            Auto = true;
            if (Avion == true)
            {
                objAvion.pctAvion.Dispose();
                Avion = false;
            }
            if (Barco == true)
            {
                objBarco.pctBarco.Dispose();
                Barco = false;
            }
            LstListadoDeVehiculos.Items.Clear();
            ListadoDeVehiculos.Clear();
            ListadoDeVehiculos.Add(objAuto);
            foreach(clsVehiculos vehiculos in ListadoDeVehiculos)
            {
                LstListadoDeVehiculos.Items.Add(vehiculos.TipoDeVehiculo);
            }
        }
        private void BtnListar_Click(object sender, EventArgs e)
        {
            ListadoDeVehiculos.Clear();
            LstListadoDeVehiculos.Items.Clear();

            objAuto.CrearAuto();
            ListadoDeVehiculos.Add(objAuto);

            objAvion.CrearAvion();
            ListadoDeVehiculos.Add(objAvion);


            objBarco.CrearBarco();
            ListadoDeVehiculos.Add(objBarco);
            foreach (clsVehiculos vehiculos in ListadoDeVehiculos)
            {
                LstListadoDeVehiculos.Items.Add(vehiculos.TipoDeVehiculo);
            }
        }
    }
}
