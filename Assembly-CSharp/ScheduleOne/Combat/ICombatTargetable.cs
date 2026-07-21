using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vision;
using UnityEngine;

namespace ScheduleOne.Combat
{
	// Token: 0x02000E28 RID: 3624
	[Token(Token = "0x2000E28")]
	public interface ICombatTargetable : IDamageable, ISightable
	{
		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x060067F0 RID: 26608
		[Token(Token = "0x17000EB9")]
		NetworkObject NetworkObject
		{
			[Token(Token = "0x60067F0")]
			get;
		}

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x060067F1 RID: 26609 RVA: 0x000194B8 File Offset: 0x000176B8
		[Token(Token = "0x17000EBA")]
		Vector3 CenterPoint
		{
			[Token(Token = "0x60067F1")]
			[Address(RVA = "0xAB0FC0", Offset = "0xAB01C0", VA = "0x180AB0FC0", Slot = "1")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x060067F2 RID: 26610
		[Token(Token = "0x17000EBB")]
		Transform CenterPointTransform
		{
			[Token(Token = "0x60067F2")]
			get;
		}

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x060067F3 RID: 26611
		[Token(Token = "0x17000EBC")]
		Vector3 LookAtPoint
		{
			[Token(Token = "0x60067F3")]
			get;
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x060067F4 RID: 26612
		[Token(Token = "0x17000EBD")]
		bool IsCurrentlyTargetable
		{
			[Token(Token = "0x60067F4")]
			get;
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x060067F5 RID: 26613
		[Token(Token = "0x17000EBE")]
		float RangedHitChanceMultiplier
		{
			[Token(Token = "0x60067F5")]
			get;
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060067F6 RID: 26614
		[Token(Token = "0x17000EBF")]
		Vector3 Velocity
		{
			[Token(Token = "0x60067F6")]
			get;
		}

		// Token: 0x060067F7 RID: 26615
		[Token(Token = "0x60067F7")]
		void RecordLastKnownPosition(bool resetTimeSinceLastSeen);

		// Token: 0x060067F8 RID: 26616
		[Token(Token = "0x60067F8")]
		float GetSearchTime();

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060067F9 RID: 26617 RVA: 0x000194D0 File Offset: 0x000176D0
		[Token(Token = "0x17000EC0")]
		bool IsPlayer
		{
			[Token(Token = "0x60067F9")]
			[Address(RVA = "0xAB1040", Offset = "0xAB0240", VA = "0x180AB1040", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060067FA RID: 26618 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000EC1")]
		Player AsPlayer
		{
			[Token(Token = "0x60067FA")]
			[Address(RVA = "0xAB0F50", Offset = "0xAB0150", VA = "0x180AB0F50", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x000194E8 File Offset: 0x000176E8
		[Token(Token = "0x60067FB")]
		[Address(RVA = "0xAB0E80", Offset = "0xAB0080", VA = "0x180AB0E80", Slot = "11")]
		bool IsNull()
		{
			return default(bool);
		}
	}
}
