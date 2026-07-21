using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Effects
{
	// Token: 0x02000B50 RID: 2896
	[Token(Token = "0x2000B50")]
	public abstract class EffectHandler : MonoBehaviour
	{
		// Token: 0x060056E2 RID: 22242
		[Token(Token = "0x60056E2")]
		public abstract void Activate();

		// Token: 0x060056E3 RID: 22243
		[Token(Token = "0x60056E3")]
		public abstract void Deactivate();

		// Token: 0x060056E4 RID: 22244
		[Token(Token = "0x60056E4")]
		public abstract void SetNumericParameter(string effectName, string variable, float value);

		// Token: 0x060056E5 RID: 22245
		[Token(Token = "0x60056E5")]
		public abstract void SetNumericParameterForAll(string variable, float value);

		// Token: 0x060056E6 RID: 22246
		[Token(Token = "0x60056E6")]
		public abstract void SetVectorParameter(string effectName, string variable, Vector3 value);

		// Token: 0x060056E7 RID: 22247
		[Token(Token = "0x60056E7")]
		public abstract void SetVectorParameter(string effectName, string variable, Vector2 value);

		// Token: 0x060056E8 RID: 22248
		[Token(Token = "0x60056E8")]
		public abstract void SetVectorParameterForAll(string variable, Vector3 value);

		// Token: 0x060056E9 RID: 22249
		[Token(Token = "0x60056E9")]
		public abstract void SetVectorParameterForAll(string variable, Vector2 value);

		// Token: 0x060056EA RID: 22250
		[Token(Token = "0x60056EA")]
		public abstract void SetColorParameterForAll(string variable, Color value);

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060056EB RID: 22251 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000CB4")]
		public virtual string Id
		{
			[Token(Token = "0x60056EB")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060056EC RID: 22252 RVA: 0x00016380 File Offset: 0x00014580
		[Token(Token = "0x17000CB5")]
		public virtual bool ScaleToParent
		{
			[Token(Token = "0x60056EC")]
			[Address(RVA = "0x491650", Offset = "0x490850", VA = "0x180491650", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060056ED RID: 22253 RVA: 0x00016398 File Offset: 0x00014598
		[Token(Token = "0x17000CB6")]
		public virtual bool PositionToParent
		{
			[Token(Token = "0x60056ED")]
			[Address(RVA = "0x5D6290", Offset = "0x5D5490", VA = "0x1805D6290", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060056EE RID: 22254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EE")]
		[Address(RVA = "0x9949B0", Offset = "0x993BB0", VA = "0x1809949B0", Slot = "16")]
		public virtual void Initialise()
		{
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056EF")]
		[Address(RVA = "0x9949E0", Offset = "0x993BE0", VA = "0x1809949E0")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F0")]
		[Address(RVA = "0x994A30", Offset = "0x993C30", VA = "0x180994A30")]
		public void SetSize(Vector3 size)
		{
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F1")]
		[Address(RVA = "0x994840", Offset = "0x993A40", VA = "0x180994840")]
		public void DelayDeactivate(float duration, [Optional] Action onComplete)
		{
		}

		// Token: 0x060056F2 RID: 22258 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60056F2")]
		[Address(RVA = "0x994910", Offset = "0x993B10", VA = "0x180994910")]
		private IEnumerator DoDelayDeactivate(float duration, [Optional] Action onComplete)
		{
			return null;
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60056F3")]
		[Address(RVA = "0x9947D0", Offset = "0x9939D0", VA = "0x1809947D0")]
		protected string AddPrefixToVariableName(string variable)
		{
			return null;
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056F4")]
		[Address(RVA = "0x994A80", Offset = "0x993C80", VA = "0x180994A80")]
		protected EffectHandler()
		{
		}

		// Token: 0x04003A0B RID: 14859
		[Token(Token = "0x4003A0B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[SerializeField]
		private string _id;

		// Token: 0x04003A0C RID: 14860
		[Token(Token = "0x4003A0C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _scaleToParent;

		// Token: 0x04003A0D RID: 14861
		[Token(Token = "0x4003A0D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _positionToParent;

		// Token: 0x04003A0E RID: 14862
		[Token(Token = "0x4003A0E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[SerializeField]
		private bool _activeByDefault;

		// Token: 0x04003A0F RID: 14863
		[Token(Token = "0x4003A0F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine _delayDeactivateCoroutine;
	}
}
