using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne;
using UnityEngine;

// Token: 0x0200001C RID: 28
[Token(Token = "0x200001C")]
public static class GUIDManager
{
	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x558560", Offset = "0x557760", VA = "0x180558560")]
	public static void RegisterObject(IGUIDRegisterable obj, [Optional] GameObject go)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x5580F0", Offset = "0x5572F0", VA = "0x1805580F0")]
	public static void DeregisterObject(IGUIDRegisterable obj)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x600005F")]
	public static T GetObject<T>(Guid guid)
	{
		return null;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x0000206A File Offset: 0x0000026A
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x558390", Offset = "0x557590", VA = "0x180558390")]
	public static Type GetObjectType(Guid guid)
	{
		return null;
	}

	// Token: 0x06000061 RID: 97 RVA: 0x000020B8 File Offset: 0x000002B8
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x5582E0", Offset = "0x5574E0", VA = "0x1805582E0")]
	public static Guid GenerateUniqueGUID()
	{
		return default(Guid);
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000020D0 File Offset: 0x000002D0
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x558410", Offset = "0x557610", VA = "0x180558410")]
	public static bool IsGUIDAlreadyRegistered(Guid guid)
	{
		return default(bool);
	}

	// Token: 0x06000063 RID: 99 RVA: 0x000020E8 File Offset: 0x000002E8
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x5584A0", Offset = "0x5576A0", VA = "0x1805584A0")]
	public static bool IsGUIDValid(string guid)
	{
		return default(bool);
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	[Address(RVA = "0x558010", Offset = "0x557210", VA = "0x180558010")]
	public static void Clear()
	{
	}

	// Token: 0x04000070 RID: 112
	[Token(Token = "0x4000070")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Guid> registeredGUIDs;

	// Token: 0x04000071 RID: 113
	[Token(Token = "0x4000071")]
	[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<Guid, object> guidToObject;
}
