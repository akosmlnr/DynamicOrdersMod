using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000653 RID: 1619
	[Token(Token = "0x2000653")]
	[RequireComponent(typeof(SpraySurface))]
	public class SpraySurfaceInteraction : MonoBehaviour
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FF")]
		public bool IsOpen
		{
			[Token(Token = "0x600283C")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600283D")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x17000700")]
		private bool confirmationPanelOpen
		{
			[Token(Token = "0x600283E")]
			[Address(RVA = "0x6E2370", Offset = "0x6E1570", VA = "0x1806E2370")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x17000701")]
		private int _paintedPixelLimit
		{
			[Token(Token = "0x600283F")]
			[Address(RVA = "0x6E2350", Offset = "0x6E1550", VA = "0x1806E2350")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x6DDC90", Offset = "0x6DCE90", VA = "0x1806DDC90")]
		private void Awake()
		{
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x6E1B10", Offset = "0x6E0D10", VA = "0x1806E1B10")]
		private void Start()
		{
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x6E1130", Offset = "0x6E0330", VA = "0x1806E1130")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x6E0500", Offset = "0x6DF700", VA = "0x1806E0500")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x6E13A0", Offset = "0x6E05A0", VA = "0x1806E13A0")]
		private void ResizeCanvas()
		{
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x6E2070", Offset = "0x6E1270", VA = "0x1806E2070")]
		private void Update()
		{
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x6E1E30", Offset = "0x6E1030", VA = "0x1806E1E30")]
		private void UpdateCursor()
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x6E2000", Offset = "0x6E1200", VA = "0x1806E2000")]
		private void UpdateSpraySound()
		{
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x6DDE20", Offset = "0x6DD020", VA = "0x1806DDE20")]
		private void CheckCameraInBounds()
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x6DF1C0", Offset = "0x6DE3C0", VA = "0x1806DF1C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x6E1950", Offset = "0x6E0B50", VA = "0x1806E1950")]
		private void StartStroke(bool recordHistory = true)
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284B")]
		[Address(RVA = "0x6DEB50", Offset = "0x6DDD50", VA = "0x1806DEB50")]
		private void EndStroke(bool stopSpraySound)
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x6DF8A0", Offset = "0x6DEAA0", VA = "0x1806DF8A0")]
		private bool GetCursorPositionOnSurface(out ushort pixelX, out ushort pixelY)
		{
			return default(bool);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x6DFE60", Offset = "0x6DF060", VA = "0x1806DFE60")]
		private Ray GetCursorRay()
		{
			return default(Ray);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x6DFF30", Offset = "0x6DF130", VA = "0x1806DFF30")]
		private void Hovered()
		{
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x6E00B0", Offset = "0x6DF2B0", VA = "0x1806E00B0")]
		private void Interacted()
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x6E2190", Offset = "0x6E1390", VA = "0x1806E2190")]
		private void UseGraffitiCleaner()
		{
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x6DF0F0", Offset = "0x6DE2F0", VA = "0x1806DF0F0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x6E0680", Offset = "0x6DF880", VA = "0x1806E0680")]
		private void Open()
		{
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002853")]
		[Address(RVA = "0x6DE190", Offset = "0x6DD390", VA = "0x1806DE190")]
		private void Close()
		{
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002854")]
		[Address(RVA = "0x6DF010", Offset = "0x6DE210", VA = "0x1806DF010")]
		private void EquippedSlotChanged(int equippedSlotIndex)
		{
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002855")]
		[Address(RVA = "0x6E18A0", Offset = "0x6E0AA0", VA = "0x1806E18A0")]
		private void SetColor(ESprayColor color)
		{
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002856")]
		[Address(RVA = "0x6E18B0", Offset = "0x6E0AB0", VA = "0x1806E18B0")]
		private void SetStrokeSize(byte strokeSize)
		{
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002857")]
		[Address(RVA = "0x6E1F10", Offset = "0x6E1110", VA = "0x1806E1F10")]
		private void UpdateRemainingPaintIndicator()
		{
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002858")]
		[Address(RVA = "0x6E1CC0", Offset = "0x6E0EC0", VA = "0x1806E1CC0")]
		public void Undo()
		{
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002859")]
		[Address(RVA = "0x6DE0F0", Offset = "0x6DD2F0", VA = "0x1806DE0F0")]
		private void Clear()
		{
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x600285A")]
		[Address(RVA = "0x6E03F0", Offset = "0x6DF5F0", VA = "0x1806E03F0")]
		private static bool IsSprayCanEquipped()
		{
			return default(bool);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x600285B")]
		[Address(RVA = "0x6E02E0", Offset = "0x6DF4E0", VA = "0x1806E02E0")]
		private static bool IsGraffitiCleanerEquipped()
		{
			return default(bool);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600285C")]
		[Address(RVA = "0x6E22C0", Offset = "0x6E14C0", VA = "0x1806E22C0")]
		public SpraySurfaceInteraction()
		{
		}

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		private const float CameraLerpTime = 0.15f;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		private const int MaxPixelsBeforeNewStroke = 1000;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		private const int ManhattanDistanceBetweenPaintedPixels = 3;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		private const int FixedPaintedPixelLimit = 25000;

		// Token: 0x04001F0D RID: 7949
		[Token(Token = "0x4001F0D")]
		private const int CanvasPadding = 12;

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x28")]
		public SpraySurface SpraySurface;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[FieldOffset(Offset = "0x30")]
		public InteractableObject IntObj;

		// Token: 0x04001F11 RID: 7953
		[Token(Token = "0x4001F11")]
		[FieldOffset(Offset = "0x38")]
		public Transform CameraPosition;

		// Token: 0x04001F12 RID: 7954
		[Token(Token = "0x4001F12")]
		[FieldOffset(Offset = "0x40")]
		public Canvas Canvas;

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[FieldOffset(Offset = "0x48")]
		public Image SprayImg;

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController SpraySound;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController CleanSound;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[FieldOffset(Offset = "0x60")]
		public bool _allowDraw;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x64")]
		[Header("Settings")]
		[SerializeField]
		public float PaintedPixelLimitMultiplier;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[FieldOffset(Offset = "0x68")]
		private ESprayColor selectedColor;

		// Token: 0x04001F19 RID: 7961
		[Token(Token = "0x4001F19")]
		[FieldOffset(Offset = "0x69")]
		private byte selectedStrokeSize;

		// Token: 0x04001F1A RID: 7962
		[Token(Token = "0x4001F1A")]
		[FieldOffset(Offset = "0x6A")]
		private UShort2 lastPaintedPixelCoord;

		// Token: 0x04001F1B RID: 7963
		[Token(Token = "0x4001F1B")]
		[FieldOffset(Offset = "0x6E")]
		private bool paintedLastFrame;

		// Token: 0x04001F1C RID: 7964
		[Token(Token = "0x4001F1C")]
		[FieldOffset(Offset = "0x70")]
		private List<UShort2> currentStrokePixels;

		// Token: 0x04001F1D RID: 7965
		[Token(Token = "0x4001F1D")]
		[FieldOffset(Offset = "0x78")]
		private bool isPaintingStroke;

		// Token: 0x04001F1E RID: 7966
		[Token(Token = "0x4001F1E")]
		[FieldOffset(Offset = "0x7C")]
		private float timeSinceStrokeStart;

		// Token: 0x04001F1F RID: 7967
		[Token(Token = "0x4001F1F")]
		[FieldOffset(Offset = "0x80")]
		private int _startPaintedPixelCount;
	}
}
