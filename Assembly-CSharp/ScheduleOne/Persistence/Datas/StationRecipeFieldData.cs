using System;
using Il2CppDummyDll;

namespace ScheduleOne.Persistence.Datas
{
	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000496")]
	[Serializable]
	public class StationRecipeFieldData
	{
		// Token: 0x06001AE6 RID: 6886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE6")]
		[Address(RVA = "0x471360", Offset = "0x470560", VA = "0x180471360")]
		public StationRecipeFieldData(string recipeID)
		{
		}

		// Token: 0x040016B1 RID: 5809
		[Token(Token = "0x40016B1")]
		[FieldOffset(Offset = "0x10")]
		public string RecipeID;
	}
}
