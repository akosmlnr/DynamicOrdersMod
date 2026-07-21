using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Combat;
using ScheduleOne.Dragging;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Trash
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(PhysicsDamageable))]
	[RequireComponent(typeof(Draggable))]
	public class TrashItem : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x000100E0 File Offset: 0x0000E2E0
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000874")]
		public Guid GUID
		{
			[Token(Token = "0x60035A1")]
			[Address(RVA = "0x72F480", Offset = "0x72E680", VA = "0x18072F480", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x60035A2")]
			[Address(RVA = "0x72F490", Offset = "0x72E690", VA = "0x18072F490")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060035A4 RID: 13732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000875")]
		public Property CurrentProperty
		{
			[Token(Token = "0x60035A3")]
			[Address(RVA = "0x4C3190", Offset = "0x4C2390", VA = "0x1804C3190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035A4")]
			[Address(RVA = "0x6380B0", Offset = "0x6372B0", VA = "0x1806380B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000876")]
		public string SaveFolderName
		{
			[Token(Token = "0x60035A5")]
			[Address(RVA = "0x7D9010", Offset = "0x7D8210", VA = "0x1807D9010", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000877")]
		public string SaveFileName
		{
			[Token(Token = "0x60035A6")]
			[Address(RVA = "0x7D8FA0", Offset = "0x7D81A0", VA = "0x1807D8FA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000878")]
		public Loader Loader
		{
			[Token(Token = "0x60035A7")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060035A8 RID: 13736 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x17000879")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60035A8")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087A")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60035A9")]
			[Address(RVA = "0x4CB630", Offset = "0x4CA830", VA = "0x1804CB630", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035AA")]
			[Address(RVA = "0x59B0A0", Offset = "0x59A2A0", VA = "0x18059B0A0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087B")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60035AB")]
			[Address(RVA = "0x674730", Offset = "0x673930", VA = "0x180674730", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60035AC")]
			[Address(RVA = "0x6747C0", Offset = "0x6739C0", VA = "0x1806747C0", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x00010110 File Offset: 0x0000E310
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700087C")]
		public bool HasChanged
		{
			[Token(Token = "0x60035AD")]
			[Address(RVA = "0x674710", Offset = "0x673910", VA = "0x180674710", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60035AE")]
			[Address(RVA = "0x6747B0", Offset = "0x6739B0", VA = "0x1806747B0", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060035AF RID: 13743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035AF")]
		[Address(RVA = "0x7D7350", Offset = "0x7D6550", VA = "0x1807D7350")]
		protected void Awake()
		{
		}

		// Token: 0x060035B0 RID: 13744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B0")]
		[Address(RVA = "0x7D8C60", Offset = "0x7D7E60", VA = "0x1807D8C60")]
		protected void Start()
		{
		}

		// Token: 0x060035B1 RID: 13745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B1")]
		[Address(RVA = "0x7D7CF0", Offset = "0x7D6EF0", VA = "0x1807D7CF0", Slot = "30")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060035B2 RID: 13746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B2")]
		[Address(RVA = "0x7D8190", Offset = "0x7D7390", VA = "0x1807D8190")]
		protected void OnValidate()
		{
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B3")]
		[Address(RVA = "0x7D7E30", Offset = "0x7D7030", VA = "0x1807D7E30")]
		protected void MinPass()
		{
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B4")]
		[Address(RVA = "0x7D7BE0", Offset = "0x7D6DE0", VA = "0x1807D7BE0")]
		protected void Hovered()
		{
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B5")]
		[Address(RVA = "0x7D7D80", Offset = "0x7D6F80", VA = "0x1807D7D80")]
		protected void Interacted()
		{
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B6")]
		[Address(RVA = "0x7D8A70", Offset = "0x7D7C70", VA = "0x1807D8A70", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B7")]
		[Address(RVA = "0x7D8C10", Offset = "0x7D7E10", VA = "0x1807D8C10")]
		public void SetVelocity(Vector3 velocity)
		{
		}

		// Token: 0x060035B8 RID: 13752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B8")]
		[Address(RVA = "0x7D78B0", Offset = "0x7D6AB0", VA = "0x1807D78B0")]
		public void DestroyTrash()
		{
		}

		// Token: 0x060035B9 RID: 13753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035B9")]
		[Address(RVA = "0x7D77B0", Offset = "0x7D69B0", VA = "0x1807D77B0", Slot = "31")]
		public virtual void Deinitialize()
		{
		}

		// Token: 0x060035BA RID: 13754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BA")]
		[Address(RVA = "0x7D8070", Offset = "0x7D7270", VA = "0x1807D8070")]
		private void OnDestroy()
		{
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BB")]
		[Address(RVA = "0x7D8320", Offset = "0x7D7520", VA = "0x1807D8320")]
		private void RecheckPosition()
		{
		}

		// Token: 0x060035BC RID: 13756 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035BC")]
		[Address(RVA = "0x7D7A70", Offset = "0x7D6C70", VA = "0x1807D7A70", Slot = "32")]
		public virtual TrashItemData GetData()
		{
			return null;
		}

		// Token: 0x060035BD RID: 13757 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60035BD")]
		[Address(RVA = "0x7D7BA0", Offset = "0x7D6DA0", VA = "0x1807D7BA0", Slot = "33")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x060035BE RID: 13758 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x60035BE")]
		[Address(RVA = "0x488CF0", Offset = "0x487EF0", VA = "0x180488CF0", Slot = "34")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060035BF RID: 13759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035BF")]
		[Address(RVA = "0x7D8490", Offset = "0x7D7690", VA = "0x1807D8490")]
		private void RecheckProperty()
		{
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C0")]
		[Address(RVA = "0x7D8920", Offset = "0x7D7B20", VA = "0x1807D8920")]
		public void SetContinuousCollisionDetection()
		{
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C1")]
		[Address(RVA = "0x7D89D0", Offset = "0x7D7BD0", VA = "0x1807D89D0")]
		public void SetDiscreteCollisionDetection()
		{
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x7D8BB0", Offset = "0x7D7DB0", VA = "0x1807D8BB0")]
		public void SetPhysicsActive(bool active)
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x7D8870", Offset = "0x7D7A70", VA = "0x1807D8870")]
		public void SetCollidersEnabled(bool enabled)
		{
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x7D8E70", Offset = "0x7D8070", VA = "0x1807D8E70")]
		public TrashItem()
		{
		}

		// Token: 0x040026E5 RID: 9957
		[Token(Token = "0x40026E5")]
		public const float POSITION_CHANGE_THRESHOLD = 1f;

		// Token: 0x040026E6 RID: 9958
		[Token(Token = "0x40026E6")]
		public const float LINEAR_DRAG = 0.1f;

		// Token: 0x040026E7 RID: 9959
		[Token(Token = "0x40026E7")]
		public const float ANGULAR_DRAG = 0.1f;

		// Token: 0x040026E8 RID: 9960
		[Token(Token = "0x40026E8")]
		public const float MIN_Y = -100f;

		// Token: 0x040026E9 RID: 9961
		[Token(Token = "0x40026E9")]
		public const int INTERACTION_PRIORITY = 5;

		// Token: 0x040026EA RID: 9962
		[Token(Token = "0x40026EA")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody Rigidbody;

		// Token: 0x040026EB RID: 9963
		[Token(Token = "0x40026EB")]
		[FieldOffset(Offset = "0x28")]
		public Draggable Draggable;

		// Token: 0x040026EC RID: 9964
		[Token(Token = "0x40026EC")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public string ID;

		// Token: 0x040026ED RID: 9965
		[Token(Token = "0x40026ED")]
		[FieldOffset(Offset = "0x38")]
		[Range(0f, 5f)]
		public int Size;

		// Token: 0x040026EE RID: 9966
		[Token(Token = "0x40026EE")]
		[FieldOffset(Offset = "0x3C")]
		[Range(0f, 10f)]
		public int SellValue;

		// Token: 0x040026EF RID: 9967
		[Token(Token = "0x40026EF")]
		[FieldOffset(Offset = "0x40")]
		public bool CanGoInContainer;

		// Token: 0x040026F0 RID: 9968
		[Token(Token = "0x40026F0")]
		[FieldOffset(Offset = "0x48")]
		public Collider[] colliders;

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 lastPosition;

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x78")]
		public Action<TrashItem> onDestroyed;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x80")]
		private bool collidersEnabled;

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x84")]
		private float timeOnPhysicsEnabled;
	}
}
