using System;

namespace DynamicOrdersMod.Models
{
    public enum ActiveEventType { PoliceCrackdown, SupplyShortage }

    [Serializable]
    public class ActiveEvent
    {
        public ActiveEventType Type;
        public int StartDay;
        public int EndDay;
        public string Region;    // For PoliceCrackdown
        public string DrugType;  // For SupplyShortage
    }
}
