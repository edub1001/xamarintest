using XamarinTest.Droid;
using System.IO;
using XamarinTest.Database;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace XamarinTest.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, fileName);
        }
    }
}