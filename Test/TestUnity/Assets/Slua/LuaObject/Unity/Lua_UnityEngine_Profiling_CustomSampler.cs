﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Profiling_CustomSampler : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Begin(IntPtr l) {
		try {
			UnityEngine.Profiling.CustomSampler self=(UnityEngine.Profiling.CustomSampler)checkSelf(l);
			self.Begin();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Begin__Object(IntPtr l) {
		try {
			UnityEngine.Profiling.CustomSampler self=(UnityEngine.Profiling.CustomSampler)checkSelf(l);
			UnityEngine.Object a1;
			checkType(l,2,out a1);
			self.Begin(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int End(IntPtr l) {
		try {
			UnityEngine.Profiling.CustomSampler self=(UnityEngine.Profiling.CustomSampler)checkSelf(l);
			self.End();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Create_s(IntPtr l) {
		try {
			System.String a1;
			checkType(l,1,out a1);
			var ret=UnityEngine.Profiling.CustomSampler.Create(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.Profiling.CustomSampler");
		addMember(l,Begin);
		addMember(l,Begin__Object);
		addMember(l,End);
		addMember(l,Create_s);
		createTypeMetatable(l,null, typeof(UnityEngine.Profiling.CustomSampler),typeof(UnityEngine.Profiling.Sampler));
	}
}
