using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008B1 RID: 2225
	[Token(Token = "0x20008B1")]
	public class GrowContainerInteraction : MonoBehaviour
	{
		// Token: 0x06003AF2 RID: 15090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF2")]
		[Address(RVA = "0x814CB0", Offset = "0x813EB0", VA = "0x180814CB0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06003AF3 RID: 15091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF3")]
		[Address(RVA = "0x814E10", Offset = "0x814010", VA = "0x180814E10")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003AF4 RID: 15092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF4")]
		[Address(RVA = "0x814D10", Offset = "0x813F10", VA = "0x180814D10")]
		public void ConfigureInteraction(string labelText, InteractableObject.EInteractableState interactionState, bool setLabelPosition = false, [Optional] Vector3 labelPosition)
		{
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[Token(Token = "0x6003AF5")]
		[Address(RVA = "0x814F00", Offset = "0x814100", VA = "0x180814F00", Slot = "5")]
		protected virtual bool TryGetFallbackInteractionMessage(out string message, out InteractableObject.EInteractableState state)
		{
			return default(bool);
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003AF6")]
		[Address(RVA = "0x814F60", Offset = "0x814160", VA = "0x180814F60")]
		public GrowContainerInteraction()
		{
		}

		// Token: 0x04002B81 RID: 11137
		[Token(Token = "0x4002B81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InteractableObject _interactableObject;

		// Token: 0x04002B82 RID: 11138
		[Token(Token = "0x4002B82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _interactableActivatedThisFrame;

		// Token: 0x04002B83 RID: 11139
		[Token(Token = "0x4002B83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 displayLocationPointDefaultLocalPosition;
	}
}
