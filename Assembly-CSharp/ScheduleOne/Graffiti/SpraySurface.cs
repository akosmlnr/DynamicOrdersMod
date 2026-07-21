using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Core;
using ScheduleOne.Persistence.Datas;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Graffiti
{
	// Token: 0x02000652 RID: 1618
	[Token(Token = "0x2000652")]
	public class SpraySurface : NetworkBehaviour
	{
		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060027E8 RID: 10216 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x060027E9 RID: 10217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F6")]
		public NetworkObject CurrentEditor
		{
			[Token(Token = "0x60027E8")]
			[Address(RVA = "0x5AF080", Offset = "0x5AE280", VA = "0x1805AF080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027E9")]
			[Address(RVA = "0x5AF0A0", Offset = "0x5AE2A0", VA = "0x1805AF0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060027EA RID: 10218 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x170006F7")]
		public int DrawingStrokeCount
		{
			[Token(Token = "0x60027EA")]
			[Address(RVA = "0x6E5F90", Offset = "0x6E5190", VA = "0x1806E5F90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170006F8")]
		public Texture DrawingOutputTexture
		{
			[Token(Token = "0x60027EB")]
			[Address(RVA = "0x6E5F50", Offset = "0x6E5150", VA = "0x1806E5F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F9")]
		public int DrawingPaintedPixelCount
		{
			[Token(Token = "0x60027EC")]
			[Address(RVA = "0x6E5F70", Offset = "0x6E5170", VA = "0x1806E5F70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60027ED")]
			[Address(RVA = "0x6E6060", Offset = "0x6E5260", VA = "0x1806E6060")]
			set
			{
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060027EE RID: 10222 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x170006FA")]
		public int RoundedWidth
		{
			[Token(Token = "0x60027EE")]
			[Address(RVA = "0x6E5FC0", Offset = "0x6E51C0", VA = "0x1806E5FC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x170006FB")]
		public int RoundedHeight
		{
			[Token(Token = "0x60027EF")]
			[Address(RVA = "0x6E5FB0", Offset = "0x6E51B0", VA = "0x1806E5FB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x0000CF18 File Offset: 0x0000B118
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FC")]
		public bool ContainsCartelGraffiti
		{
			[Token(Token = "0x60027F0")]
			[Address(RVA = "0x511850", Offset = "0x510A50", VA = "0x180511850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60027F1")]
			[Address(RVA = "0x5A4550", Offset = "0x5A3750", VA = "0x1805A4550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x170006FD")]
		public Vector3 TopRightPoint
		{
			[Token(Token = "0x60027F2")]
			[Address(RVA = "0x6E5FD0", Offset = "0x6E51D0", VA = "0x1806E5FD0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060027F3 RID: 10227 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x170006FE")]
		public Vector3 CenterPoint
		{
			[Token(Token = "0x60027F3")]
			[Address(RVA = "0x6E5EB0", Offset = "0x6E50B0", VA = "0x1806E5EB0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F4")]
		[Address(RVA = "0x6E2970", Offset = "0x6E1B70", VA = "0x1806E2970", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F5")]
		[Address(RVA = "0x6E38C0", Offset = "0x6E2AC0", VA = "0x1806E38C0", Slot = "16")]
		protected override void OnValidate()
		{
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F6")]
		[Address(RVA = "0x6E3A20", Offset = "0x6E2C20", VA = "0x1806E3A20")]
		private void ResizeProjector()
		{
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x60027F7")]
		[Address(RVA = "0x6E29F0", Offset = "0x6E1BF0", VA = "0x1806E29F0")]
		public bool CanBeEdited(bool checkEditor)
		{
			return default(bool);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x60027F8")]
		[Address(RVA = "0x6E2A90", Offset = "0x6E1C90", VA = "0x1806E2A90")]
		public bool CanUndo()
		{
			return default(bool);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027F9")]
		[Address(RVA = "0x6E37C0", Offset = "0x6E29C0", VA = "0x1806E37C0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FA")]
		[Address(RVA = "0x6E3990", Offset = "0x6E2B90", VA = "0x1806E3990", Slot = "20")]
		public virtual void ReplicateTo(NetworkConnection conn)
		{
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FB")]
		[Address(RVA = "0x6E51B0", Offset = "0x6E43B0", VA = "0x1806E51B0")]
		[ServerRpc(RequireOwnership = false)]
		public void SetCurrentEditor_Server(NetworkObject player)
		{
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FC")]
		[Address(RVA = "0x6E56E0", Offset = "0x6E48E0", VA = "0x1806E56E0")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetCurrentEditor_Client(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FD")]
		[Address(RVA = "0x6E37B0", Offset = "0x6E29B0", VA = "0x1806E37B0", Slot = "21")]
		public virtual void OnEditingFinished()
		{
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FE")]
		[Address(RVA = "0x6E2570", Offset = "0x6E1770", VA = "0x1806E2570")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddStrokes_Server(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027FF")]
		[Address(RVA = "0x6E2400", Offset = "0x6E1600", VA = "0x1806E2400")]
		[ObserversRpc(RunLocally = true)]
		private void AddStrokes_Client(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x06002800 RID: 10240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002800")]
		[Address(RVA = "0x6E2820", Offset = "0x6E1A20", VA = "0x1806E2820")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddTextureToHistory_Server(int requestID)
		{
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002801")]
		[Address(RVA = "0x6E26D0", Offset = "0x6E18D0", VA = "0x1806E26D0")]
		[ObserversRpc(RunLocally = true)]
		private void AddTextureToHistory_Client(int requestID)
		{
		}

		// Token: 0x06002802 RID: 10242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002802")]
		[Address(RVA = "0x6E29C0", Offset = "0x6E1BC0", VA = "0x1806E29C0")]
		public void CacheDrawing()
		{
		}

		// Token: 0x06002803 RID: 10243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002803")]
		[Address(RVA = "0x6E38E0", Offset = "0x6E2AE0", VA = "0x1806E38E0")]
		public void PrintHistoryCount()
		{
		}

		// Token: 0x06002804 RID: 10244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002804")]
		[Address(RVA = "0x6E5CB0", Offset = "0x6E4EB0", VA = "0x1806E5CB0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void Undo_Server(int requestID)
		{
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002805")]
		[Address(RVA = "0x6E4080", Offset = "0x6E3280", VA = "0x1806E4080")]
		[ObserversRpc(RunLocally = true)]
		private void Undo_Client(int requestID)
		{
		}

		// Token: 0x06002806 RID: 10246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002806")]
		[Address(RVA = "0x6E2AB0", Offset = "0x6E1CB0", VA = "0x1806E2AB0", Slot = "22")]
		public virtual void CleanGraffiti()
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002807")]
		[Address(RVA = "0x6E2AC0", Offset = "0x6E1CC0", VA = "0x1806E2AC0")]
		[ServerRpc(RequireOwnership = false)]
		public void ClearDrawing()
		{
		}

		// Token: 0x06002808 RID: 10248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002808")]
		[Address(RVA = "0x6E2E60", Offset = "0x6E2060", VA = "0x1806E2E60")]
		public void EnsureDrawingExists()
		{
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002809")]
		[Address(RVA = "0x6E2BD0", Offset = "0x6E1DD0", VA = "0x1806E2BD0")]
		protected void CreateNewDrawing()
		{
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280A")]
		[Address(RVA = "0x6E3C10", Offset = "0x6E2E10", VA = "0x1806E3C10")]
		public void RestoreFromCache()
		{
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x600280B")]
		[Address(RVA = "0x6E5C30", Offset = "0x6E4E30", VA = "0x1806E5C30")]
		public Vector3 ToWorldPosition(UShort2 coordinate, float offset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280C")]
		[Address(RVA = "0x6E2E00", Offset = "0x6E2000", VA = "0x1806E2E00")]
		public void DrawPaintedPixel(PixelData data, bool applyTexture)
		{
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280D")]
		[Address(RVA = "0x6E5950", Offset = "0x6E4B50", VA = "0x1806E5950")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void Set(NetworkConnection conn, SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600280E")]
		[Address(RVA = "0x6E2E30", Offset = "0x6E2030", VA = "0x1806E2E30")]
		private void DrawingChanged()
		{
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600280F")]
		[Address(RVA = "0x6E2FB0", Offset = "0x6E21B0", VA = "0x1806E2FB0")]
		public SerializedGraffitiDrawing GetSerializedDrawing()
		{
			return null;
		}

		// Token: 0x06002810 RID: 10256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002810")]
		[Address(RVA = "0x6E3090", Offset = "0x6E2290", VA = "0x1806E3090")]
		[Button]
		public void LoadSerializedDrawing(SerializedGraffitiDrawing serializedDrawing, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x6E5DF0", Offset = "0x6E4FF0", VA = "0x1806E5DF0")]
		public bool WillDrawingFit(int width, int height)
		{
			return default(bool);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x6E2E80", Offset = "0x6E2080", VA = "0x1806E2E80")]
		public static int GetPadding(byte strokeSize)
		{
			return 0;
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x6E5BF0", Offset = "0x6E4DF0", VA = "0x1806E5BF0", Slot = "23")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x6E2EF0", Offset = "0x6E20F0", VA = "0x1806E2EF0", Slot = "24")]
		public virtual SpraySurfaceData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x6E5E10", Offset = "0x6E5010", VA = "0x1806E5E10")]
		public SpraySurface()
		{
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x6E3430", Offset = "0x6E2630", VA = "0x1806E3430", Slot = "25")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x6E3410", Offset = "0x6E2610", VA = "0x1806E3410", Slot = "26")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x6E33D0", Offset = "0x6E25D0", VA = "0x1806E33D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x6E51B0", Offset = "0x6E43B0", VA = "0x1806E51B0")]
		private void RpcWriter___Server_SetCurrentEditor_Server_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x6E3EE0", Offset = "0x6E30E0", VA = "0x1806E3EE0")]
		public void RpcLogic___SetCurrentEditor_Server_3323014238(NetworkObject player)
		{
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x6E4620", Offset = "0x6E3820", VA = "0x1806E4620")]
		private void RpcReader___Server_SetCurrentEditor_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281C")]
		[Address(RVA = "0x6E4B00", Offset = "0x6E3D00", VA = "0x1806E4B00")]
		private void RpcWriter___Observers_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281D")]
		[Address(RVA = "0x6E3EC0", Offset = "0x6E30C0", VA = "0x1806E3EC0")]
		private void RpcLogic___SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281E")]
		[Address(RVA = "0x6E42D0", Offset = "0x6E34D0", VA = "0x1806E42D0")]
		private void RpcReader___Observers_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600281F")]
		[Address(RVA = "0x6E5420", Offset = "0x6E4620", VA = "0x1806E5420")]
		private void RpcWriter___Target_SetCurrentEditor_Client_1824087381(NetworkConnection conn, NetworkObject player)
		{
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002820")]
		[Address(RVA = "0x6E4710", Offset = "0x6E3910", VA = "0x1806E4710")]
		private void RpcReader___Target_SetCurrentEditor_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002821")]
		[Address(RVA = "0x6E4F00", Offset = "0x6E4100", VA = "0x1806E4F00")]
		private void RpcWriter___Server_AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002822")]
		[Address(RVA = "0x6E2400", Offset = "0x6E1600", VA = "0x1806E2400")]
		public void RpcLogic___AddStrokes_Server_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x6E4470", Offset = "0x6E3670", VA = "0x1806E4470")]
		private void RpcReader___Server_AddStrokes_Server_1511871282(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x6E4830", Offset = "0x6E3A30", VA = "0x1806E4830")]
		private void RpcWriter___Observers_AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002825")]
		[Address(RVA = "0x6E3C40", Offset = "0x6E2E40", VA = "0x1806E3C40")]
		private void RpcLogic___AddStrokes_Client_1511871282(List<SprayStroke> newStrokes, int requestID)
		{
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002826")]
		[Address(RVA = "0x6E41D0", Offset = "0x6E33D0", VA = "0x1806E41D0")]
		private void RpcReader___Observers_AddStrokes_Client_1511871282(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002827")]
		[Address(RVA = "0x6E5070", Offset = "0x6E4270", VA = "0x1806E5070")]
		private void RpcWriter___Server_AddTextureToHistory_Server_3316948804(int requestID)
		{
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002828")]
		[Address(RVA = "0x6E26D0", Offset = "0x6E18D0", VA = "0x1806E26D0")]
		public void RpcLogic___AddTextureToHistory_Server_3316948804(int requestID)
		{
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002829")]
		[Address(RVA = "0x6E4510", Offset = "0x6E3710", VA = "0x1806E4510")]
		private void RpcReader___Server_AddTextureToHistory_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282A")]
		[Address(RVA = "0x6E49B0", Offset = "0x6E3BB0", VA = "0x1806E49B0")]
		private void RpcWriter___Observers_AddTextureToHistory_Client_3316948804(int requestID)
		{
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282B")]
		[Address(RVA = "0x6E3D50", Offset = "0x6E2F50", VA = "0x1806E3D50")]
		private void RpcLogic___AddTextureToHistory_Client_3316948804(int requestID)
		{
		}

		// Token: 0x0600282C RID: 10284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282C")]
		[Address(RVA = "0x6E4260", Offset = "0x6E3460", VA = "0x1806E4260")]
		private void RpcReader___Observers_AddTextureToHistory_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600282D RID: 10285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282D")]
		[Address(RVA = "0x6E52E0", Offset = "0x6E44E0", VA = "0x1806E52E0")]
		private void RpcWriter___Server_Undo_Server_3316948804(int requestID)
		{
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282E")]
		[Address(RVA = "0x6E4080", Offset = "0x6E3280", VA = "0x1806E4080")]
		public void RpcLogic___Undo_Server_3316948804(int requestID)
		{
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600282F")]
		[Address(RVA = "0x6E4690", Offset = "0x6E3890", VA = "0x1806E4690")]
		private void RpcReader___Server_Undo_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x6E4DB0", Offset = "0x6E3FB0", VA = "0x1806E4DB0")]
		private void RpcWriter___Observers_Undo_Client_3316948804(int requestID)
		{
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x6E3F80", Offset = "0x6E3180", VA = "0x1806E3F80")]
		private void RpcLogic___Undo_Client_3316948804(int requestID)
		{
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x6E4400", Offset = "0x6E3600", VA = "0x1806E4400")]
		private void RpcReader___Observers_Undo_Client_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x6E2AC0", Offset = "0x6E1CC0", VA = "0x1806E2AC0")]
		private void RpcWriter___Server_ClearDrawing_2166136261()
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x6E3E40", Offset = "0x6E3040", VA = "0x1806E3E40")]
		public void RpcLogic___ClearDrawing_2166136261()
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x6E4590", Offset = "0x6E3790", VA = "0x1806E4590")]
		private void RpcReader___Server_ClearDrawing_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x6E4C40", Offset = "0x6E3E40", VA = "0x1806E4C40")]
		private void RpcWriter___Observers_Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x6E3EF0", Offset = "0x6E30F0", VA = "0x1806E3EF0")]
		public void RpcLogic___Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x6E4350", Offset = "0x6E3550", VA = "0x1806E4350")]
		private void RpcReader___Observers_Set_4105842735(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x6E5580", Offset = "0x6E4780", VA = "0x1806E5580")]
		private void RpcWriter___Target_Set_4105842735(NetworkConnection conn, SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x6E4790", Offset = "0x6E3990", VA = "0x1806E4790")]
		private void RpcReader___Target_Set_4105842735(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x6E2960", Offset = "0x6E1B60", VA = "0x1806E2960", Slot = "27")]
		protected virtual void Awake_UserLogic_ScheduleOne.Graffiti.SpraySurface_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04001EF9 RID: 7929
		[Token(Token = "0x4001EF9")]
		public const float PIXEL_SIZE = 0.006666671f;

		// Token: 0x04001EFC RID: 7932
		[Token(Token = "0x4001EFC")]
		[FieldOffset(Offset = "0x121")]
		[Header("Settings")]
		public bool Editable;

		// Token: 0x04001EFD RID: 7933
		[Token(Token = "0x4001EFD")]
		[FieldOffset(Offset = "0x124")]
		[Range(1f, 1000f)]
		public int Width;

		// Token: 0x04001EFE RID: 7934
		[Token(Token = "0x4001EFE")]
		[FieldOffset(Offset = "0x128")]
		[Range(1f, 1000f)]
		public int Height;

		// Token: 0x04001EFF RID: 7935
		[Token(Token = "0x4001EFF")]
		[FieldOffset(Offset = "0x130")]
		public AnimationCurve FalloffCurve;

		// Token: 0x04001F00 RID: 7936
		[Token(Token = "0x4001F00")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		public bool IsVandalismSurface;

		// Token: 0x04001F01 RID: 7937
		[Token(Token = "0x4001F01")]
		[FieldOffset(Offset = "0x140")]
		[Header("References")]
		public Transform BottomLeftPoint;

		// Token: 0x04001F02 RID: 7938
		[Token(Token = "0x4001F02")]
		[FieldOffset(Offset = "0x148")]
		public DecalProjector Projector;

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		[FieldOffset(Offset = "0x150")]
		protected Drawing drawing;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		[FieldOffset(Offset = "0x158")]
		private Drawing cachedDrawing;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x160")]
		public Action onDrawingChanged;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x168")]
		private List<int> pastRequestIDs;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x170")]
		private bool NetworkInitialize___EarlyScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x171")]
		private bool NetworkInitialize__LateScheduleOne.Graffiti.SpraySurfaceAssembly-CSharp.dll_Excuted;
	}
}
