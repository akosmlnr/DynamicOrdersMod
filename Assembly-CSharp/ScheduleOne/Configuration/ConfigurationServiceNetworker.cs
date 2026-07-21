using System;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;

namespace ScheduleOne.Configuration
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	public class ConfigurationServiceNetworker : NetworkBehaviour
	{
		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060030B6 RID: 12470 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170007FD")]
		private ConfigurationService _configurationService
		{
			[Token(Token = "0x60030B6")]
			[Address(RVA = "0x75FC80", Offset = "0x75EE80", VA = "0x18075FC80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B7")]
		[Address(RVA = "0x75F490", Offset = "0x75E690", VA = "0x18075F490", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B8")]
		[Address(RVA = "0x75F150", Offset = "0x75E350", VA = "0x18075F150")]
		private void OnDestroy()
		{
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030B9")]
		[Address(RVA = "0x75F2D0", Offset = "0x75E4D0", VA = "0x18075F2D0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BA")]
		[Address(RVA = "0x75F0D0", Offset = "0x75E2D0", VA = "0x18075F0D0")]
		private void OnConfigChanged(BaseConfiguration changedConfig)
		{
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x75EDC0", Offset = "0x75DFC0", VA = "0x18075EDC0")]
		[ObserversRpc]
		[TargetRpc]
		private void ApplySettingsJson(NetworkConnection conn, string configName, string settingsJson)
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public ConfigurationServiceNetworker()
		{
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x75F000", Offset = "0x75E200", VA = "0x18075F000", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BE")]
		[Address(RVA = "0x75EFE0", Offset = "0x75E1E0", VA = "0x18075EFE0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BF")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C0")]
		[Address(RVA = "0x75F9C0", Offset = "0x75EBC0", VA = "0x18075F9C0")]
		private void RpcWriter___Observers_ApplySettingsJson_3895153758(NetworkConnection conn, string configName, string settingsJson)
		{
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C1")]
		[Address(RVA = "0x75F620", Offset = "0x75E820", VA = "0x18075F620")]
		private void RpcLogic___ApplySettingsJson_3895153758(NetworkConnection conn, string configName, string settingsJson)
		{
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C2")]
		[Address(RVA = "0x75F8C0", Offset = "0x75EAC0", VA = "0x18075F8C0")]
		private void RpcReader___Observers_ApplySettingsJson_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C3")]
		[Address(RVA = "0x75FB20", Offset = "0x75ED20", VA = "0x18075FB20")]
		private void RpcWriter___Target_ApplySettingsJson_3895153758(NetworkConnection conn, string configName, string settingsJson)
		{
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C4")]
		[Address(RVA = "0x75F940", Offset = "0x75EB40", VA = "0x18075F940")]
		private void RpcReader___Target_ApplySettingsJson_3895153758(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030C5")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040023D7 RID: 9175
		[Token(Token = "0x40023D7")]
		[FieldOffset(Offset = "0x118")]
		private bool NetworkInitialize___EarlyScheduleOne.Configuration.ConfigurationServiceNetworkerAssembly-CSharp.dll_Excuted;

		// Token: 0x040023D8 RID: 9176
		[Token(Token = "0x40023D8")]
		[FieldOffset(Offset = "0x119")]
		private bool NetworkInitialize__LateScheduleOne.Configuration.ConfigurationServiceNetworkerAssembly-CSharp.dll_Excuted;
	}
}
