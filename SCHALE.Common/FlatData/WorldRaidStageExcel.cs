// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct WorldRaidStageExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static WorldRaidStageExcel GetRootAsWorldRaidStageExcel(ByteBuffer _bb) { return GetRootAsWorldRaidStageExcel(_bb, new WorldRaidStageExcel()); }
  public static WorldRaidStageExcel GetRootAsWorldRaidStageExcel(ByteBuffer _bb, WorldRaidStageExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public WorldRaidStageExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseBossIndex { get { int o = __p.__offset(6); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool UseBossAIPhaseSync { get { int o = __p.__offset(8); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long WorldRaidBossGroupId { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string PortraitPath { get { int o = __p.__offset(12); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPortraitPathBytes() { return __p.__vector_as_span<byte>(12, 1); }
#else
  public ArraySegment<byte>? GetPortraitPathBytes() { return __p.__vector_as_arraysegment(12); }
#endif
  public byte[] GetPortraitPathArray() { return __p.__vector_as_array<byte>(12); }
  public string BGPath { get { int o = __p.__offset(14); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetBGPathBytes() { return __p.__vector_as_span<byte>(14, 1); }
#else
  public ArraySegment<byte>? GetBGPathBytes() { return __p.__vector_as_arraysegment(14); }
#endif
  public byte[] GetBGPathArray() { return __p.__vector_as_array<byte>(14); }
  public long RaidCharacterId { get { int o = __p.__offset(16); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BossCharacterId(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetLong(__p.__vector(o) + j * 8) : (long)0; }
  public int BossCharacterIdLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<long> GetBossCharacterIdBytes() { return __p.__vector_as_span<long>(18, 8); }
#else
  public ArraySegment<byte>? GetBossCharacterIdBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public long[] GetBossCharacterIdArray() { return __p.__vector_as_array<long>(18); }
  public long AssistCharacterLimitCount { get { int o = __p.__offset(20); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.WorldRaidDifficulty WorldRaidDifficulty { get { int o = __p.__offset(22); return o != 0 ? (SCHALE.Common.FlatData.WorldRaidDifficulty)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.WorldRaidDifficulty.None; } }
  public bool DifficultyOpenCondition { get { int o = __p.__offset(24); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long RaidEnterAmount { get { int o = __p.__offset(26); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ReEnterAmount { get { int o = __p.__offset(28); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long BattleDuration { get { int o = __p.__offset(30); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long GroundId { get { int o = __p.__offset(32); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidBattleEndRewardGroupId { get { int o = __p.__offset(34); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long RaidRewardGroupId { get { int o = __p.__offset(36); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string BattleReadyTimelinePath(int j) { int o = __p.__offset(38); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int BattleReadyTimelinePathLength { get { int o = __p.__offset(38); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int BattleReadyTimelinePhaseStart(int j) { int o = __p.__offset(40); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseStartLength { get { int o = __p.__offset(40); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_span<int>(40, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseStartBytes() { return __p.__vector_as_arraysegment(40); }
#endif
  public int[] GetBattleReadyTimelinePhaseStartArray() { return __p.__vector_as_array<int>(40); }
  public int BattleReadyTimelinePhaseEnd(int j) { int o = __p.__offset(42); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int BattleReadyTimelinePhaseEndLength { get { int o = __p.__offset(42); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_span<int>(42, 4); }
#else
  public ArraySegment<byte>? GetBattleReadyTimelinePhaseEndBytes() { return __p.__vector_as_arraysegment(42); }
#endif
  public int[] GetBattleReadyTimelinePhaseEndArray() { return __p.__vector_as_array<int>(42); }
  public string VictoryTimelinePath { get { int o = __p.__offset(44); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetVictoryTimelinePathBytes() { return __p.__vector_as_span<byte>(44, 1); }
#else
  public ArraySegment<byte>? GetVictoryTimelinePathBytes() { return __p.__vector_as_arraysegment(44); }
#endif
  public byte[] GetVictoryTimelinePathArray() { return __p.__vector_as_array<byte>(44); }
  public string PhaseChangeTimelinePath { get { int o = __p.__offset(46); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_span<byte>(46, 1); }
#else
  public ArraySegment<byte>? GetPhaseChangeTimelinePathBytes() { return __p.__vector_as_arraysegment(46); }
#endif
  public byte[] GetPhaseChangeTimelinePathArray() { return __p.__vector_as_array<byte>(46); }
  public long TimeLinePhase { get { int o = __p.__offset(48); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long EnterScenarioKey { get { int o = __p.__offset(50); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long ClearScenarioKey { get { int o = __p.__offset(52); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool UseFixedEchelon { get { int o = __p.__offset(54); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public long FixedEchelonId { get { int o = __p.__offset(56); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool IsRaidScenarioBattle { get { int o = __p.__offset(58); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool ShowSkillCard { get { int o = __p.__offset(60); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public uint BossBGInfoKey { get { int o = __p.__offset(62); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public long DamageToWorldBoss { get { int o = __p.__offset(64); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public string AllyPassiveSkill(int j) { int o = __p.__offset(66); return o != 0 ? __p.__string(__p.__vector(o) + j * 4) : null; }
  public int AllyPassiveSkillLength { get { int o = __p.__offset(66); return o != 0 ? __p.__vector_len(o) : 0; } }
  public int AllyPassiveSkillLevel(int j) { int o = __p.__offset(68); return o != 0 ? __p.bb.GetInt(__p.__vector(o) + j * 4) : (int)0; }
  public int AllyPassiveSkillLevelLength { get { int o = __p.__offset(68); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<int> GetAllyPassiveSkillLevelBytes() { return __p.__vector_as_span<int>(68, 4); }
#else
  public ArraySegment<byte>? GetAllyPassiveSkillLevelBytes() { return __p.__vector_as_arraysegment(68); }
#endif
  public int[] GetAllyPassiveSkillLevelArray() { return __p.__vector_as_array<int>(68); }
  public bool SaveCurrentLocalBossHP { get { int o = __p.__offset(70); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get { int o = __p.__offset(72); return o != 0 ? (SCHALE.Common.FlatData.EchelonExtensionType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.EchelonExtensionType.Base; } }

  public static Offset<SCHALE.Common.FlatData.WorldRaidStageExcel> CreateWorldRaidStageExcel(FlatBufferBuilder builder,
      long Id = 0,
      bool UseBossIndex = false,
      bool UseBossAIPhaseSync = false,
      long WorldRaidBossGroupId = 0,
      StringOffset PortraitPathOffset = default(StringOffset),
      StringOffset BGPathOffset = default(StringOffset),
      long RaidCharacterId = 0,
      VectorOffset BossCharacterIdOffset = default(VectorOffset),
      long AssistCharacterLimitCount = 0,
      SCHALE.Common.FlatData.WorldRaidDifficulty WorldRaidDifficulty = SCHALE.Common.FlatData.WorldRaidDifficulty.None,
      bool DifficultyOpenCondition = false,
      long RaidEnterAmount = 0,
      long ReEnterAmount = 0,
      long BattleDuration = 0,
      long GroundId = 0,
      long RaidBattleEndRewardGroupId = 0,
      long RaidRewardGroupId = 0,
      VectorOffset BattleReadyTimelinePathOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseStartOffset = default(VectorOffset),
      VectorOffset BattleReadyTimelinePhaseEndOffset = default(VectorOffset),
      StringOffset VictoryTimelinePathOffset = default(StringOffset),
      StringOffset PhaseChangeTimelinePathOffset = default(StringOffset),
      long TimeLinePhase = 0,
      long EnterScenarioKey = 0,
      long ClearScenarioKey = 0,
      bool UseFixedEchelon = false,
      long FixedEchelonId = 0,
      bool IsRaidScenarioBattle = false,
      bool ShowSkillCard = false,
      uint BossBGInfoKey = 0,
      long DamageToWorldBoss = 0,
      VectorOffset AllyPassiveSkillOffset = default(VectorOffset),
      VectorOffset AllyPassiveSkillLevelOffset = default(VectorOffset),
      bool SaveCurrentLocalBossHP = false,
      SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base) {
    builder.StartTable(35);
    WorldRaidStageExcel.AddDamageToWorldBoss(builder, DamageToWorldBoss);
    WorldRaidStageExcel.AddFixedEchelonId(builder, FixedEchelonId);
    WorldRaidStageExcel.AddClearScenarioKey(builder, ClearScenarioKey);
    WorldRaidStageExcel.AddEnterScenarioKey(builder, EnterScenarioKey);
    WorldRaidStageExcel.AddTimeLinePhase(builder, TimeLinePhase);
    WorldRaidStageExcel.AddRaidRewardGroupId(builder, RaidRewardGroupId);
    WorldRaidStageExcel.AddRaidBattleEndRewardGroupId(builder, RaidBattleEndRewardGroupId);
    WorldRaidStageExcel.AddGroundId(builder, GroundId);
    WorldRaidStageExcel.AddBattleDuration(builder, BattleDuration);
    WorldRaidStageExcel.AddReEnterAmount(builder, ReEnterAmount);
    WorldRaidStageExcel.AddRaidEnterAmount(builder, RaidEnterAmount);
    WorldRaidStageExcel.AddAssistCharacterLimitCount(builder, AssistCharacterLimitCount);
    WorldRaidStageExcel.AddRaidCharacterId(builder, RaidCharacterId);
    WorldRaidStageExcel.AddWorldRaidBossGroupId(builder, WorldRaidBossGroupId);
    WorldRaidStageExcel.AddId(builder, Id);
    WorldRaidStageExcel.AddEchelonExtensionType(builder, EchelonExtensionType);
    WorldRaidStageExcel.AddAllyPassiveSkillLevel(builder, AllyPassiveSkillLevelOffset);
    WorldRaidStageExcel.AddAllyPassiveSkill(builder, AllyPassiveSkillOffset);
    WorldRaidStageExcel.AddBossBGInfoKey(builder, BossBGInfoKey);
    WorldRaidStageExcel.AddPhaseChangeTimelinePath(builder, PhaseChangeTimelinePathOffset);
    WorldRaidStageExcel.AddVictoryTimelinePath(builder, VictoryTimelinePathOffset);
    WorldRaidStageExcel.AddBattleReadyTimelinePhaseEnd(builder, BattleReadyTimelinePhaseEndOffset);
    WorldRaidStageExcel.AddBattleReadyTimelinePhaseStart(builder, BattleReadyTimelinePhaseStartOffset);
    WorldRaidStageExcel.AddBattleReadyTimelinePath(builder, BattleReadyTimelinePathOffset);
    WorldRaidStageExcel.AddWorldRaidDifficulty(builder, WorldRaidDifficulty);
    WorldRaidStageExcel.AddBossCharacterId(builder, BossCharacterIdOffset);
    WorldRaidStageExcel.AddBGPath(builder, BGPathOffset);
    WorldRaidStageExcel.AddPortraitPath(builder, PortraitPathOffset);
    WorldRaidStageExcel.AddSaveCurrentLocalBossHP(builder, SaveCurrentLocalBossHP);
    WorldRaidStageExcel.AddShowSkillCard(builder, ShowSkillCard);
    WorldRaidStageExcel.AddIsRaidScenarioBattle(builder, IsRaidScenarioBattle);
    WorldRaidStageExcel.AddUseFixedEchelon(builder, UseFixedEchelon);
    WorldRaidStageExcel.AddDifficultyOpenCondition(builder, DifficultyOpenCondition);
    WorldRaidStageExcel.AddUseBossAIPhaseSync(builder, UseBossAIPhaseSync);
    WorldRaidStageExcel.AddUseBossIndex(builder, UseBossIndex);
    return WorldRaidStageExcel.EndWorldRaidStageExcel(builder);
  }

  public static void StartWorldRaidStageExcel(FlatBufferBuilder builder) { builder.StartTable(35); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddUseBossIndex(FlatBufferBuilder builder, bool useBossIndex) { builder.AddBool(1, useBossIndex, false); }
  public static void AddUseBossAIPhaseSync(FlatBufferBuilder builder, bool useBossAIPhaseSync) { builder.AddBool(2, useBossAIPhaseSync, false); }
  public static void AddWorldRaidBossGroupId(FlatBufferBuilder builder, long worldRaidBossGroupId) { builder.AddLong(3, worldRaidBossGroupId, 0); }
  public static void AddPortraitPath(FlatBufferBuilder builder, StringOffset portraitPathOffset) { builder.AddOffset(4, portraitPathOffset.Value, 0); }
  public static void AddBGPath(FlatBufferBuilder builder, StringOffset bGPathOffset) { builder.AddOffset(5, bGPathOffset.Value, 0); }
  public static void AddRaidCharacterId(FlatBufferBuilder builder, long raidCharacterId) { builder.AddLong(6, raidCharacterId, 0); }
  public static void AddBossCharacterId(FlatBufferBuilder builder, VectorOffset bossCharacterIdOffset) { builder.AddOffset(7, bossCharacterIdOffset.Value, 0); }
  public static VectorOffset CreateBossCharacterIdVector(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); for (int i = data.Length - 1; i >= 0; i--) builder.AddLong(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, long[] data) { builder.StartVector(8, data.Length, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, ArraySegment<long> data) { builder.StartVector(8, data.Count, 8); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBossCharacterIdVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<long>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBossCharacterIdVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(8, numElems, 8); }
  public static void AddAssistCharacterLimitCount(FlatBufferBuilder builder, long assistCharacterLimitCount) { builder.AddLong(8, assistCharacterLimitCount, 0); }
  public static void AddWorldRaidDifficulty(FlatBufferBuilder builder, SCHALE.Common.FlatData.WorldRaidDifficulty worldRaidDifficulty) { builder.AddInt(9, (int)worldRaidDifficulty, 0); }
  public static void AddDifficultyOpenCondition(FlatBufferBuilder builder, bool difficultyOpenCondition) { builder.AddBool(10, difficultyOpenCondition, false); }
  public static void AddRaidEnterAmount(FlatBufferBuilder builder, long raidEnterAmount) { builder.AddLong(11, raidEnterAmount, 0); }
  public static void AddReEnterAmount(FlatBufferBuilder builder, long reEnterAmount) { builder.AddLong(12, reEnterAmount, 0); }
  public static void AddBattleDuration(FlatBufferBuilder builder, long battleDuration) { builder.AddLong(13, battleDuration, 0); }
  public static void AddGroundId(FlatBufferBuilder builder, long groundId) { builder.AddLong(14, groundId, 0); }
  public static void AddRaidBattleEndRewardGroupId(FlatBufferBuilder builder, long raidBattleEndRewardGroupId) { builder.AddLong(15, raidBattleEndRewardGroupId, 0); }
  public static void AddRaidRewardGroupId(FlatBufferBuilder builder, long raidRewardGroupId) { builder.AddLong(16, raidRewardGroupId, 0); }
  public static void AddBattleReadyTimelinePath(FlatBufferBuilder builder, VectorOffset battleReadyTimelinePathOffset) { builder.AddOffset(17, battleReadyTimelinePathOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePathVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePathVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePathVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseStart(FlatBufferBuilder builder, VectorOffset battleReadyTimelinePhaseStartOffset) { builder.AddOffset(18, battleReadyTimelinePhaseStartOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseStartVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseStartVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBattleReadyTimelinePhaseEnd(FlatBufferBuilder builder, VectorOffset battleReadyTimelinePhaseEndOffset) { builder.AddOffset(19, battleReadyTimelinePhaseEndOffset.Value, 0); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateBattleReadyTimelinePhaseEndVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartBattleReadyTimelinePhaseEndVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddVictoryTimelinePath(FlatBufferBuilder builder, StringOffset victoryTimelinePathOffset) { builder.AddOffset(20, victoryTimelinePathOffset.Value, 0); }
  public static void AddPhaseChangeTimelinePath(FlatBufferBuilder builder, StringOffset phaseChangeTimelinePathOffset) { builder.AddOffset(21, phaseChangeTimelinePathOffset.Value, 0); }
  public static void AddTimeLinePhase(FlatBufferBuilder builder, long timeLinePhase) { builder.AddLong(22, timeLinePhase, 0); }
  public static void AddEnterScenarioKey(FlatBufferBuilder builder, long enterScenarioKey) { builder.AddLong(23, enterScenarioKey, 0); }
  public static void AddClearScenarioKey(FlatBufferBuilder builder, long clearScenarioKey) { builder.AddLong(24, clearScenarioKey, 0); }
  public static void AddUseFixedEchelon(FlatBufferBuilder builder, bool useFixedEchelon) { builder.AddBool(25, useFixedEchelon, false); }
  public static void AddFixedEchelonId(FlatBufferBuilder builder, long fixedEchelonId) { builder.AddLong(26, fixedEchelonId, 0); }
  public static void AddIsRaidScenarioBattle(FlatBufferBuilder builder, bool isRaidScenarioBattle) { builder.AddBool(27, isRaidScenarioBattle, false); }
  public static void AddShowSkillCard(FlatBufferBuilder builder, bool showSkillCard) { builder.AddBool(28, showSkillCard, false); }
  public static void AddBossBGInfoKey(FlatBufferBuilder builder, uint bossBGInfoKey) { builder.AddUint(29, bossBGInfoKey, 0); }
  public static void AddDamageToWorldBoss(FlatBufferBuilder builder, long damageToWorldBoss) { builder.AddLong(30, damageToWorldBoss, 0); }
  public static void AddAllyPassiveSkill(FlatBufferBuilder builder, VectorOffset allyPassiveSkillOffset) { builder.AddOffset(31, allyPassiveSkillOffset.Value, 0); }
  public static VectorOffset CreateAllyPassiveSkillVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillVectorBlock(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<StringOffset>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAllyPassiveSkillVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAllyPassiveSkillLevel(FlatBufferBuilder builder, VectorOffset allyPassiveSkillLevelOffset) { builder.AddOffset(32, allyPassiveSkillLevelOffset.Value, 0); }
  public static VectorOffset CreateAllyPassiveSkillLevelVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillLevelVectorBlock(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillLevelVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateAllyPassiveSkillLevelVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<int>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartAllyPassiveSkillLevelVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddSaveCurrentLocalBossHP(FlatBufferBuilder builder, bool saveCurrentLocalBossHP) { builder.AddBool(33, saveCurrentLocalBossHP, false); }
  public static void AddEchelonExtensionType(FlatBufferBuilder builder, SCHALE.Common.FlatData.EchelonExtensionType echelonExtensionType) { builder.AddInt(34, (int)echelonExtensionType, 0); }
  public static Offset<SCHALE.Common.FlatData.WorldRaidStageExcel> EndWorldRaidStageExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.WorldRaidStageExcel>(o);
  }
  public WorldRaidStageExcelT UnPack() {
    var _o = new WorldRaidStageExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(WorldRaidStageExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("WorldRaidStage");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.UseBossIndex = TableEncryptionService.Convert(this.UseBossIndex, key);
    _o.UseBossAIPhaseSync = TableEncryptionService.Convert(this.UseBossAIPhaseSync, key);
    _o.WorldRaidBossGroupId = TableEncryptionService.Convert(this.WorldRaidBossGroupId, key);
    _o.PortraitPath = TableEncryptionService.Convert(this.PortraitPath, key);
    _o.BGPath = TableEncryptionService.Convert(this.BGPath, key);
    _o.RaidCharacterId = TableEncryptionService.Convert(this.RaidCharacterId, key);
    _o.BossCharacterId = new List<long>();
    for (var _j = 0; _j < this.BossCharacterIdLength; ++_j) {_o.BossCharacterId.Add(TableEncryptionService.Convert(this.BossCharacterId(_j), key));}
    _o.AssistCharacterLimitCount = TableEncryptionService.Convert(this.AssistCharacterLimitCount, key);
    _o.WorldRaidDifficulty = TableEncryptionService.Convert(this.WorldRaidDifficulty, key);
    _o.DifficultyOpenCondition = TableEncryptionService.Convert(this.DifficultyOpenCondition, key);
    _o.RaidEnterAmount = TableEncryptionService.Convert(this.RaidEnterAmount, key);
    _o.ReEnterAmount = TableEncryptionService.Convert(this.ReEnterAmount, key);
    _o.BattleDuration = TableEncryptionService.Convert(this.BattleDuration, key);
    _o.GroundId = TableEncryptionService.Convert(this.GroundId, key);
    _o.RaidBattleEndRewardGroupId = TableEncryptionService.Convert(this.RaidBattleEndRewardGroupId, key);
    _o.RaidRewardGroupId = TableEncryptionService.Convert(this.RaidRewardGroupId, key);
    _o.BattleReadyTimelinePath = new List<string>();
    for (var _j = 0; _j < this.BattleReadyTimelinePathLength; ++_j) {_o.BattleReadyTimelinePath.Add(TableEncryptionService.Convert(this.BattleReadyTimelinePath(_j), key));}
    _o.BattleReadyTimelinePhaseStart = new List<int>();
    for (var _j = 0; _j < this.BattleReadyTimelinePhaseStartLength; ++_j) {_o.BattleReadyTimelinePhaseStart.Add(TableEncryptionService.Convert(this.BattleReadyTimelinePhaseStart(_j), key));}
    _o.BattleReadyTimelinePhaseEnd = new List<int>();
    for (var _j = 0; _j < this.BattleReadyTimelinePhaseEndLength; ++_j) {_o.BattleReadyTimelinePhaseEnd.Add(TableEncryptionService.Convert(this.BattleReadyTimelinePhaseEnd(_j), key));}
    _o.VictoryTimelinePath = TableEncryptionService.Convert(this.VictoryTimelinePath, key);
    _o.PhaseChangeTimelinePath = TableEncryptionService.Convert(this.PhaseChangeTimelinePath, key);
    _o.TimeLinePhase = TableEncryptionService.Convert(this.TimeLinePhase, key);
    _o.EnterScenarioKey = TableEncryptionService.Convert(this.EnterScenarioKey, key);
    _o.ClearScenarioKey = TableEncryptionService.Convert(this.ClearScenarioKey, key);
    _o.UseFixedEchelon = TableEncryptionService.Convert(this.UseFixedEchelon, key);
    _o.FixedEchelonId = TableEncryptionService.Convert(this.FixedEchelonId, key);
    _o.IsRaidScenarioBattle = TableEncryptionService.Convert(this.IsRaidScenarioBattle, key);
    _o.ShowSkillCard = TableEncryptionService.Convert(this.ShowSkillCard, key);
    _o.BossBGInfoKey = TableEncryptionService.Convert(this.BossBGInfoKey, key);
    _o.DamageToWorldBoss = TableEncryptionService.Convert(this.DamageToWorldBoss, key);
    _o.AllyPassiveSkill = new List<string>();
    for (var _j = 0; _j < this.AllyPassiveSkillLength; ++_j) {_o.AllyPassiveSkill.Add(TableEncryptionService.Convert(this.AllyPassiveSkill(_j), key));}
    _o.AllyPassiveSkillLevel = new List<int>();
    for (var _j = 0; _j < this.AllyPassiveSkillLevelLength; ++_j) {_o.AllyPassiveSkillLevel.Add(TableEncryptionService.Convert(this.AllyPassiveSkillLevel(_j), key));}
    _o.SaveCurrentLocalBossHP = TableEncryptionService.Convert(this.SaveCurrentLocalBossHP, key);
    _o.EchelonExtensionType = TableEncryptionService.Convert(this.EchelonExtensionType, key);
  }
  public static Offset<SCHALE.Common.FlatData.WorldRaidStageExcel> Pack(FlatBufferBuilder builder, WorldRaidStageExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.WorldRaidStageExcel>);
    var _PortraitPath = _o.PortraitPath == null ? default(StringOffset) : builder.CreateString(_o.PortraitPath);
    var _BGPath = _o.BGPath == null ? default(StringOffset) : builder.CreateString(_o.BGPath);
    var _BossCharacterId = default(VectorOffset);
    if (_o.BossCharacterId != null) {
      var __BossCharacterId = _o.BossCharacterId.ToArray();
      _BossCharacterId = CreateBossCharacterIdVector(builder, __BossCharacterId);
    }
    var _BattleReadyTimelinePath = default(VectorOffset);
    if (_o.BattleReadyTimelinePath != null) {
      var __BattleReadyTimelinePath = new StringOffset[_o.BattleReadyTimelinePath.Count];
      for (var _j = 0; _j < __BattleReadyTimelinePath.Length; ++_j) { __BattleReadyTimelinePath[_j] = builder.CreateString(_o.BattleReadyTimelinePath[_j]); }
      _BattleReadyTimelinePath = CreateBattleReadyTimelinePathVector(builder, __BattleReadyTimelinePath);
    }
    var _BattleReadyTimelinePhaseStart = default(VectorOffset);
    if (_o.BattleReadyTimelinePhaseStart != null) {
      var __BattleReadyTimelinePhaseStart = _o.BattleReadyTimelinePhaseStart.ToArray();
      _BattleReadyTimelinePhaseStart = CreateBattleReadyTimelinePhaseStartVector(builder, __BattleReadyTimelinePhaseStart);
    }
    var _BattleReadyTimelinePhaseEnd = default(VectorOffset);
    if (_o.BattleReadyTimelinePhaseEnd != null) {
      var __BattleReadyTimelinePhaseEnd = _o.BattleReadyTimelinePhaseEnd.ToArray();
      _BattleReadyTimelinePhaseEnd = CreateBattleReadyTimelinePhaseEndVector(builder, __BattleReadyTimelinePhaseEnd);
    }
    var _VictoryTimelinePath = _o.VictoryTimelinePath == null ? default(StringOffset) : builder.CreateString(_o.VictoryTimelinePath);
    var _PhaseChangeTimelinePath = _o.PhaseChangeTimelinePath == null ? default(StringOffset) : builder.CreateString(_o.PhaseChangeTimelinePath);
    var _AllyPassiveSkill = default(VectorOffset);
    if (_o.AllyPassiveSkill != null) {
      var __AllyPassiveSkill = new StringOffset[_o.AllyPassiveSkill.Count];
      for (var _j = 0; _j < __AllyPassiveSkill.Length; ++_j) { __AllyPassiveSkill[_j] = builder.CreateString(_o.AllyPassiveSkill[_j]); }
      _AllyPassiveSkill = CreateAllyPassiveSkillVector(builder, __AllyPassiveSkill);
    }
    var _AllyPassiveSkillLevel = default(VectorOffset);
    if (_o.AllyPassiveSkillLevel != null) {
      var __AllyPassiveSkillLevel = _o.AllyPassiveSkillLevel.ToArray();
      _AllyPassiveSkillLevel = CreateAllyPassiveSkillLevelVector(builder, __AllyPassiveSkillLevel);
    }
    return CreateWorldRaidStageExcel(
      builder,
      _o.Id,
      _o.UseBossIndex,
      _o.UseBossAIPhaseSync,
      _o.WorldRaidBossGroupId,
      _PortraitPath,
      _BGPath,
      _o.RaidCharacterId,
      _BossCharacterId,
      _o.AssistCharacterLimitCount,
      _o.WorldRaidDifficulty,
      _o.DifficultyOpenCondition,
      _o.RaidEnterAmount,
      _o.ReEnterAmount,
      _o.BattleDuration,
      _o.GroundId,
      _o.RaidBattleEndRewardGroupId,
      _o.RaidRewardGroupId,
      _BattleReadyTimelinePath,
      _BattleReadyTimelinePhaseStart,
      _BattleReadyTimelinePhaseEnd,
      _VictoryTimelinePath,
      _PhaseChangeTimelinePath,
      _o.TimeLinePhase,
      _o.EnterScenarioKey,
      _o.ClearScenarioKey,
      _o.UseFixedEchelon,
      _o.FixedEchelonId,
      _o.IsRaidScenarioBattle,
      _o.ShowSkillCard,
      _o.BossBGInfoKey,
      _o.DamageToWorldBoss,
      _AllyPassiveSkill,
      _AllyPassiveSkillLevel,
      _o.SaveCurrentLocalBossHP,
      _o.EchelonExtensionType);
  }
}

public class WorldRaidStageExcelT
{
  public long Id { get; set; }
  public bool UseBossIndex { get; set; }
  public bool UseBossAIPhaseSync { get; set; }
  public long WorldRaidBossGroupId { get; set; }
  public string PortraitPath { get; set; }
  public string BGPath { get; set; }
  public long RaidCharacterId { get; set; }
  public List<long> BossCharacterId { get; set; }
  public long AssistCharacterLimitCount { get; set; }
  public SCHALE.Common.FlatData.WorldRaidDifficulty WorldRaidDifficulty { get; set; }
  public bool DifficultyOpenCondition { get; set; }
  public long RaidEnterAmount { get; set; }
  public long ReEnterAmount { get; set; }
  public long BattleDuration { get; set; }
  public long GroundId { get; set; }
  public long RaidBattleEndRewardGroupId { get; set; }
  public long RaidRewardGroupId { get; set; }
  public List<string> BattleReadyTimelinePath { get; set; }
  public List<int> BattleReadyTimelinePhaseStart { get; set; }
  public List<int> BattleReadyTimelinePhaseEnd { get; set; }
  public string VictoryTimelinePath { get; set; }
  public string PhaseChangeTimelinePath { get; set; }
  public long TimeLinePhase { get; set; }
  public long EnterScenarioKey { get; set; }
  public long ClearScenarioKey { get; set; }
  public bool UseFixedEchelon { get; set; }
  public long FixedEchelonId { get; set; }
  public bool IsRaidScenarioBattle { get; set; }
  public bool ShowSkillCard { get; set; }
  public uint BossBGInfoKey { get; set; }
  public long DamageToWorldBoss { get; set; }
  public List<string> AllyPassiveSkill { get; set; }
  public List<int> AllyPassiveSkillLevel { get; set; }
  public bool SaveCurrentLocalBossHP { get; set; }
  public SCHALE.Common.FlatData.EchelonExtensionType EchelonExtensionType { get; set; }

  public WorldRaidStageExcelT() {
    this.Id = 0;
    this.UseBossIndex = false;
    this.UseBossAIPhaseSync = false;
    this.WorldRaidBossGroupId = 0;
    this.PortraitPath = null;
    this.BGPath = null;
    this.RaidCharacterId = 0;
    this.BossCharacterId = null;
    this.AssistCharacterLimitCount = 0;
    this.WorldRaidDifficulty = SCHALE.Common.FlatData.WorldRaidDifficulty.None;
    this.DifficultyOpenCondition = false;
    this.RaidEnterAmount = 0;
    this.ReEnterAmount = 0;
    this.BattleDuration = 0;
    this.GroundId = 0;
    this.RaidBattleEndRewardGroupId = 0;
    this.RaidRewardGroupId = 0;
    this.BattleReadyTimelinePath = null;
    this.BattleReadyTimelinePhaseStart = null;
    this.BattleReadyTimelinePhaseEnd = null;
    this.VictoryTimelinePath = null;
    this.PhaseChangeTimelinePath = null;
    this.TimeLinePhase = 0;
    this.EnterScenarioKey = 0;
    this.ClearScenarioKey = 0;
    this.UseFixedEchelon = false;
    this.FixedEchelonId = 0;
    this.IsRaidScenarioBattle = false;
    this.ShowSkillCard = false;
    this.BossBGInfoKey = 0;
    this.DamageToWorldBoss = 0;
    this.AllyPassiveSkill = null;
    this.AllyPassiveSkillLevel = null;
    this.SaveCurrentLocalBossHP = false;
    this.EchelonExtensionType = SCHALE.Common.FlatData.EchelonExtensionType.Base;
  }
}


static public class WorldRaidStageExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*UseBossIndex*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 8 /*UseBossAIPhaseSync*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 10 /*WorldRaidBossGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyString(tablePos, 12 /*PortraitPath*/, false)
      && verifier.VerifyString(tablePos, 14 /*BGPath*/, false)
      && verifier.VerifyField(tablePos, 16 /*RaidCharacterId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfData(tablePos, 18 /*BossCharacterId*/, 8 /*long*/, false)
      && verifier.VerifyField(tablePos, 20 /*AssistCharacterLimitCount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 22 /*WorldRaidDifficulty*/, 4 /*SCHALE.Common.FlatData.WorldRaidDifficulty*/, 4, false)
      && verifier.VerifyField(tablePos, 24 /*DifficultyOpenCondition*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 26 /*RaidEnterAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 28 /*ReEnterAmount*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 30 /*BattleDuration*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 32 /*GroundId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 34 /*RaidBattleEndRewardGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 36 /*RaidRewardGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfStrings(tablePos, 38 /*BattleReadyTimelinePath*/, false)
      && verifier.VerifyVectorOfData(tablePos, 40 /*BattleReadyTimelinePhaseStart*/, 4 /*int*/, false)
      && verifier.VerifyVectorOfData(tablePos, 42 /*BattleReadyTimelinePhaseEnd*/, 4 /*int*/, false)
      && verifier.VerifyString(tablePos, 44 /*VictoryTimelinePath*/, false)
      && verifier.VerifyString(tablePos, 46 /*PhaseChangeTimelinePath*/, false)
      && verifier.VerifyField(tablePos, 48 /*TimeLinePhase*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 50 /*EnterScenarioKey*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 52 /*ClearScenarioKey*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 54 /*UseFixedEchelon*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 56 /*FixedEchelonId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 58 /*IsRaidScenarioBattle*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 60 /*ShowSkillCard*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 62 /*BossBGInfoKey*/, 4 /*uint*/, 4, false)
      && verifier.VerifyField(tablePos, 64 /*DamageToWorldBoss*/, 8 /*long*/, 8, false)
      && verifier.VerifyVectorOfStrings(tablePos, 66 /*AllyPassiveSkill*/, false)
      && verifier.VerifyVectorOfData(tablePos, 68 /*AllyPassiveSkillLevel*/, 4 /*int*/, false)
      && verifier.VerifyField(tablePos, 70 /*SaveCurrentLocalBossHP*/, 1 /*bool*/, 1, false)
      && verifier.VerifyField(tablePos, 72 /*EchelonExtensionType*/, 4 /*SCHALE.Common.FlatData.EchelonExtensionType*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
