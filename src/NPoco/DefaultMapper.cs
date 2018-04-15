using System;
using System.Reflection;

namespace NPoco
{
    public abstract class DefaultMapper : IMapper
    {
        public virtual void GetTableInfo(Type t, TableInfo ti) { }
 
        public virtual bool MapMemberToColumn(MemberInfo pi, ref string columnName, ref bool resultColumn)
        {
            return true;
        }

        public virtual Func<object, object> GetFromDbConverter(MemberInfo destMemberInfo, Type sourceType)
        {
            var type = destMemberInfo.GetMemberInfoType();
            return destMemberInfo != null ? GetFromDbConverter(type, sourceType) : null;
        }

        public virtual Func<object, object> GetFromDbConverter(Type destType, Type sourceType)
        {
            return null;
        }

        public virtual Func<object, object> GetToDbConverter(Type destType, MemberInfo sourceMemberInfo)
        {
            var type = sourceMemberInfo.GetMemberInfoType();
            return sourceMemberInfo != null ? GetToDbConverter(destType, type) : null;
        }

        public virtual Func<object, object> GetToDbConverter(Type destType, Type sourceType)
        {
            return null;
        }

        public virtual Func<object, object> GetParameterConverter(Type sourceType)
        {
            return null;
        }


        public virtual bool OnInserting(Database database, InsertContext insertContext)
        {
            return true;
        }

        public virtual bool OnInserted(Database database, InsertContext insertContext)
        {
            return true;
        }

        public virtual bool OnUpdating(Database database, UpdateContext updateContext)
        {
            return true;
        }

        public virtual bool OnUpdated(Database database, UpdateContext updateContext)
        {
             return true;
        }

        public virtual bool OnDeleting(Database database, DeleteContext deleteContext)
        {
            return true;
        }

        public virtual bool OnDeleted(Database database, DeleteContext deleteContext)
        {
            return true;
        }
    }
}