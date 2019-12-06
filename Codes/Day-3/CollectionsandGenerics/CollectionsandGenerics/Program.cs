using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsandGenerics
{
    //class MyList<T> //where T : struct
    //{

    //}
    class Program
    {
        static void Main()
        {
            /*
            ArrayList al = new ArrayList();


            //int a = 12;
            ////Boxing: conversion of VT to RT
            //object objA = a;
            ////unboxing: conversion of RT back to the same/source VT
            //int b = (int)objA;
            ////long b = (int)objA;

            al.Add(12);
            al.Add('a');
            al.Add(12.34);
            al.Add("siemens");
            al.Insert(1, 'b');

            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.WriteLine();
            al.Remove('a');
            al.RemoveAt(2);

            foreach (object item in al)
            {
                Console.WriteLine(item);
            }
            */
            //collection initializer
            List<int> list = new List<int> { 1, 4, 2, 3, 6, 7, 5, 9, 8, 0 };
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //implicit typed local variable (x)
            int a;
            a = 10;
            var x = 20;// value must be assigned to implicitly typed local variable, so that actual type can be 'inferred'
        }
    }
}
