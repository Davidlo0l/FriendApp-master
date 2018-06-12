using FriendApp.Services;
using System;
using System.IO;
using Xamarin.Forms;

[assembly : Dependency(typeof(FileHelper))]
namespace FriendApp.Services
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
