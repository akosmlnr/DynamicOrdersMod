using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Product;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x02000A12 RID: 2578
	[Token(Token = "0x2000A12")]
	public class SceneUtility : MonoBehaviour
	{
		// Token: 0x0600499C RID: 18844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499C")]
		[Address(RVA = "0x90F910", Offset = "0x90EB10", VA = "0x18090F910")]
		[Button]
		public void ScanSceneForShaders()
		{
		}

		// Token: 0x0600499D RID: 18845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499D")]
		[Address(RVA = "0x90EF20", Offset = "0x90E120", VA = "0x18090EF20")]
		[Button]
		public void AddAffinityAndRandomise()
		{
		}

		// Token: 0x0600499E RID: 18846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499E")]
		[Address(RVA = "0x90F590", Offset = "0x90E790", VA = "0x18090F590")]
		[Button]
		public void RemoveAffinity()
		{
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600499F")]
		[Address(RVA = "0x90FDB0", Offset = "0x90EFB0", VA = "0x18090FDB0")]
		public SceneUtility()
		{
		}

		// Token: 0x040033FD RID: 13309
		[Token(Token = "0x40033FD")]
		[FieldOffset(Offset = "0x20")]
		[Header("Afinity Settings")]
		public EDrugType DrugAffinityToAdd;

		// Token: 0x040033FE RID: 13310
		[Token(Token = "0x40033FE")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 MinMaxAffinityRange;

		// Token: 0x040033FF RID: 13311
		[Token(Token = "0x40033FF")]
		[FieldOffset(Offset = "0x2C")]
		public bool UseCurrentHighestAffinityAsMax;

		// Token: 0x04003400 RID: 13312
		[Token(Token = "0x4003400")]
		[FieldOffset(Offset = "0x30")]
		[Header("Objects to Modify")]
		public List<Transform> SceneObjects;

		// Token: 0x04003401 RID: 13313
		[Token(Token = "0x4003401")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("Finding Shaders")]
		private Transform _rootObject;

		// Token: 0x04003402 RID: 13314
		[Token(Token = "0x4003402")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _showCountOnly;
	}
}
