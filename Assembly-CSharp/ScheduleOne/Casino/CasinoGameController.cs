using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700080B")]
		public bool IsOpen
		{
			[Token(Token = "0x6003169")]
			[Address(RVA = "0x51C070", Offset = "0x51B270", VA = "0x18051C070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600316A")]
			[Address(RVA = "0x61FCB0", Offset = "0x61EEB0", VA = "0x18061FCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700080C")]
		public CasinoGamePlayerData LocalPlayerData
		{
			[Token(Token = "0x600316B")]
			[Address(RVA = "0x758810", Offset = "0x757A10", VA = "0x180758810")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316C")]
		[Address(RVA = "0x757C00", Offset = "0x756E00", VA = "0x180757C00", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316D")]
		[Address(RVA = "0x758260", Offset = "0x757460", VA = "0x180758260", Slot = "20")]
		protected virtual void OnLocalPlayerRequestJoin(Player player)
		{
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316E")]
		[Address(RVA = "0x7581C0", Offset = "0x7573C0", VA = "0x1807581C0", Slot = "21")]
		protected virtual void Exit(ExitAction action)
		{
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600316F")]
		[Address(RVA = "0x758280", Offset = "0x757480", VA = "0x180758280", Slot = "22")]
		protected virtual void Open()
		{
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003170")]
		[Address(RVA = "0x757D90", Offset = "0x756F90", VA = "0x180757D90", Slot = "23")]
		protected virtual void Close()
		{
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003171")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public CasinoGameController()
		{
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003172")]
		[Address(RVA = "0x758240", Offset = "0x757440", VA = "0x180758240", Slot = "24")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003173")]
		[Address(RVA = "0x758220", Offset = "0x757420", VA = "0x180758220", Slot = "25")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003174")]
		[Address(RVA = "0x751DC0", Offset = "0x750FC0", VA = "0x180751DC0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003175")]
		[Address(RVA = "0x757AA0", Offset = "0x756CA0", VA = "0x180757AA0", Slot = "26")]
		protected virtual void Awake_UserLogic_ScheduleOne.Casino.CasinoGameController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		public const float FOV = 65f;

		// Token: 0x04002466 RID: 9318
		[Token(Token = "0x4002466")]
		public const float CAMERA_LERP_TIME = 0.2f;

		// Token: 0x04002468 RID: 9320
		[Token(Token = "0x4002468")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public CasinoGamePlayers Players;

		// Token: 0x04002469 RID: 9321
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x128")]
		public CasinoGameInteraction Interaction;

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x130")]
		public Transform[] DefaultCameraTransforms;

		// Token: 0x0400246B RID: 9323
		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x138")]
		protected Transform localDefaultCameraTransform;

		// Token: 0x0400246C RID: 9324
		[Token(Token = "0x400246C")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400246D RID: 9325
		[Token(Token = "0x400246D")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted;
	}
}
