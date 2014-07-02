using System;
using System.IO;

namespace CodingChallenge2 {
    class Scanner {
        private StreamReader aStreamReader;

        public Scanner(string documentName) {
            aStreamReader = new StreamReader(documentName);
        }

        public bool StillReading {
            get { return !(aStreamReader.EndOfStream); }
        }

        public char nextLetter() {
            return (char)aStreamReader.Read();
        }
    }
}