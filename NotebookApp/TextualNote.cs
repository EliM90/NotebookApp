using System;
using System.Net;

namespace NotebookApp {
    public class TextualNote : IPageable {
        protected string _note;
        protected PageData _pageData;

        public PageData PageData { get; set; }

        public virtual IPageable Input(string author, string title, string note) {
            _pageData.Author = author;
            _pageData.Tiltle = title;
            _note = note;

            return this;
        }

        public string Output() {
            var output = ($@" Title:{_pageData.Tiltle}
Author:{PageData.Author}
{_note} 
");
            return output;
        }
    }
}
