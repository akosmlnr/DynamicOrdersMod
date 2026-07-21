using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x02000977 RID: 2423
	[Token(Token = "0x2000977")]
	[RequireComponent(typeof(Player))]
	public class PlayerNetworkedEquipper : NetworkedEquipper
	{
		// Token: 0x060040C5 RID: 16581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C5")]
		[Address(RVA = "0x861610", Offset = "0x860810", VA = "0x180861610", Slot = "22")]
		public override void Awake()
		{
		}

		// Token: 0x060040C6 RID: 16582 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60040C6")]
		[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0", Slot = "19")]
		protected override IEquippableUser GetUser()
		{
			return null;
		}

		// Token: 0x060040C7 RID: 16583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C7")]
		[Address(RVA = "0x85ECD0", Offset = "0x85DED0", VA = "0x18085ECD0")]
		public PlayerNetworkedEquipper()
		{
		}

		// Token: 0x060040C8 RID: 16584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C8")]
		[Address(RVA = "0x85ECB0", Offset = "0x85DEB0", VA = "0x18085ECB0", Slot = "20")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060040C9 RID: 16585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x85EC50", Offset = "0x85DE50", VA = "0x18085EC50", Slot = "21")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060040CA RID: 16586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040CB")]
		[Address(RVA = "0x8615C0", Offset = "0x8607C0", VA = "0x1808615C0")]
		private void Awake_UserLogic_ScheduleOne.Equipping.Framework.PlayerNetworkedEquipper_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002F24 RID: 12068
		[Token(Token = "0x4002F24")]
		[FieldOffset(Offset = "0x130")]
		private Player _player;

		// Token: 0x04002F25 RID: 12069
		[Token(Token = "0x4002F25")]
		[FieldOffset(Offset = "0x138")]
		private bool NetworkInitialize___EarlyScheduleOne.Equipping.Framework.PlayerNetworkedEquipperAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F26 RID: 12070
		[Token(Token = "0x4002F26")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize__LateScheduleOne.Equipping.Framework.PlayerNetworkedEquipperAssembly-CSharp.dll_Excuted;
	}
}
