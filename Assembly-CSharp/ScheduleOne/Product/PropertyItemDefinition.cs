using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2000929")]
	[CreateAssetMenu(fileName = "PropertyItemDefinition", menuName = "ScriptableObjects/PropertyItemDefinition", order = 1)]
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x06003F2D RID: 16173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2D")]
		[Address(RVA = "0x864220", Offset = "0x863420", VA = "0x180864220", Slot = "7")]
		public virtual void Initialize(List<Effect> properties)
		{
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x00012060 File Offset: 0x00010260
		[Token(Token = "0x6003F2E")]
		[Address(RVA = "0x8641C0", Offset = "0x8633C0", VA = "0x1808641C0")]
		public bool HasProperty(Effect property)
		{
			return default(bool);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F2F")]
		[Address(RVA = "0x864280", Offset = "0x863480", VA = "0x180864280")]
		public PropertyItemDefinition()
		{
		}

		// Token: 0x04002DF5 RID: 11765
		[Token(Token = "0x4002DF5")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Properties")]
		public List<Effect> Properties;
	}
}
