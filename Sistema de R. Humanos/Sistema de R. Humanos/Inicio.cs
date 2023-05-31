using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_R.Humanos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            DiseñoPersonalizado();
        }
        private void DiseñoPersonalizado() //OCULTAMOS PANELES CON SU CONTENIDO
        {
            panelExpedienteSubMenu.Visible = false;
            panelEmpleadoSubMenu.Visible = false;
            panelDepartamentoSubMenu1.Visible = false;
            panelDepartamentoSubMenu2.Visible = false;
        }
        private void OcultarSubMenu() // METODO QUE OCULTA SUBMENUS
        {
            if (panelExpedienteSubMenu.Visible == true)
            panelExpedienteSubMenu.Visible = false;
            if (panelEmpleadoSubMenu.Visible == true)
                panelEmpleadoSubMenu.Visible = false;
            if (panelDepartamentoSubMenu1.Visible == true)
                panelDepartamentoSubMenu1.Visible = false;
            if (panelDepartamentoSubMenu2.Visible == true)
                panelDepartamentoSubMenu2.Visible = false;
        }
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelExpedienteSubMenu);
        }

        private void btnNuevoExpediente_Click(object sender, EventArgs e)
        {
            Form nuevoExpediente = new Nuevo_expediente();
            nuevoExpediente.Show();
            OcultarSubMenu();
        }

        private void btnExpedientesAnteriores_Click(object sender, EventArgs e)
        {
            Form expedientesAnteriores = new Expedientes_anteriores();
            expedientesAnteriores.Show();
        }
        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelEmpleadoSubMenu);
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            Form agregarEmpleado = new Agregar_empleado();
            agregarEmpleado.Show();
        }

        private void btnVerEmpleados_Click(object sender, EventArgs e)
        {
            Form verEmpleado = new Ver_empleados();
            verEmpleado.Show();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelDepartamentoSubMenu1);
        }

        private void btnH_CabildoRegidores_Click(object sender, EventArgs e)
        {
            Form hCabildoRegidores = new H_Cabildo_Regidores();
            hCabildoRegidores.Show();
        }
        private void btnPresidenteMunicipal1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelDepartamentoSubMenu2);
        }
        private void btnPresidenteMunicipal2_Click(object sender, EventArgs e)
        {
            Form presidenteMunicipal = new Presidente_municipal();
            presidenteMunicipal.Show();
        }

        private void btnSecretariaGeneral_Click(object sender, EventArgs e)
        {
            Form secretariaGeneral = new Secretaria_general();
            secretariaGeneral.Show();
        }

        private void btnTesoreriaMunicipal_Click(object sender, EventArgs e)
        {
            Form tesoreriaMunicipal = new Tesoreria_municipal();
            tesoreriaMunicipal.Show();
        }

        private void btnDireccionGeneralSC_Click(object sender, EventArgs e)
        {
            Form direccionGeneralSC = new Direccion_general_de_S_C();
            direccionGeneralSC.Show();
        }

        private void btnContraloriaMunipal_Click(object sender, EventArgs e)
        {
            Form contraloriaMunicipal = new Contraloria_municipal();
            contraloriaMunicipal.Show();
        }
    }
}
