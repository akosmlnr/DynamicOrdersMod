using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x0200054A RID: 1354
	[Token(Token = "0x200054A")]
	public class SewerMushroomLocation : MonoBehaviour
	{
		// Token: 0x06001E31 RID: 7729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E31")]
		[Address(RVA = "0x630760", Offset = "0x62F960", VA = "0x180630760")]
		public void SetMushroomsFromData(GameObject mushroomObject)
		{
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E32")]
		[Address(RVA = "0x630460", Offset = "0x62F660", VA = "0x180630460")]
		private void SetMushroomFromData(Transform childMushroomObj, SewerMushroomLocation.MushroomLocationData data)
		{
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E33")]
		[Address(RVA = "0x630410", Offset = "0x62F610", VA = "0x180630410")]
		public void ClearData()
		{
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x630540", Offset = "0x62F740", VA = "0x180630540")]
		[Button]
		public void SetMushroomLocationData()
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x630BA0", Offset = "0x62FDA0", VA = "0x180630BA0")]
		public SewerMushroomLocation()
		{
		}

		// Token: 0x04001957 RID: 6487
		[Token(Token = "0x4001957")]
		[FieldOffset(Offset = "0x20")]
		[Header("Properties")]
		[SerializeField]
		private List<SewerMushroomLocation.MushroomLocationData> _data;

		// Token: 0x0200054B RID: 1355
		[Token(Token = "0x200054B")]
		[Serializable]
		public struct MushroomLocationData
		{
			// Token: 0x04001958 RID: 6488
			[Token(Token = "0x4001958")]
			[FieldOffset(Offset = "0x0")]
			public bool isActive;

			// Token: 0x04001959 RID: 6489
			[Token(Token = "0x4001959")]
			[FieldOffset(Offset = "0x4")]
			public Vector3 location;

			// Token: 0x0400195A RID: 6490
			[Token(Token = "0x400195A")]
			[FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			// Token: 0x0400195B RID: 6491
			[Token(Token = "0x400195B")]
			[FieldOffset(Offset = "0x20")]
			public float scale;
		}
	}
}
