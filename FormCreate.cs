﻿using System;
using System.Linq;
using System.Windows.Forms;
using magnit.Models;

namespace magnit
{
    public partial class FormCreate : Form
    {
        private readonly MagnitContext _context;
        private RevenueHistory _currentRevenueHistory;
        private Form _backForm;

        public FormCreate(MagnitContext context, RevenueHistory revenueHistory = null)
        {
            InitializeComponent();
            _context = context;
            _currentRevenueHistory = revenueHistory;

            LoadComboBoxes();
            if (_currentRevenueHistory != null)
            {
                LoadRevenueHistoryData();
            }

        }

        private void LoadComboBoxes()
        {
            var employees = _context.Employees
                .Select(e => new
                {
                    e.Id,
                    FullName = e.Surname + " " + e.Name + " " + e.MiddleName
                })
                .ToList();

            comboBoxEmployee.DataSource = employees;
            comboBoxEmployee.DisplayMember = "FullName";
            comboBoxEmployee.ValueMember = "Id";

            comboBoxSalesRegisters.DataSource = _context.SalesRegisters.ToList();
            comboBoxSalesRegisters.DisplayMember = "Name";
            comboBoxSalesRegisters.ValueMember = "Id";
        }
        public void BackForm(Form backForm)
        {
            _backForm = backForm;
        }
        private void LoadRevenueHistoryData()
        {
            comboBoxEmployee.SelectedValue = _currentRevenueHistory.IdEmployee;
            comboBoxSalesRegisters.SelectedValue = _currentRevenueHistory.IdSalesRegisters;
            textBoxRevenue.Text = _currentRevenueHistory.Revenue.ToString("F2");

            DateTime dateValue = _currentRevenueHistory.Date.ToDateTime(TimeOnly.MinValue);
            if (dateValue < dateTimePickerDate.MinDate || dateValue > dateTimePickerDate.MaxDate)
            {
                dateValue = DateTime.Now;
            }
            dateTimePickerDate.Value = dateValue;

            DateTime baseDate = dateTimePickerDate.Value.Date;

            DateTime timeStartValue;
            if (!DateTime.TryParseExact(_currentRevenueHistory.TimeStart, "HH:mm", null, System.Globalization.DateTimeStyles.None, out timeStartValue))
            {
                timeStartValue = DateTime.Now;
            }
            else
            {
                timeStartValue = baseDate.Add(timeStartValue.TimeOfDay);
            }
            dateTimePickerTimeStart.Value = timeStartValue;

            DateTime timeEndValue;
            if (!DateTime.TryParseExact(_currentRevenueHistory.TimeEnd, "HH:mm", null, System.Globalization.DateTimeStyles.None, out timeEndValue))
            {
                timeEndValue = DateTime.Now;
            }
            else
            {
                timeEndValue = baseDate.Add(timeEndValue.TimeOfDay);
            }
            dateTimePicker1.Value = timeEndValue;
        }

        private void ButtonSave_Click(object? sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxRevenue.Text, out decimal revenue))
            {
                MessageBox.Show("Введите корректное значение выручки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка, что TimeStart не больше TimeEnd
            if (dateTimePickerTimeStart.Value > dateTimePicker1.Value)
            {
                MessageBox.Show("Время начала не может быть больше времени окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentRevenueHistory == null)
            {
                _currentRevenueHistory = new RevenueHistory();
            }

            _currentRevenueHistory.IdEmployee = (int)comboBoxEmployee.SelectedValue;
            _currentRevenueHistory.IdSalesRegisters = (short)comboBoxSalesRegisters.SelectedValue;
            _currentRevenueHistory.Revenue = revenue;
            _currentRevenueHistory.Date = DateOnly.FromDateTime(dateTimePickerDate.Value);
            _currentRevenueHistory.TimeStart = dateTimePickerTimeStart.Value.ToString("HH:mm");
            _currentRevenueHistory.TimeEnd = dateTimePicker1.Value.ToString("HH:mm");

            // Добавляем или обновляем запись в контексте
            if (_currentRevenueHistory.Id == 0)
            {
                using (var newContext = new MagnitContext())
                {
                    var entity = new RevenueHistory
                    {
                        IdEmployee = _currentRevenueHistory.IdEmployee,
                        IdSalesRegisters = _currentRevenueHistory.IdSalesRegisters,
                        Revenue = _currentRevenueHistory.Revenue,
                        Date = _currentRevenueHistory.Date,
                        TimeStart = _currentRevenueHistory.TimeStart,
                        TimeEnd = _currentRevenueHistory.TimeEnd
                    };
                    newContext.RevenueHistories.Add(entity);
                    newContext.SaveChanges();
                }
            }
            else
            {
                using (var newContext = new MagnitContext())
                {
                    var existing = newContext.RevenueHistories.Find(_currentRevenueHistory.Id);
                    if (existing != null)
                    {
                        existing.IdEmployee = _currentRevenueHistory.IdEmployee;
                        existing.IdSalesRegisters = _currentRevenueHistory.IdSalesRegisters;
                        existing.Revenue = _currentRevenueHistory.Revenue;
                        existing.Date = _currentRevenueHistory.Date;
                        existing.TimeStart = _currentRevenueHistory.TimeStart;
                        existing.TimeEnd = _currentRevenueHistory.TimeEnd;
                        newContext.SaveChanges();
                    }
                }
            }

            MessageBox.Show("Данные успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            if (_backForm is FormSortedList sortedList)
            {
                sortedList.RefreshDataWithSettings();
            }
            else if (_backForm is FormHistoryRevenue historyRevenue)
            {
                historyRevenue.LoadDataWithSettings();
            }
            _backForm.Show();
        }
    }
}
