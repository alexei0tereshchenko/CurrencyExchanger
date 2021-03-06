﻿using System;
using System.Windows;
using System.Windows.Controls;
using CurrencyExchanger.packages.view.Dialogs;
using CurrencyExchanger.packages.view.Loaders;
using FirstFloor.ModernUI.Presentation;
using User.bo;

namespace CurrencyExchanger.packages.view.Pages
{
    public partial class EmployeeList : UserControl
    {
        public EmployeeList()
        {
            InitializeComponent();
            ReloadUsers();
        }

        public void ReloadUsers()
        {
            var allEmployees = GetEmployeeBO.GetInstance().DoRead();
            var employeeLinks = new LinkCollection();
            foreach (var employee in (Abstract.model.User[])allEmployees)
            {
                if (employee.UserId != 1)
                {
                    employeeLinks.Add(new Link
                    {
                        DisplayName = string.Concat(employee.FirstName, ' ', employee.LastName),
                        Source = new Uri("//" + employee.UserId)
                    });
                }
            }

            Employees.Links = employeeLinks;
            Employees.ContentLoader = new EmployeeLoader {EmployeeList = this};
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var addEmployeeDialog = new AddEmployeeDialog();
            addEmployeeDialog.ShowWithPropagate(this);
        }



        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}