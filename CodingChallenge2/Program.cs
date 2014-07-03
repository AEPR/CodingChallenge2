using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2 {
    class Program {
        public static void Main() {

            Console.Write("Enter name of document to be read: ");
            string chosenDocumentName = Console.ReadLine();
            Console.Write("Enter desired frequency to be matched: ");
            int desiredFrequency = Convert.ToInt32(Console.ReadLine());
            TlsDetector detector = new TlsDetector();
            detector.ReadDocument(chosenDocumentName);
            detector.DisplayTlsWithFrequency(desiredFrequency);

        }

    }
}
