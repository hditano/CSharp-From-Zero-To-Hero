﻿using System;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {

            var index = 3;
            var array = new int[] {1, 0, -1, 3};
            if (array == null || array.Length == 0) Console.WriteLine("Array es null o esta vacio");

            var tempArray = array.Length - 1;
            var arrayRemovedAtIndex = new int[tempArray];

            for (var i = 0; i < tempArray; i++)
            {
                if (i < array.Length)
                    arrayRemovedAtIndex[i] = array[i];
                if (i >= index)
                    arrayRemovedAtIndex[i] = array[i + 1];

            }

            foreach (var i in arrayRemovedAtIndex)
            {
                Console.WriteLine($"tempArray es {i}");
            }

        }




        

        public static void Sort(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int result = 0;
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        result = array[i];
                        array[i] = array[j];
                        array[j] = result;
                    }
                }
            }
        }

        public static void Reverse(int[] array)
        {
            if (array == null || array.Length == 0) return;
            Array.Reverse(array);
            for (var i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
            }
        }

        public static int[] RemoveLast(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            return array;

        }

        public static int[] RemoveFirst(int[] array)
        {
            if (array == null || array.Length == 0) return array;

            return array;
        }

        public static int[] RemoveAt(int[] array, int index)
        {
            if (array == null || array.Length == 0) return array;
            return array;
        }

        public static int[] InsertFirst(int[] array, int number)
        {
            if (array == null || array.Length == 0) return array;
            return array;
        }

        public static int[] InsertLast(int[] array, int number)
        {
            if (array == null || array.Length == 0) return array;
            return array;
        }

        public static int[] InsertAt(int[] array, int number, int index)
        {

            if (array == null || array.Length == 0)
            {
                if (array != null && array.Length == 0 && index != 0)
                {
                    return array;
                }

                var newArray = new[] {number};
                return newArray;
            }
      
            var tempArray = new int[array.Length + 1];
                     
            for (var i = 0; i < array.Length; i++)
            {
                if (i < index)
                    tempArray[i] = array[i];
                else if (i == index)
                    tempArray[i] = number;
                else
                    tempArray[i] = array[i - 1];
            }
            
            return tempArray;
        }
    }
}
