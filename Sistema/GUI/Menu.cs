using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.GUI
{
    public partial class Menu : Form
    {
        SessionManager.Session _Sesion = SessionManager.Session.Instancia;

        //Muestra sólo los labels de Descripcion y Menu para el evento mouseEnter
        //También pone el focus en el botón que activó el evento
        void soloLabels(Object send, String lblMen, String lblDesc)
        {
            Button btn = (Button)send;
            btn.Focus();
            lblDescripcion.Text = lblDesc;
            lblMenu.Text = lblMen;
            flpGestiones.Visible = false;
            flpReportes.Visible = false;
            lblMenu.Visible = true;
            lblDescripcion.Visible = true;
        }

        //Muestra sólo los labels de Descripcion y Menu para el evento Enter
        //que se activa con el tab
        void soloLabels(String lblMen, String lblDesc)
        {
            lblDescripcion.Text = lblDesc;
            lblMenu.Text = lblMen;
            flpGestiones.Visible = false;
            flpReportes.Visible = false;
            lblMenu.Visible = true;
            lblDescripcion.Visible = true;
        }

        //Muestra sólo el FlowLayout con las gestiones
        void soloGestiones()
        {
            flpGestiones.Visible = true;

            if (!_Sesion.oUsuario.verificarPermiso("PERMISOS"))
            {
                btnGestionPermisos.Visible = false;
            }

            flpReportes.Visible = false;
            lblMenu.Visible = false;
            lblDescripcion.Visible = false;
        }

        //Muestra sólo el FlowLayout con los reportes
        void soloReportes()
        {
            flpReportes.Visible = true;

            if (!_Sesion.oUsuario.verificarPermiso("CONSTANCIAS"))
            {
                button6.Visible = false;
            }

            flpGestiones.Visible = false;
            lblMenu.Visible = false;
            lblDescripcion.Visible = false;
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (!_Sesion.oUsuario.verificarPermiso("REPORTES"))
            {
                btnReportes.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("COMPRAS"))
            {
                btnCompras.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("VENTAS"))
            {
                btnVentas.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("INVENTARIOS"))
            {
                btnInventarios.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("GESTIONES"))
            {
                btnGestiones.Visible = false;
            }
            if (!_Sesion.oUsuario.verificarPermiso("CONSULTAS"))
            {
                btnConsultas.Visible = false;
            }
        }

        //-------MOUSE ENTER

        private void btnConsultas_MouseEnter(object sender, EventArgs e)
        {
            soloLabels(
                sender, 
                "Consultas", 
                "Gestión de las consultas y procedimientos. Muestra cada una de las " +
                "consultas registradas, se pueden filtrar dependiendo del campo necesario." +
                " También se puede agregar más consultas o procedimientos a realizar. " +
                "\n\nClic para abrir.");
        }

        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            soloLabels(
                sender, 
                "Ventas", 
                "Gestión de las ventas. Muestra cada una de las ventas registradas, " +
                "se pueden filtrar dependiendo del campo necesario. También se puede " +
                "realizar más ventas. \n\nClic para abrir.");
        }

        private void btnGestiones_MouseEnter(object sender, EventArgs e)
        {
            soloLabels(
                sender, 
                "Gestiones",
                "Gestión de las entidades del sistema. Muestra cada grupo " +
                "de registros que pueden ser modificados de alguna manera, " +
                "ya sea con inserciones, con modificaciones o con eliminaciones. " +
                "\n\nClic para mostrar cada gestión.");
        }

        private void btnCompras_MouseEnter(object sender, EventArgs e)
        {
            soloLabels(
                sender,
                "Compras",
                "Gestión de las ventas. Puede ver las ventas registradas, registrar nuevas y" +
                " ver el detalle de cada una de ellas. \n\nClic para abrir.");
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            soloLabels(
                sender, 
                "Reportes", 
                "Gestión de los reportes y constancias que se pueden generar. " +
                "\n\nClic mostrar cada tipo de registro.");
        }

        private void btnInventarios_MouseEnter(object sender, EventArgs e)
        {
            soloLabels(
                sender,
                "Inventarios",
                "Puede ver todas las existencias de los productos en los inventarios," +
                " aparte de ver los detalles de cada uno" +
                "\n\nClic para abrir.");
        }



        //-------ENTER

        private void btnConsultas_Enter(object sender, EventArgs e)
        {
            soloLabels(
                "Consultas", 
                "Gestión de las consultas y procedimientos. Muestra cada una de las consultas registradas, " +
                "se pueden filtrar dependiendo del campo necesario. También se puede agregar más consultas o " +
                "procedimientos a realizar. Clic para abrir.");
        }

        private void btnVentas_Enter(object sender, EventArgs e)
        {
            soloLabels(
                "Ventas", 
                "Gestión de las ventas. Muestra cada una de las ventas registradas, se pueden filtrar " +
                "dependiendo del campo necesario. También se puede realizar más ventas. \n\nClic para abrir.");
        }

        private void btnGestiones_Enter(object sender, EventArgs e)
        {
            soloLabels(
                "Gestiones", 
                "Gestión de las entidades del sistema. Muestra cada grupo de registros " +
                "que pueden ser modificados de alguna manera, ya sea con inserciones, con " +
                "modificaciones o con eliminaciones. \n\nClic para mostrar cada gestión.");
        }

        private void btnCompras_Enter(object sender, EventArgs e)
        {
            soloLabels(
                "Compras", 
                "Gestión de las ventas. Puede ver las ventas registradas, registrar nuevas y" +
                " ver el detalle de cada una de ellas. \n\nClic para abrir.");
        }

        private void btnReportes_Enter(object sender, EventArgs e)
        {
            soloLabels(
                "Reportes",
                "Gestión de los reportes y constancias que se pueden generar. " +
                "\n\nClic mostrar cada tipo de registro.");
        }

        private void btnInventarios_Enter(object sender, EventArgs e)
        {
            soloLabels(
                "Inventarios",
                "Puede ver todas las existencias de los productos en los inventarios," +
                " aparte de ver los detalles de cada uno" +
                "\n\nClic para abrir.");
        }


        //-------CLICK



        private void btnReportes_Click(object sender, EventArgs e){ soloReportes(); }

        private void btnGestiones_Click(object sender, EventArgs e) { soloGestiones(); }

        private void btnGestionMedicos_Click(object sender, EventArgs e)
        {
            General.GUI.Medicos.GestionMedicos f = new General.GUI.Medicos.GestionMedicos();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionEspecialidades_Click(object sender, EventArgs e)
        {
            General.GUI.Especialidades.GestionEspecialidades f = new General.GUI.Especialidades.GestionEspecialidades();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionOpciones_Click(object sender, EventArgs e)
        {
            General.GUI.Opciones.GestionOpciones f = new General.GUI.Opciones.GestionOpciones();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionPermisos_Click(object sender, EventArgs e)
        {
            General.GUI.Permisos.GestionPermisos f = new General.GUI.Permisos.GestionPermisos();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionCargos_Click(object sender, EventArgs e)
        {
            General.GUI.Cargos.GestionCargos f = new General.GUI.Cargos.GestionCargos();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionPacientes_Click(object sender, EventArgs e)
        {
            General.GUI.Pacientes.GestionPacientes f = new General.GUI.Pacientes.GestionPacientes();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionRoles_Click(object sender, EventArgs e)
        {
            General.GUI.Roles.GestionRoles f = new General.GUI.Roles.GestionRoles();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionUsuarios_Click(object sender, EventArgs e)
        {
            General.GUI.Usuarios.GestionUsuarios f = new General.GUI.Usuarios.GestionUsuarios();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionEmpleados_Click(object sender, EventArgs e)
        {
            General.GUI.Empleados.GestionEmpleados f = new General.GUI.Empleados.GestionEmpleados();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            General.GUI.Constancias.CapDatIncapacidad f = new General.GUI.Constancias.CapDatIncapacidad();
            //f.ShowDialog();
            //this.Close();
            //f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            General.GUI.ReportVentas.CapDatReporteVentas f = new General.GUI.ReportVentas.CapDatReporteVentas();
            f.Show();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            General.GUI.Operaciones.GestionConsultas f = new General.GUI.Operaciones.GestionConsultas();
            f.btnRegConsulta.Visible = true;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            General.GUI.Ventas.GestionVentas f = new General.GUI.Ventas.GestionVentas();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            General.GUI.Compras.GestionCompras f = new General.GUI.Compras.GestionCompras();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnInventarios_Click(object sender, EventArgs e)
        {
            General.GUI.Inventarios.GestionInventarios f = new General.GUI.Inventarios.GestionInventarios();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionConsumibles_Click(object sender, EventArgs e)
        {
            General.GUI.Consumibles.GestionConsumibles f = new General.GUI.Consumibles.GestionConsumibles();
            f.Todos = true;
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionMarcas_Click(object sender, EventArgs e)
        {
            General.GUI.Marcas.GestionMarcas f = new General.GUI.Marcas.GestionMarcas();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void btnGestionLaboratorios_Click(object sender, EventArgs e)
        {
            General.GUI.Proveedores.GestionProveedores f = new General.GUI.Proveedores.GestionProveedores();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            General.GUI.ReportCompras.CapDatReporteCompras f = new General.GUI.ReportCompras.CapDatReporteCompras();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            General.GUI.ReportInventario.CapDatInventarios f = new General.GUI.ReportInventario.CapDatInventarios();
            f.Show();
        }
    }
}
