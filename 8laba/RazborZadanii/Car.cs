using System;
using System.Collections.Generic;
using System.Text;

namespace RazborZadanii
{
    class Car
    {
        public int Number { get; set; }
        private Engine _engine;

        public Engine Engine { get { return _engine; } }
        public Car(int engine)
        {
            _engine = new Engine() { Size = engine };
        }
    }
}
