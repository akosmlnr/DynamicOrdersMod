using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne
{
	// Token: 0x02000240 RID: 576
	[Token(Token = "0x2000240")]
	public class Console : Singleton<Console>
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000280")]
		private static Player player
		{
			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0xAC9A20", Offset = "0xAC8C20", VA = "0x180AC9A20")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFD")]
		[Address(RVA = "0xAC8CB0", Offset = "0xAC7EB0", VA = "0x180AC8CB0")]
		private static void LogCommandError(string error)
		{
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0xAC8D90", Offset = "0xAC7F90", VA = "0x180AC8D90")]
		private static void LogUnrecognizedFormat(string[] correctExamples)
		{
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0xAC7E10", Offset = "0xAC7010", VA = "0x180AC7E10", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D00")]
		[Address(RVA = "0xAC7C60", Offset = "0xAC6E60", VA = "0x180AC7C60")]
		private void AddCommand(Console.ConsoleCommand command)
		{
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0xAC90C0", Offset = "0xAC82C0", VA = "0x180AC90C0")]
		private void RunStartupCommands()
		{
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0xAC8F50", Offset = "0xAC8150", VA = "0x180AC8F50")]
		[HideInCallstack]
		public static void Log(object message, [Optional] global::UnityEngine.Object context)
		{
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0xAC8EF0", Offset = "0xAC80F0", VA = "0x180AC8EF0")]
		[HideInCallstack]
		public static void LogWarning(object message, [Optional] global::UnityEngine.Object context)
		{
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0xAC8D30", Offset = "0xAC7F30", VA = "0x180AC8D30")]
		[HideInCallstack]
		public static void LogError(object message, [Optional] global::UnityEngine.Object context)
		{
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0xAC9300", Offset = "0xAC8500", VA = "0x180AC9300")]
		public static void SubmitCommand(List<string> args)
		{
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0xAC9550", Offset = "0xAC8750", VA = "0x180AC9550")]
		public static void SubmitCommand(string args)
		{
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0xAC7AD0", Offset = "0xAC6CD0", VA = "0x180AC7AD0")]
		public void AddBinding(KeyCode key, string command)
		{
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D08")]
		[Address(RVA = "0xAC8FB0", Offset = "0xAC81B0", VA = "0x180AC8FB0")]
		public void RemoveBinding(KeyCode key)
		{
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0xAC8BF0", Offset = "0xAC7DF0", VA = "0x180AC8BF0")]
		public void ClearBindings()
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0xAC9640", Offset = "0xAC8840", VA = "0x180AC9640")]
		private void Update()
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0B")]
		[Address(RVA = "0xAC9950", Offset = "0xAC8B50", VA = "0x180AC9950")]
		public Console()
		{
		}

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform TeleportPointsContainer;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Console.LabelledGameObject> LabelledGameObjectList;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Commands that run on startup (Editor only)")]
		public List<string> startupCommands;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<Console.ConsoleCommand> Commands;

		// Token: 0x04000CF1 RID: 3313
		[Token(Token = "0x4000CF1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Console.ConsoleCommand> commands;

		// Token: 0x04000CF2 RID: 3314
		[Token(Token = "0x4000CF2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<KeyCode, string> keyBindings;

		// Token: 0x02000241 RID: 577
		[Token(Token = "0x2000241")]
		public abstract class ConsoleCommand
		{
			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000D0D RID: 3341
			[Token(Token = "0x17000281")]
			public abstract string CommandWord
			{
				[Token(Token = "0x6000D0D")]
				get;
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000D0E RID: 3342
			[Token(Token = "0x17000282")]
			public abstract string CommandDescription
			{
				[Token(Token = "0x6000D0E")]
				get;
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000D0F RID: 3343
			[Token(Token = "0x17000283")]
			public abstract string ExampleUsage
			{
				[Token(Token = "0x6000D0F")]
				get;
			}

			// Token: 0x06000D10 RID: 3344
			[Token(Token = "0x6000D10")]
			public abstract void Execute(List<string> args);

			// Token: 0x06000D11 RID: 3345 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			protected ConsoleCommand()
			{
			}
		}

		// Token: 0x02000242 RID: 578
		[Token(Token = "0x2000242")]
		public class SetTimeCommand : Console.ConsoleCommand
		{
			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000284")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D12")]
				[Address(RVA = "0xACEB30", Offset = "0xACDD30", VA = "0x180ACEB30", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000285 RID: 645
			// (get) Token: 0x06000D13 RID: 3347 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000285")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D13")]
				[Address(RVA = "0xACEB00", Offset = "0xACDD00", VA = "0x180ACEB00", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000286")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D14")]
				[Address(RVA = "0xACEB60", Offset = "0xACDD60", VA = "0x180ACEB60", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D15 RID: 3349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D15")]
			[Address(RVA = "0xACE880", Offset = "0xACDA80", VA = "0x180ACE880", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetTimeCommand()
			{
			}
		}

		// Token: 0x02000243 RID: 579
		[Token(Token = "0x2000243")]
		public class SpawnVehicleCommand : Console.ConsoleCommand
		{
			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000D17 RID: 3351 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000287")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D17")]
				[Address(RVA = "0xACFC60", Offset = "0xACEE60", VA = "0x180ACFC60", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000288")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D18")]
				[Address(RVA = "0xACFC30", Offset = "0xACEE30", VA = "0x180ACFC30", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000D19 RID: 3353 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000289")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D19")]
				[Address(RVA = "0xACFC90", Offset = "0xACEE90", VA = "0x180ACFC90", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0xACF740", Offset = "0xACE940", VA = "0x180ACF740", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D1B RID: 3355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SpawnVehicleCommand()
			{
			}
		}

		// Token: 0x02000244 RID: 580
		[Token(Token = "0x2000244")]
		public class AddItemToInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700028A")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D1C")]
				[Address(RVA = "0xAC6A70", Offset = "0xAC5C70", VA = "0x180AC6A70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000D1D RID: 3357 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700028B")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D1D")]
				[Address(RVA = "0xAC6A40", Offset = "0xAC5C40", VA = "0x180AC6A40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700028C")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D1E")]
				[Address(RVA = "0xAC6AA0", Offset = "0xAC5CA0", VA = "0x180AC6AA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0xAC6490", Offset = "0xAC5690", VA = "0x180AC6490", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public AddItemToInventoryCommand()
			{
			}
		}

		// Token: 0x02000245 RID: 581
		[Token(Token = "0x2000245")]
		public class ClearInventoryCommand : Console.ConsoleCommand
		{
			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700028D")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D21")]
				[Address(RVA = "0xAC7880", Offset = "0xAC6A80", VA = "0x180AC7880", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700028E")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D22")]
				[Address(RVA = "0xAC7850", Offset = "0xAC6A50", VA = "0x180AC7850", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700028F")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D23")]
				[Address(RVA = "0xAC78B0", Offset = "0xAC6AB0", VA = "0x180AC78B0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0xAC7760", Offset = "0xAC6960", VA = "0x180AC7760", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ClearInventoryCommand()
			{
			}
		}

		// Token: 0x02000246 RID: 582
		[Token(Token = "0x2000246")]
		public class ChangeCashCommand : Console.ConsoleCommand
		{
			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000290")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D26")]
				[Address(RVA = "0xAC71F0", Offset = "0xAC63F0", VA = "0x180AC71F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000D27 RID: 3367 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000291")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D27")]
				[Address(RVA = "0xAC71C0", Offset = "0xAC63C0", VA = "0x180AC71C0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000292")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D28")]
				[Address(RVA = "0xAC7220", Offset = "0xAC6420", VA = "0x180AC7220", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D29")]
			[Address(RVA = "0xAC6F30", Offset = "0xAC6130", VA = "0x180AC6F30", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D2A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ChangeCashCommand()
			{
			}
		}

		// Token: 0x02000247 RID: 583
		[Token(Token = "0x2000247")]
		public class ChangeOnlineBalanceCommand : Console.ConsoleCommand
		{
			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000D2B RID: 3371 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000293")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D2B")]
				[Address(RVA = "0xAC7540", Offset = "0xAC6740", VA = "0x180AC7540", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000D2C RID: 3372 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000294")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D2C")]
				[Address(RVA = "0xAC7510", Offset = "0xAC6710", VA = "0x180AC7510", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000D2D RID: 3373 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000295")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D2D")]
				[Address(RVA = "0xAC7570", Offset = "0xAC6770", VA = "0x180AC7570", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D2E RID: 3374 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0xAC7250", Offset = "0xAC6450", VA = "0x180AC7250", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D2F RID: 3375 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ChangeOnlineBalanceCommand()
			{
			}
		}

		// Token: 0x02000248 RID: 584
		[Token(Token = "0x2000248")]
		public class SetMoveSpeedCommand : Console.ConsoleCommand
		{
			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000D30 RID: 3376 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000296")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D30")]
				[Address(RVA = "0xACCC40", Offset = "0xACBE40", VA = "0x180ACCC40", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000D31 RID: 3377 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000297")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D31")]
				[Address(RVA = "0xACCC10", Offset = "0xACBE10", VA = "0x180ACCC10", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000D32 RID: 3378 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000298")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D32")]
				[Address(RVA = "0xACCC70", Offset = "0xACBE70", VA = "0x180ACCC70", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D33 RID: 3379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D33")]
			[Address(RVA = "0xACCA70", Offset = "0xACBC70", VA = "0x180ACCA70", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D34 RID: 3380 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetMoveSpeedCommand()
			{
			}
		}

		// Token: 0x02000249 RID: 585
		[Token(Token = "0x2000249")]
		public class SetJumpMultiplier : Console.ConsoleCommand
		{
			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000D35 RID: 3381 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000299")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D35")]
				[Address(RVA = "0xACC750", Offset = "0xACB950", VA = "0x180ACC750", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000D36 RID: 3382 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700029A")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D36")]
				[Address(RVA = "0xACC720", Offset = "0xACB920", VA = "0x180ACC720", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000D37 RID: 3383 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700029B")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D37")]
				[Address(RVA = "0xACC780", Offset = "0xACB980", VA = "0x180ACC780", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D38 RID: 3384 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D38")]
			[Address(RVA = "0xACC580", Offset = "0xACB780", VA = "0x180ACC580", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetJumpMultiplier()
			{
			}
		}

		// Token: 0x0200024A RID: 586
		[Token(Token = "0x200024A")]
		public class SetPropertyOwned : Console.ConsoleCommand
		{
			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000D3A RID: 3386 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700029C")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D3A")]
				[Address(RVA = "0xACD140", Offset = "0xACC340", VA = "0x180ACD140", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000D3B RID: 3387 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700029D")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D3B")]
				[Address(RVA = "0xACD110", Offset = "0xACC310", VA = "0x180ACD110", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000D3C RID: 3388 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700029E")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D3C")]
				[Address(RVA = "0xACD170", Offset = "0xACC370", VA = "0x180ACD170", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0xACCCA0", Offset = "0xACBEA0", VA = "0x180ACCCA0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetPropertyOwned()
			{
			}
		}

		// Token: 0x0200024C RID: 588
		[Token(Token = "0x200024C")]
		public class Teleport : Console.ConsoleCommand
		{
			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000D42 RID: 3394 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700029F")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D42")]
				[Address(RVA = "0xAD0640", Offset = "0xACF840", VA = "0x180AD0640", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000D43 RID: 3395 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A0")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D43")]
				[Address(RVA = "0xAD0610", Offset = "0xACF810", VA = "0x180AD0610", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000D44 RID: 3396 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A1")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D44")]
				[Address(RVA = "0xAD0670", Offset = "0xACF870", VA = "0x180AD0670", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0xACFCC0", Offset = "0xACEEC0", VA = "0x180ACFCC0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Teleport()
			{
			}
		}

		// Token: 0x0200024D RID: 589
		[Token(Token = "0x200024D")]
		public class PackageProduct : Console.ConsoleCommand
		{
			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000D47 RID: 3399 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A2")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D47")]
				[Address(RVA = "0xACB3C0", Offset = "0xACA5C0", VA = "0x180ACB3C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000D48 RID: 3400 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A3")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D48")]
				[Address(RVA = "0xACB390", Offset = "0xACA590", VA = "0x180ACB390", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000D49 RID: 3401 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A4")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D49")]
				[Address(RVA = "0xACB3F0", Offset = "0xACA5F0", VA = "0x180ACB3F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D4A RID: 3402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0xACAF60", Offset = "0xACA160", VA = "0x180ACAF60", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public PackageProduct()
			{
			}
		}

		// Token: 0x0200024E RID: 590
		[Token(Token = "0x200024E")]
		public class SetStaminaReserve : Console.ConsoleCommand
		{
			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000D4C RID: 3404 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A5")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D4C")]
				[Address(RVA = "0xACE820", Offset = "0xACDA20", VA = "0x180ACE820", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A6")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D4D")]
				[Address(RVA = "0xACE7F0", Offset = "0xACD9F0", VA = "0x180ACE7F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000D4E RID: 3406 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A7")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D4E")]
				[Address(RVA = "0xACE850", Offset = "0xACDA50", VA = "0x180ACE850", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D4F RID: 3407 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0xACE610", Offset = "0xACD810", VA = "0x180ACE610", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D50")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetStaminaReserve()
			{
			}
		}

		// Token: 0x0200024F RID: 591
		[Token(Token = "0x200024F")]
		public class SetWeather : Console.ConsoleCommand
		{
			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000D51 RID: 3409 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A8")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D51")]
				[Address(RVA = "0xACF6E0", Offset = "0xACE8E0", VA = "0x180ACF6E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000D52 RID: 3410 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002A9")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D52")]
				[Address(RVA = "0xACF6B0", Offset = "0xACE8B0", VA = "0x180ACF6B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000D53 RID: 3411 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002AA")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D53")]
				[Address(RVA = "0xACF710", Offset = "0xACE910", VA = "0x180ACF710", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D54 RID: 3412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D54")]
			[Address(RVA = "0xACF520", Offset = "0xACE720", VA = "0x180ACF520", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D55 RID: 3413 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D55")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetWeather()
			{
			}
		}

		// Token: 0x02000250 RID: 592
		[Token(Token = "0x2000250")]
		public class SetWeatherSpeed : Console.ConsoleCommand
		{
			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000D56 RID: 3414 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002AB")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D56")]
				[Address(RVA = "0xACF4C0", Offset = "0xACE6C0", VA = "0x180ACF4C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000D57 RID: 3415 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002AC")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D57")]
				[Address(RVA = "0xACF490", Offset = "0xACE690", VA = "0x180ACF490", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000D58 RID: 3416 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002AD")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D58")]
				[Address(RVA = "0xACF4F0", Offset = "0xACE6F0", VA = "0x180ACF4F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D59 RID: 3417 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D59")]
			[Address(RVA = "0xACF300", Offset = "0xACE500", VA = "0x180ACF300", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D5A RID: 3418 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D5A")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetWeatherSpeed()
			{
			}
		}

		// Token: 0x02000251 RID: 593
		[Token(Token = "0x2000251")]
		public class TriggerLightning : Console.ConsoleCommand
		{
			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000D5B RID: 3419 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002AE")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D5B")]
				[Address(RVA = "0xAD0A80", Offset = "0xACFC80", VA = "0x180AD0A80", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002AF")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D5C")]
				[Address(RVA = "0xAD0A50", Offset = "0xACFC50", VA = "0x180AD0A50", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000D5D RID: 3421 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B0")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D5D")]
				[Address(RVA = "0xAD0AB0", Offset = "0xACFCB0", VA = "0x180AD0AB0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D5E RID: 3422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D5E")]
			[Address(RVA = "0xAD07B0", Offset = "0xACF9B0", VA = "0x180AD07B0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D5F RID: 3423 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public TriggerLightning()
			{
			}
		}

		// Token: 0x02000252 RID: 594
		[Token(Token = "0x2000252")]
		public class TriggerDistantThunder : Console.ConsoleCommand
		{
			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B1")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D60")]
				[Address(RVA = "0xAD0750", Offset = "0xACF950", VA = "0x180AD0750", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000D61 RID: 3425 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B2")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D61")]
				[Address(RVA = "0xAD0720", Offset = "0xACF920", VA = "0x180AD0720", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000D62 RID: 3426 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B3")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D62")]
				[Address(RVA = "0xAD0780", Offset = "0xACF980", VA = "0x180AD0780", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D63 RID: 3427 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D63")]
			[Address(RVA = "0xAD06A0", Offset = "0xACF8A0", VA = "0x180AD06A0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D64 RID: 3428 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public TriggerDistantThunder()
			{
			}
		}

		// Token: 0x02000253 RID: 595
		[Token(Token = "0x2000253")]
		public class RaisedWanted : Console.ConsoleCommand
		{
			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000D65 RID: 3429 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B4")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D65")]
				[Address(RVA = "0xACB6C0", Offset = "0xACA8C0", VA = "0x180ACB6C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000D66 RID: 3430 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B5")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D66")]
				[Address(RVA = "0xACB690", Offset = "0xACA890", VA = "0x180ACB690", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000D67 RID: 3431 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B6")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D67")]
				[Address(RVA = "0xACB6F0", Offset = "0xACA8F0", VA = "0x180ACB6F0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D68 RID: 3432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0xACB420", Offset = "0xACA620", VA = "0x180ACB420", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D69 RID: 3433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public RaisedWanted()
			{
			}
		}

		// Token: 0x02000254 RID: 596
		[Token(Token = "0x2000254")]
		public class LowerWanted : Console.ConsoleCommand
		{
			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000D6A RID: 3434 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B7")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D6A")]
				[Address(RVA = "0xACAF00", Offset = "0xACA100", VA = "0x180ACAF00", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000D6B RID: 3435 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B8")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D6B")]
				[Address(RVA = "0xACAED0", Offset = "0xACA0D0", VA = "0x180ACAED0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000D6C RID: 3436 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002B9")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D6C")]
				[Address(RVA = "0xACAF30", Offset = "0xACA130", VA = "0x180ACAF30", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D6D RID: 3437 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0xACADD0", Offset = "0xAC9FD0", VA = "0x180ACADD0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D6E RID: 3438 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public LowerWanted()
			{
			}
		}

		// Token: 0x02000255 RID: 597
		[Token(Token = "0x2000255")]
		public class ClearWanted : Console.ConsoleCommand
		{
			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002BA")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D6F")]
				[Address(RVA = "0xAC7A70", Offset = "0xAC6C70", VA = "0x180AC7A70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000D70 RID: 3440 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002BB")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D70")]
				[Address(RVA = "0xAC7A40", Offset = "0xAC6C40", VA = "0x180AC7A40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002BC")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D71")]
				[Address(RVA = "0xAC7AA0", Offset = "0xAC6CA0", VA = "0x180AC7AA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0xAC78E0", Offset = "0xAC6AE0", VA = "0x180AC78E0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D73 RID: 3443 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ClearWanted()
			{
			}
		}

		// Token: 0x02000256 RID: 598
		[Token(Token = "0x2000256")]
		public class SetHealth : Console.ConsoleCommand
		{
			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000D74 RID: 3444 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002BD")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D74")]
				[Address(RVA = "0xACC520", Offset = "0xACB720", VA = "0x180ACC520", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000D75 RID: 3445 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002BE")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D75")]
				[Address(RVA = "0xACC4F0", Offset = "0xACB6F0", VA = "0x180ACC4F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002BF")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D76")]
				[Address(RVA = "0xACC550", Offset = "0xACB750", VA = "0x180ACC550", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D77 RID: 3447 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0xACC270", Offset = "0xACB470", VA = "0x180ACC270", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D78 RID: 3448 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetHealth()
			{
			}
		}

		// Token: 0x02000257 RID: 599
		[Token(Token = "0x2000257")]
		public class SetEnergy : Console.ConsoleCommand
		{
			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000D79 RID: 3449 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C0")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D79")]
				[Address(RVA = "0xACC210", Offset = "0xACB410", VA = "0x180ACC210", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000D7A RID: 3450 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C1")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D7A")]
				[Address(RVA = "0xACC1E0", Offset = "0xACB3E0", VA = "0x180ACC1E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000D7B RID: 3451 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C2")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D7B")]
				[Address(RVA = "0xACC240", Offset = "0xACB440", VA = "0x180ACC240", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D7C RID: 3452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0xACC000", Offset = "0xACB200", VA = "0x180ACC000", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D7D RID: 3453 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetEnergy()
			{
			}
		}

		// Token: 0x02000258 RID: 600
		[Token(Token = "0x2000258")]
		public class FreeCamCommand : Console.ConsoleCommand
		{
			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x06000D7E RID: 3454 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C3")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D7E")]
				[Address(RVA = "0xACA7E0", Offset = "0xAC99E0", VA = "0x180ACA7E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x06000D7F RID: 3455 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C4")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D7F")]
				[Address(RVA = "0xACA7B0", Offset = "0xAC99B0", VA = "0x180ACA7B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06000D80 RID: 3456 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C5")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D80")]
				[Address(RVA = "0xACA810", Offset = "0xAC9A10", VA = "0x180ACA810", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D81")]
			[Address(RVA = "0xACA680", Offset = "0xAC9880", VA = "0x180ACA680", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D82 RID: 3458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D82")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public FreeCamCommand()
			{
			}
		}

		// Token: 0x02000259 RID: 601
		[Token(Token = "0x2000259")]
		public class Save : Console.ConsoleCommand
		{
			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06000D83 RID: 3459 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C6")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D83")]
				[Address(RVA = "0xACB840", Offset = "0xACAA40", VA = "0x180ACB840", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C7 RID: 711
			// (get) Token: 0x06000D84 RID: 3460 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C7")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D84")]
				[Address(RVA = "0xACB810", Offset = "0xACAA10", VA = "0x180ACB810", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000D85 RID: 3461 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C8")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D85")]
				[Address(RVA = "0xACB870", Offset = "0xACAA70", VA = "0x180ACB870", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D86 RID: 3462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D86")]
			[Address(RVA = "0xACB720", Offset = "0xACA920", VA = "0x180ACB720", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D87 RID: 3463 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D87")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Save()
			{
			}
		}

		// Token: 0x0200025A RID: 602
		[Token(Token = "0x200025A")]
		public class SetTimeScale : Console.ConsoleCommand
		{
			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000D88 RID: 3464 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002C9")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D88")]
				[Address(RVA = "0xACEDE0", Offset = "0xACDFE0", VA = "0x180ACEDE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000D89 RID: 3465 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002CA")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D89")]
				[Address(RVA = "0xACEDB0", Offset = "0xACDFB0", VA = "0x180ACEDB0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06000D8A RID: 3466 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002CB")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D8A")]
				[Address(RVA = "0xACEE10", Offset = "0xACE010", VA = "0x180ACEE10", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D8B RID: 3467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D8B")]
			[Address(RVA = "0xACEB90", Offset = "0xACDD90", VA = "0x180ACEB90", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D8C RID: 3468 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D8C")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetTimeScale()
			{
			}
		}

		// Token: 0x0200025B RID: 603
		[Token(Token = "0x200025B")]
		public class SetVariableValue : Console.ConsoleCommand
		{
			// Token: 0x170002CC RID: 716
			// (get) Token: 0x06000D8D RID: 3469 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002CC")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D8D")]
				[Address(RVA = "0xACF2A0", Offset = "0xACE4A0", VA = "0x180ACF2A0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06000D8E RID: 3470 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002CD")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D8E")]
				[Address(RVA = "0xACF270", Offset = "0xACE470", VA = "0x180ACF270", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06000D8F RID: 3471 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002CE")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D8F")]
				[Address(RVA = "0xACF2D0", Offset = "0xACE4D0", VA = "0x180ACF2D0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D90 RID: 3472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D90")]
			[Address(RVA = "0xACF0C0", Offset = "0xACE2C0", VA = "0x180ACF0C0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D91 RID: 3473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetVariableValue()
			{
			}
		}

		// Token: 0x0200025C RID: 604
		[Token(Token = "0x200025C")]
		public class SetQuestState : Console.ConsoleCommand
		{
			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000D92 RID: 3474 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002CF")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D92")]
				[Address(RVA = "0xACE2B0", Offset = "0xACD4B0", VA = "0x180ACE2B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x06000D93 RID: 3475 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D0")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D93")]
				[Address(RVA = "0xACE280", Offset = "0xACD480", VA = "0x180ACE280", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D1 RID: 721
			// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D1")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D94")]
				[Address(RVA = "0xACE2E0", Offset = "0xACD4E0", VA = "0x180ACE2E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D95 RID: 3477 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0xACDEE0", Offset = "0xACD0E0", VA = "0x180ACDEE0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D96 RID: 3478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D96")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetQuestState()
			{
			}
		}

		// Token: 0x0200025D RID: 605
		[Token(Token = "0x200025D")]
		public class SetQuestEntryState : Console.ConsoleCommand
		{
			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000D97 RID: 3479 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D2")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D97")]
				[Address(RVA = "0xACDE80", Offset = "0xACD080", VA = "0x180ACDE80", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D3")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D98")]
				[Address(RVA = "0xACDE50", Offset = "0xACD050", VA = "0x180ACDE50", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000D99 RID: 3481 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D4")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D99")]
				[Address(RVA = "0xACDEB0", Offset = "0xACD0B0", VA = "0x180ACDEB0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D9A RID: 3482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D9A")]
			[Address(RVA = "0xACD940", Offset = "0xACCB40", VA = "0x180ACD940", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetQuestEntryState()
			{
			}
		}

		// Token: 0x0200025E RID: 606
		[Token(Token = "0x200025E")]
		public class SetEmotion : Console.ConsoleCommand
		{
			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D5")]
			public override string CommandWord
			{
				[Token(Token = "0x6000D9C")]
				[Address(RVA = "0xACBFA0", Offset = "0xACB1A0", VA = "0x180ACBFA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D6 RID: 726
			// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D6")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000D9D")]
				[Address(RVA = "0xACBF70", Offset = "0xACB170", VA = "0x180ACBF70", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D7")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000D9E")]
				[Address(RVA = "0xACBFD0", Offset = "0xACB1D0", VA = "0x180ACBFD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000D9F RID: 3487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0xACBC10", Offset = "0xACAE10", VA = "0x180ACBC10", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DA0 RID: 3488 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetEmotion()
			{
			}
		}

		// Token: 0x0200025F RID: 607
		[Token(Token = "0x200025F")]
		public class SetUnlocked : Console.ConsoleCommand
		{
			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D8")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DA1")]
				[Address(RVA = "0xACF060", Offset = "0xACE260", VA = "0x180ACF060", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002D9")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DA2")]
				[Address(RVA = "0xACF030", Offset = "0xACE230", VA = "0x180ACF030", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002DA")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DA3")]
				[Address(RVA = "0xACF090", Offset = "0xACE290", VA = "0x180ACF090", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DA4 RID: 3492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0xACEE40", Offset = "0xACE040", VA = "0x180ACEE40", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DA5 RID: 3493 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetUnlocked()
			{
			}
		}

		// Token: 0x02000260 RID: 608
		[Token(Token = "0x2000260")]
		public class SetRelationship : Console.ConsoleCommand
		{
			// Token: 0x170002DB RID: 731
			// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002DB")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DA6")]
				[Address(RVA = "0xACE5B0", Offset = "0xACD7B0", VA = "0x180ACE5B0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002DC")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DA7")]
				[Address(RVA = "0xACE580", Offset = "0xACD780", VA = "0x180ACE580", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002DD")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DA8")]
				[Address(RVA = "0xACE5E0", Offset = "0xACD7E0", VA = "0x180ACE5E0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DA9 RID: 3497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0xACE310", Offset = "0xACD510", VA = "0x180ACE310", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DAA RID: 3498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetRelationship()
			{
			}
		}

		// Token: 0x02000261 RID: 609
		[Token(Token = "0x2000261")]
		public class AddEmployeeCommand : Console.ConsoleCommand
		{
			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000DAB RID: 3499 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002DE")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DAB")]
				[Address(RVA = "0xAC6430", Offset = "0xAC5630", VA = "0x180AC6430", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000DAC RID: 3500 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002DF")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DAC")]
				[Address(RVA = "0xAC6400", Offset = "0xAC5600", VA = "0x180AC6400", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E0 RID: 736
			// (get) Token: 0x06000DAD RID: 3501 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E0")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DAD")]
				[Address(RVA = "0xAC6460", Offset = "0xAC5660", VA = "0x180AC6460", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0xAC5EE0", Offset = "0xAC50E0", VA = "0x180AC5EE0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DAF RID: 3503 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DAF")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public AddEmployeeCommand()
			{
			}
		}

		// Token: 0x02000263 RID: 611
		[Token(Token = "0x2000263")]
		public class SetDiscovered : Console.ConsoleCommand
		{
			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E1")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DB2")]
				[Address(RVA = "0xACBBB0", Offset = "0xACADB0", VA = "0x180ACBBB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E2")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DB3")]
				[Address(RVA = "0xACBB80", Offset = "0xACAD80", VA = "0x180ACBB80", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E3")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DB4")]
				[Address(RVA = "0xACBBE0", Offset = "0xACADE0", VA = "0x180ACBBE0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DB5 RID: 3509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0xACB8A0", Offset = "0xACAAA0", VA = "0x180ACB8A0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DB6 RID: 3510 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetDiscovered()
			{
			}
		}

		// Token: 0x02000264 RID: 612
		[Token(Token = "0x2000264")]
		public class GrowPlants : Console.ConsoleCommand
		{
			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E4")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DB7")]
				[Address(RVA = "0xACAC50", Offset = "0xAC9E50", VA = "0x180ACAC50", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E5 RID: 741
			// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E5")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DB8")]
				[Address(RVA = "0xACAC20", Offset = "0xAC9E20", VA = "0x180ACAC20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E6")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DB9")]
				[Address(RVA = "0xACAC80", Offset = "0xAC9E80", VA = "0x180ACAC80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DBA RID: 3514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0xACAAD0", Offset = "0xAC9CD0", VA = "0x180ACAAD0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DBB RID: 3515 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public GrowPlants()
			{
			}
		}

		// Token: 0x02000265 RID: 613
		[Token(Token = "0x2000265")]
		public class SetLawIntensity : Console.ConsoleCommand
		{
			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x06000DBC RID: 3516 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E7")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DBC")]
				[Address(RVA = "0xACCA10", Offset = "0xACBC10", VA = "0x180ACCA10", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E8")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DBD")]
				[Address(RVA = "0xACC9E0", Offset = "0xACBBE0", VA = "0x180ACC9E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x06000DBE RID: 3518 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002E9")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DBE")]
				[Address(RVA = "0xACCA40", Offset = "0xACBC40", VA = "0x180ACCA40", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DBF RID: 3519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0xACC7B0", Offset = "0xACB9B0", VA = "0x180ACC7B0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC0")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetLawIntensity()
			{
			}
		}

		// Token: 0x02000266 RID: 614
		[Token(Token = "0x2000266")]
		public class SetQuality : Console.ConsoleCommand
		{
			// Token: 0x170002EA RID: 746
			// (get) Token: 0x06000DC1 RID: 3521 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002EA")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DC1")]
				[Address(RVA = "0xACD600", Offset = "0xACC800", VA = "0x180ACD600", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EB RID: 747
			// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002EB")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DC2")]
				[Address(RVA = "0xACD5D0", Offset = "0xACC7D0", VA = "0x180ACD5D0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EC RID: 748
			// (get) Token: 0x06000DC3 RID: 3523 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002EC")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DC3")]
				[Address(RVA = "0xACD630", Offset = "0xACC830", VA = "0x180ACD630", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DC4 RID: 3524 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC4")]
			[Address(RVA = "0xACD1A0", Offset = "0xACC3A0", VA = "0x180ACD1A0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DC5 RID: 3525 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetQuality()
			{
			}
		}

		// Token: 0x02000267 RID: 615
		[Token(Token = "0x2000267")]
		public class SetQuantity : Console.ConsoleCommand
		{
			// Token: 0x170002ED RID: 749
			// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002ED")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DC6")]
				[Address(RVA = "0xACD8E0", Offset = "0xACCAE0", VA = "0x180ACD8E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EE RID: 750
			// (get) Token: 0x06000DC7 RID: 3527 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002EE")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DC7")]
				[Address(RVA = "0xACD8B0", Offset = "0xACCAB0", VA = "0x180ACD8B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002EF RID: 751
			// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002EF")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DC8")]
				[Address(RVA = "0xACD910", Offset = "0xACCB10", VA = "0x180ACD910", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DC9 RID: 3529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DC9")]
			[Address(RVA = "0xACD660", Offset = "0xACC860", VA = "0x180ACD660", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DCA RID: 3530 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public SetQuantity()
			{
			}
		}

		// Token: 0x02000268 RID: 616
		[Token(Token = "0x2000268")]
		public class Bind : Console.ConsoleCommand
		{
			// Token: 0x170002F0 RID: 752
			// (get) Token: 0x06000DCB RID: 3531 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F0")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DCB")]
				[Address(RVA = "0xAC6ED0", Offset = "0xAC60D0", VA = "0x180AC6ED0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F1 RID: 753
			// (get) Token: 0x06000DCC RID: 3532 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F1")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DCC")]
				[Address(RVA = "0xAC6EA0", Offset = "0xAC60A0", VA = "0x180AC6EA0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F2 RID: 754
			// (get) Token: 0x06000DCD RID: 3533 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F2")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DCD")]
				[Address(RVA = "0xAC6F00", Offset = "0xAC6100", VA = "0x180AC6F00", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DCE RID: 3534 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0xAC6AD0", Offset = "0xAC5CD0", VA = "0x180AC6AD0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Bind()
			{
			}
		}

		// Token: 0x02000269 RID: 617
		[Token(Token = "0x2000269")]
		public class Unbind : Console.ConsoleCommand
		{
			// Token: 0x170002F3 RID: 755
			// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F3")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DD0")]
				[Address(RVA = "0xAE2430", Offset = "0xAE1630", VA = "0x180AE2430", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F4 RID: 756
			// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F4")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DD1")]
				[Address(RVA = "0xAE2400", Offset = "0xAE1600", VA = "0x180AE2400", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F5 RID: 757
			// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F5")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DD2")]
				[Address(RVA = "0xAE2460", Offset = "0xAE1660", VA = "0x180AE2460", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0xAE20F0", Offset = "0xAE12F0", VA = "0x180AE20F0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DD4 RID: 3540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Unbind()
			{
			}
		}

		// Token: 0x0200026A RID: 618
		[Token(Token = "0x200026A")]
		public class ClearBinds : Console.ConsoleCommand
		{
			// Token: 0x170002F6 RID: 758
			// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F6")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DD5")]
				[Address(RVA = "0xAC7700", Offset = "0xAC6900", VA = "0x180AC7700", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F7 RID: 759
			// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F7")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DD6")]
				[Address(RVA = "0xAC76D0", Offset = "0xAC68D0", VA = "0x180AC76D0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002F8 RID: 760
			// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F8")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DD7")]
				[Address(RVA = "0xAC7730", Offset = "0xAC6930", VA = "0x180AC7730", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DD8 RID: 3544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0xAC75A0", Offset = "0xAC67A0", VA = "0x180AC75A0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DD9 RID: 3545 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public ClearBinds()
			{
			}
		}

		// Token: 0x0200026B RID: 619
		[Token(Token = "0x200026B")]
		public class HideUI : Console.ConsoleCommand
		{
			// Token: 0x170002F9 RID: 761
			// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002F9")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DDA")]
				[Address(RVA = "0xACAD70", Offset = "0xAC9F70", VA = "0x180ACAD70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002FA RID: 762
			// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002FA")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DDB")]
				[Address(RVA = "0xACAD40", Offset = "0xAC9F40", VA = "0x180ACAD40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002FB RID: 763
			// (get) Token: 0x06000DDC RID: 3548 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002FB")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DDC")]
				[Address(RVA = "0xACADA0", Offset = "0xAC9FA0", VA = "0x180ACADA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DDD RID: 3549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0xACACB0", Offset = "0xAC9EB0", VA = "0x180ACACB0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DDE RID: 3550 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public HideUI()
			{
			}
		}

		// Token: 0x0200026C RID: 620
		[Token(Token = "0x200026C")]
		public class GiveXP : Console.ConsoleCommand
		{
			// Token: 0x170002FC RID: 764
			// (get) Token: 0x06000DDF RID: 3551 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002FC")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DDF")]
				[Address(RVA = "0xACAA70", Offset = "0xAC9C70", VA = "0x180ACAA70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002FD RID: 765
			// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002FD")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DE0")]
				[Address(RVA = "0xACAA40", Offset = "0xAC9C40", VA = "0x180ACAA40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x170002FE RID: 766
			// (get) Token: 0x06000DE1 RID: 3553 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002FE")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DE1")]
				[Address(RVA = "0xACAAA0", Offset = "0xAC9CA0", VA = "0x180ACAAA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DE2 RID: 3554 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DE2")]
			[Address(RVA = "0xACA840", Offset = "0xAC9A40", VA = "0x180ACA840", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DE3 RID: 3555 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public GiveXP()
			{
			}
		}

		// Token: 0x0200026D RID: 621
		[Token(Token = "0x200026D")]
		public class Disable : Console.ConsoleCommand
		{
			// Token: 0x170002FF RID: 767
			// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x170002FF")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DE4")]
				[Address(RVA = "0xACA1E0", Offset = "0xAC93E0", VA = "0x180ACA1E0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000300 RID: 768
			// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000300")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DE5")]
				[Address(RVA = "0xACA1B0", Offset = "0xAC93B0", VA = "0x180ACA1B0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000301 RID: 769
			// (get) Token: 0x06000DE6 RID: 3558 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000301")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DE6")]
				[Address(RVA = "0xACA210", Offset = "0xAC9410", VA = "0x180ACA210", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DE7 RID: 3559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DE7")]
			[Address(RVA = "0xAC9EB0", Offset = "0xAC90B0", VA = "0x180AC9EB0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DE8 RID: 3560 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DE8")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Disable()
			{
			}
		}

		// Token: 0x0200026F RID: 623
		[Token(Token = "0x200026F")]
		public class Enable : Console.ConsoleCommand
		{
			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000302")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DEB")]
				[Address(RVA = "0xACA510", Offset = "0xAC9710", VA = "0x180ACA510", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000303 RID: 771
			// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000303")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DEC")]
				[Address(RVA = "0xACA4E0", Offset = "0xAC96E0", VA = "0x180ACA4E0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000304 RID: 772
			// (get) Token: 0x06000DED RID: 3565 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000304")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DED")]
				[Address(RVA = "0xACA540", Offset = "0xAC9740", VA = "0x180ACA540", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DEE RID: 3566 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0xACA240", Offset = "0xAC9440", VA = "0x180ACA240", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public Enable()
			{
			}
		}

		// Token: 0x02000271 RID: 625
		[Token(Token = "0x2000271")]
		public class EndTutorial : Console.ConsoleCommand
		{
			// Token: 0x17000305 RID: 773
			// (get) Token: 0x06000DF2 RID: 3570 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000305")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DF2")]
				[Address(RVA = "0xACA620", Offset = "0xAC9820", VA = "0x180ACA620", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000306 RID: 774
			// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000306")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DF3")]
				[Address(RVA = "0xACA5F0", Offset = "0xAC97F0", VA = "0x180ACA5F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000307 RID: 775
			// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000307")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DF4")]
				[Address(RVA = "0xACA650", Offset = "0xAC9850", VA = "0x180ACA650", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DF5 RID: 3573 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DF5")]
			[Address(RVA = "0xACA570", Offset = "0xAC9770", VA = "0x180ACA570", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DF6 RID: 3574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DF6")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public EndTutorial()
			{
			}
		}

		// Token: 0x02000272 RID: 626
		[Token(Token = "0x2000272")]
		public class DisableNPCAsset : Console.ConsoleCommand
		{
			// Token: 0x17000308 RID: 776
			// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000308")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DF7")]
				[Address(RVA = "0xAC9E50", Offset = "0xAC9050", VA = "0x180AC9E50", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000309 RID: 777
			// (get) Token: 0x06000DF8 RID: 3576 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000309")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DF8")]
				[Address(RVA = "0xAC9E20", Offset = "0xAC9020", VA = "0x180AC9E20", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700030A RID: 778
			// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700030A")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DF9")]
				[Address(RVA = "0xAC9E80", Offset = "0xAC9080", VA = "0x180AC9E80", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DFA RID: 3578 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0xAC9AD0", Offset = "0xAC8CD0", VA = "0x180AC9AD0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000DFB RID: 3579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DFB")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public DisableNPCAsset()
			{
			}
		}

		// Token: 0x02000273 RID: 627
		[Token(Token = "0x2000273")]
		public class ShowFPS : Console.ConsoleCommand
		{
			// Token: 0x1700030B RID: 779
			// (get) Token: 0x06000DFC RID: 3580 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700030B")]
			public override string CommandWord
			{
				[Token(Token = "0x6000DFC")]
				[Address(RVA = "0xAFB010", Offset = "0xAFA210", VA = "0x180AFB010", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700030C RID: 780
			// (get) Token: 0x06000DFD RID: 3581 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700030C")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000DFD")]
				[Address(RVA = "0xAFAFE0", Offset = "0xAFA1E0", VA = "0x180AFAFE0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700030D RID: 781
			// (get) Token: 0x06000DFE RID: 3582 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700030D")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000DFE")]
				[Address(RVA = "0xAFB040", Offset = "0xAFA240", VA = "0x180AFB040", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000DFF RID: 3583 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0xAFAF40", Offset = "0xAFA140", VA = "0x180AFAF40", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E00 RID: 3584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public ShowFPS()
			{
			}
		}

		// Token: 0x02000274 RID: 628
		[Token(Token = "0x2000274")]
		public class HideFPS : Console.ConsoleCommand
		{
			// Token: 0x1700030E RID: 782
			// (get) Token: 0x06000E01 RID: 3585 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700030E")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E01")]
				[Address(RVA = "0xAE9E30", Offset = "0xAE9030", VA = "0x180AE9E30", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700030F RID: 783
			// (get) Token: 0x06000E02 RID: 3586 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700030F")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E02")]
				[Address(RVA = "0xAE9E00", Offset = "0xAE9000", VA = "0x180AE9E00", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000310 RID: 784
			// (get) Token: 0x06000E03 RID: 3587 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000310")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E03")]
				[Address(RVA = "0xAE9E60", Offset = "0xAE9060", VA = "0x180AE9E60", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E04 RID: 3588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E04")]
			[Address(RVA = "0xAE9D60", Offset = "0xAE8F60", VA = "0x180AE9D60", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E05 RID: 3589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E05")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public HideFPS()
			{
			}
		}

		// Token: 0x02000275 RID: 629
		[Token(Token = "0x2000275")]
		public class ClearTrash : Console.ConsoleCommand
		{
			// Token: 0x17000311 RID: 785
			// (get) Token: 0x06000E06 RID: 3590 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000311")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E06")]
				[Address(RVA = "0xAE2FA0", Offset = "0xAE21A0", VA = "0x180AE2FA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000312 RID: 786
			// (get) Token: 0x06000E07 RID: 3591 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000312")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E07")]
				[Address(RVA = "0xAE2F70", Offset = "0xAE2170", VA = "0x180AE2F70", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000313 RID: 787
			// (get) Token: 0x06000E08 RID: 3592 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000313")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E08")]
				[Address(RVA = "0xAE2FD0", Offset = "0xAE21D0", VA = "0x180AE2FD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E09 RID: 3593 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E09")]
			[Address(RVA = "0xAE2EE0", Offset = "0xAE20E0", VA = "0x180AE2EE0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E0A RID: 3594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public ClearTrash()
			{
			}
		}

		// Token: 0x02000276 RID: 630
		[Token(Token = "0x2000276")]
		public class PlayCutscene : Console.ConsoleCommand
		{
			// Token: 0x17000314 RID: 788
			// (get) Token: 0x06000E0B RID: 3595 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000314")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E0B")]
				[Address(RVA = "0xAF8120", Offset = "0xAF7320", VA = "0x180AF8120", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000315 RID: 789
			// (get) Token: 0x06000E0C RID: 3596 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000315")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E0C")]
				[Address(RVA = "0xAF80F0", Offset = "0xAF72F0", VA = "0x180AF80F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000316 RID: 790
			// (get) Token: 0x06000E0D RID: 3597 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000316")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E0D")]
				[Address(RVA = "0xAF8150", Offset = "0xAF7350", VA = "0x180AF8150", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E0E RID: 3598 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0xAF7F60", Offset = "0xAF7160", VA = "0x180AF7F60", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E0F RID: 3599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E0F")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public PlayCutscene()
			{
			}
		}

		// Token: 0x02000277 RID: 631
		[Token(Token = "0x2000277")]
		public class SetGravityMultiplier : Console.ConsoleCommand
		{
			// Token: 0x17000317 RID: 791
			// (get) Token: 0x06000E10 RID: 3600 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000317")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E10")]
				[Address(RVA = "0xAFA940", Offset = "0xAF9B40", VA = "0x180AFA940", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000318 RID: 792
			// (get) Token: 0x06000E11 RID: 3601 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000318")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E11")]
				[Address(RVA = "0xAFA910", Offset = "0xAF9B10", VA = "0x180AFA910", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000319 RID: 793
			// (get) Token: 0x06000E12 RID: 3602 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000319")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E12")]
				[Address(RVA = "0xAFA970", Offset = "0xAF9B70", VA = "0x180AFA970", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E13 RID: 3603 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E13")]
			[Address(RVA = "0xAFA780", Offset = "0xAF9980", VA = "0x180AFA780", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E14 RID: 3604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E14")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public SetGravityMultiplier()
			{
			}
		}

		// Token: 0x02000278 RID: 632
		[Token(Token = "0x2000278")]
		public class SetRegionUnlocked : Console.ConsoleCommand
		{
			// Token: 0x1700031A RID: 794
			// (get) Token: 0x06000E15 RID: 3605 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700031A")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E15")]
				[Address(RVA = "0xAFADA0", Offset = "0xAF9FA0", VA = "0x180AFADA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700031B RID: 795
			// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700031B")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E16")]
				[Address(RVA = "0xAFAD70", Offset = "0xAF9F70", VA = "0x180AFAD70", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700031C RID: 796
			// (get) Token: 0x06000E17 RID: 3607 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700031C")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E17")]
				[Address(RVA = "0xAFADD0", Offset = "0xAF9FD0", VA = "0x180AFADD0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E18 RID: 3608 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E18")]
			[Address(RVA = "0xAFABD0", Offset = "0xAF9DD0", VA = "0x180AFABD0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E19 RID: 3609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E19")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public SetRegionUnlocked()
			{
			}
		}

		// Token: 0x02000279 RID: 633
		[Token(Token = "0x2000279")]
		public class ForceSleep : Console.ConsoleCommand
		{
			// Token: 0x1700031D RID: 797
			// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700031D")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E1A")]
				[Address(RVA = "0xAE3740", Offset = "0xAE2940", VA = "0x180AE3740", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700031E RID: 798
			// (get) Token: 0x06000E1B RID: 3611 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700031E")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E1B")]
				[Address(RVA = "0xAE3710", Offset = "0xAE2910", VA = "0x180AE3710", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700031F RID: 799
			// (get) Token: 0x06000E1C RID: 3612 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x1700031F")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E1C")]
				[Address(RVA = "0xAE3770", Offset = "0xAE2970", VA = "0x180AE3770", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E1D RID: 3613 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0xAE3690", Offset = "0xAE2890", VA = "0x180AE3690", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E1E RID: 3614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public ForceSleep()
			{
			}
		}

		// Token: 0x0200027A RID: 634
		[Token(Token = "0x200027A")]
		public class DestroyNPCs : Console.ConsoleCommand
		{
			// Token: 0x17000320 RID: 800
			// (get) Token: 0x06000E1F RID: 3615 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000320")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E1F")]
				[Address(RVA = "0xAE3630", Offset = "0xAE2830", VA = "0x180AE3630", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000321 RID: 801
			// (get) Token: 0x06000E20 RID: 3616 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000321")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E20")]
				[Address(RVA = "0xAE3600", Offset = "0xAE2800", VA = "0x180AE3600", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000322 RID: 802
			// (get) Token: 0x06000E21 RID: 3617 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000322")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E21")]
				[Address(RVA = "0xAE3660", Offset = "0xAE2860", VA = "0x180AE3660", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E22 RID: 3618 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0xAE3500", Offset = "0xAE2700", VA = "0x180AE3500", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E23 RID: 3619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public DestroyNPCs()
			{
			}
		}

		// Token: 0x0200027B RID: 635
		[Token(Token = "0x200027B")]
		public class SetDayDuration : Console.ConsoleCommand
		{
			// Token: 0x17000323 RID: 803
			// (get) Token: 0x06000E24 RID: 3620 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000323")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E24")]
				[Address(RVA = "0xAFA720", Offset = "0xAF9920", VA = "0x180AFA720", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000324 RID: 804
			// (get) Token: 0x06000E25 RID: 3621 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000324")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E25")]
				[Address(RVA = "0xAFA6F0", Offset = "0xAF98F0", VA = "0x180AFA6F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000325 RID: 805
			// (get) Token: 0x06000E26 RID: 3622 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000325")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E26")]
				[Address(RVA = "0xAFA750", Offset = "0xAF9950", VA = "0x180AFA750", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E27 RID: 3623 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E27")]
			[Address(RVA = "0xAFA5C0", Offset = "0xAF97C0", VA = "0x180AFA5C0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E28 RID: 3624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E28")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public SetDayDuration()
			{
			}
		}

		// Token: 0x0200027C RID: 636
		[Token(Token = "0x200027C")]
		public class SetPoliceIgnorePlayers : Console.ConsoleCommand
		{
			// Token: 0x17000326 RID: 806
			// (get) Token: 0x06000E29 RID: 3625 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000326")]
			public override string CommandWord
			{
				[Token(Token = "0x6000E29")]
				[Address(RVA = "0xAFAB70", Offset = "0xAF9D70", VA = "0x180AFAB70", Slot = "4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000327 RID: 807
			// (get) Token: 0x06000E2A RID: 3626 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000327")]
			public override string CommandDescription
			{
				[Token(Token = "0x6000E2A")]
				[Address(RVA = "0xAFAB40", Offset = "0xAF9D40", VA = "0x180AFAB40", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000328 RID: 808
			// (get) Token: 0x06000E2B RID: 3627 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x17000328")]
			public override string ExampleUsage
			{
				[Token(Token = "0x6000E2B")]
				[Address(RVA = "0xAFABA0", Offset = "0xAF9DA0", VA = "0x180AFABA0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0xAFA9A0", Offset = "0xAF9BA0", VA = "0x180AFA9A0", Slot = "7")]
			public override void Execute(List<string> args)
			{
			}

			// Token: 0x06000E2D RID: 3629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E2D")]
			[Address(RVA = "0xAE2F60", Offset = "0xAE2160", VA = "0x180AE2F60")]
			public SetPoliceIgnorePlayers()
			{
			}
		}

		// Token: 0x0200027D RID: 637
		[Token(Token = "0x200027D")]
		[Serializable]
		public class LabelledGameObject
		{
			// Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public LabelledGameObject()
			{
			}

			// Token: 0x04000CF7 RID: 3319
			[Token(Token = "0x4000CF7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Label;

			// Token: 0x04000CF8 RID: 3320
			[Token(Token = "0x4000CF8")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public GameObject GameObject;
		}
	}
}
