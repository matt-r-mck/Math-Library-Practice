using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeMath {
    public static class PracticeExtensions {

        public static int Eval(this int i) {
            return (i * i) + (3 * i) + 5;
        }

    }
}
