using System;
using System.Collections;

namespace EkolTestCase
{
    public class Solution
    {
        public static string stringSolver(int n, string text)
        {
            Stack characterBox = new Stack();
            char[] tempText = text.ToCharArray();

            tempText[0] = text[0];

            characterBox.Push(tempText[0]);
            for (int i = 1; i < text.Length; i++)
            {
                if (tempText[i - 1] == tempText[i])
                {
                    characterBox.Push(tempText[i]);
                }
                else
                {
                    if (characterBox.Count == n)
                    {
                        for (int j = i-1; j > i - n -1; j--)
                        {
                            tempText[j] = '*';
                        }
                        characterBox.Clear();
                    }
                    else
                    {
                        characterBox.Clear();
                    }
                }
            }

            return new string(tempText);
        }
    }
}
