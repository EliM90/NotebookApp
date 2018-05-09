using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {
    class NotebookLogger {
        private Notebook _trackedNotebook;
        private bool _logging = true;

        public bool Logging {
            get => _logging;

            set {
                if (!value)
                    detach();
            }
        }

        public NotebookLogger(Notebook trackedNotebook) {
            _trackedNotebook = trackedNotebook;
            attach();
        }

        private void printAdded(string typeItemAdded) {

        }

        private void printDeleted(string idOfDeleted) {

        }

        private void printUpdated(string idOfDeleted) {

        }

        private void attach() {
            _trackedNotebook.ItemAdded += printAdded;
            _trackedNotebook.ItemRemoved += printDeleted;
            _trackedNotebook.ItemUpdated += printUpdated;
        }

        private void detach() {
            _trackedNotebook.ItemAdded -= printAdded;
            _trackedNotebook.ItemRemoved -= printDeleted;
            _trackedNotebook.ItemUpdated -= printUpdated;
        }
    }
}
