using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.NPCs.Other
{
	// Token: 0x02000B4E RID: 2894
	[Token(Token = "0x2000B4E")]
	public class SprayPaint : MonoBehaviour
	{
		// Token: 0x060056D3 RID: 22227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D3")]
		[Address(RVA = "0x9A4820", Offset = "0x9A3A20", VA = "0x1809A4820")]
		private void Awake()
		{
		}

		// Token: 0x060056D4 RID: 22228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D4")]
		[Address(RVA = "0x9A4910", Offset = "0x9A3B10", VA = "0x1809A4910")]
		public void Begin()
		{
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D5")]
		[Address(RVA = "0x9A4A00", Offset = "0x9A3C00", VA = "0x1809A4A00")]
		public void End()
		{
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D6")]
		[Address(RVA = "0x9A4AE0", Offset = "0x9A3CE0", VA = "0x1809A4AE0")]
		public void SetEffect(bool value, [Optional] Color colour)
		{
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60056D7")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SprayPaint()
		{
		}

		// Token: 0x040039FE RID: 14846
		[Token(Token = "0x40039FE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Components")]
		private NPC _npc;

		// Token: 0x040039FF RID: 14847
		[Token(Token = "0x40039FF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AvatarEquippable _sprayPaintPrefab;

		// Token: 0x04003A00 RID: 14848
		[Token(Token = "0x4003A00")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AvatarAnimation _anim;

		// Token: 0x04003A01 RID: 14849
		[Token(Token = "0x4003A01")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioSourceController _spraySound;

		// Token: 0x04003A02 RID: 14850
		[Token(Token = "0x4003A02")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AvatarEquippable _sprayPaint;

		// Token: 0x04003A03 RID: 14851
		[Token(Token = "0x4003A03")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem _sprayEffect;
	}
}
