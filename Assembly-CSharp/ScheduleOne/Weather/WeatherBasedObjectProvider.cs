using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BB3 RID: 2995
	[Token(Token = "0x2000BB3")]
	[CreateAssetMenu(fileName = "WeatherBasedObjectProvider", menuName = "ScriptableObjects/Weather/Weather Based Object Provider")]
	public class WeatherBasedObjectProvider : ScriptableObject
	{
		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x0600591B RID: 22811 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CE6")]
		public global::UnityEngine.Object Object
		{
			[Token(Token = "0x600591B")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600591C RID: 22812 RVA: 0x000168C0 File Offset: 0x00014AC0
		[Token(Token = "0x600591C")]
		[Address(RVA = "0x9BAF40", Offset = "0x9BA140", VA = "0x1809BAF40")]
		public bool DoesSatisfyConditions(WeatherConditions activeConditions)
		{
			return default(bool);
		}

		// Token: 0x0600591D RID: 22813 RVA: 0x000168D8 File Offset: 0x00014AD8
		[Token(Token = "0x600591D")]
		[Address(RVA = "0x9BB300", Offset = "0x9BA500", VA = "0x1809BB300")]
		public float GetAverageBlend(WeatherConditions activeConditions)
		{
			return 0f;
		}

		// Token: 0x0600591E RID: 22814 RVA: 0x000168F0 File Offset: 0x00014AF0
		[Token(Token = "0x600591E")]
		[Address(RVA = "0x9BB5F0", Offset = "0x9BA7F0", VA = "0x1809BB5F0")]
		private float GetConditionBlendValue(float activeValue, float condition)
		{
			return 0f;
		}

		// Token: 0x0600591F RID: 22815 RVA: 0x00016908 File Offset: 0x00014B08
		[Token(Token = "0x600591F")]
		[Address(RVA = "0x9BB2D0", Offset = "0x9BA4D0", VA = "0x1809BB2D0")]
		private bool EvaluateConditions(float conditionValue, float conditionThreshold)
		{
			return default(bool);
		}

		// Token: 0x06005920 RID: 22816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005920")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public WeatherBasedObjectProvider()
		{
		}

		// Token: 0x04003B5B RID: 15195
		[Token(Token = "0x4003B5B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WeatherBasedObjectProvider.ConditionFlags _selectedConditions;

		// Token: 0x04003B5C RID: 15196
		[Token(Token = "0x4003B5C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WeatherConditions _conditions;

		// Token: 0x04003B5D RID: 15197
		[Token(Token = "0x4003B5D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WeatherBasedObjectProvider.EvaluationType _evaluationType;

		// Token: 0x04003B5E RID: 15198
		[Token(Token = "0x4003B5E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private global::UnityEngine.Object _object;

		// Token: 0x02000BB4 RID: 2996
		[Token(Token = "0x2000BB4")]
		[Serializable]
		public enum EvaluationType
		{
			// Token: 0x04003B60 RID: 15200
			[Token(Token = "0x4003B60")]
			LessThan,
			// Token: 0x04003B61 RID: 15201
			[Token(Token = "0x4003B61")]
			Equals,
			// Token: 0x04003B62 RID: 15202
			[Token(Token = "0x4003B62")]
			GreaterThan,
			// Token: 0x04003B63 RID: 15203
			[Token(Token = "0x4003B63")]
			Blend
		}

		// Token: 0x02000BB5 RID: 2997
		[Token(Token = "0x2000BB5")]
		[Flags]
		public enum ConditionFlags
		{
			// Token: 0x04003B65 RID: 15205
			[Token(Token = "0x4003B65")]
			None = 0,
			// Token: 0x04003B66 RID: 15206
			[Token(Token = "0x4003B66")]
			Sunny = 1,
			// Token: 0x04003B67 RID: 15207
			[Token(Token = "0x4003B67")]
			Cloudy = 2,
			// Token: 0x04003B68 RID: 15208
			[Token(Token = "0x4003B68")]
			Rainy = 4,
			// Token: 0x04003B69 RID: 15209
			[Token(Token = "0x4003B69")]
			Stormy = 8,
			// Token: 0x04003B6A RID: 15210
			[Token(Token = "0x4003B6A")]
			Snowy = 16,
			// Token: 0x04003B6B RID: 15211
			[Token(Token = "0x4003B6B")]
			Foggy = 32,
			// Token: 0x04003B6C RID: 15212
			[Token(Token = "0x4003B6C")]
			Windy = 64,
			// Token: 0x04003B6D RID: 15213
			[Token(Token = "0x4003B6D")]
			Hail = 128,
			// Token: 0x04003B6E RID: 15214
			[Token(Token = "0x4003B6E")]
			Sleet = 256
		}
	}
}
