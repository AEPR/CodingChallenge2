using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace CodingChallenge2 {

    public class TlsCounter {

        private Dictionary<string, int> dictionary;

        public TlsCounter() {
            dictionary = new Dictionary<string, int>();
        }

        public void TestAndAddToCounter(string threeCharSequence) {
            if (AreAllLetters(threeCharSequence)) {
                AddToCount(threeCharSequence);
            }
        }

        private void AddToCount(string key) {
            if (dictionary.ContainsKey(key)) {
                dictionary[key]++;
            }
            else {
                dictionary.Add(key, 1);
            }
        }

        private bool AreAllLetters(string threeCharSequence) {
            if (char.IsLetter(threeCharSequence[0])
                && char.IsLetter(threeCharSequence[1])
                && char.IsLetter(threeCharSequence[2])) {
                return true;
            }
            else return false;
        }


        public void ShowTlsWithFrequency(int desiredFrequency) {
            foreach (var tls in dictionary) {
                if (tls.Value == desiredFrequency) {
                    Console.WriteLine(tls);
                }
            }
        }
    }
}