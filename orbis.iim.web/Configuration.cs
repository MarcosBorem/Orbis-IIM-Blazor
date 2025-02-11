﻿using MudBlazor;
using MudBlazor.Utilities;

namespace orbis.iim.web
{
    public static class Configuration
    {
        //public const string HttpClientName = "dima";
        public const string HttpClientName = "orbis-iim";
        public static string BackendUrl { get; set; } = "http://localhost:5164";
        public static MudTheme Theme = new()
        {
            Typography = new Typography
            {
                Default = new Default()
                {
                    FontFamily = ["Raleway", "sans-serif"]
                }
            },
            PaletteLight = new PaletteLight
            {
                Primary = new MudColor("#01579B"),
                PrimaryContrastText = new MudColor("#000000"),
                Secondary = "#01579B",
                Background = "#eff0f2",
                AppbarBackground = new MudColor("#ffffff"),
                AppbarText = Colors.Shades.Black,
                TextPrimary = Colors.Shades.Black,
                DrawerText = Colors.Shades.Black,
                DrawerBackground = "#eff0f2"
            },

            PaletteDark = new PaletteDark
            {
                Primary = new MudColor("#01579B"),
                PrimaryContrastText = Colors.Shades.White,
                Secondary = "#01579B",
                Background = "#141414",
                Surface = "#1c1c1c",
                AppbarBackground = new MudColor("#2d2e2e"),
                AppbarText = Colors.Shades.White,
                TextPrimary = Colors.Shades.White,
                DrawerText = Colors.Shades.White,
                DrawerBackground = "#141414"
            }
        };
    }
}
