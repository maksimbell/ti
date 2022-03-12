using System;

public static class ColumnCryptographer
{
    public static string Encrypt(string message, string key)
    {
        string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        string cipher = String.Empty;
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
            if (i % key.Length == 0) {
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

    public static string Decrypt()
    {

        return "LOl";
    }
}
