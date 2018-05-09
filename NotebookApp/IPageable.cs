using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {

    public interface IPageable {
        PageData PageData { get; set; }
        IPageable Input();
        void Output();
    }
}
