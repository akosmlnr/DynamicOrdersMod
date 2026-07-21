using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.NPCs.Relation
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	[Serializable]
	public class NPCRelationData
	{
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06004D34 RID: 19764 RVA: 0x00014C10 File Offset: 0x00012E10
		// (set) Token: 0x06004D35 RID: 19765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF7")]
		public float RelationDelta
		{
			[Token(Token = "0x6004D34")]
			[Address(RVA = "0x475910", Offset = "0x474B10", VA = "0x180475910")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004D35")]
			[Address(RVA = "0x492A10", Offset = "0x491C10", VA = "0x180492A10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06004D36 RID: 19766 RVA: 0x00014C28 File Offset: 0x00012E28
		[Token(Token = "0x17000BF8")]
		public float NormalizedRelationDelta
		{
			[Token(Token = "0x6004D36")]
			[Address(RVA = "0x93EFC0", Offset = "0x93E1C0", VA = "0x18093EFC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06004D37 RID: 19767 RVA: 0x00014C40 File Offset: 0x00012E40
		// (set) Token: 0x06004D38 RID: 19768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BF9")]
		public bool Unlocked
		{
			[Token(Token = "0x6004D37")]
			[Address(RVA = "0x66E350", Offset = "0x66D550", VA = "0x18066E350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004D38")]
			[Address(RVA = "0x66E360", Offset = "0x66D560", VA = "0x18066E360")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06004D39 RID: 19769 RVA: 0x00014C58 File Offset: 0x00012E58
		// (set) Token: 0x06004D3A RID: 19770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFA")]
		public NPCRelationData.EUnlockType UnlockType
		{
			[Token(Token = "0x6004D39")]
			[Address(RVA = "0x457F70", Offset = "0x457170", VA = "0x180457F70")]
			[CompilerGenerated]
			get
			{
				return NPCRelationData.EUnlockType.Recommendation;
			}
			[Token(Token = "0x6004D3A")]
			[Address(RVA = "0x49BD70", Offset = "0x49AF70", VA = "0x18049BD70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06004D3B RID: 19771 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004D3C RID: 19772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BFB")]
		public NPC NPC
		{
			[Token(Token = "0x6004D3B")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D3C")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x06004D3D RID: 19773 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BFC")]
		public List<NPC> Connections
		{
			[Token(Token = "0x6004D3D")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D3E")]
		[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
		public void SetNPC(NPC npc)
		{
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D3F")]
		[Address(RVA = "0x93E810", Offset = "0x93DA10", VA = "0x18093E810")]
		public void Init(NPC npc)
		{
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D40")]
		[Address(RVA = "0x93E3A0", Offset = "0x93D5A0", VA = "0x18093E3A0", Slot = "4")]
		public virtual void ChangeRelationship(float deltaChange, bool network = true)
		{
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D41")]
		[Address(RVA = "0x93EBF0", Offset = "0x93DDF0", VA = "0x18093EBF0", Slot = "5")]
		public virtual void SetRelationship(float newDelta, bool network = true)
		{
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x93EEE0", Offset = "0x93E0E0", VA = "0x18093EEE0", Slot = "6")]
		public virtual void Unlock(NPCRelationData.EUnlockType type, bool notify = true)
		{
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x93EDF0", Offset = "0x93DFF0", VA = "0x18093EDF0", Slot = "7")]
		public virtual void UnlockConnections()
		{
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D44")]
		[Address(RVA = "0x93E780", Offset = "0x93D980", VA = "0x18093E780")]
		public RelationshipData GetSaveData()
		{
			return null;
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x93E3C0", Offset = "0x93D5C0", VA = "0x18093E3C0")]
		public float GetAverageMutualRelationship()
		{
			return 0f;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x6004D46")]
		[Address(RVA = "0x93E9C0", Offset = "0x93DBC0", VA = "0x18093E9C0")]
		public bool IsKnown()
		{
			return default(bool);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x6004D47")]
		[Address(RVA = "0x93EAE0", Offset = "0x93DCE0", VA = "0x18093EAE0")]
		public bool IsMutuallyKnown()
		{
			return default(bool);
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D48")]
		[Address(RVA = "0x93E4C0", Offset = "0x93D6C0", VA = "0x18093E4C0")]
		public List<NPC> GetLockedConnections(bool excludeCustomers = false)
		{
			return null;
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D49")]
		[Address(RVA = "0x93E590", Offset = "0x93D790", VA = "0x18093E590")]
		public List<NPC> GetLockedDealers(bool excludeRecommended)
		{
			return null;
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x93E660", Offset = "0x93D860", VA = "0x18093E660")]
		public List<NPC> GetLockedSuppliers()
		{
			return null;
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x93EF10", Offset = "0x93E110", VA = "0x18093EF10")]
		public NPCRelationData()
		{
		}

		// Token: 0x0400361F RID: 13855
		[Token(Token = "0x400361F")]
		public const float MinDelta = 0f;

		// Token: 0x04003620 RID: 13856
		[Token(Token = "0x4003620")]
		public const float MaxDelta = 5f;

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		public const float DEFAULT_RELATION_DELTA = 2f;

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected List<NPC> FullGameConnections;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected List<NPC> DemoConnections;

		// Token: 0x04003628 RID: 13864
		[Token(Token = "0x4003628")]
		[FieldOffset(Offset = "0x38")]
		public Action<float> onRelationshipChange;

		// Token: 0x04003629 RID: 13865
		[Token(Token = "0x4003629")]
		[FieldOffset(Offset = "0x40")]
		public Action<NPCRelationData.EUnlockType, bool> onUnlocked;

		// Token: 0x02000A71 RID: 2673
		[Token(Token = "0x2000A71")]
		public enum EUnlockType
		{
			// Token: 0x0400362B RID: 13867
			[Token(Token = "0x400362B")]
			Recommendation,
			// Token: 0x0400362C RID: 13868
			[Token(Token = "0x400362C")]
			DirectApproach
		}
	}
}
