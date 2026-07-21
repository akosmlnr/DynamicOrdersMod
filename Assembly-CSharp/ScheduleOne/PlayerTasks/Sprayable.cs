using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	// Token: 0x02000386 RID: 902
	[Token(Token = "0x2000386")]
	public class Sprayable : Draggable
	{
		// Token: 0x060016AE RID: 5806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AE")]
		[Address(RVA = "0x5C3970", Offset = "0x5C2B70", VA = "0x1805C3970")]
		public void Initialise(float sprayRadius, float sprayDistance)
		{
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016AF")]
		[Address(RVA = "0x5C3DC0", Offset = "0x5C2FC0", VA = "0x1805C3DC0", Slot = "10")]
		protected override void Update()
		{
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B0")]
		[Address(RVA = "0x5C3A10", Offset = "0x5C2C10", VA = "0x1805C3A10")]
		private void Spray()
		{
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B1")]
		[Address(RVA = "0x5C39F0", Offset = "0x5C2BF0", VA = "0x1805C39F0")]
		public void SetCurrentTarget(Vector3 position)
		{
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x60016B2")]
		[Address(RVA = "0x5C3880", Offset = "0x5C2A80", VA = "0x1805C3880")]
		private bool DoesHitTarget(Vector3 rayOrigin, Vector3 rayDirection, Vector3 sphereCenter, float sphereRadius, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B3")]
		[Address(RVA = "0x5C3C60", Offset = "0x5C2E60", VA = "0x1805C3C60")]
		public void SubscribeToSuccessfulSpray(Action callback)
		{
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B4")]
		[Address(RVA = "0x5C3D10", Offset = "0x5C2F10", VA = "0x1805C3D10")]
		public void UnsubscribeFromSuccessfulSpray(Action callback)
		{
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B5")]
		[Address(RVA = "0x5C3990", Offset = "0x5C2B90", VA = "0x1805C3990")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60016B6")]
		[Address(RVA = "0x5C3E50", Offset = "0x5C3050", VA = "0x1805C3E50")]
		public Sprayable()
		{
		}

		// Token: 0x040013FE RID: 5118
		[Token(Token = "0x40013FE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("Sprayable Components")]
		private Transform _sprayOrigin;

		// Token: 0x040013FF RID: 5119
		[Token(Token = "0x40013FF")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Header("Gizmos")]
		private bool _drawGizmos;

		// Token: 0x04001400 RID: 5120
		[Token(Token = "0x4001400")]
		[FieldOffset(Offset = "0xD0")]
		public Action _onSuccessfulSpray;

		// Token: 0x04001401 RID: 5121
		[Token(Token = "0x4001401")]
		[FieldOffset(Offset = "0xD8")]
		public UnityEvent onSpray;

		// Token: 0x04001402 RID: 5122
		[Token(Token = "0x4001402")]
		[FieldOffset(Offset = "0xE0")]
		private float _sprayRadius;

		// Token: 0x04001403 RID: 5123
		[Token(Token = "0x4001403")]
		[FieldOffset(Offset = "0xE4")]
		private float _sprayDistance;

		// Token: 0x04001404 RID: 5124
		[Token(Token = "0x4001404")]
		[FieldOffset(Offset = "0xE8")]
		private Vector3 _currentTargetPosition;
	}
}
