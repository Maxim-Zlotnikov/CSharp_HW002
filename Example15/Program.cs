﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
    // 6 -> да
    // 7 -> да
    // 1 -> нет

System.Console.Clear();

Console.WriteLine("Введите номер дня недели: ");
int i = Convert.ToInt32(Console.ReadLine());

if (i >= 1 & i <= 5) Console.WriteLine("Будний день");
if (i == 6 | i == 7) Console.WriteLine("Выходной");
if (i > 7 | i < 1) Console.WriteLine("Такого дня не существует");