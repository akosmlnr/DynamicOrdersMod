using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000806 RID: 2054
	[Token(Token = "0x2000806")]
	public class ACAccessorySelection : ACSelection<Accessory>
	{
		// Token: 0x06003765 RID: 14181 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x7E0960", Offset = "0x7DFB60", VA = "0x1807E0960", Slot = "6")]
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003766")]
		[Address(RVA = "0x7E0730", Offset = "0x7DF930", VA = "0x1807E0730", Slot = "5")]
		public override void CallValueChange()
		{
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x7E0810", Offset = "0x7DFA10", VA = "0x1807E0810", Slot = "7")]
		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003768")]
		[Address(RVA = "0x7E09C0", Offset = "0x7DFBC0", VA = "0x1807E09C0")]
		public ACAccessorySelection()
		{
		}
	}
}
