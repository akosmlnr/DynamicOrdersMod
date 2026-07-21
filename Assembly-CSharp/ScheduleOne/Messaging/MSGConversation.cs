using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.UI.Phone.Messages;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.Messaging
{
	// Token: 0x0200050B RID: 1291
	[Token(Token = "0x200050B")]
	[Serializable]
	public class MSGConversation : ISaveable
	{
		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001C15 RID: 7189 RVA: 0x0000A500 File Offset: 0x00008700
		// (set) Token: 0x06001C16 RID: 7190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051D")]
		public bool IsSenderKnown
		{
			[Token(Token = "0x6001C15")]
			[Address(RVA = "0x492B10", Offset = "0x491D10", VA = "0x180492B10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C16")]
			[Address(RVA = "0x492B30", Offset = "0x491D30", VA = "0x180492B30")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C17 RID: 7191 RVA: 0x0000A518 File Offset: 0x00008718
		// (set) Token: 0x06001C18 RID: 7192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051E")]
		public bool Read
		{
			[Token(Token = "0x6001C17")]
			[Address(RVA = "0x4D4690", Offset = "0x4D3890", VA = "0x1804D4690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C18")]
			[Address(RVA = "0x4D4A40", Offset = "0x4D3C40", VA = "0x1804D4A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0000A530 File Offset: 0x00008730
		// (set) Token: 0x06001C1A RID: 7194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051F")]
		public int index
		{
			[Token(Token = "0x6001C19")]
			[Address(RVA = "0x4D4680", Offset = "0x4D3880", VA = "0x1804D4680")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001C1A")]
			[Address(RVA = "0x4E0DB0", Offset = "0x4DFFB0", VA = "0x1804E0DB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C1B RID: 7195 RVA: 0x0000A548 File Offset: 0x00008748
		// (set) Token: 0x06001C1C RID: 7196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000520")]
		public bool isOpen
		{
			[Token(Token = "0x6001C1B")]
			[Address(RVA = "0x49B030", Offset = "0x49A230", VA = "0x18049B030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C1C")]
			[Address(RVA = "0x49B240", Offset = "0x49A440", VA = "0x18049B240")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C1D RID: 7197 RVA: 0x0000A560 File Offset: 0x00008760
		// (set) Token: 0x06001C1E RID: 7198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000521")]
		public bool rollingOut
		{
			[Token(Token = "0x6001C1D")]
			[Address(RVA = "0x508DE0", Offset = "0x507FE0", VA = "0x180508DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C1E")]
			[Address(RVA = "0x60E940", Offset = "0x60DB40", VA = "0x18060E940")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001C1F RID: 7199 RVA: 0x0000A578 File Offset: 0x00008778
		// (set) Token: 0x06001C20 RID: 7200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000522")]
		public bool EntryVisible
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x60E8A0", Offset = "0x60DAA0", VA = "0x18060E8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C20")]
			[Address(RVA = "0x60E920", Offset = "0x60DB20", VA = "0x18060E920")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001C21 RID: 7201 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000523")]
		public UISelectable UISelectable
		{
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x4B4780", Offset = "0x4B3980", VA = "0x1804B4780")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x17000524")]
		public bool AreResponsesActive
		{
			[Token(Token = "0x6001C22")]
			[Address(RVA = "0x60E850", Offset = "0x60DA50", VA = "0x18060E850")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C23 RID: 7203 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000525")]
		public string SaveFolderName
		{
			[Token(Token = "0x6001C23")]
			[Address(RVA = "0x60E8F0", Offset = "0x60DAF0", VA = "0x18060E8F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000526")]
		public string SaveFileName
		{
			[Token(Token = "0x6001C24")]
			[Address(RVA = "0x60E8C0", Offset = "0x60DAC0", VA = "0x18060E8C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C25 RID: 7205 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000527")]
		public Loader Loader
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x490CA0", Offset = "0x48FEA0", VA = "0x180490CA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x17000528")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6001C26")]
			[Address(RVA = "0x4914F0", Offset = "0x4906F0", VA = "0x1804914F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001C28 RID: 7208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000529")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x514940", Offset = "0x513B40", VA = "0x180514940", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C28")]
			[Address(RVA = "0x51C410", Offset = "0x51B610", VA = "0x18051C410", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052A")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6001C29")]
			[Address(RVA = "0x514950", Offset = "0x513B50", VA = "0x180514950", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C2A")]
			[Address(RVA = "0x504620", Offset = "0x503820", VA = "0x180504620", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C2B RID: 7211 RVA: 0x0000A5C0 File Offset: 0x000087C0
		// (set) Token: 0x06001C2C RID: 7212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052B")]
		public bool HasChanged
		{
			[Token(Token = "0x6001C2B")]
			[Address(RVA = "0x60E8B0", Offset = "0x60DAB0", VA = "0x18060E8B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001C2C")]
			[Address(RVA = "0x60E930", Offset = "0x60DB30", VA = "0x18060E930", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0x60E390", Offset = "0x60D590", VA = "0x18060E390")]
		public MSGConversation(NPC _npc, string _contactName)
		{
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x60A8B0", Offset = "0x609AB0", VA = "0x18060A8B0", Slot = "27")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x497930", Offset = "0x496B30", VA = "0x180497930")]
		public void SetCategories(List<EConversationCategory> cat)
		{
		}

		// Token: 0x06001C30 RID: 7216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x60AE70", Offset = "0x60A070", VA = "0x18060AE70")]
		public void MoveToTop()
		{
		}

		// Token: 0x06001C31 RID: 7217 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x60DF20", Offset = "0x60D120", VA = "0x18060DF20")]
		public bool ShouldReplicate()
		{
			return default(bool);
		}

		// Token: 0x06001C32 RID: 7218 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x60A290", Offset = "0x609490", VA = "0x18060A290")]
		public int GetReplicationByteSize()
		{
			return 0;
		}

		// Token: 0x06001C33 RID: 7219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x6094B0", Offset = "0x6086B0", VA = "0x1806094B0")]
		protected void CreateUI()
		{
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x60A260", Offset = "0x609460", VA = "0x18060A260")]
		public void EnsureUIExists()
		{
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x60AF90", Offset = "0x60A190", VA = "0x18060AF90")]
		protected void RefreshPreviewText()
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x60B900", Offset = "0x60AB00", VA = "0x18060B900")]
		public void RepositionEntry()
		{
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x60CB20", Offset = "0x60BD20", VA = "0x18060CB20")]
		public void SetIsKnown(bool known)
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x60A280", Offset = "0x609480", VA = "0x18060A280")]
		public void EntryClicked()
		{
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C39")]
		[Address(RVA = "0x60CCC0", Offset = "0x60BEC0", VA = "0x18060CCC0")]
		public void SetOpen(bool open)
		{
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3A")]
		[Address(RVA = "0x609DB0", Offset = "0x608FB0", VA = "0x180609DB0")]
		public void DisplayRelationshipInfo()
		{
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3B")]
		[Address(RVA = "0x60B070", Offset = "0x60A270", VA = "0x18060B070", Slot = "28")]
		protected virtual void RenderMessage(Message m)
		{
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3C")]
		[Address(RVA = "0x60C9A0", Offset = "0x60BBA0", VA = "0x18060C9A0")]
		public void SetEntryVisibility(bool v)
		{
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3D")]
		[Address(RVA = "0x60D910", Offset = "0x60CB10", VA = "0x18060D910")]
		public void SetRead(bool r)
		{
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x60C270", Offset = "0x60B470", VA = "0x18060C270")]
		public void SendMessage(Message message, bool notify = true, bool network = true)
		{
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x60BEA0", Offset = "0x60B0A0", VA = "0x18060BEA0")]
		public void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x60A3D0", Offset = "0x6095D0", VA = "0x18060A3D0")]
		public MSGConversationData GetSaveData()
		{
			return null;
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x60A870", Offset = "0x609A70", VA = "0x18060A870", Slot = "29")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x60A940", Offset = "0x609B40", VA = "0x18060A940", Slot = "30")]
		public virtual void Load(MSGConversationData data)
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x60B9D0", Offset = "0x60ABD0", VA = "0x18060B9D0")]
		public void ResetConversation()
		{
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x60DE20", Offset = "0x60D020", VA = "0x18060DE20")]
		public void SetSliderValue(float value, Color color)
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x60A2F0", Offset = "0x6094F0", VA = "0x18060A2F0")]
		public Response GetResponse(string label)
		{
			return null;
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x60DF90", Offset = "0x60D190", VA = "0x18060DF90")]
		public void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x608EF0", Offset = "0x6080F0", VA = "0x180608EF0")]
		protected void CreateResponseUI(Response r)
		{
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x608BA0", Offset = "0x607DA0", VA = "0x180608BA0")]
		protected void ClearResponseUI()
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x60DB50", Offset = "0x60CD50", VA = "0x18060DB50")]
		public void SetResponseContainerVisible(bool v)
		{
		}

		// Token: 0x06001C4A RID: 7242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x60BBC0", Offset = "0x60ADC0", VA = "0x18060BBC0")]
		public void ResponseChosen(Response r, bool network)
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x608CD0", Offset = "0x607ED0", VA = "0x180608CD0")]
		public void ClearResponses(bool network = false)
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x6093A0", Offset = "0x6085A0", VA = "0x1806093A0")]
		public SendableMessage CreateSendableMessage(string text)
		{
			return null;
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x60C730", Offset = "0x60B930", VA = "0x18060C730")]
		public void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x60B840", Offset = "0x60AA40", VA = "0x18060B840")]
		public void RenderPlayerMessage(SendableMessage sendable)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x608980", Offset = "0x607B80", VA = "0x180608980")]
		private void CheckSendLoop()
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x608810", Offset = "0x607A10", VA = "0x180608810")]
		private bool CanSendNewMessage()
		{
			return default(bool);
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6001C52")]
		[Address(RVA = "0x60E310", Offset = "0x60D510", VA = "0x18060E310")]
		[CompilerGenerated]
		private IEnumerator <CheckSendLoop>g__Loop|110_0()
		{
			return null;
		}

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		public const int MAX_MESSAGE_HISTORY = 10;

		// Token: 0x040017E9 RID: 6121
		[Token(Token = "0x40017E9")]
		[FieldOffset(Offset = "0x10")]
		public string contactName;

		// Token: 0x040017EA RID: 6122
		[Token(Token = "0x40017EA")]
		[FieldOffset(Offset = "0x18")]
		public NPC sender;

		// Token: 0x040017EC RID: 6124
		[Token(Token = "0x40017EC")]
		[FieldOffset(Offset = "0x28")]
		public List<Message> messageHistory;

		// Token: 0x040017ED RID: 6125
		[Token(Token = "0x40017ED")]
		[FieldOffset(Offset = "0x30")]
		public List<MessageChain> messageChainHistory;

		// Token: 0x040017EE RID: 6126
		[Token(Token = "0x40017EE")]
		[FieldOffset(Offset = "0x38")]
		public List<MessageBubble> bubbles;

		// Token: 0x040017EF RID: 6127
		[Token(Token = "0x40017EF")]
		[FieldOffset(Offset = "0x40")]
		public List<SendableMessage> Sendables;

		// Token: 0x040017F5 RID: 6133
		[Token(Token = "0x40017F5")]
		[FieldOffset(Offset = "0x58")]
		public List<EConversationCategory> Categories;

		// Token: 0x040017F6 RID: 6134
		[Token(Token = "0x40017F6")]
		[FieldOffset(Offset = "0x60")]
		public RectTransform entry;

		// Token: 0x040017F7 RID: 6135
		[Token(Token = "0x40017F7")]
		[FieldOffset(Offset = "0x68")]
		protected RectTransform container;

		// Token: 0x040017F8 RID: 6136
		[Token(Token = "0x40017F8")]
		[FieldOffset(Offset = "0x70")]
		protected RectTransform bubbleContainer;

		// Token: 0x040017F9 RID: 6137
		[Token(Token = "0x40017F9")]
		[FieldOffset(Offset = "0x78")]
		protected RectTransform scrollRectContainer;

		// Token: 0x040017FA RID: 6138
		[Token(Token = "0x40017FA")]
		[FieldOffset(Offset = "0x80")]
		protected ScrollRect scrollRect;

		// Token: 0x040017FB RID: 6139
		[Token(Token = "0x40017FB")]
		[FieldOffset(Offset = "0x88")]
		protected Text entryPreviewText;

		// Token: 0x040017FC RID: 6140
		[Token(Token = "0x40017FC")]
		[FieldOffset(Offset = "0x90")]
		protected RectTransform unreadDot;

		// Token: 0x040017FD RID: 6141
		[Token(Token = "0x40017FD")]
		[FieldOffset(Offset = "0x98")]
		protected Slider slider;

		// Token: 0x040017FE RID: 6142
		[Token(Token = "0x40017FE")]
		[FieldOffset(Offset = "0xA0")]
		protected Image sliderFill;

		// Token: 0x040017FF RID: 6143
		[Token(Token = "0x40017FF")]
		[FieldOffset(Offset = "0xA8")]
		protected RectTransform responseContainer;

		// Token: 0x04001800 RID: 6144
		[Token(Token = "0x4001800")]
		[FieldOffset(Offset = "0xB0")]
		protected MessageSenderInterface senderInterface;

		// Token: 0x04001801 RID: 6145
		[Token(Token = "0x4001801")]
		[FieldOffset(Offset = "0xB8")]
		protected UISelectable uiSelectable;

		// Token: 0x04001802 RID: 6146
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0xC0")]
		protected UIPanel dialogueScreenUIPanel;

		// Token: 0x04001803 RID: 6147
		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0xC8")]
		private bool uiCreated;

		// Token: 0x04001804 RID: 6148
		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0xD0")]
		public Action onMessageRendered;

		// Token: 0x04001805 RID: 6149
		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0xD8")]
		public Action onLoaded;

		// Token: 0x04001806 RID: 6150
		[Token(Token = "0x4001806")]
		[FieldOffset(Offset = "0xE0")]
		public Action onResponsesShown;

		// Token: 0x04001807 RID: 6151
		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0xE8")]
		public Action onConversationOpened;

		// Token: 0x04001808 RID: 6152
		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0xF0")]
		public List<Response> currentResponses;

		// Token: 0x04001809 RID: 6153
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0xF8")]
		private List<RectTransform> responseRects;
	}
}
