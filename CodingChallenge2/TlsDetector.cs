using System;

namespace CodingChallenge2 {
    class TlsDetector {

        private char oneAgoLetter = '.', twoAgoLetter = '.', threeAgoLetter = '.';

        private Scanner documentScanner;
        private TlsCounter counter;

        public string threeCharSequence {
            get { return threeAgoLetter.ToString() + twoAgoLetter.ToString() + oneAgoLetter.ToString(); }
        }

        public void ReadDocument(string chosenDocument) {
            
            counter = new TlsCounter();
            documentScanner = new Scanner(chosenDocument);

            while (documentScanner.StillReading) {
                UpdateLetters();
                counter.TestAndAddToCounter(threeCharSequence);
            }
        }


        private void UpdateLetters() {
            threeAgoLetter = twoAgoLetter;
            twoAgoLetter = oneAgoLetter;
            oneAgoLetter = documentScanner.nextLetter();
        }

        public void DisplayTlsWithFrequency(int desiredFrequency) {
            counter.ShowTlsWithFrequency(desiredFrequency);
        }
    }
}