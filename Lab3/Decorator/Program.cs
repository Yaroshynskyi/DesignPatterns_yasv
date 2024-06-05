using Decorator;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var warrior = new Warrior("Warrior", 10);
        var mage = new Mage("Mage", 10);
        var paladin = new Paladin("Paladin", 10);

        warrior.AddInventory(new Armor());
        warrior.AddInventory(new Weapon());
        mage.AddInventory(new Weapon());
        paladin.AddInventory(new Artifact());

        Console.WriteLine("Warrior inventory:");
        warrior.ShowInventory();
        Console.WriteLine();

        Console.WriteLine("Mage inventory:");
        mage.ShowInventory();
        Console.WriteLine();

        Console.WriteLine("Paladin inventory:");
        paladin.ShowInventory();
    }
}