using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace OutNow.Events
{
    public static class ThemeDatas
    {
        private static string rootPath = "ms-appx:///Assets/Icons";
        public static Dictionary<string, int> ThemesFilter { get { return themes; } }
        private static readonly Dictionary<string, int> themes = new Dictionary<string, int> { 
            { "Tous",0},
            { "Autre",1},
            { "Cinéma",2},
            { "Gastronomie",3},
            { "Spectacles",4},
            { "Soirées",5},
            { "Shopping",6},
            { "Sport & Loisirs",7},
            { "Salons & Foires",8},
            { "Expositions",9},
            { "Manifestations",10},
            { "Concert",11}
        };
        public static readonly List<string> Themes = new List<string>
        {
            {"Autre"},
            {"Cinéma"},
            {"Gastronomie"},
            {"Spectacles"},
            {"Soirées"},
            {"Shopping"},
            {"Sport & Loisirs"},
            {"Salons & Foires"},
            {"Expositions"},
            {"Manifestations"},
            {"Concert"}
        };

        public static readonly Dictionary<string, string> ThemeBitmapUris = new Dictionary<string, string> { 
            {ThemeDatas.Themes[0], rootPath+"/autre.png"},
            {ThemeDatas.Themes[1], rootPath+"/autre.png"},
            {ThemeDatas.Themes[2],rootPath+"/cinema.png"},
            {ThemeDatas.Themes[3],rootPath+"/gastronomie.png"},
            {ThemeDatas.Themes[4], rootPath+"/theatre.png"},
            {ThemeDatas.Themes[5], rootPath+"/soiree.png"},
            {ThemeDatas.Themes[6], rootPath+"/market.png"},
            {ThemeDatas.Themes[7], rootPath+"/autre.png"},
            {ThemeDatas.Themes[8],rootPath+"/autre.png"},
            {ThemeDatas.Themes[9],rootPath+"/expo.png"},
            {ThemeDatas.Themes[10],rootPath+"/manif.png"},
            {ThemeDatas.Themes[11],rootPath+"/concert.png"}
        };

        public static readonly Dictionary<string, BitmapImage> ThemeBitmaps = new Dictionary<string, BitmapImage> { 
            {ThemeDatas.Themes[0], new BitmapImage(new Uri(rootPath+"/autre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[1], new BitmapImage(new Uri(rootPath+"/autre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[2], new BitmapImage(new Uri(rootPath+"/cinema.png", UriKind.Absolute))},
            {ThemeDatas.Themes[3],new BitmapImage(new Uri(rootPath+"/gastronomie.png", UriKind.Absolute))},
            {ThemeDatas.Themes[4], new BitmapImage(new Uri(rootPath+"/theatre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[5], new BitmapImage(new Uri(rootPath+"/soiree.png", UriKind.Absolute))},
            {ThemeDatas.Themes[6], new BitmapImage(new Uri(rootPath+"/market.png", UriKind.Absolute))},
            {ThemeDatas.Themes[7], new BitmapImage(new Uri(rootPath+"/autre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[8],new BitmapImage(new Uri(rootPath+"/autre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[9],new BitmapImage(new Uri(rootPath+"/expo.png", UriKind.Absolute))},
            {ThemeDatas.Themes[10],new BitmapImage(new Uri(rootPath+"/manif.png", UriKind.Absolute))},
            {ThemeDatas.Themes[11],new BitmapImage(new Uri(rootPath+"/concert.png", UriKind.Absolute))}
        };

        public static readonly Dictionary<string, BitmapImage> ThemeInvertBitmaps = new Dictionary<string, BitmapImage> { 
            {ThemeDatas.Themes[0], new BitmapImage(new Uri(rootPath+"/autreCircleB.png", UriKind.Absolute))},
            {ThemeDatas.Themes[1], new BitmapImage(new Uri(rootPath+"/autreCircleB.png", UriKind.Absolute))},
            {ThemeDatas.Themes[2], new BitmapImage(new Uri(rootPath+"/cinema.png", UriKind.Absolute))},
            {ThemeDatas.Themes[3],new BitmapImage(new Uri(rootPath+"/gastronomie.png", UriKind.Absolute))},
            {ThemeDatas.Themes[4], new BitmapImage(new Uri(rootPath+"/theatre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[5], new BitmapImage(new Uri(rootPath+"/soiree.png", UriKind.Absolute))},
            {ThemeDatas.Themes[6], new BitmapImage(new Uri(rootPath+"/market.png", UriKind.Absolute))},
            {ThemeDatas.Themes[7], new BitmapImage(new Uri(rootPath+"/autre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[8],new BitmapImage(new Uri(rootPath+"/autre.png", UriKind.Absolute))},
            {ThemeDatas.Themes[9],new BitmapImage(new Uri(rootPath+"/expo.png", UriKind.Absolute))},
            {ThemeDatas.Themes[10],new BitmapImage(new Uri(rootPath+"/manif.png", UriKind.Absolute))},
            {ThemeDatas.Themes[11],new BitmapImage(new Uri(rootPath+"/concert.png", UriKind.Absolute))}
        };
    }
}
