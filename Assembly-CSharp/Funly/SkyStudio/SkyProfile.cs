using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	[CreateAssetMenu(fileName = "skyProfile.asset", menuName = "Sky Studio/Sky Profile", order = 0)]
	public class SkyProfile : ScriptableObject
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		public Material skyboxMaterial
		{
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x8E38E0", Offset = "0x8E2AE0", VA = "0x1808E38E0")]
			set
			{
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001CD")]
		public string shaderName
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001CE")]
		public ProfileGroupSection[] groupDefinitions
		{
			[Token(Token = "0x6000905")]
			[Address(RVA = "0x8E3810", Offset = "0x8E2A10", VA = "0x1808E3810")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170001CF")]
		public ProfileFeatureSection[] featureDefinitions
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x8E37C0", Offset = "0x8E29C0", VA = "0x1808E37C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x8E1EA0", Offset = "0x8E10A0", VA = "0x1808E1EA0")]
		public float GetNumberPropertyValue(string propertyKey)
		{
			return 0f;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x8E1EB0", Offset = "0x8E10B0", VA = "0x1808E1EB0")]
		public float GetNumberPropertyValue(string propertyKey, float timeOfDay)
		{
			return 0f;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x8E1740", Offset = "0x8E0940", VA = "0x1808E1740")]
		public Color GetColorPropertyValue(string propertyKey)
		{
			return default(Color);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x8E1770", Offset = "0x8E0970", VA = "0x1808E1770")]
		public Color GetColorPropertyValue(string propertyKey, float timeOfDay)
		{
			return default(Color);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x8E2400", Offset = "0x8E1600", VA = "0x1808E2400")]
		public Texture GetTexturePropertyValue(string propertyKey)
		{
			return null;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x8E2240", Offset = "0x8E1440", VA = "0x1808E2240")]
		public Texture GetTexturePropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x8E20B0", Offset = "0x8E12B0", VA = "0x1808E20B0")]
		public SpherePoint GetSpherePointPropertyValue(string propertyKey)
		{
			return null;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x8E2170", Offset = "0x8E1370", VA = "0x1808E2170")]
		public SpherePoint GetSpherePointPropertyValue(string propertyKey, float timeOfDay)
		{
			return null;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x8E1680", Offset = "0x8E0880", VA = "0x1808E1680")]
		public bool GetBoolPropertyValue(string propertyKey)
		{
			return default(bool);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x8E15B0", Offset = "0x8E07B0", VA = "0x1808E15B0")]
		public bool GetBoolPropertyValue(string propertyKey, float timeOfDay)
		{
			return default(bool);
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x8E3680", Offset = "0x8E2880", VA = "0x1808E3680")]
		public SkyProfile()
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x8E2EE0", Offset = "0x8E20E0", VA = "0x1808E2EE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x8E30C0", Offset = "0x8E22C0", VA = "0x1808E30C0")]
		private void ReloadFullProfile()
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x8E3030", Offset = "0x8E2230", VA = "0x1808E3030")]
		private void ReloadDefinitions()
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x8E2030", Offset = "0x8E1230", VA = "0x1808E2030")]
		private IProfileDefinition GetShaderInfoForMaterial(string shaderName)
		{
			return null;
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x8E2D00", Offset = "0x8E1F00", VA = "0x1808E2D00")]
		public void MergeProfileWithDefinitions()
		{
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x8E2890", Offset = "0x8E1A90", VA = "0x1808E2890")]
		public void MergeGroupsWithDefinitions()
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x8E25A0", Offset = "0x8E17A0", VA = "0x1808E25A0")]
		public Dictionary<string, ProfileGroupDefinition> GroupDefinitionDictionary()
		{
			return null;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x8E1F80", Offset = "0x8E1180", VA = "0x1808E1F80")]
		public ProfileGroupSection[] ProfileDefinitionTable()
		{
			return null;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x8E1060", Offset = "0x8E0260", VA = "0x1808E1060")]
		private void AddNumericGroup(string propKey, string groupName, float min, float max, float value)
		{
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x8E0F10", Offset = "0x8E0110", VA = "0x1808E0F10")]
		private void AddColorGroup(string propKey, string groupName, Color color)
		{
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x8E13A0", Offset = "0x8E05A0", VA = "0x1808E13A0")]
		private void AddTextureGroup(string propKey, string groupName, Texture2D texture)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x8E11D0", Offset = "0x8E03D0", VA = "0x1808E11D0")]
		private void AddSpherePointGroup(string propKey, string groupName, SpherePoint point)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x8E0DD0", Offset = "0x8DFFD0", VA = "0x1808E0DD0")]
		private void AddBooleanGroup(string propKey, string groupName, bool value)
		{
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600091F")]
		public T GetGroup<T>(string propertyKey) where T : class
		{
			return null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000920")]
		[Address(RVA = "0x8E1E80", Offset = "0x8E1080", VA = "0x1808E1E80")]
		public IKeyframeGroup GetGroup(string propertyKey)
		{
			return null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000921")]
		[Address(RVA = "0x8E1C50", Offset = "0x8E0E50", VA = "0x1808E1C50")]
		public IKeyframeGroup GetGroupWithId(string groupId)
		{
			return null;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000922")]
		[Address(RVA = "0x8E1F80", Offset = "0x8E1180", VA = "0x1808E1F80")]
		public ProfileGroupSection[] GetProfileDefinitions()
		{
			return null;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000923")]
		[Address(RVA = "0x8E1F90", Offset = "0x8E1190", VA = "0x1808E1F90")]
		public ProfileGroupSection GetSectionInfo(string sectionKey)
		{
			return null;
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x6000924")]
		[Address(RVA = "0x8E2830", Offset = "0x8E1A30", VA = "0x1808E2830")]
		public bool IsManagedByTimeline(string propertyKey)
		{
			return default(bool);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000925")]
		[Address(RVA = "0x8E3360", Offset = "0x8E2560", VA = "0x1808E3360")]
		public void ValidateTimelineGroupKeys()
		{
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000926")]
		[Address(RVA = "0x8E18D0", Offset = "0x8E0AD0", VA = "0x1808E18D0")]
		public List<ProfileGroupDefinition> GetGroupDefinitionsManagedByTimeline()
		{
			return null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000927")]
		[Address(RVA = "0x8E1AD0", Offset = "0x8E0CD0", VA = "0x1808E1AD0")]
		public List<ProfileGroupDefinition> GetGroupDefinitionsNotManagedByTimeline()
		{
			return null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000928")]
		[Address(RVA = "0x8E1850", Offset = "0x8E0A50", VA = "0x1808E1850")]
		public ProfileGroupDefinition GetGroupDefinitionForKey(string propertyKey)
		{
			return null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000929")]
		[Address(RVA = "0x8E2EF0", Offset = "0x8E20F0", VA = "0x1808E2EF0")]
		public void RebuildKeyToGroupInfoMapping()
		{
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092A")]
		[Address(RVA = "0x8E32F0", Offset = "0x8E24F0", VA = "0x1808E32F0")]
		public void TrimGroupToSingleKeyframe(string propertyKey)
		{
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x600092B")]
		[Address(RVA = "0x8E14F0", Offset = "0x8E06F0", VA = "0x1808E14F0")]
		public bool CanGroupBeOnTimeline(ProfileGroupDefinition definition)
		{
			return default(bool);
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092C")]
		[Address(RVA = "0x8E2D20", Offset = "0x8E1F20", VA = "0x1808E2D20")]
		protected void MergeShaderKeywordsWithDefinitions()
		{
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x600092D")]
		[Address(RVA = "0x8E26D0", Offset = "0x8E18D0", VA = "0x1808E26D0")]
		public bool IsFeatureEnabled(string featureKey, bool recursive = true)
		{
			return default(bool);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x8E3230", Offset = "0x8E2430", VA = "0x1808E3230")]
		public void SetFeatureEnabled(string featureKey, bool value)
		{
		}

		// Token: 0x04000A77 RID: 2679
		[Token(Token = "0x4000A77")]
		public const string DefaultShaderName = "Funly/Sky Studio/Skybox/3D Standard";

		// Token: 0x04000A78 RID: 2680
		[Token(Token = "0x4000A78")]
		public const string DefaultLegacyShaderName = "Funly/Sky Studio/Skybox/3D Standard - Global Keywords";

		// Token: 0x04000A79 RID: 2681
		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material m_SkyboxMaterial;

		// Token: 0x04000A7A RID: 2682
		[Token(Token = "0x4000A7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_ShaderName;

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		[FieldOffset(Offset = "0x28")]
		public IProfileDefinition profileDefinition;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0x30")]
		public List<string> timelineManagedKeys;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x38")]
		public KeyframeGroupDictionary keyframeGroups;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x40")]
		public BoolDictionary featureStatus;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x48")]
		public LightningArtSet lightningArtSet;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x50")]
		public RainSplashArtSet rainSplashArtSet;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x58")]
		public Texture2D starLayer1DataTexture;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x60")]
		public Texture2D starLayer2DataTexture;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D starLayer3DataTexture;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int m_ProfileVersion;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x78")]
		private Dictionary<string, ProfileGroupDefinition> m_KeyToGroupInfo;
	}
}
