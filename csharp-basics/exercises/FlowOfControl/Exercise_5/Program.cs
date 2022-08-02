using System;

namespace Exercise_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(PhoneKeyPad("Hello"));
        }

        //Solution 1
        static string PhoneKeyPad(string text)
        {
            text = text.ToLower();
            string digitSequence = "";

            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        digitSequence += '2';
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        digitSequence += '3';
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        digitSequence += '4';
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        digitSequence += '5';
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        digitSequence += '6';
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        digitSequence += '7';
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        digitSequence += '8';
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        digitSequence += '9';
                        break;
                    default:
                        return "Invalid input text";
                }
            }

            return digitSequence;
        }

        //Solution 2
        //static string PhoneKeyPad(string text)
        //{
        //    text = text.ToLower();
        //    string digitSequence = "";

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (!Char.IsLetter(text[i]))
        //        {
        //            return "Invalid input text";
        //        }
        //        else
        //        {
        //            if (text[i] == 'a' || text[i] == 'b' || text[i] == 'c')
        //            {
        //                digitSequence += '2';
        //            }
        //            else if (text[i] == 'd' || text[i] == 'e' || text[i] == 'f')
        //            {
        //                digitSequence += '3';
        //            }
        //            if (text[i] == 'g' || text[i] == 'h' || text[i] == 'i')
        //            {
        //                digitSequence += '4';
        //            }
        //            if (text[i] == 'j' || text[i] == 'k' || text[i] == 'l')
        //            {
        //                digitSequence += '5';
        //            }
        //            if (text[i] == 'm' || text[i] == 'n' || text[i] == 'o')
        //            {
        //                digitSequence += '6';
        //            }
        //            if (text[i] == 'p' || text[i] == 'q' || text[i] == 'r' || text[i] == 's')
        //            {
        //                digitSequence += '7';
        //            }
        //            if (text[i] == 't' || text[i] == 'u' || text[i] == 'v')
        //            {
        //                digitSequence += '8';
        //            }
        //            if (text[i] == 'w' || text[i] == 'x' || text[i] == 'y' || text[i] == 'z')
        //            {
        //                digitSequence += '9';
        //            }
        //        }
        //    }

        //    return digitSequence;
        //}
    }
}