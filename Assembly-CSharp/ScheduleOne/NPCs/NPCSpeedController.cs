using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000A61 RID: 2657
	[Token(Token = "0x2000A61")]
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06004CC7 RID: 19655 RVA: 0x00014A60 File Offset: 0x00012C60
		// (set) Token: 0x06004CC8 RID: 19656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BEA")]
		public float SpeedMultiplier
		{
			[Token(Token = "0x6004CC7")]
			[Address(RVA = "0x492980", Offset = "0x491B80", VA = "0x180492980")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004CC8")]
			[Address(RVA = "0x92E9C0", Offset = "0x92DBC0", VA = "0x18092E9C0")]
			set
			{
			}
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x92E500", Offset = "0x92D700", VA = "0x18092E500")]
		private void Awake()
		{
		}

		// Token: 0x06004CCA RID: 19658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CCA")]
		[Address(RVA = "0x92E2C0", Offset = "0x92D4C0", VA = "0x18092E2C0")]
		public void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
		}

		// Token: 0x06004CCB RID: 19659 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6004CCB")]
		[Address(RVA = "0x92E690", Offset = "0x92D890", VA = "0x18092E690")]
		public NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			return null;
		}

		// Token: 0x06004CCC RID: 19660 RVA: 0x00014A78 File Offset: 0x00012C78
		[Token(Token = "0x6004CCC")]
		[Address(RVA = "0x92E5B0", Offset = "0x92D7B0", VA = "0x18092E5B0")]
		public bool DoesSpeedControlExist(string id)
		{
			return default(bool);
		}

		// Token: 0x06004CCD RID: 19661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CCD")]
		[Address(RVA = "0x92E770", Offset = "0x92D970", VA = "0x18092E770")]
		public void RemoveSpeedControl(string id)
		{
		}

		// Token: 0x06004CCE RID: 19662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CCE")]
		[Address(RVA = "0x92E890", Offset = "0x92DA90", VA = "0x18092E890")]
		private void UpdateActiveSpeedControl()
		{
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CCF")]
		[Address(RVA = "0x92E930", Offset = "0x92DB30", VA = "0x18092E930")]
		public NPCSpeedController()
		{
		}

		// Token: 0x040035DB RID: 13787
		[Token(Token = "0x40035DB")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[Range(0f, 1f)]
		public float DefaultWalkSpeed;

		// Token: 0x040035DC RID: 13788
		[Token(Token = "0x40035DC")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FormerlySerializedAs("SpeedMultiplier")]
		private float _SpeedMultiplier;

		// Token: 0x040035DD RID: 13789
		[Token(Token = "0x40035DD")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public NPCMovement Movement;

		// Token: 0x040035DE RID: 13790
		[Token(Token = "0x40035DE")]
		[FieldOffset(Offset = "0x30")]
		protected List<NPCSpeedController.SpeedControl> speedControlStack;

		// Token: 0x040035DF RID: 13791
		[Token(Token = "0x40035DF")]
		[FieldOffset(Offset = "0x38")]
		public NPCSpeedController.SpeedControl ActiveSpeedControl;

		// Token: 0x02000A62 RID: 2658
		[Token(Token = "0x2000A62")]
		[Serializable]
		public class SpeedControl
		{
			// Token: 0x06004CD0 RID: 19664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CD0")]
			[Address(RVA = "0x92EA40", Offset = "0x92DC40", VA = "0x18092EA40")]
			public SpeedControl(string id, int priority, float speed)
			{
			}

			// Token: 0x040035E0 RID: 13792
			[Token(Token = "0x40035E0")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x040035E1 RID: 13793
			[Token(Token = "0x40035E1")]
			[FieldOffset(Offset = "0x18")]
			public int priority;

			// Token: 0x040035E2 RID: 13794
			[Token(Token = "0x40035E2")]
			[FieldOffset(Offset = "0x1C")]
			public float speed;
		}
	}
}
