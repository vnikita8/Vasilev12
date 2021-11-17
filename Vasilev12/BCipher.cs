using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vasilev12
{
    class BCipher : ICipher
    {
        public string encryption;
        private string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ"; //Можно под любой язык подстроить
        public void decode()
        {
            encode();
        }

        public void encode()
        {
            string encodeString = "";
            foreach (char symbol in encryption)
            {
                if (Alphabet.Contains(symbol.ToString().ToUpper()))
                {
                    char newSymbol = symbol;
                    int id = Alphabet.IndexOf(symbol.ToString().ToUpper());
                    if (Char.IsUpper(symbol))
                        newSymbol = Alphabet[Alphabet.Length - id - 1];
                    else
                        newSymbol = Convert.ToChar(Alphabet[Alphabet.Length - id - 1].ToString().ToLower());
                    encodeString += newSymbol;
                }
                else
                    encodeString += symbol;
                    
            }
            encryption = encodeString;
        }
    }
}
