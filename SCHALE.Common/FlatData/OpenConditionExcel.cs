// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct OpenConditionExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static OpenConditionExcel GetRootAsOpenConditionExcel(ByteBuffer _bb) { return GetRootAsOpenConditionExcel(_bb, new OpenConditionExcel()); }
  public static OpenConditionExcel GetRootAsOpenConditionExcel(ByteBuffer _bb, OpenConditionExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public OpenConditionExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.OpenConditionContent OpenConditionContentType { get { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.OpenConditionContent)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.OpenConditionContent.Shop; } }
  public string LockUI(int j) { int o = __p.__offset(6); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int LockUILength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public long ShortcutPopupPriority { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string ShortcutUIName(int j) { int o = __p.__offset(10); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int ShortcutUINameLength { get { int o = __p.__offset(10); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int ShortcutParam { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public string Scene { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetSceneBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetSceneBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetSceneArray() { return __p.__vector_as_array<byte>(14); }
  public bool HideWhenLocked { get { int o = __p.__offset(16); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long AccountLevel { get { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ScenarioModeId { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CampaignStageId { get { int o = __p.__offset(22); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.MultipleConditionCheckType MultipleConditionCheckType { get { int o = __p.__offset(24); return o != 0 ? (SCHALE.Common.FlatData.MultipleConditionCheckType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.MultipleConditionCheckType.And; } }
  public SCHALE.Common.FlatData.WeekDay OpenDayOfWeek { get { int o = __p.__offset(26); return o != 0 ? (SCHALE.Common.FlatData.WeekDay)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.WeekDay.Sunday; } }
  public long OpenHour { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.WeekDay CloseDayOfWeek { get { int o = __p.__offset(30); return o != 0 ? (SCHALE.Common.FlatData.WeekDay)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.WeekDay.Sunday; } }
  public long CloseHour { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long OpenedCafeId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CafeIdforCafeRank { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long CafeRank { get { int o = __p.__offset(38); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool ContentsOpenShow { get { int o = __p.__offset(40); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public string ContentsOpenShortcutUI { get { int o = __p.__offset(42); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetContentsOpenShortcutUIBytes() { return __p.__vector_as_span<byte>(42, 1); }
#else
  public ArraySegment<byte>? GetContentsOpenShortcutUIBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public byte[] GetContentsOpenShortcutUIArray() { return __p.__vector_as_array<byte>(42); }

  public static Offset<SCHALE.Common.FlatData.OpenConditionExcel> CreateOpenConditionExcel(FlatBufferBuilder builder,
      SCHALE.Common.FlatData.OpenConditionContent OpenConditionContentType = SCHALE.Common.FlatData.OpenConditionContent.Shop,
      VectorOffset LockUIOffset = default(VectorOffset),
      long ShortcutPopupPriority = 0,
      VectorOffset ShortcutUINameOffset = default(VectorOffset),
      int ShortcutParam = 0,
      StringOffset SceneOffset = default(StringOffset),
      bool HideWhenLocked = false,
      long AccountLevel = 0,
      long ScenarioModeId = 0,
      long CampaignStageId = 0,
      SCHALE.Common.FlatData.MultipleConditionCheckType MultipleConditionCheckType = SCHALE.Common.FlatData.MultipleConditionCheckType.And,
      SCHALE.Common.FlatData.WeekDay OpenDayOfWeek = SCHALE.Common.FlatData.WeekDay.Sunday,
      long OpenHour = 0,
      SCHALE.Common.FlatData.WeekDay CloseDayOfWeek = SCHALE.Common.FlatData.WeekDay.Sunday,
      long CloseHour = 0,
      long OpenedCafeId = 0,
      long CafeIdforCafeRank = 0,
      long CafeRank = 0,
      bool ContentsOpenShow = false,
      StringOffset ContentsOpenShortcutUIOffset = default(StringOffset)) {
    builder.StartTable(20);
    OpenConditionExcel.AddCafeRank(builder, CafeRank);
    OpenConditionExcel.AddCafeIdforCafeRank(builder, CafeIdforCafeRank);
    OpenConditionExcel.AddOpenedCafeId(builder, OpenedCafeId);
    OpenConditionExcel.AddCloseHour(builder, CloseHour);
    OpenConditionExcel.AddOpenHour(builder, OpenHour);
    OpenConditionExcel.AddCampaignStageId(builder, CampaignStageId);
    OpenConditionExcel.AddScenarioModeId(builder, ScenarioModeId);
    OpenConditionExcel.AddAccountLevel(builder, AccountLevel);
    OpenConditionExcel.AddShortcutPopupPriority(builder, ShortcutPopupPriority);
    OpenConditionExcel.AddContentsOpenShortcutUI(builder, ContentsOpenShortcutUIOffset);
    OpenConditionExcel.AddCloseDayOfWeek(builder, CloseDayOfWeek);
    OpenConditionExcel.AddOpenDayOfWeek(builder, OpenDayOfWeek);
    OpenConditionExcel.AddMultipleConditionCheckType(builder, MultipleConditionCheckType);
    OpenConditionExcel.AddScene(builder, SceneOffset);
    OpenConditionExcel.AddShortcutParam(builder, ShortcutParam);
    OpenConditionExcel.AddShortcutUIName(builder, ShortcutUINameOffset);
    OpenConditionExcel.AddLockUI(builder, LockUIOffset);
    OpenConditionExcel.AddOpenConditionContentType(builder, OpenConditionContentType);
    OpenConditionExcel.AddContentsOpenShow(builder, ContentsOpenShow);
    OpenConditionExcel.AddHideWhenLocked(builder, HideWhenLocked);
    return OpenConditionExcel.EndOpenConditionExcel(builder);
  }

  public static void StartOpenConditionExcel(FlatBufferBuilder builder) { builder.StartTable(20); }
  public static void AddOpenConditionContentType(FlatBufferBuilder builder, SCHALE.Common.FlatData.OpenConditionContent openConditionContentType) { builder.AddInt(0, (int)openConditionContentType, 0); }
  public static void AddLockUI(FlatBufferBuilder builder, VectorOffset lockUIOffset) { builder.AddOffset(1, lockUIOffset.Value, 0); }
  public static VectorOffset CreateLockUIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateLockUIVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartLockUIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutPopupPriority(FlatBufferBuilder builder, long shortcutPopupPriority) { builder.AddLong(2, shortcutPopupPriority, 0); }
  public static void AddShortcutUIName(FlatBufferBuilder builder, VectorOffset shortcutUINameOffset) { builder.AddOffset(3, shortcutUINameOffset.Value, 0); }
  public static VectorOffset CreateShortcutUINameVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUINameVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUINameVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateShortcutUINameVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartShortcutUINameVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddShortcutParam(FlatBufferBuilder builder, int shortcutParam) { builder.AddInt(4, shortcutParam, 0); }
  public static void AddScene(FlatBufferBuilder builder, StringOffset sceneOffset) { builder.AddOffset(5, sceneOffset.Value, 0); }
  public static void AddHideWhenLocked(FlatBufferBuilder builder, bool hideWhenLocked) { builder.AddBool(6, hideWhenLocked, false); }
  public static void AddAccountLevel(FlatBufferBuilder builder, long accountLevel) { builder.AddLong(7, accountLevel, 0); }
  public static void AddScenarioModeId(FlatBufferBuilder builder, long scenarioModeId) { builder.AddLong(8, scenarioModeId, 0); }
  public static void AddCampaignStageId(FlatBufferBuilder builder, long campaignStageId) { builder.AddLong(9, campaignStageId, 0); }
  public static void AddMultipleConditionCheckType(FlatBufferBuilder builder, SCHALE.Common.FlatData.MultipleConditionCheckType multipleConditionCheckType) { builder.AddInt(10, (int)multipleConditionCheckType, 0); }
  public static void AddOpenDayOfWeek(FlatBufferBuilder builder, SCHALE.Common.FlatData.WeekDay openDayOfWeek) { builder.AddInt(11, (int)openDayOfWeek, 0); }
  public static void AddOpenHour(FlatBufferBuilder builder, long openHour) { builder.AddLong(12, openHour, 0); }
  public static void AddCloseDayOfWeek(FlatBufferBuilder builder, SCHALE.Common.FlatData.WeekDay closeDayOfWeek) { builder.AddInt(13, (int)closeDayOfWeek, 0); }
  public static void AddCloseHour(FlatBufferBuilder builder, long closeHour) { builder.AddLong(14, closeHour, 0); }
  public static void AddOpenedCafeId(FlatBufferBuilder builder, long openedCafeId) { builder.AddLong(15, openedCafeId, 0); }
  public static void AddCafeIdforCafeRank(FlatBufferBuilder builder, long cafeIdforCafeRank) { builder.AddLong(16, cafeIdforCafeRank, 0); }
  public static void AddCafeRank(FlatBufferBuilder builder, long cafeRank) { builder.AddLong(17, cafeRank, 0); }
  public static void AddContentsOpenShow(FlatBufferBuilder builder, bool contentsOpenShow) { builder.AddBool(18, contentsOpenShow, false); }
  public static void AddContentsOpenShortcutUI(FlatBufferBuilder builder, StringOffset contentsOpenShortcutUIOffset) { builder.AddOffset(19, contentsOpenShortcutUIOffset.Value, 0); }
  public static Offset<SCHALE.Common.FlatData.OpenConditionExcel> EndOpenConditionExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.OpenConditionExcel>(o);
  }
  public OpenConditionExcelT UnPack() {
    var _o = new OpenConditionExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(OpenConditionExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("OpenCondition");
    _o.OpenConditionContentType = TableEncryptionService.Convert(this.OpenConditionContentType, key);
    _o.LockUI = new List<string>();
    for (var _j = 0; _j < this.LockUILength; ++_j) {_o.LockUI.Add(TableEncryptionService.Convert(this.LockUI(_j), key));}
    _o.ShortcutPopupPriority = TableEncryptionService.Convert(this.ShortcutPopupPriority, key);
    _o.ShortcutUIName = new List<string>();
    for (var _j = 0; _j < this.ShortcutUINameLength; ++_j) {_o.ShortcutUIName.Add(TableEncryptionService.Convert(this.ShortcutUIName(_j), key));}
    _o.ShortcutParam = TableEncryptionService.Convert(this.ShortcutParam, key);
    _o.Scene = TableEncryptionService.Convert(this.Scene, key);
    _o.HideWhenLocked = TableEncryptionService.Convert(this.HideWhenLocked, key);
    _o.AccountLevel = TableEncryptionService.Convert(this.AccountLevel, key);
    _o.ScenarioModeId = TableEncryptionService.Convert(this.ScenarioModeId, key);
    _o.CampaignStageId = TableEncryptionService.Convert(this.CampaignStageId, key);
    _o.MultipleConditionCheckType = TableEncryptionService.Convert(this.MultipleConditionCheckType, key);
    _o.OpenDayOfWeek = TableEncryptionService.Convert(this.OpenDayOfWeek, key);
    _o.OpenHour = TableEncryptionService.Convert(this.OpenHour, key);
    _o.CloseDayOfWeek = TableEncryptionService.Convert(this.CloseDayOfWeek, key);
    _o.CloseHour = TableEncryptionService.Convert(this.CloseHour, key);
    _o.OpenedCafeId = TableEncryptionService.Convert(this.OpenedCafeId, key);
    _o.CafeIdforCafeRank = TableEncryptionService.Convert(this.CafeIdforCafeRank, key);
    _o.CafeRank = TableEncryptionService.Convert(this.CafeRank, key);
    _o.ContentsOpenShow = TableEncryptionService.Convert(this.ContentsOpenShow, key);
    _o.ContentsOpenShortcutUI = TableEncryptionService.Convert(this.ContentsOpenShortcutUI, key);
  }
  public static Offset<SCHALE.Common.FlatData.OpenConditionExcel> Pack(FlatBufferBuilder builder, OpenConditionExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.OpenConditionExcel>);
    var _LockUI = default(VectorOffset);
    if (_o.LockUI != null) {
      var __LockUI = new StringOffset[_o.LockUI.Count];
      for (var _j = 0; _j < __LockUI.Length; ++_j) { __LockUI[_j] = builder.CreateString(_o.LockUI[_j]); }
      _LockUI = CreateLockUIVector(builder, __LockUI);
    }
    var _ShortcutUIName = default(VectorOffset);
    if (_o.ShortcutUIName != null) {
      var __ShortcutUIName = new StringOffset[_o.ShortcutUIName.Count];
      for (var _j = 0; _j < __ShortcutUIName.Length; ++_j) { __ShortcutUIName[_j] = builder.CreateString(_o.ShortcutUIName[_j]); }
      _ShortcutUIName = CreateShortcutUINameVector(builder, __ShortcutUIName);
    }
    var _Scene = _o.Scene == null ? default(StringOffset) : builder.CreateString(_o.Scene);
    var _ContentsOpenShortcutUI = _o.ContentsOpenShortcutUI == null ? default(StringOffset) : builder.CreateString(_o.ContentsOpenShortcutUI);
    return CreateOpenConditionExcel(
      builder,
      _o.OpenConditionContentType,
      _LockUI,
      _o.ShortcutPopupPriority,
      _ShortcutUIName,
      _o.ShortcutParam,
      _Scene,
      _o.HideWhenLocked,
      _o.AccountLevel,
      _o.ScenarioModeId,
      _o.CampaignStageId,
      _o.MultipleConditionCheckType,
      _o.OpenDayOfWeek,
      _o.OpenHour,
      _o.CloseDayOfWeek,
      _o.CloseHour,
      _o.OpenedCafeId,
      _o.CafeIdforCafeRank,
      _o.CafeRank,
      _o.ContentsOpenShow,
      _ContentsOpenShortcutUI);
  }
}

public class OpenConditionExcelT
{
  public SCHALE.Common.FlatData.OpenConditionContent OpenConditionContentType { get; set; }
  public List<string> LockUI { get; set; }
  public long ShortcutPopupPriority { get; set; }
  public List<string> ShortcutUIName { get; set; }
  public int ShortcutParam { get; set; }
  public string Scene { get; set; }
  public bool HideWhenLocked { get; set; }
  public long AccountLevel { get; set; }
  public long ScenarioModeId { get; set; }
  public long CampaignStageId { get; set; }
  public SCHALE.Common.FlatData.MultipleConditionCheckType MultipleConditionCheckType { get; set; }
  public SCHALE.Common.FlatData.WeekDay OpenDayOfWeek { get; set; }
  public long OpenHour { get; set; }
  public SCHALE.Common.FlatData.WeekDay CloseDayOfWeek { get; set; }
  public long CloseHour { get; set; }
  public long OpenedCafeId { get; set; }
  public long CafeIdforCafeRank { get; set; }
  public long CafeRank { get; set; }
  public bool ContentsOpenShow { get; set; }
  public string ContentsOpenShortcutUI { get; set; }

  public OpenConditionExcelT() {
    this.OpenConditionContentType = SCHALE.Common.FlatData.OpenConditionContent.Shop;
    this.LockUI = null;
    this.ShortcutPopupPriority = 0;
    this.ShortcutUIName = null;
    this.ShortcutParam = 0;
    this.Scene = null;
    this.HideWhenLocked = false;
    this.AccountLevel = 0;
    this.ScenarioModeId = 0;
    this.CampaignStageId = 0;
    this.MultipleConditionCheckType = SCHALE.Common.FlatData.MultipleConditionCheckType.And;
    this.OpenDayOfWeek = SCHALE.Common.FlatData.WeekDay.Sunday;
    this.OpenHour = 0;
    this.CloseDayOfWeek = SCHALE.Common.FlatData.WeekDay.Sunday;
    this.CloseHour = 0;
    this.OpenedCafeId = 0;
    this.CafeIdforCafeRank = 0;
    this.CafeRank = 0;
    this.ContentsOpenShow = false;
    this.ContentsOpenShortcutUI = null;
  }
}


static public class OpenConditionExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*OpenConditionContentType*/, 4 /*SCHALE.Common.FlatData.OpenConditionContent*/, 4, false)
      && verifier.VerifyVectorOfStrings(tablePos, 6 /*LockUI*/, false)
      && verifier.VerifyField(tablePos, 8 /*ShortcutPopupPriority*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfStrings(tablePos, 10 /*ShortcutUIName*/, false)
      && verifier.VerifyField(tablePos, 12 /*ShortcutParam*/, 4 /*int*/, 4, false)
      && verifier.VerifyString(tablePos, 14 /*Scene*/, false)
      && verifier.VerifyField(tablePos, 16 /*HideWhenLocked*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 18 /*AccountLevel*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 20 /*ScenarioModeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*CampaignStageId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 24 /*MultipleConditionCheckType*/, 4 /*SCHALE.Common.FlatData.MultipleConditionCheckType*/, 4, false)
      && verifier.VerifyField(tablePos, 26 /*OpenDayOfWeek*/, 4 /*SCHALE.Common.FlatData.WeekDay*/, 4, false)
      && verifier.VerifyField(tablePos, 28 /*OpenHour*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*CloseDayOfWeek*/, 4 /*SCHALE.Common.FlatData.WeekDay*/, 4, false)
      && verifier.VerifyField(tablePos, 32 /*CloseHour*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*OpenedCafeId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*CafeIdforCafeRank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 38 /*CafeRank*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 40 /*ContentsOpenShow*/, 1 /*bool*/, 1, false)
      && verifier.VerifyString(tablePos, 42 /*ContentsOpenShortcutUI*/, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
