#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Void Animancer.FSM.DelegateState`1::.ctor(System.Func`2<TState,System.Boolean>,System.Func`2<TState,System.Boolean>,System.Action,System.Action)
// 0x00000002 System.Boolean Animancer.FSM.DelegateState`1::Animancer.FSM.IState<TState>.CanEnterState(TState)
// 0x00000003 System.Boolean Animancer.FSM.DelegateState`1::Animancer.FSM.IState<TState>.CanExitState(TState)
// 0x00000004 System.Void Animancer.FSM.DelegateState`1::Animancer.FSM.IState<TState>.OnEnterState()
// 0x00000005 System.Void Animancer.FSM.DelegateState`1::Animancer.FSM.IState<TState>.OnExitState()
// 0x00000006 TState Animancer.FSM.StateMachine`1::get_CurrentState()
// 0x00000007 System.Void Animancer.FSM.StateMachine`1::set_CurrentState(TState)
// 0x00000008 System.Void Animancer.FSM.StateMachine`1::.ctor()
// 0x00000009 System.Void Animancer.FSM.StateMachine`1::.ctor(TState)
// 0x0000000A System.Boolean Animancer.FSM.StateMachine`1::CanSetState(TState)
// 0x0000000B System.Boolean Animancer.FSM.StateMachine`1::TrySetState(TState)
// 0x0000000C System.Boolean Animancer.FSM.StateMachine`1::TryResetState(TState)
// 0x0000000D System.Void Animancer.FSM.StateMachine`1::ForceSetState(TState)
// 0x0000000E System.String Animancer.FSM.StateMachine`1::ToString()
// 0x0000000F Animancer.FSM.StateMachine`1<TState> Animancer.FSM.StateMachine`1/InputBuffer::get_StateMachine()
// 0x00000010 System.Void Animancer.FSM.StateMachine`1/InputBuffer::set_StateMachine(Animancer.FSM.StateMachine`1<TState>)
// 0x00000011 TState Animancer.FSM.StateMachine`1/InputBuffer::get_BufferedState()
// 0x00000012 System.Void Animancer.FSM.StateMachine`1/InputBuffer::set_BufferedState(TState)
// 0x00000013 System.Single Animancer.FSM.StateMachine`1/InputBuffer::get_TimeOut()
// 0x00000014 System.Void Animancer.FSM.StateMachine`1/InputBuffer::set_TimeOut(System.Single)
// 0x00000015 System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::get_UseUnscaledTime()
// 0x00000016 System.Void Animancer.FSM.StateMachine`1/InputBuffer::set_UseUnscaledTime(System.Boolean)
// 0x00000017 System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::get_IsBufferActive()
// 0x00000018 System.Void Animancer.FSM.StateMachine`1/InputBuffer::.ctor(Animancer.FSM.StateMachine`1<TState>)
// 0x00000019 System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::TrySetState(TState,System.Single)
// 0x0000001A System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::TryEnterBufferedState()
// 0x0000001B System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::Update()
// 0x0000001C System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::Update(System.Single)
// 0x0000001D System.Boolean Animancer.FSM.StateMachine`1/InputBuffer::CheckBuffer()
// 0x0000001E System.Void Animancer.FSM.StateMachine`1/InputBuffer::Clear()
// 0x0000001F System.Collections.Generic.IDictionary`2<TKey,TState> Animancer.FSM.StateMachine`2::get_Dictionary()
// 0x00000020 System.Void Animancer.FSM.StateMachine`2::set_Dictionary(System.Collections.Generic.IDictionary`2<TKey,TState>)
// 0x00000021 TKey Animancer.FSM.StateMachine`2::get_CurrentKey()
// 0x00000022 System.Void Animancer.FSM.StateMachine`2::set_CurrentKey(TKey)
// 0x00000023 System.Void Animancer.FSM.StateMachine`2::.ctor()
// 0x00000024 System.Void Animancer.FSM.StateMachine`2::.ctor(System.Collections.Generic.IDictionary`2<TKey,TState>)
// 0x00000025 System.Void Animancer.FSM.StateMachine`2::.ctor(TKey,TState)
// 0x00000026 System.Void Animancer.FSM.StateMachine`2::.ctor(System.Collections.Generic.IDictionary`2<TKey,TState>,TKey,TState)
// 0x00000027 System.Boolean Animancer.FSM.StateMachine`2::TrySetState(TKey,TState)
// 0x00000028 TState Animancer.FSM.StateMachine`2::TrySetState(TKey)
// 0x00000029 System.Boolean Animancer.FSM.StateMachine`2::TryResetState(TKey,TState)
// 0x0000002A TState Animancer.FSM.StateMachine`2::TryResetState(TKey)
// 0x0000002B System.Void Animancer.FSM.StateMachine`2::ForceSetState(TKey,TState)
// 0x0000002C TState Animancer.FSM.StateMachine`2::ForceSetState(TKey)
// 0x0000002D TState Animancer.FSM.StateMachine`2::get_Item(TKey)
// 0x0000002E System.Void Animancer.FSM.StateMachine`2::set_Item(TKey,TState)
// 0x0000002F System.Collections.Generic.ICollection`1<TKey> Animancer.FSM.StateMachine`2::get_Keys()
// 0x00000030 System.Collections.Generic.ICollection`1<TState> Animancer.FSM.StateMachine`2::get_Values()
// 0x00000031 System.Int32 Animancer.FSM.StateMachine`2::get_Count()
// 0x00000032 System.Boolean Animancer.FSM.StateMachine`2::get_IsReadOnly()
// 0x00000033 System.Void Animancer.FSM.StateMachine`2::Add(TKey,TState)
// 0x00000034 System.Boolean Animancer.FSM.StateMachine`2::Remove(TKey)
// 0x00000035 System.Void Animancer.FSM.StateMachine`2::Clear()
// 0x00000036 System.Boolean Animancer.FSM.StateMachine`2::ContainsKey(TKey)
// 0x00000037 System.Boolean Animancer.FSM.StateMachine`2::TryGetValue(TKey,TState&)
// 0x00000038 System.Void Animancer.FSM.StateMachine`2::Add(System.Collections.Generic.KeyValuePair`2<TKey,TState>)
// 0x00000039 System.Boolean Animancer.FSM.StateMachine`2::Remove(System.Collections.Generic.KeyValuePair`2<TKey,TState>)
// 0x0000003A System.Boolean Animancer.FSM.StateMachine`2::Contains(System.Collections.Generic.KeyValuePair`2<TKey,TState>)
// 0x0000003B System.Collections.Generic.IEnumerator`1<System.Collections.Generic.KeyValuePair`2<TKey,TState>> Animancer.FSM.StateMachine`2::GetEnumerator()
// 0x0000003C System.Collections.IEnumerator Animancer.FSM.StateMachine`2::System.Collections.IEnumerable.GetEnumerator()
// 0x0000003D System.Void Animancer.FSM.StateMachine`2::CopyTo(System.Collections.Generic.KeyValuePair`2<TKey,TState>[],System.Int32)
// 0x0000003E TState Animancer.FSM.StateMachine`2::GetState(TKey)
// 0x0000003F System.Void Animancer.FSM.StateMachine`2::AddRange(TKey[],TState[])
// 0x00000040 System.Void Animancer.FSM.StateMachine`2::SetFakeKey(TKey)
// 0x00000041 System.String Animancer.FSM.StateMachine`2::ToString()
// 0x00000042 Animancer.FSM.StateMachine`2<TKey,TState> Animancer.FSM.StateMachine`2/InputBuffer::get_StateMachine()
// 0x00000043 System.Void Animancer.FSM.StateMachine`2/InputBuffer::set_StateMachine(Animancer.FSM.StateMachine`2<TKey,TState>)
// 0x00000044 TKey Animancer.FSM.StateMachine`2/InputBuffer::get_BufferedKey()
// 0x00000045 System.Void Animancer.FSM.StateMachine`2/InputBuffer::set_BufferedKey(TKey)
// 0x00000046 System.Void Animancer.FSM.StateMachine`2/InputBuffer::.ctor(Animancer.FSM.StateMachine`2<TKey,TState>)
// 0x00000047 System.Boolean Animancer.FSM.StateMachine`2/InputBuffer::TrySetState(TKey,TState,System.Single)
// 0x00000048 System.Boolean Animancer.FSM.StateMachine`2/InputBuffer::TrySetState(TKey,System.Single)
// 0x00000049 System.Boolean Animancer.FSM.StateMachine`2/InputBuffer::TryEnterBufferedState()
// 0x0000004A System.Boolean Animancer.FSM.IState`1::CanEnterState(TState)
// 0x0000004B System.Boolean Animancer.FSM.IState`1::CanExitState(TState)
// 0x0000004C System.Void Animancer.FSM.IState`1::OnEnterState()
// 0x0000004D System.Void Animancer.FSM.IState`1::OnExitState()
// 0x0000004E Animancer.FSM.StateMachine`1<TState> Animancer.FSM.IOwnedState`1::get_OwnerStateMachine()
// 0x0000004F System.Boolean Animancer.FSM.StateExtensions::IsCurrentState(TState)
// 0x00000050 System.Boolean Animancer.FSM.StateExtensions::CanEnterState(TState)
// 0x00000051 System.Boolean Animancer.FSM.StateExtensions::TryEnterState(TState)
// 0x00000052 System.Boolean Animancer.FSM.StateExtensions::TryReEnterState(TState)
// 0x00000053 System.Void Animancer.FSM.StateExtensions::ForceEnterState(TState)
// 0x00000054 System.Boolean Animancer.FSM.StateBehaviour`1::CanEnterState(TState)
// 0x00000055 System.Boolean Animancer.FSM.StateBehaviour`1::CanExitState(TState)
// 0x00000056 System.Void Animancer.FSM.StateBehaviour`1::OnEnterState()
// 0x00000057 System.Void Animancer.FSM.StateBehaviour`1::OnExitState()
// 0x00000058 System.Void Animancer.FSM.StateBehaviour`1::.ctor()
static Il2CppMethodPointer s_methodPointers[88] = 
{
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[88] = 
{
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
	0,
};
static const Il2CppTokenRangePair s_rgctxIndices[10] = 
{
	{ 0x02000002, { 0, 2 } },
	{ 0x02000003, { 2, 11 } },
	{ 0x02000004, { 13, 15 } },
	{ 0x02000005, { 28, 37 } },
	{ 0x02000006, { 65, 12 } },
	{ 0x0600004F, { 77, 5 } },
	{ 0x06000050, { 82, 5 } },
	{ 0x06000051, { 87, 5 } },
	{ 0x06000052, { 92, 5 } },
	{ 0x06000053, { 97, 5 } },
};
extern const uint32_t g_rgctx_Func_2_tC47207CB7E89A3AF719EFBEFC1CD3F9D21313B81;
extern const uint32_t g_rgctx_Func_2_Invoke_mBA1D745FDBB9276B372B3FE8E8E3A18D23B375EA;
extern const uint32_t g_rgctx_StateMachine_1_set_CurrentState_m287A2156AF51015F182EE51EC85A5C92C5BB285E;
extern const uint32_t g_rgctx_TState_t149EFCD0C71EBC1C9CCADF8E66318EB467DE80A2;
extern const uint32_t g_rgctx_IState_1_tC936A3EF29A3845B8E80F00EDE6BFBA1E2F24630;
extern const uint32_t g_rgctx_IState_1_OnEnterState_mA6ABED6E76A84344F6F7549F2E0FCBA8AE243667;
extern const uint32_t g_rgctx_StateMachine_1_get_CurrentState_m25ED950CF444777446C7D360BDC5A5032FA1CF2C;
extern const uint32_t g_rgctx_IState_1_CanExitState_mB26B6AF3CBE4FE8ADF054C3F296AE8680A42770C;
extern const uint32_t g_rgctx_IState_1_CanEnterState_mB7FF9ED1B5B0A3DEDDB8BC9DB51062AE490C1A61;
extern const uint32_t g_rgctx_StateMachine_1_TryResetState_mE9024EAAF04C673C0EC190F050C0B24D7D135FEE;
extern const uint32_t g_rgctx_StateMachine_1_CanSetState_mC6AC4B230240156AD4013A519C6DFD76B3D06A9E;
extern const uint32_t g_rgctx_StateMachine_1_ForceSetState_m9EFC8783386B452E15E9E74C1AE34294051C3024;
extern const uint32_t g_rgctx_IState_1_OnExitState_m708D9B19B3C3559D3624FC85104F03DB72991AED;
extern const uint32_t g_rgctx_InputBuffer_get_BufferedState_m8366A2C4138D4B2158DFB7CED8D550973AFAE15D;
extern const uint32_t g_rgctx_TState_t6346968489EC07B70D1FA1B50FBAD28FEFBA045C;
extern const uint32_t g_rgctx_InputBuffer_set_StateMachine_mD09833D6346CFDAB67E2BF0FEF4AA8DD5C78FD73;
extern const uint32_t g_rgctx_InputBuffer_set_BufferedState_mBE2041F4F86407696E46BE9C1610AB83B0261D17;
extern const uint32_t g_rgctx_InputBuffer_set_TimeOut_m6AA3B6D26538C3388E10C4025ECA292B053D29B6;
extern const uint32_t g_rgctx_InputBuffer_t782B16D9FC18B6139C4F5C80F3BBCFAB057A7DE5;
extern const uint32_t g_rgctx_InputBuffer_TryEnterBufferedState_m2B4FD2AFE2A566453E86ECF493271C9E7351159B;
extern const uint32_t g_rgctx_InputBuffer_Clear_mC0AD281FD11FF55D7952B1747371702D8B9AE95B;
extern const uint32_t g_rgctx_InputBuffer_get_StateMachine_m1CB7A1385C035CCFA43A860E460CCA26C205530A;
extern const uint32_t g_rgctx_StateMachine_1_t0D15819B44913EC7E56EF3CF28165634AA5FDB02;
extern const uint32_t g_rgctx_StateMachine_1_TryResetState_mEECA1F7F1485D4E04E927C98DEF2E2F07C9D207E;
extern const uint32_t g_rgctx_InputBuffer_get_UseUnscaledTime_mDB2EC172E3277B4BC511A864B580F591BBCF78F8;
extern const uint32_t g_rgctx_InputBuffer_Update_m14614128A048E61FF5FA58D43166C875E19A9EF0;
extern const uint32_t g_rgctx_InputBuffer_get_IsBufferActive_m2E66918039ED4523B31A8292FBA250445CC7E988;
extern const uint32_t g_rgctx_InputBuffer_get_TimeOut_m2210B407C7148EBF9DAAB7A77CB1154A32C63D2A;
extern const uint32_t g_rgctx_StateMachine_1__ctor_mE2ADFA0DEDC8432FBE24FF8FFC57ADB8DEA60816;
extern const uint32_t g_rgctx_StateMachine_1_tCE8D6863411C5AB2B1E0A59E49B6A9044AD2D167;
extern const uint32_t g_rgctx_Dictionary_2_tF78B98298C94111F44870DC42B450B8CE35E977D;
extern const uint32_t g_rgctx_Dictionary_2__ctor_m571CEC2D70E7143A360D27215DE150094BE940B1;
extern const uint32_t g_rgctx_StateMachine_2_set_Dictionary_mB3102DA4F9A01F7ACC6ACB3DEAA7EFEF6438DBCD;
extern const uint32_t g_rgctx_StateMachine_2_ForceSetState_mA4BF6F7ABA14808260261389F9381A9946BC88E0;
extern const uint32_t g_rgctx_StateMachine_1_get_CurrentState_m558732E98876812D7C74D6885EE1751D93D0CEB4;
extern const uint32_t g_rgctx_TState_t1879040707404BEAB2D38C74BB98D67381B45F2B;
extern const uint32_t g_rgctx_StateMachine_2_TryResetState_mDF81D100A5BD504038E8BC0675186AD3822CDA5D;
extern const uint32_t g_rgctx_StateMachine_2_get_CurrentKey_m09D5444B7C5DBFB78D6407696BFC14DAAF408FAB;
extern const uint32_t g_rgctx_TKey_t0B9A81442E271F8F2D172966BFBDE6CDAE4F4914;
extern const uint32_t g_rgctx_StateMachine_2_TryResetState_mF06F9117F332BE4AB6436BD3EF1000B75BC114C5;
extern const uint32_t g_rgctx_StateMachine_1_CanSetState_mDDBDE86D8A4B591869847ED7847D5166236E5146;
extern const uint32_t g_rgctx_StateMachine_2_get_Dictionary_m65AB99A7728CFDA1396A334F058B2D3200ACCE6D;
extern const uint32_t g_rgctx_IDictionary_2_tBEBC117C57B3D7946D7905EADAB9E93019EF99BC;
extern const uint32_t g_rgctx_IDictionary_2_TryGetValue_m9939391ED82781F23DBD84BA3E6A4D66CBB3B98D;
extern const uint32_t g_rgctx_StateMachine_2_set_CurrentKey_m3FFC6E35EB7B8D5283968AFBB672EE2BE1335381;
extern const uint32_t g_rgctx_StateMachine_1_ForceSetState_mCF738F08D1258EA367AF89FA9127F9D8F91C260B;
extern const uint32_t g_rgctx_IDictionary_2_get_Item_m126708916DD6A8910189D6F785D808B43D657C51;
extern const uint32_t g_rgctx_IDictionary_2_set_Item_mB82E2143CEF87E04F5A45BC61E56D00EA7CA6CE3;
extern const uint32_t g_rgctx_IDictionary_2_get_Keys_m6B2B2B3B48593122A2B1BF240C33B1649050E592;
extern const uint32_t g_rgctx_IDictionary_2_get_Values_m97303CC9986BCBBE4C70130AC1B21D6288C0DB27;
extern const uint32_t g_rgctx_ICollection_1_tD4CAD80612E27AFF8661D4B4E7C2726A6FB7DE64;
extern const uint32_t g_rgctx_ICollection_1_get_Count_m88FFBF357DC618DD7980700321C02D917406B81D;
extern const uint32_t g_rgctx_ICollection_1_get_IsReadOnly_mEBD9D5D549691F32706089A5D6685B4847ECE956;
extern const uint32_t g_rgctx_IDictionary_2_Add_mC92CEEA80987461390DE12C3A424DE417B65D076;
extern const uint32_t g_rgctx_IDictionary_2_Remove_m0E1E52A3708362D3EC7EE0AB13170ED4624C6772;
extern const uint32_t g_rgctx_ICollection_1_Clear_mF445954B61400588490CFE537C28962C311B6D98;
extern const uint32_t g_rgctx_IDictionary_2_ContainsKey_m28A3549A6D86D498381B5A2C3CE3E733E30E9F66;
extern const uint32_t g_rgctx_ICollection_1_Add_mA90BF949C28AF14534EEC618E9B48B7876F16270;
extern const uint32_t g_rgctx_ICollection_1_Remove_m8F9E0AFFCA0DA6CCF34A1BA8D8C9AF5375C4D01F;
extern const uint32_t g_rgctx_ICollection_1_Contains_mA3ACFE225FDE8252006D872CB28854B347F33825;
extern const uint32_t g_rgctx_IEnumerable_1_t5AC01C6623F85D940BB975403BB3E1E5A59DE6E1;
extern const uint32_t g_rgctx_IEnumerable_1_GetEnumerator_mA577FDF98C8A69F2ED682746E31C061310C69F7A;
extern const uint32_t g_rgctx_ICollection_1_CopyTo_m88CB3978A3A4952F3A9EC4ED47F552860555E19A;
extern const uint32_t g_rgctx_StateMachine_2_TryGetValue_m3FAF5FC15844E2606A0558FABE46487C372F16F0;
extern const Il2CppRGCTXConstrainedData g_rgctx_TKey_t0B9A81442E271F8F2D172966BFBDE6CDAE4F4914_Object_ToString_mF8AC1EB9D85AB52EC8FD8B8BDD131E855E69673F;
extern const uint32_t g_rgctx_InputBuffer_set_StateMachine_m8022AEBCB34BE7321F67A8605429FEB90F9A796F;
extern const uint32_t g_rgctx_InputBuffer__ctor_m57A88DB6A1A553249932BAD2AC5ECCBFB8B44FF6;
extern const uint32_t g_rgctx_InputBuffer_t04CEAA0F326DCEF16BD6F774D35E280A3BB268E4;
extern const uint32_t g_rgctx_StateMachine_2_t6ADB0D5EA7D245182D1AB8D2199B077FC9F290EF;
extern const uint32_t g_rgctx_StateMachine_2_get_CurrentKey_m06F6120FB331216E1693E7D1252027D42EA14E2A;
extern const uint32_t g_rgctx_InputBuffer_set_BufferedKey_mF1EA5E7C57EBEFAD24907A52EDFA85CC0D1E2498;
extern const uint32_t g_rgctx_InputBuffer_TrySetState_m9697BCAE5FDCBD8D8268CE66F8197B62344FC8AB;
extern const uint32_t g_rgctx_StateMachine_2_TryGetValue_mCD995868B3484D4A0210C923FB501DF8C152925E;
extern const uint32_t g_rgctx_InputBuffer_TrySetState_m2CB98D25785392E20E1DBAC93BFFDEE11E534B7D;
extern const uint32_t g_rgctx_InputBuffer_get_BufferedKey_m5715EA399043EB9B3E7523FBF312E56A3EBC851B;
extern const uint32_t g_rgctx_InputBuffer_get_BufferedState_m5E8DC093CCD7EDAC309A38495F31C0DAA9375C70;
extern const uint32_t g_rgctx_StateMachine_2_TrySetState_m3BA459270E807666795E3D5094CEB47578BBC7E0;
extern const uint32_t g_rgctx_TState_tF5AB9D07473D62E5168BDB27253291AAFCCB82F7;
extern const uint32_t g_rgctx_IOwnedState_1_t06DAE06326D93FD36F616AFFDD2A0FE04F4593E1;
extern const uint32_t g_rgctx_IOwnedState_1_get_OwnerStateMachine_mE735C4C26BF52CCF835A689DCCF37048C52E107E;
extern const uint32_t g_rgctx_StateMachine_1_t95FE74FAC7983D06AED2FA7D162F55EAF45FC2E6;
extern const uint32_t g_rgctx_StateMachine_1_get_CurrentState_m524E9FD06BFB578EDFC4B6656407305E09BF73FE;
extern const uint32_t g_rgctx_TState_tC05A07215FFAF5341945B8FEF3CDD249BEC39A1D;
extern const uint32_t g_rgctx_IOwnedState_1_tF2942D733B46ECF2C969AFB579A65E7CF46B8A56;
extern const uint32_t g_rgctx_IOwnedState_1_get_OwnerStateMachine_m0D070549C5FD4154E694D10342C9EAE5C1900388;
extern const uint32_t g_rgctx_StateMachine_1_t8CF78ED90CE4FF4697979FE824B9E77548E961F2;
extern const uint32_t g_rgctx_StateMachine_1_CanSetState_m0A58C1FCE23108B2BC7FC625BA754D6BEED69184;
extern const uint32_t g_rgctx_TState_tC3E909BCB15984E3E02DDDBDB1495169479950D3;
extern const uint32_t g_rgctx_IOwnedState_1_t39E1F52B260B06395FBDF01DE7F2907C4CC2292C;
extern const uint32_t g_rgctx_IOwnedState_1_get_OwnerStateMachine_mB8C657AF3CEE9FFD3103B2ED50E41BC31CBD9FA8;
extern const uint32_t g_rgctx_StateMachine_1_tD79812985B04C47C3D2C5E2DD6E03044DFBCA8C2;
extern const uint32_t g_rgctx_StateMachine_1_TrySetState_mF0E67D59FFEE9E87C29828BDE81147B642A86868;
extern const uint32_t g_rgctx_TState_t386361FBBA270F6A14D71C9F152CA870DD78FD77;
extern const uint32_t g_rgctx_IOwnedState_1_t590FE3AD9E3C5A803D51AEF7F8C8A9E56ED19DEF;
extern const uint32_t g_rgctx_IOwnedState_1_get_OwnerStateMachine_m5F119BEE28C0E7CD8BA1DACF2D0BFFFCAD132DA2;
extern const uint32_t g_rgctx_StateMachine_1_t3354FD16545D85138F3B08FF153BF4991B6C5530;
extern const uint32_t g_rgctx_StateMachine_1_TryResetState_mF3B3507E5B6C00F810AC78B1DFDE50390F80AE76;
extern const uint32_t g_rgctx_TState_t1ACA0078BB5A0FF2DFB23F86B8903DED06EEF718;
extern const uint32_t g_rgctx_IOwnedState_1_t72B68985EF7FB91B795A2A974276070773985A51;
extern const uint32_t g_rgctx_IOwnedState_1_get_OwnerStateMachine_m2CE9EA844A8C8E1660C9F3B0C29015A6966D3449;
extern const uint32_t g_rgctx_StateMachine_1_t0E6C43DE0CB58B845A21E97F06C457EF9CDF93A0;
extern const uint32_t g_rgctx_StateMachine_1_ForceSetState_m848E04ABDB61438BC935560AA82C97B44F4FA1D1;
static const Il2CppRGCTXDefinition s_rgctxValues[102] = 
{
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_Func_2_tC47207CB7E89A3AF719EFBEFC1CD3F9D21313B81 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_Func_2_Invoke_mBA1D745FDBB9276B372B3FE8E8E3A18D23B375EA },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_set_CurrentState_m287A2156AF51015F182EE51EC85A5C92C5BB285E },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_t149EFCD0C71EBC1C9CCADF8E66318EB467DE80A2 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IState_1_tC936A3EF29A3845B8E80F00EDE6BFBA1E2F24630 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IState_1_OnEnterState_mA6ABED6E76A84344F6F7549F2E0FCBA8AE243667 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_get_CurrentState_m25ED950CF444777446C7D360BDC5A5032FA1CF2C },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IState_1_CanExitState_mB26B6AF3CBE4FE8ADF054C3F296AE8680A42770C },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IState_1_CanEnterState_mB7FF9ED1B5B0A3DEDDB8BC9DB51062AE490C1A61 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_TryResetState_mE9024EAAF04C673C0EC190F050C0B24D7D135FEE },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_CanSetState_mC6AC4B230240156AD4013A519C6DFD76B3D06A9E },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_ForceSetState_m9EFC8783386B452E15E9E74C1AE34294051C3024 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IState_1_OnExitState_m708D9B19B3C3559D3624FC85104F03DB72991AED },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_BufferedState_m8366A2C4138D4B2158DFB7CED8D550973AFAE15D },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_t6346968489EC07B70D1FA1B50FBAD28FEFBA045C },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_set_StateMachine_mD09833D6346CFDAB67E2BF0FEF4AA8DD5C78FD73 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_set_BufferedState_mBE2041F4F86407696E46BE9C1610AB83B0261D17 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_set_TimeOut_m6AA3B6D26538C3388E10C4025ECA292B053D29B6 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_InputBuffer_t782B16D9FC18B6139C4F5C80F3BBCFAB057A7DE5 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_TryEnterBufferedState_m2B4FD2AFE2A566453E86ECF493271C9E7351159B },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_Clear_mC0AD281FD11FF55D7952B1747371702D8B9AE95B },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_StateMachine_m1CB7A1385C035CCFA43A860E460CCA26C205530A },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_t0D15819B44913EC7E56EF3CF28165634AA5FDB02 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_TryResetState_mEECA1F7F1485D4E04E927C98DEF2E2F07C9D207E },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_UseUnscaledTime_mDB2EC172E3277B4BC511A864B580F591BBCF78F8 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_Update_m14614128A048E61FF5FA58D43166C875E19A9EF0 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_IsBufferActive_m2E66918039ED4523B31A8292FBA250445CC7E988 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_TimeOut_m2210B407C7148EBF9DAAB7A77CB1154A32C63D2A },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1__ctor_mE2ADFA0DEDC8432FBE24FF8FFC57ADB8DEA60816 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_tCE8D6863411C5AB2B1E0A59E49B6A9044AD2D167 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_Dictionary_2_tF78B98298C94111F44870DC42B450B8CE35E977D },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_Dictionary_2__ctor_m571CEC2D70E7143A360D27215DE150094BE940B1 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_set_Dictionary_mB3102DA4F9A01F7ACC6ACB3DEAA7EFEF6438DBCD },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_ForceSetState_mA4BF6F7ABA14808260261389F9381A9946BC88E0 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_get_CurrentState_m558732E98876812D7C74D6885EE1751D93D0CEB4 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_t1879040707404BEAB2D38C74BB98D67381B45F2B },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_TryResetState_mDF81D100A5BD504038E8BC0675186AD3822CDA5D },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_get_CurrentKey_m09D5444B7C5DBFB78D6407696BFC14DAAF408FAB },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TKey_t0B9A81442E271F8F2D172966BFBDE6CDAE4F4914 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_TryResetState_mF06F9117F332BE4AB6436BD3EF1000B75BC114C5 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_CanSetState_mDDBDE86D8A4B591869847ED7847D5166236E5146 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_get_Dictionary_m65AB99A7728CFDA1396A334F058B2D3200ACCE6D },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IDictionary_2_tBEBC117C57B3D7946D7905EADAB9E93019EF99BC },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_TryGetValue_m9939391ED82781F23DBD84BA3E6A4D66CBB3B98D },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_set_CurrentKey_m3FFC6E35EB7B8D5283968AFBB672EE2BE1335381 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_ForceSetState_mCF738F08D1258EA367AF89FA9127F9D8F91C260B },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_get_Item_m126708916DD6A8910189D6F785D808B43D657C51 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_set_Item_mB82E2143CEF87E04F5A45BC61E56D00EA7CA6CE3 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_get_Keys_m6B2B2B3B48593122A2B1BF240C33B1649050E592 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_get_Values_m97303CC9986BCBBE4C70130AC1B21D6288C0DB27 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_ICollection_1_tD4CAD80612E27AFF8661D4B4E7C2726A6FB7DE64 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_get_Count_m88FFBF357DC618DD7980700321C02D917406B81D },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_get_IsReadOnly_mEBD9D5D549691F32706089A5D6685B4847ECE956 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_Add_mC92CEEA80987461390DE12C3A424DE417B65D076 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_Remove_m0E1E52A3708362D3EC7EE0AB13170ED4624C6772 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_Clear_mF445954B61400588490CFE537C28962C311B6D98 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IDictionary_2_ContainsKey_m28A3549A6D86D498381B5A2C3CE3E733E30E9F66 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_Add_mA90BF949C28AF14534EEC618E9B48B7876F16270 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_Remove_m8F9E0AFFCA0DA6CCF34A1BA8D8C9AF5375C4D01F },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_Contains_mA3ACFE225FDE8252006D872CB28854B347F33825 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IEnumerable_1_t5AC01C6623F85D940BB975403BB3E1E5A59DE6E1 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IEnumerable_1_GetEnumerator_mA577FDF98C8A69F2ED682746E31C061310C69F7A },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_ICollection_1_CopyTo_m88CB3978A3A4952F3A9EC4ED47F552860555E19A },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_TryGetValue_m3FAF5FC15844E2606A0558FABE46487C372F16F0 },
	{ (Il2CppRGCTXDataType)5, (const void *)&g_rgctx_TKey_t0B9A81442E271F8F2D172966BFBDE6CDAE4F4914_Object_ToString_mF8AC1EB9D85AB52EC8FD8B8BDD131E855E69673F },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_set_StateMachine_m8022AEBCB34BE7321F67A8605429FEB90F9A796F },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer__ctor_m57A88DB6A1A553249932BAD2AC5ECCBFB8B44FF6 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_InputBuffer_t04CEAA0F326DCEF16BD6F774D35E280A3BB268E4 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_2_t6ADB0D5EA7D245182D1AB8D2199B077FC9F290EF },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_get_CurrentKey_m06F6120FB331216E1693E7D1252027D42EA14E2A },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_set_BufferedKey_mF1EA5E7C57EBEFAD24907A52EDFA85CC0D1E2498 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_TrySetState_m9697BCAE5FDCBD8D8268CE66F8197B62344FC8AB },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_TryGetValue_mCD995868B3484D4A0210C923FB501DF8C152925E },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_TrySetState_m2CB98D25785392E20E1DBAC93BFFDEE11E534B7D },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_BufferedKey_m5715EA399043EB9B3E7523FBF312E56A3EBC851B },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_InputBuffer_get_BufferedState_m5E8DC093CCD7EDAC309A38495F31C0DAA9375C70 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_2_TrySetState_m3BA459270E807666795E3D5094CEB47578BBC7E0 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_tF5AB9D07473D62E5168BDB27253291AAFCCB82F7 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IOwnedState_1_t06DAE06326D93FD36F616AFFDD2A0FE04F4593E1 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IOwnedState_1_get_OwnerStateMachine_mE735C4C26BF52CCF835A689DCCF37048C52E107E },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_t95FE74FAC7983D06AED2FA7D162F55EAF45FC2E6 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_get_CurrentState_m524E9FD06BFB578EDFC4B6656407305E09BF73FE },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_tC05A07215FFAF5341945B8FEF3CDD249BEC39A1D },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IOwnedState_1_tF2942D733B46ECF2C969AFB579A65E7CF46B8A56 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IOwnedState_1_get_OwnerStateMachine_m0D070549C5FD4154E694D10342C9EAE5C1900388 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_t8CF78ED90CE4FF4697979FE824B9E77548E961F2 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_CanSetState_m0A58C1FCE23108B2BC7FC625BA754D6BEED69184 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_tC3E909BCB15984E3E02DDDBDB1495169479950D3 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IOwnedState_1_t39E1F52B260B06395FBDF01DE7F2907C4CC2292C },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IOwnedState_1_get_OwnerStateMachine_mB8C657AF3CEE9FFD3103B2ED50E41BC31CBD9FA8 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_tD79812985B04C47C3D2C5E2DD6E03044DFBCA8C2 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_TrySetState_mF0E67D59FFEE9E87C29828BDE81147B642A86868 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_t386361FBBA270F6A14D71C9F152CA870DD78FD77 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IOwnedState_1_t590FE3AD9E3C5A803D51AEF7F8C8A9E56ED19DEF },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IOwnedState_1_get_OwnerStateMachine_m5F119BEE28C0E7CD8BA1DACF2D0BFFFCAD132DA2 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_t3354FD16545D85138F3B08FF153BF4991B6C5530 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_TryResetState_mF3B3507E5B6C00F810AC78B1DFDE50390F80AE76 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_TState_t1ACA0078BB5A0FF2DFB23F86B8903DED06EEF718 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_IOwnedState_1_t72B68985EF7FB91B795A2A974276070773985A51 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_IOwnedState_1_get_OwnerStateMachine_m2CE9EA844A8C8E1660C9F3B0C29015A6966D3449 },
	{ (Il2CppRGCTXDataType)2, (const void *)&g_rgctx_StateMachine_1_t0E6C43DE0CB58B845A21E97F06C457EF9CDF93A0 },
	{ (Il2CppRGCTXDataType)3, (const void *)&g_rgctx_StateMachine_1_ForceSetState_m848E04ABDB61438BC935560AA82C97B44F4FA1D1 },
};
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_Animancer_FSM_CodeGenModule;
const Il2CppCodeGenModule g_Animancer_FSM_CodeGenModule = 
{
	"Animancer.FSM.dll",
	88,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	10,
	s_rgctxIndices,
	102,
	s_rgctxValues,
	NULL,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
