using System;
using System.Collections;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Graffiti;
using ScheduleOne.NPCs.Other;
using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000B16 RID: 2838
	[Token(Token = "0x2000B16")]
	public class GraffitiBehaviour : Behaviour
	{
		// Token: 0x06005392 RID: 21394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005392")]
		[Address(RVA = "0x965BE0", Offset = "0x964DE0", VA = "0x180965BE0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005393")]
		[Address(RVA = "0x9658B0", Offset = "0x964AB0", VA = "0x1809658B0", Slot = "20")]
		public override void Enable()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005394")]
		[Address(RVA = "0x9655B0", Offset = "0x9647B0", VA = "0x1809655B0", Slot = "21")]
		public override void Disable()
		{
		}

		// Token: 0x06005395 RID: 21397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005395")]
		[Address(RVA = "0x964D60", Offset = "0x963F60", VA = "0x180964D60", Slot = "22")]
		public override void Activate()
		{
		}

		// Token: 0x06005396 RID: 21398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005396")]
		[Address(RVA = "0x965E50", Offset = "0x965050", VA = "0x180965E50", Slot = "24")]
		public override void Pause()
		{
		}

		// Token: 0x06005397 RID: 21399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005397")]
		[Address(RVA = "0x9654C0", Offset = "0x9646C0", VA = "0x1809654C0", Slot = "23")]
		public override void Deactivate()
		{
		}

		// Token: 0x06005398 RID: 21400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005398")]
		[Address(RVA = "0x9653B0", Offset = "0x9645B0", VA = "0x1809653B0")]
		[ServerRpc(RequireOwnership = false)]
		private void Complete_Server()
		{
		}

		// Token: 0x06005399 RID: 21401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005399")]
		[Address(RVA = "0x964FB0", Offset = "0x9641B0", VA = "0x180964FB0")]
		private void CheckForInterruptions()
		{
		}

		// Token: 0x0600539A RID: 21402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539A")]
		[Address(RVA = "0x9665B0", Offset = "0x9657B0", VA = "0x1809665B0")]
		private void SetupEvents()
		{
		}

		// Token: 0x0600539B RID: 21403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539B")]
		[Address(RVA = "0x965100", Offset = "0x964300", VA = "0x180965100")]
		private void CleanUp()
		{
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539C")]
		[Address(RVA = "0x965A90", Offset = "0x964C90", VA = "0x180965A90")]
		private void OnMinPass()
		{
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539D")]
		[Address(RVA = "0x965CF0", Offset = "0x964EF0", VA = "0x180965CF0")]
		private void OnTimePass(int minutes)
		{
		}

		// Token: 0x0600539E RID: 21406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600539E")]
		[Address(RVA = "0x966870", Offset = "0x965A70", VA = "0x180966870")]
		private void StopEffectRoutine()
		{
		}

		// Token: 0x0600539F RID: 21407 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600539F")]
		[Address(RVA = "0x965840", Offset = "0x964A40", VA = "0x180965840")]
		private IEnumerator DoEffectRoutine()
		{
			return null;
		}

		// Token: 0x060053A0 RID: 21408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A0")]
		[Address(RVA = "0x966540", Offset = "0x965740", VA = "0x180966540")]
		[ObserversRpc(RunLocally = true)]
		public void SetSpraySurface_Client(NetworkConnection conn, NetworkObject surface)
		{
		}

		// Token: 0x060053A1 RID: 21409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A1")]
		[Address(RVA = "0x9668C0", Offset = "0x965AC0", VA = "0x1809668C0")]
		public GraffitiBehaviour()
		{
		}

		// Token: 0x060053A2 RID: 21410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A2")]
		[Address(RVA = "0x9659A0", Offset = "0x964BA0", VA = "0x1809659A0", Slot = "32")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A3")]
		[Address(RVA = "0x965980", Offset = "0x964B80", VA = "0x180965980", Slot = "33")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A4")]
		[Address(RVA = "0x931880", Offset = "0x930A80", VA = "0x180931880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A5")]
		[Address(RVA = "0x9653B0", Offset = "0x9645B0", VA = "0x1809653B0")]
		private void RpcWriter___Server_Complete_Server_2166136261()
		{
		}

		// Token: 0x060053A6 RID: 21414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A6")]
		[Address(RVA = "0x965EE0", Offset = "0x9650E0", VA = "0x180965EE0")]
		private void RpcLogic___Complete_Server_2166136261()
		{
		}

		// Token: 0x060053A7 RID: 21415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A7")]
		[Address(RVA = "0x9662A0", Offset = "0x9654A0", VA = "0x1809662A0")]
		private void RpcReader___Server_Complete_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060053A8 RID: 21416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A8")]
		[Address(RVA = "0x9662D0", Offset = "0x9654D0", VA = "0x1809662D0")]
		private void RpcWriter___Observers_SetSpraySurface_Client_1824087381(NetworkConnection conn, NetworkObject surface)
		{
		}

		// Token: 0x060053A9 RID: 21417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053A9")]
		[Address(RVA = "0x966170", Offset = "0x965370", VA = "0x180966170")]
		public void RpcLogic___SetSpraySurface_Client_1824087381(NetworkConnection conn, NetworkObject surface)
		{
		}

		// Token: 0x060053AA RID: 21418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AA")]
		[Address(RVA = "0x9661E0", Offset = "0x9653E0", VA = "0x1809661E0")]
		private void RpcReader___Observers_SetSpraySurface_Client_1824087381(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060053AB RID: 21419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60053AB")]
		[Address(RVA = "0x935FD0", Offset = "0x9351D0", VA = "0x180935FD0", Slot = "19")]
		public override void Awake()
		{
		}

		// Token: 0x040038A1 RID: 14497
		[Token(Token = "0x40038A1")]
		public const int InterruptionXP = 50;

		// Token: 0x040038A2 RID: 14498
		[Token(Token = "0x40038A2")]
		public const float InterruptionCartelInfluenceChange = -0.1f;

		// Token: 0x040038A3 RID: 14499
		[Token(Token = "0x40038A3")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Header("Graffiti: Components")]
		private SprayPaint _sprayPaint;

		// Token: 0x040038A4 RID: 14500
		[Token(Token = "0x40038A4")]
		[FieldOffset(Offset = "0x170")]
		[Header("Graffiti: Settings")]
		[SerializeField]
		private Vector2Int _graffitiDurationInMinutes;

		// Token: 0x040038A5 RID: 14501
		[Token(Token = "0x40038A5")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Vector2 _minMaxEffectLoopDuration;

		// Token: 0x040038A6 RID: 14502
		[Token(Token = "0x40038A6")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Vector2 _minMaxEffectPauseDuration;

		// Token: 0x040038A7 RID: 14503
		[Token(Token = "0x40038A7")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private Gradient _effectColorGradient;

		// Token: 0x040038A8 RID: 14504
		[Token(Token = "0x40038A8")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		[Header("Graffiti: Drawings")]
		private List<SerializedGraffitiDrawing> _drawinglist;

		// Token: 0x040038A9 RID: 14505
		[Token(Token = "0x40038A9")]
		[FieldOffset(Offset = "0x198")]
		[Header("Graffiti: Interruptions")]
		[SerializeField]
		private List<Behaviour> _interruptingBehaviours;

		// Token: 0x040038AA RID: 14506
		[Token(Token = "0x40038AA")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[Header("Debugging & Development")]
		private bool _debugMode;

		// Token: 0x040038AB RID: 14507
		[Token(Token = "0x40038AB")]
		[FieldOffset(Offset = "0x1A4")]
		private int _duration;

		// Token: 0x040038AC RID: 14508
		[Token(Token = "0x40038AC")]
		[FieldOffset(Offset = "0x1A8")]
		private Coroutine _effectCoroutine;

		// Token: 0x040038AD RID: 14509
		[Token(Token = "0x40038AD")]
		[FieldOffset(Offset = "0x1B0")]
		private WorldSpraySurface _spraySurface;

		// Token: 0x040038AE RID: 14510
		[Token(Token = "0x40038AE")]
		[FieldOffset(Offset = "0x1B8")]
		private bool _graffitiCompleted;

		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		[FieldOffset(Offset = "0x1B9")]
		private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GraffitiBehaviourAssembly-CSharp.dll_Excuted;

		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		[FieldOffset(Offset = "0x1BA")]
		private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GraffitiBehaviourAssembly-CSharp.dll_Excuted;
	}
}
