using System;
using Il2CppDummyDll;
using ScheduleOne.Configuration;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.Core.Settings;
using UnityEngine;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x0200096B RID: 2411
	[Token(Token = "0x200096B")]
	[CreateAssetMenu(fileName = "EquipConfiguration", menuName = "ScheduleOne/Configurations/EquipConfiguration", order = 1)]
	public class EquipConfiguration : Configuration<EquipSettings>
	{
		// Token: 0x06004080 RID: 16512 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x6004080")]
		[Address(RVA = "0x84FD00", Offset = "0x84EF00", VA = "0x18084FD00")]
		public bool TryGetHandlerForData(Type handlerType, out IEquippedItemHandler handler)
		{
			return default(bool);
		}

		// Token: 0x06004081 RID: 16513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004081")]
		[Address(RVA = "0x84FEB0", Offset = "0x84F0B0", VA = "0x18084FEB0")]
		public EquipConfiguration()
		{
		}

		// Token: 0x04002F14 RID: 12052
		[Token(Token = "0x4002F14")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public EquippedItemHandler[] Handlers;
	}
}
