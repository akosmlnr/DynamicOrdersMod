using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000817 RID: 2071
	[Token(Token = "0x2000817")]
	public class ACReplicator : MonoBehaviour
	{
		// Token: 0x060037AE RID: 14254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AE")]
		[Address(RVA = "0x7E11B0", Offset = "0x7E03B0", VA = "0x1807E11B0")]
		private void Start()
		{
		}

		// Token: 0x060037AF RID: 14255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037AF")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80", Slot = "4")]
		protected virtual void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x060037B0 RID: 14256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x7E0DC0", Offset = "0x7DFFC0", VA = "0x1807E0DC0")]
		public ACReplicator()
		{
		}

		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		[FieldOffset(Offset = "0x20")]
		public string propertyName;
	}
}
