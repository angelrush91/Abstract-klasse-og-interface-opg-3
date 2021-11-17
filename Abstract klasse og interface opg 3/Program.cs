using Abstract_klasse_og_interface_opg_3;
using System;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//de forskellige objekter af biler oprettes
Bil bil = new Bil();
Bil bil2 = new Bil();
Bil bil3 = new Bil();
// her declareres mængden af brændstof i bilerne
bil.getsetBrændstof = 100;
bil2.getsetBrændstof = 0;
bil3.getsetBrændstof = 50;
//arrayobjekt med biler
Bil[] biler = { bil, bil2, bil3 };

//forloop hvor jeg kører arrayet igennem og bruger metoderne i en if statement
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


