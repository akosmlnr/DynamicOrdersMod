using System;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Animation;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	// Token: 0x02000B3A RID: 2874
	[Token(Token = "0x2000B3A")]
	public class NPCEvent_Sit : NPCEvent
	{
		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x060055AF RID: 21935 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000C95")]
		public new string ActionName
		{
			[Token(Token = "0x60055AF")]
			[Address(RVA = "0x980EE0", Offset = "0x9800E0", VA = "0x180980EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60055B0")]
		[Address(RVA = "0x97F640", Offset = "0x97E840", VA = "0x18097F640", Slot = "36")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B1")]
		[Address(RVA = "0x980D50", Offset = "0x97FF50", VA = "0x180980D50", Slot = "22")]
		public override void Started()
		{
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B2")]
		[Address(RVA = "0x980260", Offset = "0x97F460", VA = "0x180980260", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B3")]
		[Address(RVA = "0x97FB40", Offset = "0x97ED40", VA = "0x18097FB40", Slot = "23")]
		public override void LateStarted()
		{
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B4")]
		[Address(RVA = "0x97FD40", Offset = "0x97EF40", VA = "0x18097FD40", Slot = "31")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B5")]
		[Address(RVA = "0x97F940", Offset = "0x97EB40", VA = "0x18097F940", Slot = "24")]
		public override void JumpTo()
		{
		}

		// Token: 0x060055B6 RID: 21942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B6")]
		[Address(RVA = "0x97F5F0", Offset = "0x97E7F0", VA = "0x18097F5F0", Slot = "25")]
		public override void End()
		{
		}

		// Token: 0x060055B7 RID: 21943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B7")]
		[Address(RVA = "0x97F6F0", Offset = "0x97E8F0", VA = "0x18097F6F0", Slot = "26")]
		public override void Interrupt()
		{
		}

		// Token: 0x060055B8 RID: 21944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B8")]
		[Address(RVA = "0x980320", Offset = "0x97F520", VA = "0x180980320", Slot = "27")]
		public override void Resume()
		{
		}

		// Token: 0x060055B9 RID: 21945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055B9")]
		[Address(RVA = "0x980A10", Offset = "0x97FC10", VA = "0x180980A10", Slot = "29")]
		public override void Skipped()
		{
		}

		// Token: 0x060055BA RID: 21946 RVA: 0x000160E0 File Offset: 0x000142E0
		[Token(Token = "0x60055BA")]
		[Address(RVA = "0x97F780", Offset = "0x97E980", VA = "0x18097F780")]
		private bool IsAtDestination()
		{
			return default(bool);
		}

		// Token: 0x060055BB RID: 21947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BB")]
		[Address(RVA = "0x980E20", Offset = "0x980020", VA = "0x180980E20", Slot = "39")]
		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x060055BC RID: 21948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BC")]
		[Address(RVA = "0x980AD0", Offset = "0x97FCD0", VA = "0x180980AD0", Slot = "45")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void StartAction(NetworkConnection conn, int seatIndex)
		{
		}

		// Token: 0x060055BD RID: 21949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BD")]
		[Address(RVA = "0x97F490", Offset = "0x97E690", VA = "0x18097F490", Slot = "46")]
		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
		{
		}

		// Token: 0x060055BE RID: 21950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BE")]
		[Address(RVA = "0x97A670", Offset = "0x979870", VA = "0x18097A670")]
		public NPCEvent_Sit()
		{
		}

		// Token: 0x060055BF RID: 21951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055BF")]
		[Address(RVA = "0x97FC10", Offset = "0x97EE10", VA = "0x18097FC10", Slot = "42")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060055C0 RID: 21952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C0")]
		[Address(RVA = "0x97CC30", Offset = "0x97BE30", VA = "0x18097CC30", Slot = "43")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060055C1 RID: 21953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C1")]
		[Address(RVA = "0x978F90", Offset = "0x978190", VA = "0x180978F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060055C2 RID: 21954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C2")]
		[Address(RVA = "0x980750", Offset = "0x97F950", VA = "0x180980750")]
		private void RpcWriter___Observers_StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
		}

		// Token: 0x060055C3 RID: 21955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C3")]
		[Address(RVA = "0x980450", Offset = "0x97F650", VA = "0x180980450", Slot = "47")]
		protected virtual void RpcLogic___StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C4")]
		[Address(RVA = "0x980550", Offset = "0x97F750", VA = "0x180980550")]
		private void RpcReader___Observers_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C5")]
		[Address(RVA = "0x9808A0", Offset = "0x97FAA0", VA = "0x1809808A0")]
		private void RpcWriter___Target_StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C6")]
		[Address(RVA = "0x9805C0", Offset = "0x97F7C0", VA = "0x1809805C0")]
		private void RpcReader___Target_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C7")]
		[Address(RVA = "0x980630", Offset = "0x97F830", VA = "0x180980630")]
		private void RpcWriter___Observers_EndAction_2166136261()
		{
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C8")]
		[Address(RVA = "0x9803E0", Offset = "0x97F5E0", VA = "0x1809803E0", Slot = "48")]
		protected virtual void RpcLogic___EndAction_2166136261()
		{
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055C9")]
		[Address(RVA = "0x980510", Offset = "0x97F710", VA = "0x180980510")]
		private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60055CA")]
		[Address(RVA = "0x97A7C0", Offset = "0x9799C0", VA = "0x18097A7C0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x0400399F RID: 14751
		[Token(Token = "0x400399F")]
		public const float DESTINATION_THRESHOLD = 1.5f;

		// Token: 0x040039A0 RID: 14752
		[Token(Token = "0x40039A0")]
		[FieldOffset(Offset = "0x158")]
		public AvatarSeatSet SeatSet;

		// Token: 0x040039A1 RID: 14753
		[Token(Token = "0x40039A1")]
		[FieldOffset(Offset = "0x160")]
		public bool WarpIfSkipped;

		// Token: 0x040039A2 RID: 14754
		[Token(Token = "0x40039A2")]
		[FieldOffset(Offset = "0x161")]
		private bool seated;

		// Token: 0x040039A3 RID: 14755
		[Token(Token = "0x40039A3")]
		[FieldOffset(Offset = "0x168")]
		private AvatarSeat targetSeat;

		// Token: 0x040039A4 RID: 14756
		[Token(Token = "0x40039A4")]
		[FieldOffset(Offset = "0x170")]
		public UnityEvent onSeated;

		// Token: 0x040039A5 RID: 14757
		[Token(Token = "0x40039A5")]
		[FieldOffset(Offset = "0x178")]
		public UnityEvent onStandUp;

		// Token: 0x040039A6 RID: 14758
		[Token(Token = "0x40039A6")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted;

		// Token: 0x040039A7 RID: 14759
		[Token(Token = "0x40039A7")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted;
	}
}
