using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Management
{
	// Token: 0x0200055C RID: 1372
	[Token(Token = "0x200055C")]
	public class ConfigurationReplicator : NetworkBehaviour
	{
		// Token: 0x06001E92 RID: 7826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x63E140", Offset = "0x63D340", VA = "0x18063E140")]
		public void ReplicateField(ConfigField field, [Optional] NetworkConnection conn)
		{
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x641730", Offset = "0x640930", VA = "0x180641730")]
		[ServerRpc(RequireOwnership = false)]
		private void SendItemField(int fieldIndex, string value)
		{
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x63D3D0", Offset = "0x63C5D0", VA = "0x18063D3D0")]
		[ObserversRpc]
		private void ReceiveItemField(int fieldIndex, string value)
		{
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x6418A0", Offset = "0x640AA0", VA = "0x1806418A0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendNPCField(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x63D550", Offset = "0x63C750", VA = "0x18063D550")]
		[ObserversRpc]
		private void ReceiveNPCField(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x641B80", Offset = "0x640D80", VA = "0x180641B80")]
		[ServerRpc(RequireOwnership = false)]
		private void SendObjectField(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x63D850", Offset = "0x63CA50", VA = "0x18063D850")]
		[ObserversRpc]
		private void ReceiveObjectField(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x641CF0", Offset = "0x640EF0", VA = "0x180641CF0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x63D9D0", Offset = "0x63CBD0", VA = "0x18063D9D0")]
		[ObserversRpc]
		private void ReceiveObjectListField(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x641FD0", Offset = "0x6411D0", VA = "0x180641FD0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x63DCC0", Offset = "0x63CEC0", VA = "0x18063DCC0")]
		[ObserversRpc]
		private void ReceiveRecipeField(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x641A10", Offset = "0x640C10", VA = "0x180641A10")]
		[ServerRpc(RequireOwnership = false)]
		private void SendNumberField(int fieldIndex, float value)
		{
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x63D6D0", Offset = "0x63C8D0", VA = "0x18063D6D0")]
		[ObserversRpc]
		private void ReceiveNumberField(int fieldIndex, float value)
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x642150", Offset = "0x641350", VA = "0x180642150")]
		[ServerRpc(RequireOwnership = false)]
		private void SendRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x63DE40", Offset = "0x63D040", VA = "0x18063DE40")]
		[ObserversRpc]
		private void ReceiveRouteListField(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x641E60", Offset = "0x641060", VA = "0x180641E60")]
		[ServerRpc(RequireOwnership = false)]
		private void SendQualityField(int fieldIndex, EQuality quality)
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x63DB50", Offset = "0x63CD50", VA = "0x18063DB50")]
		[ObserversRpc]
		private void ReceiveQualityField(int fieldIndex, EQuality value)
		{
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x6422C0", Offset = "0x6414C0", VA = "0x1806422C0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendStringField(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x63DFC0", Offset = "0x63D1C0", VA = "0x18063DFC0")]
		[ObserversRpc]
		private void ReceiveStringField(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x642430", Offset = "0x641630", VA = "0x180642430")]
		public ConfigurationReplicator()
		{
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x63CEC0", Offset = "0x63C0C0", VA = "0x18063CEC0", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x63CEA0", Offset = "0x63C0A0", VA = "0x18063CEA0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x641730", Offset = "0x640930", VA = "0x180641730")]
		private void RpcWriter___Server_SendItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x63D3D0", Offset = "0x63C5D0", VA = "0x18063D3D0")]
		private void RpcLogic___SendItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x640830", Offset = "0x63FA30", VA = "0x180640830")]
		private void RpcReader___Server_SendItemField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x63D3D0", Offset = "0x63C5D0", VA = "0x18063D3D0")]
		private void RpcWriter___Observers_ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x63F480", Offset = "0x63E680", VA = "0x18063F480")]
		private void RpcLogic___ReceiveItemField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x640380", Offset = "0x63F580", VA = "0x180640380")]
		private void RpcReader___Observers_ReceiveItemField_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x6418A0", Offset = "0x640AA0", VA = "0x1806418A0")]
		private void RpcWriter___Server_SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x63D550", Offset = "0x63C750", VA = "0x18063D550")]
		private void RpcLogic___SendNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x6409D0", Offset = "0x63FBD0", VA = "0x1806409D0")]
		private void RpcReader___Server_SendNPCField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x63D550", Offset = "0x63C750", VA = "0x18063D550")]
		private void RpcWriter___Observers_ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x63F630", Offset = "0x63E830", VA = "0x18063F630")]
		private void RpcLogic___ReceiveNPCField_1687693739(int fieldIndex, NetworkObject npcObject)
		{
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x640400", Offset = "0x63F600", VA = "0x180640400")]
		private void RpcReader___Observers_ReceiveNPCField_1687693739(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x641B80", Offset = "0x640D80", VA = "0x180641B80")]
		private void RpcWriter___Server_SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x63D850", Offset = "0x63CA50", VA = "0x18063D850")]
		private void RpcLogic___SendObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x640D30", Offset = "0x63FF30", VA = "0x180640D30")]
		private void RpcReader___Server_SendObjectField_1687693739(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x63D850", Offset = "0x63CA50", VA = "0x18063D850")]
		private void RpcWriter___Observers_ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x63F980", Offset = "0x63EB80", VA = "0x18063F980")]
		private void RpcLogic___ReceiveObjectField_1687693739(int fieldIndex, NetworkObject obj)
		{
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x640510", Offset = "0x63F710", VA = "0x180640510")]
		private void RpcReader___Observers_ReceiveObjectField_1687693739(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x641CF0", Offset = "0x640EF0", VA = "0x180641CF0")]
		private void RpcWriter___Server_SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x63D9D0", Offset = "0x63CBD0", VA = "0x18063D9D0")]
		private void RpcLogic___SendObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x640EF0", Offset = "0x6400F0", VA = "0x180640EF0")]
		private void RpcReader___Server_SendObjectListField_690244341(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x63D9D0", Offset = "0x63CBD0", VA = "0x18063D9D0")]
		private void RpcWriter___Observers_ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x63FB30", Offset = "0x63ED30", VA = "0x18063FB30")]
		private void RpcLogic___ReceiveObjectListField_690244341(int fieldIndex, List<NetworkObject> objects)
		{
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x6405A0", Offset = "0x63F7A0", VA = "0x1806405A0")]
		private void RpcReader___Observers_ReceiveObjectListField_690244341(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x641FD0", Offset = "0x6411D0", VA = "0x180641FD0")]
		private void RpcWriter___Server_SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x63DCC0", Offset = "0x63CEC0", VA = "0x18063DCC0")]
		private void RpcLogic___SendRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x641230", Offset = "0x640430", VA = "0x180641230")]
		private void RpcReader___Server_SendRecipeField_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x63DCC0", Offset = "0x63CEC0", VA = "0x18063DCC0")]
		private void RpcWriter___Observers_ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x63FE80", Offset = "0x63F080", VA = "0x18063FE80")]
		private void RpcLogic___ReceiveRecipeField_1692629761(int fieldIndex, int recipeIndex)
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x6406A0", Offset = "0x63F8A0", VA = "0x1806406A0")]
		private void RpcReader___Observers_ReceiveRecipeField_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x641A10", Offset = "0x640C10", VA = "0x180641A10")]
		private void RpcWriter___Server_SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x63D6D0", Offset = "0x63C8D0", VA = "0x18063D6D0")]
		private void RpcLogic___SendNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x640B90", Offset = "0x63FD90", VA = "0x180640B90")]
		private void RpcReader___Server_SendNumberField_1293284375(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x63D6D0", Offset = "0x63C8D0", VA = "0x18063D6D0")]
		private void RpcWriter___Observers_ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x63F7E0", Offset = "0x63E9E0", VA = "0x18063F7E0")]
		private void RpcLogic___ReceiveNumberField_1293284375(int fieldIndex, float value)
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x640490", Offset = "0x63F690", VA = "0x180640490")]
		private void RpcReader___Observers_ReceiveNumberField_1293284375(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x642150", Offset = "0x641350", VA = "0x180642150")]
		private void RpcWriter___Server_SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x63DE40", Offset = "0x63D040", VA = "0x18063DE40")]
		private void RpcLogic___SendRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x6413F0", Offset = "0x6405F0", VA = "0x1806413F0")]
		private void RpcReader___Server_SendRouteListField_3226448297(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x63DE40", Offset = "0x63D040", VA = "0x18063DE40")]
		private void RpcWriter___Observers_ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x640020", Offset = "0x63F220", VA = "0x180640020")]
		private void RpcLogic___ReceiveRouteListField_3226448297(int fieldIndex, AdvancedTransitRouteData[] value)
		{
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x640730", Offset = "0x63F930", VA = "0x180640730")]
		private void RpcReader___Observers_ReceiveRouteListField_3226448297(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x641E60", Offset = "0x641060", VA = "0x180641E60")]
		private void RpcWriter___Server_SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x63DB50", Offset = "0x63CD50", VA = "0x18063DB50")]
		private void RpcLogic___SendQualityField_3536682170(int fieldIndex, EQuality quality)
		{
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x641090", Offset = "0x640290", VA = "0x180641090")]
		private void RpcReader___Server_SendQualityField_3536682170(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x63DB50", Offset = "0x63CD50", VA = "0x18063DB50")]
		private void RpcWriter___Observers_ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x63FCE0", Offset = "0x63EEE0", VA = "0x18063FCE0")]
		private void RpcLogic___ReceiveQualityField_3536682170(int fieldIndex, EQuality value)
		{
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x640620", Offset = "0x63F820", VA = "0x180640620")]
		private void RpcReader___Observers_ReceiveQualityField_3536682170(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x6422C0", Offset = "0x6414C0", VA = "0x1806422C0")]
		private void RpcWriter___Server_SendStringField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDA")]
		[Address(RVA = "0x63DFC0", Offset = "0x63D1C0", VA = "0x18063DFC0")]
		private void RpcLogic___SendStringField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDB")]
		[Address(RVA = "0x641590", Offset = "0x640790", VA = "0x180641590")]
		private void RpcReader___Server_SendStringField_2801973956(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDC")]
		[Address(RVA = "0x63DFC0", Offset = "0x63D1C0", VA = "0x18063DFC0")]
		private void RpcWriter___Observers_ReceiveStringField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDD")]
		[Address(RVA = "0x6401D0", Offset = "0x63F3D0", VA = "0x1806401D0")]
		private void RpcLogic___ReceiveStringField_2801973956(int fieldIndex, string value)
		{
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDE")]
		[Address(RVA = "0x6407B0", Offset = "0x63F9B0", VA = "0x1806407B0")]
		private void RpcReader___Observers_ReceiveStringField_2801973956(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001EDF")]
		[Address(RVA = "0x621F90", Offset = "0x621190", VA = "0x180621F90", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x040019A2 RID: 6562
		[Token(Token = "0x40019A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public EntityConfiguration Configuration;

		// Token: 0x040019A3 RID: 6563
		[Token(Token = "0x40019A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private bool NetworkInitialize___EarlyScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted;

		// Token: 0x040019A4 RID: 6564
		[Token(Token = "0x40019A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x121")]
		private bool NetworkInitialize__LateScheduleOne.Management.ConfigurationReplicatorAssembly-CSharp.dll_Excuted;
	}
}
