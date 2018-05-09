using System;

namespace NotebookApp {
    public class TextualMessage : IPageable {
        protected string _note;
        protected PageData _pageData;

        public PageData PageData { get; set; }

        public virtual IPageable Input() {
            Console.WriteLine("Plase enter your name");
            _pageData.Author = Console.ReadLine();
            Console.WriteLine("Plase enter the note title");
            _pageData.Tiltle = Console.ReadLine();
            Console.WriteLine("Plase enter your note");
            _note = Console.ReadLine();

            return this;
        }


        public void Output() {
            Console.WriteLine(@"
Title : {0}
Author : {1}

{2} 
",
_pageData.Tiltle,
_pageData.Author,
_note);
        }
    }
}
