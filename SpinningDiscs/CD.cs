using System;
namespace SpinningDiscs
{
    public class CD : MediaStorage, IOpticalDisc
    {
        public CD(string name, int storageCapacity, int capacityUsed, string diskType) : base(name, storageCapacity, capacityUsed, diskType)
        {
        }

        public void ReadData()
        {
            Console.WriteLine("Would you like to play a game ?");
        }

        public void SpinDisc()
        {
            Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
        }
    }
}
