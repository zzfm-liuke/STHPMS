using ServiceStack.OrmLite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using ZZHMHN.IBase.I_Entity;

namespace ZZHMHN.IBase.I_DAL
{
    /// <summary>
    /// 数据层接口统一基类
    /// </summary>
    public interface IRepository : IDisposable
    {
        #region connection
        string ConnectionString { get; }
        IDbConnection OpenDbConnection();
        void CloseConnection();

        string GetLastSql();
        long LastInsertId();
        #endregion

        #region insert
        long Insert<T>(T obj, bool selectIdentity = false) where T : IEntity;
        void InsertAll<T>(IEnumerable<T> objs) where T : IEntity;

        #endregion

        #region update
        int Update<T>(T obj) where T : IEntity;
        int UpdateAll<T>(IEnumerable<T> objs) where T : IEntity;
        int Update<T>(T item, Expression<Func<T, bool>> where) where T : IEntity;

        int Update<T>(object updateOnly, Expression<Func<T, bool>> where = null) where T : class ,IEntity;

        #endregion

        #region delete
        int Delete<T>(object anonFilter) where T : IEntity;
        int Delete<T>(T allFieldsFilter) where T : IEntity;
        int DeleteAll<T>() where T : IEntity;
        int DeleteById<T>(object id) where T : IEntity;
        int DeleteByIds<T>(IEnumerable idValues) where T : IEntity;

        #endregion

        #region save
        bool Save<T>(T obj, bool references = false) where T : IEntity;
        int SaveAll<T>(IEnumerable<T> objs) where T : IEntity;

        #endregion

        #region select
        bool Exists<T>(object anonType) where T : IEntity;
        bool Exists<T>(Expression<Func<T, bool>> expression) where T : IEntity;
        long Count<T>() where T : IEntity;
        long Count<T>(Expression<Func<T, bool>> expression) where T : IEntity;
        TKey Scalar<T, TKey>(Expression<Func<T, TKey>> field);
        TKey Scalar<T, TKey>(Expression<Func<T, TKey>> field, Expression<Func<T, bool>> predicate);
        T Single<T>(object anonType) where T : class ,IEntity;
        T Single<T>(Expression<Func<T, bool>> predicate) where T : class ,IEntity;
        T SingleById<T>(object idValue) where T : class ,IEntity;
        List<T> Select<T>() where T : class ,IEntity;
        List<T> SelectByIds<T>(IEnumerable idValues) where T : class ,IEntity;
        List<T> Select<T>(Expression<Func<T, bool>> predicate) where T : class ,IEntity;

        #endregion

        #region SqlExpression
        bool Exists<T>(SqlExpression<T> expression) where T : IEntity;
        bool Exists<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : IEntity;
        long Count<T>(SqlExpression<T> expression) where T : IEntity;
        long Count<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : IEntity;
        T Scalar<T>(ISqlExpression sqlExpression) where T : class ,IEntity;
        T Single<T>(SqlExpression<T> expression) where T : class ,IEntity;
        T Single<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : class ,IEntity;
        List<T> Select<T>(SqlExpression<T> expression) where T : class ,IEntity;
        List<T> Select<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : class ,IEntity;
        List<T> Select<T>(ISqlExpression expression, object anonType = null) where T : class ,IEntity;
        Dictionary<K, List<V>> Lookup<K, V>(ISqlExpression sqlExpression);
        Dictionary<K, V> Dictionary<K, V>(ISqlExpression query);
        List<T> Column<T>(ISqlExpression query);
        HashSet<T> ColumnDistinct<T>(ISqlExpression query);

        SqlExpression<T> From<T>();
        SqlExpression<T> From<T, JoinWith>(Expression<Func<T, JoinWith, bool>> joinExpr = null);
        SqlExpression<T> From<T>(string fromExpression);
        #endregion


    }
}
