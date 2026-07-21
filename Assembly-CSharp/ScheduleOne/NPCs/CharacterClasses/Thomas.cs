using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Messaging;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000AC4 RID: 2756
	[Token(Token = "0x2000AC4")]
	public class Thomas : NPC
	{
		// Token: 0x06004F35 RID: 20277 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004F35")]
		[Address(RVA = "0x8AB460", Offset = "0x8AA660", VA = "0x1808AB460", Slot = "87")]
		public override Sprite GetMessagingIcon()
		{
			return null;
		}

		// Token: 0x06004F36 RID: 20278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F36")]
		[Address(RVA = "0x945170", Offset = "0x944370", VA = "0x180945170")]
		public void SendIntroMessage()
		{
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F37")]
		[Address(RVA = "0x944A50", Offset = "0x943C50", VA = "0x180944A50")]
		[ServerRpc(RequireOwnership = false)]
		public void MeetingEnded_Server()
		{
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F38")]
		[Address(RVA = "0x944B60", Offset = "0x943D60", VA = "0x180944B60")]
		[ObserversRpc]
		private void MeetingEnded()
		{
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F39")]
		[Address(RVA = "0x9448D0", Offset = "0x943AD0", VA = "0x1809448D0", Slot = "85")]
		protected override void CreateMessageConversation()
		{
		}

		// Token: 0x06004F3A RID: 20282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3A")]
		[Address(RVA = "0x9447C0", Offset = "0x9439C0", VA = "0x1809447C0")]
		[ServerRpc(RequireOwnership = false)]
		private void CancelAgreement_Server()
		{
		}

		// Token: 0x06004F3B RID: 20283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3B")]
		[Address(RVA = "0x8F1980", Offset = "0x8F0B80", VA = "0x1808F1980")]
		public Thomas()
		{
		}

		// Token: 0x06004F3C RID: 20284 RVA: 0x00014F40 File Offset: 0x00013140
		[Token(Token = "0x6004F3C")]
		[Address(RVA = "0x945530", Offset = "0x944730", VA = "0x180945530")]
		[CompilerGenerated]
		internal static bool <CreateMessageConversation>g__ShowCancelAgreement|6_0(SendableMessage msg)
		{
			return default(bool);
		}

		// Token: 0x06004F3D RID: 20285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3D")]
		[Address(RVA = "0x945400", Offset = "0x944600", VA = "0x180945400")]
		[CompilerGenerated]
		private void <CreateMessageConversation>g__ConfirmCancelAgreement|6_1()
		{
		}

		// Token: 0x06004F3E RID: 20286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3E")]
		[Address(RVA = "0x945250", Offset = "0x944450", VA = "0x180945250")]
		[CompilerGenerated]
		private void <CreateMessageConversation>g__CancelAgreementCallback|6_2(ConfirmationPopup.EResponse response)
		{
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F3F")]
		[Address(RVA = "0x944C80", Offset = "0x943E80", VA = "0x180944C80", Slot = "121")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F40")]
		[Address(RVA = "0x93AA00", Offset = "0x939C00", VA = "0x18093AA00", Slot = "122")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F41")]
		[Address(RVA = "0x6F03C0", Offset = "0x6EF5C0", VA = "0x1806F03C0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F42")]
		[Address(RVA = "0x944A50", Offset = "0x943C50", VA = "0x180944A50")]
		private void RpcWriter___Server_MeetingEnded_Server_2166136261()
		{
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F43")]
		[Address(RVA = "0x944B60", Offset = "0x943D60", VA = "0x180944B60")]
		public void RpcLogic___MeetingEnded_Server_2166136261()
		{
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F44")]
		[Address(RVA = "0x945040", Offset = "0x944240", VA = "0x180945040")]
		private void RpcReader___Server_MeetingEnded_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F45")]
		[Address(RVA = "0x944B60", Offset = "0x943D60", VA = "0x180944B60")]
		private void RpcWriter___Observers_MeetingEnded_2166136261()
		{
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F46")]
		[Address(RVA = "0x944EC0", Offset = "0x9440C0", VA = "0x180944EC0")]
		private void RpcLogic___MeetingEnded_2166136261()
		{
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F47")]
		[Address(RVA = "0x944EE0", Offset = "0x9440E0", VA = "0x180944EE0")]
		private void RpcReader___Observers_MeetingEnded_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F48")]
		[Address(RVA = "0x9447C0", Offset = "0x9439C0", VA = "0x1809447C0")]
		private void RpcWriter___Server_CancelAgreement_Server_2166136261()
		{
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F49")]
		[Address(RVA = "0x944DB0", Offset = "0x943FB0", VA = "0x180944DB0")]
		private void RpcLogic___CancelAgreement_Server_2166136261()
		{
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x944F20", Offset = "0x944120", VA = "0x180944F20")]
		private void RpcReader___Server_CancelAgreement_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004F4B RID: 20299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x794B40", Offset = "0x793D40", VA = "0x180794B40", Slot = "82")]
		public override void Awake()
		{
		}

		// Token: 0x0400370D RID: 14093
		[Token(Token = "0x400370D")]
		[FieldOffset(Offset = "0x328")]
		public Sprite MessagingIcon;

		// Token: 0x0400370E RID: 14094
		[Token(Token = "0x400370E")]
		[FieldOffset(Offset = "0x330")]
		public UnityEvent onMeetingEnded;

		// Token: 0x0400370F RID: 14095
		[Token(Token = "0x400370F")]
		[FieldOffset(Offset = "0x338")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted;

		// Token: 0x04003710 RID: 14096
		[Token(Token = "0x4003710")]
		[FieldOffset(Offset = "0x339")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted;
	}
}
