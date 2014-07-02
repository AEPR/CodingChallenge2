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



        public void ShowTlsWithFrequency(int desiredFrequency) {
            foreach (var tls in dictionary) {
                if (tls.Value == desiredFrequency) {
                    Console.WriteLine(tls);
                }
            }
        }
    }
}