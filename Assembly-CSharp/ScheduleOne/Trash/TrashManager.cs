using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public class TrashManager : NetworkSingleton<TrashManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x060035C7 RID: 13767 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700087D")]
		public string SaveFolderName
		{
			[Token(Token = "0x60035C7")]
			[Address(RVA = "0x7DEA10", Offset = "0x7DDC10", VA = "0x1807DEA10", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700087E")]
		public string SaveFileName
		{
			[Token(Token = "0x60035C8")]
			[Address(RVA = "0x7DE9E0", Offset = "0x7DDBE0", VA = "0x1807DE9E0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x060035C9 RID: 13769 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700087F")]
		public Loader Loader
		{
			[Token(Token = "0x60035C9")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x17000880")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60035CA")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x060035CB RID: 13771 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060035CC RID: 13772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000881")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60035CB")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035CC")]
			[Address(RVA = "0x755980", Offset = "0x754B80", VA = "0x180755980", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000882")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60035CD")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035CE")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00010158 File Offset: 0x0000E358
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000883")]
		public bool HasChanged
		{
			[Token(Token = "0x60035CF")]
			[Address(RVA = "0x71D4F0", Offset = "0x71C6F0", VA = "0x18071D4F0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60035D0")]
			[Address(RVA = "0x7DEA40", Offset = "0x7DDC40", VA = "0x1807DEA40", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x17000884")]
		public int LoadOrder
		{
			[Token(Token = "0x60035D1")]
			[Address(RVA = "0x7DE9D0", Offset = "0x7DDBD0", VA = "0x1807DE9D0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D2")]
		[Address(RVA = "0x7DE7F0", Offset = "0x7DD9F0", VA = "0x1807DE7F0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D3")]
		[Address(RVA = "0x7DA760", Offset = "0x7D9960", VA = "0x1807DA760", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D4")]
		[Address(RVA = "0x7DAB50", Offset = "0x7D9D50", VA = "0x1807DAB50", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D5")]
		[Address(RVA = "0x7DAD30", Offset = "0x7D9F30", VA = "0x1807DAD30")]
		public void ReplicateTransformData(TrashItem trash)
		{
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D6")]
		[Address(RVA = "0x7DE650", Offset = "0x7DD850", VA = "0x1807DE650")]
		[ServerRpc(RequireOwnership = false)]
		private void SendTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x060035D7 RID: 13783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D7")]
		[Address(RVA = "0x7DACC0", Offset = "0x7D9EC0", VA = "0x1807DACC0")]
		[ObserversRpc]
		private void ReceiveTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035D8")]
		[Address(RVA = "0x7D9AC0", Offset = "0x7D8CC0", VA = "0x1807D9AC0")]
		public TrashItem CreateTrashItem(string id, Vector3 posiiton, Quaternion rotation, [Optional] Vector3 initialVelocity, string guid = "", bool startKinematic = false)
		{
			return null;
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035D9")]
		[Address(RVA = "0x7DE760", Offset = "0x7DD960", VA = "0x1807DE760")]
		[ServerRpc(RequireOwnership = false)]
		private void SendTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035DA RID: 13786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035DA")]
		[Address(RVA = "0x7D9CA0", Offset = "0x7D8EA0", VA = "0x1807D9CA0")]
		[TargetRpc]
		[ObserversRpc]
		private void CreateTrashItem(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035DB RID: 13787 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035DB")]
		[Address(RVA = "0x7D9440", Offset = "0x7D8640", VA = "0x1807D9440")]
		private TrashItem CreateAndReturnTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			return null;
		}

		// Token: 0x060035DC RID: 13788 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035DC")]
		[Address(RVA = "0x7D98C0", Offset = "0x7D8AC0", VA = "0x1807D98C0")]
		public TrashItem CreateTrashBag(string id, Vector3 posiiton, Quaternion rotation, TrashContentData content, [Optional] Vector3 initialVelocity, string guid = "", bool startKinematic = false)
		{
			return null;
		}

		// Token: 0x060035DD RID: 13789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035DD")]
		[Address(RVA = "0x7DE6C0", Offset = "0x7DD8C0", VA = "0x1807DE6C0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035DE RID: 13790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035DE")]
		[Address(RVA = "0x7D9790", Offset = "0x7D8990", VA = "0x1807D9790")]
		[ObserversRpc]
		[TargetRpc]
		private void CreateTrashBag(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035DF")]
		[Address(RVA = "0x7D90F0", Offset = "0x7D82F0", VA = "0x1807D90F0")]
		private TrashItem CreateAndReturnTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid, bool startKinematic)
		{
			return null;
		}

		// Token: 0x060035E0 RID: 13792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E0")]
		[Address(RVA = "0x7D9DB0", Offset = "0x7D8FB0", VA = "0x1807D9DB0")]
		public void DestroyAllTrash()
		{
		}

		// Token: 0x060035E1 RID: 13793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E1")]
		[Address(RVA = "0x7D9E90", Offset = "0x7D9090", VA = "0x1807D9E90")]
		public void DestroyTrash(TrashItem trash)
		{
		}

		// Token: 0x060035E2 RID: 13794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E2")]
		[Address(RVA = "0x7DE520", Offset = "0x7DD720", VA = "0x1807DE520")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendDestroyTrash(string guid)
		{
		}

		// Token: 0x060035E3 RID: 13795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E3")]
		[Address(RVA = "0x7D9FF0", Offset = "0x7D91F0", VA = "0x1807D9FF0")]
		[ObserversRpc(RunLocally = true)]
		private void DestroyTrash(string guid)
		{
		}

		// Token: 0x060035E4 RID: 13796 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035E4")]
		[Address(RVA = "0x7DA680", Offset = "0x7D9880", VA = "0x1807DA680")]
		public TrashItem GetTrashPrefab(string id)
		{
			return null;
		}

		// Token: 0x060035E5 RID: 13797 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035E5")]
		[Address(RVA = "0x7DA130", Offset = "0x7D9330", VA = "0x1807DA130")]
		public TrashItem GetRandomGeneratableTrashPrefab()
		{
			return null;
		}

		// Token: 0x060035E6 RID: 13798 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035E6")]
		[Address(RVA = "0x7DA2D0", Offset = "0x7D94D0", VA = "0x1807DA2D0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060035E7 RID: 13799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E7")]
		[Address(RVA = "0x7DE840", Offset = "0x7DDA40", VA = "0x1807DE840")]
		public TrashManager()
		{
		}

		// Token: 0x060035E8 RID: 13800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E8")]
		[Address(RVA = "0x7DA840", Offset = "0x7D9A40", VA = "0x1807DA840", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060035E9 RID: 13801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035E9")]
		[Address(RVA = "0x7DA7F0", Offset = "0x7D99F0", VA = "0x1807DA7F0", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060035EA RID: 13802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EA")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060035EB RID: 13803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EB")]
		[Address(RVA = "0x7DD510", Offset = "0x7DC710", VA = "0x1807DD510")]
		private void RpcWriter___Server_SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x060035EC RID: 13804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EC")]
		[Address(RVA = "0x7DACC0", Offset = "0x7D9EC0", VA = "0x1807DACC0")]
		private void RpcLogic___SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x060035ED RID: 13805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035ED")]
		[Address(RVA = "0x7DBDF0", Offset = "0x7DAFF0", VA = "0x1807DBDF0")]
		private void RpcReader___Server_SendTransformData_2990100769(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060035EE RID: 13806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EE")]
		[Address(RVA = "0x7DD0D0", Offset = "0x7DC2D0", VA = "0x1807DD0D0")]
		private void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x060035EF RID: 13807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035EF")]
		[Address(RVA = "0x7DB220", Offset = "0x7DA420", VA = "0x1807DB220")]
		private void RpcLogic___ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender)
		{
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F0")]
		[Address(RVA = "0x7DBB10", Offset = "0x7DAD10", VA = "0x1807DBB10")]
		private void RpcReader___Observers_ReceiveTransformData_2990100769(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F1")]
		[Address(RVA = "0x7DDB30", Offset = "0x7DCD30", VA = "0x1807DDB30")]
		private void RpcWriter___Server_SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F2")]
		[Address(RVA = "0x7DB520", Offset = "0x7DA720", VA = "0x1807DB520")]
		private void RpcLogic___SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F3")]
		[Address(RVA = "0x7DC210", Offset = "0x7DB410", VA = "0x1807DC210")]
		private void RpcReader___Server_SendTrashItem_478112418(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060035F4 RID: 13812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F4")]
		[Address(RVA = "0x7DCC30", Offset = "0x7DBE30", VA = "0x1807DCC30")]
		private void RpcWriter___Observers_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035F5 RID: 13813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F5")]
		[Address(RVA = "0x7DAFD0", Offset = "0x7DA1D0", VA = "0x1807DAFD0")]
		private void RpcLogic___CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035F6 RID: 13814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F6")]
		[Address(RVA = "0x7DB8B0", Offset = "0x7DAAB0", VA = "0x1807DB8B0")]
		private void RpcReader___Observers_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035F7 RID: 13815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F7")]
		[Address(RVA = "0x7DE1C0", Offset = "0x7DD3C0", VA = "0x1807DE1C0")]
		private void RpcWriter___Target_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035F8 RID: 13816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F8")]
		[Address(RVA = "0x7DC6B0", Offset = "0x7DB8B0", VA = "0x1807DC6B0")]
		private void RpcReader___Target_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035F9 RID: 13817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035F9")]
		[Address(RVA = "0x7DD800", Offset = "0x7DCA00", VA = "0x1807DD800")]
		private void RpcWriter___Server_SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035FA RID: 13818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035FA")]
		[Address(RVA = "0x7DB3B0", Offset = "0x7DA5B0", VA = "0x1807DB3B0")]
		private void RpcLogic___SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035FB RID: 13819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035FB")]
		[Address(RVA = "0x7DBF90", Offset = "0x7DB190", VA = "0x1807DBF90")]
		private void RpcReader___Server_SendTrashBag_3965031115(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060035FC RID: 13820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035FC")]
		[Address(RVA = "0x7DC8C0", Offset = "0x7DBAC0", VA = "0x1807DC8C0")]
		private void RpcWriter___Observers_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035FD RID: 13821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035FD")]
		[Address(RVA = "0x7DAEF0", Offset = "0x7DA0F0", VA = "0x1807DAEF0")]
		private void RpcLogic___CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x060035FE RID: 13822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035FE")]
		[Address(RVA = "0x7DB680", Offset = "0x7DA880", VA = "0x1807DB680")]
		private void RpcReader___Observers_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060035FF RID: 13823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035FF")]
		[Address(RVA = "0x7DDE50", Offset = "0x7DD050", VA = "0x1807DDE50")]
		private void RpcWriter___Target_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = false)
		{
		}

		// Token: 0x06003600 RID: 13824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003600")]
		[Address(RVA = "0x7DC470", Offset = "0x7DB670", VA = "0x1807DC470")]
		private void RpcReader___Target_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003601 RID: 13825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003601")]
		[Address(RVA = "0x7DD3E0", Offset = "0x7DC5E0", VA = "0x1807DD3E0")]
		private void RpcWriter___Server_SendDestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003602 RID: 13826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003602")]
		[Address(RVA = "0x7D9FF0", Offset = "0x7D91F0", VA = "0x1807D9FF0")]
		private void RpcLogic___SendDestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003603 RID: 13827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003603")]
		[Address(RVA = "0x7DBD80", Offset = "0x7DAF80", VA = "0x1807DBD80")]
		private void RpcReader___Server_SendDestroyTrash_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003604 RID: 13828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003604")]
		[Address(RVA = "0x7DCF90", Offset = "0x7DC190", VA = "0x1807DCF90")]
		private void RpcWriter___Observers_DestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003605 RID: 13829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003605")]
		[Address(RVA = "0x7DB0A0", Offset = "0x7DA2A0", VA = "0x1807DB0A0")]
		private void RpcLogic___DestroyTrash_3615296227(string guid)
		{
		}

		// Token: 0x06003606 RID: 13830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003606")]
		[Address(RVA = "0x7DBAB0", Offset = "0x7DACB0", VA = "0x1807DBAB0")]
		private void RpcReader___Observers_DestroyTrash_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003607 RID: 13831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003607")]
		[Address(RVA = "0x7D9080", Offset = "0x7D8280", VA = "0x1807D9080", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x040026FA RID: 9978
		[Token(Token = "0x40026FA")]
		public const int TRASH_ITEM_LIMIT = 2000;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		public const int TRASH_REPLICATIONS_PER_SECOND = 100;

		// Token: 0x040026FC RID: 9980
		[Token(Token = "0x40026FC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public TrashItem[] TrashPrefabs;

		// Token: 0x040026FD RID: 9981
		[Token(Token = "0x40026FD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public TrashItem TrashBagPrefab;

		// Token: 0x040026FE RID: 9982
		[Token(Token = "0x40026FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public TrashManager.TrashItemData[] GenerateableTrashItems;

		// Token: 0x040026FF RID: 9983
		[Token(Token = "0x40026FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private List<TrashItem> trashItems;

		// Token: 0x04002700 RID: 9984
		[Token(Token = "0x4002700")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float TrashForceMultiplier;

		// Token: 0x04002701 RID: 9985
		[Token(Token = "0x4002701")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private TrashLoader loader;

		// Token: 0x04002706 RID: 9990
		[Token(Token = "0x4002706")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private List<string> writtenItemFiles;

		// Token: 0x04002707 RID: 9991
		[Token(Token = "0x4002707")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002708 RID: 9992
		[Token(Token = "0x4002708")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x020007D6 RID: 2006
		[Token(Token = "0x20007D6")]
		[Serializable]
		public class TrashItemData
		{
			// Token: 0x06003608 RID: 13832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003608")]
			[Address(RVA = "0x7D7340", Offset = "0x7D6540", VA = "0x1807D7340")]
			public TrashItemData()
			{
			}

			// Token: 0x04002709 RID: 9993
			[Token(Token = "0x4002709")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TrashItem Item;

			// Token: 0x0400270A RID: 9994
			[Token(Token = "0x400270A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float GenerationChance;
		}
	}
}
