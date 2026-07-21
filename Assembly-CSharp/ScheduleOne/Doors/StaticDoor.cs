using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Doors
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public class StaticDoor : MonoBehaviour
	{
		// Token: 0x06002EAC RID: 11948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAC")]
		[Address(RVA = "0x74D0A0", Offset = "0x74C2A0", VA = "0x18074D0A0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAD")]
		[Address(RVA = "0x74D6F0", Offset = "0x74C8F0", VA = "0x18074D6F0", Slot = "5")]
		protected virtual void OnValidate()
		{
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EAE")]
		[Address(RVA = "0x74D3E0", Offset = "0x74C5E0", VA = "0x18074D3E0", Slot = "6")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x0000E790 File Offset: 0x0000C990
		[Token(Token = "0x6002EAF")]
		[Address(RVA = "0x74D360", Offset = "0x74C560", VA = "0x18074D360", Slot = "7")]
		protected virtual bool CanKnockNow()
		{
			return default(bool);
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x0000E7A8 File Offset: 0x0000C9A8
		[Token(Token = "0x6002EB0")]
		[Address(RVA = "0x74D4F0", Offset = "0x74C6F0", VA = "0x18074D4F0", Slot = "8")]
		protected virtual bool IsKnockValid(out string message)
		{
			return default(bool);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x74D4D0", Offset = "0x74C6D0", VA = "0x18074D4D0", Slot = "9")]
		protected virtual void Interacted()
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x74D540", Offset = "0x74C740", VA = "0x18074D540", Slot = "10")]
		protected virtual void Knock()
		{
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB3")]
		[Address(RVA = "0x74D630", Offset = "0x74C830", VA = "0x18074D630", Slot = "11")]
		protected virtual void NPCSelected(NPC npc)
		{
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB4")]
		[Address(RVA = "0x7375D0", Offset = "0x7367D0", VA = "0x1807375D0")]
		public StaticDoor()
		{
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x74D870", Offset = "0x74CA70", VA = "0x18074D870")]
		[CompilerGenerated]
		private IEnumerator <Knock>g__knockRoutine|18_0()
		{
			return null;
		}

		// Token: 0x04002292 RID: 8850
		[Token(Token = "0x4002292")]
		public const float KNOCK_COOLDOWN = 2f;

		// Token: 0x04002293 RID: 8851
		[Token(Token = "0x4002293")]
		public const float SUMMON_DURATION = 8f;

		// Token: 0x04002294 RID: 8852
		[Token(Token = "0x4002294")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public Transform AccessPoint;

		// Token: 0x04002295 RID: 8853
		[Token(Token = "0x4002295")]
		[FieldOffset(Offset = "0x28")]
		public InteractableObject IntObj;

		// Token: 0x04002296 RID: 8854
		[Token(Token = "0x4002296")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController KnockSound;

		// Token: 0x04002297 RID: 8855
		[Token(Token = "0x4002297")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController EnterSound;

		// Token: 0x04002298 RID: 8856
		[Token(Token = "0x4002298")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController ExitSound;

		// Token: 0x04002299 RID: 8857
		[Token(Token = "0x4002299")]
		[FieldOffset(Offset = "0x48")]
		public NPCEnterableBuilding Building;

		// Token: 0x0400229A RID: 8858
		[Token(Token = "0x400229A")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public bool Usable;

		// Token: 0x0400229B RID: 8859
		[Token(Token = "0x400229B")]
		[FieldOffset(Offset = "0x51")]
		public bool CanKnock;

		// Token: 0x0400229C RID: 8860
		[Token(Token = "0x400229C")]
		[FieldOffset(Offset = "0x54")]
		private float timeSinceLastKnock;

		// Token: 0x0400229D RID: 8861
		[Token(Token = "0x400229D")]
		[FieldOffset(Offset = "0x58")]
		private int doorIndex;
	}
}
