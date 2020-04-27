﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsGrep.Common
{
    public class ExpectsParameterAttribute : Attribute
    {
        #region Properties..
        public bool Value { get; private set; }
        #endregion Properties..

        #region Constructors..
        public ExpectsParameterAttribute(bool value)
        {
            this.Value = value;
        }
        #endregion Constructors..
    }
}
