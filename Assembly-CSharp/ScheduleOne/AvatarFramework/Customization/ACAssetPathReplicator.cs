using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000813 RID: 2067
	[Token(Token = "0x2000813")]
	public class ACAssetPathReplicator<T> : ACReplicator where T : global::UnityEngine.Object
	{
		// Token: 0x060037A7 RID: 14247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x060037A8 RID: 14248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A8")]
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x060037A9 RID: 14249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037A9")]
		public ACAssetPathReplicator()
		{
		}

		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		[FieldOffset(Offset = "0x0")]
		private ACSelection<T> selection;
	}
}
