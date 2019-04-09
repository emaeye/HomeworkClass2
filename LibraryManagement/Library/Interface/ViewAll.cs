using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Classes;
using Library.Enums;

namespace Library.Interface
{
    public interface ILM
    {
        void ViewAllBooks();
        void ViewAllNovels();
        void ViewAllStoryCollections();
        void ViewAllAnthologies();


        List<Novel> ListOfNovels { get; set; }
        List<StoryCollection> ListOfStoryCollection { get; set; }
        List<Anthology> ListOfAnthologies { get; set; }


    }
}
