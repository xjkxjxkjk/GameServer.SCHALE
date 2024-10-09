// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct EventContentTreasureExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentTreasureExcel GetRootAsEventContentTreasureExcel(ByteBuffer _bb) { return GetRootAsEventContentTreasureExcel(_bb, new EventContentTreasureExcel()); }
  public static EventContentTreasureExcel GetRootAsEventContentTreasureExcel(ByteBuffer _bb, EventContentTreasureExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentTreasureExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long EventContentId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string TitleLocalize { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTitleLocalizeBytes() { return __p.__vector_as_span<byte>(6, 1); }
#else
  public ArraySegment<byte>? GetTitleLocalizeBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetTitleLocalizeArray() { return __p.__vector_as_array<byte>(6); }
  public int LoopRound { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string UsePrefabName { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetUsePrefabNameBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetUsePrefabNameBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetUsePrefabNameArray() { return __p.__vector_as_array<byte>(10); }
  public string TreasureBGImagePath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetTreasureBGImagePathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetTreasureBGImagePathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetTreasureBGImagePathArray() { return __p.__vector_as_array<byte>(12); }

  public static Offset<SCHALE.Common.FlatData.EventContentTreasureExcel> CreateEventContentTreasureExcel(FlatBufferBuilder builder,
      long EventContentId = 0,
      StringOffset TitleLocalizeOffset = default(StringOffset),
      int LoopRound = 0,
      StringOffset UsePrefabNameOffset = default(StringOffset),
      StringOffset TreasureBGImagePathOffset = default(StringOffset)) {
    builder.StartTable(5);
    EventContentTreasureExcel.AddEventContentId(builder, EventContentId);
    EventContentTreasureExcel.AddTreasureBGImagePath(builder, TreasureBGImagePathOffset);
    EventContentTreasureExcel.AddUsePrefabName(builder, UsePrefabNameOffset);
    EventContentTreasureExcel.AddLoopRound(builder, LoopRound);
    EventContentTreasureExcel.AddTitleLocalize(builder, TitleLocalizeOffset);
    return EventContentTreasureExcel.EndEventContentTreasureExcel(builder);
  }

  public static void StartEventContentTreasureExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(0, eventContentId, 0); }
  public static void AddTitleLocalize(FlatBufferBuilder builder, StringOffset titleLocalizeOffset) { builder.AddOffset(1, titleLocalizeOffset.Value, 0); }
  public static void AddLoopRound(FlatBufferBuilder builder, int loopRound) { builder.AddInt(2, loopRound, 0); }
  public static void AddUsePrefabName(FlatBufferBuilder builder, StringOffset usePrefabNameOffset) { builder.AddOffset(3, usePrefabNameOffset.Value, 0); }
  public static void AddTreasureBGImagePath(FlatBufferBuilder builder, StringOffset treasureBGImagePathOffset) { builder.AddOffset(4, treasureBGImagePathOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.EventContentTreasureExcel> EndEventContentTreasureExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentTreasureExcel>(o);
  }
  public EventContentTreasureExcelT UnPack() {
    var _o = new EventContentTreasureExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentTreasureExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentTreasure");
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.TitleLocalize = TableEncryptionService.Convert(this.TitleLocalize, key);
    _o.LoopRound = TableEncryptionService.Convert(this.LoopRound, key);
    _o.UsePrefabName = TableEncryptionService.Convert(this.UsePrefabName, key);
    _o.TreasureBGImagePath = TableEncryptionService.Convert(this.TreasureBGImagePath, key);
  }
  public static Offset<SCHALE.Common.FlatData.EventContentTreasureExcel> Pack(FlatBufferBuilder builder, EventContentTreasureExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.EventContentTreasureExcel>);
    var _TitleLocalize = _o.TitleLocalize == null ? default(StringOffset) : builder.CreateString(_o.TitleLocalize);
    var _UsePrefabName = _o.UsePrefabName == null ? default(StringOffset) : builder.CreateString(_o.UsePrefabName);
    var _TreasureBGImagePath = _o.TreasureBGImagePath == null ? default(StringOffset) : builder.CreateString(_o.TreasureBGImagePath);
    return CreateEventContentTreasureExcel(
      builder,
      _o.EventContentId,
      _TitleLocalize,
      _o.LoopRound,
      _UsePrefabName,
      _TreasureBGImagePath);
  }
}

public class EventContentTreasureExcelT
{
  public long EventContentId { get; set; }
  public string TitleLocalize { get; set; }
  public int LoopRound { get; set; }
  public string UsePrefabName { get; set; }
  public string TreasureBGImagePath { get; set; }

  public EventContentTreasureExcelT() {
    this.EventContentId = 0;
    this.TitleLocalize = null;
    this.LoopRound = 0;
    this.UsePrefabName = null;
    this.TreasureBGImagePath = null;
  }
}


static public class EventContentTreasureExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 6 /*TitleLocalize*/, false)
      && verifier.VerifyField(tablePos, 8 /*LoopRound*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 10 /*UsePrefabName*/, false)
      && verifier.VerifyString(tablePos, 12 /*TreasureBGImagePath*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
