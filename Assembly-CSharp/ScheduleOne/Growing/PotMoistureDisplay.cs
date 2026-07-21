using System;
using Il2CppDummyDll;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	public class PotMoistureDisplay : GrowContainerMoistureDisplay
	{
		// Token: 0x06003B51 RID: 15185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B51")]
		[Address(RVA = "0x81A110", Offset = "0x819310", VA = "0x18081A110", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06003B52 RID: 15186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B52")]
		[Address(RVA = "0x81A210", Offset = "0x819410", VA = "0x18081A210", Slot = "5")]
		protected override void UpdateCanvasContents()
		{
		}

		// Token: 0x06003B53 RID: 15187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B53")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public PotMoistureDisplay()
		{
		}

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _temperatureBoostIndicator;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x60")]
		private Pot _pot;
	}
}
