    using System;
using System.IO;
using FriendApp.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace FriendApp.iOS.Services
{
     public class FileHelper:IFileHelper
    {   public FileHelper()
        {
        }

        public string GetLocalFilePath(string FileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "DataBases ");
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);

            }
            return Path.Combine(libFolder, FileName);
        }
    }
}