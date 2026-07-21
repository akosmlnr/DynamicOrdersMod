using System;
using System.Text;
using AOT;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x02000025 RID: 37
[Token(Token = "0x2000025")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600007E RID: 126 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x17000007")]
	protected static SteamManager Instance
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x561280", Offset = "0x560480", VA = "0x180561280")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600007F RID: 127 RVA: 0x00002100 File Offset: 0x00000300
	[Token(Token = "0x17000008")]
	public static bool Initialized
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x561190", Offset = "0x560390", VA = "0x180561190")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x561130", Offset = "0x560330", VA = "0x180561130")]
	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void SteamAPIDebugTextHook(int nSeverity, StringBuilder pchDebugText)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x560EF0", Offset = "0x5600F0", VA = "0x180560EF0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void InitOnPlayMode()
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x560B20", Offset = "0x55FD20", VA = "0x180560B20", Slot = "4")]
	protected virtual void Awake()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x561020", Offset = "0x560220", VA = "0x180561020", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x560F60", Offset = "0x560160", VA = "0x180560F60", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x561180", Offset = "0x560380", VA = "0x180561180", Slot = "7")]
	protected virtual void Update()
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x43DCF0", Offset = "0x43CEF0", VA = "0x18043DCF0")]
	public SteamManager()
	{
	}

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x0")]
	protected static bool s_EverInitialized;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x8")]
	protected static SteamManager s_instance;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x20")]
	protected bool m_bInitialized;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x10")]
	public static Action OnSteamInitialized;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x28")]
	protected SteamAPIWarningMessageHook_t m_SteamAPIWarningMessageHook;
}
