using System;
using System.Collections.Generic;
using System.Text;

namespace mongo
{
    class Quest
    {
        public string Naz;
        private Map map;

        internal Map Map { get => map; set => map = value; }
    }
}
