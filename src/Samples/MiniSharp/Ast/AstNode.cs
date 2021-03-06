﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VBF.MiniSharp.Ast
{
    public abstract class AstNode
    {
        public abstract T Accept<T>(IAstVisitor<T> visitor);
    }
}
