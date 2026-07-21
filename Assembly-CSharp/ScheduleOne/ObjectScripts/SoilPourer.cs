using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009C9 RID: 2505
	[Token(Token = "0x20009C9")]
	public class SoilPourer : GridItem
	{
		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06004739 RID: 18233 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600473A RID: 18234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B25")]
		public string SoilID
		{
			[Token(Token = "0x6004739")]
			[Address(RVA = "0x66BA50", Offset = "0x66AC50", VA = "0x18066BA50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600473A")]
			[Address(RVA = "0x876080", Offset = "0x875280", VA = "0x180876080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600473B RID: 18235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x8C78A0", Offset = "0x8C6AA0", VA = "0x1808C78A0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x0600473C RID: 18236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x8C74F0", Offset = "0x8C66F0", VA = "0x1808C74F0")]
		public void HandleHovered()
		{
		}

		// Token: 0x0600473D RID: 18237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473D")]
		[Address(RVA = "0x8C7590", Offset = "0x8C6790", VA = "0x1808C7590")]
		public void HandleInteracted()
		{
		}

		// Token: 0x0600473E RID: 18238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473E")]
		[Address(RVA = "0x8C83D0", Offset = "0x8C75D0", VA = "0x1808C83D0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendPourSoil()
		{
		}

		// Token: 0x0600473F RID: 18239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x8C7970", Offset = "0x8C6B70", VA = "0x1808C7970")]
		[ObserversRpc(RunLocally = true)]
		private void PourSoil()
		{
		}

		// Token: 0x06004740 RID: 18240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004740")]
		[Address(RVA = "0x8C6AA0", Offset = "0x8C5CA0", VA = "0x1808C6AA0")]
		public void FillHovered()
		{
		}

		// Token: 0x06004741 RID: 18241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004741")]
		[Address(RVA = "0x8C6C80", Offset = "0x8C5E80", VA = "0x1808C6C80")]
		public void FillInteracted()
		{
		}

		// Token: 0x06004742 RID: 18242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004742")]
		[Address(RVA = "0x8C84E0", Offset = "0x8C76E0", VA = "0x1808C84E0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendSoil(string ID)
		{
		}

		// Token: 0x06004743 RID: 18243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004743")]
		[Address(RVA = "0x8C8770", Offset = "0x8C7970", VA = "0x1808C8770")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		protected void SetSoil(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06004744 RID: 18244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004744")]
		[Address(RVA = "0x8C8610", Offset = "0x8C7810", VA = "0x1808C8610")]
		public void SetSoilLevel(float level)
		{
		}

		// Token: 0x06004745 RID: 18245 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004745")]
		[Address(RVA = "0x8C70C0", Offset = "0x8C62C0", VA = "0x1808C70C0", Slot = "71")]
		protected virtual List<Pot> GetPots()
		{
			return null;
		}

		// Token: 0x06004746 RID: 18246 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004746")]
		[Address(RVA = "0x8C6FC0", Offset = "0x8C61C0", VA = "0x1808C6FC0", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x06004747 RID: 18247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004747")]
		[Address(RVA = "0x8C8A40", Offset = "0x8C7C40", VA = "0x1808C8A40")]
		public SoilPourer()
		{
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004748")]
		[Address(RVA = "0x8C89D0", Offset = "0x8C7BD0", VA = "0x1808C89D0")]
		[CompilerGenerated]
		private IEnumerator <PourSoil>g__PourRoutine|20_0()
		{
			return null;
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004749")]
		[Address(RVA = "0x8C76F0", Offset = "0x8C68F0", VA = "0x1808C76F0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474A")]
		[Address(RVA = "0x8C76D0", Offset = "0x8C68D0", VA = "0x1808C76D0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474B")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474C")]
		[Address(RVA = "0x8C8030", Offset = "0x8C7230", VA = "0x1808C8030")]
		private void RpcWriter___Server_SendPourSoil_2166136261()
		{
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474D")]
		[Address(RVA = "0x8C7970", Offset = "0x8C6B70", VA = "0x1808C7970")]
		private void RpcLogic___SendPourSoil_2166136261()
		{
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474E")]
		[Address(RVA = "0x8C7CA0", Offset = "0x8C6EA0", VA = "0x1808C7CA0")]
		private void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600474F")]
		[Address(RVA = "0x8C7DD0", Offset = "0x8C6FD0", VA = "0x1808C7DD0")]
		private void RpcWriter___Observers_PourSoil_2166136261()
		{
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004750")]
		[Address(RVA = "0x8C7A90", Offset = "0x8C6C90", VA = "0x1808C7A90")]
		private void RpcLogic___PourSoil_2166136261()
		{
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004751")]
		[Address(RVA = "0x8C7C00", Offset = "0x8C6E00", VA = "0x1808C7C00")]
		private void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004752")]
		[Address(RVA = "0x8C8140", Offset = "0x8C7340", VA = "0x1808C8140")]
		private void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004753")]
		[Address(RVA = "0x8C7B20", Offset = "0x8C6D20", VA = "0x1808C7B20")]
		public void RpcLogic___SendSoil_3615296227(string ID)
		{
		}

		// Token: 0x06004754 RID: 18260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004754")]
		[Address(RVA = "0x8C7CF0", Offset = "0x8C6EF0", VA = "0x1808C7CF0")]
		private void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06004755 RID: 18261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004755")]
		[Address(RVA = "0x8C7EF0", Offset = "0x8C70F0", VA = "0x1808C7EF0")]
		private void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004756")]
		[Address(RVA = "0x8C7B30", Offset = "0x8C6D30", VA = "0x1808C7B30")]
		protected void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004757")]
		[Address(RVA = "0x8C7C40", Offset = "0x8C6E40", VA = "0x1808C7C40")]
		private void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004758")]
		[Address(RVA = "0x8C8270", Offset = "0x8C7470", VA = "0x1808C8270")]
		private void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004759")]
		[Address(RVA = "0x8C7D70", Offset = "0x8C6F70", VA = "0x1808C7D70")]
		private void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600475A")]
		[Address(RVA = "0x82F570", Offset = "0x82E770", VA = "0x18082F570", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04003277 RID: 12919
		[Token(Token = "0x4003277")]
		[FieldOffset(Offset = "0x218")]
		public float AnimationDuration;

		// Token: 0x04003278 RID: 12920
		[Token(Token = "0x4003278")]
		[FieldOffset(Offset = "0x220")]
		[Header("References")]
		public InteractableObject HandleIntObj;

		// Token: 0x04003279 RID: 12921
		[Token(Token = "0x4003279")]
		[FieldOffset(Offset = "0x228")]
		public InteractableObject FillIntObj;

		// Token: 0x0400327A RID: 12922
		[Token(Token = "0x400327A")]
		[FieldOffset(Offset = "0x230")]
		public MeshRenderer DirtPlane;

		// Token: 0x0400327B RID: 12923
		[Token(Token = "0x400327B")]
		[FieldOffset(Offset = "0x238")]
		public Transform Dirt_Min;

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x240")]
		public Transform Dirt_Max;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		[FieldOffset(Offset = "0x248")]
		public ParticleSystem PourParticles;

		// Token: 0x0400327E RID: 12926
		[Token(Token = "0x400327E")]
		[FieldOffset(Offset = "0x250")]
		public Animation PourAnimation;

		// Token: 0x0400327F RID: 12927
		[Token(Token = "0x400327F")]
		[FieldOffset(Offset = "0x258")]
		public AudioSourceController FillSound;

		// Token: 0x04003280 RID: 12928
		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x260")]
		public AudioSourceController ActivateSound;

		// Token: 0x04003281 RID: 12929
		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x268")]
		public AudioSourceController DirtPourSound;

		// Token: 0x04003282 RID: 12930
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x270")]
		private bool isDispensing;

		// Token: 0x04003283 RID: 12931
		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0x271")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003284 RID: 12932
		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x272")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted;
	}
}
