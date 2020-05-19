﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using DG.Tweening;
using LuaInterface;

public class DG_Tweening_TweenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DG.Tweening.Tweener), typeof(DG.Tweening.Tween));
		L.RegFunction("ChangeStartValue", ChangeStartValue);
		L.RegFunction("ChangeEndValue", ChangeEndValue);
		L.RegFunction("ChangeValues", ChangeValues);
		L.RegFunction("SetSpeedBased", SetSpeedBased);
		L.RegFunction("SetRelative", SetRelative);
		L.RegFunction("SetDelay", SetDelay);
		L.RegFunction("From", From);
		L.RegFunction("SetAs", SetAs);
		L.RegFunction("OnWaypointChange", OnWaypointChange);
		L.RegFunction("OnKill", OnKill);
		L.RegFunction("OnComplete", OnComplete);
		L.RegFunction("OnStepComplete", OnStepComplete);
		L.RegFunction("OnUpdate", OnUpdate);
		L.RegFunction("OnRewind", OnRewind);
		L.RegFunction("OnPause", OnPause);
		L.RegFunction("OnPlay", OnPlay);
		L.RegFunction("OnStart", OnStart);
		L.RegFunction("SetUpdate", SetUpdate);
		L.RegFunction("SetRecyclable", SetRecyclable);
		L.RegFunction("SetEase", SetEase);
		L.RegFunction("SetLoops", SetLoops);
		L.RegFunction("SetTarget", SetTarget);
		L.RegFunction("SetLink", SetLink);
		L.RegFunction("SetId", SetId);
		L.RegFunction("SetAutoKill", SetAutoKill);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeStartValue(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				DG.Tweening.Tweener o = obj.ChangeStartValue(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				DG.Tweening.Tweener o = obj.ChangeStartValue(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.ChangeStartValue");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeEndValue(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				DG.Tweening.Tweener o = obj.ChangeEndValue(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<float>(L, 3))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 3);
				DG.Tweening.Tweener o = obj.ChangeEndValue(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<bool>(L, 3))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				bool arg1 = LuaDLL.lua_toboolean(L, 3);
				DG.Tweening.Tweener o = obj.ChangeEndValue(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				DG.Tweening.Tweener o = obj.ChangeEndValue(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.ChangeEndValue");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeValues(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				DG.Tweening.Tweener o = obj.ChangeValues(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				object arg1 = ToLua.ToVarObject(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				DG.Tweening.Tweener o = obj.ChangeValues(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.ChangeValues");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetSpeedBased(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Tween o = obj.SetSpeedBased();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				DG.Tweening.Tween o = obj.SetSpeedBased(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetSpeedBased");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRelative(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Tween o = obj.SetRelative();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				DG.Tweening.Tween o = obj.SetRelative(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetRelative");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetDelay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			DG.Tweening.Tween o = obj.SetDelay(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int From(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Tweener o = obj.From();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				DG.Tweening.Tweener o = obj.From(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.From");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAs(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, DG.Tweening.TweenParams>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				DG.Tweening.TweenParams arg0 = (DG.Tweening.TweenParams)ToLua.ToObject(L, 2);
				DG.Tweening.Tween o = obj.SetAs(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, DG.Tweening.Tween>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				DG.Tweening.Tween arg0 = (DG.Tweening.Tween)ToLua.ToObject(L, 2);
				DG.Tweening.Tween o = obj.SetAs(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetAs");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnWaypointChange(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback<int> arg0 = (DG.Tweening.TweenCallback<int>)ToLua.CheckDelegate<DG.Tweening.TweenCallback<int>>(L, 2);
			DG.Tweening.Tween o = obj.OnWaypointChange(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnKill(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnKill(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnComplete(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStepComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnStepComplete(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnUpdate(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnRewind(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnRewind(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPause(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnPause(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPlay(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnPlay(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			DG.Tweening.TweenCallback arg0 = (DG.Tweening.TweenCallback)ToLua.CheckDelegate<DG.Tweening.TweenCallback>(L, 2);
			DG.Tweening.Tween o = obj.OnStart(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetUpdate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, DG.Tweening.UpdateType>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				DG.Tweening.UpdateType arg0 = (DG.Tweening.UpdateType)ToLua.ToObject(L, 2);
				DG.Tweening.Tween o = obj.SetUpdate(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, bool>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				bool arg0 = LuaDLL.lua_toboolean(L, 2);
				DG.Tweening.Tween o = obj.SetUpdate(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.UpdateType arg0 = (DG.Tweening.UpdateType)ToLua.CheckObject(L, 2, typeof(DG.Tweening.UpdateType));
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				DG.Tweening.Tween o = obj.SetUpdate(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetUpdate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRecyclable(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Tween o = obj.SetRecyclable();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				DG.Tweening.Tween o = obj.SetRecyclable(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetRecyclable");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetEase(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, DG.Tweening.EaseFunction>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				DG.Tweening.EaseFunction arg0 = (DG.Tweening.EaseFunction)ToLua.ToObject(L, 2);
				DG.Tweening.Tween o = obj.SetEase(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, UnityEngine.AnimationCurve>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				UnityEngine.AnimationCurve arg0 = (UnityEngine.AnimationCurve)ToLua.ToObject(L, 2);
				DG.Tweening.Tween o = obj.SetEase(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, DG.Tweening.Ease>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				DG.Tweening.Ease arg0 = (DG.Tweening.Ease)ToLua.ToObject(L, 2);
				DG.Tweening.Tween o = obj.SetEase(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Ease arg0 = (DG.Tweening.Ease)ToLua.CheckObject(L, 2, typeof(DG.Tweening.Ease));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				DG.Tweening.Tween o = obj.SetEase(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 4)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Ease arg0 = (DG.Tweening.Ease)ToLua.CheckObject(L, 2, typeof(DG.Tweening.Ease));
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				DG.Tweening.Tween o = obj.SetEase(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetEase");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLoops(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				DG.Tweening.Tween o = obj.SetLoops(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				DG.Tweening.LoopType arg1 = (DG.Tweening.LoopType)ToLua.CheckObject(L, 3, typeof(DG.Tweening.LoopType));
				DG.Tweening.Tween o = obj.SetLoops(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetLoops");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTarget(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
			object arg0 = ToLua.ToVarObject(L, 2);
			DG.Tweening.Tween o = obj.SetTarget(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLink(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				DG.Tweening.Tween o = obj.SetLink(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 2, typeof(UnityEngine.GameObject));
				DG.Tweening.LinkBehaviour arg1 = (DG.Tweening.LinkBehaviour)ToLua.CheckObject(L, 3, typeof(DG.Tweening.LinkBehaviour));
				DG.Tweening.Tween o = obj.SetLink(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetLink");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetId(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, int>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				int arg0 = (int)LuaDLL.lua_tonumber(L, 2);
				DG.Tweening.Tween o = obj.SetId(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, string>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				string arg0 = ToLua.ToString(L, 2);
				DG.Tweening.Tween o = obj.SetId(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<DG.Tweening.Tween, object>(L, 1))
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.ToObject(L, 1);
				object arg0 = ToLua.ToVarObject(L, 2);
				DG.Tweening.Tween o = obj.SetId(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetId");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAutoKill(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				DG.Tweening.Tween o = obj.SetAutoKill();
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2)
			{
				DG.Tweening.Tweener obj = (DG.Tweening.Tweener)ToLua.CheckObject<DG.Tweening.Tweener>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				DG.Tweening.Tween o = obj.SetAutoKill(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: DG.Tweening.Tweener.SetAutoKill");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

