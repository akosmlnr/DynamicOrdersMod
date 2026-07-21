using System;
using Il2CppDummyDll;
using UnityEngine.UI;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000818 RID: 2072
	[Token(Token = "0x2000818")]
	public class ACSliderReplicator : ACReplicator
	{
		// Token: 0x060037B1 RID: 14257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B1")]
		[Address(RVA = "0x7E13C0", Offset = "0x7E05C0", VA = "0x1807E13C0", Slot = "4")]
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B2")]
		[Address(RVA = "0x7E0DC0", Offset = "0x7DFFC0", VA = "0x1807E0DC0")]
		public ACSliderReplicator()
		{
		}

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x28")]
		public Slider slider;
	}
}
