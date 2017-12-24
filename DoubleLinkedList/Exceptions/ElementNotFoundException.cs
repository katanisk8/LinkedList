﻿using System;
using IDoubleLinkedList;
using System.Linq;

namespace ElementNotFoundException
{
    public class ElementNotFoundException<TValue> : Exception
    {
        private const string expectedMessageValue = "Nie znaleziono elementu o wartości '{0}' w kolekcji. ";
        private string expectedMessageList = "Kolekcja zawiera: ";

        public ElementNotFoundException() { }

        public ElementNotFoundException(TValue value)
        {
            throw new Exception(string.Format(expectedMessageValue, value));
        }

        public ElementNotFoundException(TValue value, IDoubleLinkedList<TValue> list)
        {
            var msgValue = string.Format(expectedMessageValue, value);

            foreach (var item in list)
            {
                expectedMessageList += item.ToString();
            }

            throw new Exception(msgValue + expectedMessageList);
        }
    }
}