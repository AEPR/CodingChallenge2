using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace CodingChallenge2 {

    public class TlsCounter {

        private Dictionary<string, int> dictionary;

        public TlsCounter() {
            dictionary = new Dictionary<string, int>();
        }

        public void TestAndAddToCounter(string threeCharSequence) {
            if (StringHelper.AreAllLetters(threeCharSequence)) {
                threeCharSequence = threeCharSequence.ToUpper();
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



        public bool ShowTlsWithFrequency(int desiredFrequency) {
            bool noMatches = true;
            foreach (var tls in dictionary) {
                if (tls.Value == desiredFrequency) {
                    Console.WriteLine(tls);
                    noMatches = false;
                }
            }
            return !noMatches;
        }

        public void ShowTlsInAscendingFrequency() {
            var maxFrequency = dictionary.Values.Max();
            for (int i = 1; i < maxFrequency; ++i) {
                ShowTlsWithFrequency(i);
            }
        }
    }
}