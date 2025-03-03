﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_CanvasRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetColor(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.SetColor(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetColor(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			var ret=self.GetColor();
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
	static public int EnableRectClipping(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			self.EnableRectClipping(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int DisableRectClipping(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			self.DisableRectClipping();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMaterial__Material__Int32(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetMaterial(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMaterial__Material__Texture(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			UnityEngine.Texture a2;
			checkType(l,3,out a2);
			self.SetMaterial(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetMaterial(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			var ret=self.GetMaterial();
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
	static public int GetMaterial__Int32(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetMaterial(a1);
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
	static public int SetPopMaterial(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetPopMaterial(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPopMaterial(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPopMaterial(a1);
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
	static public int SetTexture(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			self.SetTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetAlphaTexture(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			self.SetAlphaTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetMesh(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			self.SetMesh(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetAlpha(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			var ret=self.GetAlpha();
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
	static public int SetAlpha(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.SetAlpha(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetInheritedAlpha(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			var ret=self.GetInheritedAlpha();
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
	static public int SplitUIVertexStreams__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector3> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector4> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<System.Int32> a8;
			checkType(l,8,out a8);
			UnityEngine.CanvasRenderer.SplitUIVertexStreams(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SplitUIVertexStreams__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector2> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector2> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<UnityEngine.Vector3> a8;
			checkType(l,8,out a8);
			System.Collections.Generic.List<UnityEngine.Vector4> a9;
			checkType(l,9,out a9);
			System.Collections.Generic.List<System.Int32> a10;
			checkType(l,10,out a10);
			UnityEngine.CanvasRenderer.SplitUIVertexStreams(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector3> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector4> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<System.Int32> a8;
			checkType(l,8,out a8);
			UnityEngine.CanvasRenderer.CreateUIVertexStream(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int CreateUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector2> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector2> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<UnityEngine.Vector3> a8;
			checkType(l,8,out a8);
			System.Collections.Generic.List<UnityEngine.Vector4> a9;
			checkType(l,9,out a9);
			System.Collections.Generic.List<System.Int32> a10;
			checkType(l,10,out a10);
			UnityEngine.CanvasRenderer.CreateUIVertexStream(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector3> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector4> a7;
			checkType(l,7,out a7);
			UnityEngine.CanvasRenderer.AddUIVertexStream(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int AddUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector2> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector2> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<UnityEngine.Vector3> a8;
			checkType(l,8,out a8);
			System.Collections.Generic.List<UnityEngine.Vector4> a9;
			checkType(l,9,out a9);
			UnityEngine.CanvasRenderer.AddUIVertexStream(a1,a2,a3,a4,a5,a6,a7,a8,a9);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasPopInstruction(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasPopInstruction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_hasPopInstruction(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hasPopInstruction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_materialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.materialCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_materialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.materialCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_popMaterialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.popMaterialCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_popMaterialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.popMaterialCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_absoluteDepth(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.absoluteDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasMoved(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasMoved);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cullTransparentMesh(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cullTransparentMesh);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cullTransparentMesh(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.cullTransparentMesh=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_hasRectClipping(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasRectClipping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_relativeDepth(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.relativeDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_cull(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cull);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_cull(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.cull=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CanvasRenderer");
		addMember(l,SetColor);
		addMember(l,GetColor);
		addMember(l,EnableRectClipping);
		addMember(l,DisableRectClipping);
		addMember(l,SetMaterial__Material__Int32);
		addMember(l,SetMaterial__Material__Texture);
		addMember(l,GetMaterial);
		addMember(l,GetMaterial__Int32);
		addMember(l,SetPopMaterial);
		addMember(l,GetPopMaterial);
		addMember(l,SetTexture);
		addMember(l,SetAlphaTexture);
		addMember(l,SetMesh);
		addMember(l,Clear);
		addMember(l,GetAlpha);
		addMember(l,SetAlpha);
		addMember(l,GetInheritedAlpha);
		addMember(l,SplitUIVertexStreams__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s);
		addMember(l,SplitUIVertexStreams__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s);
		addMember(l,CreateUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s);
		addMember(l,CreateUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4__List_1_Int32_s);
		addMember(l,AddUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4_s);
		addMember(l,AddUIVertexStream__List_1_UIVertex__List_1_Vector3__List_1_Color32__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector2__List_1_Vector3__List_1_Vector4_s);
		addMember(l,"hasPopInstruction",get_hasPopInstruction,set_hasPopInstruction,true);
		addMember(l,"materialCount",get_materialCount,set_materialCount,true);
		addMember(l,"popMaterialCount",get_popMaterialCount,set_popMaterialCount,true);
		addMember(l,"absoluteDepth",get_absoluteDepth,null,true);
		addMember(l,"hasMoved",get_hasMoved,null,true);
		addMember(l,"cullTransparentMesh",get_cullTransparentMesh,set_cullTransparentMesh,true);
		addMember(l,"hasRectClipping",get_hasRectClipping,null,true);
		addMember(l,"relativeDepth",get_relativeDepth,null,true);
		addMember(l,"cull",get_cull,set_cull,true);
		createTypeMetatable(l,null, typeof(UnityEngine.CanvasRenderer),typeof(UnityEngine.Component));
	}
}
