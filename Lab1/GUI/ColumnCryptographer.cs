using System;

namespace GUI
{
    public static class ColumnCryptographer
    {
        public static string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static string Encrypt(string message, string key)
        {
            string cipher = string.Empty;
            int rowsNumber = message.Length / key.Length + 3;
            char[,] table = new char[rowsNumber, key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                table[0, i] = key[i];
            }

            int counter = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (table[0, j] == alphabet[i])
                    {
                        table[1, j] = (char)counter;
                        counter++;
                    }
                }
            }

            int row = 1;
            int col = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (i % key.Length == 0)
                {
                    row++;
                    col = 0;
                }

                table[row, col] = message[i];
                col++;
            }

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (table[1, j] == (char)i)
                    {
                        for (int k = 2; k < rowsNumber; k++)
                        {
                            if (table[k, j] != '\0') cipher += table[k, j];
                        }
                    }
                }
            }

            return cipher.ToUpper();
        }

        public static string Decrypt(string cipher, string key)
        {
            string message = string.Empty;
            int rowsNumber = cipher.Length / key.Length + 3;
            char[,] table = new char[rowsNumber, key.Length];

            for (int i = 0; i < key.Length; i++)
            {
                table[0, i] = key[i];
            }

            int counter = 0;
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (table[0, j] == alphabet[i])
                    {
                        table[1, j] = (char)counter;
                        counter++;
                    }
                }
            }

            int row = 2;
            int col = 0;
            int emptyCol = cipher.Length % key.Length;
            int lastRow = rowsNumber - 1;
            counter = 0;

            for (int i = 0; i < key.Length; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (table[1, j] == (char)i)
                    {
                        col = j;
                        row = 2;
                        while (row < rowsNumber)
                        {
                            if ((col < emptyCol || lastRow > row) && counter < cipher.Length)
                            {
                                table[row, col] = cipher[counter];
                                counter++;
                            }
                            row++;
                        }
                    }
                }
            }

            row = 1;
            col = 0;
            for (int i = 0; i < cipher.Length; i++)
            {
                if (i % key.Length == 0)
                {
                    row++;
                    col = 0;
                }

                message += table[row, col];
                col++;
            }

            return message.ToUpper();
        }
    }
}