using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Money;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Property
{
	// Token: 0x02000359 RID: 857
	[Token(Token = "0x2000359")]
	public class Business : Property, ISaveable
	{
		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060014EA RID: 5354 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x1700041E")]
		public float currentLaunderTotal
		{
			[Token(Token = "0x60014EA")]
			[Address(RVA = "0x598FC0", Offset = "0x5981C0", VA = "0x180598FC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x1700041F")]
		public float appliedLaunderLimit
		{
			[Token(Token = "0x60014EB")]
			[Address(RVA = "0x598F90", Offset = "0x598190", VA = "0x180598F90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060014EC RID: 5356 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000420")]
		public new Loader Loader
		{
			[Token(Token = "0x60014EC")]
			[Address(RVA = "0x598F80", Offset = "0x598180", VA = "0x180598F80", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x597190", Offset = "0x596390", VA = "0x180597190", Slot = "42")]
		public override void Awake()
		{
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EE")]
		[Address(RVA = "0x598B30", Offset = "0x597D30", VA = "0x180598B30", Slot = "44")]
		protected override void Start()
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014EF")]
		[Address(RVA = "0x597E30", Offset = "0x597030", VA = "0x180597E30", Slot = "46")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F0")]
		[Address(RVA = "0x597600", Offset = "0x596800", VA = "0x180597600", Slot = "47")]
		protected override void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F1")]
		[Address(RVA = "0x597F00", Offset = "0x597100", VA = "0x180597F00", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F2")]
		[Address(RVA = "0x597B80", Offset = "0x596D80", VA = "0x180597B80", Slot = "61")]
		protected virtual void MinPass()
		{
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F3")]
		[Address(RVA = "0x597BA0", Offset = "0x596DA0", VA = "0x180597BA0", Slot = "62")]
		protected virtual void MinsPass(int mins)
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F4")]
		[Address(RVA = "0x598D50", Offset = "0x597F50", VA = "0x180598D50")]
		private void TimeSkipped(int minsPassed)
		{
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60014F5")]
		[Address(RVA = "0x597670", Offset = "0x596870", VA = "0x180597670", Slot = "52")]
		public override string GetSaveString()
		{
			return null;
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F6")]
		[Address(RVA = "0x597A80", Offset = "0x596C80", VA = "0x180597A80", Slot = "55")]
		public override void Load(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x60014F7")]
		[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "56")]
		public override bool CanDeliverToProperty()
		{
			return default(bool);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F8")]
		[Address(RVA = "0x598270", Offset = "0x597470", VA = "0x180598270", Slot = "48")]
		protected override void RecieveOwned()
		{
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014F9")]
		[Address(RVA = "0x598850", Offset = "0x597A50", VA = "0x180598850")]
		[ServerRpc(RequireOwnership = false)]
		public void StartLaunderingOperation(float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FA")]
		[Address(RVA = "0x598020", Offset = "0x597220", VA = "0x180598020")]
		[ObserversRpc]
		[TargetRpc]
		private void ReceiveLaunderingOperation(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FB")]
		[Address(RVA = "0x5971E0", Offset = "0x5963E0", VA = "0x1805971E0")]
		protected void CompleteOperation(LaunderingOperation op)
		{
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FC")]
		[Address(RVA = "0x598E90", Offset = "0x598090", VA = "0x180598E90")]
		public Business()
		{
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x597D00", Offset = "0x596F00", VA = "0x180597D00", Slot = "58")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FF")]
		[Address(RVA = "0x597CD0", Offset = "0x596ED0", VA = "0x180597CD0", Slot = "59")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001500")]
		[Address(RVA = "0x595D90", Offset = "0x594F90", VA = "0x180595D90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001501")]
		[Address(RVA = "0x598850", Offset = "0x597A50", VA = "0x180598850")]
		private void RpcWriter___Server_StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001502")]
		[Address(RVA = "0x598500", Offset = "0x597700", VA = "0x180598500")]
		public void RpcLogic___StartLaunderingOperation_1481775633(float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001503")]
		[Address(RVA = "0x5985B0", Offset = "0x5977B0", VA = "0x1805985B0")]
		private void RpcReader___Server_StartLaunderingOperation_1481775633(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001504")]
		[Address(RVA = "0x5989C0", Offset = "0x597BC0", VA = "0x1805989C0")]
		private void RpcWriter___Target_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001505")]
		[Address(RVA = "0x598380", Offset = "0x597580", VA = "0x180598380")]
		private void RpcLogic___ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001506")]
		[Address(RVA = "0x598640", Offset = "0x597840", VA = "0x180598640")]
		private void RpcReader___Target_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001507")]
		[Address(RVA = "0x5986D0", Offset = "0x5978D0", VA = "0x1805986D0")]
		private void RpcWriter___Observers_ReceiveLaunderingOperation_1001022388(NetworkConnection conn, float amount, int minutesSinceStarted = 0)
		{
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001508")]
		[Address(RVA = "0x598520", Offset = "0x597720", VA = "0x180598520")]
		private void RpcReader___Observers_ReceiveLaunderingOperation_1001022388(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001509")]
		[Address(RVA = "0x596FD0", Offset = "0x5961D0", VA = "0x180596FD0", Slot = "63")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.Business_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040012DC RID: 4828
		[Token(Token = "0x40012DC")]
		[FieldOffset(Offset = "0x0")]
		public static List<Business> Businesses;

		// Token: 0x040012DD RID: 4829
		[Token(Token = "0x40012DD")]
		[FieldOffset(Offset = "0x8")]
		public static List<Business> UnownedBusinesses;

		// Token: 0x040012DE RID: 4830
		[Token(Token = "0x40012DE")]
		[FieldOffset(Offset = "0x10")]
		public static List<Business> OwnedBusinesses;

		// Token: 0x040012DF RID: 4831
		[Token(Token = "0x40012DF")]
		[FieldOffset(Offset = "0x250")]
		[Header("Settings")]
		public float LaunderCapacity;

		// Token: 0x040012E0 RID: 4832
		[Token(Token = "0x40012E0")]
		[FieldOffset(Offset = "0x258")]
		public List<LaunderingOperation> LaunderingOperations;

		// Token: 0x040012E1 RID: 4833
		[Token(Token = "0x40012E1")]
		[FieldOffset(Offset = "0x18")]
		public static Action<LaunderingOperation> onOperationStarted;

		// Token: 0x040012E2 RID: 4834
		[Token(Token = "0x40012E2")]
		[FieldOffset(Offset = "0x20")]
		public static Action<LaunderingOperation> onOperationFinished;

		// Token: 0x040012E3 RID: 4835
		[Token(Token = "0x40012E3")]
		[FieldOffset(Offset = "0x260")]
		private BusinessLoader loader;

		// Token: 0x040012E4 RID: 4836
		[Token(Token = "0x40012E4")]
		[FieldOffset(Offset = "0x268")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted;

		// Token: 0x040012E5 RID: 4837
		[Token(Token = "0x40012E5")]
		[FieldOffset(Offset = "0x269")]
		private bool NetworkInitialize__LateScheduleOne.Property.BusinessAssembly-CSharp.dll_Excuted;
	}
}
