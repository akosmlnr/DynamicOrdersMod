using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	[RequireComponent(typeof(BoxCollider))]
	public class TrashGenerator : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700086C")]
		public string SaveFolderName
		{
			[Token(Token = "0x600357F")]
			[Address(RVA = "0x7D72C0", Offset = "0x7D64C0", VA = "0x1807D72C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06003580 RID: 13696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700086D")]
		public string SaveFileName
		{
			[Token(Token = "0x6003580")]
			[Address(RVA = "0x7D7250", Offset = "0x7D6450", VA = "0x1807D7250", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700086E")]
		public Loader Loader
		{
			[Token(Token = "0x6003581")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003582 RID: 13698 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x1700086F")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003582")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000870")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003583")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003584")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000871")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003585")]
			[Address(RVA = "0x4C0310", Offset = "0x4BF510", VA = "0x1804C0310", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003586")]
			[Address(RVA = "0x5D63B0", Offset = "0x5D55B0", VA = "0x1805D63B0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x00010098 File Offset: 0x0000E298
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000872")]
		public bool HasChanged
		{
			[Token(Token = "0x6003587")]
			[Address(RVA = "0x49B030", Offset = "0x49A230", VA = "0x18049B030", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003588")]
			[Address(RVA = "0x49B240", Offset = "0x49A440", VA = "0x18049B240", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x000100B0 File Offset: 0x0000E2B0
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000873")]
		public Guid GUID
		{
			[Token(Token = "0x6003589")]
			[Address(RVA = "0x7D7240", Offset = "0x7D6440", VA = "0x1807D7240", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600358A")]
			[Address(RVA = "0x7D7330", Offset = "0x7D6530", VA = "0x1807D7330")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600358B RID: 13707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358B")]
		[Address(RVA = "0x7D6CB0", Offset = "0x7D5EB0", VA = "0x1807D6CB0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x7D5D40", Offset = "0x7D4F40", VA = "0x1807D5D40")]
		private void Awake()
		{
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x7D6E40", Offset = "0x7D6040", VA = "0x1807D6E40")]
		private void Start()
		{
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x7D6800", Offset = "0x7D5A00", VA = "0x1807D6800", Slot = "30")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x7D6B20", Offset = "0x7D5D20", VA = "0x1807D6B20")]
		private void OnValidate()
		{
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x7D6890", Offset = "0x7D5A90", VA = "0x1807D6890")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x7D6910", Offset = "0x7D5B10", VA = "0x1807D6910")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003592")]
		[Address(RVA = "0x7D5A80", Offset = "0x7D4C80", VA = "0x1807D5A80")]
		public void AddGeneratedTrash(TrashItem item)
		{
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003593")]
		[Address(RVA = "0x7D6B80", Offset = "0x7D5D80", VA = "0x1807D6B80")]
		public void RemoveGeneratedTrash(TrashItem item)
		{
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003594")]
		[Address(RVA = "0x7200F0", Offset = "0x71F2F0", VA = "0x1807200F0")]
		[Button]
		private void RegenerateGUID()
		{
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003595")]
		[Address(RVA = "0x7D5BE0", Offset = "0x7D4DE0", VA = "0x1807D5BE0")]
		[Button]
		private void AutoCalculateTrashCount()
		{
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003596")]
		[Address(RVA = "0x7D5E10", Offset = "0x7D5010", VA = "0x1807D5E10")]
		[Button]
		private void GenerateMaxTrash()
		{
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003597")]
		[Address(RVA = "0x7D6D60", Offset = "0x7D5F60", VA = "0x1807D6D60")]
		private void SleepStart()
		{
		}

		// Token: 0x06003598 RID: 13720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003598")]
		[Address(RVA = "0x7D5E60", Offset = "0x7D5060", VA = "0x1807D5E60")]
		private void GenerateTrash(int count)
		{
		}

		// Token: 0x06003599 RID: 13721 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x6003599")]
		[Address(RVA = "0x7D6D10", Offset = "0x7D5F10", VA = "0x1807D6D10")]
		public bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600359A")]
		[Address(RVA = "0x7D6620", Offset = "0x7D5820", VA = "0x1807D6620", Slot = "31")]
		public virtual TrashGeneratorData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600359B")]
		[Address(RVA = "0x7D67C0", Offset = "0x7D59C0", VA = "0x1807D67C0", Slot = "18")]
		public string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600359C")]
		[Address(RVA = "0x7D7110", Offset = "0x7D6310", VA = "0x1807D7110")]
		public TrashGenerator()
		{
		}

		// Token: 0x040026D6 RID: 9942
		[Token(Token = "0x40026D6")]
		public const float TRASH_GENERATION_FRACTION = 0.2f;

		// Token: 0x040026D7 RID: 9943
		[Token(Token = "0x40026D7")]
		public const float DEFAULT_TRASH_PER_M2 = 0.015f;

		// Token: 0x040026D8 RID: 9944
		[Token(Token = "0x40026D8")]
		[FieldOffset(Offset = "0x0")]
		public static List<TrashGenerator> AllGenerators;

		// Token: 0x040026D9 RID: 9945
		[Token(Token = "0x40026D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Range(1f, 200f)]
		private int MaxTrashCount;

		// Token: 0x040026DA RID: 9946
		[Token(Token = "0x40026DA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private int TrashCountMultiplier;

		// Token: 0x040026DB RID: 9947
		[Token(Token = "0x40026DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<TrashItem> generatedTrash;

		// Token: 0x040026DC RID: 9948
		[Token(Token = "0x40026DC")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public LayerMask GroundCheckMask;

		// Token: 0x040026DD RID: 9949
		[Token(Token = "0x40026DD")]
		[FieldOffset(Offset = "0x38")]
		private BoxCollider boxCollider;

		// Token: 0x040026E2 RID: 9954
		[Token(Token = "0x40026E2")]
		[FieldOffset(Offset = "0x68")]
		public string StaticGUID;
	}
}
