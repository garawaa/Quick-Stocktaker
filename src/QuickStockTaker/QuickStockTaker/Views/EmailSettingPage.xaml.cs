﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using QuickStockTaker.ViewModels;
using QuickStockTaker.ViewModels.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickStockTaker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailSettingPage : ContentPage
    {
        private bool _shown;
        private EmailSettingViewModel _vm;
        public EmailSettingPage()
        {
            InitializeComponent();
            BindingContext = _vm = ViewModelLocator.Container.Resolve<EmailSettingViewModel>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (_shown)
                return;

            _shown = true;

            await _vm.Initialase();

        }
    }
}