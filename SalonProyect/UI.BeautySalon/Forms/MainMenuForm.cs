using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI.BeautySalon
{ 
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
          
            InitializeComponent();
            btnCustomers.Enabled = true;
        }
  
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 207;
            }
            else
                MenuVertical.Width = 250;
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
        //    Login l = new Login();
        //    l.Show();
        //    Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CustomersForm());
            //btnEstudiante.Enabled = false;


        }

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Central_Pane_Form());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Seccion s = Seccion.Instance;
            //lbluser.Text = s.Usuario.ToUpper();
            //lblcorreo.Text = s.correo.ToUpper();

            btnlogoInicio_Click(null, e);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
           

            //if (btnCustomers.Enabled == false)
            //{
            //    btnCustomers.Enabled = true;
            //}


            AbrirFormInPanel(new ProviderForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CustomersForm());
        }
    }
}
