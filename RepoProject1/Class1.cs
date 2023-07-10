using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace RepoProject1
{
    class Sprite
    {
        public Image i;
        public Sprite(Uri s)
        {
            BitmapImage c = new BitmapImage();
            c.BeginInit();
            c.UriSource = s;
            c.EndInit();
            i = new Image();
        }
    }

    static class GameClass
    {

    }
}