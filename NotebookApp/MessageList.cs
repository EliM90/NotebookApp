using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotebookApp {
    class MessageList : TextualMessage {

        private enum BulletType {
            Dashed,
            Numbered,
            Star
        }

        private BulletType _bulletType;

        public override IPageable Input() {
            return this;
        }
    }
}
