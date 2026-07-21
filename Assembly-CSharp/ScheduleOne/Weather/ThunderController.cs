using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Core;
using ScheduleOne.Effects;
using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Weather
{
	// Token: 0x02000BAE RID: 2990
	[Token(Token = "0x2000BAE")]
	public class ThunderController : WeatherEffectController
	{
		// Token: 0x060058EA RID: 22762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EA")]
		[Address(RVA = "0x9B6D50", Offset = "0x9B5F50", VA = "0x1809B6D50", Slot = "24")]
		public override void Awake()
		{
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EB")]
		[Address(RVA = "0x9B7F60", Offset = "0x9B7160", VA = "0x1809B7F60")]
		private void Start()
		{
		}

		// Token: 0x060058EC RID: 22764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EC")]
		[Address(RVA = "0x9B94E0", Offset = "0x9B86E0", VA = "0x1809B94E0", Slot = "25")]
		protected override void Update()
		{
		}

		// Token: 0x060058ED RID: 22765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058ED")]
		[Address(RVA = "0x9B88D0", Offset = "0x9B7AD0", VA = "0x1809B88D0")]
		[Button]
		private void TriggerThunder()
		{
		}

		// Token: 0x060058EE RID: 22766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EE")]
		[Address(RVA = "0x9B8320", Offset = "0x9B7520", VA = "0x1809B8320")]
		public void TriggerRandomLightningStrike()
		{
		}

		// Token: 0x060058EF RID: 22767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058EF")]
		[Address(RVA = "0x9B8680", Offset = "0x9B7880", VA = "0x1809B8680")]
		public void TriggerRandomPlayerLightningStrike()
		{
		}

		// Token: 0x060058F0 RID: 22768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F0")]
		[Address(RVA = "0x9B8250", Offset = "0x9B7450", VA = "0x1809B8250")]
		public void TriggerPlayerLightningStrike(Player player)
		{
		}

		// Token: 0x060058F1 RID: 22769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F1")]
		[Address(RVA = "0x9B83F0", Offset = "0x9B75F0", VA = "0x1809B83F0")]
		public void TriggerRandomNPCLightningStrike()
		{
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F2")]
		[Address(RVA = "0x9B8180", Offset = "0x9B7380", VA = "0x1809B8180")]
		public void TriggerNPCLightningStrike(NPC targetNPC)
		{
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F3")]
		[Address(RVA = "0x9B7DF0", Offset = "0x9B6FF0", VA = "0x1809B7DF0")]
		[ServerRpc(RequireOwnership = false)]
		private void TriggerLightningStrike_Server(Vector3 position)
		{
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F4")]
		[Address(RVA = "0x9B7C60", Offset = "0x9B6E60", VA = "0x1809B7C60")]
		[ObserversRpc]
		private void TriggerLightningStrike_Client(Vector3 position)
		{
		}

		// Token: 0x060058F5 RID: 22773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F5")]
		[Address(RVA = "0x9B7FF0", Offset = "0x9B71F0", VA = "0x1809B7FF0")]
		public void TriggerDistantThunder()
		{
		}

		// Token: 0x060058F6 RID: 22774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F6")]
		[Address(RVA = "0x9B7AD0", Offset = "0x9B6CD0", VA = "0x1809B7AD0")]
		[ObserversRpc]
		private void TriggerDistantThunder_Client(Vector3 location)
		{
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F7")]
		[Address(RVA = "0x9B7090", Offset = "0x9B6290", VA = "0x1809B7090")]
		private void RandomiseThunderTimer()
		{
		}

		// Token: 0x060058F8 RID: 22776 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058F8")]
		[Address(RVA = "0x9B8DD0", Offset = "0x9B7FD0", VA = "0x1809B8DD0", Slot = "27")]
		public override void UpdateAudio()
		{
		}

		// Token: 0x060058F9 RID: 22777 RVA: 0x000167B8 File Offset: 0x000149B8
		[Token(Token = "0x60058F9")]
		[Address(RVA = "0x9B6DA0", Offset = "0x9B5FA0", VA = "0x1809B6DA0")]
		private Vector3 GetRandomPointInVolume()
		{
			return default(Vector3);
		}

		// Token: 0x060058FA RID: 22778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FA")]
		[Address(RVA = "0x9B8F40", Offset = "0x9B8140", VA = "0x1809B8F40")]
		private void UpdateAudio(AudioSourceController audioSource, bool useEffectDistance)
		{
		}

		// Token: 0x060058FB RID: 22779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FB")]
		[Address(RVA = "0x9B9380", Offset = "0x9B8580", VA = "0x1809B9380", Slot = "21")]
		public override void UpdateProperties(Vector3 anchorPosition, Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend)
		{
		}

		// Token: 0x060058FC RID: 22780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058FC")]
		[Address(RVA = "0x9B9580", Offset = "0x9B8780", VA = "0x1809B9580")]
		public ThunderController()
		{
		}

		// Token: 0x060058FD RID: 22781 RVA: 0x000167D0 File Offset: 0x000149D0
		[Token(Token = "0x60058FD")]
		[Address(RVA = "0x9B8D40", Offset = "0x9B7F40", VA = "0x1809B8D40")]
		[CompilerGenerated]
		internal static bool <TriggerRandomPlayerLightningStrike>g__CanBeStruck|20_1(Player player)
		{
			return default(bool);
		}

		// Token: 0x060058FE RID: 22782 RVA: 0x000167E8 File Offset: 0x000149E8
		[Token(Token = "0x60058FE")]
		[Address(RVA = "0x9B8C60", Offset = "0x9B7E60", VA = "0x1809B8C60")]
		[CompilerGenerated]
		internal static bool <TriggerRandomNPCLightningStrike>g__CanBeStruck|22_1(NPC npc)
		{
			return default(bool);
		}

		// Token: 0x06005901 RID: 22785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005901")]
		[Address(RVA = "0x9B6F50", Offset = "0x9B6150", VA = "0x1809B6F50", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005902 RID: 22786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005902")]
		[Address(RVA = "0x9B6F20", Offset = "0x9B6120", VA = "0x1809B6F20", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005903 RID: 22787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005903")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005904 RID: 22788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005904")]
		[Address(RVA = "0x9B7DF0", Offset = "0x9B6FF0", VA = "0x1809B7DF0")]
		private void RpcWriter___Server_TriggerLightningStrike_Server_4276783012(Vector3 position)
		{
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005905")]
		[Address(RVA = "0x9B7660", Offset = "0x9B6860", VA = "0x1809B7660")]
		private void RpcLogic___TriggerLightningStrike_Server_4276783012(Vector3 position)
		{
		}

		// Token: 0x06005906 RID: 22790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005906")]
		[Address(RVA = "0x9B7A20", Offset = "0x9B6C20", VA = "0x1809B7A20")]
		private void RpcReader___Server_TriggerLightningStrike_Server_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005907 RID: 22791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005907")]
		[Address(RVA = "0x9B7C60", Offset = "0x9B6E60", VA = "0x1809B7C60")]
		private void RpcWriter___Observers_TriggerLightningStrike_Client_4276783012(Vector3 position)
		{
		}

		// Token: 0x06005908 RID: 22792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005908")]
		[Address(RVA = "0x9B7430", Offset = "0x9B6630", VA = "0x1809B7430")]
		private void RpcLogic___TriggerLightningStrike_Client_4276783012(Vector3 position)
		{
		}

		// Token: 0x06005909 RID: 22793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005909")]
		[Address(RVA = "0x9B7970", Offset = "0x9B6B70", VA = "0x1809B7970")]
		private void RpcReader___Observers_TriggerLightningStrike_Client_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600590A RID: 22794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600590A")]
		[Address(RVA = "0x9B7AD0", Offset = "0x9B6CD0", VA = "0x1809B7AD0")]
		private void RpcWriter___Observers_TriggerDistantThunder_Client_4276783012(Vector3 location)
		{
		}

		// Token: 0x0600590B RID: 22795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600590B")]
		[Address(RVA = "0x9B70C0", Offset = "0x9B62C0", VA = "0x1809B70C0")]
		private void RpcLogic___TriggerDistantThunder_Client_4276783012(Vector3 location)
		{
		}

		// Token: 0x0600590C RID: 22796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600590C")]
		[Address(RVA = "0x9B78C0", Offset = "0x9B6AC0", VA = "0x1809B78C0")]
		private void RpcReader___Observers_TriggerDistantThunder_Client_4276783012(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600590D RID: 22797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600590D")]
		[Address(RVA = "0x9B6810", Offset = "0x9B5A10", VA = "0x1809B6810", Slot = "29")]
		protected virtual void Awake_UserLogic_ScheduleOne.Weather.ThunderController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003B41 RID: 15169
		[Token(Token = "0x4003B41")]
		private const float _npcLightningStrikeDistanceFromPlayer = 40f;

		// Token: 0x04003B42 RID: 15170
		[Token(Token = "0x4003B42")]
		[FieldOffset(Offset = "0x1C0")]
		[Header("Thunder Settings")]
		[SerializeField]
		private float _maxThunderDelay;

		// Token: 0x04003B43 RID: 15171
		[Token(Token = "0x4003B43")]
		[FieldOffset(Offset = "0x1C4")]
		[SerializeField]
		private Vector2 _timeBetweenThunders;

		// Token: 0x04003B44 RID: 15172
		[Token(Token = "0x4003B44")]
		[FieldOffset(Offset = "0x1CC")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _chanceForLightingStrike;

		// Token: 0x04003B45 RID: 15173
		[Token(Token = "0x4003B45")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _chanceForLightingToHitPlayer;

		// Token: 0x04003B46 RID: 15174
		[Token(Token = "0x4003B46")]
		[FieldOffset(Offset = "0x1D4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _chanceForLightingToHitNPC;

		// Token: 0x04003B47 RID: 15175
		[Token(Token = "0x4003B47")]
		[FieldOffset(Offset = "0x1D8")]
		private float _sqrDistanceToPlayer;

		// Token: 0x04003B48 RID: 15176
		[Token(Token = "0x4003B48")]
		[FieldOffset(Offset = "0x1DC")]
		private float _thundertimer;

		// Token: 0x04003B49 RID: 15177
		[Token(Token = "0x4003B49")]
		[FieldOffset(Offset = "0x1E0")]
		private float _timeUntilNextThunder;

		// Token: 0x04003B4A RID: 15178
		[Token(Token = "0x4003B4A")]
		[FieldOffset(Offset = "0x1E4")]
		private float _effectNormalisedDistanceToPlayer;

		// Token: 0x04003B4B RID: 15179
		[Token(Token = "0x4003B4B")]
		[FieldOffset(Offset = "0x1E8")]
		private RandomizedAudioSourceController _thunderAudio;

		// Token: 0x04003B4C RID: 15180
		[Token(Token = "0x4003B4C")]
		[FieldOffset(Offset = "0x1F0")]
		private RandomizedAudioSourceController _lightningAudio;

		// Token: 0x04003B4D RID: 15181
		[Token(Token = "0x4003B4D")]
		[FieldOffset(Offset = "0x1F8")]
		private VFXEffectHandler _lightningEffect;

		// Token: 0x04003B4E RID: 15182
		[Token(Token = "0x4003B4E")]
		[FieldOffset(Offset = "0x200")]
		private VFXEffectHandler _thunderEffect;

		// Token: 0x04003B4F RID: 15183
		[Token(Token = "0x4003B4F")]
		[FieldOffset(Offset = "0x208")]
		private Vector3 _debugThunderLocation;

		// Token: 0x04003B50 RID: 15184
		[Token(Token = "0x4003B50")]
		[FieldOffset(Offset = "0x214")]
		private bool NetworkInitialize___EarlyScheduleOne.Weather.ThunderControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003B51 RID: 15185
		[Token(Token = "0x4003B51")]
		[FieldOffset(Offset = "0x215")]
		private bool NetworkInitialize__LateScheduleOne.Weather.ThunderControllerAssembly-CSharp.dll_Excuted;
	}
}
