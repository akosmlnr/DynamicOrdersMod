using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007EE RID: 2030
	[Token(Token = "0x20007EE")]
	public class Eyebrow : MonoBehaviour
	{
		// Token: 0x060036E7 RID: 14055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E7")]
		[Address(RVA = "0x7F3210", Offset = "0x7F2410", VA = "0x1807F3210")]
		public void SetScale(float _scale)
		{
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E8")]
		[Address(RVA = "0x7F3270", Offset = "0x7F2470", VA = "0x1807F3270")]
		public void SetThickness(float thickness)
		{
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036E9")]
		[Address(RVA = "0x7F3080", Offset = "0x7F2280", VA = "0x1807F3080")]
		public void SetRestingAngle(float _angle)
		{
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EA")]
		[Address(RVA = "0x7F3180", Offset = "0x7F2380", VA = "0x1807F3180")]
		public void SetRestingHeight(float normalizedHeight)
		{
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EB")]
		[Address(RVA = "0x7F3030", Offset = "0x7F2230", VA = "0x1807F3030")]
		public void SetColor(Color _col)
		{
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036EC")]
		[Address(RVA = "0x7F32D0", Offset = "0x7F24D0", VA = "0x1807F32D0")]
		public Eyebrow()
		{
		}

		// Token: 0x040027D1 RID: 10193
		[Token(Token = "0x40027D1")]
		private const float eyebrowHeightMultiplier = 0.01f;

		// Token: 0x040027D2 RID: 10194
		[Token(Token = "0x40027D2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 EyebrowDefaultScale;

		// Token: 0x040027D3 RID: 10195
		[Token(Token = "0x40027D3")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 EyebrowDefaultLocalPos;

		// Token: 0x040027D4 RID: 10196
		[Token(Token = "0x40027D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Eyebrow.ESide Side;

		// Token: 0x040027D5 RID: 10197
		[Token(Token = "0x40027D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform Model;

		// Token: 0x040027D6 RID: 10198
		[Token(Token = "0x40027D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected MeshRenderer Rend;

		// Token: 0x040027D7 RID: 10199
		[Token(Token = "0x40027D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Header("Eyebrow Data - Readonly")]
		private Color col;

		// Token: 0x040027D8 RID: 10200
		[Token(Token = "0x40027D8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float scale;

		// Token: 0x040027D9 RID: 10201
		[Token(Token = "0x40027D9")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float thickness;

		// Token: 0x040027DA RID: 10202
		[Token(Token = "0x40027DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float restingAngle;

		// Token: 0x020007EF RID: 2031
		[Token(Token = "0x20007EF")]
		public enum ESide
		{
			// Token: 0x040027DC RID: 10204
			[Token(Token = "0x40027DC")]
			Right,
			// Token: 0x040027DD RID: 10205
			[Token(Token = "0x40027DD")]
			Left
		}
	}
}
