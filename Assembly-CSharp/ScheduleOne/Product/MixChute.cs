using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020008FE RID: 2302
	[Token(Token = "0x20008FE")]
	public class MixChute : MonoBehaviour
	{
		// Token: 0x06003DA5 RID: 15781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA5")]
		[Address(RVA = "0x82F180", Offset = "0x82E380", VA = "0x18082F180")]
		private void Update()
		{
		}

		// Token: 0x06003DA6 RID: 15782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA6")]
		[Address(RVA = "0x82EFF0", Offset = "0x82E1F0", VA = "0x18082EFF0")]
		private void UpdateDoor()
		{
		}

		// Token: 0x06003DA7 RID: 15783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA7")]
		[Address(RVA = "0x82ED30", Offset = "0x82DF30", VA = "0x18082ED30")]
		public void Hovered()
		{
		}

		// Token: 0x06003DA8 RID: 15784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA8")]
		[Address(RVA = "0x82EE80", Offset = "0x82E080", VA = "0x18082EE80")]
		public void Interacted()
		{
		}

		// Token: 0x06003DA9 RID: 15785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DA9")]
		[Address(RVA = "0x82EF80", Offset = "0x82E180", VA = "0x18082EF80")]
		public void SetDoorOpen(bool isOpen)
		{
		}

		// Token: 0x06003DAA RID: 15786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DAA")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public MixChute()
		{
		}

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public InteractableObject IntObj;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x28")]
		public Animation DoorAnim;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x30")]
		private bool isDoorOpen;
	}
}
