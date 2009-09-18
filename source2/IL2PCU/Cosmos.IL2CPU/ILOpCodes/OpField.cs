﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Cosmos.IL2CPU.ILOpCodes {
  public class OpField : ILOpCode {
    public readonly FieldInfo Value;

    public OpField(Code aOpCode, int aPos, int aNextPos, FieldInfo aValue)
      : base(aOpCode, aPos, aNextPos) {
      Value = aValue;
    }
  }
}
