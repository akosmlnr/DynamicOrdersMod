using System;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Property;

namespace ScheduleOne.Building.Doors
{
	// Token: 0x020007C7 RID: 1991
	[Token(Token = "0x20007C7")]
	public class PropertyDoorController : DoorController
	{
		// Token: 0x06003522 RID: 13602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003522")]
		[Address(RVA = "0x7CF7C0", Offset = "0x7CE9C0", VA = "0x1807CF7C0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x06003523 RID: 13603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003523")]
		[Address(RVA = "0x7D0160", Offset = "0x7CF360", VA = "0x1807D0160")]
		public void Unlock()
		{
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003524")]
		[Address(RVA = "0x7CFC50", Offset = "0x7CEE50", VA = "0x1807CFC50")]
		private void CheckClose()
		{
		}

		// Token: 0x06003525 RID: 13605 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x6003525")]
		[Address(RVA = "0x7CF910", Offset = "0x7CEB10", VA = "0x1807CF910", Slot = "26")]
		protected override bool CanPlayerAccess(EDoorSide side, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003526")]
		[Address(RVA = "0x7CFDD0", Offset = "0x7CEFD0", VA = "0x1807CFDD0")]
		private Player GetNearestWantedPlayer()
		{
			return null;
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003527")]
		[Address(RVA = "0x7D0180", Offset = "0x7CF380", VA = "0x1807D0180")]
		public PropertyDoorController()
		{
		}

		// Token: 0x06003528 RID: 13608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003528")]
		[Address(RVA = "0x7D0140", Offset = "0x7CF340", VA = "0x1807D0140", Slot = "33")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003529 RID: 13609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003529")]
		[Address(RVA = "0x7D0120", Offset = "0x7CF320", VA = "0x1807D0120", Slot = "34")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352A")]
		[Address(RVA = "0x6A38B0", Offset = "0x6A2AB0", VA = "0x1806A38B0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600352B RID: 13611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600352B")]
		[Address(RVA = "0x7CF6A0", Offset = "0x7CE8A0", VA = "0x1807CF6A0", Slot = "36")]
		protected virtual void Awake_UserLogic_ScheduleOne.Building.Doors.PropertyDoorController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		public const float WANTED_PLAYER_CLOSE_DISTANCE = 20f;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0x198")]
		public Property Property;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0x1A0")]
		private bool IsUnlocked;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize___EarlyScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		[FieldOffset(Offset = "0x1A2")]
		private bool NetworkInitialize__LateScheduleOne.Building.Doors.PropertyDoorControllerAssembly-CSharp.dll_Excuted;
	}
}
