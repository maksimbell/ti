using System;

namespace GUI
{
    public static class PlayfairCryptographer
    {
        public static string alphabet = "abcdefghijklmnopqrstuvwxyz";
        struct CharPos
        {
            public int row;
            public int col;
        }
        public static string Encrypt(string message, char[,] key)
        {
            string cipher = string.Empty;//make static member of class
            string messageCopy = message;

            int p = 0;
            while (p < message.Length)
            {
                if (alphabet.IndexOf(message[p]) == -1)
                {
                    message = message.Remove(p, 1);
                    p--;
                }
                p++;
            }
            

            message = message.Replace("j", "i");

            CharPos char1, char2;
            char1.row = 0;
            char1.col = 0;
            char2.row = 0;
            char2.col = 0;
            int temp = 0;

            int pointer = 0;
            char prev = '\0', cur = '\0';
            while (pointer < message.Length - 1)
            {
                cur = message[pointer + 1];
                prev = message[pointer];
                if (prev == cur)
                {
                    if (prev == 'x')
                    {
                        message = message.Insert(pointer + 1, "y");
                    }
                    else
                    {
                        message = message.Insert(pointer + 1, "x");
                    }
                    pointer++;
                }
                pointer++;
            }

            if (message.Length % 2 != 0)
            {
                if (message[message.Length-1] == 'x')
                {
                    message += "y";
                }
                else
                {
                    message += "x";
                }
            }

            messageCopy = message;
            cipher = message;

            int len = 5;
            int currentPair = 0;
            while (currentPair < cipher.Length/2)
            { 
                int i = 0, j = 0;
                while (i < len)
                {
                    while (j < len)
                    {
                        if (key[i, j] == cipher[2*currentPair])
                        {
                            char1.row = i;
                            char1.col = j;
                        }
                        if (key[i, j] == cipher[2 * currentPair + 1])
                        {
                            char2.row = i;
                            char2.col = j;
                        }

                        j++;
                    }
                    j = 0;
                    i++;
                }

                if (char1.row == char2.row)
                {
                    char1.col = (char1.col + 1) % 5;
                    char2.col = (char2.col + 1) % 5;
                }
                else if (char1.col == char2.col)
                {
                    char1.row = (char1.row + 1) % 5;
                    char2.row = (char2.row + 1) % 5;
                }
                else
                {
                    temp = char1.col;
                    char1.col = char2.col;
                    char2.col = temp;
                }

                cipher = cipher.Remove(2 * currentPair, 1).Insert(2 * currentPair, key[char1.row, char1.col].ToString());
                cipher = cipher.Remove(2 * currentPair + 1, 1).Insert(2 * currentPair + 1, key[char2.row, char2.col].ToString());


                currentPair++;
            }

            //for (int i = 0; i < messageCopy.Length; i++)
            //{
            //   if (messageCopy[i] != message[i])
            //    {
            //        message = message.Insert(i, messageCopy[i].ToString());
            //        cipher = cipher.Insert(i, messageCopy[i].ToString());
            //    }
            //}

            return cipher.ToUpper();
        }

        public static string Decrypt(string cipher, char[,] key)
        {
            string message = string.Empty;//make static member of class
            string cipherCopy = cipher;

            int p = 0;
            while (p < cipher.Length)
            {
                if (alphabet.IndexOf(cipher[p]) == -1)
                {
                    cipher = cipher.Remove(p, 1);
                    p--;
                }
                p++;
            }

            CharPos char1, char2;
            char1.row = 0;
            char1.col = 0;
            char2.row = 0;
            char2.col = 0;
            int temp = 0;

            int len = 5;
            int currentPair = 0;

            message = cipher;

            while (currentPair < message.Length / 2)
            {
                int i = 0, j = 0;
                while (i < len)
                {
                    while (j < len)
                    {
                        if (key[i, j] == message[2 * currentPair])
                        {
                            char1.row = i;
                            char1.col = j;
                        }
                        if (key[i, j] == message[2 * currentPair + 1])
                        {
                            char2.row = i;
                            char2.col = j;
                        }

                        j++;
                    }
                    j = 0;
                    i++;
                }


                if (char1.row == char2.row)
                {
                    char1.col = (char1.col + 4) % 5;
                    char2.col = (char2.col + 4) % 5;
                }
                else if (char1.col == char2.col)
                {
                    char1.row = (char1.row + 4) % 5;
                    char2.row = (char2.row + 4) % 5;
                }
                else
                {
                    temp = char1.col;
                    char1.col = char2.col;
                    char2.col = temp;
                }

                message = message.Remove(2 * currentPair, 1).Insert(2 * currentPair, key[char1.row, char1.col].ToString());
                message = message.Remove(2 * currentPair + 1, 1).Insert(2 * currentPair + 1, key[char2.row, char2.col].ToString());


                currentPair++;
            }

            //for (int i = 0; i < cipherCopy.Length; i++)
            //{
            //    if (cipherCopy[i] != cipher[i])
            //    {
            //        message = message.Insert(i, cipherCopy[i].ToString());
            //        cipher = cipher.Insert(i, cipherCopy[i].ToString());
            //    }
            //}

            return message.ToUpper();
        }
    }

}