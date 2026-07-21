using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200087F RID: 2175
	[Token(Token = "0x200087F")]
	public class PasscodePanel : NetworkBehaviour
	{
		// Token: 0x06003990 RID: 14736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003990")]
		[Address(RVA = "0x80A470", Offset = "0x809670", VA = "0x18080A470", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003991")]
		[Address(RVA = "0x80A940", Offset = "0x809B40", VA = "0x18080A940", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x80A780", Offset = "0x809980", VA = "0x18080A780")]
		private void OnButtonPressed(int number)
		{
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x80A640", Offset = "0x809840", VA = "0x18080A640")]
		[ServerRpc(RequireOwnership = false)]
		private void OnButtonPressed_Server(int number)
		{
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x80A9D0", Offset = "0x809BD0", VA = "0x18080A9D0")]
		[ObserversRpc]
		private void RegisterButtonPress(int number)
		{
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003995")]
		[Address(RVA = "0x80B560", Offset = "0x80A760", VA = "0x18080B560")]
		public void SetIsUsable(bool isUsable)
		{
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003996")]
		[Address(RVA = "0x80B360", Offset = "0x80A560", VA = "0x18080B360")]
		[TargetRpc]
		[ObserversRpc]
		private void SetEnteredPasscode(NetworkConnection conn, string passcode)
		{
		}

		// Token: 0x06003997 RID: 14743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003997")]
		[Address(RVA = "0x80B650", Offset = "0x80A850", VA = "0x18080B650")]
		public PasscodePanel()
		{
		}

		// Token: 0x06003998 RID: 14744 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003998")]
		[Address(RVA = "0x80B5E0", Offset = "0x80A7E0", VA = "0x18080B5E0")]
		[CompilerGenerated]
		private IEnumerator <RegisterButtonPress>g__Evaluate|12_0()
		{
			return null;
		}

		// Token: 0x06003999 RID: 14745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003999")]
		[Address(RVA = "0x80A4E0", Offset = "0x8096E0", VA = "0x18080A4E0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600399A RID: 14746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399A")]
		[Address(RVA = "0x80A4C0", Offset = "0x8096C0", VA = "0x18080A4C0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600399B RID: 14747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399B")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600399C RID: 14748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399C")]
		[Address(RVA = "0x80A640", Offset = "0x809840", VA = "0x18080A640")]
		private void RpcWriter___Server_OnButtonPressed_Server_3316948804(int number)
		{
		}

		// Token: 0x0600399D RID: 14749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399D")]
		[Address(RVA = "0x80A9D0", Offset = "0x809BD0", VA = "0x18080A9D0")]
		private void RpcLogic___OnButtonPressed_Server_3316948804(int number)
		{
		}

		// Token: 0x0600399E RID: 14750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399E")]
		[Address(RVA = "0x80AEA0", Offset = "0x80A0A0", VA = "0x18080AEA0")]
		private void RpcReader___Server_OnButtonPressed_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600399F RID: 14751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600399F")]
		[Address(RVA = "0x80A9D0", Offset = "0x809BD0", VA = "0x18080A9D0")]
		private void RpcWriter___Observers_RegisterButtonPress_3316948804(int number)
		{
		}

		// Token: 0x060039A0 RID: 14752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A0")]
		[Address(RVA = "0x80AB20", Offset = "0x809D20", VA = "0x18080AB20")]
		private void RpcLogic___RegisterButtonPress_3316948804(int number)
		{
		}

		// Token: 0x060039A1 RID: 14753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A1")]
		[Address(RVA = "0x80ACB0", Offset = "0x809EB0", VA = "0x18080ACB0")]
		private void RpcReader___Observers_RegisterButtonPress_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060039A2 RID: 14754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A2")]
		[Address(RVA = "0x80B0C0", Offset = "0x80A2C0", VA = "0x18080B0C0")]
		private void RpcWriter___Observers_SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode)
		{
		}

		// Token: 0x060039A3 RID: 14755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A3")]
		[Address(RVA = "0x80AC50", Offset = "0x809E50", VA = "0x18080AC50")]
		private void RpcLogic___SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode)
		{
		}

		// Token: 0x060039A4 RID: 14756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A4")]
		[Address(RVA = "0x80AE20", Offset = "0x80A020", VA = "0x18080AE20")]
		private void RpcReader___Observers_SetEnteredPasscode_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A5")]
		[Address(RVA = "0x80B200", Offset = "0x80A400", VA = "0x18080B200")]
		private void RpcWriter___Target_SetEnteredPasscode_2971853958(NetworkConnection conn, string passcode)
		{
		}

		// Token: 0x060039A6 RID: 14758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A6")]
		[Address(RVA = "0x80B030", Offset = "0x80A230", VA = "0x18080B030")]
		private void RpcReader___Target_SetEnteredPasscode_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060039A7 RID: 14759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60039A7")]
		[Address(RVA = "0x80A220", Offset = "0x809420", VA = "0x18080A220")]
		private void Awake_UserLogic_ScheduleOne.Tools.PasscodePanel_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002A6A RID: 10858
		[Token(Token = "0x4002A6A")]
		public const int PasscodeLength = 4;

		// Token: 0x04002A6B RID: 10859
		[Token(Token = "0x4002A6B")]
		[FieldOffset(Offset = "0x118")]
		[Header("Settings")]
		public string CorrectPasscode;

		// Token: 0x04002A6C RID: 10860
		[Token(Token = "0x4002A6C")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public InteractableObject[] Buttons;

		// Token: 0x04002A6D RID: 10861
		[Token(Token = "0x4002A6D")]
		[FieldOffset(Offset = "0x128")]
		public TextMeshPro CodeLabel;

		// Token: 0x04002A6E RID: 10862
		[Token(Token = "0x4002A6E")]
		[FieldOffset(Offset = "0x130")]
		public UnityEvent onButtonPressed;

		// Token: 0x04002A6F RID: 10863
		[Token(Token = "0x4002A6F")]
		[FieldOffset(Offset = "0x138")]
		public UnityEvent onCorrect;

		// Token: 0x04002A70 RID: 10864
		[Token(Token = "0x4002A70")]
		[FieldOffset(Offset = "0x140")]
		public UnityEvent onIncorrect;

		// Token: 0x04002A71 RID: 10865
		[Token(Token = "0x4002A71")]
		[FieldOffset(Offset = "0x148")]
		private string enteredPasscode;

		// Token: 0x04002A72 RID: 10866
		[Token(Token = "0x4002A72")]
		[FieldOffset(Offset = "0x150")]
		private bool NetworkInitialize___EarlyScheduleOne.Tools.PasscodePanelAssembly-CSharp.dll_Excuted;

		// Token: 0x04002A73 RID: 10867
		[Token(Token = "0x4002A73")]
		[FieldOffset(Offset = "0x151")]
		private bool NetworkInitialize__LateScheduleOne.Tools.PasscodePanelAssembly-CSharp.dll_Excuted;
	}
}
