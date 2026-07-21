using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.EntityFramework;
using ScheduleOne.Property;
using ScheduleOne.Temperature;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.Tiles
{
	// Token: 0x0200030B RID: 779
	[Token(Token = "0x200030B")]
	public class Grid : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001269 RID: 4713 RVA: 0x000087C0 File Offset: 0x000069C0
		// (set) Token: 0x0600126A RID: 4714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003CC")]
		public Guid GUID
		{
			[Token(Token = "0x6001269")]
			[Address(RVA = "0xB1E0F0", Offset = "0xB1D2F0", VA = "0x180B1E0F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x600126A")]
			[Address(RVA = "0xB1E100", Offset = "0xB1D300", VA = "0x180B1E100")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003CD")]
		public Property ParentProperty
		{
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x452430", Offset = "0x451630", VA = "0x180452430")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170003CE")]
		public Transform Container
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x7D10A0", Offset = "0x7D02A0", VA = "0x1807D10A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x170003CF")]
		public Vector3 Origin
		{
			[Token(Token = "0x600126D")]
			[Address(RVA = "0x92AA30", Offset = "0x929C30", VA = "0x18092AA30")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D0")]
		public TemperatureEmitterInfo[] TemperatureEmitterInfos
		{
			[Token(Token = "0x600126E")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600126F")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000087F0 File Offset: 0x000069F0
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D1")]
		public int Width
		{
			[Token(Token = "0x6001270")]
			[Address(RVA = "0x4D4840", Offset = "0x4D3A40", VA = "0x1804D4840")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001271")]
			[Address(RVA = "0x4D4B00", Offset = "0x4D3D00", VA = "0x1804D4B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00008808 File Offset: 0x00006A08
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D2")]
		public int Height
		{
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x6A0400", Offset = "0x69F600", VA = "0x1806A0400")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001273")]
			[Address(RVA = "0xABB290", Offset = "0xABA490", VA = "0x180ABB290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001274")]
		[Address(RVA = "0xB1C970", Offset = "0xB1BB70", VA = "0x180B1C970", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001275")]
		[Address(RVA = "0xB1D190", Offset = "0xB1C390", VA = "0x180B1D190")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001276")]
		[Address(RVA = "0xB1D590", Offset = "0xB1C790", VA = "0x180B1D590")]
		private void ProcessCoordinateDataPairs()
		{
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001277")]
		[Address(RVA = "0xB1D720", Offset = "0xB1C920", VA = "0x180B1D720")]
		public void RegisterTile(Tile tile)
		{
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001278")]
		[Address(RVA = "0xB1CCE0", Offset = "0xB1BEE0", VA = "0x180B1CCE0")]
		public void DeregisterTile(Tile tile)
		{
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001279")]
		[Address(RVA = "0xB1D6D0", Offset = "0xB1C8D0", VA = "0x180B1D6D0")]
		[Button]
		public void RegenerateGUID()
		{
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127A")]
		[Address(RVA = "0xB1DB30", Offset = "0xB1CD30", VA = "0x180B1DB30", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600127B")]
		[Address(RVA = "0xB1CE90", Offset = "0xB1C090", VA = "0x180B1CE90")]
		public Coordinate GetMatchedCoordinate(FootprintTile tileToMatch)
		{
			return null;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x600127C")]
		[Address(RVA = "0xB1D020", Offset = "0xB1C220", VA = "0x180B1D020")]
		public bool IsTileValidAtCoordinate(Coordinate gridCoord, FootprintTile tile, [Optional] GridItem tileOwner)
		{
			return default(bool);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600127D")]
		[Address(RVA = "0xB1CF90", Offset = "0xB1C190", VA = "0x180B1CF90")]
		public Tile GetTile(Coordinate coord)
		{
			return null;
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127E")]
		[Address(RVA = "0xB1DE20", Offset = "0xB1D020", VA = "0x180B1DE20")]
		[Button]
		public void SetVisible()
		{
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127F")]
		[Address(RVA = "0xB1DD10", Offset = "0xB1CF10", VA = "0x180B1DD10")]
		[Button]
		public void SetInvisible()
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001280")]
		[Address(RVA = "0xB1C730", Offset = "0xB1B930", VA = "0x180B1C730")]
		public void AddTemperatureEmitter(TemperatureEmitter emitter, bool onlyCosmetic)
		{
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001281")]
		[Address(RVA = "0xB1D8F0", Offset = "0xB1CAF0", VA = "0x180B1D8F0")]
		public void RemoveTemperatureEmitter(TemperatureEmitter emitter, bool onlyCosmetic)
		{
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001282")]
		[Address(RVA = "0xB1CCD0", Offset = "0xB1BED0", VA = "0x180B1CCD0")]
		private void CosmeticTemperatureEmittersChanged()
		{
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001283")]
		[Address(RVA = "0xB1DF30", Offset = "0xB1D130", VA = "0x180B1DF30")]
		private void TemperatureEmittersChanged()
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001284")]
		[Address(RVA = "0xB1DB90", Offset = "0xB1CD90", VA = "0x180B1DB90")]
		private void SetGridSize()
		{
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001285")]
		[Address(RVA = "0xB1DF40", Offset = "0xB1D140", VA = "0x180B1DF40")]
		public Grid()
		{
		}

		// Token: 0x040010CE RID: 4302
		[Token(Token = "0x40010CE")]
		public const float TileSize = 0.5f;

		// Token: 0x040010CF RID: 4303
		[Token(Token = "0x40010CF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Tile> Tiles;

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<CoordinateTilePair> CoordinateTilePairs;

		// Token: 0x040010D1 RID: 4305
		[Token(Token = "0x40010D1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Property _parentProperty;

		// Token: 0x040010D2 RID: 4306
		[Token(Token = "0x40010D2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("StaticGUID")]
		[SerializeField]
		private string _guid;

		// Token: 0x040010D4 RID: 4308
		[Token(Token = "0x40010D4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action<string, TemperatureEmitterInfo[]> OnCosmeticTemperatureEmittersChanged;

		// Token: 0x040010D5 RID: 4309
		[Token(Token = "0x40010D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Action<TemperatureEmitterInfo[]> OnTemperatureEmittersChanged;

		// Token: 0x040010D7 RID: 4311
		[Token(Token = "0x40010D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected Dictionary<Coordinate, Tile> _coordinateToTile;

		// Token: 0x040010D8 RID: 4312
		[Token(Token = "0x40010D8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected List<TemperatureEmitter> _cosmeticTemperatureEmitters;

		// Token: 0x040010D9 RID: 4313
		[Token(Token = "0x40010D9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected List<TemperatureEmitter> _temperatureEmitters;

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool _cosmeticEmittersChangedThisFrame;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool _emittersChangedThisFrame;
	}
}
