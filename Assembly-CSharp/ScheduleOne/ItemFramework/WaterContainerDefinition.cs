using System;
using Il2CppDummyDll;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	// Token: 0x02000640 RID: 1600
	[Token(Token = "0x2000640")]
	[CreateAssetMenu(fileName = "WaterContainerDefinition", menuName = "ScriptableObjects/Item Definitions/WaterContainerDefinition", order = 1)]
	[Serializable]
	public class WaterContainerDefinition : StorableItemDefinition
	{
		// Token: 0x06002763 RID: 10083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002763")]
		[Address(RVA = "0x6B9960", Offset = "0x6B8B60", VA = "0x1806B9960", Slot = "4")]
		public override void ValidateDefinition()
		{
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002764")]
		[Address(RVA = "0x6D1A10", Offset = "0x6D0C10", VA = "0x1806D1A10", Slot = "5")]
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x6D1A80", Offset = "0x6D0C80", VA = "0x1806D1A80")]
		public WaterContainerDefinition()
		{
		}

		// Token: 0x04001EA6 RID: 7846
		[Token(Token = "0x4001EA6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public float Capacity;

		// Token: 0x04001EA7 RID: 7847
		[Token(Token = "0x4001EA7")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public FillableWaterContainer FillablePrefab;
	}
}
