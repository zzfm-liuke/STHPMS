using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using ZZHMHN.IBase.I_DAL;
using ZZHMHN.IBase.I_Entity;
using ServiceStack;
using System.Data;
using System.Linq.Expressions;
using System.Collections;
using ZZHMHN.IBase.Common;

namespace ZZHMHN.DAL.Core
{
    /// <summary>
    /// 数据层接口统一基类
    /// </summary>
    public class Repository: DisposeObject, IRepository
    {
        public Repository(string connectionString,bool openConnection=true)
        {
            ConnectionString = connectionString.Fmt(Environment.GetEnvironmentVariable("CI_HOST"));
            if (openConnection)
                OpenDbConnection();
        }
        protected override void OnDispose()
        {
            CloseConnection();
            ConnectionString = null;
            base.OnDispose();
        }

        #region connection
        public string ConnectionString
        {
            get;
            private set;
        }

        private IDbConnection _conn;

        public IDbConnection OpenDbConnection()
        {
            if(_conn==null)
            {
                OrmLiteConnectionFactory factory = new OrmLiteConnectionFactory(ConnectionString, SqlServerDialect.Provider);
                _conn=factory.OpenDbConnection();            
            }
            return _conn;
        }

        public void CloseConnection()
        {
            if (_conn != null)
            {
                _conn.Close();
                _conn = null;
            }
        }

        public string GetLastSql()
        {
            return _conn.GetLastSql();
        }
        public long LastInsertId()
        {
            return _conn.LastInsertId();
        }
        #endregion


        #region Insert
        public long Insert<T>(T obj, bool selectIdentity = false) 
            where T : IEntity
        {
            return _conn.Insert(obj, selectIdentity);
        }
        public void InsertAll<T>(IEnumerable<T> objs) 
            where T : IEntity
        {
            _conn.InsertAll(objs);
        }

        #endregion
        
        #region Update
        
        public int Update<T>(T obj) where T : IEntity
        {
            return _conn.Update(obj);
        }
        public int UpdateAll<T>(IEnumerable<T> objs) where T : IEntity
        {
            return _conn.UpdateAll(objs);
        }

        public int Update<T>(T item, Expression<Func<T, bool>> where) where T : IEntity
        {
            return _conn.Update(item,where);
        }

        public int Update<T>(object updateOnly, Expression<Func<T, bool>> where = null) where T : class ,IEntity
        {
            return _conn.Update(updateOnly, where);
        }
        #endregion

        #region Delete
        
        public int Delete<T>(object anonFilter) where T : IEntity
        {
            return _conn.Delete<T>(anonFilter);
        }
        public int Delete<T>(T allFieldsFilter) where T : IEntity
        {
            return _conn.Delete(allFieldsFilter);
        }
        public int DeleteAll<T>() where T : IEntity
        {
            return _conn.DeleteAll<T>();
        }
        public int DeleteById<T>(object id) where T : IEntity
        {
            return _conn.DeleteById<T>(id);
        }
        public int DeleteByIds<T>(IEnumerable idValues) where T : IEntity
        {
            return _conn.DeleteByIds<T>(idValues);
        }
        #endregion

        #region Save
        
        public bool Save<T>(T obj, bool references = false) where T : IEntity
        {
            return _conn.Save(obj, references);
        }
        public int SaveAll<T>(IEnumerable<T> objs) where T : IEntity
        {
            return _conn.SaveAll(objs);
        }
        #endregion

        #region Select
        public bool Exists<T>(object anonType) where T : IEntity
        {
            return _conn.Exists<T>(anonType);
        }
        public bool Exists<T>(Expression<Func<T, bool>> expression) where T : IEntity
        {
            return _conn.Exists(expression);
        }
        public long Count<T>() where T : IEntity
        {
            return _conn.Count<T>();
        }
        public long Count<T>(Expression<Func<T, bool>> expression) where T : IEntity
        {
            return _conn.Count(expression);
        }
        public TKey Scalar<T, TKey>(Expression<Func<T, TKey>> field)
        {
            return _conn.Scalar(field);
        }
        public TKey Scalar<T, TKey>(Expression<Func<T, TKey>> field, Expression<Func<T, bool>> predicate)
        {
            return _conn.Scalar(field, predicate);
        }
        public T Single<T>(object anonType) where T : class ,IEntity
        {
            return _conn.Single<T>(anonType);
        }
        public T Single<T>(Expression<Func<T, bool>> predicate) where T : class ,IEntity
        {
            return _conn.Single(predicate);
        }
        public T SingleById<T>(object idValue) where T : class ,IEntity
        {
            return _conn.SingleById<T>(idValue);
        }
        public List<T> Select<T>() where T : class ,IEntity
        {
            return _conn.Select<T>();
        }
        public List<T> SelectByIds<T>(IEnumerable idValues) where T : class ,IEntity
        {
            return _conn.SelectByIds<T>(idValues);
        }
        public List<T> Select<T>(Expression<Func<T, bool>> predicate) where T : class ,IEntity
        {
            return _conn.Select(predicate);
        }
        #endregion

        #region SqlExpression
        public bool Exists<T>(SqlExpression<T> expression) where T : IEntity
        {
            return _conn.Exists(expression);
        }
        public bool Exists<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : IEntity
        {
            return _conn.Exists(expression);
        }
        public long Count<T>(SqlExpression<T> expression) where T : IEntity
        {
            return _conn.Count(expression);
        }
        public long Count<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : IEntity
        {
            return _conn.Count(expression);
        }
        public T Scalar<T>(ISqlExpression sqlExpression) where T : class ,IEntity
        {
            return _conn.Scalar<T>(sqlExpression);
        }
        public T Single<T>(SqlExpression<T> expression) where T : class ,IEntity
        {
            return _conn.Single(expression);
        }
        public T Single<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : class ,IEntity
        {
            return _conn.Single(expression);
        }
        public List<T> Select<T>(SqlExpression<T> expression) where T : class ,IEntity
        {
            return _conn.Select(expression);
        }
        public List<T> Select<T>(Func<SqlExpression<T>, SqlExpression<T>> expression) where T : class ,IEntity
        {
            return _conn.Select(expression);
        }
        public List<T> Select<T>(ISqlExpression expression, object anonType = null) where T : class ,IEntity
        {
            return _conn.Select<T>(expression, anonType);
        }

        public Dictionary<K, List<V>> Lookup<K, V>(ISqlExpression sqlExpression)
        {
            return _conn.Lookup<K, V>(sqlExpression);
        }
        public Dictionary<K, V> Dictionary<K, V>(ISqlExpression query)
        {
            return _conn.Dictionary<K, V>(query);
        }
        public List<T> Column<T>(ISqlExpression query)
        {
            return _conn.Column<T>(query);
        }
        public HashSet<T> ColumnDistinct<T>(ISqlExpression query)
        {
            return _conn.ColumnDistinct<T>(query);
        }

        public SqlExpression<T> From<T>()
        {
            return _conn.From<T>();
        }
        public SqlExpression<T> From<T, JoinWith>(Expression<Func<T, JoinWith, bool>> joinExpr = null)
        {
            return _conn.From(joinExpr);
        }
        public SqlExpression<T> From<T>(string fromExpression)
        {
            return _conn.From<T>(fromExpression);
        }
        #endregion

       
    }
}
