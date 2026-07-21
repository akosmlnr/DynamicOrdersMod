using System;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class DeadDropState
    {
        public string DropGuid;
        public string DropName;
        public string Region;
        public float Heat;
        public bool IsDiscovered;
        public bool IsOccupied;
    }
}
