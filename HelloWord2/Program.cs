using System;
using System.Globalization;

namespace HelloWord2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Gabriel Souza";
            string profession = "Front End";
            int age = 19;
            string skills = "React, Tailwind e C#";

            Console.WriteLine($"Olá, meu nome é {name}, tenho {age}. Sou {profession} dev e minhas principais habilidades são: {skills}!");
        }
    }
}
