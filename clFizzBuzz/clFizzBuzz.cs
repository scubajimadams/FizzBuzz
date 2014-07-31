using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clFizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz() { }

        public FizzBuzz(string fizz, string buzz)
        {
            _fizz = fizz;
            _buzz = buzz;
        }

        public FizzBuzz(string fizz, string buzz, int intFizz, int intBuzz)
        {
            _fizz = fizz;
            _buzz = buzz;
            _intFizz = intFizz;
            _intBuzz = intBuzz;
        }
        public FizzBuzz(string fizz, string buzz, int intFizz, int intBuzz, int rangeStart, int rangeEnd)
        {
            _fizz = fizz;
            _buzz = buzz;
            _intFizz = intFizz;
            _intBuzz = intBuzz;
            _rangeStart = rangeStart;
            _rangeEnd = rangeEnd;
        }

        public string _fizz { get; set; }
        public string _buzz { get; set; }
    
        public int _intFizz { get; set; }
        public int _intBuzz { get; set; }

        public int _rangeStart { get; set; }
        public int _rangeEnd { get; set; }

        //1.  Create this as a stand-alone dll
        //2.  Modify to support any range of numbers (int)
        //3.  Automated test cases ()
        //4. Extend to support divisors/replacement rules ("3", "5", "Fizz" "Buzz")
        //5. GitHub Repo recruiting@clear-measure.com


       public void WriteFizzBuzz() {
        for (int i = _rangeStart; i < _rangeEnd+1; i++) {
                if (i % (_intFizz*_intBuzz) == 0)
                    Console.WriteLine(_fizz + _buzz);
                else if (i % _intFizz == 0)
                    Console.WriteLine(_fizz);
                else if (i % _intBuzz == 0)
                    Console.WriteLine(_buzz);
                else
                    Console.WriteLine(i);
         }
        }
    }
}
