using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {
    public class Notebook {
        public const string IntroMessage = "Welcome to Notebook program v1";
        public const string OutroMessage = "Thanks for using notebook program";
        private readonly List<IPageable> _pages = new List<IPageable>();
        private readonly NoteFileReader _reader = new NoteFileReader();
        private NoteFileWriter _writer = new NoteFileWriter();

        public event Action<string> ItemAdded, ItemRemoved, InputBadCommand;
        public event Action<string, string> ItemUpdated;

        public List<string> GetAllByAuthor(string name) {
            var allNotes = new List<string>();

            foreach (var note in _reader.GetAllNotesByAuthor(name)) {
                allNotes.Add(note.Output());
            }

            return allNotes;
        }

        public string GetByPageData(PageData page) {
            return _reader.GetNoteByPageData(page).Output();

        }

        public void Add(IPageable newNote) {

            ItemAdded?.Invoke("");
        }

        public void Remove(IPageable noteToRemove) {

            ItemRemoved?.Invoke("");
        }

        public void Update(IPageable noteToUpdate, IPageable updatedNote) {

            ItemUpdated?.Invoke("", "");
        }

    }
}
