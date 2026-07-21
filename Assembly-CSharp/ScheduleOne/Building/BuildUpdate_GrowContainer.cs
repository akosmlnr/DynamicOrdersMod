using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Growing;
using ScheduleOne.ItemFramework;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007BD RID: 1981
	[Token(Token = "0x20007BD")]
	public class BuildUpdate_GrowContainer : BuildUpdate_Grid
	{
		// Token: 0x060034F2 RID: 13554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x7CB000", Offset = "0x7CA200", VA = "0x1807CB000", Slot = "5")]
		public override void Initialize(GridItem buildableItemClass, ItemInstance itemInstance, GameObject ghostModel)
		{
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x7CAE40", Offset = "0x7CA040", VA = "0x1807CAE40")]
		private float GetTemperature()
		{
			return 0f;
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x7CAE30", Offset = "0x7CA030", VA = "0x1807CAE30")]
		private bool GetTemperatureVisibility()
		{
			return default(bool);
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x7CB250", Offset = "0x7CA450", VA = "0x1807CB250", Slot = "13")]
		protected override void SetShowTemperatures(bool show, Property property)
		{
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x7CB330", Offset = "0x7CA530", VA = "0x1807CB330")]
		public BuildUpdate_GrowContainer()
		{
		}

		// Token: 0x04002682 RID: 9858
		[Token(Token = "0x4002682")]
		[FieldOffset(Offset = "0x68")]
		private GrowContainer _gc;

		// Token: 0x04002683 RID: 9859
		[Token(Token = "0x4002683")]
		[FieldOffset(Offset = "0x0")]
		private static bool _showTemps;
	}
}
