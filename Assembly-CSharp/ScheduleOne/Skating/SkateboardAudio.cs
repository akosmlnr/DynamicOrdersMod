using System;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x02000321 RID: 801
	[Token(Token = "0x2000321")]
	public class SkateboardAudio : MonoBehaviour
	{
		// Token: 0x06001334 RID: 4916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x58ECB0", Offset = "0x58DEB0", VA = "0x18058ECB0")]
		private void Awake()
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x58EEC0", Offset = "0x58E0C0", VA = "0x18058EEC0")]
		private void Start()
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x58EFB0", Offset = "0x58E1B0", VA = "0x18058EFB0")]
		private void Update()
		{
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x58EE20", Offset = "0x58E020", VA = "0x18058EE20")]
		public void PlayJump(float force)
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x58EE90", Offset = "0x58E090", VA = "0x18058EE90")]
		public void PlayLand()
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public SkateboardAudio()
		{
		}

		// Token: 0x040011B0 RID: 4528
		[Token(Token = "0x40011B0")]
		[FieldOffset(Offset = "0x20")]
		public Skateboard Board;

		// Token: 0x040011B1 RID: 4529
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public AudioSourceController JumpAudio;

		// Token: 0x040011B2 RID: 4530
		[Token(Token = "0x40011B2")]
		[FieldOffset(Offset = "0x30")]
		public AudioSourceController LandAudio;

		// Token: 0x040011B3 RID: 4531
		[Token(Token = "0x40011B3")]
		[FieldOffset(Offset = "0x38")]
		public AudioSourceController RollingAudio;

		// Token: 0x040011B4 RID: 4532
		[Token(Token = "0x40011B4")]
		[FieldOffset(Offset = "0x40")]
		public AudioSourceController DirtRollingAudio;

		// Token: 0x040011B5 RID: 4533
		[Token(Token = "0x40011B5")]
		[FieldOffset(Offset = "0x48")]
		public AudioSourceController WindAudio;
	}
}
