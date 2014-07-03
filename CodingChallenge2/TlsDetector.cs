using System;
using System.Collections.Generic;

namespace CodingChallenge2 {
    class TlsDetector {

        private char oneAgoLetter = '.', twoAgoLetter = '.', threeAgoLetter = '.';

        private Scanner documentScanner;
        private TlsCounter counter;

        public string threeCharSequence {
            get { return threeAgoLetter.ToString() + twoAgoLetter.ToString() + oneAgoLetter.ToString(); }
        }

        public void ReadDocument(string documentName) {
            
            counter = new TlsCounter();
            documentScanner = new Scanner(documentName);

            while (documentScanner.StillReading) {
                UpdateTlsChars();
                counter.TestAndAddToCounter(threeCharSequence);
            }
            documentScanner.closeStream();
        }


        private void UpdateTlsChars() {
            threeAgoLetter = twoAgoLetter;
            twoAgoLetter = oneAgoLetter;
            oneAgoLetter = documentScanner.nextLetter();
        }

        public void DisplayTlsWithFrequency(int desiredFrequency) {
            counter.ShowTlsWithFrequency(desiredFrequency);
        }

        public void DisplayAllTlsByFrequency() {
            counter.ShowTlsInAscendingFrequency();
        }
    }
}