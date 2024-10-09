// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ClanRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ClanRewardExcel GetRootAsClanRewardExcel(ByteBuffer _bb) { return GetRootAsClanRewardExcel(_bb, new ClanRewardExcel()); }
  public static ClanRewardExcel GetRootAsClanRewardExcel(ByteBuffer _bb, ClanRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ClanRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.ClanRewardType ClanRewardType { get { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.ClanRewardType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ClanRewardType.None; } }
  public SCHALE.Common.FlatData.EchelonType EchelonType { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.EchelonType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EchelonType.None; } }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RewardParcelAmount { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.ClanRewardExcel> CreateClanRewardExcel(FlatBufferBuilder builder,
      SCHALE.Common.FlatData.ClanRewardType ClanRewardType = SCHALE.Common.FlatData.ClanRewardType.None,
      SCHALE.Common.FlatData.EchelonType EchelonType = SCHALE.Common.FlatData.EchelonType.None,
      SCHALE.Common.FlatData.ParcelType RewardParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long RewardParcelId = 0,
      long RewardParcelAmount = 0) {
    builder.StartTable(5);
    ClanRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmount);
    ClanRewardExcel.AddRewardParcelId(builder, RewardParcelId);
    ClanRewardExcel.AddRewardParcelType(builder, RewardParcelType);
    ClanRewardExcel.AddEchelonType(builder, EchelonType);
    ClanRewardExcel.AddClanRewardType(builder, ClanRewardType);
    return ClanRewardExcel.EndClanRewardExcel(builder);
  }

  public static void StartClanRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddClanRewardType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ClanRewardType clanRewardType) { builder.AddInt(0, (int)clanRewardType, 0); }
  public static void AddEchelonType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EchelonType echelonType) { builder.AddInt(1, (int)echelonType, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType rewardParcelType) { builder.AddInt(2, (int)rewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long rewardParcelId) { builder.AddLong(3, rewardParcelId, 0); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, long rewardParcelAmount) { builder.AddLong(4, rewardParcelAmount, 0); }
  public static Offset<SCHALE.Common.FlatData.ClanRewardExcel> EndClanRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ClanRewardExcel>(o);
  }
  public ClanRewardExcelT UnPack() {
    var _o = new ClanRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ClanRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ClanReward");
    _o.ClanRewardType = TableEncryptionService.Convert(this.ClanRewardType, key);
    _o.EchelonType = TableEncryptionService.Convert(this.EchelonType, key);
    _o.RewardParcelType = TableEncryptionService.Convert(this.RewardParcelType, key);
    _o.RewardParcelId = TableEncryptionService.Convert(this.RewardParcelId, key);
    _o.RewardParcelAmount = TableEncryptionService.Convert(this.RewardParcelAmount, key);
  }
  public static Offset<SCHALE.Common.FlatData.ClanRewardExcel> Pack(FlatBufferBuilder builder, ClanRewardExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ClanRewardExcel>);
    return CreateClanRewardExcel(
      builder,
      _o.ClanRewardType,
      _o.EchelonType,
      _o.RewardParcelType,
      _o.RewardParcelId,
      _o.RewardParcelAmount);
  }
}

public class ClanRewardExcelT
{
  public SCHALE.Common.FlatData.ClanRewardType ClanRewardType { get; set; }
  public SCHALE.Common.FlatData.EchelonType EchelonType { get; set; }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get; set; }
  public long RewardParcelId { get; set; }
  public long RewardParcelAmount { get; set; }

  public ClanRewardExcelT() {
    this.ClanRewardType = SCHALE.Common.FlatData.ClanRewardType.None;
    this.EchelonType = SCHALE.Common.FlatData.EchelonType.None;
    this.RewardParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.RewardParcelId = 0;
    this.RewardParcelAmount = 0;
  }
}


static public class ClanRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ClanRewardType*/, 4 /*SCHALE.Common.FlatData.ClanRewardType*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*EchelonType*/, 4 /*SCHALE.Common.FlatData.EchelonType*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*RewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*RewardParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*RewardParcelAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
