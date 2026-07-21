using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BCA RID: 3018
	[Token(Token = "0x2000BCA")]
	public class WorldEnclosure : MonoBehaviour
	{
		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x0600597F RID: 22911 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CFD")]
		public List<BasicEnclosure> Enclosures
		{
			[Token(Token = "0x600597F")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005980")]
		[Address(RVA = "0x9BF6C0", Offset = "0x9BE8C0", VA = "0x1809BF6C0")]
		private void Start()
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00016B48 File Offset: 0x00014D48
		[Token(Token = "0x6005981")]
		[Address(RVA = "0x9BF890", Offset = "0x9BEA90", VA = "0x1809BF890")]
		public bool WithinEnclosure(Vector3 targetPosition, out float blend)
		{
			return default(bool);
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005982")]
		[Address(RVA = "0x9BFB30", Offset = "0x9BED30", VA = "0x1809BFB30")]
		public WorldEnclosure()
		{
		}

		// Token: 0x04003BB8 RID: 15288
		[Token(Token = "0x4003BB8")]
		[FieldOffset(Offset = "0x20")]
		[Header("Components")]
		[SerializeField]
		private List<BasicEnclosure> _enclosures;

		// Token: 0x04003BB9 RID: 15289
		[Token(Token = "0x4003BB9")]
		[FieldOffset(Offset = "0x28")]
		private List<BasicEnclosure> _blendZones;

		// Token: 0x04003BBA RID: 15290
		[Token(Token = "0x4003BBA")]
		[FieldOffset(Offset = "0x30")]
		private List<BasicEnclosure> _Enclosures;
	}
}
