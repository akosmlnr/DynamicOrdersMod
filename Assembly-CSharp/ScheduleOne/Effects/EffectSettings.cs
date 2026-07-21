using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B53 RID: 2899
	[Token(Token = "0x2000B53")]
	[CreateAssetMenu(fileName = "EffectSettings", menuName = "ScriptableObjects/Effects/Effect Settings")]
	public class EffectSettings : ScriptableObject
	{
		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060056FB RID: 22267 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CB9")]
		public string Id
		{
			[Token(Token = "0x60056FB")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CBA")]
		public List<EffectItem> EffectItems
		{
			[Token(Token = "0x60056FC")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056FD")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public EffectSettings()
		{
		}

		// Token: 0x04003A16 RID: 14870
		[Token(Token = "0x4003A16")]
		[FieldOffset(Offset = "0x18")]
		[Header("Numeric Parameters")]
		[SerializeField]
		private string _handlerId;

		// Token: 0x04003A17 RID: 14871
		[Token(Token = "0x4003A17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<EffectItem> _effectItems;
	}
}
