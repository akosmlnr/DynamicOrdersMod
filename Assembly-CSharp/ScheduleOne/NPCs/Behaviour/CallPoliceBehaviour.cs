using System;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Law;
using ScheduleOne.PlayerScripts;
using ScheduleOne.UI.WorldspacePopup;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AD1 RID: 2769
	[Token(Token = "0x2000AD1")]
	public class CallPoliceBehaviour : Behaviour
	{
		// Token: 0x06004FD3 RID: 20435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD3")]
		[Address(RVA = "0x935DA0", Offset = "0x934FA0", VA = "0x180935DA0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06004FD4 RID: 20436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD4")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		public void SetData(NetworkObject player, Crime crime)
		{
		}

		// Token: 0x06004FD5 RID: 20437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD5")]
		[Address(RVA = "0x936670", Offset = "0x935870", VA = "0x180936670", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06004FD6 RID: 20438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD6")]
		[Address(RVA = "0x936230", Offset = "0x935430", VA = "0x180936230", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06004FD7 RID: 20439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD7")]
		[Address(RVA = "0x936580", Offset = "0x935780", VA = "0x180936580", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06004FD8 RID: 20440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD8")]
		[Address(RVA = "0x936020", Offset = "0x935220", VA = "0x180936020", Slot = "26")]
		public override void BehaviourUpdate()
		{
		}

		// Token: 0x06004FD9 RID: 20441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FD9")]
		[Address(RVA = "0x936640", Offset = "0x935840", VA = "0x180936640")]
		private void RefreshIcon()
		{
		}

		// Token: 0x06004FDA RID: 20442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDA")]
		[Address(RVA = "0x9362F0", Offset = "0x9354F0", VA = "0x1809362F0")]
		[ObserversRpc(RunLocally = true)]
		private void FinalizeCall()
		{
		}

		// Token: 0x06004FDB RID: 20443 RVA: 0x00015000 File Offset: 0x00013200
		[Token(Token = "0x6004FDB")]
		[Address(RVA = "0x936410", Offset = "0x935610", VA = "0x180936410")]
		private bool IsTargetValid()
		{
			return default(bool);
		}

		// Token: 0x06004FDC RID: 20444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDC")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public CallPoliceBehaviour()
		{
		}

		// Token: 0x06004FDD RID: 20445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDD")]
		[Address(RVA = "0x9364E0", Offset = "0x9356E0", VA = "0x1809364E0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004FDE RID: 20446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDE")]
		[Address(RVA = "0x9364B0", Offset = "0x9356B0", VA = "0x1809364B0", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004FDF RID: 20447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FDF")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004FE0 RID: 20448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE0")]
		[Address(RVA = "0x936990", Offset = "0x935B90", VA = "0x180936990")]
		private void RpcWriter___Observers_FinalizeCall_2166136261()
		{
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE1")]
		[Address(RVA = "0x9367A0", Offset = "0x9359A0", VA = "0x1809367A0")]
		private void RpcLogic___FinalizeCall_2166136261()
		{
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE2")]
		[Address(RVA = "0x936950", Offset = "0x935B50", VA = "0x180936950")]
		private void RpcReader___Observers_FinalizeCall_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004FE3 RID: 20451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE3")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003750 RID: 14160
		[Token(Token = "0x4003750")]
		public const float CALL_POLICE_TIME = 4f;

		// Token: 0x04003751 RID: 14161
		[Token(Token = "0x4003751")]
		[FieldOffset(Offset = "0x168")]
		[Header("References")]
		public WorldspacePopup PhoneCallPopup;

		// Token: 0x04003752 RID: 14162
		[Token(Token = "0x4003752")]
		[FieldOffset(Offset = "0x170")]
		public AvatarEquippable PhonePrefab;

		// Token: 0x04003753 RID: 14163
		[Token(Token = "0x4003753")]
		[FieldOffset(Offset = "0x178")]
		public AudioSourceController CallSound;

		// Token: 0x04003754 RID: 14164
		[Token(Token = "0x4003754")]
		[FieldOffset(Offset = "0x180")]
		private float currentCallTime;

		// Token: 0x04003755 RID: 14165
		[Token(Token = "0x4003755")]
		[FieldOffset(Offset = "0x188")]
		public Player Target;

		// Token: 0x04003756 RID: 14166
		[Token(Token = "0x4003756")]
		[FieldOffset(Offset = "0x190")]
		public Crime ReportedCrime;

		// Token: 0x04003757 RID: 14167
		[Token(Token = "0x4003757")]
		[FieldOffset(Offset = "0x198")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003758 RID: 14168
		[Token(Token = "0x4003758")]
		[FieldOffset(Offset = "0x199")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.CallPoliceBehaviourAssembly-CSharp.dll_Excuted;
	}
}
