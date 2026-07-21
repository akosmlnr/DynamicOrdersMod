using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace ScheduleOne.Polling
{
	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000376")]
	public class PollManager : MonoBehaviour
	{
		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001643 RID: 5699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000453")]
		public PollData ActivePoll
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x43FFE0", Offset = "0x43F1E0", VA = "0x18043FFE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x440010", Offset = "0x43F210", VA = "0x180440010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001645 RID: 5701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000454")]
		public PollData ConfirmedPoll
		{
			[Token(Token = "0x6001644")]
			[Address(RVA = "0x452450", Offset = "0x451650", VA = "0x180452450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x452480", Offset = "0x451680", VA = "0x180452480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x000095D0 File Offset: 0x000077D0
		// (set) Token: 0x06001647 RID: 5703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000455")]
		public PollManager.EPollSubmissionResult SubmissionResult
		{
			[Token(Token = "0x6001646")]
			[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
			[CompilerGenerated]
			get
			{
				return PollManager.EPollSubmissionResult.InProgress;
			}
			[Token(Token = "0x6001647")]
			[Address(RVA = "0x54A6A0", Offset = "0x5498A0", VA = "0x18054A6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000456")]
		public string SubmisssionFailedMesssage
		{
			[Token(Token = "0x6001648")]
			[Address(RVA = "0x452440", Offset = "0x451640", VA = "0x180452440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001649")]
			[Address(RVA = "0x452470", Offset = "0x451670", VA = "0x180452470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164A")]
		[Address(RVA = "0x59E640", Offset = "0x59D840", VA = "0x18059E640")]
		private void Start()
		{
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164B")]
		[Address(RVA = "0x43DA80", Offset = "0x43CC80", VA = "0x18043DA80")]
		private void Update()
		{
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164C")]
		[Address(RVA = "0x59D990", Offset = "0x59CB90", VA = "0x18059D990")]
		public void GenerateAppTicket()
		{
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600164D")]
		[Address(RVA = "0x59E480", Offset = "0x59D680", VA = "0x18059E480")]
		public void SelectPollResponse(int responseIndex)
		{
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600164E")]
		[Address(RVA = "0x59DBF0", Offset = "0x59CDF0", VA = "0x18059DBF0")]
		private Task InitAppTicket()
		{
			return null;
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600164F")]
		[Address(RVA = "0x59E800", Offset = "0x59DA00", VA = "0x18059E800")]
		private IEnumerator SubmitAnswerToServer(PollAnswer answer)
		{
			return null;
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001650")]
		[Address(RVA = "0x59DF00", Offset = "0x59D100", VA = "0x18059DF00")]
		private IEnumerator RequestPoll(string url, [Optional] Action<string> callback)
		{
			return null;
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001651")]
		[Address(RVA = "0x59DF90", Offset = "0x59D190", VA = "0x18059DF90")]
		private void ResponseCallback(string data)
		{
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001652")]
		[Address(RVA = "0x59DCC0", Offset = "0x59CEC0", VA = "0x18059DCC0")]
		private void OnEncryptedAppTicketResponse(EncryptedAppTicketResponse_t response, bool ioFailure)
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001653")]
		[Address(RVA = "0x59DAD0", Offset = "0x59CCD0", VA = "0x18059DAD0")]
		private Task<string> GetAppTicket()
		{
			return null;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001654")]
		[Address(RVA = "0x59D930", Offset = "0x59CB30", VA = "0x18059D930")]
		private static string CleanTicket(string ticket)
		{
			return null;
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x6001655")]
		[Address(RVA = "0x59E890", Offset = "0x59DA90", VA = "0x18059E890")]
		public static bool TryGetExistingPollResponse(int pollId, out int response)
		{
			return default(bool);
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001656")]
		[Address(RVA = "0x59DE50", Offset = "0x59D050", VA = "0x18059DE50")]
		private static void RecordSubmission(int pollId, int response)
		{
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001657")]
		[Address(RVA = "0x59E980", Offset = "0x59DB80", VA = "0x18059E980")]
		public PollManager()
		{
		}

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		public const string SERVER_URL = "https://us-central1-s1-polling-987345.cloudfunctions.net/poll";

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CallResult<EncryptedAppTicketResponse_t> appTicketCallbackResponse;

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TaskCompletionSource<string> tokenCompletion;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PollResponse receivedPollResponse;

		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int sentResponse;

		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string appTicket;

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Action<PollData> onActivePollReceived;

		// Token: 0x04001392 RID: 5010
		[Token(Token = "0x4001392")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<PollData> onConfirmedPollReceived;

		// Token: 0x04001393 RID: 5011
		[Token(Token = "0x4001393")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool appTicketRequested;

		// Token: 0x04001394 RID: 5012
		[Token(Token = "0x4001394")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[Header("Debug")]
		[SerializeField]
		private bool loadDebugData;

		// Token: 0x04001395 RID: 5013
		[Token(Token = "0x4001395")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[TextArea(10, 30)]
		[SerializeField]
		private string debugData;

		// Token: 0x02000377 RID: 887
		[Token(Token = "0x2000377")]
		public enum EPollSubmissionResult
		{
			// Token: 0x04001397 RID: 5015
			[Token(Token = "0x4001397")]
			InProgress,
			// Token: 0x04001398 RID: 5016
			[Token(Token = "0x4001398")]
			Success,
			// Token: 0x04001399 RID: 5017
			[Token(Token = "0x4001399")]
			Failed
		}
	}
}
