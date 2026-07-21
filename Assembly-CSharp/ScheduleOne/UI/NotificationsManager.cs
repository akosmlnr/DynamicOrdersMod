using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C6F RID: 3183
	[Token(Token = "0x2000C6F")]
	public class NotificationsManager : Singleton<NotificationsManager>
	{
		// Token: 0x06005D2D RID: 23853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D2D")]
		[Address(RVA = "0x9E5520", Offset = "0x9E4720", VA = "0x1809E5520")]
		public void SendNotification(string title, string subtitle, Sprite icon, float duration = 5f, bool playSound = true)
		{
		}

		// Token: 0x06005D2E RID: 23854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005D2E")]
		[Address(RVA = "0x9E5C20", Offset = "0x9E4E20", VA = "0x1809E5C20")]
		public NotificationsManager()
		{
		}

		// Token: 0x04003F9D RID: 16285
		[Token(Token = "0x4003F9D")]
		public const int MAX_NOTIFICATIONS = 6;

		// Token: 0x04003F9E RID: 16286
		[Token(Token = "0x4003F9E")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public RectTransform EntryContainer;

		// Token: 0x04003F9F RID: 16287
		[Token(Token = "0x4003F9F")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController Sound;

		// Token: 0x04003FA0 RID: 16288
		[Token(Token = "0x4003FA0")]
		[FieldOffset(Offset = "0x38")]
		[Header("Prefab")]
		public GameObject NotificationPrefab;

		// Token: 0x04003FA1 RID: 16289
		[Token(Token = "0x4003FA1")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<RectTransform, Coroutine> coroutines;

		// Token: 0x04003FA2 RID: 16290
		[Token(Token = "0x4003FA2")]
		[FieldOffset(Offset = "0x48")]
		private List<RectTransform> entries;
	}
}
