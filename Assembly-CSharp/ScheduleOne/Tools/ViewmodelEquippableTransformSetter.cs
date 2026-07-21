using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x02000898 RID: 2200
	[Token(Token = "0x2000898")]
	[ExecuteInEditMode]
	public class ViewmodelEquippableTransformSetter : MonoBehaviour
	{
		// Token: 0x06003A02 RID: 14850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A02")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public ViewmodelEquippableTransformSetter()
		{
		}

		// Token: 0x04002AC5 RID: 10949
		[Token(Token = "0x4002AC5")]
		[FieldOffset(Offset = "0x0")]
		private static Vector3 lastRecordedLocalPosition;

		// Token: 0x04002AC6 RID: 10950
		[Token(Token = "0x4002AC6")]
		[FieldOffset(Offset = "0xC")]
		private static Vector3 lastRecordedLocalEulerAngles;

		// Token: 0x04002AC7 RID: 10951
		[Token(Token = "0x4002AC7")]
		[FieldOffset(Offset = "0x18")]
		private static Vector3 lastRecordedLocalScale;

		// Token: 0x04002AC8 RID: 10952
		[Token(Token = "0x4002AC8")]
		[FieldOffset(Offset = "0x24")]
		private static bool transformChangedApplied;
	}
}
