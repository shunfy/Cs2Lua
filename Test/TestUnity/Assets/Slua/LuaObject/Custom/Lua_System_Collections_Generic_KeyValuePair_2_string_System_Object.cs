﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_System_Collections_Generic_KeyValuePair_2_string_System_Object : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor_s(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.String,System.Object> o;
			o=new System.Collections.Generic.KeyValuePair<System.String,System.Object>();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int ctor__TKey__TValue_s(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.String,System.Object> o;
			System.String a1;
			checkType(l,1,out a1);
			System.Object a2;
			checkType(l,2,out a2);
			o=new System.Collections.Generic.KeyValuePair<System.String,System.Object>(a1,a2);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static new public int ToString(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.String,System.Object> self;
			checkValueType(l,1,out self);
			var ret=self.ToString();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Key(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.String,System.Object> self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Key);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Value(IntPtr l) {
		try {
			System.Collections.Generic.KeyValuePair<System.String,System.Object> self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.Value);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"StrObjPair");
		addMember(l,ctor_s);
		addMember(l,ctor__TKey__TValue_s);
		addMember(l,ToString);
		addMember(l,"Key",get_Key,null,true);
		addMember(l,"Value",get_Value,null,true);
		createTypeMetatable(l,null, typeof(System.Collections.Generic.KeyValuePair<System.String,System.Object>),typeof(System.ValueType));
	}
}
