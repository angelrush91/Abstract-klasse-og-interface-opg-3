using Abstract_klasse_og_interface_opg_3;
using System;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Bil bil = new Bil();
Bil bil2 = new Bil();
Bil bil3 = new Bil();

bil.getsetBrændstof = 100;
bil2.getsetBrændstof = 0;
bil3.getsetBrændstof = 50;

Bil[] biler = { bil, bil2, bil3 };
for (int i = 0; i < biler.Length; i++)
{
    if (biler[i].Fuel(biler[i].getsetBrændstof) == true)
    {
        biler[i].Kør();
    }
    else
    {
        Console.WriteLine("ha der er ikke noget brændstof ");
    }
}


