using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Temperature
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	public class TemperatureEmitter : MonoBehaviour
	{
		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00008940 File Offset: 0x00006B40
		// (set) Token: 0x060012C9 RID: 4809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D9")]
		public float Temperature
		{
			[Token(Token = "0x60012C8")]
			[Address(RVA = "0x495AF0", Offset = "0x494CF0", VA = "0x180495AF0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60012C9")]
			[Address(RVA = "0x49B2C0", Offset = "0x49A4C0", VA = "0x18049B2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x00008958 File Offset: 0x00006B58
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DA")]
		public float Range
		{
			[Token(Token = "0x60012CA")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60012CB")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x170003DB")]
		public Vector3 EmissionPoint
		{
			[Token(Token = "0x60012CC")]
			[Address(RVA = "0x92AA30", Offset = "0x929C30", VA = "0x18092AA30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0xB29AD0", Offset = "0xB28CD0", VA = "0x180B29AD0")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0xB29B80", Offset = "0xB28D80", VA = "0x180B29B80")]
		public void SetTemperature(float temperature)
		{
		}

		// Token: 0x060012CF RID: 4815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0xB29B40", Offset = "0xB28D40", VA = "0x180B29B40")]
		public void SetRange(float range)
		{
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0xB29AB0", Offset = "0xB28CB0", VA = "0x180B29AB0")]
		public void NotifyChanged()
		{
		}

		// Token: 0x060012D1 RID: 4817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D1")]
		[Address(RVA = "0xB29BC0", Offset = "0xB28DC0", VA = "0x180B29BC0")]
		public TemperatureEmitter()
		{
		}

		// Token: 0x0400111A RID: 4378
		[Token(Token = "0x400111A")]
		public const int DefaultAmbientTemperature = 20;

		// Token: 0x0400111B RID: 4379
		[Token(Token = "0x400111B")]
		public const int MinTemperature = 0;

		// Token: 0x0400111C RID: 4380
		[Token(Token = "0x400111C")]
		public const int MaxTemperature = 40;

		// Token: 0x0400111F RID: 4383
		[Token(Token = "0x400111F")]
		[FieldOffset(Offset = "0x28")]
		public Action OnEmitterChanged;
	}
}
