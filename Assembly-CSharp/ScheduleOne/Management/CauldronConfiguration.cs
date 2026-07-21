using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.ObjectScripts;

namespace ScheduleOne.Management
{
	// Token: 0x02000569 RID: 1385
	[Token(Token = "0x2000569")]
	public class CauldronConfiguration : EntityConfiguration
	{
		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001F1A RID: 7962 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F1B RID: 7963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000585")]
		public Cauldron Station
		{
			[Token(Token = "0x6001F1A")]
			[Address(RVA = "0x492B20", Offset = "0x491D20", VA = "0x180492B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F1B")]
			[Address(RVA = "0x4D1C60", Offset = "0x4D0E60", VA = "0x1804D1C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000586")]
		public TransitRoute DestinationRoute
		{
			[Token(Token = "0x6001F1C")]
			[Address(RVA = "0x497910", Offset = "0x496B10", VA = "0x180497910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F1D")]
			[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1E")]
		[Address(RVA = "0x638BA0", Offset = "0x637DA0", VA = "0x180638BA0")]
		public CauldronConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cauldron cauldron)
		{
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x6383F0", Offset = "0x6375F0", VA = "0x1806383F0", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F20")]
		[Address(RVA = "0x638800", Offset = "0x637A00", VA = "0x180638800")]
		private void DestinationChanged(BuildableItem item)
		{
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x6001F21")]
		[Address(RVA = "0x638940", Offset = "0x637B40", VA = "0x180638940")]
		public bool DestinationFilter(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F22")]
		[Address(RVA = "0x638430", Offset = "0x637630", VA = "0x180638430", Slot = "7")]
		public override void Selected()
		{
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F23")]
		[Address(RVA = "0x6380D0", Offset = "0x6372D0", VA = "0x1806380D0", Slot = "8")]
		public override void Deselected()
		{
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6001F24")]
		[Address(RVA = "0x638B00", Offset = "0x637D00", VA = "0x180638B00", Slot = "9")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06001F25 RID: 7973 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001F25")]
		[Address(RVA = "0x638A50", Offset = "0x637C50", VA = "0x180638A50", Slot = "10")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x040019D3 RID: 6611
		[Token(Token = "0x40019D3")]
		[FieldOffset(Offset = "0x48")]
		public NPCField AssignedChemist;

		// Token: 0x040019D4 RID: 6612
		[Token(Token = "0x40019D4")]
		[FieldOffset(Offset = "0x50")]
		public ObjectField Destination;
	}
}
