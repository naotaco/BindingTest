using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BindingTest.Resources;
using BindingTest.models;

namespace BindingTest
{
    public partial class MainPage : PhoneApplicationPage
    {
        DataModel data = new DataModel();

        public MainPage()
        {
            InitializeComponent();
            CheckboxOnPage.DataContext = data;
            ControlCheckbox.DataContext = data;
        }
    }
}