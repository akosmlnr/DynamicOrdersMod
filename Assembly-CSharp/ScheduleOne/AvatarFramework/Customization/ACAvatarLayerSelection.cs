using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000808 RID: 2056
	[Token(Token = "0x2000808")]
	public class ACAvatarLayerSelection : ACSelection<AvatarLayer>
	{
		// Token: 0x0600376B RID: 14187 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600376B")]
		[Address(RVA = "0x7E0C70", Offset = "0x7DFE70", VA = "0x1807E0C70", Slot = "6")]
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		// Token: 0x0600376C RID: 14188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376C")]
		[Address(RVA = "0x7E0A40", Offset = "0x7DFC40", VA = "0x1807E0A40", Slot = "5")]
		public override void CallValueChange()
		{
		}

		// Token: 0x0600376D RID: 14189 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x7E0B20", Offset = "0x7DFD20", VA = "0x1807E0B20", Slot = "7")]
		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}

		// Token: 0x0600376E RID: 14190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x7E0CD0", Offset = "0x7DFED0", VA = "0x1807E0CD0")]
		public ACAvatarLayerSelection()
		{
		}
	}
}
