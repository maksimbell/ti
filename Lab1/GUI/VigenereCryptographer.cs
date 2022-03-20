using System;

namespace GUI
{
    public static class VigenereCryptographer
    {
        public static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static string Encrypt(string message, string key)
        {
            string messageCopy = message;
            string cipher = string.Empty;

            int p = 0;
            while (p < key.Length)
            {
                if (alphabet.IndexOf(key[p]) == -1)
                {
                    key = key.Remove(p, 1);
                    p--;
                }
                p++;
            }

            p = 0;
            while (p < message.Length)
            {
                if (alphabet.IndexOf(message[p]) == -1)
                {
                    message = message.Remove(p, 1);
                    p--;
                }
                p++;
            }

            string keyMessage = string.Empty;

            keyMessage = (key + message).Remove(message.Length);

            for (int i = 0; i < message.Length; i++)
            {
                cipher += alphabet[((alphabet.IndexOf(message[i]) +
                    alphabet.IndexOf(keyMessage[i])) % alphabet.Length)];
            }

            for (int i = 0; i < messageCopy.Length; i++)
            {
                if (i == message.Length)
                {
                    message += " ";
                }
                if (messageCopy[i] != message[i])
                {
                    message = message.Insert(i, messageCopy[i].ToString());
                    cipher = cipher.Insert(i, messageCopy[i].ToString());
                }
            }

            return cipher.ToUpper();
        }

        public static string Decrypt(string cipher, string key)
        {
            string message = string.Empty;
            string cipherCopy = cipher;

            int p = 0;
            while (p < key.Length)
            {
                if (alphabet.IndexOf(key[p]) == -1)
                {
                    key = key.Remove(p, 1);
                    p--;
                }
                p++;
            }

            p = 0;
            while (p < cipher.Length)
            {
                if (alphabet.IndexOf(cipher[p]) == -1)
                {
                    cipher = cipher.Remove(p, 1);
                    p--;
                }
                p++;
            }

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

            for (int i = 0; i < cipherCopy.Length; i++)
            {
                if (i == cipher.Length)
                {
                    cipher += " ";
                }
                if (cipherCopy[i] != cipher[i])
                {
                    message = message.Insert(i, cipherCopy[i].ToString());
                    cipher = cipher.Insert(i, cipherCopy[i].ToString());
                }
            }

            return message.ToUpper();
        }
    }
}