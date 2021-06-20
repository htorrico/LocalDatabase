﻿using LocalDatabase.DataContext;
using LocalDatabase.Interfaces;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocalDatabase
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            GetContext().Database.EnsureCreated();
            MainPage = new MainPage();
        }
        public static AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
