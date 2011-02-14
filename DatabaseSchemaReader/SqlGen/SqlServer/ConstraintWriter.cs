﻿using DatabaseSchemaReader.DataSchema;

namespace DatabaseSchemaReader.SqlGen.SqlServer
{
    class ConstraintWriter : ConstraintWriterBase
    {
        public ConstraintWriter(DatabaseTable table)
            : base(table)
        {
        }

        #region Overrides of ConstraintWriterBase

        protected override ISqlFormatProvider SqlFormatProvider()
        {
            return new SqlFormatProvider();
        }

        #endregion

    }
}
