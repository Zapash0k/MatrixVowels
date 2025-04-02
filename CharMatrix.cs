using System;

public class CharMatrix
{
    private char[,] matrix;
    private int vowelCount;
    private static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public CharMatrix(char[,] initialMatrix)
    {
        matrix = initialMatrix;
        UpdateVowelCount();
    }

    private void UpdateVowelCount()
    {
        vowelCount = 0;
        foreach (char c in matrix)
        {
            if (Array.Exists(vowels, v => v == c))
                vowelCount++;
        }
    }

    public string this[int diagonal]
    {
        get
        {
            if (diagonal == 0) // Головна діагональ
            {
                string result = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                    result += matrix[i, i];
                return result;
            }
            else if (diagonal == 1) // Побічна діагональ
            {
                string result = "";
                for (int i = 0; i < matrix.GetLength(0); i++)
                    result += matrix[i, matrix.GetLength(1) - 1 - i];
                return result;
            }
            else
            {
                throw new IndexOutOfRangeException("Неправильний індекс діагоналі. Використовуйте 0 або 1.");
            }
        }
    }

    public int VowelCount
    {
        get { return vowelCount; }
    }
}