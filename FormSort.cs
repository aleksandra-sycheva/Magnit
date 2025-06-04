using magnit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace magnit
{
    public partial class FormSort : Form
    {
        FormHistoryRevenue _backForm;
        public FormSort(FormHistoryRevenue backForm)
        {
            _backForm = backForm;
            InitializeComponent();
            LoadData();
            SetupEvents();
            UpdateControlsVisibility();
        }

        private void LoadData()
        {
            using (var context = new MagnitContext())
            {
                var employees = context.Employees
                    .Select(e => new
                    {
                        e.Id,
                        FullName = e.Surname + " " + e.Name + " " + e.MiddleName
                    })
                    .ToList();

                comboBoxEmploye.DataSource = employees;
                comboBoxEmploye.DisplayMember = "FullName";
                comboBoxEmploye.ValueMember = "Id";

                var salesRegisters = context.SalesRegisters
                    .Select(s => new
                    {
                        s.Id,
                        s.Name
                    })
                    .ToList();

                comboBoxSalesRegisters.DataSource = salesRegisters;
                comboBoxSalesRegisters.DisplayMember = "Name";
                comboBoxSalesRegisters.ValueMember = "Id";
            }
        }

        private void SetupEvents()
        {
            radioButtonEmployee.CheckedChanged += (s, e) => UpdateControlsVisibility();
            radioButtonSalesRegisters.CheckedChanged += (s, e) => UpdateControlsVisibility();
            radioButtonDate.CheckedChanged += (s, e) => UpdateControlsVisibility();
            buttonSort.Click += ButtonSort_Click;
        }

        private void UpdateControlsVisibility()
        {
            comboBoxEmploye.Visible = radioButtonEmployee.Checked;
            comboBoxSalesRegisters.Visible = radioButtonSalesRegisters.Checked;
            dateTimePickerDate.Visible = radioButtonDate.Checked;
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            int? employeeId = null;
            int? salesRegisterId = null;
            DateTime? date = null;
            string sortType = null;

            if (radioButtonEmployee.Checked)
            {
                sortType = "Employee";
                if (comboBoxEmploye.SelectedValue != null)
                    employeeId = Convert.ToInt32(comboBoxEmploye.SelectedValue);
            }
            else if (radioButtonSalesRegisters.Checked)
            {
                sortType = "SalesRegister";
                if (comboBoxSalesRegisters.SelectedValue != null)
                    salesRegisterId = Convert.ToInt32(comboBoxSalesRegisters.SelectedValue);
            }
            else if (radioButtonDate.Checked)
            {
                sortType = "Date";
                date = dateTimePickerDate.Value.Date;
            }

            var formSortedList = new FormSortedList(sortType, employeeId, salesRegisterId, date, _backForm);
            formSortedList.Show();
            this.Hide();
        }
    }
}
