// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct DefaultFurnitureExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static DefaultFurnitureExcel GetRootAsDefaultFurnitureExcel(ByteBuffer _bb) { return GetRootAsDefaultFurnitureExcel(_bb, new DefaultFurnitureExcel()); }
  public static DefaultFurnitureExcel GetRootAsDefaultFurnitureExcel(ByteBuffer _bb, DefaultFurnitureExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public DefaultFurnitureExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.FurnitureLocation Location { get { int o = __p.__offset(6); return o != 0 ? (SCHALE.Common.FlatData.FurnitureLocation)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.FurnitureLocation.None; } }
  public float PositionX { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float PositionY { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float Rotation { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }

  public static Offset<SCHALE.Common.FlatData.DefaultFurnitureExcel> CreateDefaultFurnitureExcel(FlatBufferBuilder builder,
      long Id = 0,
      SCHALE.Common.FlatData.FurnitureLocation Location = SCHALE.Common.FlatData.FurnitureLocation.None,
      float PositionX = 0.0f,
      float PositionY = 0.0f,
      float Rotation = 0.0f) {
    builder.StartTable(5);
    DefaultFurnitureExcel.AddId(builder, Id);
    DefaultFurnitureExcel.AddRotation(builder, Rotation);
    DefaultFurnitureExcel.AddPositionY(builder, PositionY);
    DefaultFurnitureExcel.AddPositionX(builder, PositionX);
    DefaultFurnitureExcel.AddLocation(builder, Location);
    return DefaultFurnitureExcel.EndDefaultFurnitureExcel(builder);
  }

  public static void StartDefaultFurnitureExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddLocation(FlatBufferBuilder builder, SCHALE.Common.FlatData.FurnitureLocation location) { builder.AddInt(1, (int)location, 0); }
  public static void AddPositionX(FlatBufferBuilder builder, float positionX) { builder.AddFloat(2, positionX, 0.0f); }
  public static void AddPositionY(FlatBufferBuilder builder, float positionY) { builder.AddFloat(3, positionY, 0.0f); }
  public static void AddRotation(FlatBufferBuilder builder, float rotation) { builder.AddFloat(4, rotation, 0.0f); }
  public static Offset<SCHALE.Common.FlatData.DefaultFurnitureExcel> EndDefaultFurnitureExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.DefaultFurnitureExcel>(o);
  }
  public DefaultFurnitureExcelT UnPack() {
    var _o = new DefaultFurnitureExcelT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(DefaultFurnitureExcelT _o) {
		byte[] key = TableEncryptionService.CreateKey("DefaultFurniture");
    _o.Id = TableEncryptionService.Convert(this.Id, key);
    _o.Location = TableEncryptionService.Convert(this.Location, key);
    _o.PositionX = TableEncryptionService.Convert(this.PositionX, key);
    _o.PositionY = TableEncryptionService.Convert(this.PositionY, key);
    _o.Rotation = TableEncryptionService.Convert(this.Rotation, key);
  }
  public static Offset<SCHALE.Common.FlatData.DefaultFurnitureExcel> Pack(FlatBufferBuilder builder, DefaultFurnitureExcelT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.DefaultFurnitureExcel>);
    return CreateDefaultFurnitureExcel(
      builder,
      _o.Id,
      _o.Location,
      _o.PositionX,
      _o.PositionY,
      _o.Rotation);
  }
}

public class DefaultFurnitureExcelT
{
  public long Id { get; set; }
  public SCHALE.Common.FlatData.FurnitureLocation Location { get; set; }
  public float PositionX { get; set; }
  public float PositionY { get; set; }
  public float Rotation { get; set; }

  public DefaultFurnitureExcelT() {
    this.Id = 0;
    this.Location = SCHALE.Common.FlatData.FurnitureLocation.None;
    this.PositionX = 0.0f;
    this.PositionY = 0.0f;
    this.Rotation = 0.0f;
  }
}


static public class DefaultFurnitureExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Location*/, 4 /*SCHALE.Common.FlatData.FurnitureLocation*/, 4, false)
      && verifier.VerifyField(tablePos, 8 /*PositionX*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*PositionY*/, 4 /*float*/, 4, false)
      && verifier.VerifyField(tablePos, 12 /*Rotation*/, 4 /*float*/, 4, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
