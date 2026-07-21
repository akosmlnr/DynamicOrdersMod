using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x0200098B RID: 2443
	[Token(Token = "0x200098B")]
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x00012900 File Offset: 0x00010B00
		// (set) Token: 0x060041DF RID: 16863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3C")]
		public bool Interactable
		{
			[Token(Token = "0x60041DE")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60041DF")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x060041E0 RID: 16864 RVA: 0x00012918 File Offset: 0x00010B18
		// (set) Token: 0x060041E1 RID: 16865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3D")]
		public float CurrentPosition
		{
			[Token(Token = "0x60041E0")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60041E1")]
			[Address(RVA = "0x4929D0", Offset = "0x491BD0", VA = "0x1804929D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x060041E2 RID: 16866 RVA: 0x00012930 File Offset: 0x00010B30
		// (set) Token: 0x060041E3 RID: 16867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A3E")]
		public float TargetPosition
		{
			[Token(Token = "0x60041E2")]
			[Address(RVA = "0x524800", Offset = "0x523A00", VA = "0x180524800")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60041E3")]
			[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E4")]
		[Address(RVA = "0x86E7C0", Offset = "0x86D9C0", VA = "0x18086E7C0")]
		private void Start()
		{
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E5")]
		[Address(RVA = "0x86E450", Offset = "0x86D650", VA = "0x18086E450")]
		private void LateUpdate()
		{
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E6")]
		[Address(RVA = "0x86E5F0", Offset = "0x86D7F0", VA = "0x18086E5F0")]
		private void Move()
		{
		}

		// Token: 0x060041E7 RID: 16871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E7")]
		[Address(RVA = "0x563780", Offset = "0x562980", VA = "0x180563780")]
		private void UpdateSound(float difference)
		{
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x548D10", Offset = "0x547F10", VA = "0x180548D10")]
		public void SetPosition(float position)
		{
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x86E7A0", Offset = "0x86D9A0", VA = "0x18086E7A0")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x86DFE0", Offset = "0x86D1E0", VA = "0x18086DFE0")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EB")]
		[Address(RVA = "0x86DFD0", Offset = "0x86D1D0", VA = "0x18086DFD0")]
		public void ClickEnd()
		{
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x00012948 File Offset: 0x00010B48
		[Token(Token = "0x60041EC")]
		[Address(RVA = "0x86E080", Offset = "0x86D280", VA = "0x18086E080")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041ED")]
		[Address(RVA = "0x86E8E0", Offset = "0x86DAE0", VA = "0x18086E8E0")]
		public BrickPressHandle()
		{
		}

		// Token: 0x04002FC4 RID: 12228
		[Token(Token = "0x4002FC4")]
		[FieldOffset(Offset = "0x2C")]
		private float lastClickPosition;

		// Token: 0x04002FC5 RID: 12229
		[Token(Token = "0x4002FC5")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float MoveSpeed;

		// Token: 0x04002FC6 RID: 12230
		[Token(Token = "0x4002FC6")]
		[FieldOffset(Offset = "0x34")]
		public bool Locked;

		// Token: 0x04002FC7 RID: 12231
		[Token(Token = "0x4002FC7")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform PlaneNormal;

		// Token: 0x04002FC8 RID: 12232
		[Token(Token = "0x4002FC8")]
		[FieldOffset(Offset = "0x40")]
		public Transform RaisedTransform;

		// Token: 0x04002FC9 RID: 12233
		[Token(Token = "0x4002FC9")]
		[FieldOffset(Offset = "0x48")]
		public Transform LoweredTransform;

		// Token: 0x04002FCA RID: 12234
		[Token(Token = "0x4002FCA")]
		[FieldOffset(Offset = "0x50")]
		public Clickable HandleClickable;

		// Token: 0x04002FCB RID: 12235
		[Token(Token = "0x4002FCB")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController ClickSound;

		// Token: 0x04002FCC RID: 12236
		[Token(Token = "0x4002FCC")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 clickOffset;

		// Token: 0x04002FCD RID: 12237
		[Token(Token = "0x4002FCD")]
		[FieldOffset(Offset = "0x6C")]
		private bool isMoving;
	}
}
