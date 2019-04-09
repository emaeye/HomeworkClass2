using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;
using Library.Interface;

namespace Library.Classes
{
    public class Anthology: Book, IBook
    {
        public string Editor { get; set; }
        public string Theme { get; set; }
        public List<Story> ListOfStories { get; set; }

        public Anthology(int id, string title, TypeOfEdition te, int pages, string editor, string theme) : base(id, title, te, pages)
        {
            Editor = editor;
            Theme = theme;
            ListOfStories = new List<Story>();
        }


        int NumberOfStories()
        {
            return ListOfStories.Count();
        }

        int NumberOfAuthors()
        {
            List<string> authors=new List<string>();
            foreach (var item in ListOfStories)
            {
                if (!authors.Contains(item.StoryAuthor))
                {
                    authors.Add(item.StoryAuthor);
                }
            }
            return authors.Count();
        }
        public override string ToString()
        {
            return ($"{BookTitle}{Editor}{NumberOfStories()}{NumberOfAuthors()}");
        }
        public string ViewBook()
        {
            return ($"{BookTitle}{Editor}{TypeOfEdition}");
        }
    }
}
