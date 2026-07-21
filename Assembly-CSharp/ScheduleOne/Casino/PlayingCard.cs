using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	public class PlayingCard : MonoBehaviour
	{
		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x0000F450 File Offset: 0x0000D650
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000810")]
		public bool IsFaceUp
		{
			[Token(Token = "0x60031C4")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031C5")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x0000F468 File Offset: 0x0000D668
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000811")]
		public PlayingCard.ECardSuit Suit
		{
			[Token(Token = "0x60031C6")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			[CompilerGenerated]
			get
			{
				return PlayingCard.ECardSuit.Spades;
			}
			[Token(Token = "0x60031C7")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x0000F480 File Offset: 0x0000D680
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000812")]
		public PlayingCard.ECardValue Value
		{
			[Token(Token = "0x60031C8")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			[CompilerGenerated]
			get
			{
				return PlayingCard.ECardValue.Blank;
			}
			[Token(Token = "0x60031C9")]
			[Address(RVA = "0x4929B0", Offset = "0x491BB0", VA = "0x1804929B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000813")]
		public CardController CardController
		{
			[Token(Token = "0x60031CA")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031CB")]
			[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x771260", Offset = "0x770460", VA = "0x180771260")]
		private void OnValidate()
		{
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x452460", Offset = "0x451660", VA = "0x180452460")]
		public void SetCardController(CardController cardController)
		{
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x7712E0", Offset = "0x7704E0", VA = "0x1807712E0")]
		public void SetCard(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value, bool network = true)
		{
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x770E10", Offset = "0x770010", VA = "0x180770E10")]
		public void ClearCard()
		{
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D0")]
		[Address(RVA = "0x7713C0", Offset = "0x7705C0", VA = "0x1807713C0")]
		public void SetFaceUp(bool faceUp, bool network = true)
		{
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D1")]
		[Address(RVA = "0x770F10", Offset = "0x770110", VA = "0x180770F10")]
		public void GlideTo(Vector3 position, Quaternion rotation, float duration = 0.5f, bool network = true)
		{
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x770E30", Offset = "0x770030", VA = "0x180770E30")]
		private PlayingCard.CardSprite GetCardSprite(PlayingCard.ECardSuit suit, PlayingCard.ECardValue val)
		{
			return null;
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D3")]
		[Address(RVA = "0x7714B0", Offset = "0x7706B0", VA = "0x1807714B0")]
		[Button]
		public void VerifyCardSprites()
		{
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031D4")]
		[Address(RVA = "0x7719B0", Offset = "0x770BB0", VA = "0x1807719B0")]
		public PlayingCard()
		{
		}

		// Token: 0x04002484 RID: 9348
		[Token(Token = "0x4002484")]
		[FieldOffset(Offset = "0x38")]
		public string CardID;

		// Token: 0x04002485 RID: 9349
		[Token(Token = "0x4002485")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public SpriteRenderer CardSpriteRenderer;

		// Token: 0x04002486 RID: 9350
		[Token(Token = "0x4002486")]
		[FieldOffset(Offset = "0x48")]
		public PlayingCard.CardSprite[] CardSprites;

		// Token: 0x04002487 RID: 9351
		[Token(Token = "0x4002487")]
		[FieldOffset(Offset = "0x50")]
		public Animation FlipAnimation;

		// Token: 0x04002488 RID: 9352
		[Token(Token = "0x4002488")]
		[FieldOffset(Offset = "0x58")]
		public AnimationClip FlipFaceUpClip;

		// Token: 0x04002489 RID: 9353
		[Token(Token = "0x4002489")]
		[FieldOffset(Offset = "0x60")]
		public AnimationClip FlipFaceDownClip;

		// Token: 0x0400248A RID: 9354
		[Token(Token = "0x400248A")]
		[FieldOffset(Offset = "0x68")]
		[Header("Sound")]
		public AudioSourceController FlipSound;

		// Token: 0x0400248B RID: 9355
		[Token(Token = "0x400248B")]
		[FieldOffset(Offset = "0x70")]
		public AudioSourceController LandSound;

		// Token: 0x0400248C RID: 9356
		[Token(Token = "0x400248C")]
		[FieldOffset(Offset = "0x78")]
		private Coroutine moveRoutine;

		// Token: 0x0400248D RID: 9357
		[Token(Token = "0x400248D")]
		[FieldOffset(Offset = "0x80")]
		private Tuple<Vector3, Quaternion> lastGlideTarget;

		// Token: 0x02000766 RID: 1894
		[Token(Token = "0x2000766")]
		[Serializable]
		public class CardSprite
		{
			// Token: 0x060031D5 RID: 12757 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D5")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public CardSprite()
			{
			}

			// Token: 0x0400248E RID: 9358
			[Token(Token = "0x400248E")]
			[FieldOffset(Offset = "0x10")]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x0400248F RID: 9359
			[Token(Token = "0x400248F")]
			[FieldOffset(Offset = "0x14")]
			public PlayingCard.ECardValue Value;

			// Token: 0x04002490 RID: 9360
			[Token(Token = "0x4002490")]
			[FieldOffset(Offset = "0x18")]
			public Sprite Sprite;
		}

		// Token: 0x02000767 RID: 1895
		[Token(Token = "0x2000767")]
		public struct CardData
		{
			// Token: 0x060031D6 RID: 12758 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60031D6")]
			[Address(RVA = "0x53E580", Offset = "0x53D780", VA = "0x18053E580")]
			public CardData(PlayingCard.ECardSuit suit, PlayingCard.ECardValue value)
			{
			}

			// Token: 0x04002491 RID: 9361
			[Token(Token = "0x4002491")]
			[FieldOffset(Offset = "0x0")]
			public PlayingCard.ECardSuit Suit;

			// Token: 0x04002492 RID: 9362
			[Token(Token = "0x4002492")]
			[FieldOffset(Offset = "0x4")]
			public PlayingCard.ECardValue Value;
		}

		// Token: 0x02000768 RID: 1896
		[Token(Token = "0x2000768")]
		public enum ECardSuit
		{
			// Token: 0x04002494 RID: 9364
			[Token(Token = "0x4002494")]
			Spades,
			// Token: 0x04002495 RID: 9365
			[Token(Token = "0x4002495")]
			Hearts,
			// Token: 0x04002496 RID: 9366
			[Token(Token = "0x4002496")]
			Diamonds,
			// Token: 0x04002497 RID: 9367
			[Token(Token = "0x4002497")]
			Clubs
		}

		// Token: 0x02000769 RID: 1897
		[Token(Token = "0x2000769")]
		public enum ECardValue
		{
			// Token: 0x04002499 RID: 9369
			[Token(Token = "0x4002499")]
			Blank,
			// Token: 0x0400249A RID: 9370
			[Token(Token = "0x400249A")]
			Ace,
			// Token: 0x0400249B RID: 9371
			[Token(Token = "0x400249B")]
			Two,
			// Token: 0x0400249C RID: 9372
			[Token(Token = "0x400249C")]
			Three,
			// Token: 0x0400249D RID: 9373
			[Token(Token = "0x400249D")]
			Four,
			// Token: 0x0400249E RID: 9374
			[Token(Token = "0x400249E")]
			Five,
			// Token: 0x0400249F RID: 9375
			[Token(Token = "0x400249F")]
			Six,
			// Token: 0x040024A0 RID: 9376
			[Token(Token = "0x40024A0")]
			Seven,
			// Token: 0x040024A1 RID: 9377
			[Token(Token = "0x40024A1")]
			Eight,
			// Token: 0x040024A2 RID: 9378
			[Token(Token = "0x40024A2")]
			Nine,
			// Token: 0x040024A3 RID: 9379
			[Token(Token = "0x40024A3")]
			Ten,
			// Token: 0x040024A4 RID: 9380
			[Token(Token = "0x40024A4")]
			Jack,
			// Token: 0x040024A5 RID: 9381
			[Token(Token = "0x40024A5")]
			Queen,
			// Token: 0x040024A6 RID: 9382
			[Token(Token = "0x40024A6")]
			King
		}
	}
}
