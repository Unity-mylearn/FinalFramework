﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FirClient_Manager_SoundManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FirClient.Manager.SoundManager), typeof(FirClient.Manager.BaseManager));
		L.RegFunction("CanPlayBackSound", CanPlayBackSound);
		L.RegFunction("PlayBacksound", PlayBacksound);
		L.RegFunction("CanPlaySoundEffect", CanPlaySoundEffect);
		L.RegFunction("Play", Play);
		L.RegFunction("New", _CreateFirClient_Manager_SoundManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFirClient_Manager_SoundManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FirClient.Manager.SoundManager obj = new FirClient.Manager.SoundManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FirClient.Manager.SoundManager.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanPlayBackSound(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirClient.Manager.SoundManager obj = (FirClient.Manager.SoundManager)ToLua.CheckObject<FirClient.Manager.SoundManager>(L, 1);
			bool o = obj.CanPlayBackSound();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayBacksound(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FirClient.Manager.SoundManager obj = (FirClient.Manager.SoundManager)ToLua.CheckObject<FirClient.Manager.SoundManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			obj.PlayBacksound(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanPlaySoundEffect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FirClient.Manager.SoundManager obj = (FirClient.Manager.SoundManager)ToLua.CheckObject<FirClient.Manager.SoundManager>(L, 1);
			bool o = obj.CanPlaySoundEffect();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FirClient.Manager.SoundManager obj = (FirClient.Manager.SoundManager)ToLua.CheckObject<FirClient.Manager.SoundManager>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.Play(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

