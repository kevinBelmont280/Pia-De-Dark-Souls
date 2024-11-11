﻿using login2.Data;
using System;
using System.IO;
using Xamarin.Forms;

namespace login2
{
    public partial class App : Application
    {
        private static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UserDatabase.db3");
                    database = new Database(dbPath);
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            // Envuelve la MainPage en un NavigationPage
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
