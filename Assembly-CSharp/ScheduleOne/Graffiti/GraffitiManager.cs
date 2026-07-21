using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Levelling;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Graffiti
{
	// Token: 0x0200064A RID: 1610
	[Token(Token = "0x200064A")]
	public class GraffitiManager : NetworkSingleton<GraffitiManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E6")]
		public List<WorldSpraySurface> WorldSpraySurfaces
		{
			[Token(Token = "0x60027A2")]
			[Address(RVA = "0x58D0A0", Offset = "0x58C2A0", VA = "0x18058D0A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027A3")]
			[Address(RVA = "0x58D280", Offset = "0x58C480", VA = "0x18058D280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006E7")]
		public string SaveFolderName
		{
			[Token(Token = "0x60027A4")]
			[Address(RVA = "0x6BCCE0", Offset = "0x6BBEE0", VA = "0x1806BCCE0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006E8")]
		public string SaveFileName
		{
			[Token(Token = "0x60027A5")]
			[Address(RVA = "0x6BCCB0", Offset = "0x6BBEB0", VA = "0x1806BCCB0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006E9")]
		public Loader Loader
		{
			[Token(Token = "0x60027A6")]
			[Address(RVA = "0x57F810", Offset = "0x57EA10", VA = "0x18057F810", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x170006EA")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60027A7")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EB")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027A9")]
			[Address(RVA = "0x57F870", Offset = "0x57EA70", VA = "0x18057F870", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EC")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60027AA")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027AB")]
			[Address(RVA = "0x6BCD20", Offset = "0x6BBF20", VA = "0x1806BCD20", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x060027AC RID: 10156 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		// (set) Token: 0x060027AD RID: 10157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006ED")]
		public bool HasChanged
		{
			[Token(Token = "0x60027AC")]
			[Address(RVA = "0x6BCC80", Offset = "0x6BBE80", VA = "0x1806BCC80", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027AD")]
			[Address(RVA = "0x6BCD10", Offset = "0x6BBF10", VA = "0x1806BCD10", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x170006EE")]
		public int LoadOrder
		{
			[Token(Token = "0x60027AE")]
			[Address(RVA = "0x6BCC90", Offset = "0x6BBE90", VA = "0x1806BCC90", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027AF")]
		[Address(RVA = "0x6BBAE0", Offset = "0x6BACE0", VA = "0x1806BBAE0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B0")]
		[Address(RVA = "0x6BC3B0", Offset = "0x6BB5B0", VA = "0x1806BC3B0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060027B1 RID: 10161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B1")]
		[Address(RVA = "0x6BC280", Offset = "0x6BB480", VA = "0x1806BC280", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060027B2 RID: 10162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B2")]
		[Address(RVA = "0x6BC890", Offset = "0x6BBA90", VA = "0x1806BC890")]
		private void SprayPaintPurchaseCountChanged(float newValue)
		{
		}

		// Token: 0x060027B3 RID: 10163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B3")]
		[Address(RVA = "0x6BC890", Offset = "0x6BBA90", VA = "0x1806BC890")]
		private void RankChange(FullRank oldRank, FullRank newRank)
		{
		}

		// Token: 0x060027B4 RID: 10164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B4")]
		[Address(RVA = "0x6BC8A0", Offset = "0x6BBAA0", VA = "0x1806BC8A0")]
		private void UpdateSprayPaintStockVariable()
		{
		}

		// Token: 0x060027B5 RID: 10165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027B5")]
		[Address(RVA = "0x6BBF40", Offset = "0x6BB140", VA = "0x1806BBF40", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060027B6 RID: 10166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x6BC770", Offset = "0x6BB970", VA = "0x1806BC770")]
		public void QueueSurfaceToReplicate(SpraySurface surface, NetworkConnection conn)
		{
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x6BBE40", Offset = "0x6BB040", VA = "0x1806BBE40")]
		public float GetPixelStrength(byte strokeSize, int pixelIndex)
		{
			return 0f;
		}

		// Token: 0x060027B8 RID: 10168 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60027B8")]
		[Address(RVA = "0x6BBBF0", Offset = "0x6BADF0", VA = "0x1806BBBF0")]
		private float[] GetFalloffTable(int strokeSize)
		{
			return null;
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027B9")]
		[Address(RVA = "0x6BCAE0", Offset = "0x6BBCE0", VA = "0x1806BCAE0")]
		public GraffitiManager()
		{
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BA")]
		[Address(RVA = "0x6BC360", Offset = "0x6BB560", VA = "0x1806BC360", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BB")]
		[Address(RVA = "0x6BC310", Offset = "0x6BB510", VA = "0x1806BC310", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BC")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060027BD RID: 10173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027BD")]
		[Address(RVA = "0x6BB9F0", Offset = "0x6BABF0", VA = "0x1806BB9F0", Slot = "51")]
		protected virtual void Awake_UserLogic_ScheduleOne.Graffiti.GraffitiManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001EC7 RID: 7879
		[Token(Token = "0x4001EC7")]
		private const string SPRAY_PAINT_STOCK_VARIABLE = "SprayPaintStock";

		// Token: 0x04001EC8 RID: 7880
		[Token(Token = "0x4001EC8")]
		private const string SPRAY_PAINTS_PURCHASED_VARIABLE = "SprayPaintsPurchased";

		// Token: 0x04001ECA RID: 7882
		[Token(Token = "0x4001ECA")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private AnimationCurve _falloffCurve;

		// Token: 0x04001ECB RID: 7883
		[Token(Token = "0x4001ECB")]
		[FieldOffset(Offset = "0x130")]
		private Dictionary<byte, float[]> _falloffTableCache;

		// Token: 0x04001ECC RID: 7884
		[Token(Token = "0x4001ECC")]
		[FieldOffset(Offset = "0x138")]
		private GraffitiLoader loader;

		// Token: 0x04001ED1 RID: 7889
		[Token(Token = "0x4001ED1")]
		[FieldOffset(Offset = "0x158")]
		private bool NetworkInitialize___EarlyScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04001ED2 RID: 7890
		[Token(Token = "0x4001ED2")]
		[FieldOffset(Offset = "0x159")]
		private bool NetworkInitialize__LateScheduleOne.Graffiti.GraffitiManagerAssembly-CSharp.dll_Excuted;
	}
}
