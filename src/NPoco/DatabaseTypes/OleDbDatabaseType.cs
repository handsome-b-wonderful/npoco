namespace NPoco.DatabaseTypes
{
    public class OleDatabaseType : SqlServerDatabaseType
    {
        // V2: review inherited types - some of the more specialized functions may not work for OLE (Access) databases as they are SQL Server implementations. Should be addressed on an "as-needed" basis

        public override string GetProviderName()
        {
            return "System.Data.OleDb";
        }
    }
}