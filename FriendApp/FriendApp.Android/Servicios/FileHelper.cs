
using FriendApp.Droid.Servicios;
using Xamarin.Forms;
using FriendApp.Services;
using System;
using System.IO;

[assembly: Dependency(typeof(FileHelper))]
namespace FriendApp.Droid.Servicios
{
    

    public class FileHelper : IFileHelper
    {
        public FileHelper()
        {
        }
        public string GetLocalFilePath(string FileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, FileName);
        }
    }
} 