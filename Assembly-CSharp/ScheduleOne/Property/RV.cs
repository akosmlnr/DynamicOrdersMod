using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	// Token: 0x0200036D RID: 877
	[Token(Token = "0x200036D")]
	public class RV : Property
	{
		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x00009438 File Offset: 0x00007638
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000447")]
		public bool IsDestroyed
		{
			[Token(Token = "0x60015DB")]
			[Address(RVA = "0x5AC190", Offset = "0x5AB390", VA = "0x1805AC190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60015DC")]
			[Address(RVA = "0x5AC1A0", Offset = "0x5AB3A0", VA = "0x1805AC1A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DD")]
		[Address(RVA = "0x5AB8B0", Offset = "0x5AAAB0", VA = "0x1805AB8B0", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DE")]
		[Address(RVA = "0x5AB540", Offset = "0x5AA740", VA = "0x1805AB540", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015DF")]
		[Address(RVA = "0x5ABA90", Offset = "0x5AAC90", VA = "0x1805ABA90")]
		private void UpdateVariables()
		{
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x60015E0")]
		[Address(RVA = "0x5AB850", Offset = "0x5AAA50", VA = "0x1805AB850", Slot = "49")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E1")]
		[Address(RVA = "0x5AB1C0", Offset = "0x5AA3C0", VA = "0x1805AB1C0")]
		[Button]
		public void BlowUp()
		{
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E2")]
		[Address(RVA = "0x5AB720", Offset = "0x5AA920", VA = "0x1805AB720")]
		[TargetRpc]
		private void SetDestroyed_Client(NetworkConnection conn)
		{
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x5AB6B0", Offset = "0x5AA8B0", VA = "0x1805AB6B0")]
		public void SetDestroyed()
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x5AB4B0", Offset = "0x5AA6B0", VA = "0x1805AB4B0")]
		private void OnSleep()
		{
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "56")]
		public override bool CanDeliverToProperty()
		{
			return default(bool);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x5AB3D0", Offset = "0x5AA5D0", VA = "0x1805AB3D0", Slot = "57")]
		public override bool CanRespawnInsideProperty()
		{
			return default(bool);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x5AC140", Offset = "0x5AB340", VA = "0x1805AC140")]
		public RV()
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x5ABA40", Offset = "0x5AAC40", VA = "0x1805ABA40")]
		[CompilerGenerated]
		internal static IEnumerator <BlowUp>g__Shake|13_0()
		{
			return null;
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x5AB410", Offset = "0x5AA610", VA = "0x1805AB410", Slot = "58")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x5AB3E0", Offset = "0x5AA5E0", VA = "0x1805AB3E0", Slot = "59")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x595D90", Offset = "0x594F90", VA = "0x180595D90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x5AB720", Offset = "0x5AA920", VA = "0x1805AB720")]
		private void RpcWriter___Target_SetDestroyed_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x5AB6B0", Offset = "0x5AA8B0", VA = "0x1805AB6B0")]
		private void RpcLogic___SetDestroyed_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x5AB6D0", Offset = "0x5AA8D0", VA = "0x1805AB6D0")]
		private void RpcReader___Target_SetDestroyed_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x595D20", Offset = "0x594F20", VA = "0x180595D20", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x04001350 RID: 4944
		[Token(Token = "0x4001350")]
		[FieldOffset(Offset = "0x250")]
		public Transform ModelContainer;

		// Token: 0x04001351 RID: 4945
		[Token(Token = "0x4001351")]
		[FieldOffset(Offset = "0x258")]
		public Transform FXContainer;

		// Token: 0x04001352 RID: 4946
		[Token(Token = "0x4001352")]
		[FieldOffset(Offset = "0x260")]
		public UnityEvent onExplode;

		// Token: 0x04001353 RID: 4947
		[Token(Token = "0x4001353")]
		[FieldOffset(Offset = "0x268")]
		public UnityEvent onDestroyedState;

		// Token: 0x04001355 RID: 4949
		[Token(Token = "0x4001355")]
		[FieldOffset(Offset = "0x271")]
		private bool _exploded;

		// Token: 0x04001356 RID: 4950
		[Token(Token = "0x4001356")]
		[FieldOffset(Offset = "0x272")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.RVAssembly-CSharp.dll_Excuted;

		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x273")]
		private bool NetworkInitialize__LateScheduleOne.Property.RVAssembly-CSharp.dll_Excuted;
	}
}
