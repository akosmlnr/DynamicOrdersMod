using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Misc
{
	// Token: 0x0200059B RID: 1435
	[Token(Token = "0x200059B")]
	public class ModularSwitch : NetworkBehaviour
	{
		// Token: 0x060020C8 RID: 8392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x67A8A0", Offset = "0x679AA0", VA = "0x18067A8A0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x67AAE0", Offset = "0x679CE0", VA = "0x18067AAE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x67A8F0", Offset = "0x679AF0", VA = "0x18067A8F0")]
		public void Hovered()
		{
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x67A980", Offset = "0x679B80", VA = "0x18067A980")]
		public void Interacted()
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x67B0B0", Offset = "0x67A2B0", VA = "0x18067B0B0")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendIsOn(bool isOn)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x67B1E0", Offset = "0x67A3E0", VA = "0x18067B1E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetIsOn(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x67B590", Offset = "0x67A790", VA = "0x18067B590")]
		public void SwitchOn()
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x67B450", Offset = "0x67A650", VA = "0x18067B450")]
		public void SwitchOff()
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x67B6D0", Offset = "0x67A8D0", VA = "0x18067B6D0")]
		public ModularSwitch()
		{
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x67A9C0", Offset = "0x679BC0", VA = "0x18067A9C0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x67A9A0", Offset = "0x679BA0", VA = "0x18067A9A0", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x5914A0", Offset = "0x5906A0", VA = "0x1805914A0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x67AE20", Offset = "0x67A020", VA = "0x18067AE20")]
		private void RpcWriter___Server_SendIsOn_1140765316(bool isOn)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D5")]
		[Address(RVA = "0x67AB20", Offset = "0x679D20", VA = "0x18067AB20")]
		private void RpcLogic___SendIsOn_1140765316(bool isOn)
		{
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x67ABD0", Offset = "0x679DD0", VA = "0x18067ABD0")]
		private void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x67ACE0", Offset = "0x679EE0", VA = "0x18067ACE0")]
		private void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x67AB30", Offset = "0x679D30", VA = "0x18067AB30")]
		private void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x67AB50", Offset = "0x679D50", VA = "0x18067AB50")]
		private void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x67AF50", Offset = "0x67A150", VA = "0x18067AF50")]
		private void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x67AC60", Offset = "0x679E60", VA = "0x18067AC60")]
		private void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x67A640", Offset = "0x679840", VA = "0x18067A640", Slot = "22")]
		protected virtual void Awake_UserLogic_ScheduleOne.Misc.ModularSwitch_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001AAC RID: 6828
		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x118")]
		public bool isOn;

		// Token: 0x04001AAD RID: 6829
		[Token(Token = "0x4001AAD")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Header("References")]
		protected InteractableObject intObj;

		// Token: 0x04001AAE RID: 6830
		[Token(Token = "0x4001AAE")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Transform button;

		// Token: 0x04001AAF RID: 6831
		[Token(Token = "0x4001AAF")]
		[FieldOffset(Offset = "0x130")]
		public AudioSourceController OnAudio;

		// Token: 0x04001AB0 RID: 6832
		[Token(Token = "0x4001AB0")]
		[FieldOffset(Offset = "0x138")]
		public AudioSourceController OffAudio;

		// Token: 0x04001AB1 RID: 6833
		[Token(Token = "0x4001AB1")]
		[FieldOffset(Offset = "0x140")]
		public ToggleableLight[] LightsToControl;

		// Token: 0x04001AB2 RID: 6834
		[Token(Token = "0x4001AB2")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Header("Settings")]
		protected List<ModularSwitch> SwitchesToSyncWith;

		// Token: 0x04001AB3 RID: 6835
		[Token(Token = "0x4001AB3")]
		[FieldOffset(Offset = "0x150")]
		public ModularSwitch.ButtonChange onToggled;

		// Token: 0x04001AB4 RID: 6836
		[Token(Token = "0x4001AB4")]
		[FieldOffset(Offset = "0x158")]
		public UnityEvent switchedOn;

		// Token: 0x04001AB5 RID: 6837
		[Token(Token = "0x4001AB5")]
		[FieldOffset(Offset = "0x160")]
		public UnityEvent switchedOff;

		// Token: 0x04001AB6 RID: 6838
		[Token(Token = "0x4001AB6")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted;

		// Token: 0x04001AB7 RID: 6839
		[Token(Token = "0x4001AB7")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted;

		// Token: 0x0200059C RID: 1436
		// (Invoke) Token: 0x060020DE RID: 8414
		[Token(Token = "0x200059C")]
		public delegate void ButtonChange(bool isOn);
	}
}
