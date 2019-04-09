using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;

namespace Library.Classes
{
    public abstract class Book
    {
        public int BookID{ get; set; }
        public string BookTitle { get; set; }
        public TypeOfEdition TypeOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public long ISBN { get; set; }

        public Book(int id, string title, TypeOfEdition te, int pages)
        {
            BookID = id;
            BookTitle = title;
            TypeOfEdition = te;
            NumberOfPages = pages;
            GenerateISBN();
        }

        public void GenerateISBN()
        {
            var rand = new Random();
            int random = rand.Next(100000,1000000);
            int random2 = rand.Next(100000, 1000000);
            ISBN = (random << 32) | random2;


        }
    }
}
