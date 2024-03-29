﻿using ATXBSAPP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace ATXBSAPP.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Inicio"},                
                new HomeMenuItem {Id = MenuItemType.News, Title="Noticias"},
                new HomeMenuItem {Id = MenuItemType.Webinar, Title="Webinars"},
                new HomeMenuItem {Id = MenuItemType.Promotions, Title="Soluciones"},
                new HomeMenuItem {Id = MenuItemType.Frecuency, Title="Ebooks"},
                new HomeMenuItem {Id = MenuItemType.Youtube, Title="Videos"},
                new HomeMenuItem {Id = MenuItemType.About, Title="Acerca de"},
                new HomeMenuItem {Id = MenuItemType.Retro, Title="Retroalimentación"},
                //new HomeMenuItem {Id = MenuItemType.home_menu_edition, Title="Menu 2.0"}
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}