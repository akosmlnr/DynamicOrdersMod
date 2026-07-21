using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.UI
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	public class PropertySelector : MonoBehaviour
	{
		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06005E74 RID: 24180 RVA: 0x00017B80 File Offset: 0x00015D80
		[Token(Token = "0x17000DAD")]
		public bool isOpen
		{
			[Token(Token = "0x6005E74")]
			[Address(RVA = "0xA0CE10", Offset = "0xA0C010", VA = "0x180A0CE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E75")]
		[Address(RVA = "0xA0C650", Offset = "0xA0B850", VA = "0x180A0C650", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E76")]
		[Address(RVA = "0xA0CD70", Offset = "0xA0BF70", VA = "0x180A0CD70", Slot = "5")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E77")]
		[Address(RVA = "0xA0CA40", Offset = "0xA0BC40", VA = "0x180A0CA40", Slot = "6")]
		public virtual void Exit(ExitAction exit)
		{
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E78")]
		[Address(RVA = "0xA0CAA0", Offset = "0xA0BCA0", VA = "0x180A0CAA0")]
		public void OpenSelector(PropertySelector.PropertySelected p)
		{
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E79")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void PropertyAcquired(Property p)
		{
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E7A")]
		[Address(RVA = "0xA0CD30", Offset = "0xA0BF30", VA = "0x180A0CD30")]
		private void SelectProperty(Property p)
		{
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E7B")]
		[Address(RVA = "0xA0C7B0", Offset = "0xA0B9B0", VA = "0x180A0C7B0")]
		private void Close(bool reenableShit)
		{
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E7C")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PropertySelector()
		{
		}

		// Token: 0x040040EA RID: 16618
		[Token(Token = "0x40040EA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected GameObject container;

		// Token: 0x040040EB RID: 16619
		[Token(Token = "0x40040EB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected RectTransform buttonContainer;

		// Token: 0x040040EC RID: 16620
		[Token(Token = "0x40040EC")]
		[FieldOffset(Offset = "0x30")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		// Token: 0x040040ED RID: 16621
		[Token(Token = "0x40040ED")]
		[FieldOffset(Offset = "0x38")]
		private PropertySelector.PropertySelected pCallback;

		// Token: 0x02000C9E RID: 3230
		// (Invoke) Token: 0x06005E7E RID: 24190
		[Token(Token = "0x2000C9E")]
		public delegate void PropertySelected(Property p);
	}
}
