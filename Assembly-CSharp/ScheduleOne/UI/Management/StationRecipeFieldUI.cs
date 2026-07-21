using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Management;
using ScheduleOne.StationFramework;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000D8A RID: 3466
	[Token(Token = "0x2000D8A")]
	public class StationRecipeFieldUI : MonoBehaviour
	{
		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06006404 RID: 25604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4D")]
		public List<StationRecipeField> Fields
		{
			[Token(Token = "0x6006403")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006404")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006405")]
		[Address(RVA = "0xA6CCA0", Offset = "0xA6BEA0", VA = "0x180A6CCA0")]
		public void Bind(List<StationRecipeField> field)
		{
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006406")]
		[Address(RVA = "0xA6D360", Offset = "0xA6C560", VA = "0x180A6D360")]
		private void Refresh(StationRecipe newVal)
		{
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x00018A68 File Offset: 0x00016C68
		[Token(Token = "0x6006407")]
		[Address(RVA = "0xA6CB90", Offset = "0xA6BD90", VA = "0x180A6CB90")]
		private bool AreFieldsUniform()
		{
			return default(bool);
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006408")]
		[Address(RVA = "0xA6CF40", Offset = "0xA6C140", VA = "0x180A6CF40")]
		public void Clicked()
		{
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006409")]
		[Address(RVA = "0xA6D230", Offset = "0xA6C430", VA = "0x180A6D230")]
		private void OptionSelected(StationRecipe option)
		{
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600640A")]
		[Address(RVA = "0xA6CE20", Offset = "0xA6C020", VA = "0x180A6CE20")]
		public void ClearClicked()
		{
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600640B")]
		[Address(RVA = "0xA6D540", Offset = "0xA6C740", VA = "0x180A6D540")]
		public StationRecipeFieldUI()
		{
		}

		// Token: 0x04004625 RID: 17957
		[Token(Token = "0x4004625")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public StationRecipeEntry RecipeEntry;

		// Token: 0x04004626 RID: 17958
		[Token(Token = "0x4004626")]
		[FieldOffset(Offset = "0x30")]
		public GameObject None;

		// Token: 0x04004627 RID: 17959
		[Token(Token = "0x4004627")]
		[FieldOffset(Offset = "0x38")]
		public GameObject Mixed;

		// Token: 0x04004628 RID: 17960
		[Token(Token = "0x4004628")]
		[FieldOffset(Offset = "0x40")]
		public GameObject ClearButton;
	}
}
