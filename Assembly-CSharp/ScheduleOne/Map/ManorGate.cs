using System;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.DevUtilities;
using ScheduleOne.Interaction;
using ScheduleOne.Tools;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000533 RID: 1331
	[Token(Token = "0x2000533")]
	public class ManorGate : Gate
	{
		// Token: 0x06001D6B RID: 7531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x623E60", Offset = "0x623060", VA = "0x180623E60", Slot = "22")]
		protected virtual void Start()
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x623F70", Offset = "0x623170", VA = "0x180623F70")]
		private void UpdateDetection()
		{
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x623C00", Offset = "0x622E00", VA = "0x180623C00")]
		public void IntercomBuzzed()
		{
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x623D60", Offset = "0x622F60", VA = "0x180623D60")]
		public void SetEnterable(bool enterable)
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x623B40", Offset = "0x622D40", VA = "0x180623B40")]
		[Button]
		public void ActivateIntercom()
		{
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x623E10", Offset = "0x623010", VA = "0x180623E10")]
		public void SetIntercomActive(bool active)
		{
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D71")]
		[Address(RVA = "0x6242A0", Offset = "0x6234A0", VA = "0x1806242A0")]
		private void UpdateIntercom()
		{
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D72")]
		[Address(RVA = "0x622B40", Offset = "0x621D40", VA = "0x180622B40")]
		public ManorGate()
		{
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D73")]
		[Address(RVA = "0x623C80", Offset = "0x622E80", VA = "0x180623C80", Slot = "19")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001D74 RID: 7540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x623C50", Offset = "0x622E50", VA = "0x180623C50", Slot = "20")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001D75 RID: 7541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D76")]
		[Address(RVA = "0x623B90", Offset = "0x622D90", VA = "0x180623B90", Slot = "21")]
		public override void Awake()
		{
		}

		// Token: 0x040018D6 RID: 6358
		[Token(Token = "0x40018D6")]
		[FieldOffset(Offset = "0x190")]
		[Header("References")]
		public InteractableObject IntercomInt;

		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x198")]
		public Light IntercomLight;

		// Token: 0x040018D8 RID: 6360
		[Token(Token = "0x40018D8")]
		[FieldOffset(Offset = "0x1A0")]
		public VehicleDetector ExteriorVehicleDetector;

		// Token: 0x040018D9 RID: 6361
		[Token(Token = "0x40018D9")]
		[FieldOffset(Offset = "0x1A8")]
		public PlayerDetector ExteriorPlayerDetector;

		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x1B0")]
		public VehicleDetector InteriorVehicleDetector;

		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x1B8")]
		public PlayerDetector InteriorPlayerDetector;

		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x1C0")]
		private bool intercomActive;

		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x1C1")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted;

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x1C2")]
		private bool NetworkInitialize__LateScheduleOne.Map.ManorGateAssembly-CSharp.dll_Excuted;
	}
}
