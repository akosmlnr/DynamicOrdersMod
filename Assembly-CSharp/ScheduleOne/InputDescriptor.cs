using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x0200020C RID: 524
	[Token(Token = "0x200020C")]
	public class InputDescriptor : MonoBehaviour
	{
		// Token: 0x06000B79 RID: 2937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x9F7260", Offset = "0x9F6460", VA = "0x1809F7260")]
		public void DetectTriggerInput()
		{
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x9F72E0", Offset = "0x9F64E0", VA = "0x1809F72E0")]
		public void OnReset()
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x9F72A0", Offset = "0x9F64A0", VA = "0x1809F72A0")]
		public bool GetInputTriggered()
		{
			return default(bool);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000B7C")]
		public T GetInputValue<T>() where T : struct
		{
			return null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public InputDescriptor()
		{
		}

		// Token: 0x04000BDC RID: 3036
		[Token(Token = "0x4000BDC")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Assign a InputDescriptorData scriptableObject. The scriptableObject should be placed in Assets/CustomUI/InputDescriptor")]
		[SerializeField]
		private InputDescriptorData data;

		// Token: 0x04000BDD RID: 3037
		[Token(Token = "0x4000BDD")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Assign the UITrigger component that suppose to detect and receive input when the input action from the InputDescriptorData is fired")]
		[SerializeField]
		private UITrigger uiTrigger;
	}
}
