// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::SCHALE.Common.Crypto;
using global::Google.FlatBuffers;

public struct FormationLocationExcelTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static FormationLocationExcelTable GetRootAsFormationLocationExcelTable(ByteBuffer _bb) { return GetRootAsFormationLocationExcelTable(_bb, new FormationLocationExcelTable()); }
  public static FormationLocationExcelTable GetRootAsFormationLocationExcelTable(ByteBuffer _bb, FormationLocationExcelTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public FormationLocationExcelTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public SCHALE.Common.FlatData.FormationLocationExcel? DataList(int j) { int o = __p.__offset(4); return o != 0 ? (SCHALE.Common.FlatData.FormationLocationExcel?)(new SCHALE.Common.FlatData.FormationLocationExcel()).__assign(__p.__indirect(__p.__vector(o) + j * 4), __p.bb) : null; }
  public int DataListLength { get { int o = __p.__offset(4); return o != 0 ? __p.__vector_len(o) : 0; } }

  public static Offset<SCHALE.Common.FlatData.FormationLocationExcelTable> CreateFormationLocationExcelTable(FlatBufferBuilder builder,
      VectorOffset DataListOffset = default(VectorOffset)) {
    builder.StartTable(1);
    FormationLocationExcelTable.AddDataList(builder, DataListOffset);
    return FormationLocationExcelTable.EndFormationLocationExcelTable(builder);
  }

  public static void StartFormationLocationExcelTable(FlatBufferBuilder builder) { builder.StartTable(1); }
  public static void AddDataList(FlatBufferBuilder builder, VectorOffset dataListOffset) { builder.AddOffset(0, dataListOffset.Value, 0); }
  public static VectorOffset CreateDataListVector(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.FormationLocationExcel>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, Offset<SCHALE.Common.FlatData.FormationLocationExcel>[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<SCHALE.Common.FlatData.FormationLocationExcel>> data) { builder.StartVector(4, data.Count, 4); builder.Add(data); return builder.EndVector(); }
  public static VectorOffset CreateDataListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes) { builder.StartVector(1, sizeInBytes, 1); builder.Add<Offset<SCHALE.Common.FlatData.FormationLocationExcel>>(dataPtr, sizeInBytes); return builder.EndVector(); }
  public static void StartDataListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<SCHALE.Common.FlatData.FormationLocationExcelTable> EndFormationLocationExcelTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.FormationLocationExcelTable>(o);
  }
  public FormationLocationExcelTableT UnPack() {
    var _o = new FormationLocationExcelTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(FormationLocationExcelTableT _o) {
		byte[] key = TableEncryptionService.CreateKey("FormationLocationExcel");
    _o.DataList = new List<SCHALE.Common.FlatData.FormationLocationExcelT>();
    for (var _j = 0; _j < this.DataListLength; ++_j) {_o.DataList.Add(this.DataList(_j).HasValue ? this.DataList(_j).Value.UnPack() : null);}
  }
  public static Offset<SCHALE.Common.FlatData.FormationLocationExcelTable> Pack(FlatBufferBuilder builder, FormationLocationExcelTableT _o) {
    if (_o == null) return default(Offset<SCHALE.Common.FlatData.FormationLocationExcelTable>);
    var _DataList = default(VectorOffset);
    if (_o.DataList != null) {
      var __DataList = new Offset<SCHALE.Common.FlatData.FormationLocationExcel>[_o.DataList.Count];
      for (var _j = 0; _j < __DataList.Length; ++_j) { __DataList[_j] = SCHALE.Common.FlatData.FormationLocationExcel.Pack(builder, _o.DataList[_j]); }
      _DataList = CreateDataListVector(builder, __DataList);
    }
    return CreateFormationLocationExcelTable(
      builder,
      _DataList);
  }
}

public class FormationLocationExcelTableT
{
  public List<SCHALE.Common.FlatData.FormationLocationExcelT> DataList { get; set; }

  public FormationLocationExcelTableT() {
    this.DataList = null;
  }
}


static public class FormationLocationExcelTableVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyVectorOfTables(tablePos, 4 /*DataList*/, SCHALE.Common.FlatData.FormationLocationExcelVerify.Verify, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}
