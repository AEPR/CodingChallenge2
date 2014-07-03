using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2 {
    class Program {

        private static int GetUsersFrequency() {

            bool noValidAnswer = true;
            int desiredFrequency = 0;
            while (noValidAnswer) {
                noValidAnswer = false;
                Console.Write("Enter desired frequency to be matched: ");
                try {
                    desiredFrequency = Convert.ToInt32(Console.ReadLine());
                }
                catch {
                    noValidAnswer = true;
                }
                if (desiredFrequency<0) {
                    noValidAnswer = true;
                }
            }
            return desiredFrequency;
        }

        public static void Main() {

            Console.Write("Enter name of document to be read: ");
            string chosenDocumentName = Console.ReadLine();
            int desiredFrequency = GetUsersFrequency();

            TlsDetector detector = new TlsDetector();
            detector.ReadDocument(chosenDocumentName);
            if (desiredFrequency == 0) {
                detector.DisplayAllTlsByFrequency();
            }
            else {
                detector.DisplayTlsWithFrequency(desiredFrequency);
            }

        }

    }
}
