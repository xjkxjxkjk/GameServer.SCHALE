// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct CampaignChapterRewardExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CampaignChapterRewardExcel GetRootAsCampaignChapterRewardExcel(ByteBuffer _bb) { return GetRootAsCampaignChapterRewardExcel(_bb, new CampaignChapterRewardExcel()); }
  public static CampaignChapterRewardExcel GetRootAsCampaignChapterRewardExcel(ByteBuffer _bb, CampaignChapterRewardExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CampaignChapterRewardExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CampaignChapterStar { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.ParcelType ChapterRewardParcelType(int j) { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.ParcelType)0; }
  public int ChapterRewardParcelTypeLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.ParcelType> GetChapterRewardParcelTypeBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.ParcelType>(8, 4); }
#else
  public ArraySegment<byte>? GetChapterRewardParcelTypeBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public SCHALE.Common.FlatData.ParcelType[] GetChapterRewardParcelTypeArray() { int o = __p.__offset(8); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.ParcelType[] a = new SCHALE.Common.FlatData.ParcelType[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(p + i * 4); } return a; }
  public long ChapterRewardId(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int ChapterRewardIdLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetChapterRewardIdBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetChapterRewardIdBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetChapterRewardIdArray() { return __p.__vector_as_array<long>(10); }
  public int ChapterRewardAmount(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int ChapterRewardAmountLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetChapterRewardAmountBytes() { return __p.__vector_as_span<int>(12, 4); }
#else
  public ArraySegment<byte>? GetChapterRewardAmountBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public int[] GetChapterRewardAmountArray() { return __p.__vector_as_array<int>(12); }

  public static Offset<SCHALE.Common.FlatData.CampaignChapterRewardExcel> CreateCampaignChapterRewardExcel(FlatBufferBuilder builder,
      long Id = 0,
      long CampaignChapterStar = 0,
      VectorOffset ChapterRewardParcelTypeOffset = default(VectorOffset),
      VectorOffset ChapterRewardIdOffset = default(VectorOffset),
      VectorOffset ChapterRewardAmountOffset = default(VectorOffset)) {
    builder.StartTable(5);
    CampaignChapterRewardExcel.AddCampaignChapterStar(builder, CampaignChapterStar);
    CampaignChapterRewardExcel.AddId(builder, Id);
    CampaignChapterRewardExcel.AddChapterRewardAmount(builder, ChapterRewardAmountOffset);
    CampaignChapterRewardExcel.AddChapterRewardId(builder, ChapterRewardIdOffset);
    CampaignChapterRewardExcel.AddChapterRewardParcelType(builder, ChapterRewardParcelTypeOffset);
    return CampaignChapterRewardExcel.EndCampaignChapterRewardExcel(builder);
  }

  public static void StartCampaignChapterRewardExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddCampaignChapterStar(FlatBufferBuilder builder, long campaignChapterStar) { builder.AddLong(1, campaignChapterStar, 0); }
  public static void AddChapterRewardParcelType(FlatBufferBuilder builder, VectorOffset chapterRewardParcelTypeOffset) { builder.AddOffset(2, chapterRewardParcelTypeOffset.Value, 0); }
  public static VectorOffset CreateChapterRewardParcelTypeVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardParcelTypeVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardParcelTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.ParcelType> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardParcelTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.ParcelType>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChapterRewardParcelTypeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddChapterRewardId(FlatBufferBuilder builder, VectorOffset chapterRewardIdOffset) { builder.AddOffset(3, chapterRewardIdOffset.Value, 0); }
  public static VectorOffset CreateChapterRewardIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChapterRewardIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddChapterRewardAmount(FlatBufferBuilder builder, VectorOffset chapterRewardAmountOffset) { builder.AddOffset(4, chapterRewardAmountOffset.Value, 0); }
  public static VectorOffset CreateChapterRewardAmountVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardAmountVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardAmountVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateChapterRewardAmountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartChapterRewardAmountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.CampaignChapterRewardExcel> EndCampaignChapterRewardExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CampaignChapterRewardExcel>(o);
  }
  public CampaignChapterRewardExcelT UnPack() {
    var _o = new CampaignChapterRewardExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CampaignChapterRewardExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CampaignChapterReward");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.CampaignChapterStar = TableEncryptionService.Convert(this.CampaignChapterStar, key);
    _o.ChapterRewardParcelType = new List<SCHALE.Common.FlatData.ParcelType>();
    for (var _j = 0; _j < this.ChapterRewardParcelTypeLength; ++_j) {_o.ChapterRewardParcelType.Add(TableEncryptionService.Convert(this.ChapterRewardParcelType(_j), key));}
    _o.ChapterRewardId = new List<long>();
    for (var _j = 0; _j < this.ChapterRewardIdLength; ++_j) {_o.ChapterRewardId.Add(TableEncryptionService.Convert(this.ChapterRewardId(_j), key));}
    _o.ChapterRewardAmount = new List<int>();
    for (var _j = 0; _j < this.ChapterRewardAmountLength; ++_j) {_o.ChapterRewardAmount.Add(TableEncryptionService.Convert(this.ChapterRewardAmount(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.CampaignChapterRewardExcel> Pack(FlatBufferBuilder builder, CampaignChapterRewardExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.CampaignChapterRewardExcel>);
    var _ChapterRewardParcelType = default(VectorOffset);
    if (_o.ChapterRewardParcelType != null) {
      var __ChapterRewardParcelType = _o.ChapterRewardParcelType.ToArray();
      _ChapterRewardParcelType = CreateChapterRewardParcelTypeVector(builder, __ChapterRewardParcelType);
    }
    var _ChapterRewardId = default(VectorOffset);
    if (_o.ChapterRewardId != null) {
      var __ChapterRewardId = _o.ChapterRewardId.ToArray();
      _ChapterRewardId = CreateChapterRewardIdVector(builder, __ChapterRewardId);
    }
    var _ChapterRewardAmount = default(VectorOffset);
    if (_o.ChapterRewardAmount != null) {
      var __ChapterRewardAmount = _o.ChapterRewardAmount.ToArray();
      _ChapterRewardAmount = CreateChapterRewardAmountVector(builder, __ChapterRewardAmount);
    }
    return CreateCampaignChapterRewardExcel(
      builder,
      _o.Id,
      _o.CampaignChapterStar,
      _ChapterRewardParcelType,
      _ChapterRewardId,
      _ChapterRewardAmount);
  }
}

public class CampaignChapterRewardExcelT
{
  public long Id { get; set; }
  public long CampaignChapterStar { get; set; }
  public List<SCHALE.Common.FlatData.ParcelType> ChapterRewardParcelType { get; set; }
  public List<long> ChapterRewardId { get; set; }
  public List<int> ChapterRewardAmount { get; set; }

  public CampaignChapterRewardExcelT() {
    this.Id = 0;
    this.CampaignChapterStar = 0;
    this.ChapterRewardParcelType = null;
    this.ChapterRewardId = null;
    this.ChapterRewardAmount = null;
  }
}


static public class CampaignChapterRewardExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*CampaignChapterStar*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*ChapterRewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*ChapterRewardId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*ChapterRewardAmount*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
