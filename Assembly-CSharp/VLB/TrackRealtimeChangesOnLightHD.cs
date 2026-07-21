using System;
using Il2CppDummyDll;
using UnityEngine;

namespace VLB
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Light), typeof(VolumetricLightBeamHD))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-trackrealtimechanges-hd/")]
	public class TrackRealtimeChangesOnLightHD : MonoBehaviour
	{
		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x69D6D0", Offset = "0x69C8D0", VA = "0x18069D6D0")]
		private void Awake()
		{
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x69D720", Offset = "0x69C920", VA = "0x18069D720")]
		private void Update()
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
		public TrackRealtimeChangesOnLightHD()
		{
		}

		// Token: 0x04000587 RID: 1415
		[Token(Token = "0x4000587")]
		public const string ClassName = "TrackRealtimeChangesOnLightHD";

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x20")]
		private VolumetricLightBeamHD m_Master;
	}
}
