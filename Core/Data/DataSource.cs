﻿using System;
using System.Collections.Generic;

namespace Core.Data
{
    public static class DataSource
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        private const string _nameChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string _numChars = "0123456789";


        public static List<Contact> GenerateDataList(int dataSize)
        {
            var list = new List<Contact>(dataSize);
            for (int i = 0; i < dataSize; i++)
            {
                list.Add(new Contact(i, "Name" + i, "123456789123", i % 2 == 0 ? DataState.State2 : DataState.State1));
            }

            return list;
        }

        public static List<Contact> GenerateRandomDataList(int dataSize)
        {
            var list = new List<Contact>(dataSize);
            for (int i = 0; i < dataSize; i++)
            {
                var nameSize = _rand.Next(5, 25);
                
                list.Add(new Contact(
                    i,
                    RandomString(nameSize, _nameChars),
                    $"+351{RandomString(9, _numChars)}",
                    i % 2 == 0 ? DataState.State2 : DataState.State1
                    ));
            }

            return list;
        }


        public static string RandomString(int size, string dictionary)
        {
            char[] buffer = new char[size];

            for (int i = 0; i < size; i++)
            {
                buffer[i] = dictionary[_rand.Next(dictionary.Length)];
            }
            return new string(buffer);
        }
    }
}
