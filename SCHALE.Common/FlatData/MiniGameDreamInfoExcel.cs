// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct MiniGameDreamInfoExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static MiniGameDreamInfoExcel GetRootAsMiniGameDreamInfoExcel(ByteBuffer _bb) { return GetRootAsMiniGameDreamInfoExcel(_bb, new MiniGameDreamInfoExcel()); }
  public static MiniGameDreamInfoExcel GetRootAsMiniGameDreamInfoExcel(ByteBuffer _bb, MiniGameDreamInfoExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public MiniGameDreamInfoExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.DreamMakerMultiplierCondition DreamMakerMultiplierCondition { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.DreamMakerMultiplierCondition)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.DreamMakerMultiplierCondition.None; } }
  public long DreamMakerMultiplierConditionValue { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DreamMakerMultiplierMax { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DreamMakerDays { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DreamMakerActionPoint { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType DreamMakerParcelType { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long DreamMakerParcelId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType DreamMakerDailyPointParcelType { get { int o = __p.__offset(20); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long DreamMakerDailyPointId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long DreamMakerParameterTransfer { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScheduleCostGoodsId { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long LobbyBGMChangeScenarioId { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.MiniGameDreamInfoExcel> CreateMiniGameDreamInfoExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      SCHALE.Common.FlatData.DreamMakerMultiplierCondition DreamMakerMultiplierCondition = SCHALE.Common.FlatData.DreamMakerMultiplierCondition.None,
      long DreamMakerMultiplierConditionValue = 0,
      long DreamMakerMultiplierMax = 0,
      long DreamMakerDays = 0,
      long DreamMakerActionPoint = 0,
      SCHALE.Common.FlatData.ParcelType DreamMakerParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long DreamMakerParcelId = 0,
      SCHALE.Common.FlatData.ParcelType DreamMakerDailyPointParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long DreamMakerDailyPointId = 0,
      long DreamMakerParameterTransfer = 0,
      long ScheduleCostGoodsId = 0,
      long LobbyBGMChangeScenarioId = 0) {
    builder.StartTable(13);
    MiniGameDreamInfoExcel.AddLobbyBGMChangeScenarioId(builder, LobbyBGMChangeScenarioId);
    MiniGameDreamInfoExcel.AddScheduleCostGoodsId(builder, ScheduleCostGoodsId);
    MiniGameDreamInfoExcel.AddDreamMakerParameterTransfer(builder, DreamMakerParameterTransfer);
    MiniGameDreamInfoExcel.AddDreamMakerDailyPointId(builder, DreamMakerDailyPointId);
    MiniGameDreamInfoExcel.AddDreamMakerParcelId(builder, DreamMakerParcelId);
    MiniGameDreamInfoExcel.AddDreamMakerActionPoint(builder, DreamMakerActionPoint);
    MiniGameDreamInfoExcel.AddDreamMakerDays(builder, DreamMakerDays);
    MiniGameDreamInfoExcel.AddDreamMakerMultiplierMax(builder, DreamMakerMultiplierMax);
    MiniGameDreamInfoExcel.AddDreamMakerMultiplierConditionValue(builder, DreamMakerMultiplierConditionValue);
    MiniGameDreamInfoExcel.AddEventContentId(builder, EventContentId);
    MiniGameDreamInfoExcel.AddDreamMakerDailyPointParcelType(builder, DreamMakerDailyPointParcelType);
    MiniGameDreamInfoExcel.AddDreamMakerParcelType(builder, DreamMakerParcelType);
    MiniGameDreamInfoExcel.AddDreamMakerMultiplierCondition(builder, DreamMakerMultiplierCondition);
    return MiniGameDreamInfoExcel.EndMiniGameDreamInfoExcel(builder);
  }

  public static void StartMiniGameDreamInfoExcel(FlatBufferBuilder builder) { builder.StartTable(13); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddDreamMakerMultiplierCondition(FlatBufferBuilder builder, SCHALE.Common.FlatData.DreamMakerMultiplierCondition dreamMakerMultiplierCondition) { builder.AddInt(1, (int)dreamMakerMultiplierCondition, 0); }
  public static void AddDreamMakerMultiplierConditionValue(FlatBufferBuilder builder, long dreamMakerMultiplierConditionValue) { builder.AddLong(2, dreamMakerMultiplierConditionValue, 0); }
  public static void AddDreamMakerMultiplierMax(FlatBufferBuilder builder, long dreamMakerMultiplierMax) { builder.AddLong(3, dreamMakerMultiplierMax, 0); }
  public static void AddDreamMakerDays(FlatBufferBuilder builder, long dreamMakerDays) { builder.AddLong(4, dreamMakerDays, 0); }
  public static void AddDreamMakerActionPoint(FlatBufferBuilder builder, long dreamMakerActionPoint) { builder.AddLong(5, dreamMakerActionPoint, 0); }
  public static void AddDreamMakerParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType dreamMakerParcelType) { builder.AddInt(6, (int)dreamMakerParcelType, 0); }
  public static void AddDreamMakerParcelId(FlatBufferBuilder builder, long dreamMakerParcelId) { builder.AddLong(7, dreamMakerParcelId, 0); }
  public static void AddDreamMakerDailyPointParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType dreamMakerDailyPointParcelType) { builder.AddInt(8, (int)dreamMakerDailyPointParcelType, 0); }
  public static void AddDreamMakerDailyPointId(FlatBufferBuilder builder, long dreamMakerDailyPointId) { builder.AddLong(9, dreamMakerDailyPointId, 0); }
  public static void AddDreamMakerParameterTransfer(FlatBufferBuilder builder, long dreamMakerParameterTransfer) { builder.AddLong(10, dreamMakerParameterTransfer, 0); }
  public static void AddScheduleCostGoodsId(FlatBufferBuilder builder, long scheduleCostGoodsId) { builder.AddLong(11, scheduleCostGoodsId, 0); }
  public static void AddLobbyBGMChangeScenarioId(FlatBufferBuilder builder, long lobbyBGMChangeScenarioId) { builder.AddLong(12, lobbyBGMChangeScenarioId, 0); }
  public static Offset<SCHALE.Common.FlatData.MiniGameDreamInfoExcel> EndMiniGameDreamInfoExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.MiniGameDreamInfoExcel>(o);
  }
  public MiniGameDreamInfoExcelT UnPack() {
    var _o = new MiniGameDreamInfoExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(MiniGameDreamInfoExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("MiniGameDreamInfo");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.DreamMakerMultiplierCondition = TableEncryptionService.Convert(this.DreamMakerMultiplierCondition, key);
    _o.DreamMakerMultiplierConditionValue = TableEncryptionService.Convert(this.DreamMakerMultiplierConditionValue, key);
    _o.DreamMakerMultiplierMax = TableEncryptionService.Convert(this.DreamMakerMultiplierMax, key);
    _o.DreamMakerDays = TableEncryptionService.Convert(this.DreamMakerDays, key);
    _o.DreamMakerActionPoint = TableEncryptionService.Convert(this.DreamMakerActionPoint, key);
    _o.DreamMakerParcelType = TableEncryptionService.Convert(this.DreamMakerParcelType, key);
    _o.DreamMakerParcelId = TableEncryptionService.Convert(this.DreamMakerParcelId, key);
    _o.DreamMakerDailyPointParcelType = TableEncryptionService.Convert(this.DreamMakerDailyPointParcelType, key);
    _o.DreamMakerDailyPointId = TableEncryptionService.Convert(this.DreamMakerDailyPointId, key);
    _o.DreamMakerParameterTransfer = TableEncryptionService.Convert(this.DreamMakerParameterTransfer, key);
    _o.ScheduleCostGoodsId = TableEncryptionService.Convert(this.ScheduleCostGoodsId, key);
    _o.LobbyBGMChangeScenarioId = TableEncryptionService.Convert(this.LobbyBGMChangeScenarioId, key);
  }
  public static Offset<SCHALE.Common.FlatData.MiniGameDreamInfoExcel> Pack(FlatBufferBuilder builder, MiniGameDreamInfoExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.MiniGameDreamInfoExcel>);
    return CreateMiniGameDreamInfoExcel(
      builder,
      _o.EventContentId,
      _o.DreamMakerMultiplierCondition,
      _o.DreamMakerMultiplierConditionValue,
      _o.DreamMakerMultiplierMax,
      _o.DreamMakerDays,
      _o.DreamMakerActionPoint,
      _o.DreamMakerParcelType,
      _o.DreamMakerParcelId,
      _o.DreamMakerDailyPointParcelType,
      _o.DreamMakerDailyPointId,
      _o.DreamMakerParameterTransfer,
      _o.ScheduleCostGoodsId,
      _o.LobbyBGMChangeScenarioId);
  }
}

public class MiniGameDreamInfoExcelT
{
  public long EventContentId { get; set; }
  public SCHALE.Common.FlatData.DreamMakerMultiplierCondition DreamMakerMultiplierCondition { get; set; }
  public long DreamMakerMultiplierConditionValue { get; set; }
  public long DreamMakerMultiplierMax { get; set; }
  public long DreamMakerDays { get; set; }
  public long DreamMakerActionPoint { get; set; }
  public SCHALE.Common.FlatData.ParcelType DreamMakerParcelType { get; set; }
  public long DreamMakerParcelId { get; set; }
  public SCHALE.Common.FlatData.ParcelType DreamMakerDailyPointParcelType { get; set; }
  public long DreamMakerDailyPointId { get; set; }
  public long DreamMakerParameterTransfer { get; set; }
  public long ScheduleCostGoodsId { get; set; }
  public long LobbyBGMChangeScenarioId { get; set; }

  public MiniGameDreamInfoExcelT() {
    this.EventContentId = 0;
    this.DreamMakerMultiplierCondition = SCHALE.Common.FlatData.DreamMakerMultiplierCondition.None;
    this.DreamMakerMultiplierConditionValue = 0;
    this.DreamMakerMultiplierMax = 0;
    this.DreamMakerDays = 0;
    this.DreamMakerActionPoint = 0;
    this.DreamMakerParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.DreamMakerParcelId = 0;
    this.DreamMakerDailyPointParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.DreamMakerDailyPointId = 0;
    this.DreamMakerParameterTransfer = 0;
    this.ScheduleCostGoodsId = 0;
    this.LobbyBGMChangeScenarioId = 0;
  }
}


static public class MiniGameDreamInfoExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*DreamMakerMultiplierCondition*/, 4 /*SCHALE.Common.FlatData.DreamMakerMultiplierCondition*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*DreamMakerMultiplierConditionValue*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*DreamMakerMultiplierMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*DreamMakerDays*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 14 /*DreamMakerActionPoint*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 16 /*DreamMakerParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*DreamMakerParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*DreamMakerDailyPointParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*DreamMakerDailyPointId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*DreamMakerParameterTransfer*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 26 /*ScheduleCostGoodsId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*LobbyBGMChangeScenarioId*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
