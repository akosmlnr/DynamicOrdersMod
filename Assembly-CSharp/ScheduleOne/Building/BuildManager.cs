using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.Building
{
	// Token: 0x020007AF RID: 1967
	[Token(Token = "0x20007AF")]
	public class BuildManager : NetworkSingleton<BuildManager>
	{
		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x0600349C RID: 13468 RVA: 0x0000FD50 File Offset: 0x0000DF50
		// (set) Token: 0x0600349D RID: 13469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000858")]
		public bool isBuilding
		{
			[Token(Token = "0x600349C")]
			[Address(RVA = "0x511360", Offset = "0x510560", VA = "0x180511360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600349D")]
			[Address(RVA = "0x5A4540", Offset = "0x5A3740", VA = "0x1805A4540")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x0600349E RID: 13470 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600349F RID: 13471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000859")]
		public GameObject currentBuildHandler
		{
			[Token(Token = "0x600349E")]
			[Address(RVA = "0x57F820", Offset = "0x57EA20", VA = "0x18057F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600349F")]
			[Address(RVA = "0x57F870", Offset = "0x57EA70", VA = "0x18057F870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A0")]
		[Address(RVA = "0x786AE0", Offset = "0x785CE0", VA = "0x180786AE0")]
		public void StartBuilding(ItemInstance item)
		{
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A1")]
		[Address(RVA = "0x786E40", Offset = "0x786040", VA = "0x180786E40")]
		public void StopBuilding()
		{
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A2")]
		[Address(RVA = "0x7869A0", Offset = "0x785BA0", VA = "0x1807869A0")]
		public void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
		}

		// Token: 0x060034A3 RID: 13475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A3")]
		[Address(RVA = "0x786490", Offset = "0x785690", VA = "0x180786490")]
		public void DisableColliders(GameObject obj)
		{
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A4")]
		[Address(RVA = "0x786530", Offset = "0x785730", VA = "0x180786530")]
		public void DisableLights(GameObject obj)
		{
		}

		// Token: 0x060034A5 RID: 13477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A5")]
		[Address(RVA = "0x7867A0", Offset = "0x7859A0", VA = "0x1807867A0")]
		public void DisableNetworking(GameObject obj)
		{
		}

		// Token: 0x060034A6 RID: 13478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A6")]
		[Address(RVA = "0x786860", Offset = "0x785A60", VA = "0x180786860")]
		public void DisableSpriteRenderers(GameObject obj)
		{
		}

		// Token: 0x060034A7 RID: 13479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A7")]
		[Address(RVA = "0x7858E0", Offset = "0x784AE0", VA = "0x1807858E0")]
		public void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
		}

		// Token: 0x060034A8 RID: 13480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A8")]
		[Address(RVA = "0x786640", Offset = "0x785840", VA = "0x180786640")]
		public void DisableNavigation(GameObject obj)
		{
		}

		// Token: 0x060034A9 RID: 13481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034A9")]
		[Address(RVA = "0x7863F0", Offset = "0x7855F0", VA = "0x1807863F0")]
		public void DisableCanvases(GameObject obj)
		{
		}

		// Token: 0x060034AA RID: 13482 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034AA")]
		[Address(RVA = "0x785B50", Offset = "0x784D50", VA = "0x180785B50")]
		public GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "", [Optional] Action<GridItem> onBeforeSpawn)
		{
			return null;
		}

		// Token: 0x060034AB RID: 13483 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034AB")]
		[Address(RVA = "0x785E80", Offset = "0x785080", VA = "0x180785E80")]
		public ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			return null;
		}

		// Token: 0x060034AC RID: 13484 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60034AC")]
		[Address(RVA = "0x786110", Offset = "0x785310", VA = "0x180786110")]
		public SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			return null;
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034AD")]
		[Address(RVA = "0x786EB0", Offset = "0x7860B0", VA = "0x180786EB0")]
		public BuildManager()
		{
		}

		// Token: 0x060034AE RID: 13486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034AE")]
		[Address(RVA = "0x786950", Offset = "0x785B50", VA = "0x180786950", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060034AF RID: 13487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034AF")]
		[Address(RVA = "0x786900", Offset = "0x785B00", VA = "0x180786900", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B0")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034B1")]
		[Address(RVA = "0x785AE0", Offset = "0x784CE0", VA = "0x180785AE0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04002662 RID: 9826
		[Token(Token = "0x4002662")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public List<BuildManager.BuildSound> PlaceSounds;

		// Token: 0x04002663 RID: 9827
		[Token(Token = "0x4002663")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("Materials")]
		public Material ghostMaterial_White;

		// Token: 0x04002664 RID: 9828
		[Token(Token = "0x4002664")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public Material ghostMaterial_Red;

		// Token: 0x04002667 RID: 9831
		[Token(Token = "0x4002667")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool NetworkInitialize___EarlyScheduleOne.Building.BuildManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04002668 RID: 9832
		[Token(Token = "0x4002668")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		private bool NetworkInitialize__LateScheduleOne.Building.BuildManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x020007B0 RID: 1968
		[Token(Token = "0x20007B0")]
		[Serializable]
		public class BuildSound
		{
			// Token: 0x060034B2 RID: 13490 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60034B2")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public BuildSound()
			{
			}

			// Token: 0x04002669 RID: 9833
			[Token(Token = "0x4002669")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BuildableItemDefinition.EBuildSoundType Type;

			// Token: 0x0400266A RID: 9834
			[Token(Token = "0x400266A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AudioSourceController Sound;
		}
	}
}
