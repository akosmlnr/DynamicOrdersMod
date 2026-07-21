using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemIconCreator
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class IconCreator : MonoBehaviour
	{
		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x8D4F00", Offset = "0x8D4100", VA = "0x1808D4F00")]
		private void Awake()
		{
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x8D6740", Offset = "0x8D5940", VA = "0x1808D6740")]
		protected void Initialize()
		{
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x8D5950", Offset = "0x8D4B50", VA = "0x1808D5950")]
		protected void DeleteCameras()
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x8D5020", Offset = "0x8D4220", VA = "0x1808D5020", Slot = "4")]
		public virtual void BuildIcons()
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x8D5400", Offset = "0x8D4600", VA = "0x1808D5400")]
		protected IEnumerator CaptureFrame(string objectName, int i)
		{
			return null;
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x8D6E40", Offset = "0x8D6040", VA = "0x1808D6E40", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x8D6A90", Offset = "0x8D5C90", VA = "0x1808D6A90")]
		private void RenderCamToTexture(Camera cam, Texture2D tex)
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x8D5590", Offset = "0x8D4790", VA = "0x1808D5590")]
		private void CreateBlackAndWhiteCameras()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x8D57B0", Offset = "0x8D49B0", VA = "0x1808D57B0")]
		protected void CreateNewFolderForIcons()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x8D5C30", Offset = "0x8D4E30", VA = "0x1808D5C30")]
		public string GetFinalFolder()
		{
			return null;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x8D70C0", Offset = "0x8D62C0", VA = "0x1808D70C0")]
		private void WriteScreenImageToTexture(Texture2D tex)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x8D5220", Offset = "0x8D4420", VA = "0x1808D5220")]
		private void CalculateOutputTexture()
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x8D6B50", Offset = "0x8D5D50", VA = "0x1808D6B50")]
		private void SavePng(string name, int i)
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x8D5B40", Offset = "0x8D4D40", VA = "0x1808D5B40")]
		public string GetFileName(string name, int i)
		{
			return null;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x8D5080", Offset = "0x8D4280", VA = "0x1808D5080")]
		private void CacheAndInitialiseFields()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x8D6CE0", Offset = "0x8D5EE0", VA = "0x1808D6CE0")]
		protected void UpdateFOV(GameObject targetItem)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x8D6D60", Offset = "0x8D5F60", VA = "0x1808D6D60")]
		protected void UpdateFOV(float value)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x8D6890", Offset = "0x8D5A90", VA = "0x1808D6890")]
		protected void LookAtTargetCenter(GameObject targetItem)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x8D5FC0", Offset = "0x8D51C0", VA = "0x1808D5FC0")]
		private float GetTargetFov(GameObject a)
		{
			return 0f;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x8D5EB0", Offset = "0x8D50B0", VA = "0x1808D5EB0")]
		private List<Renderer> GetRenderers(GameObject obj)
		{
			return null;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x8D5CC0", Offset = "0x8D4EC0", VA = "0x1808D5CC0")]
		private Vector3 GetMeshCenter(GameObject a)
		{
			return default(Vector3);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		protected void RevealInFinder()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x8D54A0", Offset = "0x8D46A0", VA = "0x1808D54A0", Slot = "6")]
		public virtual bool CheckConditions()
		{
			return default(bool);
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x8D5A50", Offset = "0x8D4C50", VA = "0x1808D5A50")]
		private string GetBaseLocation()
		{
			return null;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x8D6A00", Offset = "0x8D5C00", VA = "0x1808D6A00")]
		private void OnValidate()
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x8D7140", Offset = "0x8D6340", VA = "0x1808D7140")]
		public IconCreator()
		{
		}

		// Token: 0x040008B2 RID: 2226
		[Token(Token = "0x40008B2")]
		[FieldOffset(Offset = "0x20")]
		protected bool isCreatingIcons;

		// Token: 0x040008B3 RID: 2227
		[Token(Token = "0x40008B3")]
		[FieldOffset(Offset = "0x21")]
		public bool useDafaultName;

		// Token: 0x040008B4 RID: 2228
		[Token(Token = "0x40008B4")]
		[FieldOffset(Offset = "0x22")]
		public bool includeResolutionInFileName;

		// Token: 0x040008B5 RID: 2229
		[Token(Token = "0x40008B5")]
		[FieldOffset(Offset = "0x28")]
		public string iconFileName;

		// Token: 0x040008B6 RID: 2230
		[Token(Token = "0x40008B6")]
		[FieldOffset(Offset = "0x30")]
		public IconCreator.SaveLocation pathLocation;

		// Token: 0x040008B7 RID: 2231
		[Token(Token = "0x40008B7")]
		[FieldOffset(Offset = "0x34")]
		public IconCreator.Mode mode;

		// Token: 0x040008B8 RID: 2232
		[Token(Token = "0x40008B8")]
		[FieldOffset(Offset = "0x38")]
		public string folderName;

		// Token: 0x040008B9 RID: 2233
		[Token(Token = "0x40008B9")]
		[FieldOffset(Offset = "0x40")]
		public bool useTransparency;

		// Token: 0x040008BA RID: 2234
		[Token(Token = "0x40008BA")]
		[FieldOffset(Offset = "0x41")]
		public bool lookAtObjectCenter;

		// Token: 0x040008BB RID: 2235
		[Token(Token = "0x40008BB")]
		[FieldOffset(Offset = "0x42")]
		public bool dynamicFov;

		// Token: 0x040008BC RID: 2236
		[Token(Token = "0x40008BC")]
		[FieldOffset(Offset = "0x44")]
		public float fovOffset;

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[FieldOffset(Offset = "0x48")]
		protected string finalPath;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[FieldOffset(Offset = "0x50")]
		private Vector3 mousePostion;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[FieldOffset(Offset = "0x5C")]
		public KeyCode nextIconKey;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[FieldOffset(Offset = "0x60")]
		protected bool CanMove;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[FieldOffset(Offset = "0x61")]
		public bool preview;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[FieldOffset(Offset = "0x68")]
		protected Camera whiteCam;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[FieldOffset(Offset = "0x70")]
		protected Camera blackCam;

		// Token: 0x040008C4 RID: 2244
		[Token(Token = "0x40008C4")]
		[FieldOffset(Offset = "0x78")]
		public Camera mainCam;

		// Token: 0x040008C5 RID: 2245
		[Token(Token = "0x40008C5")]
		[FieldOffset(Offset = "0x80")]
		protected Texture2D texBlack;

		// Token: 0x040008C6 RID: 2246
		[Token(Token = "0x40008C6")]
		[FieldOffset(Offset = "0x88")]
		protected Texture2D texWhite;

		// Token: 0x040008C7 RID: 2247
		[Token(Token = "0x40008C7")]
		[FieldOffset(Offset = "0x90")]
		protected Texture2D finalTexture;

		// Token: 0x040008C8 RID: 2248
		[Token(Token = "0x40008C8")]
		[FieldOffset(Offset = "0x98")]
		private CameraClearFlags originalClearFlags;

		// Token: 0x040008C9 RID: 2249
		[Token(Token = "0x40008C9")]
		[FieldOffset(Offset = "0xA0")]
		protected Transform currentObject;

		// Token: 0x0200018E RID: 398
		[Token(Token = "0x200018E")]
		public enum SaveLocation
		{
			// Token: 0x040008CB RID: 2251
			[Token(Token = "0x40008CB")]
			persistentDataPath,
			// Token: 0x040008CC RID: 2252
			[Token(Token = "0x40008CC")]
			dataPath,
			// Token: 0x040008CD RID: 2253
			[Token(Token = "0x40008CD")]
			projectFolder,
			// Token: 0x040008CE RID: 2254
			[Token(Token = "0x40008CE")]
			custom
		}

		// Token: 0x0200018F RID: 399
		[Token(Token = "0x200018F")]
		public enum Mode
		{
			// Token: 0x040008D0 RID: 2256
			[Token(Token = "0x40008D0")]
			Automatic,
			// Token: 0x040008D1 RID: 2257
			[Token(Token = "0x40008D1")]
			Manual
		}
	}
}
