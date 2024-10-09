// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct PropMotion : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static PropMotion GetRootAsPropMotion(ByteBuffer _bb) { return GetRootAsPropMotion(_bb, new PropMotion()); }
  public static PropMotion GetRootAsPropMotion(ByteBuffer _bb, PropMotion obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public PropMotion __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Name { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetNameBytes() { return __p.__vector_as_span<byte>(4, 1); }
#else
  public ArraySegment<byte>? GetNameBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetNameArray() { return __p.__vector_as_array<byte>(4); }
  public SCHALE.Common.FlatData.PropVector3? Positions(int j) { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.PropVector3?)(new SCHALE.Common.FlatData.PropVector3()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int PositionsLength { get { int o = __p.__offset(6); return o != 0 ? __p.__vector_len(o) : 0; } }
  public SCHALE.Common.FlatData.PropVector3? Rotations(int j) { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.PropVector3?)(new SCHALE.Common.FlatData.PropVector3()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int RotationsLength { get { int o = __p.__offset(8); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SCHALE.Common.FlatData.PropMotion> CreatePropMotion(FlatBufferBuilder builder,
      StringOffset NameOffset = default(StringOffset),
      VectorOffset PositionsOffset = default(VectorOffset),
      VectorOffset RotationsOffset = default(VectorOffset)) {
    builder.StartTable(3);
    PropMotion.AddRotations(builder, RotationsOffset);
    PropMotion.AddPositions(builder, PositionsOffset);
    PropMotion.AddName(builder, NameOffset);
    return PropMotion.EndPropMotion(builder);
  }

  public static void StartPropMotion(FlatBufferBuilder builder) { builder.StartTable(3); }
  public static void AddName(FlatBufferBuilder builder, StringOffset nameOffset) { builder.AddOffset(0, nameOffset.Value, 0); }
  public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset) { builder.AddOffset(1, positionsOffset.Value, 0); }
  public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.PropVector3>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.PropVector3>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.PropVector3>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreatePositionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.PropVector3>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartPositionsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRotations(FlatBufferBuilder builder, VectorOffset rotationsOffset) { builder.AddOffset(2, rotationsOffset.Value, 0); }
  public static VectorOffset CreateRotationsVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.PropVector3>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateRotationsVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.PropVector3>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotationsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.PropVector3>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateRotationsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.PropVector3>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartRotationsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.PropMotion> EndPropMotion(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.PropMotion>(o);
  }
  public PropMotionT UnPack() {
    var _o = new PropMotionT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(PropMotionT _o) {
		byte[] key = { 0 };
    _o.Name = TableEncryptionService.Convert(this.Name, key);
    _o.Positions = new List<SCHALE.Common.FlatData.PropVector3T>();
    for (var _j = 0; _j < this.PositionsLength; ++_j) {_o.Positions.Add(this.Positions(_j).HasValue ? this.Positions(_j).Value.UnPack() : null);}
    _o.Rotations = new List<SCHALE.Common.FlatData.PropVector3T>();
    for (var _j = 0; _j < this.RotationsLength; ++_j) {_o.Rotations.Add(this.Rotations(_j).HasValue ? this.Rotations(_j).Value.UnPack() : null);}
  }
  public static Offset<SCHALE.Common.FlatData.PropMotion> Pack(FlatBufferBuilder builder, PropMotionT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.PropMotion>);
    var _Name = _o.Name == null ? default(StringOffset) : builder.CreateString(_o.Name);
    var _Positions = default(VectorOffset);
    if (_o.Positions != null) {
      var __Positions = new Offset<SCHALE.Common.FlatData.PropVector3>[_o.Positions.Count];
      for (var _j = 0; _j < __Positions.Length; ++_j) { __Positions[_j] = SCHALE.Common.FlatData.PropVector3.Pack(builder, _o.Positions[_j]); }
      _Positions = CreatePositionsVector(builder, __Positions);
    }
    var _Rotations = default(VectorOffset);
    if (_o.Rotations != null) {
      var __Rotations = new Offset<SCHALE.Common.FlatData.PropVector3>[_o.Rotations.Count];
      for (var _j = 0; _j < __Rotations.Length; ++_j) { __Rotations[_j] = SCHALE.Common.FlatData.PropVector3.Pack(builder, _o.Rotations[_j]); }
      _Rotations = CreateRotationsVector(builder, __Rotations);
    }
    return CreatePropMotion(
      builder,
      _Name,
      _Positions,
      _Rotations);
  }
}

public class PropMotionT
{
  public string Name { get; set; }
  public List<SCHALE.Common.FlatData.PropVector3T> Positions { get; set; }
  public List<SCHALE.Common.FlatData.PropVector3T> Rotations { get; set; }

  public PropMotionT() {
    this.Name = null;
    this.Positions = null;
    this.Rotations = null;
  }
}


static public class PropMotionVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyString(tablePos, 4 /*Name*/, false)
      && verifier.VerifyVectorOfTables(tablePos, 6 /*Positions*/, SCHALE.Common.FlatData.PropVector3Verify.Verify, false)
      && verifier.VerifyVectorOfTables(tablePos, 8 /*Rotations*/, SCHALE.Common.FlatData.PropVector3Verify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
