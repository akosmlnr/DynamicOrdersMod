using System;
using System.Collections;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	// Token: 0x020005A3 RID: 1443
	[Token(Token = "0x20005A3")]
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x060020FC RID: 8444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FC")]
		[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
		public void SetIsOn(bool isOn)
		{
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FD")]
		[Address(RVA = "0x6840C0", Offset = "0x6832C0", VA = "0x1806840C0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60020FE")]
		[Address(RVA = "0x684050", Offset = "0x683250", VA = "0x180684050")]
		protected IEnumerator CycleCoroutine()
		{
			return null;
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020FF")]
		[Address(RVA = "0x6841C0", Offset = "0x6833C0", VA = "0x1806841C0")]
		public PoliceLight()
		{
		}

		// Token: 0x04001AD1 RID: 6865
		[Token(Token = "0x4001AD1")]
		[FieldOffset(Offset = "0x20")]
		public bool IsOn;

		// Token: 0x04001AD2 RID: 6866
		[Token(Token = "0x4001AD2")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public MeshRenderer[] RedMeshes;

		// Token: 0x04001AD3 RID: 6867
		[Token(Token = "0x4001AD3")]
		[FieldOffset(Offset = "0x30")]
		public MeshRenderer[] BlueMeshes;

		// Token: 0x04001AD4 RID: 6868
		[Token(Token = "0x4001AD4")]
		[FieldOffset(Offset = "0x38")]
		public OptimizedLight[] RedLights;

		// Token: 0x04001AD5 RID: 6869
		[Token(Token = "0x4001AD5")]
		[FieldOffset(Offset = "0x40")]
		public OptimizedLight[] BlueLights;

		// Token: 0x04001AD6 RID: 6870
		[Token(Token = "0x4001AD6")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController Siren;

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public float CycleDuration;

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		[FieldOffset(Offset = "0x58")]
		public Material RedOffMat;

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x60")]
		public Material RedOnMat;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x68")]
		public Material BlueOffMat;

		// Token: 0x04001ADB RID: 6875
		[Token(Token = "0x4001ADB")]
		[FieldOffset(Offset = "0x70")]
		public Material BlueOnMat;

		// Token: 0x04001ADC RID: 6876
		[Token(Token = "0x4001ADC")]
		[FieldOffset(Offset = "0x78")]
		public AnimationCurve RedBrightnessCurve;

		// Token: 0x04001ADD RID: 6877
		[Token(Token = "0x4001ADD")]
		[FieldOffset(Offset = "0x80")]
		public AnimationCurve BlueBrightnessCurve;

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x88")]
		public float LightBrightness;

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x90")]
		private Coroutine cycleRoutine;
	}
}
