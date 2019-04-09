using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Enums;

namespace Library.Classes
{
    public class Story
    {
        public string StoryAuthor { get; set; }
        public string StoryTitle { get; set; }
        public StoryType StoryType { get; set; }
        public bool IsOriginal { get; set; }
    }
}
