using System;
using System.Security.Cryptography;

namespace ApexRandomBot
{
    public static class GatchaUtil{
        public static Random GenerateRandom(){
            using var rng = new RNGCryptoServiceProvider();
            var buffer = new byte[sizeof(int)];
            rng.GetBytes(buffer);
            var seed = BitConverter.ToInt32(buffer, 0);
            return new Random(seed);
        }
    }
}