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
using magnit.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

    public partial class FormSortedList : Form
    {
        private string _sortType;
        private int? _employeeId;
        private int? _salesRegisterId;
        private DateTime? _date;
        private int _employee;

        private FormHistoryRevenue _historyRevenueForm;

        public FormSortedList(int employee, FormHistoryRevenue historyRevenueForm)
        {
            InitializeComponent();
            _employee = employee;
            _historyRevenueForm = historyRevenueForm;
            this.FormClosed += FormSortedList_FormClosed;
            LoadSortedData();
        }


        public FormSortedList(string sortType, int? employeeId, int? salesRegisterId, DateTime? date, FormHistoryRevenue historyRevenueForm)
        {
            InitializeComponent();
            _sortType = sortType;
            _employeeId = employeeId;
            _salesRegisterId = salesRegisterId;
            _date = date;
            _historyRevenueForm = historyRevenueForm;
            this.FormClosed += FormSortedList_FormClosed;
            LoadSortedData();
        }

        private void FormSortedList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_historyRevenueForm != null)
            {
                _historyRevenueForm.Show();
            }
            else
            {
                return;
            }
        }

        public void SetButtonVisibility(bool isSellerCashier)
        {
            buttonCreate.Visible = isSellerCashier;
            buttonUpdate.Visible = isSellerCashier;
        }

        private void LoadSortedData()
        {
            using (var context = new MagnitContext())
            {
                IQueryable<RevenueHistory> query = context.RevenueHistories
                    .Include(r => r.IdEmployeeNavigation)
                    .Include(r => r.IdSalesRegistersNavigation);

                if (_employee > 0)
                {
                    query = query.Where(r => r.IdEmployee == _employee);
                }
                else if (_sortType == "Employee" && _employeeId.HasValue)
                {
                    short employeeIdShort = Convert.ToInt16(_employeeId.Value);
                    query = query.Where(r => r.IdEmployee == employeeIdShort);
                }
                else if (_sortType == "SalesRegister" && _salesRegisterId.HasValue)
                {
                    short salesRegisterIdShort = Convert.ToInt16(_salesRegisterId.Value);
                    query = query.Where(r => r.IdSalesRegisters == salesRegisterIdShort);
                }
                else if (_sortType == "Date" && _date.HasValue)
                {
                    // Исправлено для работы с DateOnly и DateTime
                    query = query.Where(r => r.Date.ToDateTime(TimeOnly.MinValue) == _date.Value.Date);
                }

                var sortedData = query
                    .OrderByDescending(r => r.Date)       // Сортировка по дате (новые сверху)
                    .ThenBy(r => r.TimeStart)
                    .Select(r => new
                    {
                        r.Id,
                        EmployeeFullName = r.IdEmployeeNavigation.Surname + " " + r.IdEmployeeNavigation.Name + " " + r.IdEmployeeNavigation.MiddleName,
                        SalesRegisterName = r.IdSalesRegistersNavigation.Name,
                        r.Revenue,
                        r.Date,
                        TimeStart = r.TimeStart,
                        TimeEnd = r.TimeEnd
                    })
                    .ToList();

                dataGridViewHistoryRevenue.DataSource = sortedData;

                dataGridViewHistoryRevenue.Columns["Id"].Visible = false;
                dataGridViewHistoryRevenue.Columns["EmployeeFullName"].HeaderText = "Сотрудник";
                dataGridViewHistoryRevenue.Columns["SalesRegisterName"].HeaderText = "Касса";
                dataGridViewHistoryRevenue.Columns["Revenue"].HeaderText = "Сумма";
                dataGridViewHistoryRevenue.Columns["Date"].HeaderText = "Дата";
                dataGridViewHistoryRevenue.Columns["TimeStart"].HeaderText = "Время начала";
                dataGridViewHistoryRevenue.Columns["TimeEnd"].HeaderText = "Время окончания";
            }
        }

        public void RefreshDataWithSettings()
        {
            // Сохраняем текущие настройки фильтров и сортировки
            string currentSortType = _sortType;
            int? currentEmployeeId = _employeeId;
            int? currentSalesRegisterId = _salesRegisterId;
            DateTime? currentDate = _date;

            // Обновляем данные с сохраненными настройками
            _sortType = currentSortType;
            _employeeId = currentEmployeeId;
            _salesRegisterId = currentSalesRegisterId;
            _date = currentDate;

            LoadSortedData();
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
