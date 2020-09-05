﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TGNetServiceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(TGNetService), typeof(System.Object));
		L.RegFunction("IsRunning", IsRunning);
		L.RegFunction("GetInstance", GetInstance);
		L.RegFunction("NewInstance", NewInstance);
		L.RegFunction("Start", Start);
		L.RegFunction("Stop", Stop);
		L.RegFunction("GetServerTime", GetServerTime);
		L.RegFunction("GetServerPassedTime", GetServerPassedTime);
		L.RegFunction("GetServerLatency", GetServerLatency);
		L.RegFunction("AddEventHandler", AddEventHandler);
		L.RegFunction("RemoveEventHander", RemoveEventHander);
		L.RegFunction("SendRequest", SendRequest);
		L.RegFunction("NetEventDispatcher", NetEventDispatcher);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("DebugLevel", get_DebugLevel, set_DebugLevel);
		L.RegConstant("ReceiveTimeout", 90000);
		L.RegConstant("PingRate", 30000);
		L.RegVar("serverIp", get_serverIp, set_serverIp);
		L.RegVar("serverPort", get_serverPort, set_serverPort);
		L.RegVar("pool", get_pool, set_pool);
		L.RegFunction("NetEventHanlder", TGNetService_NetEventHanlder);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsRunning(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
			bool o = obj.IsRunning();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			TGNetService o = TGNetService.GetInstance();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NewInstance(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			TGNetService o = TGNetService.NewInstance();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Start(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.Start(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
			obj.Stop();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetServerTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			System.DateTime o = TGNetService.GetServerTime();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetServerPassedTime(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.DateTime arg0 = StackTraits<System.DateTime>.Check(L, 1);
			float o = TGNetService.GetServerPassedTime(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetServerLatency(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			int o = TGNetService.GetServerLatency();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEventHandler(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				TGNetService.NetEventHanlder arg1 = (TGNetService.NetEventHanlder)ToLua.CheckDelegate<TGNetService.NetEventHanlder>(L, 3);
				obj.AddEventHandler(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
				string arg0 = ToLua.CheckString(L, 2);
				TGNetService.NetEventHanlder arg1 = (TGNetService.NetEventHanlder)ToLua.CheckDelegate<TGNetService.NetEventHanlder>(L, 3);
				int arg2 = (int)LuaDLL.luaL_checknumber(L, 4);
				obj.AddEventHandler(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TGNetService.AddEventHandler");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveEventHander(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			TGNetService.NetEventHanlder arg1 = (TGNetService.NetEventHanlder)ToLua.CheckDelegate<TGNetService.NetEventHanlder>(L, 3);
			obj.RemoveEventHander(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendRequest(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
			TGNetService.NetRequest arg0 = (TGNetService.NetRequest)ToLua.CheckObject<TGNetService.NetRequest>(L, 2);
			obj.SendRequest(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NetEventDispatcher(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			TGNetService obj = (TGNetService)ToLua.CheckObject<TGNetService>(L, 1);
			System.Collections.IEnumerator o = obj.NetEventDispatcher();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DebugLevel(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, TGNetService.DebugLevel);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_serverIp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService obj = (TGNetService)o;
			string ret = obj.serverIp;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index serverIp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_serverPort(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService obj = (TGNetService)o;
			int ret = obj.serverPort;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index serverPort on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_pool(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService obj = (TGNetService)o;
			UTGNetServicePool ret = obj.pool;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pool on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DebugLevel(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			TGNetService.DebugLevel = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_serverIp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService obj = (TGNetService)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.serverIp = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index serverIp on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_serverPort(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService obj = (TGNetService)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.serverPort = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index serverPort on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_pool(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			TGNetService obj = (TGNetService)o;
			UTGNetServicePool arg0 = (UTGNetServicePool)ToLua.CheckObject<UTGNetServicePool>(L, 2);
			obj.pool = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index pool on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TGNetService_NetEventHanlder(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<TGNetService.NetEventHanlder>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<TGNetService.NetEventHanlder>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
