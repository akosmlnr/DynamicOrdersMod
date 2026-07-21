using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000B91 RID: 2961
	[Token(Token = "0x2000B91")]
	public class BasicEnclosure : MonoBehaviour
	{
		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x00016500 File Offset: 0x00014700
		[Token(Token = "0x17000CC0")]
		public Vector3 StartPoint
		{
			[Token(Token = "0x6005808")]
			[Address(RVA = "0x990AF0", Offset = "0x98FCF0", VA = "0x180990AF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06005809 RID: 22537 RVA: 0x00016518 File Offset: 0x00014718
		[Token(Token = "0x17000CC1")]
		public Vector3 EndPoint
		{
			[Token(Token = "0x6005809")]
			[Address(RVA = "0x990A00", Offset = "0x98FC00", VA = "0x180990A00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x00016530 File Offset: 0x00014730
		[Token(Token = "0x17000CC2")]
		public bool IsBlendZone
		{
			[Token(Token = "0x600580A")]
			[Address(RVA = "0x7B13B0", Offset = "0x7B05B0", VA = "0x1807B13B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600580B RID: 22539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Awake()
		{
		}

		// Token: 0x0600580C RID: 22540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600580C")]
		[Address(RVA = "0x990650", Offset = "0x98F850", VA = "0x180990650")]
		private void Update()
		{
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00016548 File Offset: 0x00014748
		[Token(Token = "0x600580D")]
		[Address(RVA = "0x9907D0", Offset = "0x98F9D0", VA = "0x1809907D0")]
		public bool WithinEnclosure(Vector3 targetPosition)
		{
			return default(bool);
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00016560 File Offset: 0x00014760
		[Token(Token = "0x600580E")]
		[Address(RVA = "0x98FFB0", Offset = "0x98F1B0", VA = "0x18098FFB0")]
		public float GetEnclosureBlend(Vector3 targetPosition)
		{
			return 0f;
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x600580F")]
		[Address(RVA = "0x98FE30", Offset = "0x98F030", VA = "0x18098FE30")]
		public Vector3 GetClosestPointOnZFaces(Vector3 targetPosition)
		{
			return default(Vector3);
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00016590 File Offset: 0x00014790
		[Token(Token = "0x6005810")]
		[Address(RVA = "0x990450", Offset = "0x98F650", VA = "0x180990450")]
		public Vector3 GetOppositeFacePoint(Vector3 surfacePoint)
		{
			return default(Vector3);
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x000165A8 File Offset: 0x000147A8
		[Token(Token = "0x6005811")]
		[Address(RVA = "0x9905F0", Offset = "0x98F7F0", VA = "0x1809905F0")]
		protected Vector3 GetSize()
		{
			return default(Vector3);
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x000165C0 File Offset: 0x000147C0
		[Token(Token = "0x6005812")]
		[Address(RVA = "0x98FD50", Offset = "0x98EF50", VA = "0x18098FD50")]
		protected Vector3 GetCenter()
		{
			return default(Vector3);
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005813")]
		[Address(RVA = "0x9909A0", Offset = "0x98FBA0", VA = "0x1809909A0")]
		public BasicEnclosure()
		{
		}

		// Token: 0x04003A70 RID: 14960
		[Token(Token = "0x4003A70")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[SerializeField]
		private Vector3 _center;

		// Token: 0x04003A71 RID: 14961
		[Token(Token = "0x4003A71")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _size;

		// Token: 0x04003A72 RID: 14962
		[Token(Token = "0x4003A72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Blend Zone Settings")]
		private bool _isBlendZone;

		// Token: 0x04003A73 RID: 14963
		[Token(Token = "0x4003A73")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _backRadius;

		// Token: 0x04003A74 RID: 14964
		[Token(Token = "0x4003A74")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _frontRadius;

		// Token: 0x04003A75 RID: 14965
		[Token(Token = "0x4003A75")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve _blendCurve;

		// Token: 0x04003A76 RID: 14966
		[Token(Token = "0x4003A76")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("Debug")]
		private bool _debugMode;

		// Token: 0x04003A77 RID: 14967
		[Token(Token = "0x4003A77")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool _debugShowFrontAndBackSeparately;

		// Token: 0x04003A78 RID: 14968
		[Token(Token = "0x4003A78")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _debugObject;

		// Token: 0x04003A79 RID: 14969
		[Token(Token = "0x4003A79")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 _debugClosestPoint;

		// Token: 0x04003A7A RID: 14970
		[Token(Token = "0x4003A7A")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _debugOppositePoint;

		// Token: 0x04003A7B RID: 14971
		[Token(Token = "0x4003A7B")]
		[FieldOffset(Offset = "0x78")]
		private float _debugBlendValue;

		// Token: 0x04003A7C RID: 14972
		[Token(Token = "0x4003A7C")]
		[FieldOffset(Offset = "0x7C")]
		private float _debugActiveRadius;
	}
}
