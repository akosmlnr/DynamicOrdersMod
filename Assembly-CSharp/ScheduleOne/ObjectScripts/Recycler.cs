using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Misc;
using ScheduleOne.Trash;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x020009CE RID: 2510
	[Token(Token = "0x20009CE")]
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600477E RID: 18302 RVA: 0x000137E8 File Offset: 0x000119E8
		// (set) Token: 0x0600477F RID: 18303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2B")]
		public Recycler.EState State
		{
			[Token(Token = "0x600477E")]
			[Address(RVA = "0x5219B0", Offset = "0x520BB0", VA = "0x1805219B0")]
			[CompilerGenerated]
			get
			{
				return Recycler.EState.HatchClosed;
			}
			[Token(Token = "0x600477F")]
			[Address(RVA = "0x77EBC0", Offset = "0x77DDC0", VA = "0x18077EBC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x00013800 File Offset: 0x00011A00
		// (set) Token: 0x06004781 RID: 18305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B2C")]
		public bool IsHatchOpen
		{
			[Token(Token = "0x6004780")]
			[Address(RVA = "0x5219C0", Offset = "0x520BC0", VA = "0x1805219C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004781")]
			[Address(RVA = "0x8C6A90", Offset = "0x8C5C90", VA = "0x1808C6A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004782")]
		[Address(RVA = "0x8C6870", Offset = "0x8C5A70", VA = "0x1808C6870")]
		public void Start()
		{
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x8C4FD0", Offset = "0x8C41D0", VA = "0x1808C4FD0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004784")]
		[Address(RVA = "0x8C4CF0", Offset = "0x8C3EF0", VA = "0x1808C4CF0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004785")]
		[Address(RVA = "0x8C5020", Offset = "0x8C4220", VA = "0x1808C5020")]
		private void OnTick()
		{
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004786")]
		[Address(RVA = "0x8C4A90", Offset = "0x8C3C90", VA = "0x1808C4A90")]
		public void HandleInteracted()
		{
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004787")]
		[Address(RVA = "0x8C4130", Offset = "0x8C3330", VA = "0x1808C4130")]
		public void ButtonInteracted()
		{
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004788")]
		[Address(RVA = "0x8C4380", Offset = "0x8C3580", VA = "0x1808C4380")]
		public void CashInteracted()
		{
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x8C5ED0", Offset = "0x8C50D0", VA = "0x1808C5ED0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendCashCollected()
		{
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x8C4220", Offset = "0x8C3420", VA = "0x1808C4220")]
		[ObserversRpc(RunLocally = true)]
		private void CashCollected()
		{
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x8C45C0", Offset = "0x8C37C0", VA = "0x1808C45C0")]
		[ObserversRpc(RunLocally = true)]
		private void EnableCash()
		{
		}

		// Token: 0x0600478C RID: 18316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478C")]
		[Address(RVA = "0x8C63B0", Offset = "0x8C55B0", VA = "0x1808C63B0")]
		[ObserversRpc(RunLocally = true)]
		private void SetCashValue(float amount)
		{
		}

		// Token: 0x0600478D RID: 18317 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600478D")]
		[Address(RVA = "0x8C5190", Offset = "0x8C4390", VA = "0x1808C5190")]
		private IEnumerator Process(bool startedByLocalPlayer)
		{
			return null;
		}

		// Token: 0x0600478E RID: 18318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478E")]
		[Address(RVA = "0x8C6270", Offset = "0x8C5470", VA = "0x1808C6270")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendState(Recycler.EState state)
		{
		}

		// Token: 0x0600478F RID: 18319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600478F")]
		[Address(RVA = "0x8C65D0", Offset = "0x8C57D0", VA = "0x1808C65D0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x06004790 RID: 18320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004790")]
		[Address(RVA = "0x8C64F0", Offset = "0x8C56F0", VA = "0x1808C64F0")]
		private void SetHatchOpen(bool open)
		{
		}

		// Token: 0x06004791 RID: 18321 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004791")]
		[Address(RVA = "0x8C46F0", Offset = "0x8C38F0", VA = "0x1808C46F0")]
		private TrashItem[] GetTrash()
		{
			return null;
		}

		// Token: 0x06004792 RID: 18322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004792")]
		[Address(RVA = "0x8C4E10", Offset = "0x8C4010", VA = "0x1808C4E10")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x06004793 RID: 18323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004793")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public Recycler()
		{
		}

		// Token: 0x06004794 RID: 18324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004794")]
		[Address(RVA = "0x8C4AC0", Offset = "0x8C3CC0", VA = "0x1808C4AC0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004795 RID: 18325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004795")]
		[Address(RVA = "0x8C4AA0", Offset = "0x8C3CA0", VA = "0x1808C4AA0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004796 RID: 18326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004796")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004797 RID: 18327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004797")]
		[Address(RVA = "0x8C5ED0", Offset = "0x8C50D0", VA = "0x1808C5ED0")]
		private void RpcWriter___Server_SendCashCollected_2166136261()
		{
		}

		// Token: 0x06004798 RID: 18328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004798")]
		[Address(RVA = "0x8C4220", Offset = "0x8C3420", VA = "0x1808C4220")]
		private void RpcLogic___SendCashCollected_2166136261()
		{
		}

		// Token: 0x06004799 RID: 18329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004799")]
		[Address(RVA = "0x8C5740", Offset = "0x8C4940", VA = "0x1808C5740")]
		private void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600479A RID: 18330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479A")]
		[Address(RVA = "0x8C59D0", Offset = "0x8C4BD0", VA = "0x1808C59D0")]
		private void RpcWriter___Observers_CashCollected_2166136261()
		{
		}

		// Token: 0x0600479B RID: 18331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479B")]
		[Address(RVA = "0x8C5210", Offset = "0x8C4410", VA = "0x1808C5210")]
		private void RpcLogic___CashCollected_2166136261()
		{
		}

		// Token: 0x0600479C RID: 18332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479C")]
		[Address(RVA = "0x8C5580", Offset = "0x8C4780", VA = "0x1808C5580")]
		private void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600479D RID: 18333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479D")]
		[Address(RVA = "0x8C5AF0", Offset = "0x8C4CF0", VA = "0x1808C5AF0")]
		private void RpcWriter___Observers_EnableCash_2166136261()
		{
		}

		// Token: 0x0600479E RID: 18334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479E")]
		[Address(RVA = "0x8C5260", Offset = "0x8C4460", VA = "0x1808C5260")]
		private void RpcLogic___EnableCash_2166136261()
		{
		}

		// Token: 0x0600479F RID: 18335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600479F")]
		[Address(RVA = "0x8C55F0", Offset = "0x8C47F0", VA = "0x1808C55F0")]
		private void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047A0 RID: 18336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A0")]
		[Address(RVA = "0x8C5C10", Offset = "0x8C4E10", VA = "0x1808C5C10")]
		private void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
		}

		// Token: 0x060047A1 RID: 18337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A1")]
		[Address(RVA = "0x8C52B0", Offset = "0x8C44B0", VA = "0x1808C52B0")]
		private void RpcLogic___SetCashValue_431000436(float amount)
		{
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x8C5640", Offset = "0x8C4840", VA = "0x1808C5640")]
		private void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x8C5FE0", Offset = "0x8C51E0", VA = "0x1808C5FE0")]
		private void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
		{
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x8C5290", Offset = "0x8C4490", VA = "0x1808C5290")]
		public void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A5")]
		[Address(RVA = "0x8C58B0", Offset = "0x8C4AB0", VA = "0x1808C58B0")]
		private void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x8C5D60", Offset = "0x8C4F60", VA = "0x1808C5D60")]
		private void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x8C52C0", Offset = "0x8C44C0", VA = "0x1808C52C0")]
		private void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x8C56A0", Offset = "0x8C48A0", VA = "0x1808C56A0")]
		private void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x8C6110", Offset = "0x8C5310", VA = "0x1808C6110")]
		private void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x8C5930", Offset = "0x8C4B30", VA = "0x1808C5930")]
		private void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040032A0 RID: 12960
		[Token(Token = "0x40032A0")]
		[FieldOffset(Offset = "0x120")]
		public LayerMask DetectionMask;

		// Token: 0x040032A1 RID: 12961
		[Token(Token = "0x40032A1")]
		[FieldOffset(Offset = "0x128")]
		[Header("References")]
		public InteractableObject HandleIntObj;

		// Token: 0x040032A2 RID: 12962
		[Token(Token = "0x40032A2")]
		[FieldOffset(Offset = "0x130")]
		public InteractableObject ButtonIntObj;

		// Token: 0x040032A3 RID: 12963
		[Token(Token = "0x40032A3")]
		[FieldOffset(Offset = "0x138")]
		public InteractableObject CashIntObj;

		// Token: 0x040032A4 RID: 12964
		[Token(Token = "0x40032A4")]
		[FieldOffset(Offset = "0x140")]
		public ToggleableLight ButtonLight;

		// Token: 0x040032A5 RID: 12965
		[Token(Token = "0x40032A5")]
		[FieldOffset(Offset = "0x148")]
		public Animation ButtonAnim;

		// Token: 0x040032A6 RID: 12966
		[Token(Token = "0x40032A6")]
		[FieldOffset(Offset = "0x150")]
		public Animation HatchAnim;

		// Token: 0x040032A7 RID: 12967
		[Token(Token = "0x40032A7")]
		[FieldOffset(Offset = "0x158")]
		public Animation CashAnim;

		// Token: 0x040032A8 RID: 12968
		[Token(Token = "0x40032A8")]
		[FieldOffset(Offset = "0x160")]
		public RectTransform OpenHatchInstruction;

		// Token: 0x040032A9 RID: 12969
		[Token(Token = "0x40032A9")]
		[FieldOffset(Offset = "0x168")]
		public RectTransform InsertTrashInstruction;

		// Token: 0x040032AA RID: 12970
		[Token(Token = "0x40032AA")]
		[FieldOffset(Offset = "0x170")]
		public RectTransform PressBeginInstruction;

		// Token: 0x040032AB RID: 12971
		[Token(Token = "0x40032AB")]
		[FieldOffset(Offset = "0x178")]
		public RectTransform ProcessingScreen;

		// Token: 0x040032AC RID: 12972
		[Token(Token = "0x40032AC")]
		[FieldOffset(Offset = "0x180")]
		public TextMeshProUGUI ProcessingLabel;

		// Token: 0x040032AD RID: 12973
		[Token(Token = "0x40032AD")]
		[FieldOffset(Offset = "0x188")]
		public TextMeshProUGUI ValueLabel;

		// Token: 0x040032AE RID: 12974
		[Token(Token = "0x40032AE")]
		[FieldOffset(Offset = "0x190")]
		public BoxCollider CheckCollider;

		// Token: 0x040032AF RID: 12975
		[Token(Token = "0x40032AF")]
		[FieldOffset(Offset = "0x198")]
		public Transform Cash;

		// Token: 0x040032B0 RID: 12976
		[Token(Token = "0x40032B0")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject BankNote;

		// Token: 0x040032B1 RID: 12977
		[Token(Token = "0x40032B1")]
		[FieldOffset(Offset = "0x1A8")]
		[Header("Sound")]
		public AudioSourceController OpenSound;

		// Token: 0x040032B2 RID: 12978
		[Token(Token = "0x40032B2")]
		[FieldOffset(Offset = "0x1B0")]
		public AudioSourceController CloseSound;

		// Token: 0x040032B3 RID: 12979
		[Token(Token = "0x40032B3")]
		[FieldOffset(Offset = "0x1B8")]
		public AudioSourceController PressSound;

		// Token: 0x040032B4 RID: 12980
		[Token(Token = "0x40032B4")]
		[FieldOffset(Offset = "0x1C0")]
		public AudioSourceController DoneSound;

		// Token: 0x040032B5 RID: 12981
		[Token(Token = "0x40032B5")]
		[FieldOffset(Offset = "0x1C8")]
		public AudioSourceController CashEjectSound;

		// Token: 0x040032B6 RID: 12982
		[Token(Token = "0x40032B6")]
		[FieldOffset(Offset = "0x1D0")]
		private float cashValue;

		// Token: 0x040032B7 RID: 12983
		[Token(Token = "0x40032B7")]
		[FieldOffset(Offset = "0x1D8")]
		public UnityEvent onStart;

		// Token: 0x040032B8 RID: 12984
		[Token(Token = "0x40032B8")]
		[FieldOffset(Offset = "0x1E0")]
		public UnityEvent onStop;

		// Token: 0x040032B9 RID: 12985
		[Token(Token = "0x40032B9")]
		[FieldOffset(Offset = "0x1E8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted;

		// Token: 0x040032BA RID: 12986
		[Token(Token = "0x40032BA")]
		[FieldOffset(Offset = "0x1E9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted;

		// Token: 0x020009CF RID: 2511
		[Token(Token = "0x20009CF")]
		public enum EState
		{
			// Token: 0x040032BC RID: 12988
			[Token(Token = "0x40032BC")]
			HatchClosed,
			// Token: 0x040032BD RID: 12989
			[Token(Token = "0x40032BD")]
			HatchOpen,
			// Token: 0x040032BE RID: 12990
			[Token(Token = "0x40032BE")]
			Processing
		}
	}
}
