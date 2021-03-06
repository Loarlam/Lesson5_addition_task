﻿using System;

namespace Addition_task
{
    class Dictionary
    {
        string[] _rus;
        string[] _eng;
        string[] _ua;

        public Dictionary(params string[] arrayLine)
        {
            _rus = arrayLine[0..3];
            _eng = arrayLine[3..6];
            _ua = arrayLine[6..9];
        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < 3; i++)
                {
                    if (_rus[i] == index)
                        return _rus[i] + " - " + _eng[i] + " - " + _ua[i];
                    else if (_eng[i] == index)
                        return _eng[i] + " - " + _rus[i] + " - " + _ua[i];
                    else if (_ua[i] == index)
                        return _ua[i] + " - " + _eng[i] + " - " + _rus[i];
                }
                return $"{index} - нет перевода для этого слова.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < 3)
                    return _rus[index] + " - " + _eng[index] + " - " + _ua[index];
                else
                    return "Попытка обращения за пределы массива.";                
            }
        }
    }
}
