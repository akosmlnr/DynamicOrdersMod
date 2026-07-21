using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.CharacterClasses;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000548 RID: 1352
	[Token(Token = "0x2000548")]
	public class SewerManager : NetworkSingleton<SewerManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0000AC20 File Offset: 0x00008E20
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000567")]
		public bool IsSewerUnlocked
		{
			[Token(Token = "0x6001DE4")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DE5")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x0000AC38 File Offset: 0x00008E38
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000568")]
		public bool IsRandomWorldKeyCollected
		{
			[Token(Token = "0x6001DE6")]
			[Address(RVA = "0x621930", Offset = "0x620B30", VA = "0x180621930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x621940", Offset = "0x620B40", VA = "0x180621940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x0000AC50 File Offset: 0x00008E50
		// (set) Token: 0x06001DE9 RID: 7657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000569")]
		public int RandomSewerKeyLocationIndex
		{
			[Token(Token = "0x6001DE8")]
			[Address(RVA = "0x5D6EC0", Offset = "0x5D60C0", VA = "0x1805D6EC0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DE9")]
			[Address(RVA = "0x5D6EE0", Offset = "0x5D60E0", VA = "0x1805D6EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0000AC68 File Offset: 0x00008E68
		// (set) Token: 0x06001DEB RID: 7659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056A")]
		public bool HasSewerKingBeenDefeated
		{
			[Token(Token = "0x6001DEA")]
			[Address(RVA = "0x6302F0", Offset = "0x62F4F0", VA = "0x1806302F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DEB")]
			[Address(RVA = "0x6303B0", Offset = "0x62F5B0", VA = "0x1806303B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001DEC RID: 7660 RVA: 0x0000AC80 File Offset: 0x00008E80
		// (set) Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700056B")]
		public int RandomSewerPossessorIndex
		{
			[Token(Token = "0x6001DEC")]
			[Address(RVA = "0x630330", Offset = "0x62F530", VA = "0x180630330")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001DED")]
			[Address(RVA = "0x630400", Offset = "0x62F600", VA = "0x180630400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700056C")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x630370", Offset = "0x62F570", VA = "0x180630370", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700056D")]
		public string SaveFileName
		{
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x630340", Offset = "0x62F540", VA = "0x180630340", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700056E")]
		public Loader Loader
		{
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x628900", Offset = "0x627B00", VA = "0x180628900", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x1700056F")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DF3 RID: 7667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000570")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x630310", Offset = "0x62F510", VA = "0x180630310", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF3")]
			[Address(RVA = "0x6303C0", Offset = "0x62F5C0", VA = "0x1806303C0", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001DF5 RID: 7669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000571")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001DF4")]
			[Address(RVA = "0x630320", Offset = "0x62F520", VA = "0x180630320", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001DF5")]
			[Address(RVA = "0x6303E0", Offset = "0x62F5E0", VA = "0x1806303E0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000572")]
		public bool HasChanged
		{
			[Token(Token = "0x6001DF6")]
			[Address(RVA = "0x6302E0", Offset = "0x62F4E0", VA = "0x1806302E0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DF7")]
			[Address(RVA = "0x6303A0", Offset = "0x62F5A0", VA = "0x1806303A0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x17000573")]
		public int LoadOrder
		{
			[Token(Token = "0x6001DF8")]
			[Address(RVA = "0x630300", Offset = "0x62F500", VA = "0x180630300", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DF9")]
		[Address(RVA = "0x62C910", Offset = "0x62BB10", VA = "0x18062C910", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFA")]
		[Address(RVA = "0x62FDE0", Offset = "0x62EFE0", VA = "0x18062FDE0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFB")]
		[Address(RVA = "0x62D1A0", Offset = "0x62C3A0", VA = "0x18062D1A0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFC")]
		[Address(RVA = "0x62D870", Offset = "0x62CA70", VA = "0x18062D870", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFD")]
		[Address(RVA = "0x62FCA0", Offset = "0x62EEA0", VA = "0x18062FCA0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetSewerUnlocked_Server()
		{
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFE")]
		[Address(RVA = "0x62FA00", Offset = "0x62EC00", VA = "0x18062FA00")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSewerUnlocked_Client(NetworkConnection conn)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001DFF")]
		[Address(RVA = "0x62F3F0", Offset = "0x62E5F0", VA = "0x18062F3F0")]
		public void SetRandomWorldKeyCollected()
		{
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x62F3F0", Offset = "0x62E5F0", VA = "0x18062F3F0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SetRandomKeyCollected_Server()
		{
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E01")]
		[Address(RVA = "0x62F180", Offset = "0x62E380", VA = "0x18062F180")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetRandomKeyCollected_Client(NetworkConnection conn)
		{
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E02")]
		[Address(RVA = "0x62F780", Offset = "0x62E980", VA = "0x18062F780")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetSewerKeyLocation(NetworkConnection conn, int locationIndex)
		{
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E03")]
		[Address(RVA = "0x62FDD0", Offset = "0x62EFD0", VA = "0x18062FDD0")]
		private void SewerKingDefeated()
		{
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E04")]
		[Address(RVA = "0x62C960", Offset = "0x62BB60", VA = "0x18062C960")]
		[TargetRpc]
		[ObserversRpc]
		private void DisableSewerKing(NetworkConnection conn)
		{
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E05")]
		[Address(RVA = "0x62CD10", Offset = "0x62BF10", VA = "0x18062CD10")]
		public List<Player> GetPlayersInSewer()
		{
			return null;
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E06")]
		[Address(RVA = "0x62CFE0", Offset = "0x62C1E0", VA = "0x18062CFE0", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E07")]
		[Address(RVA = "0x62D230", Offset = "0x62C430", VA = "0x18062D230")]
		public void Load(SewerData sewerData)
		{
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E08")]
		[Address(RVA = "0x62F500", Offset = "0x62E700", VA = "0x18062F500")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void SetRandomKeyPossessor(NetworkConnection conn, int possessorIndex)
		{
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E09")]
		[Address(RVA = "0x62C610", Offset = "0x62B810", VA = "0x18062C610")]
		private void AskedAboutSewerKey()
		{
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0A")]
		[Address(RVA = "0x62CB60", Offset = "0x62BD60", VA = "0x18062CB60")]
		private void EnsureKeyPosessorHasKey()
		{
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001E0B")]
		[Address(RVA = "0x62D150", Offset = "0x62C350", VA = "0x18062D150")]
		public SewerManager.KeyPossessor GetSewerKeyPossessor()
		{
			return null;
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0C")]
		[Address(RVA = "0x6301C0", Offset = "0x62F3C0", VA = "0x1806301C0")]
		public SewerManager()
		{
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0D")]
		[Address(RVA = "0x62D4D0", Offset = "0x62C6D0", VA = "0x18062D4D0", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0E")]
		[Address(RVA = "0x62D480", Offset = "0x62C680", VA = "0x18062D480", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E0F")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E10")]
		[Address(RVA = "0x62EA00", Offset = "0x62DC00", VA = "0x18062EA00")]
		private void RpcWriter___Server_SetSewerUnlocked_Server_2166136261()
		{
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E11")]
		[Address(RVA = "0x617530", Offset = "0x616730", VA = "0x180617530")]
		public void RpcLogic___SetSewerUnlocked_Server_2166136261()
		{
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E12")]
		[Address(RVA = "0x62E080", Offset = "0x62D280", VA = "0x18062E080")]
		private void RpcReader___Server_SetSewerUnlocked_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E13")]
		[Address(RVA = "0x62E7D0", Offset = "0x62D9D0", VA = "0x18062E7D0")]
		private void RpcWriter___Observers_SetSewerUnlocked_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E14")]
		[Address(RVA = "0x62DDF0", Offset = "0x62CFF0", VA = "0x18062DDF0")]
		private void RpcLogic___SetSewerUnlocked_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E15")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		private void RpcReader___Observers_SetSewerUnlocked_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E16")]
		[Address(RVA = "0x62F050", Offset = "0x62E250", VA = "0x18062F050")]
		private void RpcWriter___Target_SetSewerUnlocked_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E17")]
		[Address(RVA = "0x62E270", Offset = "0x62D470", VA = "0x18062E270")]
		private void RpcReader___Target_SetSewerUnlocked_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x62E8F0", Offset = "0x62DAF0", VA = "0x18062E8F0")]
		private void RpcWriter___Server_SetRandomKeyCollected_Server_2166136261()
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x62DA20", Offset = "0x62CC20", VA = "0x18062DA20")]
		private void RpcLogic___SetRandomKeyCollected_Server_2166136261()
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x62E030", Offset = "0x62D230", VA = "0x18062E030")]
		private void RpcReader___Server_SetRandomKeyCollected_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1B")]
		[Address(RVA = "0x62E410", Offset = "0x62D610", VA = "0x18062E410")]
		private void RpcWriter___Observers_SetRandomKeyCollected_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1C")]
		[Address(RVA = "0x62D9E0", Offset = "0x62CBE0", VA = "0x18062D9E0")]
		private void RpcLogic___SetRandomKeyCollected_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E1D RID: 7709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1D")]
		[Address(RVA = "0x62DEB0", Offset = "0x62D0B0", VA = "0x18062DEB0")]
		private void RpcReader___Observers_SetRandomKeyCollected_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1E")]
		[Address(RVA = "0x62EC40", Offset = "0x62DE40", VA = "0x18062EC40")]
		private void RpcWriter___Target_SetRandomKeyCollected_Client_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E1F")]
		[Address(RVA = "0x62E130", Offset = "0x62D330", VA = "0x18062E130")]
		private void RpcReader___Target_SetRandomKeyCollected_Client_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E20")]
		[Address(RVA = "0x62E680", Offset = "0x62D880", VA = "0x18062E680")]
		private void RpcWriter___Observers_SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex)
		{
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E21")]
		[Address(RVA = "0x62DC70", Offset = "0x62CE70", VA = "0x18062DC70")]
		private void RpcLogic___SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex)
		{
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E22")]
		[Address(RVA = "0x62DF80", Offset = "0x62D180", VA = "0x18062DF80")]
		private void RpcReader___Observers_SetSewerKeyLocation_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x62EEE0", Offset = "0x62E0E0", VA = "0x18062EEE0")]
		private void RpcWriter___Target_SetSewerKeyLocation_2681120339(NetworkConnection conn, int locationIndex)
		{
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E24")]
		[Address(RVA = "0x62E200", Offset = "0x62D400", VA = "0x18062E200")]
		private void RpcReader___Target_SetSewerKeyLocation_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E25")]
		[Address(RVA = "0x62E2F0", Offset = "0x62D4F0", VA = "0x18062E2F0")]
		private void RpcWriter___Observers_DisableSewerKing_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E26")]
		[Address(RVA = "0x62D9A0", Offset = "0x62CBA0", VA = "0x18062D9A0")]
		private void RpcLogic___DisableSewerKing_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E27")]
		[Address(RVA = "0x62DE60", Offset = "0x62D060", VA = "0x18062DE60")]
		private void RpcReader___Observers_DisableSewerKing_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E28")]
		[Address(RVA = "0x62EB10", Offset = "0x62DD10", VA = "0x18062EB10")]
		private void RpcWriter___Target_DisableSewerKing_328543758(NetworkConnection conn)
		{
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E29")]
		[Address(RVA = "0x62E0D0", Offset = "0x62D2D0", VA = "0x18062E0D0")]
		private void RpcReader___Target_DisableSewerKing_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2A")]
		[Address(RVA = "0x62E530", Offset = "0x62D730", VA = "0x18062E530")]
		private void RpcWriter___Observers_SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex)
		{
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2B")]
		[Address(RVA = "0x62DA30", Offset = "0x62CC30", VA = "0x18062DA30")]
		private void RpcLogic___SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex)
		{
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2C")]
		[Address(RVA = "0x62DF10", Offset = "0x62D110", VA = "0x18062DF10")]
		private void RpcReader___Observers_SetRandomKeyPossessor_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2D")]
		[Address(RVA = "0x62ED70", Offset = "0x62DF70", VA = "0x18062ED70")]
		private void RpcWriter___Target_SetRandomKeyPossessor_2681120339(NetworkConnection conn, int possessorIndex)
		{
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2E")]
		[Address(RVA = "0x62E190", Offset = "0x62D390", VA = "0x18062E190")]
		private void RpcReader___Target_SetRandomKeyPossessor_2681120339(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E2F")]
		[Address(RVA = "0x62C700", Offset = "0x62B900", VA = "0x18062C700", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Map.SewerManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001946 RID: 6470
		[Token(Token = "0x4001946")]
		[FieldOffset(Offset = "0x130")]
		public ItemDefinition SewerKeyItem;

		// Token: 0x04001947 RID: 6471
		[Token(Token = "0x4001947")]
		[FieldOffset(Offset = "0x138")]
		public AudioSourceController SewerUnlockSound;

		// Token: 0x04001948 RID: 6472
		[Token(Token = "0x4001948")]
		[FieldOffset(Offset = "0x140")]
		public NetworkedItemPickup RandomWorldSewerKeyPickup;

		// Token: 0x04001949 RID: 6473
		[Token(Token = "0x4001949")]
		[FieldOffset(Offset = "0x148")]
		public Transform[] RandomSewerKeyLocations;

		// Token: 0x0400194A RID: 6474
		[Token(Token = "0x400194A")]
		[FieldOffset(Offset = "0x150")]
		public SewerKing SewerKingNPC;

		// Token: 0x0400194B RID: 6475
		[Token(Token = "0x400194B")]
		[FieldOffset(Offset = "0x158")]
		public SewerGoblin SewerGoblinNPC;

		// Token: 0x0400194C RID: 6476
		[Token(Token = "0x400194C")]
		[FieldOffset(Offset = "0x160")]
		public SewerManager.KeyPossessor[] SewerKeyPossessors;

		// Token: 0x0400194D RID: 6477
		[Token(Token = "0x400194D")]
		[FieldOffset(Offset = "0x168")]
		public SewerMushrooms SewerMushrooms;

		// Token: 0x0400194E RID: 6478
		[Token(Token = "0x400194E")]
		[FieldOffset(Offset = "0x170")]
		private SewerLoader loader;

		// Token: 0x04001953 RID: 6483
		[Token(Token = "0x4001953")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.SewerManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001954 RID: 6484
		[Token(Token = "0x4001954")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.Map.SewerManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000549 RID: 1353
		[Token(Token = "0x2000549")]
		[Serializable]
		public class KeyPossessor
		{
			// Token: 0x06001E30 RID: 7728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001E30")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public KeyPossessor()
			{
			}

			// Token: 0x04001955 RID: 6485
			[Token(Token = "0x4001955")]
			[FieldOffset(Offset = "0x10")]
			public NPC NPC;

			// Token: 0x04001956 RID: 6486
			[Token(Token = "0x4001956")]
			[FieldOffset(Offset = "0x18")]
			[Tooltip("Description of the NPC for Oscar's key location dialogue.")]
			public string NPCDescription;
		}
	}
}
