using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinWithShell.Models;

namespace XamarinWithShell.ViewModels
{
    class ProductListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Items { get; set; }

        public ProductListViewModel()
        {
            Items = new ObservableCollection<Product>(new[]
            {
                    new Product ( "Item 1") { Description = "Short Description"},
                    new Product ( "Item 2") { Description = "Short Description"},
                    new Product ( "Item 3") { Description = "Short Description"},
                    new Product ( "Item 4") { Description = "Short Description"},
                    new Product ( "Item 5") { Description = "Short Description"},
                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
