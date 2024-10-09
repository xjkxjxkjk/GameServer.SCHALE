// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct CharacterTranscendenceExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterTranscendenceExcel GetRootAsCharacterTranscendenceExcel(ByteBuffer _bb) { return GetRootAsCharacterTranscendenceExcel(_bb, new CharacterTranscendenceExcel()); }
  public static CharacterTranscendenceExcel GetRootAsCharacterTranscendenceExcel(ByteBuffer _bb, CharacterTranscendenceExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterTranscendenceExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public int MaxFavorLevel(int j) { int o = __p.__offset(6); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MaxFavorLevelLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMaxFavorLevelBytes() { return __p.__vector_as_span<int>(6, 4); }
#else
  public ArraySegment<byte>? GetMaxFavorLevelBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public int[] GetMaxFavorLevelArray() { return __p.__vector_as_array<int>(6); }
  public long StatBonusRateAttack(int j) { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatBonusRateAttackLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatBonusRateAttackBytes() { return __p.__vector_as_span<long>(8, 8); }
#else
  public ArraySegment<byte>? GetStatBonusRateAttackBytes() { return __p.__vector_as_arraysegment(8); }
#endif
  public long[] GetStatBonusRateAttackArray() { return __p.__vector_as_array<long>(8); }
  public long StatBonusRateHP(int j) { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatBonusRateHPLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatBonusRateHPBytes() { return __p.__vector_as_span<long>(10, 8); }
#else
  public ArraySegment<byte>? GetStatBonusRateHPBytes() { return __p.__vector_as_arraysegment(10); }
#endif
  public long[] GetStatBonusRateHPArray() { return __p.__vector_as_array<long>(10); }
  public long StatBonusRateHeal(int j) { int o = __p.__offset(12); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int StatBonusRateHealLength { get { int o = __p.__offset(12); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetStatBonusRateHealBytes() { return __p.__vector_as_span<long>(12, 8); }
#else
  public ArraySegment<byte>? GetStatBonusRateHealBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public long[] GetStatBonusRateHealArray() { return __p.__vector_as_array<long>(12); }
  public long RecipeId(int j) { int o = __p.__offset(14); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int RecipeIdLength { get { int o = __p.__offset(14); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetRecipeIdBytes() { return __p.__vector_as_span<long>(14, 8); }
#else
  public ArraySegment<byte>? GetRecipeIdBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public long[] GetRecipeIdArray() { return __p.__vector_as_array<long>(14); }
  public string SkillSlotA(int j) { int o = __p.__offset(16); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int SkillSlotALength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
  public string SkillSlotB(int j) { int o = __p.__offset(18); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int SkillSlotBLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int MaxlevelStar(int j) { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int MaxlevelStarLength { get { int o = __p.__offset(20); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetMaxlevelStarBytes() { return __p.__vector_as_span<int>(20, 4); }
#else
  public ArraySegment<byte>? GetMaxlevelStarBytes() { return __p.__vector_as_arraysegment(20); }
#endif
  public int[] GetMaxlevelStarArray() { return __p.__vector_as_array<int>(20); }

  public static Offset<SCHALE.Common.FlatData.CharacterTranscendenceExcel> CreateCharacterTranscendenceExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      VectorOffset MaxFavorLevelOffset = default(VectorOffset),
      VectorOffset StatBonusRateAttackOffset = default(VectorOffset),
      VectorOffset StatBonusRateHPOffset = default(VectorOffset),
      VectorOffset StatBonusRateHealOffset = default(VectorOffset),
      VectorOffset RecipeIdOffset = default(VectorOffset),
      VectorOffset SkillSlotAOffset = default(VectorOffset),
      VectorOffset SkillSlotBOffset = default(VectorOffset),
      VectorOffset MaxlevelStarOffset = default(VectorOffset)) {
    builder.StartTable(9);
    CharacterTranscendenceExcel.AddCharacterId(builder, CharacterId);
    CharacterTranscendenceExcel.AddMaxlevelStar(builder, MaxlevelStarOffset);
    CharacterTranscendenceExcel.AddSkillSlotB(builder, SkillSlotBOffset);
    CharacterTranscendenceExcel.AddSkillSlotA(builder, SkillSlotAOffset);
    CharacterTranscendenceExcel.AddRecipeId(builder, RecipeIdOffset);
    CharacterTranscendenceExcel.AddStatBonusRateHeal(builder, StatBonusRateHealOffset);
    CharacterTranscendenceExcel.AddStatBonusRateHP(builder, StatBonusRateHPOffset);
    CharacterTranscendenceExcel.AddStatBonusRateAttack(builder, StatBonusRateAttackOffset);
    CharacterTranscendenceExcel.AddMaxFavorLevel(builder, MaxFavorLevelOffset);
    return CharacterTranscendenceExcel.EndCharacterTranscendenceExcel(builder);
  }

  public static void StartCharacterTranscendenceExcel(FlatBufferBuilder builder) { builder.StartTable(9); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(0, characterId, 0); }
  public static void AddMaxFavorLevel(FlatBufferBuilder builder, VectorOffset maxFavorLevelOffset) { builder.AddOffset(1, maxFavorLevelOffset.Value, 0); }
  public static VectorOffset CreateMaxFavorLevelVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxFavorLevelVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxFavorLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxFavorLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxFavorLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddStatBonusRateAttack(FlatBufferBuilder builder, VectorOffset statBonusRateAttackOffset) { builder.AddOffset(2, statBonusRateAttackOffset.Value, 0); }
  public static VectorOffset CreateStatBonusRateAttackVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateAttackVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateAttackVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateAttackVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatBonusRateAttackVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStatBonusRateHP(FlatBufferBuilder builder, VectorOffset statBonusRateHPOffset) { builder.AddOffset(3, statBonusRateHPOffset.Value, 0); }
  public static VectorOffset CreateStatBonusRateHPVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateHPVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateHPVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateHPVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatBonusRateHPVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddStatBonusRateHeal(FlatBufferBuilder builder, VectorOffset statBonusRateHealOffset) { builder.AddOffset(4, statBonusRateHealOffset.Value, 0); }
  public static VectorOffset CreateStatBonusRateHealVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateHealVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateHealVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateStatBonusRateHealVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartStatBonusRateHealVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddRecipeId(FlatBufferBuilder builder, VectorOffset recipeIdOffset) { builder.AddOffset(5, recipeIdOffset.Value, 0); }
  public static VectorOffset CreateRecipeIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRecipeIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRecipeIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddSkillSlotA(FlatBufferBuilder builder, VectorOffset skillSlotAOffset) { builder.AddOffset(6, skillSlotAOffset.Value, 0); }
  public static VectorOffset CreateSkillSlotAVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSkillSlotAVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillSlotAVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillSlotAVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSkillSlotAVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSkillSlotB(FlatBufferBuilder builder, VectorOffset skillSlotBOffset) { builder.AddOffset(7, skillSlotBOffset.Value, 0); }
  public static VectorOffset CreateSkillSlotBVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateSkillSlotBVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillSlotBVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateSkillSlotBVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartSkillSlotBVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMaxlevelStar(FlatBufferBuilder builder, VectorOffset maxlevelStarOffset) { builder.AddOffset(8, maxlevelStarOffset.Value, 0); }
  public static VectorOffset CreateMaxlevelStarVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateMaxlevelStarVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxlevelStarVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateMaxlevelStarVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartMaxlevelStarVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.CharacterTranscendenceExcel> EndCharacterTranscendenceExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterTranscendenceExcel>(o);
  }
  public CharacterTranscendenceExcelT UnPack() {
    var _o = new CharacterTranscendenceExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(CharacterTranscendenceExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("CharacterTranscendence");
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.MaxFavorLevel = new List<int>();
    for (var _j = 0; _j < this.MaxFavorLevelLength; ++_j) {_o.MaxFavorLevel.Add(TableEncryptionService.Convert(this.MaxFavorLevel(_j), key));}
    _o.StatBonusRateAttack = new List<long>();
    for (var _j = 0; _j < this.StatBonusRateAttackLength; ++_j) {_o.StatBonusRateAttack.Add(TableEncryptionService.Convert(this.StatBonusRateAttack(_j), key));}
    _o.StatBonusRateHP = new List<long>();
    for (var _j = 0; _j < this.StatBonusRateHPLength; ++_j) {_o.StatBonusRateHP.Add(TableEncryptionService.Convert(this.StatBonusRateHP(_j), key));}
    _o.StatBonusRateHeal = new List<long>();
    for (var _j = 0; _j < this.StatBonusRateHealLength; ++_j) {_o.StatBonusRateHeal.Add(TableEncryptionService.Convert(this.StatBonusRateHeal(_j), key));}
    _o.RecipeId = new List<long>();
    for (var _j = 0; _j < this.RecipeIdLength; ++_j) {_o.RecipeId.Add(TableEncryptionService.Convert(this.RecipeId(_j), key));}
    _o.SkillSlotA = new List<string>();
    for (var _j = 0; _j < this.SkillSlotALength; ++_j) {_o.SkillSlotA.Add(TableEncryptionService.Convert(this.SkillSlotA(_j), key));}
    _o.SkillSlotB = new List<string>();
    for (var _j = 0; _j < this.SkillSlotBLength; ++_j) {_o.SkillSlotB.Add(TableEncryptionService.Convert(this.SkillSlotB(_j), key));}
    _o.MaxlevelStar = new List<int>();
    for (var _j = 0; _j < this.MaxlevelStarLength; ++_j) {_o.MaxlevelStar.Add(TableEncryptionService.Convert(this.MaxlevelStar(_j), key));}
  }
  public static Offset<SCHALE.Common.FlatData.CharacterTranscendenceExcel> Pack(FlatBufferBuilder builder, CharacterTranscendenceExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.CharacterTranscendenceExcel>);
    var _MaxFavorLevel = default(VectorOffset);
    if (_o.MaxFavorLevel != null) {
      var __MaxFavorLevel = _o.MaxFavorLevel.ToArray();
      _MaxFavorLevel = CreateMaxFavorLevelVector(builder, __MaxFavorLevel);
    }
    var _StatBonusRateAttack = default(VectorOffset);
    if (_o.StatBonusRateAttack != null) {
      var __StatBonusRateAttack = _o.StatBonusRateAttack.ToArray();
      _StatBonusRateAttack = CreateStatBonusRateAttackVector(builder, __StatBonusRateAttack);
    }
    var _StatBonusRateHP = default(VectorOffset);
    if (_o.StatBonusRateHP != null) {
      var __StatBonusRateHP = _o.StatBonusRateHP.ToArray();
      _StatBonusRateHP = CreateStatBonusRateHPVector(builder, __StatBonusRateHP);
    }
    var _StatBonusRateHeal = default(VectorOffset);
    if (_o.StatBonusRateHeal != null) {
      var __StatBonusRateHeal = _o.StatBonusRateHeal.ToArray();
      _StatBonusRateHeal = CreateStatBonusRateHealVector(builder, __StatBonusRateHeal);
    }
    var _RecipeId = default(VectorOffset);
    if (_o.RecipeId != null) {
      var __RecipeId = _o.RecipeId.ToArray();
      _RecipeId = CreateRecipeIdVector(builder, __RecipeId);
    }
    var _SkillSlotA = default(VectorOffset);
    if (_o.SkillSlotA != null) {
      var __SkillSlotA = new StringOffset[_o.SkillSlotA.Count];
      for (var _j = 0; _j < __SkillSlotA.Length; ++_j) { __SkillSlotA[_j] = builder.CreateString(_o.SkillSlotA[_j]); }
      _SkillSlotA = CreateSkillSlotAVector(builder, __SkillSlotA);
    }
    var _SkillSlotB = default(VectorOffset);
    if (_o.SkillSlotB != null) {
      var __SkillSlotB = new StringOffset[_o.SkillSlotB.Count];
      for (var _j = 0; _j < __SkillSlotB.Length; ++_j) { __SkillSlotB[_j] = builder.CreateString(_o.SkillSlotB[_j]); }
      _SkillSlotB = CreateSkillSlotBVector(builder, __SkillSlotB);
    }
    var _MaxlevelStar = default(VectorOffset);
    if (_o.MaxlevelStar != null) {
      var __MaxlevelStar = _o.MaxlevelStar.ToArray();
      _MaxlevelStar = CreateMaxlevelStarVector(builder, __MaxlevelStar);
    }
    return CreateCharacterTranscendenceExcel(
      builder,
      _o.CharacterId,
      _MaxFavorLevel,
      _StatBonusRateAttack,
      _StatBonusRateHP,
      _StatBonusRateHeal,
      _RecipeId,
      _SkillSlotA,
      _SkillSlotB,
      _MaxlevelStar);
  }
}

public class CharacterTranscendenceExcelT
{
  public long CharacterId { get; set; }
  public List<int> MaxFavorLevel { get; set; }
  public List<long> StatBonusRateAttack { get; set; }
  public List<long> StatBonusRateHP { get; set; }
  public List<long> StatBonusRateHeal { get; set; }
  public List<long> RecipeId { get; set; }
  public List<string> SkillSlotA { get; set; }
  public List<string> SkillSlotB { get; set; }
  public List<int> MaxlevelStar { get; set; }

  public CharacterTranscendenceExcelT() {
    this.CharacterId = 0;
    this.MaxFavorLevel = null;
    this.StatBonusRateAttack = null;
    this.StatBonusRateHP = null;
    this.StatBonusRateHeal = null;
    this.RecipeId = null;
    this.SkillSlotA = null;
    this.SkillSlotB = null;
    this.MaxlevelStar = null;
  }
}


static public class CharacterTranscendenceExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 6 /*MaxFavorLevel*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 8 /*StatBonusRateAttack*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 10 /*StatBonusRateHP*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 12 /*StatBonusRateHeal*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfData(tablePos, 14 /*RecipeId*/, 8 /*long*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 16 /*SkillSlotA*/, false)
      && verifier.VerifyVectorOfStrings(tablePos, 18 /*SkillSlotB*/, false)
      && verifier.VerifyVectorOfData(tablePos, 20 /*MaxlevelStar*/, 4 /*int*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
