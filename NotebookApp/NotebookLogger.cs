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

        private void onPrintAdded(string newTitle) {

        }

        private void onPrintDeleted(string UpdatedTitle) {

        }

        private void onPrintUpdated(string titile, string updatedTitle) {

        }

        private void attach() {
            _trackedNotebook.ItemAdded += onPrintAdded;
            _trackedNotebook.ItemRemoved += onPrintDeleted;
            _trackedNotebook.ItemUpdated += onPrintUpdated;
        }

        private void detach() {
            _trackedNotebook.ItemAdded -= onPrintAdded;
            _trackedNotebook.ItemRemoved -= onPrintDeleted;
            _trackedNotebook.ItemUpdated -= onPrintUpdated;
        }
    }
}
