using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x0200080D RID: 2061
	[Token(Token = "0x200080D")]
	public abstract class ACSelection<T> : MonoBehaviour where T : global::UnityEngine.Object
	{
		// Token: 0x06003779 RID: 14201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003779")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600377A RID: 14202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377A")]
		public void SelectOption(int index, bool notify = true)
		{
		}

		// Token: 0x0600377B RID: 14203
		[Token(Token = "0x600377B")]
		public abstract void CallValueChange();

		// Token: 0x0600377C RID: 14204
		[Token(Token = "0x600377C")]
		public abstract string GetOptionLabel(int index);

		// Token: 0x0600377D RID: 14205
		[Token(Token = "0x600377D")]
		public abstract int GetAssetPathIndex(string path);

		// Token: 0x0600377E RID: 14206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377E")]
		private void SetButtonHighlighted(int buttonIndex, bool h)
		{
		}

		// Token: 0x0600377F RID: 14207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600377F")]
		protected ACSelection()
		{
		}

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[FieldOffset(Offset = "0x0")]
		[Header("References")]
		public GameObject ButtonPrefab;

		// Token: 0x04002859 RID: 10329
		[Token(Token = "0x4002859")]
		[FieldOffset(Offset = "0x0")]
		[Header("Settings")]
		public int PropertyIndex;

		// Token: 0x0400285A RID: 10330
		[Token(Token = "0x400285A")]
		[FieldOffset(Offset = "0x0")]
		public List<T> Options;

		// Token: 0x0400285B RID: 10331
		[Token(Token = "0x400285B")]
		[FieldOffset(Offset = "0x0")]
		public bool Nullable;

		// Token: 0x0400285C RID: 10332
		[Token(Token = "0x400285C")]
		[FieldOffset(Offset = "0x0")]
		public int DefaultOptionIndex;

		// Token: 0x0400285D RID: 10333
		[Token(Token = "0x400285D")]
		[FieldOffset(Offset = "0x0")]
		protected List<GameObject> buttons;

		// Token: 0x0400285E RID: 10334
		[Token(Token = "0x400285E")]
		[FieldOffset(Offset = "0x0")]
		protected int SelectedOptionIndex;

		// Token: 0x0400285F RID: 10335
		[Token(Token = "0x400285F")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent<T> onValueChange;

		// Token: 0x04002860 RID: 10336
		[Token(Token = "0x4002860")]
		[FieldOffset(Offset = "0x0")]
		public UnityEvent<T, int> onValueChangeWithIndex;
	}
}
