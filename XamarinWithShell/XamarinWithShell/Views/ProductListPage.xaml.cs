
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWithShell.ViewModels;

namespace XamarinWithShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductListPage : ContentPage
    {
        public CollectionView CollectionView;

        public ProductListPage()
        {
            InitializeComponent();

            BindingContext = new ProductListViewModel();
            CollectionView = MyCollectionView;
        }
    }
}