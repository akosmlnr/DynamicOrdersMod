using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Funly.SkyStudio
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	[Serializable]
	public class KeyframeGroup<T> : IKeyframeGroup where T : IBaseKeyframe
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BC")]
		public string name
		{
			[Token(Token = "0x6000894")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000895")]
			set
			{
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001BD")]
		public string id
		{
			[Token(Token = "0x6000896")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000897")]
			set
			{
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000898")]
		public KeyframeGroup(string name)
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000899")]
		public void AddKeyFrame(T keyFrame)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089A")]
		public void RemoveKeyFrame(T keyFrame)
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089B")]
		public void RemoveKeyFrame(IBaseKeyframe keyframe)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x600089C")]
		public int GetKeyFrameCount()
		{
			return 0;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600089D")]
		public T GetKeyframe(int index)
		{
			return null;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089E")]
		public void SortKeyframes()
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x600089F")]
		public float CurveAdjustedBlendingTime(InterpolationCurve curve, float t)
		{
			return 0f;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60008A0")]
		public T GetPreviousKeyFrame(float time)
		{
			return null;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x60008A1")]
		public bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe)
		{
			return default(bool);
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x60008A2")]
		public bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex)
		{
			return default(bool);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x60008A3")]
		public static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey)
		{
			return 0f;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x60008A4")]
		public static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime)
		{
			return 0f;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x60008A5")]
		public static float WidthBetweenCircularValues(float begin, float end)
		{
			return 0f;
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A6")]
		public void TrimToSingleKeyframe()
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x60008A7")]
		public InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return InterpolationDirection.Auto;
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008A8")]
		public void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x60008A9")]
		public float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			return 0f;
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x60008AA")]
		public float AutoInterpolation(float curvedTime, float previousValue, float nextValue)
		{
			return 0f;
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x60008AB")]
		public float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			return 0f;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x60008AC")]
		public float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			return 0f;
		}

		// Token: 0x0400092A RID: 2346
		[Token(Token = "0x400092A")]
		[FieldOffset(Offset = "0x0")]
		public List<T> keyframes;

		// Token: 0x0400092B RID: 2347
		[Token(Token = "0x400092B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Name;

		// Token: 0x0400092C RID: 2348
		[Token(Token = "0x400092C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private string m_Id;
	}
}
