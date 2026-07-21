using System;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class WholesaleRecord
    {
        public int Week;
        public string CustomerGuid;
        public float Amount;
    }
}