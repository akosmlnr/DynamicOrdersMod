using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Building;
using ScheduleOne.EntityFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000980 RID: 2432
	[Token(Token = "0x2000980")]
	public class FloorRack : GridItem, IProceduralTileContainer
	{
		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600412C RID: 16684 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000A1C")]
		public List<ProceduralTile> ProceduralTiles
		{
			[Token(Token = "0x600412C")]
			[Address(RVA = "0x835000", Offset = "0x834200", VA = "0x180835000", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412D")]
		[Address(RVA = "0x880650", Offset = "0x87F850", VA = "0x180880650", Slot = "72")]
		public virtual void UpdateLegVisibility()
		{
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600412E")]
		[Address(RVA = "0x87FC30", Offset = "0x87EE30", VA = "0x18087FC30")]
		protected void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600412F")]
		[Address(RVA = "0x880270", Offset = "0x87F470", VA = "0x180880270")]
		private FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			return null;
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004130")]
		[Address(RVA = "0x8803A0", Offset = "0x87F5A0", VA = "0x1808803A0")]
		public List<FloorRack> GetSurroundingRacks()
		{
			return null;
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00012720 File Offset: 0x00010920
		[Token(Token = "0x6004131")]
		[Address(RVA = "0x87FB70", Offset = "0x87ED70", VA = "0x18087FB70", Slot = "69")]
		public override bool CanShareTileWith(List<GridItem> obstacles)
		{
			return default(bool);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00012738 File Offset: 0x00010938
		[Token(Token = "0x6004132")]
		[Address(RVA = "0x87F960", Offset = "0x87EB60", VA = "0x18087F960", Slot = "55")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004133")]
		[Address(RVA = "0x85DD20", Offset = "0x85CF20", VA = "0x18085DD20")]
		public FloorRack()
		{
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004134")]
		[Address(RVA = "0x880630", Offset = "0x87F830", VA = "0x180880630", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004135")]
		[Address(RVA = "0x880610", Offset = "0x87F810", VA = "0x180880610", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06004136 RID: 16694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004136")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004137")]
		[Address(RVA = "0x82F570", Offset = "0x82E770", VA = "0x18082F570", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04002F6A RID: 12138
		[Token(Token = "0x4002F6A")]
		[FieldOffset(Offset = "0x210")]
		[Header("References")]
		public Transform leg_BottomLeft;

		// Token: 0x04002F6B RID: 12139
		[Token(Token = "0x4002F6B")]
		[FieldOffset(Offset = "0x218")]
		public Transform leg_BottomRight;

		// Token: 0x04002F6C RID: 12140
		[Token(Token = "0x4002F6C")]
		[FieldOffset(Offset = "0x220")]
		public Transform leg_TopLeft;

		// Token: 0x04002F6D RID: 12141
		[Token(Token = "0x4002F6D")]
		[FieldOffset(Offset = "0x228")]
		public Transform leg_TopRight;

		// Token: 0x04002F6E RID: 12142
		[Token(Token = "0x4002F6E")]
		[FieldOffset(Offset = "0x230")]
		public CornerObstacle obs_BottomLeft;

		// Token: 0x04002F6F RID: 12143
		[Token(Token = "0x4002F6F")]
		[FieldOffset(Offset = "0x238")]
		public CornerObstacle obs_BottomRight;

		// Token: 0x04002F70 RID: 12144
		[Token(Token = "0x4002F70")]
		[FieldOffset(Offset = "0x240")]
		public CornerObstacle obs_TopLeft;

		// Token: 0x04002F71 RID: 12145
		[Token(Token = "0x4002F71")]
		[FieldOffset(Offset = "0x248")]
		public CornerObstacle obs_TopRight;

		// Token: 0x04002F72 RID: 12146
		[Token(Token = "0x4002F72")]
		[FieldOffset(Offset = "0x250")]
		public List<ProceduralTile> procTiles;

		// Token: 0x04002F73 RID: 12147
		[Token(Token = "0x4002F73")]
		[FieldOffset(Offset = "0x258")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F74 RID: 12148
		[Token(Token = "0x4002F74")]
		[FieldOffset(Offset = "0x259")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted;
	}
}
