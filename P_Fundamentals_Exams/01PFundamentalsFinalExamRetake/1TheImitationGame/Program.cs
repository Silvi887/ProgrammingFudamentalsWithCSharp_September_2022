using System;
using System.Linq;

namespace _1TheImitationGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string Command1 = String.Empty;

            while ((Command1= Console.ReadLine())!= "Decode")
            {
                string[] ArrCmd = Command1.Split("|").ToArray();


                string CurrentCmd = ArrCmd[0];
                if (CurrentCmd == "Move")
                {
                   
                    int numberofLetters =int.Parse( ArrCmd[1]);
                    string CurrentString = encryptedMessage.Substring(0, numberofLetters);
                    encryptedMessage = encryptedMessage.Remove(0, numberofLetters);
                    encryptedMessage += CurrentString;

                }
                else if (CurrentCmd == "Insert")
                {
                    int Index=int.Parse(ArrCmd[1]);
                    string Value=ArrCmd[2];
                    encryptedMessage=encryptedMessage.Insert(Index, Value);

                }
                else if (CurrentCmd == "ChangeAll")
                {
                    string Substring=ArrCmd[1];
                    string Replacement=ArrCmd[2];

                    encryptedMessage= encryptedMessage.Replace(Substring, Replacement);

                }



              }

            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
