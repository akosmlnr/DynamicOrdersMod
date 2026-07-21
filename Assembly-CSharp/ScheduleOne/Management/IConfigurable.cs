using System;
using FishNet.Connection;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x02000585 RID: 1413
	[Token(Token = "0x2000585")]
	public interface IConfigurable
	{
		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002041 RID: 8257
		[Token(Token = "0x170005AF")]
		EntityConfiguration Configuration
		{
			[Token(Token = "0x6002041")]
			get;
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002042 RID: 8258
		[Token(Token = "0x170005B0")]
		ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6002042")]
			get;
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002043 RID: 8259
		[Token(Token = "0x170005B1")]
		EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6002043")]
			get;
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002044 RID: 8260
		// (set) Token: 0x06002045 RID: 8261
		[Token(Token = "0x170005B2")]
		WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6002044")]
			get;
			[Token(Token = "0x6002045")]
			set;
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002046 RID: 8262
		// (set) Token: 0x06002047 RID: 8263
		[Token(Token = "0x170005B3")]
		NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6002046")]
			get;
			[Token(Token = "0x6002047")]
			set;
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x170005B4")]
		bool IsBeingConfiguredByOtherPlayer
		{
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x671830", Offset = "0x670A30", VA = "0x180671830", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002049 RID: 8265
		[Token(Token = "0x170005B5")]
		Sprite TypeIcon
		{
			[Token(Token = "0x6002049")]
			get;
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x0600204A RID: 8266
		[Token(Token = "0x170005B6")]
		Transform Transform
		{
			[Token(Token = "0x600204A")]
			get;
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x0600204B RID: 8267
		[Token(Token = "0x170005B7")]
		Transform UIPoint
		{
			[Token(Token = "0x600204B")]
			get;
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x170005B8")]
		bool IsDestroyed
		{
			[Token(Token = "0x600204C")]
			[Address(RVA = "0x6718F0", Offset = "0x670AF0", VA = "0x1806718F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x0600204D RID: 8269
		[Token(Token = "0x170005B9")]
		bool CanBeSelected
		{
			[Token(Token = "0x600204D")]
			get;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x0600204E RID: 8270
		[Token(Token = "0x170005BA")]
		Property ParentProperty
		{
			[Token(Token = "0x600204E")]
			get;
		}

		// Token: 0x0600204F RID: 8271
		[Token(Token = "0x600204F")]
		WorldspaceUIElement CreateWorldspaceUI();

		// Token: 0x06002050 RID: 8272
		[Token(Token = "0x6002050")]
		void DestroyWorldspaceUI();

		// Token: 0x06002051 RID: 8273
		[Token(Token = "0x6002051")]
		void ShowOutline(Color color);

		// Token: 0x06002052 RID: 8274
		[Token(Token = "0x6002052")]
		void HideOutline();

		// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x6717D0", Offset = "0x6709D0", VA = "0x1806717D0", Slot = "18")]
		void Selected()
		{
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x671770", Offset = "0x670970", VA = "0x180671770", Slot = "19")]
		void Deselected()
		{
		}

		// Token: 0x06002055 RID: 8277
		[Token(Token = "0x6002055")]
		void SetConfigurer(NetworkObject player);

		// Token: 0x06002056 RID: 8278
		[Token(Token = "0x6002056")]
		void SendConfigurationToClient(NetworkConnection conn);
	}
}
