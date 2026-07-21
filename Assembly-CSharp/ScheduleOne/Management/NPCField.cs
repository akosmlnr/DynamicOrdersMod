using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x0200057C RID: 1404
	[Token(Token = "0x200057C")]
	public class NPCField : ConfigField
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A6")]
		public NPC SelectedNPC
		{
			[Token(Token = "0x6001FFB")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001FFC")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x6463F0", Offset = "0x6455F0", VA = "0x1806463F0")]
		public NPCField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x646310", Offset = "0x645510", VA = "0x180646310")]
		public void SetNPC(NPC npc, bool network)
		{
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x646030", Offset = "0x645230", VA = "0x180646030")]
		public bool DoesNPCMatchRequirement(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x6461D0", Offset = "0x6453D0", VA = "0x1806461D0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x6460F0", Offset = "0x6452F0", VA = "0x1806460F0")]
		public NPCFieldData GetData()
		{
			return null;
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x646220", Offset = "0x645420", VA = "0x180646220")]
		public void Load(NPCFieldData data)
		{
		}

		// Token: 0x04001A37 RID: 6711
		[Token(Token = "0x4001A37")]
		[FieldOffset(Offset = "0x20")]
		public Type TypeRequirement;

		// Token: 0x04001A38 RID: 6712
		[Token(Token = "0x4001A38")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<NPC> onNPCChanged;
	}
}
