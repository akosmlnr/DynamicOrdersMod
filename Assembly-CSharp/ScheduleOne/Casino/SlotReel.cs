using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x0600326D RID: 12909 RVA: 0x0000F750 File Offset: 0x0000D950
		// (set) Token: 0x0600326E RID: 12910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000825")]
		public bool IsSpinning
		{
			[Token(Token = "0x600326D")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600326E")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x0600326F RID: 12911 RVA: 0x0000F768 File Offset: 0x0000D968
		// (set) Token: 0x06003270 RID: 12912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000826")]
		public SlotMachine.ESymbol CurrentSymbol
		{
			[Token(Token = "0x600326F")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			[CompilerGenerated]
			get
			{
				return SlotMachine.ESymbol.Cherry;
			}
			[Token(Token = "0x6003270")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06003271 RID: 12913 RVA: 0x0000F780 File Offset: 0x0000D980
		// (set) Token: 0x06003272 RID: 12914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000827")]
		public float CurrentRotation
		{
			[Token(Token = "0x6003271")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003272")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003273 RID: 12915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003273")]
		[Address(RVA = "0x7816C0", Offset = "0x7808C0", VA = "0x1807816C0")]
		private void Awake()
		{
		}

		// Token: 0x06003274 RID: 12916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003274")]
		[Address(RVA = "0x781930", Offset = "0x780B30", VA = "0x180781930")]
		private void Update()
		{
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003275")]
		[Address(RVA = "0x7818C0", Offset = "0x780AC0", VA = "0x1807818C0")]
		public void Spin()
		{
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003276")]
		[Address(RVA = "0x7818E0", Offset = "0x780AE0", VA = "0x1807818E0")]
		public void Stop(SlotMachine.ESymbol endSymbol)
		{
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003277")]
		[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
		public void SetSymbol(SlotMachine.ESymbol symbol)
		{
		}

		// Token: 0x06003278 RID: 12920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003278")]
		[Address(RVA = "0x781820", Offset = "0x780A20", VA = "0x180781820")]
		private void SetReelRotation(float rotation)
		{
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0000F798 File Offset: 0x0000D998
		[Token(Token = "0x6003279")]
		[Address(RVA = "0x781710", Offset = "0x780910", VA = "0x180781710")]
		private float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			return 0f;
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600327A")]
		[Address(RVA = "0x781A90", Offset = "0x780C90", VA = "0x180781A90")]
		public SlotReel()
		{
		}

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x4002511")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public SlotReel.SymbolRotation[] SymbolRotations;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[FieldOffset(Offset = "0x38")]
		public float SpinSpeed;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public AudioSourceController StopSound;

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onStart;

		// Token: 0x04002515 RID: 9493
		[Token(Token = "0x4002515")]
		[FieldOffset(Offset = "0x50")]
		public UnityEvent onStop;

		// Token: 0x02000779 RID: 1913
		[Token(Token = "0x2000779")]
		[Serializable]
		public class SymbolRotation
		{
			// Token: 0x0600327B RID: 12923 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600327B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SymbolRotation()
			{
			}

			// Token: 0x04002516 RID: 9494
			[Token(Token = "0x4002516")]
			[FieldOffset(Offset = "0x10")]
			public SlotMachine.ESymbol Symbol;

			// Token: 0x04002517 RID: 9495
			[Token(Token = "0x4002517")]
			[FieldOffset(Offset = "0x14")]
			public float Rotation;
		}
	}
}
