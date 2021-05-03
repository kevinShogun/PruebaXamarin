using PruebaXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PruebaXamarin.Views
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