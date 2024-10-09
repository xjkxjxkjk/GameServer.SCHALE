// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct AcademyLocationExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AcademyLocationExcel GetRootAsAcademyLocationExcel(ByteBuffer _bb) { return GetRootAsAcademyLocationExcel(_bb, new AcademyLocationExcel()); }
  public static AcademyLocationExcel GetRootAsAcademyLocationExcel(ByteBuffer _bb, AcademyLocationExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AcademyLocationExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public uint LocalizeEtcId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string PrefabPath { get { int o = __p.__offset(8); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPrefabPathBytes() { return __p.__vector_as_span<byte>(8, 1); }
#else
  public ArraySegment<byte>? GetPrefabPathBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public byte[] GetPrefabPathArray() { return __p.__vector_as_array<byte>(8); }
  public string IconImagePath { get { int o = __p.__offset(10); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetIconImagePathBytes() { return __p.__vector_as_span<byte>(10, 1); }
#else
  public ArraySegment<byte>? GetIconImagePathBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public byte[] GetIconImagePathArray() { return __p.__vector_as_array<byte>(10); }
  public SCHALE.Common.FlatData.School OpenCondition(int j) { int o = __p.__offset(12); return o != 0 ? (SCHALE.Common.FlatData.School)__p.bb.GetInt(__p.__vector(o) + j * 4) : (SCHALE.Common.FlatData.School)0; }
  public int OpenConditionLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<SCHALE.Common.FlatData.School> GetOpenConditionBytes() { return __p.__vector_as_span<SCHALE.Common.FlatData.School>(12, 4); }
#else
  public ArraySegment<byte>? GetOpenConditionBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public SCHALE.Common.FlatData.School[] GetOpenConditionArray() { int o = __p.__offset(12); if (o == 0) return null; int p = __p.__vector(o); int l = __p.__vector_len(o); SCHALE.Common.FlatData.School[] a = new SCHALE.Common.FlatData.School[l]; for (int i = 0; i < l; i++) { a[i] = (SCHALE.Common.FlatData.School)__p.bb.GetInt(p + i * 4); } return a; }
  public long OpenConditionCount(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int OpenConditionCountLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetOpenConditionCountBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetOpenConditionCountBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetOpenConditionCountArray() { return __p.__vector_as_array<long>(14); }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get { int o = __p.__offset(16); return o != 0 ? (SCHALE.Common.FlatData.ParcelType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.ParcelType.None; } }
  public long RewardParcelId { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenTeacherRank { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }

  public static Offset<SCHALE.Common.FlatData.AcademyLocationExcel> CreateAcademyLocationExcel(FlatBufferBuilder builder,
      long Id = 0,
      uint LocalizeEtcId = 0,
      StringOffset PrefabPathOffset = default(StringOffset),
      StringOffset IconImagePathOffset = default(StringOffset),
      VectorOffset OpenConditionOffset = default(VectorOffset),
      VectorOffset OpenConditionCountOffset = default(VectorOffset),
      SCHALE.Common.FlatData.ParcelType RewardParcelType = SCHALE.Common.FlatData.ParcelType.None,
      long RewardParcelId = 0,
      long OpenTeacherRank = 0) {
    builder.StartTable(9);
    AcademyLocationExcel.AddOpenTeacherRank(builder, OpenTeacherRank);
    AcademyLocationExcel.AddRewardParcelId(builder, RewardParcelId);
    AcademyLocationExcel.AddId(builder, Id);
    AcademyLocationExcel.AddRewardParcelType(builder, RewardParcelType);
    AcademyLocationExcel.AddOpenConditionCount(builder, OpenConditionCountOffset);
    AcademyLocationExcel.AddOpenCondition(builder, OpenConditionOffset);
    AcademyLocationExcel.AddIconImagePath(builder, IconImagePathOffset);
    AcademyLocationExcel.AddPrefabPath(builder, PrefabPathOffset);
    AcademyLocationExcel.AddLocalizeEtcId(builder, LocalizeEtcId);
    return AcademyLocationExcel.EndAcademyLocationExcel(builder);
  }

  public static void StartAcademyLocationExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddLocalizeEtcId(FlatBufferBuilder builder, uint localizeEtcId) { builder.AddUint(1, localizeEtcId, 0); }
  public static void AddPrefabPath(FlatBufferBuilder builder, StringOffset prefabPathOffset) { builder.AddOffset(2, prefabPathOffset.Value, 0); }
  public static void AddIconImagePath(FlatBufferBuilder builder, StringOffset iconImagePathOffset) { builder.AddOffset(3, iconImagePathOffset.Value, 0); }
  public static void AddOpenCondition(FlatBufferBuilder builder, VectorOffset openConditionOffset) { builder.AddOffset(4, openConditionOffset.Value, 0); }
  public static VectorOffset CreateOpenConditionVector(FlatBufferBuilder builder, SCHALE.Common.FlatData.School[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt((int)data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOpenConditionVectorBlock(FlatBufferBuilder builder, SCHALE.Common.FlatData.School[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenConditionVectorBlock(FlatBufferBuilder builder, ArraySegment<SCHALE.Common.FlatData.School> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenConditionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<SCHALE.Common.FlatData.School>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOpenConditionVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddOpenConditionCount(FlatBufferBuilder builder, VectorOffset openConditionCountOffset) { builder.AddOffset(5, openConditionCountOffset.Value, 0); }
  public static VectorOffset CreateOpenConditionCountVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateOpenConditionCountVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenConditionCountVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateOpenConditionCountVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartOpenConditionCountVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRewardParcelType(FlatBufferBuilder builder, SCHALE.Common.FlatData.ParcelType rewardParcelType) { builder.AddInt(6, (int)rewardParcelType, 0); }
  public static void AddRewardParcelId(FlatBufferBuilder builder, long rewardParcelId) { builder.AddLong(7, rewardParcelId, 0); }
  public static void AddOpenTeacherRank(FlatBufferBuilder builder, long openTeacherRank) { builder.AddLong(8, openTeacherRank, 0); }
  public static Offset<SCHALE.Common.FlatData.AcademyLocationExcel> EndAcademyLocationExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.AcademyLocationExcel>(o);
  }
  public AcademyLocationExcelT UnPack() {
    var _o = new AcademyLocationExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(AcademyLocationExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("AcademyLocation");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.LocalizeEtcId = TableEncryptionService.Convert(this.LocalizeEtcId, key);
    _o.PrefabPath = TableEncryptionService.Convert(this.PrefabPath, key);
    _o.IconImagePath = TableEncryptionService.Convert(this.IconImagePath, key);
    _o.OpenCondition = new List<SCHALE.Common.FlatData.School>();
    for (var _j = 0; _j < this.OpenConditionLength; ++_j) {_o.OpenCondition.Add(TableEncryptionService.Convert(this.OpenCondition(_j), key));}
    _o.OpenConditionCount = new List<long>();
    for (var _j = 0; _j < this.OpenConditionCountLength; ++_j) {_o.OpenConditionCount.Add(TableEncryptionService.Convert(this.OpenConditionCount(_j), key));}
    _o.RewardParcelType = TableEncryptionService.Convert(this.RewardParcelType, key);
    _o.RewardParcelId = TableEncryptionService.Convert(this.RewardParcelId, key);
    _o.OpenTeacherRank = TableEncryptionService.Convert(this.OpenTeacherRank, key);
  }
  public static Offset<SCHALE.Common.FlatData.AcademyLocationExcel> Pack(FlatBufferBuilder builder, AcademyLocationExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.AcademyLocationExcel>);
    var _PrefabPath = _o.PrefabPath == null ? default(StringOffset) : builder.CreateString(_o.PrefabPath);
    var _IconImagePath = _o.IconImagePath == null ? default(StringOffset) : builder.CreateString(_o.IconImagePath);
    var _OpenCondition = default(VectorOffset);
    if (_o.OpenCondition != null) {
      var __OpenCondition = _o.OpenCondition.ToArray();
      _OpenCondition = CreateOpenConditionVector(builder, __OpenCondition);
    }
    var _OpenConditionCount = default(VectorOffset);
    if (_o.OpenConditionCount != null) {
      var __OpenConditionCount = _o.OpenConditionCount.ToArray();
      _OpenConditionCount = CreateOpenConditionCountVector(builder, __OpenConditionCount);
    }
    return CreateAcademyLocationExcel(
      builder,
      _o.Id,
      _o.LocalizeEtcId,
      _PrefabPath,
      _IconImagePath,
      _OpenCondition,
      _OpenConditionCount,
      _o.RewardParcelType,
      _o.RewardParcelId,
      _o.OpenTeacherRank);
  }
}

public class AcademyLocationExcelT
{
  public long Id { get; set; }
  public uint LocalizeEtcId { get; set; }
  public string PrefabPath { get; set; }
  public string IconImagePath { get; set; }
  public List<SCHALE.Common.FlatData.School> OpenCondition { get; set; }
  public List<long> OpenConditionCount { get; set; }
  public SCHALE.Common.FlatData.ParcelType RewardParcelType { get; set; }
  public long RewardParcelId { get; set; }
  public long OpenTeacherRank { get; set; }

  public AcademyLocationExcelT() {
    this.Id = 0;
    this.LocalizeEtcId = 0;
    this.PrefabPath = null;
    this.IconImagePath = null;
    this.OpenCondition = null;
    this.OpenConditionCount = null;
    this.RewardParcelType = SCHALE.Common.FlatData.ParcelType.None;
    this.RewardParcelId = 0;
    this.OpenTeacherRank = 0;
  }
}


static public class AcademyLocationExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*LocalizeEtcId*/, 4 /*uint*/, 4, false)
      && verifier.VerifyString(tablePos, 8 /*PrefabPath*/, false)
      && verifier.VerifyString(tablePos, 10 /*IconImagePath*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*OpenCondition*/, 4 /*SCHALE.Common.FlatData.School*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*OpenConditionCount*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 16 /*RewardParcelType*/, 4 /*SCHALE.Common.FlatData.ParcelType*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*RewardParcelId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*OpenTeacherRank*/, 8 /*long*/, 8, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
