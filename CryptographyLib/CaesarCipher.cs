﻿using System.Text.RegularExpressions;

namespace CryptographyLib
{
    public enum Alphabet
    {
        English,
        Ukrainian,
        Russian,
        Custom
    }

    public enum EncryptorMode
    {
        Encrypt,
        Decrypt
    }

    public class CaesarCipher
    {
        public static Dictionary<Alphabet, string> Languages = new Dictionary<Alphabet, string>()
        {
            {Alphabet.English, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"},
            {Alphabet.Ukrainian, "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ"},
            {Alphabet.Russian, "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"},
            {Alphabet.Custom, "ABCDEFGHIJKLMNOPQRSTUVWXYZ"},
        };

        public string InputText { get; set; } = "Yehor Ovseiukov";

        public string OutputText 
        { 
            get 
            { 
                return CodeEncode(InputText, Mode == EncryptorMode.Encrypt ? key : -key);
            } 
        }
        
        public Alphabet SelectedLanguage { get; set; } = Alphabet.English;

        public EncryptorMode Mode { get; set; } = EncryptorMode.Encrypt;

        public bool IgnoreSeparatingMarks { get; set; } = false;

        private int key;
        public int Key 
        { 
            get { return key; } 
            set 
            {
                var alphabetLength = Languages[SelectedLanguage].Length;
                if (alphabetLength < value)
                {
                    key = alphabetLength % value;
                    return;
                }
                if(value < 0)
                    throw new ArgumentOutOfRangeException("Value can't be less that zero.");
                key = value;
            } 
        }

        private string CodeEncode(string text, int k)
        {
            var alphabet = Languages[SelectedLanguage].ToUpper();
            var letterCount = alphabet.Length;
            var result = "";
            for (int i = 0; i < text.Length; i++)
            {
                var c = text[i];
                var isCharLower = char.IsLower(c);
                var index = alphabet.IndexOf(char.ToUpper(c));
                if (index < 0)
                {
                    result += c.ToString();
                }
                else
                {
                    var codeIndex = (letterCount + index + k) % letterCount;
                    result += isCharLower ? char.ToLower(alphabet[codeIndex]) : alphabet[codeIndex];
                }
            }

            return result;
        }

    }
}