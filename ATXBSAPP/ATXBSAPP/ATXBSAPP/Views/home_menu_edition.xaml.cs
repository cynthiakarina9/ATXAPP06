using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ATXBSAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class home_menu_edition : ContentPage
    {
        public home_menu_edition()
        {
            InitializeComponent();
        }
        //MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        //async void home_Clicked(object sender, EventArgs e)
        //{
        //    await RootPage.NavigateFromMenu(0);
        //}
    }
}