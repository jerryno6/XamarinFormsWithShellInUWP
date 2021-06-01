using System.ComponentModel;
using Xamarin.Forms;
using XamarinWithShell.ViewModels;

namespace XamarinWithShell.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}