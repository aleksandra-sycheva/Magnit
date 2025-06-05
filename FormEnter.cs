﻿﻿﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using magnit.Models;

namespace magnit
{
    public partial class FormEnter : Form
    {
        public FormEnter()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (var context = new MagnitContext())
            {

                var user = context.Employees
                    .Include(emp => emp.IdTypeOfEmployeeNavigation)
                    .Where(emp => emp.Email == textBoxLogin.Text && emp.Password == textBoxPasword.Text)
                    .FirstOrDefault();

                if (user != null)
                {
                    if (user.IdTypeOfEmployeeNavigation.TypeOfEmployee == "Директор" || user.IdTypeOfEmployeeNavigation.TypeOfEmployee == "Товаровед")
                    {
                        FormEmployeeList formDirector = new FormEmployeeList(user.IdTypeOfEmployee);
                        formDirector.SetRegisterButtonVisible(true);
                        formDirector.Show();
                        this.Close();
                    }
                    else if (user.IdTypeOfEmployeeNavigation.TypeOfEmployee == "Супервайзер")
                    {
                        FormEmployeeList formDirector = new FormEmployeeList(user.IdTypeOfEmployee);
                        formDirector.SetRegisterButtonVisible(false);
                        formDirector.Show();
                        this.Close();
                    }
                    else if (user.IdTypeOfEmployeeNavigation.TypeOfEmployee == "Продавец-кассир")
                    {
                        FormSortedList formSortedList = new FormSortedList(user.Id,null);
                        formSortedList.SetButtonVisibility(true);
                        formSortedList.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
