using System;
namespace Program
{
    class Encrypter
    {

        public static string Encrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textEncripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] + 1;
                letter = (char)letterInt;
                textEncripted += letter.ToString();
            }
            return textEncripted;
        }

        public static string Decrypt(string text)
        {
            int letterInt = 0;
            char letter = ' ';
            string textDecripted = "";
            for (int i = 0; i < text.Length; i++)
            {
                letterInt = (int)text[i] - 1;
                letter = (char)letterInt;
                textDecripted += letter.ToString();
            }
            return textDecripted;
        }
    }

    class TextEncripted
    {

        static void Main()
        {
            bool debug = true;
            //---------------------------------------------------------------------
            string First_One = Encrypter.Encrypt("Ahmad");
            Console.WriteLine("Text encripted: {0}", First_One);
            string FirstOne_Descripted = Encrypter.Decrypt(First_One);
            Console.WriteLine("Text Decripted: {0}", FirstOne_Descripted);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //------------------------------------------------------------------------
            string Second_One = Encrypter.Encrypt("Dana Kanna");
            Console.WriteLine("Text encripted: {0}", Second_One);
            string SecondOne_Descripted = Encrypter.Decrypt(Second_One);
            Console.WriteLine("Text Decripted: {0}", SecondOne_Descripted);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            //------------------------------------------------------------------------
            string Third_One = Encrypter.Encrypt("Tahaluf ElEmarat");
            Console.WriteLine("Text encripted: {0}", Third_One);
            string ThirdOne_Descripted = Encrypter.Decrypt(Third_One);
            Console.WriteLine("Text Decripted: {0}", ThirdOne_Descripted);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            //-------------------------------------------------------------------
            if (debug)
                Console.ReadLine();
        }
    }




}