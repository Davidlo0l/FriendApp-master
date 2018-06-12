﻿using FriendApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace FriendApp.Droid.Servicios
{
    using FriendApp.Services;
    using System;
    using System.IO;

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