using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A11 RID: 2577
	[Token(Token = "0x2000A11")]
	[RequireComponent(typeof(Property))]
	public class PropertyTestTool : NetworkBehaviour
	{
		// Token: 0x06004997 RID: 18839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004997")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public PropertyTestTool()
		{
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004998")]
		[Address(RVA = "0x90D4D0", Offset = "0x90C6D0", VA = "0x18090D4D0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004999")]
		[Address(RVA = "0x755CD0", Offset = "0x754ED0", VA = "0x180755CD0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499A")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499B")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040033F9 RID: 13305
		[Token(Token = "0x40033F9")]
		[FieldOffset(Offset = "0x118")]
		public Property Property;

		// Token: 0x040033FA RID: 13306
		[Token(Token = "0x40033FA")]
		[FieldOffset(Offset = "0x120")]
		public TextAsset PropertyDataToLoad;

		// Token: 0x040033FB RID: 13307
		[Token(Token = "0x40033FB")]
		[FieldOffset(Offset = "0x128")]
		private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.PropertyTestToolAssembly-CSharp.dll_Excuted;

		// Token: 0x040033FC RID: 13308
		[Token(Token = "0x40033FC")]
		[FieldOffset(Offset = "0x129")]
		private bool NetworkInitialize__LateScheduleOne.DevUtilities.PropertyTestToolAssembly-CSharp.dll_Excuted;
	}
}
