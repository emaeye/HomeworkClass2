using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;
using Library.Interface;

namespace Library.Classes
{
    public class StoryCollection:Book, IBook
    {
        public string Author { get; set; }
        public List<Story> ListOfStories { get; set; }

        public StoryCollection(int id, string title, TypeOfEdition te, int pages, string author, string theme) : base(id, title, te, pages)
        {
            Author = author;

            ListOfStories = new List<Story>();
        }


        int NumberOfStories()
        {
            return ListOfStories.Count();
        }

        public override string ToString()
        {
            return ($"{BookTitle}{Author}{NumberOfStories()}");
        }
        public string ViewBook()
        {
            return ($"{BookTitle}{Author}{TypeOfEdition}");
        }
    }
}
