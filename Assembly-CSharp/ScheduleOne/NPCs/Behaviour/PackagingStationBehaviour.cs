using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AFA RID: 2810
	[Token(Token = "0x2000AFA")]
	public class PackagingStationBehaviour : Behaviour
	{
		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x060051FC RID: 20988 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060051FD RID: 20989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4C")]
		public PackagingStation Station
		{
			[Token(Token = "0x60051FC")]
			[Address(RVA = "0x5887E0", Offset = "0x5879E0", VA = "0x1805887E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60051FD")]
			[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x060051FE RID: 20990 RVA: 0x000157F8 File Offset: 0x000139F8
		// (set) Token: 0x060051FF RID: 20991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4D")]
		public bool PackagingInProgress
		{
			[Token(Token = "0x60051FE")]
			[Address(RVA = "0x5887A0", Offset = "0x5879A0", VA = "0x1805887A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60051FF")]
			[Address(RVA = "0x588850", Offset = "0x587A50", VA = "0x180588850")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005200 RID: 20992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x9557A0", Offset = "0x9549A0", VA = "0x1809557A0", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005201 RID: 20993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005201")]
		[Address(RVA = "0x956000", Offset = "0x955200", VA = "0x180956000", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005202 RID: 20994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005202")]
		[Address(RVA = "0x955FD0", Offset = "0x9551D0", VA = "0x180955FD0", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005203")]
		[Address(RVA = "0x947550", Offset = "0x946750", VA = "0x180947550", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005204")]
		[Address(RVA = "0x9558E0", Offset = "0x954AE0", VA = "0x1809558E0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005205")]
		[Address(RVA = "0x955D10", Offset = "0x954F10", VA = "0x180955D10", Slot = "28")]
		public override void OnActiveTick()
		{
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005206")]
		[Address(RVA = "0x9562E0", Offset = "0x9554E0", VA = "0x1809562E0")]
		private void StartPackaging()
		{
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005207")]
		[Address(RVA = "0x588880", Offset = "0x587A80", VA = "0x180588880")]
		public void AssignStation(PackagingStation station)
		{
		}

		// Token: 0x06005208 RID: 21000 RVA: 0x00015810 File Offset: 0x00013A10
		[Token(Token = "0x6005208")]
		[Address(RVA = "0x955A70", Offset = "0x954C70", VA = "0x180955A70")]
		public bool IsAtStation()
		{
			return default(bool);
		}

		// Token: 0x06005209 RID: 21001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005209")]
		[Address(RVA = "0x9559F0", Offset = "0x954BF0", VA = "0x1809559F0")]
		public void GoToStation()
		{
		}

		// Token: 0x0600520A RID: 21002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600520A")]
		[Address(RVA = "0x9557C0", Offset = "0x9549C0", VA = "0x1809557C0")]
		[ObserversRpc(RunLocally = true)]
		public void BeginPackaging()
		{
		}

		// Token: 0x0600520B RID: 21003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600520B")]
		[Address(RVA = "0x9563E0", Offset = "0x9555E0", VA = "0x1809563E0")]
		private void StopPackaging()
		{
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x00015828 File Offset: 0x00013A28
		[Token(Token = "0x600520C")]
		[Address(RVA = "0x955B00", Offset = "0x954D00", VA = "0x180955B00")]
		public bool IsStationReady(PackagingStation station)
		{
			return default(bool);
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600520D")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public PackagingStationBehaviour()
		{
		}

		// Token: 0x0600520E RID: 21006 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600520E")]
		[Address(RVA = "0x956540", Offset = "0x955740", VA = "0x180956540")]
		[CompilerGenerated]
		private IEnumerator <BeginPackaging>g__Package|20_0()
		{
			return null;
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600520F")]
		[Address(RVA = "0x955C80", Offset = "0x954E80", VA = "0x180955C80", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005210 RID: 21008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005210")]
		[Address(RVA = "0x948840", Offset = "0x947A40", VA = "0x180948840", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005211 RID: 21009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005211")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005212")]
		[Address(RVA = "0x9561D0", Offset = "0x9553D0", VA = "0x1809561D0")]
		private void RpcWriter___Observers_BeginPackaging_2166136261()
		{
		}

		// Token: 0x06005213 RID: 21011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005213")]
		[Address(RVA = "0x956020", Offset = "0x955220", VA = "0x180956020")]
		public void RpcLogic___BeginPackaging_2166136261()
		{
		}

		// Token: 0x06005214 RID: 21012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005214")]
		[Address(RVA = "0x956190", Offset = "0x955390", VA = "0x180956190")]
		private void RpcReader___Observers_BeginPackaging_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005215")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x0400380E RID: 14350
		[Token(Token = "0x400380E")]
		public const float BASE_PACKAGING_TIME = 5f;

		// Token: 0x04003811 RID: 14353
		[Token(Token = "0x4003811")]
		[FieldOffset(Offset = "0x178")]
		private Coroutine packagingRoutine;

		// Token: 0x04003812 RID: 14354
		[Token(Token = "0x4003812")]
		[FieldOffset(Offset = "0x180")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003813 RID: 14355
		[Token(Token = "0x4003813")]
		[FieldOffset(Offset = "0x181")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted;
	}
}
