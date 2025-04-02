﻿using Mypaddocks.Repository;
using Mypaddocks.ViewModels;
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

namespace Mypaddocks.Views
{
    /// <summary>
    /// Interaction logic for PaddockConfigurationView.xaml
    /// </summary>
    public partial class PaddockConfigurationView : UserControl
    {
        public PaddockConfigurationView()
        {
            InitializeComponent();
            // Pass the repository to the ViewModel
            this.DataContext = new PaddockConfigurationViewModel(new PaddockConfigurationRepository());
        }
    }
}
