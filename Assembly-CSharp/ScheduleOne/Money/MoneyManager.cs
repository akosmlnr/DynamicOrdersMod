using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Money
{
	// Token: 0x0200051D RID: 1309
	[Token(Token = "0x200051D")]
	public class MoneyManager : NetworkSingleton<MoneyManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x06001CBA RID: 7354 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x625710", Offset = "0x624910", VA = "0x180625710")]
		public static string ApplyMoneyTextColor(string text)
		{
			return null;
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x6256C0", Offset = "0x6248C0", VA = "0x1806256C0")]
		public static string ApplyMoneyTextColorDarker(string text)
		{
			return null;
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x625760", Offset = "0x624960", VA = "0x180625760")]
		public static string ApplyOnlineBalanceColor(string text)
		{
			return null;
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x17000538")]
		public float LifetimeEarnings
		{
			[Token(Token = "0x6001CBD")]
			[Address(RVA = "0x511760", Offset = "0x510960", VA = "0x180511760")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x0000A7A0 File Offset: 0x000089A0
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000539")]
		public float LastCalculatedNetworth
		{
			[Token(Token = "0x6001CBE")]
			[Address(RVA = "0x6288E0", Offset = "0x627AE0", VA = "0x1806288E0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001CBF")]
			[Address(RVA = "0x628A20", Offset = "0x627C20", VA = "0x180628A20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x1700053A")]
		public float cashBalance
		{
			[Token(Token = "0x6001CC0")]
			[Address(RVA = "0x628970", Offset = "0x627B70", VA = "0x180628970")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700053B")]
		protected CashInstance cashInstance
		{
			[Token(Token = "0x6001CC1")]
			[Address(RVA = "0x628990", Offset = "0x627B90", VA = "0x180628990")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700053C")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001CC2")]
			[Address(RVA = "0x628940", Offset = "0x627B40", VA = "0x180628940", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700053D")]
		public string SaveFileName
		{
			[Token(Token = "0x6001CC3")]
			[Address(RVA = "0x628910", Offset = "0x627B10", VA = "0x180628910", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700053E")]
		public Loader Loader
		{
			[Token(Token = "0x6001CC4")]
			[Address(RVA = "0x5887D0", Offset = "0x5879D0", VA = "0x1805887D0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001CC5 RID: 7365 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x1700053F")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001CC5")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000540")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001CC6")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CC7")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001CC9 RID: 7369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000541")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001CC8")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001CC9")]
			[Address(RVA = "0x628A30", Offset = "0x627C30", VA = "0x180628A30", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001CCA RID: 7370 RVA: 0x0000A7E8 File Offset: 0x000089E8
		// (set) Token: 0x06001CCB RID: 7371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000542")]
		public bool HasChanged
		{
			[Token(Token = "0x6001CCA")]
			[Address(RVA = "0x6288D0", Offset = "0x627AD0", VA = "0x1806288D0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001CCB")]
			[Address(RVA = "0x628A10", Offset = "0x627C10", VA = "0x180628A10", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001CCC RID: 7372 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x17000543")]
		public int LoadOrder
		{
			[Token(Token = "0x6001CCC")]
			[Address(RVA = "0x6288F0", Offset = "0x627AF0", VA = "0x1806288F0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCD")]
		[Address(RVA = "0x625800", Offset = "0x624A00", VA = "0x180625800", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCE")]
		[Address(RVA = "0x6265D0", Offset = "0x6257D0", VA = "0x1806265D0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CCF")]
		[Address(RVA = "0x628430", Offset = "0x627630", VA = "0x180628430", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD0")]
		[Address(RVA = "0x627270", Offset = "0x626470", VA = "0x180627270", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD1")]
		[Address(RVA = "0x6271D0", Offset = "0x6263D0", VA = "0x1806271D0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD2")]
		[Address(RVA = "0x626EC0", Offset = "0x6260C0", VA = "0x180626EC0", Slot = "21")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD3")]
		[Address(RVA = "0x626890", Offset = "0x625A90", VA = "0x180626890")]
		private void Loaded()
		{
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD4")]
		[Address(RVA = "0x628770", Offset = "0x627970", VA = "0x180628770")]
		private void Update()
		{
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD5")]
		[Address(RVA = "0x626930", Offset = "0x625B30", VA = "0x180626930")]
		private void MinPass()
		{
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CD6")]
		[Address(RVA = "0x6262B0", Offset = "0x6254B0", VA = "0x1806262B0")]
		public CashInstance GetCashInstance(float amount)
		{
			return null;
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD7")]
		[Address(RVA = "0x625EA0", Offset = "0x6250A0", VA = "0x180625EA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CD8")]
		[Address(RVA = "0x627580", Offset = "0x626780", VA = "0x180627580")]
		[ObserversRpc]
		private void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CD9")]
		[Address(RVA = "0x6283C0", Offset = "0x6275C0", VA = "0x1806283C0")]
		protected IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			return null;
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDA")]
		[Address(RVA = "0x625CA0", Offset = "0x624EA0", VA = "0x180625CA0")]
		[ServerRpc(RequireOwnership = false)]
		public void ChangeLifetimeEarnings(float change)
		{
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDB")]
		[Address(RVA = "0x627350", Offset = "0x626550", VA = "0x180627350")]
		public void PlayCashSound()
		{
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CDC")]
		[Address(RVA = "0x625880", Offset = "0x624A80", VA = "0x180625880")]
		public void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CDD")]
		[Address(RVA = "0x628350", Offset = "0x627550", VA = "0x180628350")]
		protected IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			return null;
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CDE")]
		[Address(RVA = "0x626050", Offset = "0x625250", VA = "0x180626050")]
		public static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			return null;
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001CDF")]
		[Address(RVA = "0x626440", Offset = "0x625640", VA = "0x180626440", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE0")]
		[Address(RVA = "0x626660", Offset = "0x625860", VA = "0x180626660")]
		public void Load(MoneyData data)
		{
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE1")]
		[Address(RVA = "0x625DE0", Offset = "0x624FE0", VA = "0x180625DE0")]
		public void CheckNetworthAchievements()
		{
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x6001CE2")]
		[Address(RVA = "0x626390", Offset = "0x625590", VA = "0x180626390")]
		public float GetNetWorth()
		{
			return 0f;
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE3")]
		[Address(RVA = "0x628780", Offset = "0x627980", VA = "0x180628780")]
		public MoneyManager()
		{
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE4")]
		[Address(RVA = "0x626BC0", Offset = "0x625DC0", VA = "0x180626BC0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE5")]
		[Address(RVA = "0x626B20", Offset = "0x625D20", VA = "0x180626B20", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE6")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE7")]
		[Address(RVA = "0x6281E0", Offset = "0x6273E0", VA = "0x1806281E0")]
		private void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE8")]
		[Address(RVA = "0x627580", Offset = "0x626780", VA = "0x180627580")]
		public void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CE9")]
		[Address(RVA = "0x628110", Offset = "0x627310", VA = "0x180628110")]
		private void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x627580", Offset = "0x626780", VA = "0x180627580")]
		private void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x627870", Offset = "0x626A70", VA = "0x180627870")]
		private void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x627EC0", Offset = "0x6270C0", VA = "0x180627EC0")]
		private void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x625CA0", Offset = "0x624EA0", VA = "0x180625CA0")]
		private void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEE")]
		[Address(RVA = "0x627710", Offset = "0x626910", VA = "0x180627710")]
		public void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CEF")]
		[Address(RVA = "0x627F80", Offset = "0x627180", VA = "0x180627F80")]
		private void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x0000A830 File Offset: 0x00008A30
		// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000544")]
		public float SyncAccessor_onlineBalance
		{
			[Token(Token = "0x6001CF0")]
			[Address(RVA = "0x5112E0", Offset = "0x5104E0", VA = "0x1805112E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001CF1")]
			[Address(RVA = "0x628B10", Offset = "0x627D10", VA = "0x180628B10")]
			set
			{
			}
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x6001CF2")]
		[Address(RVA = "0x627400", Offset = "0x626600", VA = "0x180627400", Slot = "51")]
		public virtual bool ReadSyncVar___ScheduleOne.Money.MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0000A860 File Offset: 0x00008A60
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000545")]
		public float SyncAccessor_lifetimeEarnings
		{
			[Token(Token = "0x6001CF3")]
			[Address(RVA = "0x511760", Offset = "0x510960", VA = "0x180511760")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001CF4")]
			[Address(RVA = "0x628A50", Offset = "0x627C50", VA = "0x180628A50")]
			set
			{
			}
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CF5")]
		[Address(RVA = "0x6257B0", Offset = "0x6249B0", VA = "0x1806257B0", Slot = "52")]
		protected virtual void Awake_UserLogic_ScheduleOne.Money.MoneyManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001851 RID: 6225
		[Token(Token = "0x4001851")]
		public const string MONEY_TEXT_COLOR = "#54E717";

		// Token: 0x04001852 RID: 6226
		[Token(Token = "0x4001852")]
		public const string MONEY_TEXT_COLOR_DARKER = "#46CB4F";

		// Token: 0x04001853 RID: 6227
		[Token(Token = "0x4001853")]
		public const string ONLINE_BALANCE_COLOR = "#4CBFFF";

		// Token: 0x04001854 RID: 6228
		[Token(Token = "0x4001854")]
		[FieldOffset(Offset = "0x120")]
		public List<Transaction> ledger;

		// Token: 0x04001855 RID: 6229
		[Token(Token = "0x4001855")]
		[FieldOffset(Offset = "0x128")]
		[SyncVar(/*Failed to decode CustomAttribute blob!*/)]
		public float onlineBalance;

		// Token: 0x04001856 RID: 6230
		[Token(Token = "0x4001856")]
		[FieldOffset(Offset = "0x12C")]
		[SyncVar(/*Failed to decode CustomAttribute blob!*/)]
		public float lifetimeEarnings;

		// Token: 0x04001858 RID: 6232
		[Token(Token = "0x4001858")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected AudioSourceController CashSound;

		// Token: 0x04001859 RID: 6233
		[Token(Token = "0x4001859")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Header("Prefabs")]
		protected GameObject moneyChangePrefab;

		// Token: 0x0400185A RID: 6234
		[Token(Token = "0x400185A")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected GameObject cashChangePrefab;

		// Token: 0x0400185B RID: 6235
		[Token(Token = "0x400185B")]
		[FieldOffset(Offset = "0x150")]
		public Sprite LaunderingNotificationIcon;

		// Token: 0x0400185C RID: 6236
		[Token(Token = "0x400185C")]
		[FieldOffset(Offset = "0x158")]
		public Action<MoneyManager.FloatContainer> onNetworthCalculation;

		// Token: 0x0400185D RID: 6237
		[Token(Token = "0x400185D")]
		[FieldOffset(Offset = "0x160")]
		private MoneyLoader loader;

		// Token: 0x04001862 RID: 6242
		[Token(Token = "0x4001862")]
		[FieldOffset(Offset = "0x180")]
		public SyncVar<float> syncVar___onlineBalance;

		// Token: 0x04001863 RID: 6243
		[Token(Token = "0x4001863")]
		[FieldOffset(Offset = "0x188")]
		public SyncVar<float> syncVar___lifetimeEarnings;

		// Token: 0x04001864 RID: 6244
		[Token(Token = "0x4001864")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001865 RID: 6245
		[Token(Token = "0x4001865")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0200051E RID: 1310
		[Token(Token = "0x200051E")]
		public class FloatContainer
		{
			// Token: 0x17000546 RID: 1350
			// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x0000A878 File Offset: 0x00008A78
			// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000546")]
			public float value
			{
				[Token(Token = "0x6001CF6")]
				[Address(RVA = "0x475910", Offset = "0x474B10", VA = "0x180475910")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6001CF7")]
				[Address(RVA = "0x492A10", Offset = "0x491C10", VA = "0x180492A10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001CF8 RID: 7416 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001CF8")]
			[Address(RVA = "0x621A90", Offset = "0x620C90", VA = "0x180621A90")]
			public void ChangeValue(float value)
			{
			}

			// Token: 0x06001CF9 RID: 7417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001CF9")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public FloatContainer()
			{
			}
		}
	}
}
