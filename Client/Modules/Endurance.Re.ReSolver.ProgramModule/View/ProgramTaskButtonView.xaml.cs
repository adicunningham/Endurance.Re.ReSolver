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
using Endurance.Re.ReSolver.Infrastructure.Interfaces;
using Endurance.Re.ReSolver.ProgramModule.ViewModel;

namespace Endurance.Re.ReSolver.ProgramModule.View
{
    /// <summary>
    /// Interaction logic for ProgramTaskButtonView.xaml
    /// </summary>
    public partial class ProgramTaskButtonView : UserControl
    {
        public ProgramTaskButtonView(IProgramTaskButtonViewModel viewModel)
        {
            InitializeComponent();
            ViewModel = viewModel;
        }


        public IViewModel ViewModel
        {
            get { return (IViewModel)DataContext; }
            set { DataContext = value; }
        }
    }
}
