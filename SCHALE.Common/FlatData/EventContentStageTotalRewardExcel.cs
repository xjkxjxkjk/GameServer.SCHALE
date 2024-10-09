// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct EventContentStageTotalRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static EventContentStageTotalRewardExcel GetRootAsEventContentStageTotalRewardExcel(ByteBuffer _bb) { return GetRootAsEventContentStageTotalRewardExcel(_bb, new EventContentStageTotalRewardExcel()); }
  public static EventContentStageTotalRewardExcel GetRootAsEventContentStageTotalRewardExcel(ByteBuffer _bb, EventContentStageTotalRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public EventContentStageTotalRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EventContentId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RequiredEventItemAmount { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType(int j) { int o = __p.__offset(10); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int RewardParcelTypeLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetRewardParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(10, 4); }
#else
  public ArraySegment<byte>? GetRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetRewardParcelTypeArray() { int o = __p.__offset(10); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long RewardParcelId(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelIdLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelIdBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelIdBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetRewardParcelIdArray() { return __p.__vector_as_array<long>(12); }
  public long RewardParcelAmount(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RewardParcelAmountLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRewardParcelAmountBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRewardParcelAmountBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRewardParcelAmountArray() { return __p.__vector_as_array<long>(14); }

  public static Offset<SCHALE.Common.FlatData.EventContentStageTotalRewardExcel> CreateEventContentStageTotalRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      long EventContentId = 0,
      long RequiredEventItemAmount = 0,
      VectorOffset RewardParcelTypeOffset = default(VectorOffset),
      VectorOffset RewardParcelIdOffset = default(VectorOffset),
      VectorOffset RewardParcelAmountOffset = default(VectorOffset)) {
    builder.StartTable(6);
    EventContentStageTotalRewardExcel.AddRequiredEventItemAmount(builder, RequiredEventItemAmount);
    EventContentStageTotalRewardExcel.AddEventContentId(builder, EventContentId);
    EventContentStageTotalRewardExcel.AddId(builder, Id);
    EventContentStageTotalRewardExcel.AddRewardParcelAmount(builder, RewardParcelAmountOffset);
    EventContentStageTotalRewardExcel.AddRewardParcelId(builder, RewardParcelIdOffset);
    EventContentStageTotalRewardExcel.AddRewardParcelType(builder, RewardParcelTypeOffset);
    return EventContentStageTotalRewardExcel.EndEventContentStageTotalRewardExcel(builder);
  }

  public static void StartEventContentStageTotalRewardExcel(FlatBufferBuilder builder) { builder.StartTable(6); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddEventContentId(FlatBufferBuilder builder, long eventContentId) { builder.AddLong(1, eventContentId, 0); }
  public static void AddRequiredEventItemAmount(FlatBufferBuilder builder, long requiredEventItemAmount) { builder.AddLong(2, requiredEventItemAmount, 0); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, VectorOffset rewardParcelTypeOffset) { builder.AddOffset(3, rewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, VectorOffset rewardParcelIdOffset) { builder.AddOffset(4, rewardParcelIdOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelAmount(FlatBufferBuilder builder, VectorOffset rewardParcelAmountOffset) { builder.AddOffset(5, rewardParcelAmountOffset.Value, 0); }
  public static VectorOffset CreateRewardParcelAmountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRewardParcelAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRewardParcelAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static Offset<SCHALE.Common.FlatData.EventContentStageTotalRewardExcel> EndEventContentStageTotalRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.EventContentStageTotalRewardExcel>(o);
  }
  public EventContentStageTotalRewardExcelT UnPack() {
    var _o = new EventContentStageTotalRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(EventContentStageTotalRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("EventContentStageTotalReward");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.EventContentId = TableEncryptionService.Convert(this.EventContentId, key);
    _o.RequiredEventItemAmount = TableEncryptionService.Convert(this.RequiredEventItemAmount, key);
    _o.RewardParcelType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.RewardParcelTypeLength; ++_j) {_o.RewardParcelType.Add(TableEncryptionService.Convert(this.RewardParcelType(_j), key));}
    _o.RewardParcelId = new List<long>();
    for (var _j = 0; _j < this.RewardParcelIdLength; ++_j) {_o.RewardParcelId.Add(TableEncryptionService.Convert(this.RewardParcelId(_j), key));}
    _o.RewardParcelAmount = new List<long>();
    for (var _j = 0; _j < this.RewardParcelAmountLength; ++_j) {_o.RewardParcelAmount.Add(TableEncryptionService.Convert(this.RewardParcelAmount(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.EventContentStageTotalRewardExcel> Pack(FlatBufferBuilder builder, EventContentStageTotalRewardExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.EventContentStageTotalRewardExcel>);
    var _RewardParcelType = default(VectorOffset);
    if (_o.RewardParcelType != null) {
      var __RewardParcelType = _o.RewardParcelType.ToArray();
      _RewardParcelType = CreateRewardParcelTypeVector(builder, __RewardParcelType);
    }
    var _RewardParcelId = default(VectorOffset);
    if (_o.RewardParcelId != null) {
      var __RewardParcelId = _o.RewardParcelId.ToArray();
      _RewardParcelId = CreateRewardParcelIdVector(builder, __RewardParcelId);
    }
    var _RewardParcelAmount = default(VectorOffset);
    if (_o.RewardParcelAmount != null) {
      var __RewardParcelAmount = _o.RewardParcelAmount.ToArray();
      _RewardParcelAmount = CreateRewardParcelAmountVector(builder, __RewardParcelAmount);
    }
    return CreateEventContentStageTotalRewardExcel(
      builder,
      _o.Id,
      _o.EventContentId,
      _o.RequiredEventItemAmount,
      _RewardParcelType,
      _RewardParcelId,
      _RewardParcelAmount);
  }
}

public class EventContentStageTotalRewardExcelT
{
  public long Id { get; set; }
  public long EventContentId { get; set; }
  public long RequiredEventItemAmount { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> RewardParcelType { get; set; }
  public List<long> RewardParcelId { get; set; }
  public List<long> RewardParcelAmount { get; set; }

  public EventContentStageTotalRewardExcelT() {
    this.Id = 0;
    this.EventContentId = 0;
    this.RequiredEventItemAmount = 0;
    this.RewardParcelType = null;
    this.RewardParcelId = null;
    this.RewardParcelAmount = null;
  }
}


static public class EventContentStageTotalRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*EventContentId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*RequiredEventItemAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*RewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*RewardParcelId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RewardParcelAmount*/, 8 /*long*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
