using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x02000738 RID: 1848
	[Token(Token = "0x2000738")]
	public class CutsceneManager : Singleton<CutsceneManager>
	{
		// Token: 0x06003071 RID: 12401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003071")]
		[Address(RVA = "0x7601E0", Offset = "0x75F3E0", VA = "0x1807601E0")]
		[Button]
		private void RunCutscene()
		{
		}

		// Token: 0x06003072 RID: 12402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003072")]
		[Address(RVA = "0x760030", Offset = "0x75F230", VA = "0x180760030")]
		public void Play(string name)
		{
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003073")]
		[Address(RVA = "0x75FF80", Offset = "0x75F180", VA = "0x18075FF80")]
		private void Ended()
		{
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003074")]
		[Address(RVA = "0x760390", Offset = "0x75F590", VA = "0x180760390")]
		public CutsceneManager()
		{
		}

		// Token: 0x040023A9 RID: 9129
		[Token(Token = "0x40023A9")]
		[FieldOffset(Offset = "0x28")]
		public List<Cutscene> Cutscenes;

		// Token: 0x040023AA RID: 9130
		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Run cutscene by name")]
		private string cutsceneName;

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x38")]
		private Cutscene playingCutscene;
	}
}
