using _2_AbsctractFactory;
using System;

class Program
{
    static void Main(string[] args)
    {
        DeviceFactory balaxyFactory = new BalaxyFactory();
        DeviceFactory kiaomiFactory = new KiaomiFactory();
        DeviceFactory iProneFactory = new IProneFactory();

        Device laptop = balaxyFactory.CreateLaptop();
        Device netbook = kiaomiFactory.CreateNetbook();
        Device smartphone = iProneFactory.CreateSmartphone();

        laptop.DisplayInfo();
        netbook.DisplayInfo();
        smartphone.DisplayInfo();
    }
}