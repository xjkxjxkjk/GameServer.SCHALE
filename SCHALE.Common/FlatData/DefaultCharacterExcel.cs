// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct DefaultCharacterExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static DefaultCharacterExcel GetRootAsDefaultCharacterExcel(ByteBuffer _bb) { return GetRootAsDefaultCharacterExcel(_bb, new DefaultCharacterExcel()); }
  public static DefaultCharacterExcel GetRootAsDefaultCharacterExcel(ByteBuffer _bb, DefaultCharacterExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DefaultCharacterExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long CharacterId { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool FavoriteCharacter { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public int Level { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int Exp { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FavorExp { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int FavorRank { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int StarGrade { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExSkillLevel { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int PassiveSkillLevel { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int ExtraPassiveSkillLevel { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int CommonSkillLevel { get { int o = __p.__offset(24); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public int LeaderSkillLevel { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }

  public static Offset<SCHALE.Common.FlatData.DefaultCharacterExcel> CreateDefaultCharacterExcel(FlatBufferBuilder builder,
      long CharacterId = 0,
      bool FavoriteCharacter = false,
      int Level = 0,
      int Exp = 0,
      int FavorExp = 0,
      int FavorRank = 0,
      int StarGrade = 0,
      int ExSkillLevel = 0,
      int PassiveSkillLevel = 0,
      int ExtraPassiveSkillLevel = 0,
      int CommonSkillLevel = 0,
      int LeaderSkillLevel = 0) {
    builder.StartTable(12);
    DefaultCharacterExcel.AddCharacterId(builder, CharacterId);
    DefaultCharacterExcel.AddLeaderSkillLevel(builder, LeaderSkillLevel);
    DefaultCharacterExcel.AddCommonSkillLevel(builder, CommonSkillLevel);
    DefaultCharacterExcel.AddExtraPassiveSkillLevel(builder, ExtraPassiveSkillLevel);
    DefaultCharacterExcel.AddPassiveSkillLevel(builder, PassiveSkillLevel);
    DefaultCharacterExcel.AddExSkillLevel(builder, ExSkillLevel);
    DefaultCharacterExcel.AddStarGrade(builder, StarGrade);
    DefaultCharacterExcel.AddFavorRank(builder, FavorRank);
    DefaultCharacterExcel.AddFavorExp(builder, FavorExp);
    DefaultCharacterExcel.AddExp(builder, Exp);
    DefaultCharacterExcel.AddLevel(builder, Level);
    DefaultCharacterExcel.AddFavoriteCharacter(builder, FavoriteCharacter);
    return DefaultCharacterExcel.EndDefaultCharacterExcel(builder);
  }

  public static void StartDefaultCharacterExcel(FlatBufferBuilder builder) { builder.StartTable(12); }
  public static void AddCharacterId(FlatBufferBuilder builder, long characterId) { builder.AddLong(0, characterId, 0); }
  public static void AddFavoriteCharacter(FlatBufferBuilder builder, bool favoriteCharacter) { builder.AddBool(1, favoriteCharacter, false); }
  public static void AddLevel(FlatBufferBuilder builder, int level) { builder.AddInt(2, level, 0); }
  public static void AddExp(FlatBufferBuilder builder, int exp) { builder.AddInt(3, exp, 0); }
  public static void AddFavorExp(FlatBufferBuilder builder, int favorExp) { builder.AddInt(4, favorExp, 0); }
  public static void AddFavorRank(FlatBufferBuilder builder, int favorRank) { builder.AddInt(5, favorRank, 0); }
  public static void AddStarGrade(FlatBufferBuilder builder, int starGrade) { builder.AddInt(6, starGrade, 0); }
  public static void AddExSkillLevel(FlatBufferBuilder builder, int exSkillLevel) { builder.AddInt(7, exSkillLevel, 0); }
  public static void AddPassiveSkillLevel(FlatBufferBuilder builder, int passiveSkillLevel) { builder.AddInt(8, passiveSkillLevel, 0); }
  public static void AddExtraPassiveSkillLevel(FlatBufferBuilder builder, int extraPassiveSkillLevel) { builder.AddInt(9, extraPassiveSkillLevel, 0); }
  public static void AddCommonSkillLevel(FlatBufferBuilder builder, int commonSkillLevel) { builder.AddInt(10, commonSkillLevel, 0); }
  public static void AddLeaderSkillLevel(FlatBufferBuilder builder, int leaderSkillLevel) { builder.AddInt(11, leaderSkillLevel, 0); }
  public static Offset<SCHALE.Common.FlatData.DefaultCharacterExcel> EndDefaultCharacterExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.DefaultCharacterExcel>(o);
  }
  public DefaultCharacterExcelT UnPack() {
    var _o = new DefaultCharacterExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DefaultCharacterExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("DefaultCharacter");
    _o.CharacterId = TableEncryptionService.Convert(this.CharacterId, key);
    _o.FavoriteCharacter = TableEncryptionService.Convert(this.FavoriteCharacter, key);
    _o.Level = TableEncryptionService.Convert(this.Level, key);
    _o.Exp = TableEncryptionService.Convert(this.Exp, key);
    _o.FavorExp = TableEncryptionService.Convert(this.FavorExp, key);
    _o.FavorRank = TableEncryptionService.Convert(this.FavorRank, key);
    _o.StarGrade = TableEncryptionService.Convert(this.StarGrade, key);
    _o.ExSkillLevel = TableEncryptionService.Convert(this.ExSkillLevel, key);
    _o.PassiveSkillLevel = TableEncryptionService.Convert(this.PassiveSkillLevel, key);
    _o.ExtraPassiveSkillLevel = TableEncryptionService.Convert(this.ExtraPassiveSkillLevel, key);
    _o.CommonSkillLevel = TableEncryptionService.Convert(this.CommonSkillLevel, key);
    _o.LeaderSkillLevel = TableEncryptionService.Convert(this.LeaderSkillLevel, key);
  }
  public static Offset<SCHALE.Common.FlatData.DefaultCharacterExcel> Pack(FlatBufferBuilder builder, DefaultCharacterExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.DefaultCharacterExcel>);
    return CreateDefaultCharacterExcel(
      builder,
      _o.CharacterId,
      _o.FavoriteCharacter,
      _o.Level,
      _o.Exp,
      _o.FavorExp,
      _o.FavorRank,
      _o.StarGrade,
      _o.ExSkillLevel,
      _o.PassiveSkillLevel,
      _o.ExtraPassiveSkillLevel,
      _o.CommonSkillLevel,
      _o.LeaderSkillLevel);
  }
}

public class DefaultCharacterExcelT
{
  public long CharacterId { get; set; }
  public bool FavoriteCharacter { get; set; }
  public int Level { get; set; }
  public int Exp { get; set; }
  public int FavorExp { get; set; }
  public int FavorRank { get; set; }
  public int StarGrade { get; set; }
  public int ExSkillLevel { get; set; }
  public int PassiveSkillLevel { get; set; }
  public int ExtraPassiveSkillLevel { get; set; }
  public int CommonSkillLevel { get; set; }
  public int LeaderSkillLevel { get; set; }

  public DefaultCharacterExcelT() {
    this.CharacterId = 0;
    this.FavoriteCharacter = false;
    this.Level = 0;
    this.Exp = 0;
    this.FavorExp = 0;
    this.FavorRank = 0;
    this.StarGrade = 0;
    this.ExSkillLevel = 0;
    this.PassiveSkillLevel = 0;
    this.ExtraPassiveSkillLevel = 0;
    this.CommonSkillLevel = 0;
    this.LeaderSkillLevel = 0;
  }
}


static public class DefaultCharacterExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*CharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*FavoriteCharacter*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*Level*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*Exp*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*FavorExp*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 14 /*FavorRank*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 16 /*StarGrade*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 18 /*ExSkillLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 20 /*PassiveSkillLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 22 /*ExtraPassiveSkillLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*CommonSkillLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*LeaderSkillLevel*/, 4 /*int*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
