// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct ConstMinigameTBGExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static ConstMinigameTBGExcel GetRootAsConstMinigameTBGExcel(ByteBuffer _bb) { return GetRootAsConstMinigameTBGExcel(_bb, new ConstMinigameTBGExcel()); }
  public static ConstMinigameTBGExcel GetRootAsConstMinigameTBGExcel(ByteBuffer _bb, ConstMinigameTBGExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public ConstMinigameTBGExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public float ConquestMapBoundaryOffsetLeft { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetRight { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetTop { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapBoundaryOffsetBottom { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapCenterOffsetX { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ConquestMapCenterOffsetY { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraAngle { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMax { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomMin { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float CameraZoomDefault { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float ThemaLoadingProgressTime { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float MapAllyRotation { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public string AniAllyBattleAttack { get { int o = __p.__offset(28); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAniAllyBattleAttackBytes() { return __p.__vector_as_span<byte>(28, 1); }
#else
  public ArraySegment<byte>? GetAniAllyBattleAttackBytes() { return __p.__vector_as_arraysegment(28); }
#endif
  public byte[] GetAniAllyBattleAttackArray() { return __p.__vector_as_array<byte>(28); }
  public string EffectAllyBattleAttack { get { int o = __p.__offset(30); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEffectAllyBattleAttackBytes() { return __p.__vector_as_span<byte>(30, 1); }
#else
  public ArraySegment<byte>? GetEffectAllyBattleAttackBytes() { return __p.__vector_as_arraysegment(30); }
#endif
  public byte[] GetEffectAllyBattleAttackArray() { return __p.__vector_as_array<byte>(30); }
  public string EffectAllyBattleDamage { get { int o = __p.__offset(32); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEffectAllyBattleDamageBytes() { return __p.__vector_as_span<byte>(32, 1); }
#else
  public ArraySegment<byte>? GetEffectAllyBattleDamageBytes() { return __p.__vector_as_arraysegment(32); }
#endif
  public byte[] GetEffectAllyBattleDamageArray() { return __p.__vector_as_array<byte>(32); }
  public string AniEnemyBattleAttack { get { int o = __p.__offset(34); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAniEnemyBattleAttackBytes() { return __p.__vector_as_span<byte>(34, 1); }
#else
  public ArraySegment<byte>? GetAniEnemyBattleAttackBytes() { return __p.__vector_as_arraysegment(34); }
#endif
  public byte[] GetAniEnemyBattleAttackArray() { return __p.__vector_as_array<byte>(34); }
  public string EffectEnemyBattleAttack { get { int o = __p.__offset(36); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEffectEnemyBattleAttackBytes() { return __p.__vector_as_span<byte>(36, 1); }
#else
  public ArraySegment<byte>? GetEffectEnemyBattleAttackBytes() { return __p.__vector_as_arraysegment(36); }
#endif
  public byte[] GetEffectEnemyBattleAttackArray() { return __p.__vector_as_array<byte>(36); }
  public string EffectEnemyBattleDamage { get { int o = __p.__offset(38); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetEffectEnemyBattleDamageBytes() { return __p.__vector_as_span<byte>(38, 1); }
#else
  public ArraySegment<byte>? GetEffectEnemyBattleDamageBytes() { return __p.__vector_as_arraysegment(38); }
#endif
  public byte[] GetEffectEnemyBattleDamageArray() { return __p.__vector_as_array<byte>(38); }
  public float EncounterAllyRotation { get { int o = __p.__offset(40); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float EncounterEnemyRotation { get { int o = __p.__offset(42); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public int EncounterRewardReceiveIndex { get { int o = __p.__offset(44); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.ConstMinigameTBGExcel> CreateConstMinigameTBGExcel(FlatBufferBuilder builder,
      float ConquestMapBoundaryOffsetLeft = 0.0f,
      float ConquestMapBoundaryOffsetRight = 0.0f,
      float ConquestMapBoundaryOffsetTop = 0.0f,
      float ConquestMapBoundaryOffsetBottom = 0.0f,
      float ConquestMapCenterOffsetX = 0.0f,
      float ConquestMapCenterOffsetY = 0.0f,
      float CameraAngle = 0.0f,
      float CameraZoomMax = 0.0f,
      float CameraZoomMin = 0.0f,
      float CameraZoomDefault = 0.0f,
      float ThemaLoadingProgressTime = 0.0f,
      float MapAllyRotation = 0.0f,
      StringOffset AniAllyBattleAttackOffset = default(StringOffset),
      StringOffset EffectAllyBattleAttackOffset = default(StringOffset),
      StringOffset EffectAllyBattleDamageOffset = default(StringOffset),
      StringOffset AniEnemyBattleAttackOffset = default(StringOffset),
      StringOffset EffectEnemyBattleAttackOffset = default(StringOffset),
      StringOffset EffectEnemyBattleDamageOffset = default(StringOffset),
      float EncounterAllyRotation = 0.0f,
      float EncounterEnemyRotation = 0.0f,
      int EncounterRewardReceiveIndex = 0) {
    builder.StartTable(21);
    ConstMinigameTBGExcel.AddEncounterRewardReceiveIndex(builder, EncounterRewardReceiveIndex);
    ConstMinigameTBGExcel.AddEncounterEnemyRotation(builder, EncounterEnemyRotation);
    ConstMinigameTBGExcel.AddEncounterAllyRotation(builder, EncounterAllyRotation);
    ConstMinigameTBGExcel.AddEffectEnemyBattleDamage(builder, EffectEnemyBattleDamageOffset);
    ConstMinigameTBGExcel.AddEffectEnemyBattleAttack(builder, EffectEnemyBattleAttackOffset);
    ConstMinigameTBGExcel.AddAniEnemyBattleAttack(builder, AniEnemyBattleAttackOffset);
    ConstMinigameTBGExcel.AddEffectAllyBattleDamage(builder, EffectAllyBattleDamageOffset);
    ConstMinigameTBGExcel.AddEffectAllyBattleAttack(builder, EffectAllyBattleAttackOffset);
    ConstMinigameTBGExcel.AddAniAllyBattleAttack(builder, AniAllyBattleAttackOffset);
    ConstMinigameTBGExcel.AddMapAllyRotation(builder, MapAllyRotation);
    ConstMinigameTBGExcel.AddThemaLoadingProgressTime(builder, ThemaLoadingProgressTime);
    ConstMinigameTBGExcel.AddCameraZoomDefault(builder, CameraZoomDefault);
    ConstMinigameTBGExcel.AddCameraZoomMin(builder, CameraZoomMin);
    ConstMinigameTBGExcel.AddCameraZoomMax(builder, CameraZoomMax);
    ConstMinigameTBGExcel.AddCameraAngle(builder, CameraAngle);
    ConstMinigameTBGExcel.AddConquestMapCenterOffsetY(builder, ConquestMapCenterOffsetY);
    ConstMinigameTBGExcel.AddConquestMapCenterOffsetX(builder, ConquestMapCenterOffsetX);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetBottom(builder, ConquestMapBoundaryOffsetBottom);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetTop(builder, ConquestMapBoundaryOffsetTop);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetRight(builder, ConquestMapBoundaryOffsetRight);
    ConstMinigameTBGExcel.AddConquestMapBoundaryOffsetLeft(builder, ConquestMapBoundaryOffsetLeft);
    return ConstMinigameTBGExcel.EndConstMinigameTBGExcel(builder);
  }

  public static void StartConstMinigameTBGExcel(FlatBufferBuilder builder) { builder.StartTable(21); }
  public static void AddConquestMapBoundaryOffsetLeft(FlatBufferBuilder builder, float conquestMapBoundaryOffsetLeft) { builder.AddFloat(0, conquestMapBoundaryOffsetLeft, 0.0f); }
  public static void AddConquestMapBoundaryOffsetRight(FlatBufferBuilder builder, float conquestMapBoundaryOffsetRight) { builder.AddFloat(1, conquestMapBoundaryOffsetRight, 0.0f); }
  public static void AddConquestMapBoundaryOffsetTop(FlatBufferBuilder builder, float conquestMapBoundaryOffsetTop) { builder.AddFloat(2, conquestMapBoundaryOffsetTop, 0.0f); }
  public static void AddConquestMapBoundaryOffsetBottom(FlatBufferBuilder builder, float conquestMapBoundaryOffsetBottom) { builder.AddFloat(3, conquestMapBoundaryOffsetBottom, 0.0f); }
  public static void AddConquestMapCenterOffsetX(FlatBufferBuilder builder, float conquestMapCenterOffsetX) { builder.AddFloat(4, conquestMapCenterOffsetX, 0.0f); }
  public static void AddConquestMapCenterOffsetY(FlatBufferBuilder builder, float conquestMapCenterOffsetY) { builder.AddFloat(5, conquestMapCenterOffsetY, 0.0f); }
  public static void AddCameraAngle(FlatBufferBuilder builder, float cameraAngle) { builder.AddFloat(6, cameraAngle, 0.0f); }
  public static void AddCameraZoomMax(FlatBufferBuilder builder, float cameraZoomMax) { builder.AddFloat(7, cameraZoomMax, 0.0f); }
  public static void AddCameraZoomMin(FlatBufferBuilder builder, float cameraZoomMin) { builder.AddFloat(8, cameraZoomMin, 0.0f); }
  public static void AddCameraZoomDefault(FlatBufferBuilder builder, float cameraZoomDefault) { builder.AddFloat(9, cameraZoomDefault, 0.0f); }
  public static void AddThemaLoadingProgressTime(FlatBufferBuilder builder, float themaLoadingProgressTime) { builder.AddFloat(10, themaLoadingProgressTime, 0.0f); }
  public static void AddMapAllyRotation(FlatBufferBuilder builder, float mapAllyRotation) { builder.AddFloat(11, mapAllyRotation, 0.0f); }
  public static void AddAniAllyBattleAttack(FlatBufferBuilder builder, StringOffset aniAllyBattleAttackOffset) { builder.AddOffset(12, aniAllyBattleAttackOffset.Value, 0); }
  public static void AddEffectAllyBattleAttack(FlatBufferBuilder builder, StringOffset effectAllyBattleAttackOffset) { builder.AddOffset(13, effectAllyBattleAttackOffset.Value, 0); }
  public static void AddEffectAllyBattleDamage(FlatBufferBuilder builder, StringOffset effectAllyBattleDamageOffset) { builder.AddOffset(14, effectAllyBattleDamageOffset.Value, 0); }
  public static void AddAniEnemyBattleAttack(FlatBufferBuilder builder, StringOffset aniEnemyBattleAttackOffset) { builder.AddOffset(15, aniEnemyBattleAttackOffset.Value, 0); }
  public static void AddEffectEnemyBattleAttack(FlatBufferBuilder builder, StringOffset effectEnemyBattleAttackOffset) { builder.AddOffset(16, effectEnemyBattleAttackOffset.Value, 0); }
  public static void AddEffectEnemyBattleDamage(FlatBufferBuilder builder, StringOffset effectEnemyBattleDamageOffset) { builder.AddOffset(17, effectEnemyBattleDamageOffset.Value, 0); }
  public static void AddEncounterAllyRotation(FlatBufferBuilder builder, float encounterAllyRotation) { builder.AddFloat(18, encounterAllyRotation, 0.0f); }
  public static void AddEncounterEnemyRotation(FlatBufferBuilder builder, float encounterEnemyRotation) { builder.AddFloat(19, encounterEnemyRotation, 0.0f); }
  public static void AddEncounterRewardReceiveIndex(FlatBufferBuilder builder, int encounterRewardReceiveIndex) { builder.AddInt(20, encounterRewardReceiveIndex, 0); }
  public static Offset<SCHALE.Common.FlatData.ConstMinigameTBGExcel> EndConstMinigameTBGExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.ConstMinigameTBGExcel>(o);
  }
  public ConstMinigameTBGExcelT UnPack() {
    var _o = new ConstMinigameTBGExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(ConstMinigameTBGExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("ConstMinigameTBG");
    _o.ConquestMapBoundaryOffsetLeft = TableEncryptionService.Convert(this.ConquestMapBoundaryOffsetLeft, key);
    _o.ConquestMapBoundaryOffsetRight = TableEncryptionService.Convert(this.ConquestMapBoundaryOffsetRight, key);
    _o.ConquestMapBoundaryOffsetTop = TableEncryptionService.Convert(this.ConquestMapBoundaryOffsetTop, key);
    _o.ConquestMapBoundaryOffsetBottom = TableEncryptionService.Convert(this.ConquestMapBoundaryOffsetBottom, key);
    _o.ConquestMapCenterOffsetX = TableEncryptionService.Convert(this.ConquestMapCenterOffsetX, key);
    _o.ConquestMapCenterOffsetY = TableEncryptionService.Convert(this.ConquestMapCenterOffsetY, key);
    _o.CameraAngle = TableEncryptionService.Convert(this.CameraAngle, key);
    _o.CameraZoomMax = TableEncryptionService.Convert(this.CameraZoomMax, key);
    _o.CameraZoomMin = TableEncryptionService.Convert(this.CameraZoomMin, key);
    _o.CameraZoomDefault = TableEncryptionService.Convert(this.CameraZoomDefault, key);
    _o.ThemaLoadingProgressTime = TableEncryptionService.Convert(this.ThemaLoadingProgressTime, key);
    _o.MapAllyRotation = TableEncryptionService.Convert(this.MapAllyRotation, key);
    _o.AniAllyBattleAttack = TableEncryptionService.Convert(this.AniAllyBattleAttack, key);
    _o.EffectAllyBattleAttack = TableEncryptionService.Convert(this.EffectAllyBattleAttack, key);
    _o.EffectAllyBattleDamage = TableEncryptionService.Convert(this.EffectAllyBattleDamage, key);
    _o.AniEnemyBattleAttack = TableEncryptionService.Convert(this.AniEnemyBattleAttack, key);
    _o.EffectEnemyBattleAttack = TableEncryptionService.Convert(this.EffectEnemyBattleAttack, key);
    _o.EffectEnemyBattleDamage = TableEncryptionService.Convert(this.EffectEnemyBattleDamage, key);
    _o.EncounterAllyRotation = TableEncryptionService.Convert(this.EncounterAllyRotation, key);
    _o.EncounterEnemyRotation = TableEncryptionService.Convert(this.EncounterEnemyRotation, key);
    _o.EncounterRewardReceiveIndex = TableEncryptionService.Convert(this.EncounterRewardReceiveIndex, key);
  }
  public static Offset<SCHALE.Common.FlatData.ConstMinigameTBGExcel> Pack(FlatBufferBuilder builder, ConstMinigameTBGExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.ConstMinigameTBGExcel>);
    var _AniAllyBattleAttack = _o.AniAllyBattleAttack == null ? default(StringOffset) : builder.CreateString(_o.AniAllyBattleAttack);
    var _EffectAllyBattleAttack = _o.EffectAllyBattleAttack == null ? default(StringOffset) : builder.CreateString(_o.EffectAllyBattleAttack);
    var _EffectAllyBattleDamage = _o.EffectAllyBattleDamage == null ? default(StringOffset) : builder.CreateString(_o.EffectAllyBattleDamage);
    var _AniEnemyBattleAttack = _o.AniEnemyBattleAttack == null ? default(StringOffset) : builder.CreateString(_o.AniEnemyBattleAttack);
    var _EffectEnemyBattleAttack = _o.EffectEnemyBattleAttack == null ? default(StringOffset) : builder.CreateString(_o.EffectEnemyBattleAttack);
    var _EffectEnemyBattleDamage = _o.EffectEnemyBattleDamage == null ? default(StringOffset) : builder.CreateString(_o.EffectEnemyBattleDamage);
    return CreateConstMinigameTBGExcel(
      builder,
      _o.ConquestMapBoundaryOffsetLeft,
      _o.ConquestMapBoundaryOffsetRight,
      _o.ConquestMapBoundaryOffsetTop,
      _o.ConquestMapBoundaryOffsetBottom,
      _o.ConquestMapCenterOffsetX,
      _o.ConquestMapCenterOffsetY,
      _o.CameraAngle,
      _o.CameraZoomMax,
      _o.CameraZoomMin,
      _o.CameraZoomDefault,
      _o.ThemaLoadingProgressTime,
      _o.MapAllyRotation,
      _AniAllyBattleAttack,
      _EffectAllyBattleAttack,
      _EffectAllyBattleDamage,
      _AniEnemyBattleAttack,
      _EffectEnemyBattleAttack,
      _EffectEnemyBattleDamage,
      _o.EncounterAllyRotation,
      _o.EncounterEnemyRotation,
      _o.EncounterRewardReceiveIndex);
  }
}

public class ConstMinigameTBGExcelT
{
  public float ConquestMapBoundaryOffsetLeft { get; set; }
  public float ConquestMapBoundaryOffsetRight { get; set; }
  public float ConquestMapBoundaryOffsetTop { get; set; }
  public float ConquestMapBoundaryOffsetBottom { get; set; }
  public float ConquestMapCenterOffsetX { get; set; }
  public float ConquestMapCenterOffsetY { get; set; }
  public float CameraAngle { get; set; }
  public float CameraZoomMax { get; set; }
  public float CameraZoomMin { get; set; }
  public float CameraZoomDefault { get; set; }
  public float ThemaLoadingProgressTime { get; set; }
  public float MapAllyRotation { get; set; }
  public string AniAllyBattleAttack { get; set; }
  public string EffectAllyBattleAttack { get; set; }
  public string EffectAllyBattleDamage { get; set; }
  public string AniEnemyBattleAttack { get; set; }
  public string EffectEnemyBattleAttack { get; set; }
  public string EffectEnemyBattleDamage { get; set; }
  public float EncounterAllyRotation { get; set; }
  public float EncounterEnemyRotation { get; set; }
  public int EncounterRewardReceiveIndex { get; set; }

  public ConstMinigameTBGExcelT() {
    this.ConquestMapBoundaryOffsetLeft = 0.0f;
    this.ConquestMapBoundaryOffsetRight = 0.0f;
    this.ConquestMapBoundaryOffsetTop = 0.0f;
    this.ConquestMapBoundaryOffsetBottom = 0.0f;
    this.ConquestMapCenterOffsetX = 0.0f;
    this.ConquestMapCenterOffsetY = 0.0f;
    this.CameraAngle = 0.0f;
    this.CameraZoomMax = 0.0f;
    this.CameraZoomMin = 0.0f;
    this.CameraZoomDefault = 0.0f;
    this.ThemaLoadingProgressTime = 0.0f;
    this.MapAllyRotation = 0.0f;
    this.AniAllyBattleAttack = null;
    this.EffectAllyBattleAttack = null;
    this.EffectAllyBattleDamage = null;
    this.AniEnemyBattleAttack = null;
    this.EffectEnemyBattleAttack = null;
    this.EffectEnemyBattleDamage = null;
    this.EncounterAllyRotation = 0.0f;
    this.EncounterEnemyRotation = 0.0f;
    this.EncounterRewardReceiveIndex = 0;
  }
}


static public class ConstMinigameTBGExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*ConquestMapBoundaryOffsetLeft*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 6 /*ConquestMapBoundaryOffsetRight*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*ConquestMapBoundaryOffsetTop*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*ConquestMapBoundaryOffsetBottom*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*ConquestMapCenterOffsetX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*ConquestMapCenterOffsetY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*CameraAngle*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*CameraZoomMax*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*CameraZoomMin*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*CameraZoomDefault*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*ThemaLoadingProgressTime*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*MapAllyRotation*/, 4 /*float*/, 4, false)
      && verifier.VerifyString(tablePos, 28 /*AniAllyBattleAttack*/, false)
      && verifier.VerifyString(tablePos, 30 /*EffectAllyBattleAttack*/, false)
      && verifier.VerifyString(tablePos, 32 /*EffectAllyBattleDamage*/, false)
      && verifier.VerifyString(tablePos, 34 /*AniEnemyBattleAttack*/, false)
      && verifier.VerifyString(tablePos, 36 /*EffectEnemyBattleAttack*/, false)
      && verifier.VerifyString(tablePos, 38 /*EffectEnemyBattleDamage*/, false)
      && verifier.VerifyField(tablePos, 40 /*EncounterAllyRotation*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 42 /*EncounterEnemyRotation*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 44 /*EncounterRewardReceiveIndex*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
