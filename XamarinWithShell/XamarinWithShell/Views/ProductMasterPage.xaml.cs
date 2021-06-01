using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWithShell.Models;

namespace XamarinWithShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductMasterPage : FlyoutPage
    {
        public ProductMasterPage()
        {
            InitializeComponent();
            FlyoutPage.CollectionView.SelectionChanged += CollectionView_SelectionChanged;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!e.CurrentSelection.Any())
                return;

            var item = e.CurrentSelection.First() as Product;
            if (item == null)
                return;

            var page = new ProductDetailPage(item);
            page.Title = item.Name;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    Detail = new NavigationPage(page);
                    IsPresented = false;
                    break;
                case Device.UWP:
                case Device.macOS:
                    Detail = page;
                    IsPresented = true;
                    break;
                default:
                    break;
            }

            //Hide item list
            IsPresented = false;

            //Unselect current item
            FlyoutPage.CollectionView.SelectedItem = null;
        }

    }
}