using System;
using Il2CppDummyDll;
using ScheduleOne.Management;
using UnityEngine;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200060C RID: 1548
	[Token(Token = "0x200060C")]
	public class IUsableInteractableObject : InteractableObject
	{
		// Token: 0x0600264A RID: 9802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x6C0760", Offset = "0x6BF960", VA = "0x1806C0760")]
		private void Awake()
		{
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x6C07E0", Offset = "0x6BF9E0", VA = "0x1806C07E0", Slot = "4")]
		public override void Hovered()
		{
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x6C0A10", Offset = "0x6BFC10", VA = "0x1806C0A10")]
		public IUsableInteractableObject()
		{
		}

		// Token: 0x04001DFB RID: 7675
		[Token(Token = "0x4001DFB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeReference]
		private MonoBehaviour _iUsableMonoBehaviour;

		// Token: 0x04001DFC RID: 7676
		[Token(Token = "0x4001DFC")]
		[FieldOffset(Offset = "0x78")]
		private string _defaultMessage;

		// Token: 0x04001DFD RID: 7677
		[Token(Token = "0x4001DFD")]
		[FieldOffset(Offset = "0x80")]
		private IUsable _iUsable;
	}
}
