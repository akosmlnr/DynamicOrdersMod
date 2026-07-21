using System;
using Il2CppDummyDll;
using ScheduleOne.EntityFramework;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000983 RID: 2435
	[Token(Token = "0x2000983")]
	public class BedItem : PlaceableStorageEntity
	{
		// Token: 0x06004147 RID: 16711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004147")]
		[Address(RVA = "0x86CE40", Offset = "0x86C040", VA = "0x18086CE40", Slot = "48")]
		protected override void Start()
		{
		}

		// Token: 0x06004148 RID: 16712 RVA: 0x00012798 File Offset: 0x00010998
		[Token(Token = "0x6004148")]
		[Address(RVA = "0x86CC90", Offset = "0x86BE90", VA = "0x18086CC90")]
		public static bool IsBedValid(BuildableItem obj, out string reason)
		{
			return default(bool);
		}

		// Token: 0x06004149 RID: 16713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004149")]
		[Address(RVA = "0x86CF00", Offset = "0x86C100", VA = "0x18086CF00")]
		private void UpdateBriefcase()
		{
		}

		// Token: 0x0600414A RID: 16714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414A")]
		[Address(RVA = "0x86D300", Offset = "0x86C500", VA = "0x18086D300")]
		public BedItem()
		{
		}

		// Token: 0x0600414B RID: 16715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414B")]
		[Address(RVA = "0x86CE20", Offset = "0x86C020", VA = "0x18086CE20", Slot = "63")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600414C RID: 16716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414C")]
		[Address(RVA = "0x86CE00", Offset = "0x86C000", VA = "0x18086CE00", Slot = "64")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600414D RID: 16717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414D")]
		[Address(RVA = "0x6D5660", Offset = "0x6D4860", VA = "0x1806D5660", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600414E RID: 16718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600414E")]
		[Address(RVA = "0x86CC40", Offset = "0x86BE40", VA = "0x18086CC40", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04002F83 RID: 12163
		[Token(Token = "0x4002F83")]
		[FieldOffset(Offset = "0x2A0")]
		public Bed Bed;

		// Token: 0x04002F84 RID: 12164
		[Token(Token = "0x4002F84")]
		[FieldOffset(Offset = "0x2A8")]
		public StorageEntity Storage;

		// Token: 0x04002F85 RID: 12165
		[Token(Token = "0x4002F85")]
		[FieldOffset(Offset = "0x2B0")]
		public GameObject Briefcase;

		// Token: 0x04002F86 RID: 12166
		[Token(Token = "0x4002F86")]
		[FieldOffset(Offset = "0x2B8")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted;

		// Token: 0x04002F87 RID: 12167
		[Token(Token = "0x4002F87")]
		[FieldOffset(Offset = "0x2B9")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted;
	}
}
