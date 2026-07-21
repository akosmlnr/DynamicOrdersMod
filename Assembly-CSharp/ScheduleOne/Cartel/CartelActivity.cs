using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Map;
using UnityEngine;

namespace ScheduleOne.Cartel
{
	// Token: 0x0200078B RID: 1931
	[Token(Token = "0x200078B")]
	public class CartelActivity : MonoBehaviour
	{
		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		// (set) Token: 0x06003360 RID: 13152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083B")]
		public bool IsActive
		{
			[Token(Token = "0x600335F")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003360")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06003361 RID: 13153 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		// (set) Token: 0x06003362 RID: 13154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083C")]
		public int MinsSinceActivation
		{
			[Token(Token = "0x6003361")]
			[Address(RVA = "0x49B290", Offset = "0x49A490", VA = "0x18049B290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003362")]
			[Address(RVA = "0x49B2B0", Offset = "0x49A4B0", VA = "0x18049B2B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083D")]
		public EMapRegion Region
		{
			[Token(Token = "0x6003363")]
			[Address(RVA = "0x492960", Offset = "0x491B60", VA = "0x180492960")]
			[CompilerGenerated]
			get
			{
				return EMapRegion.Northtown;
			}
			[Token(Token = "0x6003364")]
			[Address(RVA = "0x4929B0", Offset = "0x491BB0", VA = "0x1804929B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003365 RID: 13157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003365")]
		[Address(RVA = "0x790220", Offset = "0x78F420", VA = "0x180790220")]
		private void Start()
		{
		}

		// Token: 0x06003366 RID: 13158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003366")]
		[Address(RVA = "0x78FF20", Offset = "0x78F120", VA = "0x18078FF20", Slot = "4")]
		public virtual void Activate(EMapRegion region)
		{
		}

		// Token: 0x06003367 RID: 13159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003367")]
		[Address(RVA = "0x790210", Offset = "0x78F410", VA = "0x180790210", Slot = "5")]
		protected virtual void MinPassed()
		{
		}

		// Token: 0x06003368 RID: 13160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003368")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "6")]
		protected virtual void HourPassed()
		{
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003369")]
		[Address(RVA = "0x790030", Offset = "0x78F230", VA = "0x180790030", Slot = "7")]
		protected virtual void Deactivate()
		{
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x0000FA08 File Offset: 0x0000DC08
		[Token(Token = "0x600336A")]
		[Address(RVA = "0x790130", Offset = "0x78F330", VA = "0x180790130", Slot = "8")]
		public virtual bool IsRegionValidForActivity(EMapRegion region)
		{
			return default(bool);
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600336B")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public CartelActivity()
		{
		}

		// Token: 0x040025BE RID: 9662
		[Token(Token = "0x40025BE")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Settings")]
		[Range(0f, 1f)]
		public float InfluenceRequirement;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		[FieldOffset(Offset = "0x30")]
		public Action onActivated;

		// Token: 0x040025C0 RID: 9664
		[Token(Token = "0x40025C0")]
		[FieldOffset(Offset = "0x38")]
		public Action onDeactivated;
	}
}
