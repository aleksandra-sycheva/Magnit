﻿using System;
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
    public partial class FormDirector : Form
    {
        private int _IdTypeOfEmployee;
        public FormDirector()
        {
            InitializeComponent();
            LoadEmployees();
        }
        public FormDirector(int id)
        {
            InitializeComponent();
            LoadEmployees();
            _IdTypeOfEmployee = id;
        }

        public void SetRegisterButtonVisible(bool visible)
        {
            buttonRegistration.Visible = visible;
            buttonUpdate.Visible = visible;
        }

        private void LoadEmployees()
        {
            using (var context = new MagnitContext())
            {
                context.Employees.Load();
                var employees = context.Employees
                    .Include(e => e.IdTypeOfEmployeeNavigation)
                    .Select(e => new
                    {
                        e.Id,
                        RoleId = e.IdTypeOfEmployee,
                        RoleName = e.IdTypeOfEmployeeNavigation.TypeOfEmployee,
                        e.Surname,
                        e.Name,
                        e.MiddleName,
                    })
                    .OrderBy(e => e.RoleId)
                    .ThenBy(e => e.Surname)
                    .ToList();

                dataGridViewEmployee.DataSource = employees;

                dataGridViewEmployee.Columns["Id"].Visible = false;
                dataGridViewEmployee.Columns["RoleId"].Visible = false;
                dataGridViewEmployee.Columns["RoleName"].HeaderText = "Роль сотрудника";
                dataGridViewEmployee.Columns["Name"].HeaderText = "Имя";
                dataGridViewEmployee.Columns["Surname"].HeaderText = "Фамилия";
                dataGridViewEmployee.Columns["MiddleName"].HeaderText = "Отчество";
            }
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int employeeId = (int)dataGridViewEmployee.CurrentRow.Cells["Id"].Value;
            FormEmployee formEmployee = new FormEmployee(employeeId, this);
            formEmployee.Show();
            this.Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int employeeId = (int)dataGridViewEmployee.CurrentRow.Cells["Id"].Value;


                using (var context = new MagnitContext())
                {
                    var employee = context.Employees
                        .Where(e => e.Id == employeeId)
                        .FirstOrDefault();
                    if (employeeId < _IdTypeOfEmployee)
                    {
                        MessageBox.Show($"Вы не можете уволить сотрудника {employee.Surname} {employee.Name} {employee.MiddleName} ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show($"Вы точно хотите уволить сотрудника {employee.Surname} {employee.Name} {employee.MiddleName}? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            employee.DateOfDismissal = DateOnly.FromDateTime(DateTime.Now);
                            context.SaveChanges();
                            MessageBox.Show($"Сотрудник {employee.Surname} {employee.Name} {employee.MiddleName} уволен. Дата увольнения: {employee.DateOfDismissal}", "Успешное увольнение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration formRegistration = new FormRegistration();
            this.Hide();
            formRegistration.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы точно хотите выйти из аккаунта? ", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FormEnter backform = new FormEnter();
                this.Close();
                backform.Show();
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmployee.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int employeeId = (int)dataGridViewEmployee.CurrentRow.Cells["Id"].Value;


                using (var context = new MagnitContext())
                {
                    Employee emp = context.Employees
                        .Where(e => e.Id == employeeId)
                        .FirstOrDefault();

                    FormRegistration formRegistration = new FormRegistration(emp);
                    this.Hide();
                    formRegistration.Show();
                }
            }
        }

        private void buttonHistoryRevenue_Click(object sender, EventArgs e)
        {
            if(buttonRegistration.Visible == false)
            {
                this.Hide();
                FormHistoryRevenue formHistoryRevenue = new FormHistoryRevenue(this);
                formHistoryRevenue.SetUpdateButtonVisible(false);
                formHistoryRevenue.Show();
            }
            else
            {
                this.Hide();
                FormHistoryRevenue formHistory = new FormHistoryRevenue(this);
                formHistory.Show();
            }
        }
    }
}
