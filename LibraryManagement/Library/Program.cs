using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManagement drugarche = new LibraryManagement();
            drugarche.ListOfNovels.Add(new Novel(1, "naslov", Enums.TypeOfEdition.Hardcover, 20, "sonja"));
            drugarche.ListOfAnthologies.Add(new Anthology(2, "antologija", Enums.TypeOfEdition.Paperback, 30, "emi", "basni"));
            drugarche.ListOfStoryCollection.Add(new StoryCollection(3,"prikazni",Enums.TypeOfEdition.EBook,40,"kalina","minecraft"));
            drugarche.ViewAllBooks();
            drugarche.ViewAllNovels();
            drugarche.ViewAllStoryCollections();
            drugarche.ViewAllAnthologies();
            Console.ReadLine();
        }
    }
}
