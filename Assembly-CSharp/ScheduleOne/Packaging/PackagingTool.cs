using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Product;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Packaging
{
	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	public class PackagingTool : MonoBehaviour
	{
		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06003A18 RID: 14872 RVA: 0x00010F68 File Offset: 0x0000F168
		// (set) Token: 0x06003A19 RID: 14873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000916")]
		public bool ReceiveInput
		{
			[Token(Token = "0x6003A18")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003A19")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1A")]
		[Address(RVA = "0x809020", Offset = "0x808220", VA = "0x180809020")]
		public void Initialize(Task _task, FunctionalPackaging packaging, int packagingQuantity, ProductItemInstance product, int productQuantity)
		{
		}

		// Token: 0x06003A1B RID: 14875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1B")]
		[Address(RVA = "0x8081B0", Offset = "0x8073B0", VA = "0x1808081B0")]
		public void Deinitialize()
		{
		}

		// Token: 0x06003A1C RID: 14876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1C")]
		[Address(RVA = "0x809360", Offset = "0x808560", VA = "0x180809360")]
		private void LoadPackaging(FunctionalPackaging prefab, int quantity)
		{
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1D")]
		[Address(RVA = "0x8096A0", Offset = "0x8088A0", VA = "0x1808096A0")]
		private void UnloadPackaging()
		{
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1E")]
		[Address(RVA = "0x8093A0", Offset = "0x8085A0", VA = "0x1808093A0")]
		private void LoadProduct(ProductItemInstance product, int quantity)
		{
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A1F")]
		[Address(RVA = "0x8096E0", Offset = "0x8088E0", VA = "0x1808096E0")]
		private void UnloadProduct()
		{
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A20")]
		[Address(RVA = "0x809B00", Offset = "0x808D00", VA = "0x180809B00")]
		public void Update()
		{
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A21")]
		[Address(RVA = "0x809850", Offset = "0x808A50", VA = "0x180809850")]
		private void UpdateInput()
		{
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A22")]
		[Address(RVA = "0x809A80", Offset = "0x808C80", VA = "0x180809A80")]
		private void UpdateScreen()
		{
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A23")]
		[Address(RVA = "0x809780", Offset = "0x808980", VA = "0x180809780")]
		private void UpdateConveyor()
		{
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A24")]
		[Address(RVA = "0x809490", Offset = "0x808690", VA = "0x180809490")]
		private void Rotate(float angle)
		{
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A25")]
		[Address(RVA = "0x807D60", Offset = "0x806F60", VA = "0x180807D60")]
		private void CheckDeployPackaging()
		{
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A26")]
		[Address(RVA = "0x807E20", Offset = "0x807020", VA = "0x180807E20")]
		private void CheckFinalize()
		{
		}

		// Token: 0x06003A27 RID: 14887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A27")]
		[Address(RVA = "0x808F10", Offset = "0x808110", VA = "0x180808F10")]
		private void Finalize(PackagingTool.PackagingInstance instance)
		{
		}

		// Token: 0x06003A28 RID: 14888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A28")]
		[Address(RVA = "0x808C40", Offset = "0x807E40", VA = "0x180808C40")]
		private void DropProduct()
		{
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A29")]
		[Address(RVA = "0x807F90", Offset = "0x807190", VA = "0x180807F90")]
		private void CheckInsertions()
		{
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2A")]
		[Address(RVA = "0x809290", Offset = "0x808490", VA = "0x180809290")]
		private void InsertIntoHopper(FunctionalProduct product)
		{
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2B")]
		[Address(RVA = "0x808620", Offset = "0x807820", VA = "0x180808620")]
		private void DeployPackaging()
		{
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003A2C")]
		[Address(RVA = "0x809EC0", Offset = "0x8090C0", VA = "0x180809EC0")]
		public PackagingTool()
		{
		}

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		private const float FinalizeRange_Min = 255f;

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		private const float FinalizeRange_Max = 270f;

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x24")]
		[Header("Settings")]
		public float ConveyorSpeed;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x28")]
		public float ConveyorAcceleration;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x2C")]
		public float BaggieRadius;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x30")]
		public float JarRadius;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x34")]
		public float DeployAngle;

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x38")]
		public float ProductInitialForce;

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x3C")]
		public float ProductRandomTorque;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x40")]
		public float KickForce;

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x44")]
		public float DropCooldown;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x48")]
		[Header("References")]
		public PackagingStation Station;

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x50")]
		public Transform ConveyorModel;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		[FieldOffset(Offset = "0x58")]
		public Animation DoorAnim;

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x60")]
		public Animation CapAnim;

		// Token: 0x04002AE7 RID: 10983
		[Token(Token = "0x4002AE7")]
		[FieldOffset(Offset = "0x68")]
		public Animation SealAnim;

		// Token: 0x04002AE8 RID: 10984
		[Token(Token = "0x4002AE8")]
		[FieldOffset(Offset = "0x70")]
		public Animation KickAnim;

		// Token: 0x04002AE9 RID: 10985
		[Token(Token = "0x4002AE9")]
		[FieldOffset(Offset = "0x78")]
		public Clickable LeftButton;

		// Token: 0x04002AEA RID: 10986
		[Token(Token = "0x4002AEA")]
		[FieldOffset(Offset = "0x80")]
		public Clickable RightButton;

		// Token: 0x04002AEB RID: 10987
		[Token(Token = "0x4002AEB")]
		[FieldOffset(Offset = "0x88")]
		public Clickable DropButton;

		// Token: 0x04002AEC RID: 10988
		[Token(Token = "0x4002AEC")]
		[FieldOffset(Offset = "0x90")]
		public Transform PackagingContainer;

		// Token: 0x04002AED RID: 10989
		[Token(Token = "0x4002AED")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshPro ProductCountText;

		// Token: 0x04002AEE RID: 10990
		[Token(Token = "0x4002AEE")]
		[FieldOffset(Offset = "0xA0")]
		public Transform HopperDropPoint;

		// Token: 0x04002AEF RID: 10991
		[Token(Token = "0x4002AEF")]
		[FieldOffset(Offset = "0xA8")]
		public Transform BaggieStartPoint;

		// Token: 0x04002AF0 RID: 10992
		[Token(Token = "0x4002AF0")]
		[FieldOffset(Offset = "0xB0")]
		public Transform JarStartPoint;

		// Token: 0x04002AF1 RID: 10993
		[Token(Token = "0x4002AF1")]
		[FieldOffset(Offset = "0xB8")]
		public Transform ProductContainer;

		// Token: 0x04002AF2 RID: 10994
		[Token(Token = "0x4002AF2")]
		[FieldOffset(Offset = "0xC0")]
		public Transform KickOrigin;

		// Token: 0x04002AF3 RID: 10995
		[Token(Token = "0x4002AF3")]
		[FieldOffset(Offset = "0xC8")]
		public SphereCollider HopperInputCollider;

		// Token: 0x04002AF4 RID: 10996
		[Token(Token = "0x4002AF4")]
		[FieldOffset(Offset = "0xD0")]
		public AudioSourceController KickSound;

		// Token: 0x04002AF5 RID: 10997
		[Token(Token = "0x4002AF5")]
		[FieldOffset(Offset = "0xD8")]
		public AudioSourceController MotorSound;

		// Token: 0x04002AF6 RID: 10998
		[Token(Token = "0x4002AF6")]
		[FieldOffset(Offset = "0xE0")]
		public AudioSourceController DropSound;

		// Token: 0x04002AF7 RID: 10999
		[Token(Token = "0x4002AF7")]
		[FieldOffset(Offset = "0xE8")]
		private FunctionalPackaging PackagingPrefab;

		// Token: 0x04002AF8 RID: 11000
		[Token(Token = "0x4002AF8")]
		[FieldOffset(Offset = "0xF0")]
		private int ConcealedPackaging;

		// Token: 0x04002AF9 RID: 11001
		[Token(Token = "0x4002AF9")]
		[FieldOffset(Offset = "0xF8")]
		private ProductItemInstance ProductItem;

		// Token: 0x04002AFA RID: 11002
		[Token(Token = "0x4002AFA")]
		[FieldOffset(Offset = "0x100")]
		private FunctionalProduct ProductPrefab;

		// Token: 0x04002AFB RID: 11003
		[Token(Token = "0x4002AFB")]
		[FieldOffset(Offset = "0x108")]
		private int ProductInHopper;

		// Token: 0x04002AFC RID: 11004
		[Token(Token = "0x4002AFC")]
		[FieldOffset(Offset = "0x110")]
		private List<PackagingTool.PackagingInstance> PackagingInstances;

		// Token: 0x04002AFD RID: 11005
		[Token(Token = "0x4002AFD")]
		[FieldOffset(Offset = "0x118")]
		private List<FunctionalProduct> ProductInstances;

		// Token: 0x04002AFE RID: 11006
		[Token(Token = "0x4002AFE")]
		[FieldOffset(Offset = "0x120")]
		private List<FunctionalPackaging> FinalizedPackaging;

		// Token: 0x04002AFF RID: 11007
		[Token(Token = "0x4002AFF")]
		[FieldOffset(Offset = "0x128")]
		private float conveyorVelocity;

		// Token: 0x04002B00 RID: 11008
		[Token(Token = "0x4002B00")]
		[FieldOffset(Offset = "0x12C")]
		private int directionInput;

		// Token: 0x04002B01 RID: 11009
		[Token(Token = "0x4002B01")]
		[FieldOffset(Offset = "0x130")]
		private Task task;

		// Token: 0x04002B02 RID: 11010
		[Token(Token = "0x4002B02")]
		[FieldOffset(Offset = "0x138")]
		private PackagingTool.PackagingInstance finalizeInstance;

		// Token: 0x04002B03 RID: 11011
		[Token(Token = "0x4002B03")]
		[FieldOffset(Offset = "0x140")]
		private Coroutine finalizeCoroutine;

		// Token: 0x04002B04 RID: 11012
		[Token(Token = "0x4002B04")]
		[FieldOffset(Offset = "0x148")]
		private bool leftDown;

		// Token: 0x04002B05 RID: 11013
		[Token(Token = "0x4002B05")]
		[FieldOffset(Offset = "0x149")]
		private bool rightDown;

		// Token: 0x04002B06 RID: 11014
		[Token(Token = "0x4002B06")]
		[FieldOffset(Offset = "0x14A")]
		private bool dropDown;

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x14C")]
		private float timeSinceLastDrop;

		// Token: 0x0200089F RID: 2207
		[Token(Token = "0x200089F")]
		public class PackagingInstance
		{
			// Token: 0x06003A2D RID: 14893 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A2D")]
			[Address(RVA = "0x8078C0", Offset = "0x806AC0", VA = "0x1808078C0")]
			public void ChangePosition(float angleDelta)
			{
			}

			// Token: 0x06003A2E RID: 14894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003A2E")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public PackagingInstance()
			{
			}

			// Token: 0x04002B08 RID: 11016
			[Token(Token = "0x4002B08")]
			[FieldOffset(Offset = "0x10")]
			public Transform Container;

			// Token: 0x04002B09 RID: 11017
			[Token(Token = "0x4002B09")]
			[FieldOffset(Offset = "0x18")]
			public Rigidbody ContainerRb;

			// Token: 0x04002B0A RID: 11018
			[Token(Token = "0x4002B0A")]
			[FieldOffset(Offset = "0x20")]
			public FunctionalPackaging Packaging;

			// Token: 0x04002B0B RID: 11019
			[Token(Token = "0x4002B0B")]
			[FieldOffset(Offset = "0x28")]
			public float AnglePosition;
		}
	}
}
