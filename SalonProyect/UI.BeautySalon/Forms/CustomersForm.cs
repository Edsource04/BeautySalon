using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Repository.Data;
using Domain.Models;
using Domain.Extensions;
 


using System.Windows.Forms;

namespace UI.BeautySalon
{
    public partial class CustomersForm : Form
    {
        private int idCodigo { get; set; } 
        public CustomersForm()
        {
            InitializeComponent();
           

        }
   
      
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            

          
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //this.menuprincipal.Show();
           
        }
        private void button3_Click(object sender, EventArgs e)
        { 
                
        }
        
        private void GetArticulosDataDataGrivParticipante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Productos_Load(object sender, EventArgs e)
        {
            //GetParticipanteAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
             
               
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //Missing Implementation of Validation Before Insert a Client

            using (SalonUnitWorker db = new SalonUnitWorker(new SalonContext()))
            {
                Client newClient = new Client();
                newClient.FirstName = txtName.Text;
                newClient.LastName = txtFull_Name.Text;
                newClient.Address = txtAddress.Text;
                newClient.Birthday = BirthDate.Value;
                newClient.DocumentType = CboTypeDocument.Text;
                newClient.DocumentNumber = txtNumberDocument.Text;
                newClient.Telephone = txtTel.Text;
                newClient.Email = txtMail.Text;
                newClient.Gender = CboSex.Text;
                newClient.ClientCode = newClient.GetClientCode();
                newClient.HostName = DatabaseInfo.GetServerNameFromConfiguration();
                db.Clients.Add(newClient);
                db.JobDone();

                AlertSuccess inserted = new AlertSuccess("El Cliente Has Sido Ingresado Correctamente");
                inserted.ShowDialog();
            }
        }
    }
}
