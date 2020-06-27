using AirMonitor.Models;
using AirMonitor.ViewModels;
using Javax.Security.Auth;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AirMonitor.Views
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel _viewModel => BindingContext as HomeViewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel(Navigation);
        }
        
        void ListView_ItemTapped(System.Object sender, ItemTappedEventArgs e)
        {
            _viewModel.GoToDetailsCommand.Execute(e.Item as AllData);
        }
    }
}