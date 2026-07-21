using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x020002E2 RID: 738
	[Token(Token = "0x20002E2")]
	public class VariableDatabase : NetworkSingleton<VariableDatabase>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000392")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001108")]
			[Address(RVA = "0xB0A910", Offset = "0xB09B10", VA = "0x180B0A910", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000393")]
		public string SaveFileName
		{
			[Token(Token = "0x6001109")]
			[Address(RVA = "0xB0A8E0", Offset = "0xB09AE0", VA = "0x180B0A8E0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000394")]
		public Loader Loader
		{
			[Token(Token = "0x600110A")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x17000395")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x600110B")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000396")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x600110C")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600110D")]
			[Address(RVA = "0x755980", Offset = "0x754B80", VA = "0x180755980", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000397")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x600110E")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600110F")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x000080E8 File Offset: 0x000062E8
		// (set) Token: 0x06001111 RID: 4369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000398")]
		public bool HasChanged
		{
			[Token(Token = "0x6001110")]
			[Address(RVA = "0x71D4F0", Offset = "0x71C6F0", VA = "0x18071D4F0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001111")]
			[Address(RVA = "0x7DEA40", Offset = "0x7DDC40", VA = "0x1807DEA40", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x17000399")]
		public int LoadOrder
		{
			[Token(Token = "0x6001112")]
			[Address(RVA = "0x7DE9D0", Offset = "0x7DDBD0", VA = "0x1807DE9D0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001113")]
		[Address(RVA = "0xB08770", Offset = "0xB07970", VA = "0x180B08770", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001114")]
		[Address(RVA = "0xB09010", Offset = "0xB08210", VA = "0x180B09010", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001115")]
		[Address(RVA = "0xB08A40", Offset = "0xB07C40", VA = "0x180B08A40")]
		private void CreateVariables()
		{
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001116")]
		[Address(RVA = "0xB087C0", Offset = "0xB079C0", VA = "0x180B087C0")]
		public void CreatePlayerVariables(Player owner)
		{
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001117")]
		[Address(RVA = "0xB09540", Offset = "0xB08740", VA = "0x180B09540", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001118")]
		[Address(RVA = "0xB088A0", Offset = "0xB07AA0", VA = "0x180B088A0")]
		public void CreateVariable(string name, VariableDatabase.EVariableType type, string initialValue, bool persistent, EVariableMode mode, Player owner, EVariableReplicationMode replicationMode = EVariableReplicationMode.Networked)
		{
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001119")]
		[Address(RVA = "0xB08320", Offset = "0xB07520", VA = "0x180B08320")]
		public void AddVariable(BaseVariable variable)
		{
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111A")]
		[Address(RVA = "0xB0A470", Offset = "0xB09670", VA = "0x180B0A470")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111B")]
		[Address(RVA = "0xB09A70", Offset = "0xB08C70", VA = "0x180B09A70")]
		[TargetRpc]
		[ObserversRpc]
		public void ReceiveValue(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111C")]
		[Address(RVA = "0xB0A4D0", Offset = "0xB096D0", VA = "0x180B0A4D0")]
		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600111D")]
		[Address(RVA = "0xB08E90", Offset = "0xB08090", VA = "0x180B08E90")]
		public BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600111E")]
		public T GetValue<T>(string variableName)
		{
			return null;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600111F")]
		[Address(RVA = "0xB09650", Offset = "0xB08850", VA = "0x180B09650")]
		[Button]
		public void PrintAllVariables()
		{
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001120")]
		[Address(RVA = "0xB098B0", Offset = "0xB08AB0", VA = "0x180B098B0")]
		public void PrintVariableValue(string variableName)
		{
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001121")]
		[Address(RVA = "0xB09410", Offset = "0xB08610", VA = "0x180B09410")]
		public void NotifyItemAcquired(string id, int quantity)
		{
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001122")]
		[Address(RVA = "0xB08BF0", Offset = "0xB07DF0", VA = "0x180B08BF0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001123")]
		[Address(RVA = "0xB090A0", Offset = "0xB082A0", VA = "0x180B090A0")]
		public void LoadVariable(VariableData data)
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001124")]
		[Address(RVA = "0xB0A710", Offset = "0xB09910", VA = "0x180B0A710")]
		public VariableDatabase()
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001125")]
		[Address(RVA = "0xB092D0", Offset = "0xB084D0", VA = "0x180B092D0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001126")]
		[Address(RVA = "0xB09280", Offset = "0xB08480", VA = "0x180B09280", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001128")]
		[Address(RVA = "0xB0A0A0", Offset = "0xB092A0", VA = "0x180B0A0A0")]
		private void RpcWriter___Server_SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001129")]
		[Address(RVA = "0xB09D70", Offset = "0xB08F70", VA = "0x180B09D70")]
		public void RpcLogic___SendValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112A")]
		[Address(RVA = "0xB09E00", Offset = "0xB09000", VA = "0x180B09E00")]
		private void RpcReader___Server_SendValue_3895153758(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112B")]
		[Address(RVA = "0xB09F30", Offset = "0xB09130", VA = "0x180B09F30")]
		private void RpcWriter___Observers_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112C")]
		[Address(RVA = "0xB09CA0", Offset = "0xB08EA0", VA = "0x180B09CA0")]
		public void RpcLogic___ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112D")]
		[Address(RVA = "0xB09D80", Offset = "0xB08F80", VA = "0x180B09D80")]
		private void RpcReader___Observers_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112E")]
		[Address(RVA = "0xB0A310", Offset = "0xB09510", VA = "0x180B0A310")]
		private void RpcWriter___Target_ReceiveValue_3895153758(NetworkConnection conn, string variableName, string value)
		{
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600112F")]
		[Address(RVA = "0xB09EB0", Offset = "0xB090B0", VA = "0x180B09EB0")]
		private void RpcReader___Target_ReceiveValue_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001130")]
		[Address(RVA = "0xB084C0", Offset = "0xB076C0", VA = "0x180B084C0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Variables.VariableDatabase_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x120")]
		public List<BaseVariable> VariableList;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x128")]
		public Dictionary<string, BaseVariable> VariableDict;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x130")]
		private List<string> playerVariables;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x138")]
		public VariableCreator[] Creators;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x140")]
		public StorableItemDefinition[] ItemsToTrackAcquire;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x148")]
		private VariablesLoader loader;

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted;

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.Variables.VariableDatabaseAssembly-CSharp.dll_Excuted;

		// Token: 0x020002E3 RID: 739
		[Token(Token = "0x20002E3")]
		public enum EVariableType
		{
			// Token: 0x04000FC1 RID: 4033
			[Token(Token = "0x4000FC1")]
			Bool,
			// Token: 0x04000FC2 RID: 4034
			[Token(Token = "0x4000FC2")]
			Number
		}
	}
}
