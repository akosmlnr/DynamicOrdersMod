using System;
using System.Collections;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.GameTime;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000AD4 RID: 2772
	[Token(Token = "0x2000AD4")]
	public class ConsumeProductBehaviour : Behaviour
	{
		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06005018 RID: 20504 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06005019 RID: 20505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C18")]
		public ProductItemInstance ConsumedProduct
		{
			[Token(Token = "0x6005018")]
			[Address(RVA = "0x630320", Offset = "0x62F520", VA = "0x180630320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005019")]
			[Address(RVA = "0x6303E0", Offset = "0x62F5E0", VA = "0x1806303E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501A")]
		[Address(RVA = "0x94A6E0", Offset = "0x9498E0", VA = "0x18094A6E0", Slot = "35")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600501B RID: 20507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501B")]
		[Address(RVA = "0x94A590", Offset = "0x949790", VA = "0x18094A590")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendProduct(ProductItemInstance _product, bool removeFromInventory)
		{
		}

		// Token: 0x0600501C RID: 20508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501C")]
		[Address(RVA = "0x949CF0", Offset = "0x948EF0", VA = "0x180949CF0")]
		[ObserversRpc(RunLocally = true)]
		private void SetProduct(ProductItemInstance _product, bool removeFromInventory)
		{
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501D")]
		[Address(RVA = "0x9491D0", Offset = "0x9483D0", VA = "0x1809491D0")]
		[ObserversRpc(RunLocally = true)]
		public void ClearEffects()
		{
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501E")]
		[Address(RVA = "0x949090", Offset = "0x948290", VA = "0x180949090", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600501F")]
		[Address(RVA = "0x9499A0", Offset = "0x948BA0", VA = "0x1809499A0", Slot = "25")]
		public override void Resume()
		{
		}

		// Token: 0x06005020 RID: 20512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005020")]
		[Address(RVA = "0x94A9D0", Offset = "0x949BD0", VA = "0x18094A9D0")]
		private void TryConsume()
		{
		}

		// Token: 0x06005021 RID: 20513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005021")]
		[Address(RVA = "0x949780", Offset = "0x948980", VA = "0x180949780", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005022")]
		[Address(RVA = "0x9496E0", Offset = "0x9488E0", VA = "0x1809496E0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005023 RID: 20515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005023")]
		[Address(RVA = "0x949610", Offset = "0x948810", VA = "0x180949610")]
		private void ConsumeWeed()
		{
		}

		// Token: 0x06005024 RID: 20516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005024")]
		[Address(RVA = "0x9494F0", Offset = "0x9486F0", VA = "0x1809494F0")]
		private void ConsumeMeth()
		{
		}

		// Token: 0x06005025 RID: 20517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005025")]
		[Address(RVA = "0x949360", Offset = "0x948560", VA = "0x180949360")]
		private void ConsumeCocaine()
		{
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005026")]
		[Address(RVA = "0x949580", Offset = "0x948780", VA = "0x180949580")]
		private void ConsumeShrooms()
		{
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005027")]
		[Address(RVA = "0x9490B0", Offset = "0x9482B0", VA = "0x1809490B0")]
		[ObserversRpc(RunLocally = true)]
		private void ApplyEffects()
		{
		}

		// Token: 0x06005028 RID: 20520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005028")]
		[Address(RVA = "0x9492F0", Offset = "0x9484F0", VA = "0x1809492F0")]
		private void Clear()
		{
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005029")]
		[Address(RVA = "0x9496A0", Offset = "0x9488A0", VA = "0x1809496A0")]
		private void DayPass()
		{
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502A")]
		[Address(RVA = "0x9493F0", Offset = "0x9485F0", VA = "0x1809493F0")]
		private void ConsumeDone()
		{
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600502B")]
		[Address(RVA = "0x936AA0", Offset = "0x935CA0", VA = "0x180936AA0")]
		public ConsumeProductBehaviour()
		{
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600502C")]
		[Address(RVA = "0x94AEB0", Offset = "0x94A0B0", VA = "0x18094AEB0")]
		[CompilerGenerated]
		private IEnumerator <ConsumeWeed>g__ConsumeWeedRoutine|26_0()
		{
			return null;
		}

		// Token: 0x0600502D RID: 20525 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600502D")]
		[Address(RVA = "0x94ADD0", Offset = "0x949FD0", VA = "0x18094ADD0")]
		[CompilerGenerated]
		private IEnumerator <ConsumeMeth>g__ConsumeWeedRoutine|27_0()
		{
			return null;
		}

		// Token: 0x0600502E RID: 20526 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600502E")]
		[Address(RVA = "0x94AD10", Offset = "0x949F10", VA = "0x18094AD10")]
		[CompilerGenerated]
		private IEnumerator <ConsumeCocaine>g__ConsumeWeedRoutine|28_0()
		{
			return null;
		}

		// Token: 0x0600502F RID: 20527 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600502F")]
		[Address(RVA = "0x94AE40", Offset = "0x94A040", VA = "0x18094AE40")]
		[CompilerGenerated]
		private IEnumerator <ConsumeShrooms>g__ConsumeRoutine|29_0()
		{
			return null;
		}

		// Token: 0x06005031 RID: 20529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005031")]
		[Address(RVA = "0x949830", Offset = "0x948A30", VA = "0x180949830", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005032 RID: 20530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005032")]
		[Address(RVA = "0x949810", Offset = "0x948A10", VA = "0x180949810", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005033 RID: 20531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005033")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005034 RID: 20532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005034")]
		[Address(RVA = "0x94A430", Offset = "0x949630", VA = "0x18094A430")]
		private void RpcWriter___Server_SendProduct_3964170259(ProductItemInstance _product, bool removeFromInventory)
		{
		}

		// Token: 0x06005035 RID: 20533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005035")]
		[Address(RVA = "0x949CF0", Offset = "0x948EF0", VA = "0x180949CF0")]
		public void RpcLogic___SendProduct_3964170259(ProductItemInstance _product, bool removeFromInventory)
		{
		}

		// Token: 0x06005036 RID: 20534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005036")]
		[Address(RVA = "0x949FD0", Offset = "0x9491D0", VA = "0x180949FD0")]
		private void RpcReader___Server_SendProduct_3964170259(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005037 RID: 20535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005037")]
		[Address(RVA = "0x94A2C0", Offset = "0x9494C0", VA = "0x18094A2C0")]
		private void RpcWriter___Observers_SetProduct_3964170259(ProductItemInstance _product, bool removeFromInventory)
		{
		}

		// Token: 0x06005038 RID: 20536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005038")]
		[Address(RVA = "0x949E60", Offset = "0x949060", VA = "0x180949E60")]
		private void RpcLogic___SetProduct_3964170259(ProductItemInstance _product, bool removeFromInventory)
		{
		}

		// Token: 0x06005039 RID: 20537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005039")]
		[Address(RVA = "0x949F20", Offset = "0x949120", VA = "0x180949F20")]
		private void RpcReader___Observers_SetProduct_3964170259(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600503A RID: 20538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503A")]
		[Address(RVA = "0x94A1A0", Offset = "0x9493A0", VA = "0x18094A1A0")]
		private void RpcWriter___Observers_ClearEffects_2166136261()
		{
		}

		// Token: 0x0600503B RID: 20539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503B")]
		[Address(RVA = "0x949BD0", Offset = "0x948DD0", VA = "0x180949BD0")]
		public void RpcLogic___ClearEffects_2166136261()
		{
		}

		// Token: 0x0600503C RID: 20540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503C")]
		[Address(RVA = "0x949EE0", Offset = "0x9490E0", VA = "0x180949EE0")]
		private void RpcReader___Observers_ClearEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600503D RID: 20541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503D")]
		[Address(RVA = "0x94A080", Offset = "0x949280", VA = "0x18094A080")]
		private void RpcWriter___Observers_ApplyEffects_2166136261()
		{
		}

		// Token: 0x0600503E RID: 20542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503E")]
		[Address(RVA = "0x9499C0", Offset = "0x948BC0", VA = "0x1809499C0")]
		private void RpcLogic___ApplyEffects_2166136261()
		{
		}

		// Token: 0x0600503F RID: 20543 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600503F")]
		[Address(RVA = "0x949EA0", Offset = "0x9490A0", VA = "0x180949EA0")]
		private void RpcReader___Observers_ApplyEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005040 RID: 20544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005040")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x04003765 RID: 14181
		[Token(Token = "0x4003765")]
		[FieldOffset(Offset = "0x168")]
		public AvatarEquippable JointPrefab;

		// Token: 0x04003766 RID: 14182
		[Token(Token = "0x4003766")]
		[FieldOffset(Offset = "0x170")]
		public AvatarEquippable PipePrefab;

		// Token: 0x04003767 RID: 14183
		[Token(Token = "0x4003767")]
		[FieldOffset(Offset = "0x178")]
		public AvatarEquippable ShroomPrefab;

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x188")]
		private ProductItemInstance product;

		// Token: 0x0400376A RID: 14186
		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x190")]
		private Coroutine consumeRoutine;

		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x198")]
		public AudioSourceController WeedConsumeSound;

		// Token: 0x0400376C RID: 14188
		[Token(Token = "0x400376C")]
		[FieldOffset(Offset = "0x1A0")]
		public AudioSourceController MethConsumeSound;

		// Token: 0x0400376D RID: 14189
		[Token(Token = "0x400376D")]
		[FieldOffset(Offset = "0x1A8")]
		public AudioSourceController SnortSound;

		// Token: 0x0400376E RID: 14190
		[Token(Token = "0x400376E")]
		[FieldOffset(Offset = "0x1B0")]
		public AudioSourceController EatSound;

		// Token: 0x0400376F RID: 14191
		[Token(Token = "0x400376F")]
		[FieldOffset(Offset = "0x1B8")]
		public ParticleSystem SmokeExhaleParticles;

		// Token: 0x04003770 RID: 14192
		[Token(Token = "0x4003770")]
		[FieldOffset(Offset = "0x1C0")]
		public UnityEvent onConsumeDone;

		// Token: 0x04003771 RID: 14193
		[Token(Token = "0x4003771")]
		[FieldOffset(Offset = "0x1C8")]
		private TimedCallback _effectsCooldownTimer;

		// Token: 0x04003772 RID: 14194
		[Token(Token = "0x4003772")]
		[FieldOffset(Offset = "0x1D0")]
		private bool _removeFromInventoryOnConsume;

		// Token: 0x04003773 RID: 14195
		[Token(Token = "0x4003773")]
		[FieldOffset(Offset = "0x1D1")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x04003774 RID: 14196
		[Token(Token = "0x4003774")]
		[FieldOffset(Offset = "0x1D2")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.ConsumeProductBehaviourAssembly-CSharp.dll_Excuted;
	}
}
