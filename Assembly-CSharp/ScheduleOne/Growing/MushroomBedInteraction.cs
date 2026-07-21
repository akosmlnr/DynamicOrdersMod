using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008B9 RID: 2233
	[Token(Token = "0x20008B9")]
	public class MushroomBedInteraction : GrowContainerInteraction
	{
		// Token: 0x06003B2A RID: 15146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2A")]
		[Address(RVA = "0x814CB0", Offset = "0x813EB0", VA = "0x180814CB0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x000112F8 File Offset: 0x0000F4F8
		[Token(Token = "0x6003B2B")]
		[Address(RVA = "0x817DA0", Offset = "0x816FA0", VA = "0x180817DA0", Slot = "5")]
		protected override bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state)
		{
			return default(bool);
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B2C")]
		[Address(RVA = "0x814F60", Offset = "0x814160", VA = "0x180814F60")]
		public MushroomBedInteraction()
		{
		}

		// Token: 0x04002BBC RID: 11196
		[Token(Token = "0x4002BBC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MushroomBed _bed;
	}
}
