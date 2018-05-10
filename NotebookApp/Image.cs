using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {
    class Image : IPageable {
        private string _asciiImage;

        public PageData PageData { get; set; }

        public IPageable Input(string author, string title, string note) {
            throw new NotImplementedException();
        }

        string IPageable.Output() {
            throw new NotImplementedException();
        }
    }
}
