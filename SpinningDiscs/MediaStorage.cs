using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class MediaStorage
    {
        public string Name { get; set; }
        public int StorageCapacity { get; set; }
        public int CapacityUsed { get; set; }
        public string DiskType { get; set; }

        protected MediaStorage()
        {
        }

        protected MediaStorage(string name, int storageCapacity, int capacityUsed, string diskType)
        {
            Name = name;
            StorageCapacity = storageCapacity;
            CapacityUsed = capacityUsed;
            DiskType = diskType;
        }

        public int SpaceLeft()
        {
            return StorageCapacity - CapacityUsed;
        }

        public string DiskInfo()
        {
            string output = $"Disk Name: {Name}\nMax Capacity: {StorageCapacity}\nSpace Used: {CapacityUsed}\nAvailabe Storage: {SpaceLeft()}\n";
            return output;
        }

        public string WriteData(int size)
        {
            if (size > SpaceLeft())
            {
                return "Not enough space!";
            }

            CapacityUsed += size;
            

            return $"Data written to disc. Remaining space = {SpaceLeft()}";
        }
    }
}
