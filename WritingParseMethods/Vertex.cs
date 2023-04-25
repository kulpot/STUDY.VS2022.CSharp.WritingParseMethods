using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WritingParseMethods
{
    //struct Vertex//Value Type Parse
    class Vertex//Reference Type Parse
    {
        private int _x, _y, _z;

        public Vertex(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public int X { get { return _x; } }

        public int Y { get { return _y; } }

        public int Z { get { return _z; } }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", _x, _y, _z);
        }

        //public static bool Parse(string text, out Vertex vertex)
        public static Vertex Parse(string text)
        {
            const string PATTERN = @"(?<X>\d+), (?<Y>\d+), (?<Z>\d+)";
            Match match = Regex.Match(text, PATTERN);

            if(match.Success)
            {
                int x = int.Parse(match.Groups["X"].Value);
                int y = int.Parse(match.Groups["Y"].Value);
                int z = int.Parse(match.Groups["Z"].Value);
                //vertex = new Vertex(x, y, z);
                return new Vertex(x, y, z);
                //return true;
            }
            /*else//for struct Vertex
            {
                vertex = new Vertex();
                return false;
            }*/
            else { return null; } //return null if Fail
        }
    }
}
