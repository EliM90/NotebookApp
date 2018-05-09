using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {
    class Image : IPageable {
        private string _asciiImage;

        public PageData PageData { get; set; }

        public IPageable Input() {
            throw new NotImplementedException();
        }

        public void Output() {
            throw new NotImplementedException();
        }
    }
}
