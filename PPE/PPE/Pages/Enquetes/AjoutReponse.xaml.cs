﻿using FirstFloor.ModernUI.Windows.Controls;
using System;
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

namespace PPE.Pages.Enquetes
{
    /// <summary>
    /// Interaction logic for AjoutReponse.xaml
    /// </summary>
    public partial class AjoutReponse : ModernDialog
    {
        public AjoutReponse()
        {
            InitializeComponent();

            // define the dialog buttons
            this.Buttons = new Button[] { this.OkButton, this.CancelButton };
        }

        private void textBox_Reponse_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox_Reponse.Text = "";
        }
    }
}
