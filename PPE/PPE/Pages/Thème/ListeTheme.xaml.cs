﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PPE.Pages.Thème
{
    /// <summary>
    /// Interaction logic for ListeTheme.xaml
    /// </summary>
    public partial class ListeTheme : UserControl
    {
        public ListeTheme()
        {
            InitializeComponent();
            listView_Theme.ItemsSource = Controller.ThemeDAO.List();
            listView_Theme.Items.Refresh();
        }

        private void button_delete_Click(object sender, RoutedEventArgs e)
        {
            Button bouton = (Button)sender;
            Controller.ThemeDAO.Delete((PPE.theme)bouton.DataContext);
            listView_Theme.ItemsSource = null;
            listView_Theme.Items.Clear();
            listView_Theme.ItemsSource = (Controller.ThemeDAO.List());
            listView_Theme.Items.Refresh();
        }
    }
}
