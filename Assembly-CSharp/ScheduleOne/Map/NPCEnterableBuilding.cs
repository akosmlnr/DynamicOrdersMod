using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Doors;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000539 RID: 1337
	[Token(Token = "0x2000539")]
	[DisallowMultipleComponent]
	public class NPCEnterableBuilding : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000559")]
		public Guid GUID
		{
			[Token(Token = "0x6001D89")]
			[Address(RVA = "0x495C00", Offset = "0x494E00", VA = "0x180495C00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6001D8A")]
			[Address(RVA = "0x495C10", Offset = "0x494E10", VA = "0x180495C10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x1700055A")]
		public int OccupantCount
		{
			[Token(Token = "0x6001D8B")]
			[Address(RVA = "0x629760", Offset = "0x628960", VA = "0x180629760")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8C")]
		[Address(RVA = "0x628BD0", Offset = "0x627DD0", VA = "0x180628BD0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8D")]
		[Address(RVA = "0x629700", Offset = "0x628900", VA = "0x180629700", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8E")]
		[Address(RVA = "0x629180", Offset = "0x628380", VA = "0x180629180", Slot = "8")]
		public virtual void NPCEnteredBuilding(NPC npc, StaticDoor door)
		{
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D8F")]
		[Address(RVA = "0x629460", Offset = "0x628660", VA = "0x180629460", Slot = "9")]
		public virtual void NPCExitedBuilding(NPC npc, StaticDoor door)
		{
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D90")]
		[Address(RVA = "0x629000", Offset = "0x628200", VA = "0x180629000")]
		[Button]
		public void GetDoors()
		{
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x629050", Offset = "0x628250", VA = "0x180629050")]
		public List<NPC> GetSummonableNPCs()
		{
			return null;
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x628EA0", Offset = "0x6280A0", VA = "0x180628EA0")]
		public StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			return null;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x625610", Offset = "0x624810", VA = "0x180625610")]
		public NPCEnterableBuilding()
		{
		}

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		public const float DOOR_SOUND_DISTANCE_LIMIT = 15f;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public string BuildingName;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public StaticDoor[] Doors;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x48")]
		[Header("Readonly")]
		[SerializeField]
		private List<NPC> Occupants;
	}
}
