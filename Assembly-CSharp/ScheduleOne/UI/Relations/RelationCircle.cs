using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Relations
{
	// Token: 0x02000D03 RID: 3331
	[Token(Token = "0x2000D03")]
	public class RelationCircle : MonoBehaviour
	{
		// Token: 0x060060E3 RID: 24803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E3")]
		[Address(RVA = "0xA328C0", Offset = "0xA31AC0", VA = "0x180A328C0")]
		private void Awake()
		{
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E4")]
		[Address(RVA = "0xA32D80", Offset = "0xA31F80", VA = "0x180A32D80")]
		private void OnValidate()
		{
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E5")]
		[Address(RVA = "0xA32250", Offset = "0xA31450", VA = "0x180A32250")]
		public void AssignNPC(NPC npc)
		{
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0xA33360", Offset = "0xA32560", VA = "0x180A33360")]
		private void UnassignNPC()
		{
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E7")]
		[Address(RVA = "0xA33130", Offset = "0xA32330", VA = "0x180A33130")]
		private void RelationshipChange(float change)
		{
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E8")]
		[Address(RVA = "0xA33220", Offset = "0xA32420", VA = "0x180A33220")]
		public void SetNotchPosition(float relationshipDelta)
		{
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0xA33070", Offset = "0xA32270", VA = "0x180A33070")]
		private void RefreshNotchPosition()
		{
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0xA32E80", Offset = "0xA32080", VA = "0x180A32E80")]
		private void RefreshDependenceDisplay()
		{
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EB")]
		[Address(RVA = "0xA331C0", Offset = "0xA323C0", VA = "0x180A331C0")]
		[Button]
		public void SetLocked()
		{
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0xA332C0", Offset = "0xA324C0", VA = "0x180A332C0")]
		[Button]
		public void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0xA32D10", Offset = "0xA31F10", VA = "0x180A32D10")]
		[Button]
		public void LoadNPCData()
		{
		}

		// Token: 0x060060EE RID: 24814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EE")]
		[Address(RVA = "0xA33590", Offset = "0xA32790", VA = "0x180A33590")]
		private void UpdateBlackout()
		{
		}

		// Token: 0x060060EF RID: 24815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0xA33140", Offset = "0xA32340", VA = "0x180A33140")]
		public void SetBlackedOut(bool blackedOut)
		{
		}

		// Token: 0x060060F0 RID: 24816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0xA32CB0", Offset = "0xA31EB0", VA = "0x180A32CB0")]
		private void ButtonClicked()
		{
		}

		// Token: 0x060060F1 RID: 24817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0xA32CF0", Offset = "0xA31EF0", VA = "0x180A32CF0")]
		private void HoverStart()
		{
		}

		// Token: 0x060060F2 RID: 24818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F2")]
		[Address(RVA = "0xA32CD0", Offset = "0xA31ED0", VA = "0x180A32CD0")]
		private void HoverEnd()
		{
		}

		// Token: 0x060060F3 RID: 24819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0xA33890", Offset = "0xA32A90", VA = "0x180A33890")]
		public RelationCircle()
		{
		}

		// Token: 0x040042D6 RID: 17110
		[Token(Token = "0x40042D6")]
		public const float NotchMinRot = 90f;

		// Token: 0x040042D7 RID: 17111
		[Token(Token = "0x40042D7")]
		public const float NotchMaxRot = -90f;

		// Token: 0x040042D8 RID: 17112
		[Token(Token = "0x40042D8")]
		[FieldOffset(Offset = "0x0")]
		public static Color PortraitColor_ZeroDependence;

		// Token: 0x040042D9 RID: 17113
		[Token(Token = "0x40042D9")]
		[FieldOffset(Offset = "0x10")]
		public static Color PortraitColor_MaxDependence;

		// Token: 0x040042DA RID: 17114
		[Token(Token = "0x40042DA")]
		[FieldOffset(Offset = "0x20")]
		public string AssignedNPC_ID;

		// Token: 0x040042DB RID: 17115
		[Token(Token = "0x40042DB")]
		[FieldOffset(Offset = "0x28")]
		public NPC AssignedNPC;

		// Token: 0x040042DC RID: 17116
		[Token(Token = "0x40042DC")]
		[FieldOffset(Offset = "0x30")]
		public Action onClicked;

		// Token: 0x040042DD RID: 17117
		[Token(Token = "0x40042DD")]
		[FieldOffset(Offset = "0x38")]
		public Action onHoverStart;

		// Token: 0x040042DE RID: 17118
		[Token(Token = "0x40042DE")]
		[FieldOffset(Offset = "0x40")]
		public Action onHoverEnd;

		// Token: 0x040042DF RID: 17119
		[Token(Token = "0x40042DF")]
		[FieldOffset(Offset = "0x48")]
		public bool AutoSetName;

		// Token: 0x040042E0 RID: 17120
		[Token(Token = "0x40042E0")]
		[FieldOffset(Offset = "0x50")]
		[Header("References")]
		public RectTransform Rect;

		// Token: 0x040042E1 RID: 17121
		[Token(Token = "0x40042E1")]
		[FieldOffset(Offset = "0x58")]
		public Image PortraitBackground;

		// Token: 0x040042E2 RID: 17122
		[Token(Token = "0x40042E2")]
		[FieldOffset(Offset = "0x60")]
		public Image HeadshotImg;

		// Token: 0x040042E3 RID: 17123
		[Token(Token = "0x40042E3")]
		[FieldOffset(Offset = "0x68")]
		public RectTransform NotchPivot;

		// Token: 0x040042E4 RID: 17124
		[Token(Token = "0x40042E4")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform Locked;

		// Token: 0x040042E5 RID: 17125
		[Token(Token = "0x40042E5")]
		[FieldOffset(Offset = "0x78")]
		public Button Button;

		// Token: 0x040042E6 RID: 17126
		[Token(Token = "0x40042E6")]
		[FieldOffset(Offset = "0x80")]
		public EventTrigger Trigger;

		// Token: 0x040042E7 RID: 17127
		[Token(Token = "0x40042E7")]
		[FieldOffset(Offset = "0x88")]
		[Header("Custom UI")]
		public UIMapItem uiMapItem;
	}
}
