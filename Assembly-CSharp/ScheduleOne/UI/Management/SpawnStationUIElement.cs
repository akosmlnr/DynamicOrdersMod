using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.StationFramework;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DAB RID: 3499
	[Token(Token = "0x2000DAB")]
	public class SpawnStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x060064D3 RID: 25811 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064D4 RID: 25812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E63")]
		public MushroomSpawnStation AssignedStation
		{
			[Token(Token = "0x60064D3")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064D4")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064D5 RID: 25813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D5")]
		[Address(RVA = "0xA831E0", Offset = "0xA823E0", VA = "0x180A831E0")]
		public void Initialize(MushroomSpawnStation pack)
		{
		}

		// Token: 0x060064D6 RID: 25814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D6")]
		[Address(RVA = "0xA832C0", Offset = "0xA824C0", VA = "0x180A832C0", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064D7 RID: 25815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064D7")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SpawnStationUIElement()
		{
		}
	}
}
