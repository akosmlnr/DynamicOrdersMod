using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.Map;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x020007A6 RID: 1958
	[Token(Token = "0x20007A6")]
	public class GoonPool : MonoBehaviour
	{
		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[Token(Token = "0x17000854")]
		public int UnspawnedGoonCount
		{
			[Token(Token = "0x6003470")]
			[Address(RVA = "0x79C630", Offset = "0x79B830", VA = "0x18079C630")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003471 RID: 13425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003471")]
		[Address(RVA = "0x79BB60", Offset = "0x79AD60", VA = "0x18079BB60", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003472")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Update()
		{
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003473")]
		[Address(RVA = "0x79C360", Offset = "0x79B560", VA = "0x18079C360")]
		public List<CartelGoon> SpawnMultipleGoons(Vector3 spawnPoint, int requestedAmount, bool setAsGoonMates = true)
		{
			return null;
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003474")]
		[Address(RVA = "0x79BEB0", Offset = "0x79B0B0", VA = "0x18079BEB0")]
		public CartelGoonAppearance GetRandomAppearance()
		{
			return null;
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003475")]
		[Address(RVA = "0x79C210", Offset = "0x79B410", VA = "0x18079C210")]
		public CartelGoon SpawnGoon(Vector3 spawnPoint)
		{
			return null;
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x79C0B0", Offset = "0x79B2B0", VA = "0x18079C0B0")]
		public void ReturnToPool(CartelGoon goon)
		{
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x79BCD0", Offset = "0x79AED0", VA = "0x18079BCD0")]
		public NPCEnterableBuilding GetNearestExitBuilding(Vector3 position)
		{
			return null;
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003478")]
		[Address(RVA = "0x79C580", Offset = "0x79B780", VA = "0x18079C580")]
		public GoonPool()
		{
		}

		// Token: 0x0400263B RID: 9787
		[Token(Token = "0x400263B")]
		public const float MALE_CHANCE = 0.7f;

		// Token: 0x0400263C RID: 9788
		[Token(Token = "0x400263C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		private CartelGoon[] goons;

		// Token: 0x0400263D RID: 9789
		[Token(Token = "0x400263D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NPCEnterableBuilding[] exitBuildings;

		// Token: 0x0400263E RID: 9790
		[Token(Token = "0x400263E")]
		[FieldOffset(Offset = "0x30")]
		[Header("Appearance Settings")]
		public AvatarSettings[] MaleBaseAppearances;

		// Token: 0x0400263F RID: 9791
		[Token(Token = "0x400263F")]
		[FieldOffset(Offset = "0x38")]
		public AvatarSettings[] FemaleBaseAppearances;

		// Token: 0x04002640 RID: 9792
		[Token(Token = "0x4002640")]
		[FieldOffset(Offset = "0x40")]
		public AvatarSettings[] MaleClothing;

		// Token: 0x04002641 RID: 9793
		[Token(Token = "0x4002641")]
		[FieldOffset(Offset = "0x48")]
		public AvatarSettings[] FemaleClothing;

		// Token: 0x04002642 RID: 9794
		[Token(Token = "0x4002642")]
		[FieldOffset(Offset = "0x50")]
		public VODatabase[] MaleVoices;

		// Token: 0x04002643 RID: 9795
		[Token(Token = "0x4002643")]
		[FieldOffset(Offset = "0x58")]
		public VODatabase[] FemaleVoices;

		// Token: 0x04002644 RID: 9796
		[Token(Token = "0x4002644")]
		[FieldOffset(Offset = "0x60")]
		public Color[] SkinTones;

		// Token: 0x04002645 RID: 9797
		[Token(Token = "0x4002645")]
		[FieldOffset(Offset = "0x68")]
		public Color[] HairColors;

		// Token: 0x04002646 RID: 9798
		[Token(Token = "0x4002646")]
		[FieldOffset(Offset = "0x70")]
		private List<CartelGoon> spawnedGoons;

		// Token: 0x04002647 RID: 9799
		[Token(Token = "0x4002647")]
		[FieldOffset(Offset = "0x78")]
		private List<CartelGoon> unspawnedGoons;
	}
}
