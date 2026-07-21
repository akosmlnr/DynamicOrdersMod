using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne
{
	// Token: 0x0200020D RID: 525
	[Token(Token = "0x200020D")]
	[CreateAssetMenu(fileName = "InputDescriptorData", menuName = "ScriptableObjects/InputDescriptorData", order = 1)]
	public class InputDescriptorData : ScriptableObject
	{
		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700025B")]
		public InputActionReference InputActionReference
		{
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700025C")]
		public string DisplayName
		{
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x7507D0", Offset = "0x74F9D0", VA = "0x1807507D0")]
		public InputDescriptorData()
		{
		}

		// Token: 0x04000BDE RID: 3038
		[Token(Token = "0x4000BDE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputActionReference inputActionReference;

		// Token: 0x04000BDF RID: 3039
		[Token(Token = "0x4000BDF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string displayName;
	}
}
