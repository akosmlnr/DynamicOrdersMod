using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public class PlayerCamera : PlayerSingleton<PlayerCamera>
	{
		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x0000BE08 File Offset: 0x0000A008
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000654")]
		public static ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			[Token(Token = "0x6002420")]
			[Address(RVA = "0x683E90", Offset = "0x683090", VA = "0x180683E90")]
			[CompilerGenerated]
			get
			{
				return ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode.Off;
			}
			[Token(Token = "0x6002421")]
			[Address(RVA = "0x683FA0", Offset = "0x6831A0", VA = "0x180683FA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06002422 RID: 9250 RVA: 0x0000BE20 File Offset: 0x0000A020
		// (set) Token: 0x06002423 RID: 9251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000655")]
		public bool canLook
		{
			[Token(Token = "0x6002422")]
			[Address(RVA = "0x4E7120", Offset = "0x4E6320", VA = "0x1804E7120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002423")]
			[Address(RVA = "0x4E73B0", Offset = "0x4E65B0", VA = "0x1804E73B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06002424 RID: 9252 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x17000656")]
		public int activeUIElementCount
		{
			[Token(Token = "0x6002424")]
			[Address(RVA = "0x683F60", Offset = "0x683160", VA = "0x180683F60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x0000BE50 File Offset: 0x0000A050
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000657")]
		public bool transformOverriden
		{
			[Token(Token = "0x6002425")]
			[Address(RVA = "0x4E7280", Offset = "0x4E6480", VA = "0x1804E7280")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002426")]
			[Address(RVA = "0x4E7440", Offset = "0x4E6640", VA = "0x1804E7440")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x0000BE68 File Offset: 0x0000A068
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000658")]
		public bool fovOverriden
		{
			[Token(Token = "0x6002427")]
			[Address(RVA = "0x4E7290", Offset = "0x4E6490", VA = "0x1804E7290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002428")]
			[Address(RVA = "0x4E7450", Offset = "0x4E6650", VA = "0x1804E7450")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x0000BE80 File Offset: 0x0000A080
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000659")]
		public bool FreeCamEnabled
		{
			[Token(Token = "0x6002429")]
			[Address(RVA = "0x683EF0", Offset = "0x6830F0", VA = "0x180683EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600242A")]
			[Address(RVA = "0x684020", Offset = "0x683220", VA = "0x180684020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x0000BE98 File Offset: 0x0000A098
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065A")]
		public bool ViewingAvatar
		{
			[Token(Token = "0x600242B")]
			[Address(RVA = "0x683F50", Offset = "0x683150", VA = "0x180683F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600242C")]
			[Address(RVA = "0x684040", Offset = "0x683240", VA = "0x180684040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		// (set) Token: 0x0600242E RID: 9262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065B")]
		public PlayerCamera.ECameraMode CameraMode
		{
			[Token(Token = "0x600242D")]
			[Address(RVA = "0x4F0940", Offset = "0x4EFB40", VA = "0x1804F0940")]
			[CompilerGenerated]
			get
			{
				return PlayerCamera.ECameraMode.Default;
			}
			[Token(Token = "0x600242E")]
			[Address(RVA = "0x4F0AF0", Offset = "0x4EFCF0", VA = "0x1804F0AF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x0600242F RID: 9263 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		// (set) Token: 0x06002430 RID: 9264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065C")]
		public bool MethVisuals
		{
			[Token(Token = "0x600242F")]
			[Address(RVA = "0x525700", Offset = "0x524900", VA = "0x180525700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002430")]
			[Address(RVA = "0x684030", Offset = "0x683230", VA = "0x180684030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065D")]
		public bool CocaineVisuals
		{
			[Token(Token = "0x6002431")]
			[Address(RVA = "0x683EE0", Offset = "0x6830E0", VA = "0x180683EE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002432")]
			[Address(RVA = "0x684000", Offset = "0x683200", VA = "0x180684000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		// (set) Token: 0x06002434 RID: 9268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065E")]
		public float FovJitter
		{
			[Token(Token = "0x6002433")]
			[Address(RVA = "0x50EF40", Offset = "0x50E140", VA = "0x18050EF40")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002434")]
			[Address(RVA = "0x684010", Offset = "0x683210", VA = "0x180684010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x0000206A File Offset: 0x0000026A
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065F")]
		public List<string> activeUIElements
		{
			[Token(Token = "0x6002435")]
			[Address(RVA = "0x4E7270", Offset = "0x4E6470", VA = "0x1804E7270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002436")]
			[Address(RVA = "0x4E7420", Offset = "0x4E6620", VA = "0x1804E7420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x17000660")]
		public static bool IsCursorShowing
		{
			[Token(Token = "0x6002437")]
			[Address(RVA = "0x683F00", Offset = "0x683100", VA = "0x180683F00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x67CAA0", Offset = "0x67BCA0", VA = "0x18067CAA0", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x67ED70", Offset = "0x67DF70", VA = "0x18067ED70", Slot = "6")]
		public override void OnStartClient(bool IsOwner)
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x681990", Offset = "0x680B90", VA = "0x180681990", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x67F570", Offset = "0x67E770", VA = "0x18067F570")]
		private void PlayerSpawned()
		{
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x6812D0", Offset = "0x6804D0", VA = "0x1806812D0")]
		public static void SetAntialiasingMode(ScheduleOne.DevUtilities.GraphicsSettings.EAntiAliasingMode mode)
		{
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243D")]
		[Address(RVA = "0x67C9C0", Offset = "0x67BBC0", VA = "0x18067C9C0")]
		public void ApplyAASettings()
		{
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243E")]
		[Address(RVA = "0x682C10", Offset = "0x681E10", VA = "0x180682C10", Slot = "8")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600243F")]
		[Address(RVA = "0x681240", Offset = "0x680440", VA = "0x180681240")]
		private void Screenshot()
		{
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002440")]
		[Address(RVA = "0x67D960", Offset = "0x67CB60", VA = "0x18067D960", Slot = "9")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002441")]
		[Address(RVA = "0x67D360", Offset = "0x67C560", VA = "0x18067D360")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x6002442")]
		[Address(RVA = "0x67D690", Offset = "0x67C890", VA = "0x18067D690")]
		public float GetTargetLocalY()
		{
			return 0f;
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x4F0AF0", Offset = "0x4EFCF0", VA = "0x1804F0AF0")]
		public void SetCameraMode(PlayerCamera.ECameraMode mode)
		{
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x680400", Offset = "0x67F600", VA = "0x180680400")]
		private void RotateCamera()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x67DEC0", Offset = "0x67D0C0", VA = "0x18067DEC0")]
		public void LockMouse()
		{
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002446")]
		[Address(RVA = "0x67D4B0", Offset = "0x67C6B0", VA = "0x18067D4B0")]
		public void FreeMouse()
		{
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x6002447")]
		[Address(RVA = "0x67E4B0", Offset = "0x67D6B0", VA = "0x18067E4B0")]
		public bool LookRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			return default(bool);
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x67E0A0", Offset = "0x67D2A0", VA = "0x18067E0A0")]
		public bool LookRaycast_ExcludeBuildables(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true)
		{
			return default(bool);
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x67EC80", Offset = "0x67DE80", VA = "0x18067EC80")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x67FAF0", Offset = "0x67ECF0", VA = "0x18067FAF0")]
		public bool Raycast_ExcludeBuildables(Vector3 origin, Vector3 direction, float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = false, float radius = 0f, float maxAngleDifference = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x67D5C0", Offset = "0x67C7C0", VA = "0x18067D5C0")]
		public Ray GetMouseRay()
		{
			return default(Ray);
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x67E860", Offset = "0x67DA60", VA = "0x18067E860")]
		public bool MouseRaycast(float range, out RaycastHit hit, LayerMask layerMask, bool includeTriggers = true, float radius = 0f)
		{
			return default(bool);
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x67E700", Offset = "0x67D900", VA = "0x18067E700")]
		public bool LookSpherecast(float range, float radius, out RaycastHit hit, LayerMask layerMask)
		{
			return default(bool);
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x67F2F0", Offset = "0x67E4F0", VA = "0x18067F2F0")]
		public void OverrideTransform(Vector3 worldPos, Quaternion rot, float lerpTime, bool keepParented = false)
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x67D750", Offset = "0x67C950", VA = "0x18067D750")]
		protected IEnumerator ILerpCamera(Vector3 endPos, Quaternion endRot, float lerpTime, bool worldSpace, bool returnToRestingPosition = false, bool reenableLook = false)
		{
			return null;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x681E30", Offset = "0x681030", VA = "0x180681E30")]
		public void StopTransformOverride(float lerpTime, bool reenableCameraLook = true, bool returnToOriginalRotation = true)
		{
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x67DFB0", Offset = "0x67D1B0", VA = "0x18067DFB0")]
		public void LookAt(Vector3 point, float duration = 0.25f)
		{
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x5C1330", Offset = "0x5C0530", VA = "0x1805C1330")]
		private void SetCanLook_True()
		{
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002453")]
		[Address(RVA = "0x4E73B0", Offset = "0x4E65B0", VA = "0x1804E73B0")]
		public void SetCanLook(bool c)
		{
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x681430", Offset = "0x680630", VA = "0x180681430")]
		public void SetDoFActive(bool active, float lerpTime)
		{
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x67DE20", Offset = "0x67D020", VA = "0x18067DE20")]
		private IEnumerator LerpDoF(bool active, float lerpTime)
		{
			return null;
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x67F1A0", Offset = "0x67E3A0", VA = "0x18067F1A0")]
		public void OverrideFOV(float fov, float lerpTime)
		{
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x67D820", Offset = "0x67CA20", VA = "0x18067D820")]
		protected IEnumerator ILerpFOV(float endFov, float lerpTime)
		{
			return null;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x681CA0", Offset = "0x680EA0", VA = "0x180681CA0")]
		public void StopFOVOverride(float lerpTime)
		{
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x67C930", Offset = "0x67BB30", VA = "0x18067C930")]
		public void AddActiveUIElement(string name)
		{
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x680300", Offset = "0x67F500", VA = "0x180680300")]
		public void RemoveActiveUIElement(string name)
		{
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x6800A0", Offset = "0x67F2A0", VA = "0x1806800A0")]
		public void RegisterMovementEvent(int threshold, Action action)
		{
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x67D160", Offset = "0x67C360", VA = "0x18067D160")]
		public void DeregisterMovementEvent(Action action)
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x6829E0", Offset = "0x681BE0", VA = "0x1806829E0")]
		private void UpdateMovementEvents()
		{
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x683580", Offset = "0x682780", VA = "0x180683580")]
		private void ViewAvatar()
		{
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x682320", Offset = "0x681520", VA = "0x180682320")]
		private void StopViewingAvatar()
		{
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x67D8E0", Offset = "0x67CAE0", VA = "0x18067D8E0")]
		public void JoltCamera()
		{
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x6002461")]
		[Address(RVA = "0x67F710", Offset = "0x67E910", VA = "0x18067F710")]
		public bool PointInCameraView(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x6002462")]
		[Address(RVA = "0x67D8C0", Offset = "0x67CAC0", VA = "0x18067D8C0")]
		public bool Is01(float a)
		{
			return default(bool);
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002463")]
		[Address(RVA = "0x680390", Offset = "0x67F590", VA = "0x180680390")]
		public void ResetRotation()
		{
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x67D3E0", Offset = "0x67C5E0", VA = "0x18067D3E0")]
		public void FocusCameraOnTarget(Transform target)
		{
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x681DF0", Offset = "0x680FF0", VA = "0x180681DF0")]
		public void StopFocus()
		{
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x67EE20", Offset = "0x67E020", VA = "0x18067EE20")]
		public void OpenInterface(bool keepInventoryVisible = false, bool keepCompassVisible = false)
		{
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x67CD50", Offset = "0x67BF50", VA = "0x18067CD50")]
		public void CloseInterface(float cameraLerpTime = 0.2f, bool reenableCameraInput = true)
		{
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002468")]
		[Address(RVA = "0x681830", Offset = "0x680A30", VA = "0x180681830")]
		public void StartCameraShake(float intensity, float duration = -1f, bool decreaseOverTime = true)
		{
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002469")]
		[Address(RVA = "0x681C00", Offset = "0x680E00", VA = "0x180681C00")]
		public void StopCameraShake()
		{
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246A")]
		[Address(RVA = "0x682550", Offset = "0x681750", VA = "0x180682550")]
		public void UpdateCameraBob()
		{
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246B")]
		[Address(RVA = "0x681500", Offset = "0x680700", VA = "0x180681500")]
		public void SetFreeCam(bool enable, bool reenableLook = true)
		{
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246C")]
		[Address(RVA = "0x680CE0", Offset = "0x67FEE0", VA = "0x180680CE0")]
		private void RotateFreeCam()
		{
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246D")]
		[Address(RVA = "0x682720", Offset = "0x681920", VA = "0x180682720")]
		private void UpdateFreeCamInput()
		{
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246E")]
		[Address(RVA = "0x67EA80", Offset = "0x67DC80", VA = "0x18067EA80")]
		private void MoveFreeCam()
		{
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600246F")]
		[Address(RVA = "0x683B90", Offset = "0x682D90", VA = "0x180683B90")]
		public PlayerCamera()
		{
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002473")]
		[Address(RVA = "0x682500", Offset = "0x681700", VA = "0x180682500")]
		[CompilerGenerated]
		internal static IEnumerator <Screenshot>g__Routine|100_0()
		{
			return null;
		}

		// Token: 0x04001C3D RID: 7229
		[Token(Token = "0x4001C3D")]
		public const float CAMERA_SHAKE_MULTIPLIER = 0.1f;

		// Token: 0x04001C3F RID: 7231
		[Token(Token = "0x4001C3F")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		public float cameraOffsetFromTop;

		// Token: 0x04001C40 RID: 7232
		[Token(Token = "0x4001C40")]
		[FieldOffset(Offset = "0x24")]
		public float SprintFoVBoost;

		// Token: 0x04001C41 RID: 7233
		[Token(Token = "0x4001C41")]
		[FieldOffset(Offset = "0x28")]
		public float FoVChangeRate;

		// Token: 0x04001C42 RID: 7234
		[Token(Token = "0x4001C42")]
		[FieldOffset(Offset = "0x2C")]
		public float HorizontalCameraBob;

		// Token: 0x04001C43 RID: 7235
		[Token(Token = "0x4001C43")]
		[FieldOffset(Offset = "0x30")]
		public float VerticalCameraBob;

		// Token: 0x04001C44 RID: 7236
		[Token(Token = "0x4001C44")]
		[FieldOffset(Offset = "0x34")]
		public float BobRate;

		// Token: 0x04001C45 RID: 7237
		[Token(Token = "0x4001C45")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve HorizontalBobCurve;

		// Token: 0x04001C46 RID: 7238
		[Token(Token = "0x4001C46")]
		[FieldOffset(Offset = "0x40")]
		public AnimationCurve VerticalBobCurve;

		// Token: 0x04001C47 RID: 7239
		[Token(Token = "0x4001C47")]
		[FieldOffset(Offset = "0x48")]
		public float FreeCamSpeed;

		// Token: 0x04001C48 RID: 7240
		[Token(Token = "0x4001C48")]
		[FieldOffset(Offset = "0x4C")]
		public float FreeCamAcceleration;

		// Token: 0x04001C49 RID: 7241
		[Token(Token = "0x4001C49")]
		[FieldOffset(Offset = "0x50")]
		public bool SmoothLook;

		// Token: 0x04001C4A RID: 7242
		[Token(Token = "0x4001C4A")]
		[FieldOffset(Offset = "0x54")]
		public float SmoothLookSpeed;

		// Token: 0x04001C4B RID: 7243
		[Token(Token = "0x4001C4B")]
		[FieldOffset(Offset = "0x58")]
		public FloatSmoother FoVChangeSmoother;

		// Token: 0x04001C4C RID: 7244
		[Token(Token = "0x4001C4C")]
		[FieldOffset(Offset = "0x60")]
		public FloatSmoother SmoothLookSmoother;

		// Token: 0x04001C4D RID: 7245
		[Token(Token = "0x4001C4D")]
		[FieldOffset(Offset = "0x68")]
		[Header("References")]
		public Transform CameraContainer;

		// Token: 0x04001C4E RID: 7246
		[Token(Token = "0x4001C4E")]
		[FieldOffset(Offset = "0x70")]
		public Camera Camera;

		// Token: 0x04001C4F RID: 7247
		[Token(Token = "0x4001C4F")]
		[FieldOffset(Offset = "0x78")]
		public Camera OverlayCamera;

		// Token: 0x04001C50 RID: 7248
		[Token(Token = "0x4001C50")]
		[FieldOffset(Offset = "0x80")]
		public Animator Animator;

		// Token: 0x04001C51 RID: 7249
		[Token(Token = "0x4001C51")]
		[FieldOffset(Offset = "0x88")]
		public AnimationClip[] JoltClips;

		// Token: 0x04001C52 RID: 7250
		[Token(Token = "0x4001C52")]
		[FieldOffset(Offset = "0x90")]
		public UniversalRenderPipelineAsset[] URPAssets;

		// Token: 0x04001C53 RID: 7251
		[Token(Token = "0x4001C53")]
		[FieldOffset(Offset = "0x98")]
		public Transform ViewAvatarCameraPosition;

		// Token: 0x04001C54 RID: 7252
		[Token(Token = "0x4001C54")]
		[FieldOffset(Offset = "0xA0")]
		public HeartbeatSoundController HeartbeatSoundController;

		// Token: 0x04001C55 RID: 7253
		[Token(Token = "0x4001C55")]
		[FieldOffset(Offset = "0xA8")]
		public ParticleSystem Flies;

		// Token: 0x04001C56 RID: 7254
		[Token(Token = "0x4001C56")]
		[FieldOffset(Offset = "0xB0")]
		public AudioSourceController MethRumble;

		// Token: 0x04001C57 RID: 7255
		[Token(Token = "0x4001C57")]
		[FieldOffset(Offset = "0xB8")]
		public RandomizedAudioSourceController SchizoVoices;

		// Token: 0x04001C5B RID: 7259
		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0xC3")]
		[HideInInspector]
		public bool blockNextStopTransformOverride;

		// Token: 0x04001C62 RID: 7266
		[Token(Token = "0x4001C62")]
		[FieldOffset(Offset = "0xD8")]
		private Volume globalVolume;

		// Token: 0x04001C63 RID: 7267
		[Token(Token = "0x4001C63")]
		[FieldOffset(Offset = "0xE0")]
		private DepthOfField DoF;

		// Token: 0x04001C65 RID: 7269
		[Token(Token = "0x4001C65")]
		[FieldOffset(Offset = "0xF0")]
		private Coroutine cameraShakeCoroutine;

		// Token: 0x04001C66 RID: 7270
		[Token(Token = "0x4001C66")]
		[FieldOffset(Offset = "0xF8")]
		private Vector3 cameraLocalPos;

		// Token: 0x04001C67 RID: 7271
		[Token(Token = "0x4001C67")]
		[FieldOffset(Offset = "0x104")]
		private Vector3 freeCamMovement;

		// Token: 0x04001C68 RID: 7272
		[Token(Token = "0x4001C68")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine focusRoutine;

		// Token: 0x04001C69 RID: 7273
		[Token(Token = "0x4001C69")]
		[FieldOffset(Offset = "0x118")]
		private float focusMouseX;

		// Token: 0x04001C6A RID: 7274
		[Token(Token = "0x4001C6A")]
		[FieldOffset(Offset = "0x11C")]
		private float focusMouseY;

		// Token: 0x04001C6B RID: 7275
		[Token(Token = "0x4001C6B")]
		[FieldOffset(Offset = "0x120")]
		private Dictionary<int, MotionEvent> movementEvents;

		// Token: 0x04001C6C RID: 7276
		[Token(Token = "0x4001C6C")]
		[FieldOffset(Offset = "0x128")]
		private List<int> movementEventKeys;

		// Token: 0x04001C6D RID: 7277
		[Token(Token = "0x4001C6D")]
		[FieldOffset(Offset = "0x130")]
		private float freeCamSpeed;

		// Token: 0x04001C6E RID: 7278
		[Token(Token = "0x4001C6E")]
		[FieldOffset(Offset = "0x134")]
		private float mouseX;

		// Token: 0x04001C6F RID: 7279
		[Token(Token = "0x4001C6F")]
		[FieldOffset(Offset = "0x138")]
		private float mouseY;

		// Token: 0x04001C70 RID: 7280
		[Token(Token = "0x4001C70")]
		[FieldOffset(Offset = "0x13C")]
		private Vector2 seizureJitter;

		// Token: 0x04001C71 RID: 7281
		[Token(Token = "0x4001C71")]
		[FieldOffset(Offset = "0x144")]
		private float schizoFoV;

		// Token: 0x04001C72 RID: 7282
		[Token(Token = "0x4001C72")]
		[FieldOffset(Offset = "0x148")]
		private float timeUntilNextSchizoVoice;

		// Token: 0x04001C73 RID: 7283
		[Token(Token = "0x4001C73")]
		[FieldOffset(Offset = "0x4")]
		private static bool isCursorShowing;

		// Token: 0x04001C74 RID: 7284
		[Token(Token = "0x4001C74")]
		[FieldOffset(Offset = "0x150")]
		private List<Vector3> gizmos;

		// Token: 0x04001C75 RID: 7285
		[Token(Token = "0x4001C75")]
		[FieldOffset(Offset = "0x158")]
		private Vector3 cameralocalPos_PriorOverride;

		// Token: 0x04001C76 RID: 7286
		[Token(Token = "0x4001C76")]
		[FieldOffset(Offset = "0x164")]
		private Quaternion cameraLocalRot_PriorOverride;

		// Token: 0x04001C77 RID: 7287
		[Token(Token = "0x4001C77")]
		[FieldOffset(Offset = "0x178")]
		public Coroutine ILerpCamera_Coroutine;

		// Token: 0x04001C78 RID: 7288
		[Token(Token = "0x4001C78")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine lookRoutine;

		// Token: 0x04001C79 RID: 7289
		[Token(Token = "0x4001C79")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine DoFCoroutine;

		// Token: 0x04001C7A RID: 7290
		[Token(Token = "0x4001C7A")]
		[FieldOffset(Offset = "0x190")]
		private Coroutine ILerpCameraFOV_Coroutine;

		// Token: 0x020005E3 RID: 1507
		[Token(Token = "0x20005E3")]
		public enum ECameraMode
		{
			// Token: 0x04001C7C RID: 7292
			[Token(Token = "0x4001C7C")]
			Default,
			// Token: 0x04001C7D RID: 7293
			[Token(Token = "0x4001C7D")]
			Vehicle,
			// Token: 0x04001C7E RID: 7294
			[Token(Token = "0x4001C7E")]
			Skateboard
		}
	}
}
