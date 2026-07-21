using System;
using Il2CppDummyDll;
using ScheduleOne.Interaction;

namespace ScheduleOne.Storage
{
	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06003C01 RID: 15361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C01")]
		[Address(RVA = "0x81EA10", Offset = "0x81DC10", VA = "0x18081EA10")]
		private void Awake()
		{
		}

		// Token: 0x06003C02 RID: 15362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C02")]
		[Address(RVA = "0x81EA80", Offset = "0x81DC80", VA = "0x18081EA80", Slot = "4")]
		public override void Hovered()
		{
		}

		// Token: 0x06003C03 RID: 15363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C03")]
		[Address(RVA = "0x81EAD0", Offset = "0x81DCD0", VA = "0x18081EAD0", Slot = "5")]
		public override void StartInteract()
		{
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003C04")]
		[Address(RVA = "0x81EC20", Offset = "0x81DE20", VA = "0x18081EC20")]
		public StorageEntityInteractable()
		{
		}

		// Token: 0x04002C19 RID: 11289
		[Token(Token = "0x4002C19")]
		[FieldOffset(Offset = "0x70")]
		private StorageEntity StorageEntity;
	}
}
