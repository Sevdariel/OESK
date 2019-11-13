using System;
using System.IO;

namespace pr1.Extensions
{
    public static class Extension
    {
        public static string GetDataURL(string imageFile)
        {
            return "<img src=\"data:image/"
                        + Path.GetExtension(imageFile).Replace(".", "")
                        + ";base64,"
                        + Convert.ToBase64String(File.ReadAllBytes(imageFile)) + "\" />";
        }
    }
}