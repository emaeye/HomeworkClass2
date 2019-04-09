using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Interface;

namespace Library.Classes
{
    public class LibraryManagement:ILM
    {
        public void ViewAllBooks()
        {
            foreach (var b in ListOfNovels)
            {
                System.Console.WriteLine(b.ViewBook());
            }
            foreach (var b in ListOfStoryCollection)
            {
                System.Console.WriteLine(b.ViewBook());
            }
            foreach (var b in ListOfAnthologies)
            {
                System.Console.WriteLine(b.ViewBook());
            }
        }
        public void ViewAllNovels()
        {
            foreach (var b in ListOfNovels)
            {
                System.Console.WriteLine(b.ToString());
            }

        }
        public void ViewAllStoryCollections()
        {
            foreach (var b in ListOfStoryCollection)
            {
                System.Console.WriteLine(b.ToString());
            }

        }
        public void ViewAllAnthologies()
        {
            foreach (var b in ListOfAnthologies)
            {
                System.Console.WriteLine(b.ToString());
            }
        }

        public List<Novel> ListOfNovels { get; set; }
        public List<StoryCollection> ListOfStoryCollection { get; set; }
        public List<Anthology> ListOfAnthologies { get; set; }
        public LibraryManagement()
        {
            ListOfNovels = new List<Novel>();
            ListOfAnthologies = new List<Anthology>();
            ListOfStoryCollection = new List<StoryCollection>();
        }
    }
}
