using magnit.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace magnit
{
    public partial class FormRegistration : Form
    {
        MagnitContext db;
        Employee _employee;
        private bool _isEditMode;
        public FormRegistration()
        {
            InitializeComponent();
            db = new MagnitContext();
            _isEditMode = false;
            LoadTypes();
        }

        public FormRegistration(Employee employee)
        {
            InitializeComponent();
            db = new MagnitContext();
            _employee = employee;
            _isEditMode = true;
            LoadTypes();
            PopulateForm();
        }
        private void LoadTypes()
        {
            db.TypesOfEmployees.Load();
            comboBoxTypeOfEmployee.DataSource = db.TypesOfEmployees.Local.ToBindingList();
            comboBoxTypeOfEmployee.DisplayMember = "TypeOfEmployee";
            comboBoxTypeOfEmployee.ValueMember = "Id";
        }

        private void PopulateForm()
        {
            comboBoxTypeOfEmployee.SelectedValue = _employee.IdTypeOfEmployee;
            textBoxName.Text = _employee.Name;
            textBoxSurname.Text = _employee.Surname;
            textBoxmMiddleName.Text = _employee.MiddleName;
            dateTimePickerDaterOfBirth.Value = _employee.DateOfBirth.ToDateTime(new TimeOnly(0, 0));
            textBoxResidentialAddress.Text = _employee.ResidentialAddress;
            textBoxPhone.Text = _employee.Phone;
            textBoxEmail.Text = _employee.Email;
            dateTimePickerDateOfEmployment.Value = _employee.DateOfEmployment.ToDateTime(new TimeOnly(0, 0));
            textBoxPassword.Text = _employee.Password;
            textBoxPhoto.Text = _employee.Photo;

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                UpdateEmployee();
            }
            else
            {
                RegistrationEmployee();
            }
        }

        private void RegistrationEmployee()
        {
            Employee newEmployee = new Employee
            {
                IdTypeOfEmployee = (short)comboBoxTypeOfEmployee.SelectedValue,
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                MiddleName = textBoxmMiddleName.Text,
                DateOfBirth = DateOnly.FromDateTime(dateTimePickerDaterOfBirth.Value),
                ResidentialAddress = textBoxResidentialAddress.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                DateOfEmployment = DateOnly.FromDateTime(dateTimePickerDateOfEmployment.Value),
                Password = textBoxPassword.Text,
                Photo = textBoxPhoto.Text
            };

            db.Employees.Add(newEmployee);
            db.SaveChanges();
            MessageBox.Show("Новый сотрудник успешно зарегистрирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormDirector form = new FormDirector();
            form.Show();
        }

        private void UpdateEmployee()
        {
            _employee.IdTypeOfEmployee = (short)comboBoxTypeOfEmployee.SelectedValue;
            _employee.Name = textBoxName.Text;
            _employee.Surname = textBoxSurname.Text;
            _employee.MiddleName = textBoxmMiddleName.Text;
            _employee.DateOfBirth = DateOnly.FromDateTime(dateTimePickerDaterOfBirth.Value);
            _employee.ResidentialAddress = textBoxResidentialAddress.Text;
            _employee.Phone = textBoxPhone.Text;
            _employee.Email = textBoxEmail.Text;
            _employee.DateOfEmployment = DateOnly.FromDateTime(dateTimePickerDateOfEmployment.Value);
            _employee.Password = textBoxPassword.Text;
            _employee.Photo = textBoxPhoto.Text;

            db.Employees.Update(_employee);
            db.SaveChanges();
            MessageBox.Show("Данные сотрудника успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            FormDirector form = new FormDirector();
            form.Show();
        }
    }
}
