using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;
using Library.Interface;

namespace Library.Classes
{
    public class Novel : Book, IBook
    {
        public string Author { get; set; }
        public string Series { get; set; }
        public int SeriesNumber { get; set; }

        public Novel(int id, string title, TypeOfEdition te, int pages, string author, string series, int sn):base(id, title, te, pages)
        {
            Author = author;
            Series = series;
            SeriesNumber = sn;
        }

        public Novel(int id, string title, TypeOfEdition te, int pages, string author) : base(id, title, te, pages)
        {
            Author = author;
        }

        public override string ToString()
        {
            return ($"{BookTitle}{Author}{Series}{SeriesNumber}{NumberOfPages}");
        }
        public string ViewBook()
        {
            return ($"{BookTitle}{Author}{TypeOfEdition}");
        }

    }
}
