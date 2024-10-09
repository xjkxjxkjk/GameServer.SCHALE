// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct BuffParticleExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static BuffParticleExcelTable GetRootAsBuffParticleExcelTable(ByteBuffer _bb) { return GetRootAsBuffParticleExcelTable(_bb, new BuffParticleExcelTable()); }
  public static BuffParticleExcelTable GetRootAsBuffParticleExcelTable(ByteBuffer _bb, BuffParticleExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public BuffParticleExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.BuffParticleExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.BuffParticleExcel?)(new SCHALE.Common.FlatData.BuffParticleExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SCHALE.Common.FlatData.BuffParticleExcelTable> CreateBuffParticleExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    BuffParticleExcelTable.AddDataList(builder, DataListOffset);
    return BuffParticleExcelTable.EndBuffParticleExcelTable(builder);
  }

  public static void StartBuffParticleExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.BuffParticleExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.BuffParticleExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.BuffParticleExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.BuffParticleExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.BuffParticleExcelTable> EndBuffParticleExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.BuffParticleExcelTable>(o);
  }
  public BuffParticleExcelTableT UnPack() {
    var _o = new BuffParticleExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(BuffParticleExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("BuffParticleExcel");
    _o.DataList = new List<SCHALE.Common.FlatData.BuffParticleExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<SCHALE.Common.FlatData.BuffParticleExcelTable> Pack(FlatBufferBuilder builder, BuffParticleExcelTableT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.BuffParticleExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<SCHALE.Common.FlatData.BuffParticleExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = SCHALE.Common.FlatData.BuffParticleExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateBuffParticleExcelTable(
      builder,
      _DataList);
  }
}

public class BuffParticleExcelTableT
{
  public List<SCHALE.Common.FlatData.BuffParticleExcelT> DataList { get; set; }

  public BuffParticleExcelTableT() {
    this.DataList = null;
  }
}


static public class BuffParticleExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, SCHALE.Common.FlatData.BuffParticleExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
