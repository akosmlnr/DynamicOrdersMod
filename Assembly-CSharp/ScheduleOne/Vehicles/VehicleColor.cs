using System;
using Il2CppDummyDll;
using ScheduleOne.Vehicles.Modification;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	// Token: 0x020002A1 RID: 673
	[Token(Token = "0x20002A1")]
	public class VehicleColor : MonoBehaviour
	{
		// Token: 0x06000FDD RID: 4061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0xB12C30", Offset = "0xB11E30", VA = "0x180B12C30")]
		private void Start()
		{
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0xB12920", Offset = "0xB11B20", VA = "0x180B12920", Slot = "4")]
		public virtual void ApplyColor(EVehicleColor col)
		{
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0xB12C70", Offset = "0xB11E70", VA = "0x180B12C70")]
		public VehicleColor()
		{
		}

		// Token: 0x04000E2E RID: 3630
		[Token(Token = "0x4000E2E")]
		[FieldOffset(Offset = "0x20")]
		public VehicleColor.BodyMesh[] BodyMeshes;

		// Token: 0x04000E2F RID: 3631
		[Token(Token = "0x4000E2F")]
		[FieldOffset(Offset = "0x28")]
		public EVehicleColor DefaultColor;

		// Token: 0x04000E30 RID: 3632
		[Token(Token = "0x4000E30")]
		[FieldOffset(Offset = "0x2C")]
		private EVehicleColor displayedColor;

		// Token: 0x04000E31 RID: 3633
		[Token(Token = "0x4000E31")]
		[FieldOffset(Offset = "0x30")]
		private bool initialColorApplied;

		// Token: 0x020002A2 RID: 674
		[Token(Token = "0x20002A2")]
		[Serializable]
		public class BodyMesh
		{
			// Token: 0x06000FE1 RID: 4065 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public BodyMesh()
			{
			}

			// Token: 0x04000E32 RID: 3634
			[Token(Token = "0x4000E32")]
			[FieldOffset(Offset = "0x10")]
			public MeshRenderer Renderer;

			// Token: 0x04000E33 RID: 3635
			[Token(Token = "0x4000E33")]
			[FieldOffset(Offset = "0x18")]
			public int MaterialIndex;
		}
	}
}
