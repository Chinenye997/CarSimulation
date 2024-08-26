using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Formregister : Form
    {
        Register_dt register_Tbl = new Register_dt(); 
        public Formregister()
        {
            InitializeComponent();
        }
        private void Formregister_Load(object sender, EventArgs e)
        {
        }
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Registration_dbEntities1 registration_db = new Registration_dbEntities1();
            register_Tbl.Username = txtUsername.Text;
            register_Tbl.EmailAddress = txtEmailAddress.Text;
            register_Tbl.Password = txtPassword.Text;
            register_Tbl.ConfirmPassword = txtConfirmPassword.Text;
            register_Tbl.Name = txtName.Text;
            register_Tbl.Phone = txtPhone.Text;
            register_Tbl.Family = txtFamily.Text;
            register_Tbl.Mobile = txtMobile.Text;
            register_Tbl.BirthDate = txtBirthDate.Text;
            register_Tbl.BirthPlace = txtBirthPlace.Text;
            registration_db.Register_dt.Add(register_Tbl);
            registration_db.SaveChanges();

            MessageBox.Show("Data registered  Successfully");


            PopulateDataGridView();

         

        }

        private void PopulateDataGridView()
        {
            throw new NotImplementedException();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username:")
            {
               txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
               txtUsername.Text = "Username:";
            }
        }

        private void txtEmailAddress_Enter(object sender, EventArgs e)
        {
            if(txtEmailAddress.Text == "Email Address:")
            {
                txtEmailAddress.Text = "";
            }
        }

        private void txtEmailAddress_Leave(object sender, EventArgs e)
        {
            if(txtEmailAddress.Text == "")
            {
                txtEmailAddress.Text = "Email Address:";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password:")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password:";
            }
        }

        private void txtConfirmPassword_Enter(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text == "Confirm Password:")
            {
                txtConfirmPassword.Text = "";
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(txtConfirmPassword.Text == "")
            {
                txtConfirmPassword.Text = "Confirm Password:";
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Name:")
            {
                txtName.Text = "";
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "Name:";
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Phone:")
            {
                txtPhone.Text = "";
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "") 
            {
                txtPhone.Text = "Phone:";
            }
        }

        private void txtBirthDate_Enter(object sender, EventArgs e)
        {
            if (txtBirthDate.Text == "Birth Date:")
            {
                txtBirthDate.Text = "";
            }
        }

        private void txtBirthDate_Leave(object sender, EventArgs e)
        {
            if (txtBirthDate.Text == "")
            {
                txtBirthDate.Text = "Birth Date:";
            }
        }


        private void txtBirthPlace_Enter(object sender, EventArgs e)
        {
            if (txtBirthPlace.Text == "Birth Place:")
            {
                txtBirthPlace.Text = "";
            }
        }

        private void txtBirthPlace_Leave(object sender, EventArgs e)
        {
            if (txtBirthPlace.Text == "")
            {
                txtBirthPlace.Text = "Birth Place:";
            }
        }

        private void txtFamily_Enter(object sender, EventArgs e)
        {
            if (txtFamily.Text == "Family:")
            {
                txtFamily.Text = "";
            }
        }

        private void txtFamily_Leave(object sender, EventArgs e)
        {
            if (txtFamily.Text == "")
            {
                txtFamily.Text = "Family:";
            }
        }

        private void txtMobile_Enter(object sender, EventArgs e)
        {
            if (txtMobile.Text == "Mobile:")
            {
                txtMobile.Text = "";
            }
        }

        private void txtMobile_Leave(object sender, EventArgs e)
        {
            if (txtMobile.Text == "")
            {
                txtMobile.Text = "Mobile:";
            }
        }

       

       
    }
}
