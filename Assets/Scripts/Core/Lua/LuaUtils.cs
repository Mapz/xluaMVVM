using XLua;

namespace Mapz.Core.Lua
{
    /// <summary>
    /// 对Xlua进行扩展
    /// </summary>
    public static class XLuaExtentions
    {
        /// <summary>
        /// 调用LuaTable中 以点(.) 定义的某一个方法.(首参数不传入LuaTable自身)
        /// 注意:调用不缓存Delegate,适用于一次性调用.
        /// </summary>
        public static object[] Call(this LuaTable _luaTable, string _funName, params object[] _args)
        {
            return _luaTable.GetInPath<LuaFunction>(_funName).Call(_args);
        }

        /// <summary>
        /// 调用LuaTable中 以冒号(:) 定义的某一个方法.(首参数传入LuaTable自身)
        /// 注意:调用不缓存Delegate,适用于一次性调用.
        /// </summary>
        public static object[] CallSelf(this LuaTable _luaTable, string _funName, params object[] _args)
        {
            if (_args != null && _args.Length > 0)
            {
                var newArgs = new object[_args.Length + 1];
                newArgs[0] = _luaTable;
                for (var i = 0; i < _args.Length; i++)
                {
                    newArgs[i + 1] = _args[i];
                }

                return _luaTable.GetInPath<LuaFunction>(_funName).Call(newArgs);
            }
            else
            {
                return _luaTable.GetInPath<LuaFunction>(_funName).Call(_luaTable);
            }
        }

        /// <summary>
        /// 返回Lua函数,适用于需要多次调用的情况
        /// </summary>
        public static LuaFunction GetFun(this LuaTable _luaTable, string _funName)
        {
            return _luaTable.GetInPath<LuaFunction>(_funName);
        }
    }
}