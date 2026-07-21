using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace ScheduleOne.Management
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	public class TransitRoute
	{
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x0600209F RID: 8351 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060020A0 RID: 8352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CE")]
		public ITransitEntity Source
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x43FFF0", Offset = "0x43F1F0", VA = "0x18043FFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x49B100", Offset = "0x49A300", VA = "0x18049B100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x060020A1 RID: 8353 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060020A2 RID: 8354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005CF")]
		public ITransitEntity Destination
		{
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x43FFD0", Offset = "0x43F1D0", VA = "0x18043FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x440000", Offset = "0x43F200", VA = "0x180440000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A3")]
		[Address(RVA = "0x687320", Offset = "0x686520", VA = "0x180687320")]
		public TransitRoute(ITransitEntity source, ITransitEntity destination)
		{
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A4")]
		[Address(RVA = "0x686C00", Offset = "0x685E00", VA = "0x180686C00")]
		public void Destroy()
		{
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A5")]
		[Address(RVA = "0x686E40", Offset = "0x686040", VA = "0x180686E40")]
		public void SetVisualsActive(bool active)
		{
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A6")]
		[Address(RVA = "0x687000", Offset = "0x686200", VA = "0x180687000")]
		private void Update()
		{
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A7")]
		[Address(RVA = "0x686E00", Offset = "0x686000", VA = "0x180686E00", Slot = "4")]
		public virtual void SetSource(ITransitEntity source)
		{
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x60020A8")]
		[Address(RVA = "0x686BD0", Offset = "0x685DD0", VA = "0x180686BD0")]
		public bool AreEntitiesNonNull()
		{
			return default(bool);
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x686DC0", Offset = "0x685FC0", VA = "0x180686DC0", Slot = "5")]
		public virtual void SetDestination(ITransitEntity destination)
		{
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x687270", Offset = "0x686470", VA = "0x180687270")]
		private void ValidateEntities()
		{
		}

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x20")]
		protected TransitLineVisuals visuals;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x28")]
		public Action<ITransitEntity> onSourceChange;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x30")]
		public Action<ITransitEntity> onDestinationChange;
	}
}
