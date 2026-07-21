using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using ScheduleOne.UI.Stations;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DA1 RID: 3489
	[Token(Token = "0x2000DA1")]
	public class ChemistryStationUIElement : WorldspaceUIElement
	{
		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x060064A1 RID: 25761 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060064A2 RID: 25762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E59")]
		public ChemistryStation AssignedStation
		{
			[Token(Token = "0x60064A1")]
			[Address(RVA = "0x442C10", Offset = "0x441E10", VA = "0x180442C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60064A2")]
			[Address(RVA = "0x497920", Offset = "0x496B20", VA = "0x180497920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0xA70B80", Offset = "0xA6FD80", VA = "0x180A70B80")]
		public void Initialize(ChemistryStation oven)
		{
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0xA70C60", Offset = "0xA6FE60", VA = "0x180A70C60", Slot = "10")]
		protected virtual void RefreshUI()
		{
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ChemistryStationUIElement()
		{
		}

		// Token: 0x0400469D RID: 18077
		[Token(Token = "0x400469D")]
		[FieldOffset(Offset = "0x58")]
		[Header("References")]
		public StationRecipeEntry RecipeEntry;

		// Token: 0x0400469E RID: 18078
		[Token(Token = "0x400469E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject NoRecipe;
	}
}
