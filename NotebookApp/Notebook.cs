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

        public event Action<string> ItemAdded, ItemRemoved, InputBadCommand, ItemUpdated; 

        public void Show() { }

        public void Add() {

            ItemAdded?.Invoke("");
        }

        public void Remove() {
            ItemRemoved?.Invoke("");
        }

        public void Update() {
            ItemUpdated?.Invoke("");
        }

    }
}
