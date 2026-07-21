using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Map;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A53 RID: 2643
	[Token(Token = "0x2000A53")]
	public class NPCManager : NetworkSingleton<NPCManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x06004C22 RID: 19490 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BCC")]
		public string SaveFolderName
		{
			[Token(Token = "0x6004C22")]
			[Address(RVA = "0x921DC0", Offset = "0x920FC0", VA = "0x180921DC0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x06004C23 RID: 19491 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BCD")]
		public string SaveFileName
		{
			[Token(Token = "0x6004C23")]
			[Address(RVA = "0x921D90", Offset = "0x920F90", VA = "0x180921D90", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x06004C24 RID: 19492 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000BCE")]
		public Loader Loader
		{
			[Token(Token = "0x6004C24")]
			[Address(RVA = "0x6BCCA0", Offset = "0x6BBEA0", VA = "0x1806BCCA0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06004C25 RID: 19493 RVA: 0x00014778 File Offset: 0x00012978
		[Token(Token = "0x17000BCF")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6004C25")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06004C26 RID: 19494 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004C27 RID: 19495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD0")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6004C26")]
			[Address(RVA = "0x5A44D0", Offset = "0x5A36D0", VA = "0x1805A44D0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C27")]
			[Address(RVA = "0x755980", Offset = "0x754B80", VA = "0x180755980", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06004C28 RID: 19496 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06004C29 RID: 19497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD1")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6004C28")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C29")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06004C2A RID: 19498 RVA: 0x00014790 File Offset: 0x00012990
		// (set) Token: 0x06004C2B RID: 19499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD2")]
		public bool HasChanged
		{
			[Token(Token = "0x6004C2A")]
			[Address(RVA = "0x71D4F0", Offset = "0x71C6F0", VA = "0x18071D4F0", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C2B")]
			[Address(RVA = "0x7DEA40", Offset = "0x7DDC40", VA = "0x1807DEA40", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06004C2C RID: 19500 RVA: 0x000147A8 File Offset: 0x000129A8
		[Token(Token = "0x17000BD3")]
		public int LoadOrder
		{
			[Token(Token = "0x6004C2C")]
			[Address(RVA = "0x7DE9D0", Offset = "0x7DDBD0", VA = "0x1807DE9D0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06004C2D RID: 19501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2D")]
		[Address(RVA = "0x920CB0", Offset = "0x91FEB0", VA = "0x180920CB0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x06004C2E RID: 19502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2E")]
		[Address(RVA = "0x9217E0", Offset = "0x9209E0", VA = "0x1809217E0", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x06004C2F RID: 19503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C2F")]
		[Address(RVA = "0x9216B0", Offset = "0x9208B0", VA = "0x1809216B0", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06004C30 RID: 19504 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C30")]
		[Address(RVA = "0x920D30", Offset = "0x91FF30", VA = "0x180920D30")]
		public static NPC GetNPC(string id)
		{
			return null;
		}

		// Token: 0x06004C31 RID: 19505 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C31")]
		[Address(RVA = "0x920EF0", Offset = "0x9200F0", VA = "0x180920EF0")]
		public static List<NPC> GetNPCsInRegion(EMapRegion region)
		{
			return null;
		}

		// Token: 0x06004C32 RID: 19506 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C32")]
		[Address(RVA = "0x921490", Offset = "0x920690", VA = "0x180921490", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06004C33 RID: 19507 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x921360", Offset = "0x920560", VA = "0x180921360")]
		public List<Transform> GetOrderedDistanceWarpPoints(Vector3 origin)
		{
			return null;
		}

		// Token: 0x06004C34 RID: 19508 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x921960", Offset = "0x920B60", VA = "0x180921960", Slot = "51")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06004C35 RID: 19509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x921100", Offset = "0x920300", VA = "0x180921100")]
		[Button]
		public void GetNPCsWithSewerKey()
		{
		}

		// Token: 0x06004C36 RID: 19510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x921C90", Offset = "0x920E90", VA = "0x180921C90")]
		public NPCManager()
		{
		}

		// Token: 0x06004C38 RID: 19512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C38")]
		[Address(RVA = "0x921790", Offset = "0x920990", VA = "0x180921790", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004C39 RID: 19513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C39")]
		[Address(RVA = "0x921740", Offset = "0x920940", VA = "0x180921740", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004C3A RID: 19514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3A")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004C3B RID: 19515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C3B")]
		[Address(RVA = "0x920C60", Offset = "0x91FE60", VA = "0x180920C60", Slot = "52")]
		protected virtual void Awake_UserLogic_ScheduleOne.NPCs.NPCManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x0")]
		public static List<NPC> NPCRegistry;

		// Token: 0x04003554 RID: 13652
		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x120")]
		public Transform[] NPCWarpPoints;

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x128")]
		public Transform NPCContainer;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		public NPCPoI NPCPoIPrefab;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x138")]
		public NPCPoI PotentialCustomerPoIPrefab;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x140")]
		public NPCPoI PotentialDealerPoIPrefab;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x148")]
		private NPCsLoader loader;

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0x168")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x169")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted;
	}
}
