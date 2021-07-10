require("cs2dsl__syslib");
require("cs2dsl__namespaces");
require("cs2dsl__externenums");
require("cs2dsl__interfaces");

class(DataBlockDefine.BaseIntegerArray) {
	static_methods {
		__new_object = deffunc(1)args(...){
			local(__cs2dsl_newobj);__cs2dsl_newobj = newobject(DataBlockDefine.BaseIntegerArray, "g_DataBlockDefine_BaseIntegerArray", typeargs(), typekinds(), "ctor", 0, null, ...);
			return(__cs2dsl_newobj);
		}options[needfuncinfo(false)];
		cctor = deffunc(0)args(){
			callstatic(DataBlockDefine.BaseIntegerArray, "__cctor");
		};
		__cctor = deffunc(0)args(){
			if(DataBlockDefine.BaseIntegerArray.__cctor_called){
				return();
			}else{
				DataBlockDefine.BaseIntegerArray.__cctor_called = true;
			};
		}options[needfuncinfo(false)];
	};
	static_fields {
		__cctor_called = false;
	};
	static_props {};
	static_events {};

	instance_methods {
		GetDataBlockId = deffunc(1)args(this){
			local(__method_ret_578_8_581_9);
			__method_ret_578_8_581_9 = getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId");
			return(__method_ret_578_8_581_9);
		}options[needfuncinfo(false), rettype(return, System.UInt64, TypeKind.Struct, 0, true)];
		Init = deffunc(0)args(this){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid"), 584_12_585_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Release = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid"), System.Boolean, TypeKind.Struct), 590_12_591_23 ){
				return();
			};
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 592_12_595_13 ){
				callstatic(DataBlockDefine.DclApi, "free_array", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"));
				setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId", 0);
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		Attach = deffunc(0)args(this, dataBlockId){
			if( getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid"), 600_12_601_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId", dataBlockId);
			setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid", true);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false), paramtype(dataBlockId, System.UInt64, TypeKind.Struct, 0, true)];
		Detach = deffunc(0)args(this){
			if( execunary("!", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid"), System.Boolean, TypeKind.Struct), 607_12_608_23 ){
				return();
			};
			setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId", 0);
			setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_IsValid", false);
		}options[needfuncinfo(false), rettype(return, System.Void, TypeKind.Unknown, 0, false)];
		GetLength = deffunc(1)args(this){
			local(__method_ret_612_8_620_9);
			if( execbinary("!=", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"), 0, System.UInt64, System.UInt64, TypeKind.Struct, TypeKind.Struct), 614_12_619_13 ){
				__method_ret_612_8_620_9 = callstatic(DataBlockDefine.DclApi, "get_array_length", getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "m_DataBlockId"));
				return(__method_ret_612_8_620_9);
			}else{
				__method_ret_612_8_620_9 = 0;
				return(__method_ret_612_8_620_9);
			};
			return(null);
		}options[needfuncinfo(false), rettype(return, System.Int32, TypeKind.Struct, 0, true)];
		ctor = deffunc(0)args(this){
			callinstance(this, DataBlockDefine.BaseIntegerArray, "__ctor");
		};
		__ctor = deffunc(0)args(this){
			if(getinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "__ctor_called")){
				return();
			}else{
				setinstance(SymbolKind.Field, this, DataBlockDefine.BaseIntegerArray, "__ctor_called", true);
			};
		}options[needfuncinfo(false)];
	};
	instance_fields {
		m_IsValid = false;
		m_DataBlockId = 0;
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
		GetDataBlockId(MethodKind.Ordinary, Accessibility.Public){
		};
		Init(MethodKind.Ordinary, Accessibility.Public){
		};
		Release(MethodKind.Ordinary, Accessibility.Public){
		};
		Attach(MethodKind.Ordinary, Accessibility.Public){
		};
		Detach(MethodKind.Ordinary, Accessibility.Public){
		};
		GetLength(MethodKind.Ordinary, Accessibility.Public){
		};
		ctor(MethodKind.Constructor, Accessibility.Public){
		};
	};
};



