using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200097C RID: 2428
	[Token(Token = "0x200097C")]
	public class JukeboxInterface : MonoBehaviour
	{
		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x060040FC RID: 16636 RVA: 0x000126F0 File Offset: 0x000108F0
		// (set) Token: 0x060040FD RID: 16637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A19")]
		public bool IsOpen
		{
			[Token(Token = "0x60040FC")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60040FD")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FE")]
		[Address(RVA = "0x880760", Offset = "0x87F960", VA = "0x180880760")]
		private void Awake()
		{
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040FF")]
		[Address(RVA = "0x880D80", Offset = "0x87FF80", VA = "0x180880D80")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004100")]
		[Address(RVA = "0x881E20", Offset = "0x881020", VA = "0x180881E20")]
		private void UpdateAmbientDisplay()
		{
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004101")]
		[Address(RVA = "0x8817D0", Offset = "0x8809D0", VA = "0x1808817D0")]
		private void SetupSongEntries()
		{
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004102")]
		[Address(RVA = "0x881CA0", Offset = "0x880EA0", VA = "0x180881CA0")]
		public void Start()
		{
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004103")]
		[Address(RVA = "0x880E30", Offset = "0x880030", VA = "0x180880E30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004104")]
		[Address(RVA = "0x880D30", Offset = "0x87FF30", VA = "0x180880D30")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004105")]
		[Address(RVA = "0x880EC0", Offset = "0x8800C0", VA = "0x180880EC0")]
		public void Open()
		{
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004106")]
		[Address(RVA = "0x880A40", Offset = "0x87FC40", VA = "0x180880A40")]
		public void Close()
		{
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004107")]
		[Address(RVA = "0x880D90", Offset = "0x87FF90", VA = "0x180880D90")]
		private void Hovered()
		{
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004108")]
		[Address(RVA = "0x880E00", Offset = "0x880000", VA = "0x180880E00")]
		private void Interacted()
		{
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004109")]
		[Address(RVA = "0x8812E0", Offset = "0x8804E0", VA = "0x1808812E0")]
		public void PlayPausePressed()
		{
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410A")]
		[Address(RVA = "0x880A20", Offset = "0x87FC20", VA = "0x180880A20")]
		public void BackPressed()
		{
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410B")]
		[Address(RVA = "0x880E10", Offset = "0x880010", VA = "0x180880E10")]
		public void NextPressed()
		{
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410C")]
		[Address(RVA = "0x881BC0", Offset = "0x880DC0", VA = "0x180881BC0")]
		public void ShufflePressed()
		{
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410D")]
		[Address(RVA = "0x8817B0", Offset = "0x8809B0", VA = "0x1808817B0")]
		public void RepeatPressed()
		{
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410E")]
		[Address(RVA = "0x881E00", Offset = "0x881000", VA = "0x180881E00")]
		public void SyncPressed()
		{
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600410F")]
		[Address(RVA = "0x881BE0", Offset = "0x880DE0", VA = "0x180881BE0")]
		public void SongEntryClicked(RectTransform entry)
		{
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004110")]
		[Address(RVA = "0x881380", Offset = "0x880580", VA = "0x180881380")]
		private void RefreshSongEntries()
		{
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004111")]
		[Address(RVA = "0x881550", Offset = "0x880750", VA = "0x180881550")]
		private void RefreshUI()
		{
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004112")]
		[Address(RVA = "0x881300", Offset = "0x880500", VA = "0x180881300")]
		private void RefreshAmbientDisplay()
		{
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004113")]
		[Address(RVA = "0x8822B0", Offset = "0x8814B0", VA = "0x1808822B0")]
		public JukeboxInterface()
		{
		}

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		public const float OPEN_TIME = 0.15f;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Jukebox Jukebox;

		// Token: 0x04002F42 RID: 12098
		[Token(Token = "0x4002F42")]
		[FieldOffset(Offset = "0x30")]
		public Canvas Canvas;

		// Token: 0x04002F43 RID: 12099
		[Token(Token = "0x4002F43")]
		[FieldOffset(Offset = "0x38")]
		public Transform CameraPosition;

		// Token: 0x04002F44 RID: 12100
		[Token(Token = "0x4002F44")]
		[FieldOffset(Offset = "0x40")]
		public InteractableObject IntObj;

		// Token: 0x04002F45 RID: 12101
		[Token(Token = "0x4002F45")]
		[FieldOffset(Offset = "0x48")]
		public Image PausePlayImage;

		// Token: 0x04002F46 RID: 12102
		[Token(Token = "0x4002F46")]
		[FieldOffset(Offset = "0x50")]
		public Button ShuffleButton;

		// Token: 0x04002F47 RID: 12103
		[Token(Token = "0x4002F47")]
		[FieldOffset(Offset = "0x58")]
		public Button RepeatButton;

		// Token: 0x04002F48 RID: 12104
		[Token(Token = "0x4002F48")]
		[FieldOffset(Offset = "0x60")]
		public Button SyncButton;

		// Token: 0x04002F49 RID: 12105
		[Token(Token = "0x4002F49")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform EntryContainer;

		// Token: 0x04002F4A RID: 12106
		[Token(Token = "0x4002F4A")]
		[FieldOffset(Offset = "0x70")]
		public GameObject AmbientDisplayContainer;

		// Token: 0x04002F4B RID: 12107
		[Token(Token = "0x4002F4B")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshPro AmbientDisplaySongLabel;

		// Token: 0x04002F4C RID: 12108
		[Token(Token = "0x4002F4C")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshPro AmbientDisplayTimeLabel;

		// Token: 0x04002F4D RID: 12109
		[Token(Token = "0x4002F4D")]
		[FieldOffset(Offset = "0x88")]
		[Header("Settings")]
		public Sprite PlaySprite;

		// Token: 0x04002F4E RID: 12110
		[Token(Token = "0x4002F4E")]
		[FieldOffset(Offset = "0x90")]
		public Sprite PauseSprite;

		// Token: 0x04002F4F RID: 12111
		[Token(Token = "0x4002F4F")]
		[FieldOffset(Offset = "0x98")]
		public Sprite SongEntryPlaySprite;

		// Token: 0x04002F50 RID: 12112
		[Token(Token = "0x4002F50")]
		[FieldOffset(Offset = "0xA0")]
		public Sprite SongEntryPauseSprite;

		// Token: 0x04002F51 RID: 12113
		[Token(Token = "0x4002F51")]
		[FieldOffset(Offset = "0xA8")]
		public Sprite RepeatModeSprite_None;

		// Token: 0x04002F52 RID: 12114
		[Token(Token = "0x4002F52")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite RepeatModeSprite_Track;

		// Token: 0x04002F53 RID: 12115
		[Token(Token = "0x4002F53")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite RepeatModeSprite_Queue;

		// Token: 0x04002F54 RID: 12116
		[Token(Token = "0x4002F54")]
		[FieldOffset(Offset = "0xC0")]
		public Color DeselectedColor;

		// Token: 0x04002F55 RID: 12117
		[Token(Token = "0x4002F55")]
		[FieldOffset(Offset = "0xD0")]
		public Color SelectedColor;

		// Token: 0x04002F56 RID: 12118
		[Token(Token = "0x4002F56")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject SongEntryPrefab;

		// Token: 0x04002F57 RID: 12119
		[Token(Token = "0x4002F57")]
		[FieldOffset(Offset = "0xE8")]
		private List<RectTransform> songEntries;
	}
}
