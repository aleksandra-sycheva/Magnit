using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using magnit.Models;
using Microsoft.EntityFrameworkCore;

namespace magnit
{
    public partial class FormEmployee : Form
    {
        int _id;
        FormEmployeeList _backform;
        public FormEmployee(int id, FormEmployeeList backform)
        {
            _id = id;
            _backform = backform;
            InitializeComponent();
        }


        private void FormEmployee_Load(object sender, EventArgs e)
        {
            using (var context = new MagnitContext())
            {
                context.Employees.Load();
                var employees = context.Employees
                    .Include(e => e.IdTypeOfEmployeeNavigation)
                    .Where(e => e.Id == _id)
                    .Select(e => new
                    {
                        e.Id,
                        RoleName = e.IdTypeOfEmployeeNavigation.TypeOfEmployee,
                        e.Surname,
                        e.Name,
                        e.MiddleName,
                        e.DateOfBirth,
                        e.ResidentialAddress,
                        e.Phone,
                        e.Email,
                        e.DateOfEmployment,
                        e.Photo,
                        e.DateOfDismissal,
                    })
                    .FirstOrDefault();

                if(employees != null)
                {
                    label_TypeOfEmploee.Text = employees.RoleName.ToString();
                    label_Surname.Text = employees.Surname.ToString();
                    label_Name.Text = employees.Name.ToString();
                    string photo = employees.Photo.ToString().Trim();
                    int extensionIndex = photo.LastIndexOf('.');
                    if (extensionIndex > 0)
                    {
                        photo = photo.Substring(0, extensionIndex);
                    }
                    var rm = Properties.Resources.ResourceManager;
                    pictureBoxPhoto.Image = (Image)rm.GetObject(photo);
                    pictureBoxPhoto.Refresh();
                    label_MiddleName.Text = employees.MiddleName.ToString();
                    label_DaterOfBirth.Text = employees.DateOfBirth.ToString();
                    label_ResidentialAddress.Text = employees.ResidentialAddress.ToString();
                    label_Phone.Text = employees.Phone.ToString();
                    label_Email.Text = employees.Email.ToString();
                    label_DateOfEmployment.Text = employees.DateOfEmployment.ToString();
                    if (employees.DateOfDismissal == null)
                    {
                        labelDateOfDismissal.Visible = false;
                        label_DateOfDismissal.Visible = false;
                    }
                    else
                    {
                        labelDateOfDismissal.Visible = true;
                        label_DateOfDismissal.Visible = true;
                        label_DateOfDismissal.Text = employees.DateOfDismissal.ToString();
                        
                    }
                    
                }

            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _backform.Show();
        }
    }
}
