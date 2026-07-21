using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x0200038B RID: 907
	[Token(Token = "0x200038B")]
	public class ApplyShroomSpawnTask : Task
	{
		// Token: 0x060016D9 RID: 5849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016D9")]
		[Address(RVA = "0x5B3660", Offset = "0x5B2860", VA = "0x1805B3660")]
		public ApplyShroomSpawnTask(MushroomBed mushroomBed, ShroomSpawnDefinition spawnDefinition)
		{
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DA")]
		[Address(RVA = "0x5B2700", Offset = "0x5B1900", VA = "0x1805B2700", Slot = "6")]
		public override void StopTask()
		{
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DB")]
		[Address(RVA = "0x5B2A80", Offset = "0x5B1C80", VA = "0x1805B2A80", Slot = "7")]
		public override void Success()
		{
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DC")]
		[Address(RVA = "0x5B35C0", Offset = "0x5B27C0", VA = "0x1805B35C0", Slot = "9")]
		public override void Update()
		{
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DD")]
		[Address(RVA = "0x5B2250", Offset = "0x5B1450", VA = "0x1805B2250", Slot = "11")]
		public override void LateUpdate()
		{
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DE")]
		[Address(RVA = "0x5B31E0", Offset = "0x5B23E0", VA = "0x1805B31E0")]
		private void UpdateInstructionText()
		{
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016DF")]
		[Address(RVA = "0x5B33C0", Offset = "0x5B25C0", VA = "0x1805B33C0")]
		private void UpdateProgression()
		{
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x60016E0")]
		[Address(RVA = "0x5B1EB0", Offset = "0x5B10B0", VA = "0x1805B1EB0")]
		private bool GetCursorHoverOnSoil(out Vector3 hitPoint)
		{
			return default(bool);
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E1")]
		[Address(RVA = "0x5B2CB0", Offset = "0x5B1EB0", VA = "0x1805B2CB0")]
		private void TriggerMix(Vector3 mixPoint)
		{
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016E2")]
		[Address(RVA = "0x5B2500", Offset = "0x5B1700", VA = "0x1805B2500")]
		private void PaintMask(int x, int y)
		{
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60016E3")]
		[Address(RVA = "0x5B1DE0", Offset = "0x5B0FE0", VA = "0x1805B1DE0")]
		private Texture2D CreateMaskTexture()
		{
			return null;
		}

		// Token: 0x04001424 RID: 5156
		[Token(Token = "0x4001424")]
		private const float DistanceBetweenMixes = 0.08f;

		// Token: 0x04001425 RID: 5157
		[Token(Token = "0x4001425")]
		private const float MixRadius = 0.1f;

		// Token: 0x04001426 RID: 5158
		[Token(Token = "0x4001426")]
		private const int MaskTextureSize = 128;

		// Token: 0x04001427 RID: 5159
		[Token(Token = "0x4001427")]
		private const int SmallChunkCount = 16;

		// Token: 0x04001428 RID: 5160
		[Token(Token = "0x4001428")]
		[FieldOffset(Offset = "0xA0")]
		private ShroomSpawnDefinition _spawnDefinition;

		// Token: 0x04001429 RID: 5161
		[Token(Token = "0x4001429")]
		[FieldOffset(Offset = "0xA8")]
		private MushroomBed _mushroomBed;

		// Token: 0x0400142A RID: 5162
		[Token(Token = "0x400142A")]
		[FieldOffset(Offset = "0xB0")]
		private SpawnChunk _baseSpawnChunk;

		// Token: 0x0400142B RID: 5163
		[Token(Token = "0x400142B")]
		[FieldOffset(Offset = "0xB8")]
		private ApplyShroomSpawnTask.EStage _currentStage;

		// Token: 0x0400142C RID: 5164
		[Token(Token = "0x400142C")]
		[FieldOffset(Offset = "0xC0")]
		private DecalProjector _mixProjector;

		// Token: 0x0400142D RID: 5165
		[Token(Token = "0x400142D")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 _lastMixPosition;

		// Token: 0x0400142E RID: 5166
		[Token(Token = "0x400142E")]
		[FieldOffset(Offset = "0xD8")]
		private Texture2D _maskingTexture;

		// Token: 0x0400142F RID: 5167
		[Token(Token = "0x400142F")]
		[FieldOffset(Offset = "0xE0")]
		private List<SpawnChunk> _mixedChunks;

		// Token: 0x04001430 RID: 5168
		[Token(Token = "0x4001430")]
		[FieldOffset(Offset = "0xE8")]
		private bool _mixMouseUp;

		// Token: 0x0200038C RID: 908
		[Token(Token = "0x200038C")]
		private enum EStage
		{
			// Token: 0x04001432 RID: 5170
			[Token(Token = "0x4001432")]
			BreakUpChunks,
			// Token: 0x04001433 RID: 5171
			[Token(Token = "0x4001433")]
			MixIntoSoil
		}
	}
}
