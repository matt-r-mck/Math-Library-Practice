using System;
using System.Reflection.Metadata.Ecma335;
using PracticeLib;
using StringLib;
using PracticeMath;
using System.Data;

namespace PracticeMathLib {
    public static class Program {
        public static void Main(string[] args) {

            var x = 37;
            x = x.Eval();
            Console.WriteLine($"{x}");

            var str = new StringLib.Str();
            var answer = str.Reverse("love");
            Console.WriteLine($"{answer}");
            
            var algebra = new PracticeLib.Algebra();
            var answer4 = algebra.Inverse(0);
            Console.WriteLine($"{ answer4}");
            
            var answer2 = algebra.Modulo(7, 4);
            Console.WriteLine($"{answer2}");

            var answer3 = algebra.Cubed(7);
            Console.WriteLine($"{answer3}");

            Console.WriteLine(algebra);

            
        }
    }
}
