using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.BeautySalon
{
    public partial class Central_Pane_Form : Form
    {
        public Central_Pane_Form()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

   
        private void btnCustomersCentral_Panel_Click(object sender, EventArgs e)
        {
            MainMenu m = new MainMenu();
            // m.GetForm.btnCustomersCentral_Panel_Click(null,e);
           

        } 
      
    }
}
