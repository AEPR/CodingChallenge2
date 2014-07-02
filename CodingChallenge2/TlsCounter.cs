using System;
using System.Collections.Generic;

namespace CodingChallenge2 {

    public class TlsCounter {

        private Dictionary<string, int> dictionary; 

        public void TestAndAddToCounter(string threeCharSequence) {
            if (AreAllLetters(threeCharSequence)) {
                AddToCount(threeCharSequence);
            }
        }

        private void AddToCount(string key) {

        }

        private bool AreAllLetters(string threeCharSequence) {
            if (char.IsLetter(threeCharSequence[0])
                && char.IsLetter(threeCharSequence[1])
                && char.IsLetter(threeCharSequence[2])) {
                return true;
            }
            else return false;
        }
    }
}