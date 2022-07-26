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

            characterBox.Push(tempText[0]); //İlk karakter için stack'e yükleme yapıldı.

            for (int i = 1; i < text.Length; i++)
            {
                if (tempText[i - 1] == tempText[i])
                {
                    //Eger bir önceki karakterimle suanki karakterim match olursa Stack icerisine pushlayacagim
                    characterBox.Push(tempText[i]);
                }
                else
                {
                    if (characterBox.Count == n)
                    {
                        //Eger match olmazsa ve stackteki eleman sayımla n parametrem esitse oldugum yerden n kadar geriye gidip stringin o kısmını * ile isaretliyorum.
                        for (int j = i-1; j > i - n -1; j--)
                        {
                            tempText[j] = '*';
                        }
                        characterBox.Clear(); //İsaretleme isi bittikten sonra stackimi bosaltiyorum.
                    }
                    else
                    {
                        characterBox.Clear(); // Eger karakter degisiminde stackteki eleman sayim n parametremle esit degilse isaretleme yapmadan stackimi bosaltiyorum.
                    }
                }
            }

            return new string(tempText);
        }
    }
}
