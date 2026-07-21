using System;
using Il2CppDummyDll;
using ScheduleOne.Core.Equipping.Framework;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Equipping.Framework
{
	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000976")]
	[RequireComponent(typeof(NPC))]
	public class NPCNetworkedEquipper : NetworkedEquipper
	{
		// Token: 0x060040BE RID: 16574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040BE")]
		[Address(RVA = "0x85EBD0", Offset = "0x85DDD0", VA = "0x18085EBD0", Slot = "22")]
		public override void Awake()
		{
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60040BF")]
		[Address(RVA = "0x5A44F0", Offset = "0x5A36F0", VA = "0x1805A44F0", Slot = "19")]
		protected override IEquippableUser GetUser()
		{
			return null;
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C0")]
		[Address(RVA = "0x85ECD0", Offset = "0x85DED0", VA = "0x18085ECD0")]
		public NPCNetworkedEquipper()
		{
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C1")]
		[Address(RVA = "0x85ECB0", Offset = "0x85DEB0", VA = "0x18085ECB0", Slot = "20")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C2")]
		[Address(RVA = "0x85EC50", Offset = "0x85DE50", VA = "0x18085EC50", Slot = "21")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C3")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040C4")]
		[Address(RVA = "0x85EB80", Offset = "0x85DD80", VA = "0x18085EB80")]
		private void Awake_UserLogic_ScheduleOne.Equipping.Framework.NPCNetworkedEquipper_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002F21 RID: 12065
		[Token(Token = "0x4002F21")]
		[FieldOffset(Offset = "0x130")]
		private NPC _npc;

		// Token: 0x04002F22 RID: 12066
		[Token(Token = "0x4002F22")]
		[FieldOffset(Offset = "0x138")]
		private bool NetworkInitialize___EarlyScheduleOne.Equipping.Framework.NPCNetworkedEquipperAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F23 RID: 12067
		[Token(Token = "0x4002F23")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize__LateScheduleOne.Equipping.Framework.NPCNetworkedEquipperAssembly-CSharp.dll_Excuted;
	}
}
