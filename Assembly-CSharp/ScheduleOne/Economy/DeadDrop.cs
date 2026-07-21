using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006B0 RID: 1712
	[Token(Token = "0x20006B0")]
	public class DeadDrop : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06002CC2 RID: 11458 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		// (set) Token: 0x06002CC3 RID: 11459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700079C")]
		public Guid GUID
		{
			[Token(Token = "0x6002CC2")]
			[Address(RVA = "0x4F8550", Offset = "0x4F7750", VA = "0x1804F8550", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6002CC3")]
			[Address(RVA = "0x7206B0", Offset = "0x71F8B0", VA = "0x1807206B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x7200F0", Offset = "0x71F2F0", VA = "0x1807200F0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x71FC70", Offset = "0x71EE70", VA = "0x18071FC70", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x7200C0", Offset = "0x71F2C0", VA = "0x1807200C0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x7201A0", Offset = "0x71F3A0", VA = "0x1807201A0", Slot = "8")]
		protected virtual void Start()
		{
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x720140", Offset = "0x71F340", VA = "0x180720140", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x720040", Offset = "0x71F240", VA = "0x180720040")]
		public void OnDestroy()
		{
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x71FD90", Offset = "0x71EF90", VA = "0x18071FD90")]
		public static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			return null;
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x720460", Offset = "0x71F660", VA = "0x180720460")]
		private void UpdateDeadDrop()
		{
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x720640", Offset = "0x71F840", VA = "0x180720640")]
		public DeadDrop()
		{
		}

		// Token: 0x04002165 RID: 8549
		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x0")]
		public static List<DeadDrop> DeadDrops;

		// Token: 0x04002166 RID: 8550
		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x20")]
		public string DeadDropName;

		// Token: 0x04002167 RID: 8551
		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x28")]
		public string DeadDropDescription;

		// Token: 0x04002168 RID: 8552
		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x30")]
		public EMapRegion Region;

		// Token: 0x04002169 RID: 8553
		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x38")]
		public WorldStorageEntity Storage;

		// Token: 0x0400216A RID: 8554
		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x40")]
		public POI PoI;

		// Token: 0x0400216B RID: 8555
		[Token(Token = "0x400216B")]
		[FieldOffset(Offset = "0x48")]
		public OptimizedLight Light;

		// Token: 0x0400216C RID: 8556
		[Token(Token = "0x400216C")]
		[FieldOffset(Offset = "0x50")]
		public string ItemCountVariable;

		// Token: 0x0400216E RID: 8558
		[Token(Token = "0x400216E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected string BakedGUID;
	}
}
