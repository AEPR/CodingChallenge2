using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge2 {
    class Program {



        public static void Main() {
            

            string chosenDocumentName = UserInput.GetUserDocumentName();
            int desiredFrequency = UserInput.GetUsersFrequency();

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
