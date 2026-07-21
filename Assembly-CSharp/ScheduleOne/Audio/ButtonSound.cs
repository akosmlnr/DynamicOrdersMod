using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace ScheduleOne.Audio
{
	// Token: 0x02000BD8 RID: 3032
	[Token(Token = "0x2000BD8")]
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	[RequireComponent(typeof(AudioSourceController))]
	public class ButtonSound : MonoBehaviour
	{
		// Token: 0x060059E6 RID: 23014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E6")]
		[Address(RVA = "0x9AC580", Offset = "0x9AB780", VA = "0x1809AC580")]
		public void Awake()
		{
		}

		// Token: 0x060059E7 RID: 23015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E7")]
		[Address(RVA = "0x9AC3D0", Offset = "0x9AB5D0", VA = "0x1809AC3D0")]
		public void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
		{
		}

		// Token: 0x060059E8 RID: 23016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E8")]
		[Address(RVA = "0x9AC7C0", Offset = "0x9AB9C0", VA = "0x1809AC7C0", Slot = "4")]
		protected virtual void Hovered()
		{
		}

		// Token: 0x060059E9 RID: 23017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059E9")]
		[Address(RVA = "0x9AC740", Offset = "0x9AB940", VA = "0x1809AC740", Slot = "5")]
		protected virtual void Clicked()
		{
		}

		// Token: 0x060059EA RID: 23018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60059EA")]
		[Address(RVA = "0x9AC880", Offset = "0x9ABA80", VA = "0x1809AC880")]
		public ButtonSound()
		{
		}

		// Token: 0x04003C1D RID: 15389
		[Token(Token = "0x4003C1D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("PlaySoundOnClickStart")]
		private bool _playSoundOnClickStart;

		// Token: 0x04003C1E RID: 15390
		[Token(Token = "0x4003C1E")]
		[FieldOffset(Offset = "0x28")]
		[FormerlySerializedAs("HoverClip")]
		[SerializeField]
		private AudioClip _hoverClip;

		// Token: 0x04003C1F RID: 15391
		[Token(Token = "0x4003C1F")]
		[FieldOffset(Offset = "0x30")]
		[FormerlySerializedAs("HoverSoundVolume")]
		[SerializeField]
		private float _hoverVolume;

		// Token: 0x04003C20 RID: 15392
		[Token(Token = "0x4003C20")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("ClickClip")]
		[SerializeField]
		private AudioClip _clickClip;

		// Token: 0x04003C21 RID: 15393
		[Token(Token = "0x4003C21")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("ClickSoundVolume")]
		[SerializeField]
		private float _clickVolume;

		// Token: 0x04003C22 RID: 15394
		[Token(Token = "0x4003C22")]
		[FieldOffset(Offset = "0x48")]
		private AudioSourceController _audioSource;

		// Token: 0x04003C23 RID: 15395
		[Token(Token = "0x4003C23")]
		[FieldOffset(Offset = "0x50")]
		private Button _button;

		// Token: 0x04003C24 RID: 15396
		[Token(Token = "0x4003C24")]
		[FieldOffset(Offset = "0x58")]
		private EventTrigger _eventTrigger;
	}
}
