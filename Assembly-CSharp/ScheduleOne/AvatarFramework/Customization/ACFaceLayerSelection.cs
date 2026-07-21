using System;
using Il2CppDummyDll;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200080B RID: 2059
	[Token(Token = "0x200080B")]
	public class ACFaceLayerSelection : ACSelection<FaceLayer>
	{
		// Token: 0x06003773 RID: 14195 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003773")]
		[Address(RVA = "0x7E1110", Offset = "0x7E0310", VA = "0x1807E1110", Slot = "6")]
		public override string GetOptionLabel(int index)
		{
			return null;
		}

		// Token: 0x06003774 RID: 14196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003774")]
		[Address(RVA = "0x7E0EE0", Offset = "0x7E00E0", VA = "0x1807E0EE0", Slot = "5")]
		public override void CallValueChange()
		{
		}

		// Token: 0x06003775 RID: 14197 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x7E0FC0", Offset = "0x7E01C0", VA = "0x1807E0FC0", Slot = "7")]
		public override int GetAssetPathIndex(string path)
		{
			return 0;
		}

		// Token: 0x06003776 RID: 14198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003776")]
		[Address(RVA = "0x7E1170", Offset = "0x7E0370", VA = "0x1807E1170")]
		public ACFaceLayerSelection()
		{
		}
	}
}
