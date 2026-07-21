using System;
using System.Collections.Generic;

namespace DynamicOrdersMod.Models
{
    [Serializable]
    public class ModSaveData
    {
        public int Version;
        public Dictionary<string, CustomerProfile> CustomerProfiles = new Dictionary<string, CustomerProfile>();
        public Dictionary<string, DeadDropState> DeadDropStates = new Dictionary<string, DeadDropState>();
        public List<ActiveEvent> ActiveEvents = new List<ActiveEvent>();
        public List<WholesaleRecord> WholesaleRecords = new List<WholesaleRecord>();
        public ModStatistics Statistics = new ModStatistics();
    }

    [Serializable]
    public class ModStatistics
    {
        public int TotalDeadDropsCompleted;
        public int TotalDeadDropsFailed;
        public int TotalOverdoses;
        public float TotalWholesaleRevenue;
    }
}