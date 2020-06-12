﻿

namespace ATXBSAPP.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        News,
        Promotions,
        Store,
        Webinar,
        Frecuency,
        Youtube,
        Retro,
        Chat,
        home_menu_edition
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
