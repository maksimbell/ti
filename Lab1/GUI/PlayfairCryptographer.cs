using System;

namespace GUI
{
    public static class PlayfairCryptographer
    {
        struct CharPos
        {
            public int row;
            public int col;
        }
        public static string Encrypt(string message, char[,] key)
        {
            string cipher = string.Empty;//make static member of class
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
                    message = message.Insert(pointer + 1, "x");
                    pointer++;
                }
                pointer++;
            }

            if (message.Length % 2 != 0)
            {
                message += "x";
            }

            int len = 5;
            int currentPair = 0;
            while (currentPair < message.Length/2)
            { 
                int i = 0, j = 0;
                while (i < len)
                {
                    while (j < len)
                    {
                        if (key[i, j] == message[2*currentPair])
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

                message = message.Remove(2 * currentPair, 1).Insert(2 * currentPair, key[char1.row, char1.col].ToString());
                message = message.Remove(2 * currentPair + 1, 1).Insert(2 * currentPair + 1, key[char2.row, char2.col].ToString());


                currentPair++;
            }

            return message;
        }

        public static string Decrypt(string cipher, char[,] key)
        {
            string message = string.Empty;//make static member of class

            CharPos char1, char2;
            char1.row = 0;
            char1.col = 0;
            char2.row = 0;
            char2.col = 0;
            int temp = 0;

            int len = 5;
            int currentPair = 0;
            while (currentPair < cipher.Length / 2)
            {
                int i = 0, j = 0;
                while (i < len)
                {
                    while (j < len)
                    {
                        if (key[i, j] == cipher[2 * currentPair])
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
                    char1.col = (char1.col - 1) % 5;
                    char2.col = (char2.col - 1) % 5;
                }
                else if (char1.col == char2.col)
                {
                    char1.row = (char1.row - 1) % 5;
                    char2.row = (char2.row - 1) % 5;
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

            return cipher;
        }
    }

}