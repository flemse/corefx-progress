﻿namespace System.Reflection {
  public enum CallingConventions {
    Any = 3,
    ExplicitThis = 64,
    HasThis = 32,
    Standard = 1,
    VarArgs = 2,
  }
  public enum EventAttributes {
    None = 0,
    RTSpecialName = 1024,
    SpecialName = 512,
  }
  public enum FieldAttributes {
    Assembly = 3,
    FamANDAssem = 2,
    Family = 4,
    FamORAssem = 5,
    FieldAccessMask = 7,
    HasDefault = 32768,
    HasFieldMarshal = 4096,
    HasFieldRVA = 256,
    InitOnly = 32,
    Literal = 64,
    NotSerialized = 128,
    PinvokeImpl = 8192,
    Private = 1,
    PrivateScope = 0,
    Public = 6,
    RTSpecialName = 1024,
    SpecialName = 512,
    Static = 16,
  }
  public enum GenericParameterAttributes {
    Contravariant = 2,
    Covariant = 1,
    DefaultConstructorConstraint = 16,
    None = 0,
    NotNullableValueTypeConstraint = 8,
    ReferenceTypeConstraint = 4,
    SpecialConstraintMask = 28,
    VarianceMask = 3,
  }
  public enum MethodAttributes {
    Abstract = 1024,
    Assembly = 3,
    CheckAccessOnOverride = 512,
    FamANDAssem = 2,
    Family = 4,
    FamORAssem = 5,
    Final = 32,
    HasSecurity = 16384,
    HideBySig = 128,
    MemberAccessMask = 7,
    NewSlot = 256,
    PinvokeImpl = 8192,
    Private = 1,
    PrivateScope = 0,
    Public = 6,
    RequireSecObject = 32768,
    ReuseSlot = 0,
    RTSpecialName = 4096,
    SpecialName = 2048,
    Static = 16,
    UnmanagedExport = 8,
    Virtual = 64,
    VtableLayoutMask = 256,
  }
  public enum MethodImplAttributes {
    AggressiveInlining = 256,
    CodeTypeMask = 3,
    ForwardRef = 16,
    IL = 0,
    InternalCall = 4096,
    Managed = 0,
    ManagedMask = 4,
    Native = 1,
    NoInlining = 8,
    NoOptimization = 64,
    OPTIL = 2,
    PreserveSig = 128,
    Runtime = 3,
    Synchronized = 32,
    Unmanaged = 4,
  }
  public enum ParameterAttributes {
    HasDefault = 4096,
    HasFieldMarshal = 8192,
    In = 1,
    Lcid = 4,
    None = 0,
    Optional = 16,
    Out = 2,
    Retval = 8,
  }
  public enum PropertyAttributes {
    HasDefault = 4096,
    None = 0,
    RTSpecialName = 1024,
    SpecialName = 512,
  }
  public enum TypeAttributes {
    Abstract = 128,
    AnsiClass = 0,
    AutoClass = 131072,
    AutoLayout = 0,
    BeforeFieldInit = 1048576,
    Class = 0,
    ClassSemanticsMask = 32,
    CustomFormatClass = 196608,
    CustomFormatMask = 12582912,
    ExplicitLayout = 16,
    HasSecurity = 262144,
    Import = 4096,
    Interface = 32,
    LayoutMask = 24,
    NestedAssembly = 5,
    NestedFamANDAssem = 6,
    NestedFamily = 4,
    NestedFamORAssem = 7,
    NestedPrivate = 3,
    NestedPublic = 2,
    NotPublic = 0,
    Public = 1,
    RTSpecialName = 2048,
    Sealed = 256,
    SequentialLayout = 8,
    Serializable = 8192,
    SpecialName = 1024,
    StringFormatMask = 196608,
    UnicodeClass = 65536,
    VisibilityMask = 7,
    WindowsRuntime = 16384,
  }
}
namespace System.Reflection.Emit {
  public enum FlowControl {
    Branch = 0,
    Break = 1,
    Call = 2,
    Cond_Branch = 3,
    Meta = 4,
    Next = 5,
    Return = 7,
    Throw = 8,
  }
  [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
  public struct OpCode {
    public FlowControl FlowControl { get; }
    public string Name { get; }
    public OpCodeType OpCodeType { get; }
    public OperandType OperandType { get; }
    public int Size { get; }
    public StackBehaviour StackBehaviourPop { get; }
    public StackBehaviour StackBehaviourPush { get; }
    public short Value { get; }
    public override bool Equals(object obj);
    public bool Equals(OpCode obj);
    public override int GetHashCode();
    public static bool operator ==(OpCode a, OpCode b);
    public static bool operator !=(OpCode a, OpCode b);
    public override string ToString();
  }
  public class OpCodes {
    public static readonly OpCode Add;
    public static readonly OpCode Add_Ovf;
    public static readonly OpCode Add_Ovf_Un;
    public static readonly OpCode And;
    public static readonly OpCode Arglist;
    public static readonly OpCode Beq;
    public static readonly OpCode Beq_S;
    public static readonly OpCode Bge;
    public static readonly OpCode Bge_S;
    public static readonly OpCode Bge_Un;
    public static readonly OpCode Bge_Un_S;
    public static readonly OpCode Bgt;
    public static readonly OpCode Bgt_S;
    public static readonly OpCode Bgt_Un;
    public static readonly OpCode Bgt_Un_S;
    public static readonly OpCode Ble;
    public static readonly OpCode Ble_S;
    public static readonly OpCode Ble_Un;
    public static readonly OpCode Ble_Un_S;
    public static readonly OpCode Blt;
    public static readonly OpCode Blt_S;
    public static readonly OpCode Blt_Un;
    public static readonly OpCode Blt_Un_S;
    public static readonly OpCode Bne_Un;
    public static readonly OpCode Bne_Un_S;
    public static readonly OpCode Box;
    public static readonly OpCode Br;
    public static readonly OpCode Br_S;
    public static readonly OpCode Break;
    public static readonly OpCode Brfalse;
    public static readonly OpCode Brfalse_S;
    public static readonly OpCode Brtrue;
    public static readonly OpCode Brtrue_S;
    public static readonly OpCode Call;
    public static readonly OpCode Calli;
    public static readonly OpCode Callvirt;
    public static readonly OpCode Castclass;
    public static readonly OpCode Ceq;
    public static readonly OpCode Cgt;
    public static readonly OpCode Cgt_Un;
    public static readonly OpCode Ckfinite;
    public static readonly OpCode Clt;
    public static readonly OpCode Clt_Un;
    public static readonly OpCode Constrained;
    public static readonly OpCode Conv_I;
    public static readonly OpCode Conv_I1;
    public static readonly OpCode Conv_I2;
    public static readonly OpCode Conv_I4;
    public static readonly OpCode Conv_I8;
    public static readonly OpCode Conv_Ovf_I;
    public static readonly OpCode Conv_Ovf_I_Un;
    public static readonly OpCode Conv_Ovf_I1;
    public static readonly OpCode Conv_Ovf_I1_Un;
    public static readonly OpCode Conv_Ovf_I2;
    public static readonly OpCode Conv_Ovf_I2_Un;
    public static readonly OpCode Conv_Ovf_I4;
    public static readonly OpCode Conv_Ovf_I4_Un;
    public static readonly OpCode Conv_Ovf_I8;
    public static readonly OpCode Conv_Ovf_I8_Un;
    public static readonly OpCode Conv_Ovf_U;
    public static readonly OpCode Conv_Ovf_U_Un;
    public static readonly OpCode Conv_Ovf_U1;
    public static readonly OpCode Conv_Ovf_U1_Un;
    public static readonly OpCode Conv_Ovf_U2;
    public static readonly OpCode Conv_Ovf_U2_Un;
    public static readonly OpCode Conv_Ovf_U4;
    public static readonly OpCode Conv_Ovf_U4_Un;
    public static readonly OpCode Conv_Ovf_U8;
    public static readonly OpCode Conv_Ovf_U8_Un;
    public static readonly OpCode Conv_R_Un;
    public static readonly OpCode Conv_R4;
    public static readonly OpCode Conv_R8;
    public static readonly OpCode Conv_U;
    public static readonly OpCode Conv_U1;
    public static readonly OpCode Conv_U2;
    public static readonly OpCode Conv_U4;
    public static readonly OpCode Conv_U8;
    public static readonly OpCode Cpblk;
    public static readonly OpCode Cpobj;
    public static readonly OpCode Div;
    public static readonly OpCode Div_Un;
    public static readonly OpCode Dup;
    public static readonly OpCode Endfilter;
    public static readonly OpCode Endfinally;
    public static readonly OpCode Initblk;
    public static readonly OpCode Initobj;
    public static readonly OpCode Isinst;
    public static readonly OpCode Jmp;
    public static readonly OpCode Ldarg;
    public static readonly OpCode Ldarg_0;
    public static readonly OpCode Ldarg_1;
    public static readonly OpCode Ldarg_2;
    public static readonly OpCode Ldarg_3;
    public static readonly OpCode Ldarg_S;
    public static readonly OpCode Ldarga;
    public static readonly OpCode Ldarga_S;
    public static readonly OpCode Ldc_I4;
    public static readonly OpCode Ldc_I4_0;
    public static readonly OpCode Ldc_I4_1;
    public static readonly OpCode Ldc_I4_2;
    public static readonly OpCode Ldc_I4_3;
    public static readonly OpCode Ldc_I4_4;
    public static readonly OpCode Ldc_I4_5;
    public static readonly OpCode Ldc_I4_6;
    public static readonly OpCode Ldc_I4_7;
    public static readonly OpCode Ldc_I4_8;
    public static readonly OpCode Ldc_I4_M1;
    public static readonly OpCode Ldc_I4_S;
    public static readonly OpCode Ldc_I8;
    public static readonly OpCode Ldc_R4;
    public static readonly OpCode Ldc_R8;
    public static readonly OpCode Ldelem;
    public static readonly OpCode Ldelem_I;
    public static readonly OpCode Ldelem_I1;
    public static readonly OpCode Ldelem_I2;
    public static readonly OpCode Ldelem_I4;
    public static readonly OpCode Ldelem_I8;
    public static readonly OpCode Ldelem_R4;
    public static readonly OpCode Ldelem_R8;
    public static readonly OpCode Ldelem_Ref;
    public static readonly OpCode Ldelem_U1;
    public static readonly OpCode Ldelem_U2;
    public static readonly OpCode Ldelem_U4;
    public static readonly OpCode Ldelema;
    public static readonly OpCode Ldfld;
    public static readonly OpCode Ldflda;
    public static readonly OpCode Ldftn;
    public static readonly OpCode Ldind_I;
    public static readonly OpCode Ldind_I1;
    public static readonly OpCode Ldind_I2;
    public static readonly OpCode Ldind_I4;
    public static readonly OpCode Ldind_I8;
    public static readonly OpCode Ldind_R4;
    public static readonly OpCode Ldind_R8;
    public static readonly OpCode Ldind_Ref;
    public static readonly OpCode Ldind_U1;
    public static readonly OpCode Ldind_U2;
    public static readonly OpCode Ldind_U4;
    public static readonly OpCode Ldlen;
    public static readonly OpCode Ldloc;
    public static readonly OpCode Ldloc_0;
    public static readonly OpCode Ldloc_1;
    public static readonly OpCode Ldloc_2;
    public static readonly OpCode Ldloc_3;
    public static readonly OpCode Ldloc_S;
    public static readonly OpCode Ldloca;
    public static readonly OpCode Ldloca_S;
    public static readonly OpCode Ldnull;
    public static readonly OpCode Ldobj;
    public static readonly OpCode Ldsfld;
    public static readonly OpCode Ldsflda;
    public static readonly OpCode Ldstr;
    public static readonly OpCode Ldtoken;
    public static readonly OpCode Ldvirtftn;
    public static readonly OpCode Leave;
    public static readonly OpCode Leave_S;
    public static readonly OpCode Localloc;
    public static readonly OpCode Mkrefany;
    public static readonly OpCode Mul;
    public static readonly OpCode Mul_Ovf;
    public static readonly OpCode Mul_Ovf_Un;
    public static readonly OpCode Neg;
    public static readonly OpCode Newarr;
    public static readonly OpCode Newobj;
    public static readonly OpCode Nop;
    public static readonly OpCode Not;
    public static readonly OpCode Or;
    public static readonly OpCode Pop;
    public static readonly OpCode Prefix1;
    public static readonly OpCode Prefix2;
    public static readonly OpCode Prefix3;
    public static readonly OpCode Prefix4;
    public static readonly OpCode Prefix5;
    public static readonly OpCode Prefix6;
    public static readonly OpCode Prefix7;
    public static readonly OpCode Prefixref;
    public static readonly OpCode Readonly;
    public static readonly OpCode Refanytype;
    public static readonly OpCode Refanyval;
    public static readonly OpCode Rem;
    public static readonly OpCode Rem_Un;
    public static readonly OpCode Ret;
    public static readonly OpCode Rethrow;
    public static readonly OpCode Shl;
    public static readonly OpCode Shr;
    public static readonly OpCode Shr_Un;
    public static readonly OpCode Sizeof;
    public static readonly OpCode Starg;
    public static readonly OpCode Starg_S;
    public static readonly OpCode Stelem;
    public static readonly OpCode Stelem_I;
    public static readonly OpCode Stelem_I1;
    public static readonly OpCode Stelem_I2;
    public static readonly OpCode Stelem_I4;
    public static readonly OpCode Stelem_I8;
    public static readonly OpCode Stelem_R4;
    public static readonly OpCode Stelem_R8;
    public static readonly OpCode Stelem_Ref;
    public static readonly OpCode Stfld;
    public static readonly OpCode Stind_I;
    public static readonly OpCode Stind_I1;
    public static readonly OpCode Stind_I2;
    public static readonly OpCode Stind_I4;
    public static readonly OpCode Stind_I8;
    public static readonly OpCode Stind_R4;
    public static readonly OpCode Stind_R8;
    public static readonly OpCode Stind_Ref;
    public static readonly OpCode Stloc;
    public static readonly OpCode Stloc_0;
    public static readonly OpCode Stloc_1;
    public static readonly OpCode Stloc_2;
    public static readonly OpCode Stloc_3;
    public static readonly OpCode Stloc_S;
    public static readonly OpCode Stobj;
    public static readonly OpCode Stsfld;
    public static readonly OpCode Sub;
    public static readonly OpCode Sub_Ovf;
    public static readonly OpCode Sub_Ovf_Un;
    public static readonly OpCode Switch;
    public static readonly OpCode Tailcall;
    public static readonly OpCode Throw;
    public static readonly OpCode Unaligned;
    public static readonly OpCode Unbox;
    public static readonly OpCode Unbox_Any;
    public static readonly OpCode Volatile;
    public static readonly OpCode Xor;
    public static bool TakesSingleByteArgument(OpCode inst);
  }
  public enum OpCodeType {
    Macro = 1,
    Nternal = 2,
    Objmodel = 3,
    Prefix = 4,
    Primitive = 5,
  }
  public enum OperandType {
    InlineBrTarget = 0,
    InlineField = 1,
    InlineI = 2,
    InlineI8 = 3,
    InlineMethod = 4,
    InlineNone = 5,
    InlineR = 7,
    InlineSig = 9,
    InlineString = 10,
    InlineSwitch = 11,
    InlineTok = 12,
    InlineType = 13,
    InlineVar = 14,
    ShortInlineBrTarget = 15,
    ShortInlineI = 16,
    ShortInlineR = 17,
    ShortInlineVar = 18,
  }
  public enum PackingSize {
    Size1 = 1,
    Size128 = 128,
    Size16 = 16,
    Size2 = 2,
    Size32 = 32,
    Size4 = 4,
    Size64 = 64,
    Size8 = 8,
    Unspecified = 0,
  }
  public enum StackBehaviour {
    Pop0 = 0,
    Pop1 = 1,
    Pop1_pop1 = 2,
    Popi = 3,
    Popi_pop1 = 4,
    Popi_popi = 5,
    Popi_popi_popi = 7,
    Popi_popi8 = 6,
    Popi_popr4 = 8,
    Popi_popr8 = 9,
    Popref = 10,
    Popref_pop1 = 11,
    Popref_popi = 12,
    Popref_popi_pop1 = 28,
    Popref_popi_popi = 13,
    Popref_popi_popi8 = 14,
    Popref_popi_popr4 = 15,
    Popref_popi_popr8 = 16,
    Popref_popi_popref = 17,
    Push0 = 18,
    Push1 = 19,
    Push1_push1 = 20,
    Pushi = 21,
    Pushi8 = 22,
    Pushr4 = 23,
    Pushr8 = 24,
    Pushref = 25,
    Varpop = 26,
    Varpush = 27,
  }
}
