using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Pathfinding;
using ScheduleOne.DevUtilities;
using ScheduleOne.Math;
using UnityEngine;

namespace ScheduleOne.Vehicles.AI
{
	// Token: 0x020002CB RID: 715
	[Token(Token = "0x20002CB")]
	[RequireComponent(typeof(LandVehicle))]
	public class VehicleAgent : MonoBehaviour
	{
		// Token: 0x17000385 RID: 901
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00007DE8 File Offset: 0x00005FE8
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000385")]
		public bool AutoDriving
		{
			[Token(Token = "0x60010AB")]
			[Address(RVA = "0x68A2D0", Offset = "0x6894D0", VA = "0x18068A2D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60010AC")]
			[Address(RVA = "0x570D90", Offset = "0x56FF90", VA = "0x180570D90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x17000386")]
		public bool KinematicMode
		{
			[Token(Token = "0x60010AD")]
			[Address(RVA = "0xB12650", Offset = "0xB11850", VA = "0x180B12650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x060010AE RID: 4270 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x17000387")]
		public bool IsReversing
		{
			[Token(Token = "0x60010AE")]
			[Address(RVA = "0xB12640", Offset = "0xB11840", VA = "0x180B12640")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00007E30 File Offset: 0x00006030
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000388")]
		public Vector3 TargetLocation
		{
			[Token(Token = "0x60010AF")]
			[Address(RVA = "0x4D4930", Offset = "0x4D3B30", VA = "0x1804D4930")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x4D4BE0", Offset = "0x4D3DE0", VA = "0x1804D4BE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x17000389")]
		protected float sampleStepSize
		{
			[Token(Token = "0x60010B1")]
			[Address(RVA = "0xB127A0", Offset = "0xB119A0", VA = "0x180B127A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x1700038A")]
		protected float turnSpeedReductionRange
		{
			[Token(Token = "0x60010B2")]
			[Address(RVA = "0xB12850", Offset = "0xB11A50", VA = "0x180B12850")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x060010B3 RID: 4275 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x1700038B")]
		protected float maxSteerAngle
		{
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0xB12770", Offset = "0xB11970", VA = "0x180B12770")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x1700038C")]
		private Vector3 frontOfVehiclePosition
		{
			[Token(Token = "0x60010B4")]
			[Address(RVA = "0xB12690", Offset = "0xB11890", VA = "0x180B12690")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x1700038D")]
		public bool NavigationCalculationInProgress
		{
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0xB12680", Offset = "0xB11880", VA = "0x180B12680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x1700038E")]
		private float timeSinceLastNavigationCall
		{
			[Token(Token = "0x60010B6")]
			[Address(RVA = "0xB12830", Offset = "0xB11A30", VA = "0x180B12830")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B7")]
		[Address(RVA = "0xB0A940", Offset = "0xB09B40", VA = "0x180B0A940")]
		private void Awake()
		{
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B8")]
		[Address(RVA = "0xB0ED70", Offset = "0xB0DF70", VA = "0x180B0ED70", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010B9")]
		[Address(RVA = "0xB0D7C0", Offset = "0xB0C9C0", VA = "0x180B0D7C0")]
		private void InitializeVehicleData()
		{
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0xB0C170", Offset = "0xB0B370", VA = "0x180B0C170", Slot = "5")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0xB0D450", Offset = "0xB0C650", VA = "0x180B0D450")]
		protected void InfrequentUpdate()
		{
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0xB0E270", Offset = "0xB0D470", VA = "0x180B0E270")]
		protected void LateUpdate()
		{
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0xB0FC20", Offset = "0xB0EE20", VA = "0x180B0FC20")]
		protected void UpdateKinematic(float deltaTime)
		{
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0xB0C180", Offset = "0xB0B380", VA = "0x180B0C180")]
		private Vector3 GetAxleGroundHit(bool front)
		{
			return default(Vector3);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0xB12190", Offset = "0xB11390", VA = "0x180B12190")]
		private void UpdateSweep()
		{
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0xB10A60", Offset = "0xB0FC60", VA = "0x180B10A60")]
		private void UpdateSpeedReduction()
		{
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0xB10850", Offset = "0xB0FA50", VA = "0x180B10850")]
		private void UpdatePursuitMode()
		{
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0xB11E20", Offset = "0xB11020", VA = "0x180B11E20")]
		private void UpdateStuckDetection()
		{
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C3")]
		[Address(RVA = "0xB0BC30", Offset = "0xB0AE30", VA = "0x180B0BC30")]
		private void CheckDistanceFromPath()
		{
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C4")]
		[Address(RVA = "0xB10770", Offset = "0xB0F970", VA = "0x180B10770")]
		private void UpdateOvertaking()
		{
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0xB0EB90", Offset = "0xB0DD90", VA = "0x180B0EB90", Slot = "6")]
		protected virtual void RefreshSpeedZone()
		{
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0xB11370", Offset = "0xB10570", VA = "0x180B11370", Slot = "7")]
		protected virtual void UpdateSpeed()
		{
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C7")]
		[Address(RVA = "0xB11480", Offset = "0xB10680", VA = "0x180B11480")]
		protected void UpdateSteering()
		{
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C8")]
		[Address(RVA = "0xB0E490", Offset = "0xB0D690", VA = "0x180B0E490")]
		public void Navigate(Vector3 location, [Optional] NavigationSettings settings, [Optional] VehicleAgent.NavigationCallback callback)
		{
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0xB0EA90", Offset = "0xB0DC90", VA = "0x180B0EA90")]
		private void NavigationCalculationCallback(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath _path)
		{
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0xB0C020", Offset = "0xB0B220", VA = "0x180B0C020")]
		private void EndDriving()
		{
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0xB0EE30", Offset = "0xB0E030", VA = "0x180B0EE30")]
		public void StopNavigating()
		{
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CC")]
		[Address(RVA = "0xB0EB40", Offset = "0xB0DD40", VA = "0x180B0EB40")]
		public void RecalculateNavigation()
		{
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x60010CD")]
		[Address(RVA = "0xB0EF40", Offset = "0xB0E140", VA = "0x180B0EF40")]
		public bool SweepTurn(VehicleAgent.ESweepType sweep, float sweepAngle, bool reverse, out float hitDistance, out Vector3 hitPoint, float steerAngle = 0f)
		{
			return default(bool);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CE")]
		[Address(RVA = "0xB0AC50", Offset = "0xB09E50", VA = "0x180B0AC50")]
		public void BetterSweepTurn(VehicleAgent.ESweepType sweep, float steerAngle, bool reverse, LayerMask mask, out float hitDistance, out RaycastHit hit)
		{
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010CF")]
		[Address(RVA = "0xB0ECD0", Offset = "0xB0DED0", VA = "0x180B0ECD0")]
		public void StartReverse()
		{
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D0")]
		[Address(RVA = "0xB0EC60", Offset = "0xB0DE60", VA = "0x180B0EC60")]
		public IEnumerator Reverse()
		{
			return null;
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D1")]
		[Address(RVA = "0xB0EE90", Offset = "0xB0E090", VA = "0x180B0EE90")]
		private void StopReversing()
		{
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60010D2")]
		[Address(RVA = "0xB0C740", Offset = "0xB0B940", VA = "0x180B0C740")]
		private Collider GetClosestForwardObstruction(out float obstructionDist)
		{
			return null;
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x60010D3")]
		[Address(RVA = "0xB0E250", Offset = "0xB0D450", VA = "0x180B0E250")]
		public bool IsOnVehicleGraph()
		{
			return default(bool);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x60010D4")]
		[Address(RVA = "0xB0CBE0", Offset = "0xB0BDE0", VA = "0x180B0CBE0")]
		private float GetDistanceFromVehicleGraph()
		{
			return 0f;
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x60010D5")]
		[Address(RVA = "0xB0D1E0", Offset = "0xB0C3E0", VA = "0x180B0D1E0")]
		private Vector3 GetPathLateralDirection()
		{
			return default(Vector3);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x60010D6")]
		[Address(RVA = "0xB0CED0", Offset = "0xB0C0D0", VA = "0x180B0CED0")]
		public bool GetIsStuck()
		{
			return default(bool);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010D7")]
		[Address(RVA = "0xB12510", Offset = "0xB11710", VA = "0x180B12510")]
		public VehicleAgent()
		{
		}

		// Token: 0x04000F13 RID: 3859
		[Token(Token = "0x4000F13")]
		public const string VehicleGraphName = "General Vehicle Graph";

		// Token: 0x04000F14 RID: 3860
		[Token(Token = "0x4000F14")]
		public const string RoadGraphName = "Road Nodes";

		// Token: 0x04000F15 RID: 3861
		[Token(Token = "0x4000F15")]
		public const float MaxDistanceFromPath = 6f;

		// Token: 0x04000F16 RID: 3862
		[Token(Token = "0x4000F16")]
		public const float MaxDistanceFromPathWhenReversing = 8f;

		// Token: 0x04000F17 RID: 3863
		[Token(Token = "0x4000F17")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Vector3 MainGraphSamplePoint;

		// Token: 0x04000F18 RID: 3864
		[Token(Token = "0x4000F18")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float MinRenavigationRate;

		// Token: 0x04000F19 RID: 3865
		[Token(Token = "0x4000F19")]
		public const float Steer_P = 40f;

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		public const float Steer_I = 5f;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		public const float Steer_D = 10f;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		public const float Throttle_P = 0.08f;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		public const float Throttle_I = 0f;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		public const float Throttle_D = 0f;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		public const float Steer_Rate = 135f;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		public const float MaxAxlePositionShift = 3f;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		public const float OBSTACLE_MIN_RANGE = 1.5f;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		public const float OBSTACLE_MAX_RANGE = 15f;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		public const float MAX_STEER_ANGLE_OVERRIDE = 35f;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		public const float INFREQUENT_UPDATE_RATE = 0.033f;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool DEBUG_MODE;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DriveFlags Flags;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Seekers")]
		[SerializeField]
		protected Seeker roadSeeker;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Seeker generalSeeker;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Header("References")]
		protected Transform CTE_Origin;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform FrontAxlePosition;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Transform RearAxlePosition;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Sensors")]
		[SerializeField]
		protected Sensor sensor_FL;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected Sensor sensor_FM;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected Sensor sensor_FR;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		protected Sensor sensor_RR;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected Sensor sensor_RL;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Sensor[] sensors;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Header("Sweeping")]
		protected LayerMask sweepMask;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected Transform sweepOrigin_FL;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected Transform sweepOrigin_FR;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected Transform sweepOrigin_RL;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected Transform sweepOrigin_RR;

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected Wheel leftWheel;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected Wheel rightWheel;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		protected const float sweepSegment = 15f;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Path following")]
		protected float sampleStepSizeMin;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		protected float sampleStepSizeMax;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		protected int aheadPointSamples;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		protected const float DestinationDistanceSlowThreshold = 8f;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		protected const float DestinationArrivalThreshold = 3f;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		[Header("Steer settings")]
		protected float steerTargetFollowRate;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private SteerPID steerPID;

		// Token: 0x04000F43 RID: 3907
		[Token(Token = "0x4000F43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Header("Turning speed reduction")]
		protected float turnSpeedReductionMinRange;

		// Token: 0x04000F44 RID: 3908
		[Token(Token = "0x4000F44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		protected float turnSpeedReductionMaxRange;

		// Token: 0x04000F45 RID: 3909
		[Token(Token = "0x4000F45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		protected float turnSpeedReductionDivisor;

		// Token: 0x04000F46 RID: 3910
		[Token(Token = "0x4000F46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float minTurnSpeedReductionAngleThreshold;

		// Token: 0x04000F47 RID: 3911
		[Token(Token = "0x4000F47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float minTurningSpeed;

		// Token: 0x04000F48 RID: 3912
		[Token(Token = "0x4000F48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Header("Throttle")]
		[SerializeField]
		protected float throttleMin;

		// Token: 0x04000F49 RID: 3913
		[Token(Token = "0x4000F49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		protected float throttleMax;

		// Token: 0x04000F4A RID: 3914
		[Token(Token = "0x4000F4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private PID throttlePID;

		// Token: 0x04000F4B RID: 3915
		[Token(Token = "0x4000F4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float UnmarkedSpeed;

		// Token: 0x04000F4C RID: 3916
		[Token(Token = "0x4000F4C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float ReverseSpeed;

		// Token: 0x04000F4D RID: 3917
		[Token(Token = "0x4000F4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private ValueTracker speedReductionTracker;

		// Token: 0x04000F4E RID: 3918
		[Token(Token = "0x4000F4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Header("Pursuit Mode")]
		public bool PursuitModeEnabled;

		// Token: 0x04000F4F RID: 3919
		[Token(Token = "0x4000F4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Transform PursuitTarget;

		// Token: 0x04000F50 RID: 3920
		[Token(Token = "0x4000F50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float PursuitDistanceUpdateThreshold;

		// Token: 0x04000F51 RID: 3921
		[Token(Token = "0x4000F51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 PursuitTargetLastPosition;

		// Token: 0x04000F52 RID: 3922
		[Token(Token = "0x4000F52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("Stuck Detection")]
		public VehicleTeleporter Teleporter;

		// Token: 0x04000F53 RID: 3923
		[Token(Token = "0x4000F53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public PositionHistoryTracker PositionHistoryTracker;

		// Token: 0x04000F54 RID: 3924
		[Token(Token = "0x4000F54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public float StuckTimeThreshold;

		// Token: 0x04000F55 RID: 3925
		[Token(Token = "0x4000F55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public int StuckSamples;

		// Token: 0x04000F56 RID: 3926
		[Token(Token = "0x4000F56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public float StuckDistanceThreshold;

		// Token: 0x04000F57 RID: 3927
		[Token(Token = "0x4000F57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		protected VehicleAgent.NavigationCallback storedNavigationCallback;

		// Token: 0x04000F58 RID: 3928
		[Token(Token = "0x4000F58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		protected SpeedZone currentSpeedZone;

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		protected LandVehicle vehicle;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		protected float wheelbase;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		protected float wheeltrack;

		// Token: 0x04000F5C RID: 3932
		[Token(Token = "0x4000F5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		protected float vehicleLength;

		// Token: 0x04000F5D RID: 3933
		[Token(Token = "0x4000F5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		protected float vehicleWidth;

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		protected float turnRadius;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		protected float sweepTrack;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float wheelBottomOffset;

		// Token: 0x04000F61 RID: 3937
		[Token(Token = "0x4000F61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[SerializeField]
		[Header("Control info - READONLY")]
		protected float targetSpeed;

		// Token: 0x04000F62 RID: 3938
		[Token(Token = "0x4000F62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		[SerializeField]
		protected float targetSteerAngle_Normalized;

		// Token: 0x04000F63 RID: 3939
		[Token(Token = "0x4000F63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		protected float lateralOffset;

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected PathSmoothingUtility.SmoothedPath path;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float timeOnLastNavigationCall;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float sweepTestFailedTime;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private NavigationSettings currentNavigationSettings;

		// Token: 0x04000F68 RID: 3944
		[Token(Token = "0x4000F68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Coroutine navigationCalculationRoutine;

		// Token: 0x04000F69 RID: 3945
		[Token(Token = "0x4000F69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Coroutine reverseCoroutine;

		// Token: 0x020002CC RID: 716
		[Token(Token = "0x20002CC")]
		public enum ENavigationResult
		{
			// Token: 0x04000F6B RID: 3947
			[Token(Token = "0x4000F6B")]
			Failed,
			// Token: 0x04000F6C RID: 3948
			[Token(Token = "0x4000F6C")]
			Complete,
			// Token: 0x04000F6D RID: 3949
			[Token(Token = "0x4000F6D")]
			Stopped
		}

		// Token: 0x020002CD RID: 717
		[Token(Token = "0x20002CD")]
		public enum EAgentStatus
		{
			// Token: 0x04000F6F RID: 3951
			[Token(Token = "0x4000F6F")]
			Inactive,
			// Token: 0x04000F70 RID: 3952
			[Token(Token = "0x4000F70")]
			MovingToRoad,
			// Token: 0x04000F71 RID: 3953
			[Token(Token = "0x4000F71")]
			OnRoad
		}

		// Token: 0x020002CE RID: 718
		[Token(Token = "0x20002CE")]
		public enum EPathGroupStatus
		{
			// Token: 0x04000F73 RID: 3955
			[Token(Token = "0x4000F73")]
			Inactive,
			// Token: 0x04000F74 RID: 3956
			[Token(Token = "0x4000F74")]
			Calculating
		}

		// Token: 0x020002CF RID: 719
		[Token(Token = "0x20002CF")]
		public enum ESweepType
		{
			// Token: 0x04000F76 RID: 3958
			[Token(Token = "0x4000F76")]
			FL,
			// Token: 0x04000F77 RID: 3959
			[Token(Token = "0x4000F77")]
			FR,
			// Token: 0x04000F78 RID: 3960
			[Token(Token = "0x4000F78")]
			RL,
			// Token: 0x04000F79 RID: 3961
			[Token(Token = "0x4000F79")]
			RR
		}

		// Token: 0x020002D0 RID: 720
		// (Invoke) Token: 0x060010DB RID: 4315
		[Token(Token = "0x20002D0")]
		public delegate void NavigationCallback(VehicleAgent.ENavigationResult status);
	}
}
