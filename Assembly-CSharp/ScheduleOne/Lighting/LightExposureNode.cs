using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A1 RID: 1441
	[Token(Token = "0x20005A1")]
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x060020F1 RID: 8433 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x6784D0", Offset = "0x6776D0", VA = "0x1806784D0")]
		public float GetTotalExposure(out float growSpeedMultiplier)
		{
			return 0f;
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x678410", Offset = "0x677610", VA = "0x180678410")]
		public void AddSource(UsableLightSource source, float lightAmount)
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x6787A0", Offset = "0x6779A0", VA = "0x1806787A0")]
		public void RemoveSource(UsableLightSource source)
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x678700", Offset = "0x677900", VA = "0x180678700")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x678800", Offset = "0x677A00", VA = "0x180678800")]
		public LightExposureNode()
		{
		}

		// Token: 0x04001ACB RID: 6859
		[Token(Token = "0x4001ACB")]
		[FieldOffset(Offset = "0x20")]
		public float ambientExposure;

		// Token: 0x04001ACC RID: 6860
		[Token(Token = "0x4001ACC")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<UsableLightSource, float> sources;
	}
}
