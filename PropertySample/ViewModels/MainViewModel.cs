using System;
using System.Windows.Input;
using PropertySample.Helpers;
using PropertySample.Services;
using PropertySample.Views;

namespace PropertySample.ViewModels
{
    public class MainViewModel : Observable
    {
        public MainViewModel()
        {
            Init();
        }

        private void Init()
        {
            GotoCommand = new RelayCommand<string>(page =>
            {
                switch (page)
                {
                    case nameof(Part0):
                        NavigationService.Navigate(typeof(Part0));
                        break;
                    case nameof(Part1):
                        NavigationService.Navigate(typeof(Part1));
                        break;
                }
            });
        }

        public ICommand GotoCommand { get; set; }


    }
}
