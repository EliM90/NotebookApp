using System;

namespace NotebookApp {
    public class TextualMessage : IPageable {
        protected string _message;

        public PageData PageData { get; set; }

        public virtual IPageable Input() {
            throw new NotImplementedException();
        }


        public void Output() {
            throw new NotImplementedException();
        }
    }
}
