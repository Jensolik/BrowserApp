using System;

namespace ModelBrowserLibrary
{



    public class Tab
    {
        public string Title { get; set; }
        public string URL { get; set; }
        public char Emodji { get; set; }    
        public Tab(string name, string url)
        {
            Title = name;
            URL = url;
            Emodji = 'X';
        }
    }
}
