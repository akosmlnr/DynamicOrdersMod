using System;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.EntityFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x2000978")]
	public class Jukebox : GridItem
	{
		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060040CC RID: 16588 RVA: 0x000125E8 File Offset: 0x000107E8
		[Token(Token = "0x17000A0E")]
		public int CurrentVolume
		{
			[Token(Token = "0x60040CC")]
			[Address(RVA = "0x85DD70", Offset = "0x85CF70", VA = "0x18085DD70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x00012600 File Offset: 0x00010800
		[Token(Token = "0x17000A0F")]
		public float NormalizedVolume
		{
			[Token(Token = "0x60040CD")]
			[Address(RVA = "0x85DDB0", Offset = "0x85CFB0", VA = "0x18085DDB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x00012618 File Offset: 0x00010818
		[Token(Token = "0x17000A10")]
		public bool IsPlaying
		{
			[Token(Token = "0x60040CE")]
			[Address(RVA = "0x85DD90", Offset = "0x85CF90", VA = "0x18085DD90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x00012630 File Offset: 0x00010830
		[Token(Token = "0x17000A11")]
		public float CurrentTrackTime
		{
			[Token(Token = "0x60040CF")]
			[Address(RVA = "0x85DD50", Offset = "0x85CF50", VA = "0x18085DD50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060040D0 RID: 16592 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A12")]
		private int[] TrackOrder
		{
			[Token(Token = "0x60040D0")]
			[Address(RVA = "0x85DE40", Offset = "0x85D040", VA = "0x18085DE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x00012648 File Offset: 0x00010848
		[Token(Token = "0x17000A13")]
		public int CurrentTrackOrderIndex
		{
			[Token(Token = "0x60040D1")]
			[Address(RVA = "0x85DD30", Offset = "0x85CF30", VA = "0x18085DD30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x060040D2 RID: 16594 RVA: 0x00012660 File Offset: 0x00010860
		[Token(Token = "0x17000A14")]
		public bool Shuffle
		{
			[Token(Token = "0x60040D2")]
			[Address(RVA = "0x85DE00", Offset = "0x85D000", VA = "0x18085DE00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x060040D3 RID: 16595 RVA: 0x00012678 File Offset: 0x00010878
		[Token(Token = "0x17000A15")]
		public Jukebox.ERepeatMode RepeatMode
		{
			[Token(Token = "0x60040D3")]
			[Address(RVA = "0x85DDE0", Offset = "0x85CFE0", VA = "0x18085DDE0")]
			get
			{
				return Jukebox.ERepeatMode.None;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x060040D4 RID: 16596 RVA: 0x00012690 File Offset: 0x00010890
		[Token(Token = "0x17000A16")]
		public bool Sync
		{
			[Token(Token = "0x60040D4")]
			[Address(RVA = "0x85DE20", Offset = "0x85D020", VA = "0x18085DE20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x060040D5 RID: 16597 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A17")]
		public Jukebox.Track currentTrack
		{
			[Token(Token = "0x60040D5")]
			[Address(RVA = "0x85DE90", Offset = "0x85D090", VA = "0x18085DE90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x060040D6 RID: 16598 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A18")]
		private AudioClip currentClip
		{
			[Token(Token = "0x60040D6")]
			[Address(RVA = "0x85DE60", Offset = "0x85D060", VA = "0x18085DE60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D7")]
		[Address(RVA = "0x85BCA0", Offset = "0x85AEA0", VA = "0x18085BCA0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D8")]
		[Address(RVA = "0x85BDD0", Offset = "0x85AFD0", VA = "0x18085BDD0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040D9")]
		[Address(RVA = "0x85C390", Offset = "0x85B590", VA = "0x18085C390", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040DA")]
		[Address(RVA = "0x85BDA0", Offset = "0x85AFA0", VA = "0x18085BDA0")]
		public void ChangeVolume(int change)
		{
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040DB")]
		[Address(RVA = "0x85D5F0", Offset = "0x85C7F0", VA = "0x18085D5F0")]
		public void SetVolume(int volume, bool replicate)
		{
		}

		// Token: 0x060040DC RID: 16604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040DC")]
		[Address(RVA = "0x85D720", Offset = "0x85C920", VA = "0x18085D720")]
		[Button]
		public void TogglePlay()
		{
		}

		// Token: 0x060040DD RID: 16605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040DD")]
		[Address(RVA = "0x85BCF0", Offset = "0x85AEF0", VA = "0x18085BCF0")]
		[Button]
		public void Back()
		{
		}

		// Token: 0x060040DE RID: 16606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040DE")]
		[Address(RVA = "0x85C2F0", Offset = "0x85B4F0", VA = "0x18085C2F0")]
		[Button]
		public void Next()
		{
		}

		// Token: 0x060040DF RID: 16607 RVA: 0x000126A8 File Offset: 0x000108A8
		[Token(Token = "0x60040DF")]
		[Address(RVA = "0x85C060", Offset = "0x85B260", VA = "0x18085C060")]
		private int GetPreviousTrackOrderIndex()
		{
			return 0;
		}

		// Token: 0x060040E0 RID: 16608 RVA: 0x000126C0 File Offset: 0x000108C0
		[Token(Token = "0x60040E0")]
		[Address(RVA = "0x85C020", Offset = "0x85B220", VA = "0x18085C020")]
		private int GetNextTrackOrderIndex()
		{
			return 0;
		}

		// Token: 0x060040E1 RID: 16609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E1")]
		[Address(RVA = "0x85D830", Offset = "0x85CA30", VA = "0x18085D830")]
		[Button]
		public void ToggleShuffle()
		{
		}

		// Token: 0x060040E2 RID: 16610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E2")]
		[Address(RVA = "0x85D7A0", Offset = "0x85C9A0", VA = "0x18085D7A0")]
		[Button]
		public void ToggleRepeatMode()
		{
		}

		// Token: 0x060040E3 RID: 16611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E3")]
		[Address(RVA = "0x85DB00", Offset = "0x85CD00", VA = "0x18085DB00")]
		[Button]
		public void ToggleSync()
		{
		}

		// Token: 0x060040E4 RID: 16612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E4")]
		[Address(RVA = "0x85C3F0", Offset = "0x85B5F0", VA = "0x18085C3F0")]
		public void PlayTrack(int trackID)
		{
		}

		// Token: 0x060040E5 RID: 16613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E5")]
		[Address(RVA = "0x85CED0", Offset = "0x85C0D0", VA = "0x18085CED0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendJukeboxState(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040E6 RID: 16614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E6")]
		[Address(RVA = "0x85D060", Offset = "0x85C260", VA = "0x18085D060")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetJukeboxState(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040E7 RID: 16615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040E7")]
		[Address(RVA = "0x85D320", Offset = "0x85C520", VA = "0x18085D320")]
		public void SetJukeboxState(Jukebox.JukeboxState state, bool setTrackTime)
		{
		}

		// Token: 0x060040E8 RID: 16616 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60040E8")]
		[Address(RVA = "0x85C0A0", Offset = "0x85B2A0", VA = "0x18085C0A0")]
		private Jukebox.Track GetTrack(int orderIndex)
		{
			return null;
		}

		// Token: 0x060040E9 RID: 16617 RVA: 0x000126D8 File Offset: 0x000108D8
		[Token(Token = "0x60040E9")]
		[Address(RVA = "0x85DB60", Offset = "0x85CD60", VA = "0x18085DB60")]
		private bool ValidateQueue(int[] queue)
		{
			return default(bool);
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EA")]
		[Address(RVA = "0x85C600", Offset = "0x85B800", VA = "0x18085C600")]
		private void ReplicateStateToOtherClients(bool setTrackTime)
		{
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EB")]
		[Address(RVA = "0x85C630", Offset = "0x85B830", VA = "0x18085C630")]
		private void ReplicateStateToOtherJukeboxes(bool setTrackTime)
		{
		}

		// Token: 0x060040EC RID: 16620 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60040EC")]
		[Address(RVA = "0x85BF20", Offset = "0x85B120", VA = "0x18085BF20", Slot = "61")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x060040ED RID: 16621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040ED")]
		[Address(RVA = "0x85DD20", Offset = "0x85CF20", VA = "0x18085DD20")]
		public Jukebox()
		{
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EE")]
		[Address(RVA = "0x85C1C0", Offset = "0x85B3C0", VA = "0x18085C1C0", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040EF")]
		[Address(RVA = "0x85C1A0", Offset = "0x85B3A0", VA = "0x18085C1A0", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F0")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F1")]
		[Address(RVA = "0x85CC00", Offset = "0x85BE00", VA = "0x18085CC00")]
		private void RpcWriter___Server_SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F2")]
		[Address(RVA = "0x85C7E0", Offset = "0x85B9E0", VA = "0x18085C7E0")]
		public void RpcLogic___SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F3")]
		[Address(RVA = "0x85C8E0", Offset = "0x85BAE0", VA = "0x18085C8E0")]
		private void RpcReader___Server_SendJukeboxState_1728100027(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F4")]
		[Address(RVA = "0x85CA80", Offset = "0x85BC80", VA = "0x18085CA80")]
		private void RpcWriter___Observers_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F5")]
		[Address(RVA = "0x85C810", Offset = "0x85BA10", VA = "0x18085C810")]
		public void RpcLogic___SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F6")]
		[Address(RVA = "0x85C830", Offset = "0x85BA30", VA = "0x18085C830")]
		private void RpcReader___Observers_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F7")]
		[Address(RVA = "0x85CD60", Offset = "0x85BF60", VA = "0x18085CD60")]
		private void RpcWriter___Target_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F8")]
		[Address(RVA = "0x85C9D0", Offset = "0x85BBD0", VA = "0x18085C9D0")]
		private void RpcReader___Target_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040F9")]
		[Address(RVA = "0x85BA20", Offset = "0x85AC20", VA = "0x18085BA20", Slot = "71")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.Jukebox_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002F27 RID: 12071
		[Token(Token = "0x4002F27")]
		public const float MUSIC_FADE_MULTIPLIER = 0.4f;

		// Token: 0x04002F28 RID: 12072
		[Token(Token = "0x4002F28")]
		public const int TRACK_COUNT = 27;

		// Token: 0x04002F29 RID: 12073
		[Token(Token = "0x4002F29")]
		[FieldOffset(Offset = "0x210")]
		private Jukebox.JukeboxState _jukeboxState;

		// Token: 0x04002F2A RID: 12074
		[Token(Token = "0x4002F2A")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public Jukebox.Track[] TrackList;

		// Token: 0x04002F2B RID: 12075
		[Token(Token = "0x4002F2B")]
		[FieldOffset(Offset = "0x220")]
		public GameObject[] VolumeIndicatorBars;

		// Token: 0x04002F2C RID: 12076
		[Token(Token = "0x4002F2C")]
		[FieldOffset(Offset = "0x228")]
		public AudioSourceController AudioSourceController;

		// Token: 0x04002F2D RID: 12077
		[Token(Token = "0x4002F2D")]
		[FieldOffset(Offset = "0x230")]
		public Action onStateChanged;

		// Token: 0x04002F2E RID: 12078
		[Token(Token = "0x4002F2E")]
		[FieldOffset(Offset = "0x238")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F2F RID: 12079
		[Token(Token = "0x4002F2F")]
		[FieldOffset(Offset = "0x239")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted;

		// Token: 0x02000979 RID: 2425
		[Token(Token = "0x2000979")]
		[Serializable]
		public class Track
		{
			// Token: 0x060040FA RID: 16634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040FA")]
			[Address(RVA = "0x882B10", Offset = "0x881D10", VA = "0x180882B10")]
			public Track()
			{
			}

			// Token: 0x04002F30 RID: 12080
			[Token(Token = "0x4002F30")]
			[FieldOffset(Offset = "0x10")]
			public string TrackName;

			// Token: 0x04002F31 RID: 12081
			[Token(Token = "0x4002F31")]
			[FieldOffset(Offset = "0x18")]
			public AudioClip Clip;

			// Token: 0x04002F32 RID: 12082
			[Token(Token = "0x4002F32")]
			[FieldOffset(Offset = "0x20")]
			public string ArtistName;
		}

		// Token: 0x0200097A RID: 2426
		[Token(Token = "0x200097A")]
		[Serializable]
		public class JukeboxState
		{
			// Token: 0x060040FB RID: 16635 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60040FB")]
			[Address(RVA = "0x882330", Offset = "0x881530", VA = "0x180882330")]
			public JukeboxState()
			{
			}

			// Token: 0x04002F33 RID: 12083
			[Token(Token = "0x4002F33")]
			[FieldOffset(Offset = "0x10")]
			public int CurrentVolume;

			// Token: 0x04002F34 RID: 12084
			[Token(Token = "0x4002F34")]
			[FieldOffset(Offset = "0x14")]
			public bool IsPlaying;

			// Token: 0x04002F35 RID: 12085
			[Token(Token = "0x4002F35")]
			[FieldOffset(Offset = "0x18")]
			public float CurrentTrackTime;

			// Token: 0x04002F36 RID: 12086
			[Token(Token = "0x4002F36")]
			[FieldOffset(Offset = "0x20")]
			public int[] TrackOrder;

			// Token: 0x04002F37 RID: 12087
			[Token(Token = "0x4002F37")]
			[FieldOffset(Offset = "0x28")]
			public int CurrentTrackOrderIndex;

			// Token: 0x04002F38 RID: 12088
			[Token(Token = "0x4002F38")]
			[FieldOffset(Offset = "0x2C")]
			public bool Shuffle;

			// Token: 0x04002F39 RID: 12089
			[Token(Token = "0x4002F39")]
			[FieldOffset(Offset = "0x30")]
			public Jukebox.ERepeatMode RepeatMode;

			// Token: 0x04002F3A RID: 12090
			[Token(Token = "0x4002F3A")]
			[FieldOffset(Offset = "0x34")]
			public bool Sync;
		}

		// Token: 0x0200097B RID: 2427
		[Token(Token = "0x200097B")]
		public enum ERepeatMode
		{
			// Token: 0x04002F3C RID: 12092
			[Token(Token = "0x4002F3C")]
			None,
			// Token: 0x04002F3D RID: 12093
			[Token(Token = "0x4002F3D")]
			RepeatQueue,
			// Token: 0x04002F3E RID: 12094
			[Token(Token = "0x4002F3E")]
			RepeatTrack
		}
	}
}
