﻿namespace AtlusScriptLib.FlowScriptLanguage.Syntax
{
    public class SubtractionOperator : BinaryExpression, IOperator
    {
        public int Precedence => 6;

        public SubtractionOperator() : base( ValueKind.Unresolved )
        {
        }

        public SubtractionOperator( Expression left, Expression right )
            : base( ValueKind.Bool, left, right )
        {

        }

        public override string ToString()
        {
            return $"({Left}) - ({Right})";
        }
    }
}
