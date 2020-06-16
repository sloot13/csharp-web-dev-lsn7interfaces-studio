using System;
namespace SpinningDiscs
{
    public class DVD : MediaStorage, IOpticalDisc
    {
        public DVD(string name, int storageCapacity, int capacityUsed, string diskType) : base(name, storageCapacity, capacityUsed, diskType)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Sorry, I'm afraid I can't do that.");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
    }
}
