﻿using magnit.Models;
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

namespace magnit
{
    public partial class FormHistoryRevenue : Form
    {
        private FormDirector _backForm;
        public FormHistoryRevenue(FormDirector backForm)
        {
            InitializeComponent();
            _backForm = backForm;
        }

        public void SetUpdateButtonVisible(bool visible)
        {
            buttonCreate.Visible = visible;
            buttonUpdate.Visible = visible;
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            var formSort = new FormSort(this);
            formSort.Show();
            this.Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _backForm.Show();
        }

        private void FormHistoryRevenue_Load(object sender, EventArgs e)
        {
            LoadDataWithSettings();
        }

        public void LoadDataWithSettings()
        {
            using (var context = new MagnitContext())
            {
                var revenueHistories = context.RevenueHistories
                    .Include(r => r.IdEmployeeNavigation)
                    .Include(r => r.IdSalesRegistersNavigation)
                    .OrderByDescending(r => r.Date)       // Сортировка по дате (новые сверху)
                    .ThenBy(r => r.TimeStart)             // Сортировка по TimeStart (строка)
                    .Select(r => new
                    {
                        r.Id,
                        EmployeeFullName = r.IdEmployeeNavigation.Surname + " " + r.IdEmployeeNavigation.Name + " " + r.IdEmployeeNavigation.MiddleName,
                        SalesRegisterName = r.IdSalesRegistersNavigation.Name,
                        r.Revenue,
                        r.Date,
                        TimeStart = r.TimeStart,  // Использование строки напрямую
                        TimeEnd = r.TimeEnd       // Использование строки напрямую
                    })
                    .ToList();

                dataGridViewHistoryRevenue.DataSource = revenueHistories;

                dataGridViewHistoryRevenue.Columns["Id"].Visible = false;
                dataGridViewHistoryRevenue.Columns["EmployeeFullName"].HeaderText = "Сотрудник";
                dataGridViewHistoryRevenue.Columns["SalesRegisterName"].HeaderText = "Касса";
                dataGridViewHistoryRevenue.Columns["Revenue"].HeaderText = "Сумма";
                dataGridViewHistoryRevenue.Columns["Date"].HeaderText = "Дата";
                dataGridViewHistoryRevenue.Columns["TimeStart"].HeaderText = "Время начала";
                dataGridViewHistoryRevenue.Columns["TimeEnd"].HeaderText = "Время окончания";

            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            using (var context = new MagnitContext())
            {
                var formCreate = new FormCreate(context);
                formCreate.BackForm(this);
                formCreate.Show();
                this.Hide();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistoryRevenue.CurrentRow == null)
            {
                MessageBox.Show("Пожалуйста, выберите запись для обновления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedId = (int)dataGridViewHistoryRevenue.CurrentRow.Cells["Id"].Value;

            using (var context = new MagnitContext())
            {
                var revenueHistory = context.RevenueHistories
                    .Include(r => r.IdEmployeeNavigation)
                    .Include(r => r.IdSalesRegistersNavigation)
                    .FirstOrDefault(r => r.Id == selectedId);

                if (revenueHistory == null)
                {
                    MessageBox.Show("Выбранная запись не найдена.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var formCreate = new FormCreate(context, revenueHistory);
                formCreate.BackForm(this);
                formCreate.Show();
                this.Hide();
            }
        }
    }
}
