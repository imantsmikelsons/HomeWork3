﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class Telefons

    {
        public string Size { get; set; }

        public string Model { get; set; }

        public string Mark { get; set; }

        public void Call()
        {
        }
        public void SMS()
        {
        }

    }
}



public class Car
{
    public string Brand { get; set; }
    public string NumberPlate { get; set; }
    public double Speed { get; set; }

    public void StartToDrive()
    {
        Speed = 10;
        Console.WriteLine("Sākam braukt");
    }

    public double GoFaster()
    {
        Speed += 10;
        Console.WriteLine("Ātrums - " + Speed);
        return Speed;
    }

    public void Beep()
    {
        Console.WriteLine("Beep");
    }

    public double SlowDown()
    {
        Speed -= 10;
        Console.WriteLine("Ātrums - " + Speed);
        return Speed;
    }

    public void Stop()
    {
        Speed = 0;
        Console.WriteLine("Apstāšanās");
    }
}