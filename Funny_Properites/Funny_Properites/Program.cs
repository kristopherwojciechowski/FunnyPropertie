﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funny_Properites
{
    class Program
    {
        static void Main(string[] args)
        {
            #region opisu brak

            //Console.WriteLine("podaj minimalna liczbe:");
            //String positivIntegerMin = Console.ReadLine();

            //Console.WriteLine("podaj maksymalna liczbe:");
            //String positivIntegerMax = Console.ReadLine();

            //int p, tempNum, h;
            //for (h = Int32.Parse(positivIntegerMin); h <= Int32.Parse(positivIntegerMax); h++)
            //{
            //    String positivInteger = h.ToString();
            //    for (p = 0; p <= 11; p++)
            //    {
            //        double sum = 0;
            //        for (int m = 1; m <= positivInteger.Length; m++)
            //        {
            //            tempNum = Int32.Parse(positivInteger.Substring(m - 1, 1));
            //            sum = sum + Math.Pow(Convert.ToDouble(tempNum), Convert.ToDouble(p + m - 1));
            //        }
            //        double resztaZDzielenie = sum % double.Parse(positivInteger);

            //        if (resztaZDzielenie == 0)
            //        {
            //            Console.WriteLine();
            //            Console.WriteLine("liczba: {0}", h);
            //            Console.WriteLine("p poczatkowe = {0}", p);
            //            Console.WriteLine("czynik skalujacy wynosi: {0}", sum / double.Parse(positivInteger));
            //        }
            //    }
            //}

            //int[] arr = new int[7] { 14, 12, -7, -3, -5, 3, -2 };
            //int[] arr = new int[6] { -5, 11, 11, 2, -1, 1 };

            //Console.WriteLine("Array: ");
            //for (int m = 0; m<arr.Length; m++)
            //{
            //    Console.WriteLine("m = {0}, arr[{0}] = {1} ",m, arr[m]);
            //}

            //Console.WriteLine();

            //int minPositivValue = arr[0];
            //int maxNegativValue = arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] >= 0)
            //    {
            //        if (Math.Abs(arr[i]) <= Math.Abs(minPositivValue))
            //        {
            //            minPositivValue = arr[i];
            //        }
            //    }
            //    else
            //    {
            //        if (Math.Abs(arr[i]) <= Math.Abs(maxNegativValue))
            //        {
            //            maxNegativValue = arr[i];
            //        }
            //    }
            //    Console.WriteLine("roznica: {0}; ", minPositivValue);
            //    Console.WriteLine("Dla wartosci ujemnych:");
            //    Console.WriteLine("roznica: {0}; ", maxNegativValue);
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //int abs1 = Math.Abs(maxNegativValue);
            //int abs2 = Math.Abs(minPositivValue);

            //if (abs1 == abs2)
            //{
            //    Console.WriteLine("jest wiecej niz jedno rozwiazania");
            //}
            //else if (abs1 < abs2)
            //{
            //    Console.WriteLine("rozwizaniem jest: " + maxNegativValue);
            //}
            //else
            //{
            //    Console.WriteLine("rozwizaniem jest: " + minPositivValue);
            //}

            ////Console.WriteLine(DigPow.digPow(46288, 3));
            ////Console.WriteLine(digPow(46288, 3));
            //Console.WriteLine();

            //Console.WriteLine("klasa Kata; wynik: " + Kata.Closest(arr));

            #endregion 

            //Fighter fighter01 = new Fighter("ogryzka", 30);
            //Fighter fighter02 = new Fighter("John", 11);

            //Random rand = new Random();

            Fighter fighter01 = new Fighter();
            Fighter fighter02 = new Fighter();

            Fighter.CreateFighter(fighter01);
            Console.WriteLine();
            Fighter.CreateFighter(fighter02);
            Console.WriteLine();


            Fighter winner = new Fighter();

            Console.WriteLine();
            #region  this part is replaced with methode from Fighter class
            //int hit1, hit2, i = 0;
            //do
            //{
            //    hit1 = rand.Next(10);
            //    hit2 = rand.Next(10);
            //    if (hit1 > hit2)
            //    {
            //        Console.WriteLine("hit_1 = {0}, hit_2 = {1}", hit1, hit2);
            //        fighter02.health = fighter02.health - hit1;
            //        Console.WriteLine("john health: " + fighter02.health);
            //    }
            //    else
            //    {
            //        Console.WriteLine("hit 2 > hit 1");
            //    }

            //    hit1 = rand.Next(10);
            //    hit2 = rand.Next(10);
            //    if (hit1 < hit2)
            //    {
            //        Console.WriteLine("hit_1 = {0}, hit_2 = {1}", hit1, hit2);
            //        fighter01.health = fighter01.health - hit2;
            //        Console.WriteLine("jas health: " + fighter01.health);
            //    }
            //    else
            //    {
            //        Console.WriteLine("hit 1 > hit 2");
            //    }
            //    i++;
            //    Console.WriteLine("koniec rundy {0}", i);
            //    Console.WriteLine();

            //    if (fighter01.health <= 0)
            //    {
            //        winner.name = fighter02.name;
            //    }

            //    if (fighter02.health <= 0)
            //    {
            //        winner.name = fighter01.name;
            //    }

            //} while (fighter01.health > 0 && fighter02.health > 0);

            //Console.WriteLine();
            //Console.WriteLine("The winner is: " + winner.name);

            #endregion
            string decision;
            do
            {
                Console.WriteLine("{0} health = {1}", fighter01.name, fighter01.health);
                Console.WriteLine("{0} health = {1}", fighter02.name, fighter02.health);

                int fighter01Health = fighter01.health;
                int fighter02Health = fighter02.health;

                Console.WriteLine("Would you like to fight??");
                Console.WriteLine("type: y/n");
                decision = Console.ReadLine();

                if (decision != "y" && decision != "n")
                {
                    Console.WriteLine("type: y/n");
                }
                else if(decision == "y")
                {
                    winner = Fighter.fight(fighter01, fighter02);
                    Console.WriteLine("The winner is: " + winner.name);
                    Console.WriteLine();
                    if (winner == fighter01)
                    {
                        fighter01.health = fighter01Health + 5;
                        Console.WriteLine("{0} health = {1}", fighter01.name, fighter01.health);
                        fighter02.health = fighter02Health;
                        Console.WriteLine("{0} health = {1}", fighter02.name, fighter02.health);
                    }
                    else
                    {
                        fighter01.health = fighter01Health;
                        Console.WriteLine("{0} health = {1}", fighter01.name, fighter01.health);
                        fighter02.health = fighter02Health + 5;
                        Console.WriteLine("{0} health = {1}", fighter02.name, fighter02.health);
                    }
                } else
                {
                    Console.WriteLine("NO FIGHT");
                }
                Console.WriteLine();
            } while (decision != "n");


            Console.WriteLine();
            //Console.WriteLine("(Metoda)The winner is: " + Fighter.fight(fighter01, fighter02));

            Console.ReadKey();
        }
    }
}
