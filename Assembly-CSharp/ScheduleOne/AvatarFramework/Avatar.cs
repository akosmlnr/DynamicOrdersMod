using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Animation;
using ScheduleOne.AvatarFramework.Emotions;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.AvatarFramework.Impostors;
using ScheduleOne.Core;
using ScheduleOne.Core.Equipping.Framework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x020007DD RID: 2013
	[Token(Token = "0x20007DD")]
	public class Avatar : MonoBehaviour, IThirdPersonReferencesProvider
	{
		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x0600361F RID: 13855 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000885")]
		public Transform RightHandContainer
		{
			[Token(Token = "0x600361F")]
			[Address(RVA = "0x7CAE10", Offset = "0x7CA010", VA = "0x1807CAE10", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000886")]
		public Transform LeftHandContainer
		{
			[Token(Token = "0x6003620")]
			[Address(RVA = "0x7CADD0", Offset = "0x7C9FD0", VA = "0x1807CADD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003621 RID: 13857 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000887")]
		public Transform RightHandAlignmentPoint
		{
			[Token(Token = "0x6003621")]
			[Address(RVA = "0x7CADF0", Offset = "0x7C9FF0", VA = "0x1807CADF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000888")]
		public Transform LeftHandAlignmentPoint
		{
			[Token(Token = "0x6003622")]
			[Address(RVA = "0x7CADB0", Offset = "0x7C9FB0", VA = "0x1807CADB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x000101B8 File Offset: 0x0000E3B8
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000889")]
		public bool Ragdolled
		{
			[Token(Token = "0x6003623")]
			[Address(RVA = "0x60E8B0", Offset = "0x60DAB0", VA = "0x18060E8B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003624")]
			[Address(RVA = "0x60E930", Offset = "0x60DB30", VA = "0x18060E930")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088A")]
		public AvatarEquippable CurrentEquippable
		{
			[Token(Token = "0x6003625")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003626")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700088B")]
		public AvatarSettings CurrentSettings
		{
			[Token(Token = "0x6003627")]
			[Address(RVA = "0x5887C0", Offset = "0x5879C0", VA = "0x1805887C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003628")]
			[Address(RVA = "0x6783D0", Offset = "0x6775D0", VA = "0x1806783D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x7C9480", Offset = "0x7C8680", VA = "0x1807C9480")]
		[Button]
		public void Load()
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x7C9460", Offset = "0x7C8660", VA = "0x1807C9460")]
		[Button]
		public void LoadNaked()
		{
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700088C")]
		public Transform CenterPointTransform
		{
			[Token(Token = "0x600362B")]
			[Address(RVA = "0x4B4790", Offset = "0x4B3990", VA = "0x1804B4790")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x1700088D")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x600362C")]
			[Address(RVA = "0x7CAD60", Offset = "0x7C9F60", VA = "0x1807CAD60")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x7C84E0", Offset = "0x7C76E0", VA = "0x1807C84E0", Slot = "10")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x7CABB0", Offset = "0x7C9DB0", VA = "0x1807CABB0", Slot = "11")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x7CAAB0", Offset = "0x7C9CB0", VA = "0x1807CAAB0")]
		public void SetVisible(bool vis)
		{
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x7C8770", Offset = "0x7C7970", VA = "0x1807C8770")]
		public void GetMugshot(Action<Texture2D> callback)
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x7C9CC0", Offset = "0x7C8EC0", VA = "0x1807C9CC0")]
		public void SetEmission(Color color)
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x7C8950", Offset = "0x7C7B50", VA = "0x1807C8950")]
		public bool IsMale()
		{
			return default(bool);
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x7C89E0", Offset = "0x7C7BE0", VA = "0x1807C89E0")]
		public bool IsWhite()
		{
			return default(bool);
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x7C86D0", Offset = "0x7C78D0", VA = "0x1807C86D0")]
		public string GetFormalAddress(bool capitalized = true)
		{
			return null;
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003635")]
		[Address(RVA = "0x7C8810", Offset = "0x7C7A10", VA = "0x1807C8810")]
		public string GetThirdPersonAddress(bool capitalized = true)
		{
			return null;
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003636")]
		[Address(RVA = "0x7C88B0", Offset = "0x7C7AB0", VA = "0x1807C88B0")]
		public string GetThirdPersonPronoun(bool capitalized = true)
		{
			return null;
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003637")]
		[Address(RVA = "0x7C9880", Offset = "0x7C8A80", VA = "0x1807C9880", Slot = "8")]
		public void SetAnimationBool(string name, bool value)
		{
		}

		// Token: 0x06003638 RID: 13880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003638")]
		[Address(RVA = "0x7C98A0", Offset = "0x7C8AA0", VA = "0x1807C98A0", Slot = "9")]
		public void SetAnimationTrigger(string name)
		{
		}

		// Token: 0x06003639 RID: 13881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003639")]
		[Address(RVA = "0x7C8100", Offset = "0x7C7300", VA = "0x1807C8100")]
		private void ApplyShapeKeys(float gender, float weight, bool bodyOnly = false)
		{
		}

		// Token: 0x0600363A RID: 13882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363A")]
		[Address(RVA = "0x7CA320", Offset = "0x7C9520", VA = "0x1807CA320")]
		private void SetFeetShrunk(bool shrink, float reduction)
		{
		}

		// Token: 0x0600363B RID: 13883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363B")]
		[Address(RVA = "0x7CAB10", Offset = "0x7C9D10", VA = "0x1807CAB10")]
		private void SetWearingHairBlockingAccessory(bool blocked)
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363C")]
		[Address(RVA = "0x7C8A80", Offset = "0x7C7C80", VA = "0x1807C8A80")]
		public void LoadAvatarSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363D")]
		[Address(RVA = "0x7C8EF0", Offset = "0x7C80F0", VA = "0x1807C8EF0")]
		public void LoadNakedSettings(AvatarSettings settings, int maxLayerOrder = 19)
		{
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363E")]
		[Address(RVA = "0x7C7620", Offset = "0x7C6820", VA = "0x1807C7620")]
		public void ApplyBodySettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600363F")]
		[Address(RVA = "0x6AAF00", Offset = "0x6AA100", VA = "0x1806AAF00")]
		public void SetAdditionalWeight(float weight)
		{
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003640")]
		[Address(RVA = "0x7C9870", Offset = "0x7C8A70", VA = "0x1807C9870")]
		public void SetAdditionalGender(float gender)
		{
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003641")]
		[Address(RVA = "0x7CA7B0", Offset = "0x7C99B0", VA = "0x1807CA7B0")]
		public void SetSkinColor(Color color)
		{
		}

		// Token: 0x06003642 RID: 13890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003642")]
		[Address(RVA = "0x7C7F10", Offset = "0x7C7110", VA = "0x1807C7F10")]
		public void ApplyHairSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06003643 RID: 13891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003643")]
		[Address(RVA = "0x7CA430", Offset = "0x7C9630", VA = "0x1807CA430")]
		public void SetHairVisible(bool visible)
		{
		}

		// Token: 0x06003644 RID: 13892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003644")]
		[Address(RVA = "0x7C7E10", Offset = "0x7C7010", VA = "0x1807C7E10")]
		public void ApplyHairColorSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003645")]
		[Address(RVA = "0x7C9490", Offset = "0x7C8690", VA = "0x1807C9490")]
		public void OverrideHairColor(Color color)
		{
		}

		// Token: 0x06003646 RID: 13894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003646")]
		[Address(RVA = "0x7C96E0", Offset = "0x7C88E0", VA = "0x1807C96E0")]
		public void ResetHairColor()
		{
		}

		// Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003647")]
		[Address(RVA = "0x7C76F0", Offset = "0x7C68F0", VA = "0x1807C76F0")]
		public void ApplyEyeBallSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003648")]
		[Address(RVA = "0x7C77E0", Offset = "0x7C69E0", VA = "0x1807C77E0")]
		public void ApplyEyeLidSettings(AvatarSettings settings)
		{
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003649")]
		[Address(RVA = "0x7C7760", Offset = "0x7C6960", VA = "0x1807C7760")]
		public void ApplyEyeLidColorSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364A")]
		[Address(RVA = "0x7C7860", Offset = "0x7C6A60", VA = "0x1807C7860")]
		public void ApplyEyebrowSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364B")]
		[Address(RVA = "0x7C98C0", Offset = "0x7C8AC0", VA = "0x1807C98C0")]
		public void SetBlockEyeFaceLayers(bool block)
		{
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364C")]
		[Address(RVA = "0x7C7880", Offset = "0x7C6A80", VA = "0x1807C7880")]
		public void ApplyFaceLayerSettings(AvatarSettings settings)
		{
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364D")]
		[Address(RVA = "0x7C9FF0", Offset = "0x7C91F0", VA = "0x1807C9FF0")]
		private void SetFaceLayer(int index, string assetPath, Color color)
		{
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364E")]
		[Address(RVA = "0x7CA1E0", Offset = "0x7C93E0", VA = "0x1807CA1E0")]
		public void SetFaceTexture(Texture2D tex, Color color)
		{
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600364F")]
		[Address(RVA = "0x7C7030", Offset = "0x7C6230", VA = "0x1807C7030")]
		public void ApplyBodyLayerSettings(AvatarSettings settings, int maxOrder = -1)
		{
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003650")]
		[Address(RVA = "0x7C9940", Offset = "0x7C8B40", VA = "0x1807C9940")]
		private void SetBodyLayer(int index, string assetPath, Color color)
		{
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003651")]
		[Address(RVA = "0x7C6740", Offset = "0x7C5940", VA = "0x1807C6740")]
		public void ApplyAccessorySettings(AvatarSettings settings)
		{
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003652")]
		[Address(RVA = "0x7C85B0", Offset = "0x7C77B0", VA = "0x1807C85B0")]
		private void DestroyAccessories()
		{
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003653")]
		[Address(RVA = "0x7CA4D0", Offset = "0x7C96D0", VA = "0x1807CA4D0", Slot = "12")]
		public virtual void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6003654")]
		[Address(RVA = "0x7C9DD0", Offset = "0x7C8FD0", VA = "0x1807C9DD0", Slot = "13")]
		public virtual AvatarEquippable SetEquippable(string assetPath)
		{
			return null;
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003655")]
		[Address(RVA = "0x7C95F0", Offset = "0x7C87F0", VA = "0x1807C95F0", Slot = "14")]
		public virtual void ReceiveEquippableMessage(string message, object data)
		{
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003656")]
		[Address(RVA = "0x7CACB0", Offset = "0x7C9EB0", VA = "0x1807CACB0")]
		public Avatar()
		{
		}

		// Token: 0x04002721 RID: 10017
		[Token(Token = "0x4002721")]
		public const int MAX_ACCESSORIES = 9;

		// Token: 0x04002722 RID: 10018
		[Token(Token = "0x4002722")]
		public const bool CombinedLayersEnabled = true;

		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		public const float DEFAULT_SMOOTHNESS = 0.25f;

		// Token: 0x04002724 RID: 10020
		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x0")]
		private static float maleShoulderScale;

		// Token: 0x04002725 RID: 10021
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x4")]
		private static float femaleShoulderScale;

		// Token: 0x04002726 RID: 10022
		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x20")]
		[Header("References")]
		public AvatarAnimation Animation;

		// Token: 0x04002727 RID: 10023
		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0x28")]
		public AvatarLookController LookController;

		// Token: 0x04002728 RID: 10024
		[Token(Token = "0x4002728")]
		[FieldOffset(Offset = "0x30")]
		public SkinnedMeshRenderer[] BodyMeshes;

		// Token: 0x04002729 RID: 10025
		[Token(Token = "0x4002729")]
		[FieldOffset(Offset = "0x38")]
		public SkinnedMeshRenderer[] ShapeKeyMeshes;

		// Token: 0x0400272A RID: 10026
		[Token(Token = "0x400272A")]
		[FieldOffset(Offset = "0x40")]
		public SkinnedMeshRenderer FaceMesh;

		// Token: 0x0400272B RID: 10027
		[Token(Token = "0x400272B")]
		[FieldOffset(Offset = "0x48")]
		public EyeController Eyes;

		// Token: 0x0400272C RID: 10028
		[Token(Token = "0x400272C")]
		[FieldOffset(Offset = "0x50")]
		public EyebrowController EyeBrows;

		// Token: 0x0400272D RID: 10029
		[Token(Token = "0x400272D")]
		[FieldOffset(Offset = "0x58")]
		public Transform BodyContainer;

		// Token: 0x0400272E RID: 10030
		[Token(Token = "0x400272E")]
		[FieldOffset(Offset = "0x60")]
		public Transform Armature;

		// Token: 0x0400272F RID: 10031
		[Token(Token = "0x400272F")]
		[FieldOffset(Offset = "0x68")]
		public Transform LeftShoulder;

		// Token: 0x04002730 RID: 10032
		[Token(Token = "0x4002730")]
		[FieldOffset(Offset = "0x70")]
		public Transform RightShoulder;

		// Token: 0x04002731 RID: 10033
		[Token(Token = "0x4002731")]
		[FieldOffset(Offset = "0x78")]
		public Transform HeadBone;

		// Token: 0x04002732 RID: 10034
		[Token(Token = "0x4002732")]
		[FieldOffset(Offset = "0x80")]
		public Transform HipBone;

		// Token: 0x04002733 RID: 10035
		[Token(Token = "0x4002733")]
		[FieldOffset(Offset = "0x88")]
		public Transform LeftFootBone;

		// Token: 0x04002734 RID: 10036
		[Token(Token = "0x4002734")]
		[FieldOffset(Offset = "0x90")]
		public Transform RightFootBone;

		// Token: 0x04002735 RID: 10037
		[Token(Token = "0x4002735")]
		[FieldOffset(Offset = "0x98")]
		public Rigidbody[] RagdollRBs;

		// Token: 0x04002736 RID: 10038
		[Token(Token = "0x4002736")]
		[FieldOffset(Offset = "0xA0")]
		public Collider[] RagdollColliders;

		// Token: 0x04002737 RID: 10039
		[Token(Token = "0x4002737")]
		[FieldOffset(Offset = "0xA8")]
		public Rigidbody MiddleSpineRB;

		// Token: 0x04002738 RID: 10040
		[Token(Token = "0x4002738")]
		[FieldOffset(Offset = "0xB0")]
		public Rigidbody[] ImpactForceRBs;

		// Token: 0x04002739 RID: 10041
		[Token(Token = "0x4002739")]
		[FieldOffset(Offset = "0xB8")]
		public AvatarEmotionManager EmotionManager;

		// Token: 0x0400273A RID: 10042
		[Token(Token = "0x400273A")]
		[FieldOffset(Offset = "0xC0")]
		public AvatarEffects Effects;

		// Token: 0x0400273B RID: 10043
		[Token(Token = "0x400273B")]
		[FieldOffset(Offset = "0xC8")]
		public Transform MiddleSpine;

		// Token: 0x0400273C RID: 10044
		[Token(Token = "0x400273C")]
		[FieldOffset(Offset = "0xD0")]
		public Transform LowerSpine;

		// Token: 0x0400273D RID: 10045
		[Token(Token = "0x400273D")]
		[FieldOffset(Offset = "0xD8")]
		public Transform LowestSpine;

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0xE0")]
		public AvatarImpostor Impostor;

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0xE8")]
		public ParticleSystem BloodParticles;

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0xF0")]
		[Header("Settings")]
		public AvatarSettings InitialAvatarSettings;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0xF8")]
		public Material DefaultAvatarMaterial;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x100")]
		public bool UseCombinedLayer;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x108")]
		public UnityEvent<bool, bool, bool> onRagdollChange;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Header("Data - readonly")]
		protected float appliedGender;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		protected float appliedWeight;

		// Token: 0x04002748 RID: 10056
		[Token(Token = "0x4002748")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected Hair appliedHair;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		protected Color appliedHairColor;

		// Token: 0x0400274A RID: 10058
		[Token(Token = "0x400274A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		protected Accessory[] appliedAccessories;

		// Token: 0x0400274B RID: 10059
		[Token(Token = "0x400274B")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected bool wearingHairBlockingAccessory;

		// Token: 0x0400274C RID: 10060
		[Token(Token = "0x400274C")]
		[FieldOffset(Offset = "0x14C")]
		private float additionalWeight;

		// Token: 0x0400274D RID: 10061
		[Token(Token = "0x400274D")]
		[FieldOffset(Offset = "0x150")]
		private float additionalGender;

		// Token: 0x0400274F RID: 10063
		[Token(Token = "0x400274F")]
		[FieldOffset(Offset = "0x160")]
		[Header("Runtime loading")]
		public AvatarSettings SettingsToLoad;

		// Token: 0x04002750 RID: 10064
		[Token(Token = "0x4002750")]
		[FieldOffset(Offset = "0x168")]
		public UnityEvent onSettingsLoaded;

		// Token: 0x04002751 RID: 10065
		[Token(Token = "0x4002751")]
		[FieldOffset(Offset = "0x170")]
		private Vector3 originalHipPos;

		// Token: 0x04002752 RID: 10066
		[Token(Token = "0x4002752")]
		[FieldOffset(Offset = "0x17C")]
		private bool usingCombinedLayer;

		// Token: 0x04002753 RID: 10067
		[Token(Token = "0x4002753")]
		[FieldOffset(Offset = "0x17D")]
		private bool blockEyeFaceLayers;
	}
}
