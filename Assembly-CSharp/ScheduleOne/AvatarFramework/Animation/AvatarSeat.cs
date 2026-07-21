using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Animation
{
	// Token: 0x0200082A RID: 2090
	[Token(Token = "0x200082A")]
	public class AvatarSeat : MonoBehaviour
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06003830 RID: 14384 RVA: 0x000108F0 File Offset: 0x0000EAF0
		[Token(Token = "0x170008E7")]
		public bool IsOccupied
		{
			[Token(Token = "0x6003830")]
			[Address(RVA = "0x7EB7F0", Offset = "0x7EA9F0", VA = "0x1807EB7F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008E8")]
		public NPC Occupant
		{
			[Token(Token = "0x6003831")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003832")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003833 RID: 14387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003833")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003834")]
		[Address(RVA = "0x7EB6E0", Offset = "0x7EA8E0", VA = "0x1807EB6E0")]
		public void SetOccupant(NPC npc)
		{
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public AvatarSeat()
		{
		}

		// Token: 0x04002930 RID: 10544
		[Token(Token = "0x4002930")]
		[FieldOffset(Offset = "0x28")]
		public Transform SittingPoint;

		// Token: 0x04002931 RID: 10545
		[Token(Token = "0x4002931")]
		[FieldOffset(Offset = "0x30")]
		public Transform AccessPoint;
	}
}
