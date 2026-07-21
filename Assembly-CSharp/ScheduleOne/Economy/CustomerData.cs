using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Effects;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Economy
{
	// Token: 0x020006AF RID: 1711
	[Token(Token = "0x20006AF")]
	[CreateAssetMenu(fileName = "CustomerData", menuName = "ScriptableObjects/CustomerData", order = 1)]
	[Serializable]
	public class CustomerData : ScriptableObject
	{
		// Token: 0x06002CBA RID: 11450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x71F410", Offset = "0x71E610", VA = "0x18071F410")]
		private void OnValidate()
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0000E0A0 File Offset: 0x0000C2A0
		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x71F3D0", Offset = "0x71E5D0", VA = "0x18071F3D0")]
		public static float GetQualityScalar(EQuality quality)
		{
			return 0f;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x71F230", Offset = "0x71E430", VA = "0x18071F230")]
		public List<EDay> GetOrderDays(float dependence, float normalizedRelationship)
		{
			return null;
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x71F150", Offset = "0x71E350", VA = "0x18071F150")]
		public float GetAdjustedWeeklySpend(float normalizedRelationship)
		{
			return 0f;
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x71F480", Offset = "0x71E680", VA = "0x18071F480")]
		[Button]
		public void RandomizeAffinities()
		{
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CBF")]
		[Address(RVA = "0x71F7C0", Offset = "0x71E9C0", VA = "0x18071F7C0")]
		[Button]
		public void RandomizeFavouriteEffects()
		{
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC0")]
		[Address(RVA = "0x71FAD0", Offset = "0x71ECD0", VA = "0x18071FAD0")]
		[Button]
		public void RandomizeTiming()
		{
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CC1")]
		[Address(RVA = "0x71FB70", Offset = "0x71ED70", VA = "0x18071FB70")]
		public CustomerData()
		{
		}

		// Token: 0x04002154 RID: 8532
		[Token(Token = "0x4002154")]
		[FieldOffset(Offset = "0x18")]
		public CustomerAffinityData DefaultAffinityData;

		// Token: 0x04002155 RID: 8533
		[Token(Token = "0x4002155")]
		[FieldOffset(Offset = "0x20")]
		[Header("Preferred Properties - Properties the customer prefers in a product.")]
		public List<Effect> PreferredProperties;

		// Token: 0x04002156 RID: 8534
		[Token(Token = "0x4002156")]
		[FieldOffset(Offset = "0x28")]
		[Header("Spending Behaviour")]
		public float MinWeeklySpend;

		// Token: 0x04002157 RID: 8535
		[Token(Token = "0x4002157")]
		[FieldOffset(Offset = "0x2C")]
		public float MaxWeeklySpend;

		// Token: 0x04002158 RID: 8536
		[Token(Token = "0x4002158")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 7f)]
		public int MinOrdersPerWeek;

		// Token: 0x04002159 RID: 8537
		[Token(Token = "0x4002159")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 7f)]
		public int MaxOrdersPerWeek;

		// Token: 0x0400215A RID: 8538
		[Token(Token = "0x400215A")]
		[FieldOffset(Offset = "0x38")]
		[Header("Timing Settings")]
		public int OrderTime;

		// Token: 0x0400215B RID: 8539
		[Token(Token = "0x400215B")]
		[FieldOffset(Offset = "0x3C")]
		public EDay PreferredOrderDay;

		// Token: 0x0400215C RID: 8540
		[Token(Token = "0x400215C")]
		[FieldOffset(Offset = "0x40")]
		[Header("Standards")]
		public ECustomerStandard Standards;

		// Token: 0x0400215D RID: 8541
		[Token(Token = "0x400215D")]
		[FieldOffset(Offset = "0x44")]
		[Header("Direct approaching")]
		public bool CanBeDirectlyApproached;

		// Token: 0x0400215E RID: 8542
		[Token(Token = "0x400215E")]
		[FieldOffset(Offset = "0x45")]
		public bool GuaranteeFirstSampleSuccess;

		// Token: 0x0400215F RID: 8543
		[Token(Token = "0x400215F")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("The average relationship of mutual customers to provide a 50% chance of success")]
		[Range(0f, 5f)]
		public float MinMutualRelationRequirement;

		// Token: 0x04002160 RID: 8544
		[Token(Token = "0x4002160")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("The average relationship of mutual customers to provide a 100% chance of success")]
		[Range(0f, 5f)]
		public float MaxMutualRelationRequirement;

		// Token: 0x04002161 RID: 8545
		[Token(Token = "0x4002161")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("If direct approach fails, whats the chance the police will be called?")]
		[Range(0f, 1f)]
		public float CallPoliceChance;

		// Token: 0x04002162 RID: 8546
		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x54")]
		[Header("Dependence")]
		[Range(0f, 2f)]
		[Tooltip("How quickly the customer builds dependence")]
		public float DependenceMultiplier;

		// Token: 0x04002163 RID: 8547
		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("The customer's starting (and lowest possible) dependence level")]
		public float BaseAddiction;

		// Token: 0x04002164 RID: 8548
		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x60")]
		public Action onChanged;
	}
}
