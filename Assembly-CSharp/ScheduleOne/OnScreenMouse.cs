using System;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.UI;

namespace ScheduleOne
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public class OnScreenMouse : Singleton<OnScreenMouse>
	{
		// Token: 0x06000B83 RID: 2947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x9FAB00", Offset = "0x9F9D00", VA = "0x1809FAB00")]
		private new void Awake()
		{
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x9FAF20", Offset = "0x9FA120", VA = "0x1809FAF20")]
		private void OnInputDeviceChanged(GameInput.InputDeviceType type)
		{
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x9FADC0", Offset = "0x9F9FC0", VA = "0x1809FADC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x9FAC70", Offset = "0x9F9E70", VA = "0x1809FAC70")]
		private void OnDisable()
		{
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x9FB2A0", Offset = "0x9FA4A0", VA = "0x1809FB2A0")]
		private void Update()
		{
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x9FAA90", Offset = "0x9F9C90", VA = "0x1809FAA90")]
		public void Activate()
		{
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x9FAC40", Offset = "0x9F9E40", VA = "0x1809FAC40")]
		public void Deactivate()
		{
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x9FAF80", Offset = "0x9FA180", VA = "0x1809FAF80")]
		public void SetTexture(Texture tex, Vector2 hotSpot)
		{
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x9FB070", Offset = "0x9FA270", VA = "0x1809FB070")]
		private void SetVirtualMouseEnabled(bool isOn)
		{
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x9FB2A0", Offset = "0x9FA4A0", VA = "0x1809FB2A0")]
		private void UpdateSystemMouseValues()
		{
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x9FB4B0", Offset = "0x9FA6B0", VA = "0x1809FB4B0")]
		public OnScreenMouse()
		{
		}

		// Token: 0x04000BE4 RID: 3044
		[Token(Token = "0x4000BE4")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 CURSOR_COORDINATE_REFERENCE;

		// Token: 0x04000BE5 RID: 3045
		[Token(Token = "0x4000BE5")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("Unity new input system virtual mouse")]
		public VirtualMouseInput ptrComponent;

		// Token: 0x04000BE6 RID: 3046
		[Token(Token = "0x4000BE6")]
		[FieldOffset(Offset = "0x30")]
		private Mouse systemMouse;
	}
}
