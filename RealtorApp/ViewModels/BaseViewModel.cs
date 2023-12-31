﻿using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace RealtorApp.ViewModels
{
    //[INotifyPropertyChanged]
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel() 
        {
            
        }

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        private bool isBusy = false;
        //public bool IsBusy { 
        //    get => isBusy; 
        //    set 
        //    {
        //        if (isBusy == value) return;

        //        isBusy = value;
        //        OnPropertyChanged();
        //    }
        //}

        public bool IsNotBusy => !IsBusy;

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
    }
}
