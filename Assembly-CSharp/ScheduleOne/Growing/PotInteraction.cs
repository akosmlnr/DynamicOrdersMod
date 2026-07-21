using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008BE RID: 2238
	[Token(Token = "0x20008BE")]
	public class PotInteraction : GrowContainerInteraction
	{
		// Token: 0x06003B4E RID: 15182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B4E")]
		[Address(RVA = "0x814CB0", Offset = "0x813EB0", VA = "0x180814CB0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003B4F RID: 15183 RVA: 0x00011388 File Offset: 0x0000F588
		[Token(Token = "0x6003B4F")]
		[Address(RVA = "0x819EC0", Offset = "0x8190C0", VA = "0x180819EC0", Slot = "5")]
		protected override bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state)
		{
			return default(bool);
		}

		// Token: 0x06003B50 RID: 15184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B50")]
		[Address(RVA = "0x814F60", Offset = "0x814160", VA = "0x180814F60")]
		public PotInteraction()
		{
		}

		// Token: 0x04002BD7 RID: 11223
		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Pot _pot;
	}
}
