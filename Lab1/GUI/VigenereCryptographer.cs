using System;

namespace GUI
{
    public static class VigenereCryptographer
    {
        public static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        public static string Encrypt(string message, string key)
        {
            string cipher = string.Empty;
            string keyMessage = string.Empty;

            keyMessage = (key + message).Remove(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                cipher += alphabet[((alphabet.IndexOf(message[i]) +
                    alphabet.IndexOf(keyMessage[i])) % alphabet.Length)];
            }

            return cipher.ToUpper();
        }

        public static string Decrypt(string cipher, string key)
        {
            string message = string.Empty;
            string keyMessage = string.Empty;

            keyMessage = key;

            int cipherIndex, keyIndex;

            for (int i = 0; i < cipher.Length; i++)
            {
                cipherIndex = alphabet.IndexOf(cipher[i]);
                keyIndex = alphabet.IndexOf(keyMessage[i]);
                message += keyIndex <= cipherIndex ? alphabet[((cipherIndex -
                    keyIndex) % alphabet.Length)] : alphabet[(alphabet.Length - (keyIndex -
                    cipherIndex) % alphabet.Length)];
                keyMessage += message[i];

            }

            return message.ToUpper();
        }
    }
}