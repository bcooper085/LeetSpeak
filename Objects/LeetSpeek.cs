using System;
using System.Collections.Generic;

namespace LeetSpeekTranslator
{
    public class LeetSpeek
    {
        public LeetSpeek(string newInput)
        {
            _userInput = newInput;
            _letterArray = newInput.ToCharArray();
        }

        private string _userInput;
        private char[] _letterArray;

        public string CharacterReplace()
        {
            for (int index = 0; index < _letterArray.Length; index++)
            {
                if (_letterArray[index] == 'e' || _letterArray[index] == 'E')
                {
                    _letterArray[index] = '3';
                }
                else if (_letterArray[index] == 'o' || _letterArray[index] == 'O')
                {
                    _letterArray[index] = '0';
                }
                else if (_letterArray[index] == 'I')
                {
                    _letterArray[index] = '1';
                }
                else if (_letterArray[index] == 's')
                {
                    if (index != 0)
                    {
                        if (_letterArray[index-1] != ' ')
                        {
                            _letterArray[index] = 'z';
                        }
                    }
                }
                else if (_letterArray[index] == 'S')
                {
                    if (index != 0)
                    {
                        if (_letterArray[index-1] != ' ')
                        {
                            _letterArray[index] = 'Z';
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("", _letterArray));
            return String.Join("", _letterArray);
        }

        public string GetUserInput()
        {
            return _userInput;
        }
        public void SetUserInput(string newInput)
        {
            _userInput = newInput;
        }
        public void SetLetterArray()
        {
            _letterArray = _userInput.ToCharArray();
        }
        public char[] GetLetterArray()
        {
            return _letterArray;
        }
    }
}
