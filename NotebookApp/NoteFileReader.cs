using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NotebookApp {
    class NoteFileReader {
        private string Directory { get; } =
            Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")) + @"Notes\";

        public List<IPageable> GetAllNotesByAuthor(string name) {
            var xDoc = XDocument.Load(Directory + "Notes.xml");

            var notesElements = xDoc.Descendants("Notebook").FirstOrDefault(n => n.Attribute("Author")?.Value == name)
                ?.Elements("Note");

            var notesList = new List<IPageable>((notesElements ?? throw new InvalidOperationException()).Count());
            foreach (var note in notesElements) {
                notesList.Add(new TextualNote().
                    Input(name,
                        note.Attribute("Title")?.Value,
                        note.Value
                        ));
            }

            return notesList;
        }


        public IPageable GetNoteByPageData(PageData page) {
            var xDoc = XDocument.Load(Directory + "Notes.xml");

            var note = xDoc.Elements("Notebook").FirstOrDefault(n => n.Attribute("Author")?.Value == page.Author)
                ?.Descendants("Note").
                FirstOrDefault(n => n.Attribute("Title")?.Value == page.Tiltle);

            return new TextualNote().Input(page.Author, page.Tiltle, note?.Value);
        }

    }
}
