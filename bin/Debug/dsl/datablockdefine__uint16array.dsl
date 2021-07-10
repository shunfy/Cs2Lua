require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");
require("datablockdefine__baseintegerarray");

class(DataBlockDefine.UInt16Array, DataBlockDefine.BaseIntegerArray, false) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.UInt16Array, "g_DataBlockDefine_UInt16Array", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.BaseIntegerArray, "cctor");
			callstatic(DataBlockDefine.UInt16Array, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.UInt16Array.__cctor_called){
				return();
			}else{
				DataBlockDefine.UInt16Array.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		Reset = deffunc(0)args(this, size){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 704_12_706_13 ){
				callstatic(DataBlockDefine.DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"));
			};
			getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId") = callstatic(DataBlockDefine.DclApi, "alloc_array", 2, size, size);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(size, System.UInt32, TypeKind.Struct, 0, true)];
		GetData = deffunc(1)args(this, index){
			local(__method_ret_709_8_717_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 711_12_716_13 ){
				__method_ret_709_8_717_9 = callstatic(DataBlockDefine.DclApi, "get_array_element_uint16", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Struct));
				return(__method_ret_709_8_717_9);
			}else{
				__method_ret_709_8_717_9 = 0;
				return(__method_ret_709_8_717_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.UInt16, TypeKind.Struct, 0, true), paramtype(index, System.Int32, TypeKind.Struct, 0, true)];
		SetData = deffunc(0)args(this, index, val){
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 720_12_722_13 ){
				callstatic(DataBlockDefine.DclApi, "set_array_element_uint16", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), typecast(index, System.UInt32, TypeKind.Struct), val);
			};
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(index, System.Int32, TypeKind.Struct, 0, true), paramtype(val, System.UInt16, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			buildbaseobj(this, DataBlockDefine.UInt16Array, DataBlockDefine.BaseIntegerArray, "ctor", 0);
			callinstance(this, DataBlockDefine.UInt16Array, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.UInt16Array, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.UInt16Array, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		__ctor_called = false;
	};
	instance_props {};
	instance_events {};

	interfaces {
		"DataBlockDefine.IDataBlock";
	};

	class_info(TypeKind.Class, Accessibility.Public) {
	};
	method_info {
		Reset(MethodKind.Ordinary, Accessibility.Public){
		};
		GetData(MethodKind.Ordinary, Accessibility.Public){
		};
		SetData(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



