using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	// Token: 0x02000DAD RID: 3501
	[Token(Token = "0x2000DAD")]
	public class WorldspaceUIElement : MonoBehaviour
	{
		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x060064DD RID: 25821 RVA: 0x00018BA0 File Offset: 0x00016DA0
		// (set) Token: 0x060064DE RID: 25822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E65")]
		public bool IsEnabled
		{
			[Token(Token = "0x60064DD")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60064DE")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x060064DF RID: 25823 RVA: 0x00018BB8 File Offset: 0x00016DB8
		[Token(Token = "0x17000E66")]
		public bool IsVisible
		{
			[Token(Token = "0x60064DF")]
			[Address(RVA = "0xA87050", Offset = "0xA86250", VA = "0x180A87050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060064E0 RID: 25824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E0")]
		[Address(RVA = "0xA86D90", Offset = "0xA85F90", VA = "0x180A86D90", Slot = "4")]
		public virtual void Show()
		{
		}

		// Token: 0x060064E1 RID: 25825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E1")]
		[Address(RVA = "0xA86850", Offset = "0xA85A50", VA = "0x180A86850", Slot = "5")]
		public virtual void Hide([Optional] Action callback)
		{
		}

		// Token: 0x060064E2 RID: 25826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E2")]
		[Address(RVA = "0xA867F0", Offset = "0xA859F0", VA = "0x180A867F0", Slot = "6")]
		public virtual void Destroy()
		{
		}

		// Token: 0x060064E3 RID: 25827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E3")]
		[Address(RVA = "0xA86E90", Offset = "0xA86090", VA = "0x180A86E90")]
		public void UpdatePosition(Vector3 worldSpacePosition)
		{
		}

		// Token: 0x060064E4 RID: 25828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E4")]
		[Address(RVA = "0xA86A40", Offset = "0xA85C40", VA = "0x180A86A40", Slot = "7")]
		public virtual void SetInternalScale(float scale)
		{
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E5")]
		[Address(RVA = "0xA86B10", Offset = "0xA85D10", VA = "0x180A86B10")]
		private void SetScale(float scale, Action callback)
		{
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E6")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "8")]
		public virtual void HoverStart()
		{
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E7")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "9")]
		public virtual void HoverEnd()
		{
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E8")]
		[Address(RVA = "0xA86990", Offset = "0xA85B90", VA = "0x180A86990")]
		public void SetAssignedNPC(NPC npc)
		{
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064E9")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public WorldspaceUIElement()
		{
		}

		// Token: 0x040046B9 RID: 18105
		[Token(Token = "0x40046B9")]
		public const float TRANSITION_TIME = 0.1f;

		// Token: 0x040046BB RID: 18107
		[Token(Token = "0x40046BB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform RectTransform;

		// Token: 0x040046BC RID: 18108
		[Token(Token = "0x40046BC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RectTransform Container;

		// Token: 0x040046BD RID: 18109
		[Token(Token = "0x40046BD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI TitleLabel;

		// Token: 0x040046BE RID: 18110
		[Token(Token = "0x40046BE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AssignedWorkerDisplay AssignedWorkerDisplay;

		// Token: 0x040046BF RID: 18111
		[Token(Token = "0x40046BF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine scaleRoutine;
	}
}
