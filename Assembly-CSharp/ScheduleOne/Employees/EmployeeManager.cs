using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x0200067B RID: 1659
	[Token(Token = "0x200067B")]
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x06002ADA RID: 10970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ADA")]
		[Address(RVA = "0x6F9C60", Offset = "0x6F8E60", VA = "0x1806F9C60")]
		public void CreateNewEmployee(Property property, EEmployeeType type)
		{
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ADB")]
		[Address(RVA = "0x6F9BC0", Offset = "0x6F8DC0", VA = "0x1806F9BC0")]
		[ServerRpc(RequireOwnership = false)]
		public void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002ADC")]
		[Address(RVA = "0x6F9570", Offset = "0x6F8770", VA = "0x1806F9570")]
		public Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			return null;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		[Token(Token = "0x6002ADD")]
		[Address(RVA = "0x6FA700", Offset = "0x6F9900", VA = "0x1806FA700")]
		private bool IsPositionValid(Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		[Token(Token = "0x6002ADE")]
		[Address(RVA = "0x6FA770", Offset = "0x6F9970", VA = "0x1806FA770")]
		private bool IsRotationValid(Quaternion rotation)
		{
			return default(bool);
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x0000DA10 File Offset: 0x0000BC10
		[Token(Token = "0x6002ADF")]
		[Address(RVA = "0x6FA6D0", Offset = "0x6F98D0", VA = "0x1806FA6D0")]
		private bool IsFloatValid(float value)
		{
			return default(bool);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE0")]
		[Address(RVA = "0x6FA9F0", Offset = "0x6F9BF0", VA = "0x1806FA9F0")]
		public void RegisterName(string name)
		{
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE1")]
		[Address(RVA = "0x6FA8F0", Offset = "0x6F9AF0", VA = "0x1806FA8F0")]
		public void RegisterAppearance(bool male, int index)
		{
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE2")]
		[Address(RVA = "0x6FA080", Offset = "0x6F9280", VA = "0x1806FA080")]
		public void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002AE3")]
		[Address(RVA = "0x6FA1F0", Offset = "0x6F93F0", VA = "0x1806FA1F0")]
		public EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			return null;
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002AE4")]
		[Address(RVA = "0x6FA670", Offset = "0x6F9870", VA = "0x1806FA670")]
		public VODatabase GetVoice(bool male, int index)
		{
			return null;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE5")]
		[Address(RVA = "0x6FA520", Offset = "0x6F9720", VA = "0x1806FA520")]
		public void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002AE6")]
		[Address(RVA = "0x6FA270", Offset = "0x6F9470", VA = "0x1806FA270")]
		public Employee GetEmployeePrefab(EEmployeeType type)
		{
			return null;
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6002AE7")]
		[Address(RVA = "0x6FA390", Offset = "0x6F9590", VA = "0x1806FA390")]
		public List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			return null;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE8")]
		[Address(RVA = "0x6FB060", Offset = "0x6FA260", VA = "0x1806FB060")]
		public EmployeeManager()
		{
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AE9")]
		[Address(RVA = "0x6FA850", Offset = "0x6F9A50", VA = "0x1806FA850", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEA")]
		[Address(RVA = "0x6FA800", Offset = "0x6F9A00", VA = "0x1806FA800", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEB")]
		[Address(RVA = "0x584650", Offset = "0x583850", VA = "0x180584650", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEC")]
		[Address(RVA = "0x6FAD30", Offset = "0x6F9F30", VA = "0x1806FAD30")]
		private void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AED")]
		[Address(RVA = "0x6FAAA0", Offset = "0x6F9CA0", VA = "0x1806FAAA0")]
		public void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEE")]
		[Address(RVA = "0x6FAB40", Offset = "0x6F9D40", VA = "0x1806FAB40")]
		private void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06002AEF RID: 10991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002AEF")]
		[Address(RVA = "0x6F9500", Offset = "0x6F8700", VA = "0x1806F9500", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x04002028 RID: 8232
		[Token(Token = "0x4002028")]
		public const float MALE_EMPLOYEE_CHANCE = 0.67f;

		// Token: 0x04002029 RID: 8233
		[Token(Token = "0x4002029")]
		[FieldOffset(Offset = "0x120")]
		public List<Employee> AllEmployees;

		// Token: 0x0400202A RID: 8234
		[Token(Token = "0x400202A")]
		[FieldOffset(Offset = "0x128")]
		public Quest_Employees[] EmployeeQuests;

		// Token: 0x0400202B RID: 8235
		[Token(Token = "0x400202B")]
		[FieldOffset(Offset = "0x130")]
		[Header("Prefabs")]
		public Botanist BotanistPrefab;

		// Token: 0x0400202C RID: 8236
		[Token(Token = "0x400202C")]
		[FieldOffset(Offset = "0x138")]
		public Packager PackagerPrefab;

		// Token: 0x0400202D RID: 8237
		[Token(Token = "0x400202D")]
		[FieldOffset(Offset = "0x140")]
		public Chemist ChemistPrefab;

		// Token: 0x0400202E RID: 8238
		[Token(Token = "0x400202E")]
		[FieldOffset(Offset = "0x148")]
		public Cleaner CleanerPrefab;

		// Token: 0x0400202F RID: 8239
		[Token(Token = "0x400202F")]
		[FieldOffset(Offset = "0x150")]
		[Header("Appearances")]
		public List<EmployeeManager.EmployeeAppearance> MaleAppearances;

		// Token: 0x04002030 RID: 8240
		[Token(Token = "0x4002030")]
		[FieldOffset(Offset = "0x158")]
		public List<EmployeeManager.EmployeeAppearance> FemaleAppearances;

		// Token: 0x04002031 RID: 8241
		[Token(Token = "0x4002031")]
		[FieldOffset(Offset = "0x160")]
		[Header("Voices")]
		public VODatabase[] MaleVoices;

		// Token: 0x04002032 RID: 8242
		[Token(Token = "0x4002032")]
		[FieldOffset(Offset = "0x168")]
		public VODatabase[] FemaleVoices;

		// Token: 0x04002033 RID: 8243
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x170")]
		[Header("Names")]
		public string[] MaleFirstNames;

		// Token: 0x04002034 RID: 8244
		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0x178")]
		public string[] FemaleFirstNames;

		// Token: 0x04002035 RID: 8245
		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x180")]
		public string[] LastNames;

		// Token: 0x04002036 RID: 8246
		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x188")]
		private List<string> takenNames;

		// Token: 0x04002037 RID: 8247
		[Token(Token = "0x4002037")]
		[FieldOffset(Offset = "0x190")]
		private List<int> takenMaleAppearances;

		// Token: 0x04002038 RID: 8248
		[Token(Token = "0x4002038")]
		[FieldOffset(Offset = "0x198")]
		private List<int> takenFemaleAppearances;

		// Token: 0x04002039 RID: 8249
		[Token(Token = "0x4002039")]
		[FieldOffset(Offset = "0x1A0")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0400203A RID: 8250
		[Token(Token = "0x400203A")]
		[FieldOffset(Offset = "0x1A1")]
		private bool NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x0200067C RID: 1660
		[Token(Token = "0x200067C")]
		[Serializable]
		public class EmployeeAppearance
		{
			// Token: 0x06002AF0 RID: 10992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002AF0")]
			[Address(RVA = "0x43D6A0", Offset = "0x43C8A0", VA = "0x18043D6A0")]
			public EmployeeAppearance()
			{
			}

			// Token: 0x0400203B RID: 8251
			[Token(Token = "0x400203B")]
			[FieldOffset(Offset = "0x10")]
			public AvatarSettings Settings;

			// Token: 0x0400203C RID: 8252
			[Token(Token = "0x400203C")]
			[FieldOffset(Offset = "0x18")]
			public Sprite Mugshot;
		}
	}
}
