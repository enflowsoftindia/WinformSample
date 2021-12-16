using DataEntity.Data;
using DataEntity.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindUserDataIngrid();
        }

        private void btnSave_click(object sender, EventArgs e)
        {
            tbl_users user = new tbl_users()
            {
                Firstname = txtFirstName.Text,
                Lastname = txtLastName.Text,
                Address = txtAddress.Text,
                userid = Guid.NewGuid(),
            };

            if (UserRepository.SaveUser(user))
            {
                InitializeComponent();
                BindUserDataIngrid();
               
            }

        }

        private void BindUserDataIngrid()
        {
            var users = UserRepository.GetUsers();
            dgUsers.Refresh();
            dgUsers.DataSource = users;
            dgUsers.Refresh(); 
        }
    }
}
