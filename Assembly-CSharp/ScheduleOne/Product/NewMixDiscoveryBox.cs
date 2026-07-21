using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Effects;
using ScheduleOne.Interaction;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x0200090F RID: 2319
	[Token(Token = "0x200090F")]
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x06003DE9 RID: 15849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x835A00", Offset = "0x834C00", VA = "0x180835A00")]
		public void Start()
		{
		}

		// Token: 0x06003DEA RID: 15850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEA")]
		[Address(RVA = "0x835560", Offset = "0x834760", VA = "0x180835560")]
		public void ShowProduct(ProductDefinition baseDefinition, List<Effect> properties)
		{
		}

		// Token: 0x06003DEB RID: 15851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEB")]
		[Address(RVA = "0x835440", Offset = "0x834640", VA = "0x180835440")]
		private void CloseCase()
		{
		}

		// Token: 0x06003DEC RID: 15852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEC")]
		[Address(RVA = "0x835510", Offset = "0x834710", VA = "0x180835510")]
		private void OpenCase()
		{
		}

		// Token: 0x06003DED RID: 15853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DED")]
		[Address(RVA = "0x8354A0", Offset = "0x8346A0", VA = "0x1808354A0")]
		private void Interacted()
		{
		}

		// Token: 0x06003DEE RID: 15854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DEE")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public NewMixDiscoveryBox()
		{
		}

		// Token: 0x04002D65 RID: 11621
		[Token(Token = "0x4002D65")]
		[FieldOffset(Offset = "0x20")]
		private bool isOpen;

		// Token: 0x04002D66 RID: 11622
		[Token(Token = "0x4002D66")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public Transform CameraPosition;

		// Token: 0x04002D67 RID: 11623
		[Token(Token = "0x4002D67")]
		[FieldOffset(Offset = "0x30")]
		public TextMeshPro PropertiesText;

		// Token: 0x04002D68 RID: 11624
		[Token(Token = "0x4002D68")]
		[FieldOffset(Offset = "0x38")]
		public Animation Animation;

		// Token: 0x04002D69 RID: 11625
		[Token(Token = "0x4002D69")]
		[FieldOffset(Offset = "0x40")]
		public InteractableObject IntObj;

		// Token: 0x04002D6A RID: 11626
		[Token(Token = "0x4002D6A")]
		[FieldOffset(Offset = "0x48")]
		public Transform Lid;

		// Token: 0x04002D6B RID: 11627
		[Token(Token = "0x4002D6B")]
		[FieldOffset(Offset = "0x50")]
		public MultiTypeVisualsSetter Visuals;

		// Token: 0x04002D6C RID: 11628
		[Token(Token = "0x4002D6C")]
		[FieldOffset(Offset = "0x58")]
		private Pose closedLidPose;

		// Token: 0x04002D6D RID: 11629
		[Token(Token = "0x4002D6D")]
		[FieldOffset(Offset = "0x78")]
		private NewMixOperation currentMix;
	}
}
