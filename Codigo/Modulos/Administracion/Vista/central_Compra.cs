using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComprasVista
{
    public partial class central_Compra : Form
    {
       Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public central_Compra()
        {
            InitializeComponent();
            customizeDesing();

            Button [] apps = { btnCliente, btnProveedores, btnPedidos,btnVentas, btnFactura
            };
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(3001, apps[0]);
            cnseg.getAccesoApp(3002, apps[1]);
            cnseg.getAccesoApp(3111, apps[2]);
            cnseg.getAccesoApp(3108, apps[3]);
            cnseg.getAccesoApp(3107, apps[4]);



        }
        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelCompras.Visible = false;
            panelClientes.Visible = false;
            panel1.Visible = false;
           
        }

        private void hideSubMenu()
        {
            if (panelCompras.Visible == true)
                panelCompras.Visible = false;
            if (panelClientes.Visible == true)
                panelClientes.Visible = false;
            if (panel1.Visible == true)
                panel1.Visible = false;
            

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelCompras);

        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            //Codigo
            Clientes cl = new Clientes();
            cl.MdiParent = this;
            cl.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();


 
        }

        private void btnRecepción_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            //Codigo
            Proveedores p = new Proveedores();
            p.MdiParent = this;
            p.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnRequisiciones_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            //Codigo
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            //Codigo
          
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesCompras_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {


        }
            private void btnContactoClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnDay_Click(object sender, EventArgs e)
        {

        }

        private void btnReporteCliente_Click(object sender, EventArgs e)
        {
            //Codigo
          
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnComprobantesClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnMovimientosCLientes_Click(object sender, EventArgs e)
        {
            //Codigo
            Pedidos lp = new Pedidos();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnCajaClientes_Click(object sender, EventArgs e)
        {
            //Codigo
            FacturaVentas lp = new FacturaVentas();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(panel1);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            //Codigo
            
            //Ocultar submenu
            hideSubMenu();
        }




        private void btnCotizaciones_Click(object sender, EventArgs e)
        {
            //Codigo
            Form formCotizacionesVentas = new Form();
            formCotizacionesVentas.ShowDialog();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
 
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            //Codigo
           /* Form formMovimientosVentas = new Pedidos();
            formMovimientosVentas.ShowDialog();*/
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            //Codigo
           
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
 
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
           // showSubMenu(panel3);
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {

        }


        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            Ventas lp = new Ventas();
            lp.MdiParent = this;
            lp.Show();
            pictureBox2.Visible = false;
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMoviemientosProveedor_Click(object sender, EventArgs e)
        {
 
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Vista_Seguridad.Bitacora lp = new Vista_Seguridad.Bitacora();
            
            lp.Show();
            
            //Ocultar submenu
            hideSubMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
