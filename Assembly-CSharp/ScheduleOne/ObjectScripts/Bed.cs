using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000981 RID: 2433
	[Token(Token = "0x2000981")]
	public class Bed : NetworkBehaviour
	{
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A1D")]
		public Employee AssignedEmployee
		{
			[Token(Token = "0x6004138")]
			[Address(RVA = "0x86DD90", Offset = "0x86CF90", VA = "0x18086DD90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004139 RID: 16697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004139")]
		[Address(RVA = "0x86D420", Offset = "0x86C620", VA = "0x18086D420", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600413A RID: 16698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413A")]
		[Address(RVA = "0x86DAA0", Offset = "0x86CCA0", VA = "0x18086DAA0")]
		public void Hovered()
		{
		}

		// Token: 0x0600413B RID: 16699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413B")]
		[Address(RVA = "0x86DC80", Offset = "0x86CE80", VA = "0x18086DC80")]
		public void Interacted()
		{
		}

		// Token: 0x0600413C RID: 16700 RVA: 0x00012750 File Offset: 0x00010950
		[Token(Token = "0x600413C")]
		[Address(RVA = "0x86D560", Offset = "0x86C760", VA = "0x18086D560")]
		private bool CanSleep(out string noSleepReason)
		{
			return default(bool);
		}

		// Token: 0x0600413D RID: 16701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413D")]
		[Address(RVA = "0x86D310", Offset = "0x86C510", VA = "0x18086D310")]
		public void UpdateMaterial()
		{
		}

		// Token: 0x0600413E RID: 16702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413E")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public Bed()
		{
		}

		// Token: 0x0600413F RID: 16703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600413F")]
		[Address(RVA = "0x86DD70", Offset = "0x86CF70", VA = "0x18086DD70", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004140 RID: 16704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004140")]
		[Address(RVA = "0x86DD50", Offset = "0x86CF50", VA = "0x18086DD50", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004141 RID: 16705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004141")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004142 RID: 16706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004142")]
		[Address(RVA = "0x86D310", Offset = "0x86C510", VA = "0x18086D310")]
		private void Awake_UserLogic_ScheduleOne.ObjectScripts.Bed_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002F75 RID: 12149
		[Token(Token = "0x4002F75")]
		public const int MIN_SLEEP_TIME = 1800;

		// Token: 0x04002F76 RID: 12150
		[Token(Token = "0x4002F76")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Header("References")]
		protected InteractableObject intObj;

		// Token: 0x04002F77 RID: 12151
		[Token(Token = "0x4002F77")]
		[FieldOffset(Offset = "0x120")]
		public EmployeeHome EmployeeStationThing;

		// Token: 0x04002F78 RID: 12152
		[Token(Token = "0x4002F78")]
		[FieldOffset(Offset = "0x128")]
		public MeshRenderer BlanketMesh;

		// Token: 0x04002F79 RID: 12153
		[Token(Token = "0x4002F79")]
		[FieldOffset(Offset = "0x130")]
		[Header("Materials")]
		public Material DefaultBlanket;

		// Token: 0x04002F7A RID: 12154
		[Token(Token = "0x4002F7A")]
		[FieldOffset(Offset = "0x138")]
		public Material BotanistBlanket;

		// Token: 0x04002F7B RID: 12155
		[Token(Token = "0x4002F7B")]
		[FieldOffset(Offset = "0x140")]
		public Material ChemistBlanket;

		// Token: 0x04002F7C RID: 12156
		[Token(Token = "0x4002F7C")]
		[FieldOffset(Offset = "0x148")]
		public Material PackagerBlanket;

		// Token: 0x04002F7D RID: 12157
		[Token(Token = "0x4002F7D")]
		[FieldOffset(Offset = "0x150")]
		public Material CleanerBlanket;

		// Token: 0x04002F7E RID: 12158
		[Token(Token = "0x4002F7E")]
		[FieldOffset(Offset = "0x158")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F7F RID: 12159
		[Token(Token = "0x4002F7F")]
		[FieldOffset(Offset = "0x159")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted;
	}
}
