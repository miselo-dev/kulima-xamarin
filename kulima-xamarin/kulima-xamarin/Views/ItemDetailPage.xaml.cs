using System.ComponentModel;
using Xamarin.Forms;
using kulima_xamarin.ViewModels;

namespace kulima_xamarin.Views
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