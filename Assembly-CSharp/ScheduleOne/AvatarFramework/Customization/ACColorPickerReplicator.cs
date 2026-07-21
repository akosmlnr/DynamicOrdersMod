using System;
using HSVPicker;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	public class ACColorPickerReplicator : ACReplicator
	{
		// Token: 0x060037AB RID: 14251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AB")]
		[Address(RVA = "0x7E0D10", Offset = "0x7DFF10", VA = "0x1807E0D10", Slot = "4")]
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x060037AC RID: 14252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x7E0DC0", Offset = "0x7DFFC0", VA = "0x1807E0DC0")]
		public ACColorPickerReplicator()
		{
		}

		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		[FieldOffset(Offset = "0x28")]
		public ColorPicker picker;
	}
}
