﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ManagementCenterWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ManagementCenter), typeof(System.Object));
		L.RegFunction("GetManager", GetManager);
		L.RegFunction("GetExtManager", GetExtManager);
		L.RegFunction("New", _CreateManagementCenter);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("managerObject", get_managerObject, null);
		L.RegVar("main", get_main, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateManagementCenter(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				ManagementCenter obj = new ManagementCenter();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: ManagementCenter.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			FirClient.Manager.BaseManager o = ManagementCenter.GetManager(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetExtManager(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			object o = ManagementCenter.GetExtManager(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_managerObject(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, ManagementCenter.managerObject);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_main(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ManagementCenter.main);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

