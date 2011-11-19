//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.MSHTMLApi
{
	///<summary>
	/// DispatchInterface IHTMLWindow2 SupportByLibraryAttribute MSHTML, 4
	///</summary>
	[SupportByLibraryAttribute("MSHTML", 4)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class IHTMLWindow2 : IHTMLFramesCollection2
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IHTMLWindow2);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IHTMLWindow2(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLFramesCollection2 frames
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "frames", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLFramesCollection2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLFramesCollection2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string defaultStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "defaultStatus", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "defaultStatus", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string status
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "status", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "status", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLImageElementFactory Image
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Image", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLImageElementFactory newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLImageElementFactory;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLLocation location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "location", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLLocation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLLocation;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IOmHistory history
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "history", paramsArray);
				LateBindingApi.MSHTMLApi.IOmHistory newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IOmHistory;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object opener
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "opener", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "opener", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IOmNavigator navigator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "navigator", paramsArray);
				LateBindingApi.MSHTMLApi.IOmNavigator newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IOmNavigator;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLWindow2 parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "parent", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLWindow2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLWindow2 self
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "self", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLWindow2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLWindow2 top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "top", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLWindow2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLWindow2 window
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "window", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLWindow2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLWindow2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onfocus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onfocus", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onfocus", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onblur
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onblur", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onblur", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onload", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onbeforeunload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onbeforeunload", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onbeforeunload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onunload
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onunload", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onunload", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onhelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onhelp", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onhelp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onerror
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onerror", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onerror", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onresize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onresize", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onresize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object onscroll
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "onscroll", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "onscroll", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLDocument2 document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "document", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLDocument2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLDocument2;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLEventObj get_event()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.PropertyGet(this, "event", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLEventObj newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLEventObj;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject _newEnum
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_newEnum", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLScreen screen
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "screen", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLScreen newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLScreen;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLOptionElementFactory Option
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Option", paramsArray);
				LateBindingApi.MSHTMLApi.IHTMLOptionElementFactory newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLOptionElementFactory;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool closed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "closed", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IOmNavigator clientInformation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "clientInformation", paramsArray);
				LateBindingApi.MSHTMLApi.IOmNavigator newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IOmNavigator;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get/Set
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object offscreenBuffering
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "offscreenBuffering", paramsArray);
				if((null != returnItem) && (returnItem is MarshalByRefObject))
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "offscreenBuffering", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// Get
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public COMObject external
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "external", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 setTimeout(string expression, Int32 msec, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec, language);
			object returnItem = Invoker.MethodReturn(this, "setTimeout", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 setTimeout(string expression, Int32 msec)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec);
			object returnItem = Invoker.MethodReturn(this, "setTimeout", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void clearTimeout(Int32 timerID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(timerID);
			Invoker.Method(this, "clearTimeout", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="message">string message</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void alert(string message)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message);
			Invoker.Method(this, "alert", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="message">string message</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public bool confirm(string message)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message);
			object returnItem = Invoker.MethodReturn(this, "confirm", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="message">string message</param>
		/// <param name="defstr">string defstr</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object prompt(string message, string defstr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(message, defstr);
			object returnItem = Invoker.MethodReturn(this, "prompt", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="url">string url</param>
		/// <param name="name">string name</param>
		/// <param name="features">string features</param>
		/// <param name="replace">bool replace</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public LateBindingApi.MSHTMLApi.IHTMLWindow2 open(string url, string name, string features, bool replace)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url, name, features, replace);
			object returnItem = Invoker.MethodReturn(this, "open", paramsArray);
			LateBindingApi.MSHTMLApi.IHTMLWindow2 newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.MSHTMLApi.IHTMLWindow2;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="url">string url</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void navigate(string url)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(url);
			Invoker.Method(this, "navigate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		/// <param name="varOptions">optional object varOptions</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object showModalDialog(string dialog, object varArgIn, object varOptions)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dialog, varArgIn, varOptions);
			object returnItem = Invoker.MethodReturn(this, "showModalDialog", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object showModalDialog(string dialog)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dialog);
			object returnItem = Invoker.MethodReturn(this, "showModalDialog", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="dialog">string dialog</param>
		/// <param name="varArgIn">optional object varArgIn</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object showModalDialog(string dialog, object varArgIn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dialog, varArgIn);
			object returnItem = Invoker.MethodReturn(this, "showModalDialog", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="helpURL">string helpURL</param>
		/// <param name="helpArg">object helpArg</param>
		/// <param name="features">string features</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void showHelp(string helpURL, object helpArg, string features)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpURL, helpArg, features);
			Invoker.Method(this, "showHelp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void focus()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "focus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void blur()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "blur", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scroll(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scroll", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		/// <param name="language">optional object language</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 setInterval(string expression, Int32 msec, object language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec, language);
			object returnItem = Invoker.MethodReturn(this, "setInterval", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="expression">string expression</param>
		/// <param name="msec">Int32 msec</param>
		[CustomMethodAttribute]
		[SupportByLibraryAttribute("MSHTML", 4)]
		public Int32 setInterval(string expression, Int32 msec)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression, msec);
			object returnItem = Invoker.MethodReturn(this, "setInterval", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="timerID">Int32 timerID</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void clearInterval(Int32 timerID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(timerID);
			Invoker.Method(this, "clearInterval", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="code">string code</param>
		/// <param name="language">string language</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public object execScript(string code, string language)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(code, language);
			object returnItem = Invoker.MethodReturn(this, "execScript", paramsArray);
			if((null != returnItem) && (returnItem is MarshalByRefObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public string toString()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "toString", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollBy(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scrollBy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void scrollTo(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "scrollTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void moveTo(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "moveTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void moveBy(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "moveBy", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void resizeTo(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "resizeTo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary MSHTML 4
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		[SupportByLibraryAttribute("MSHTML", 4)]
		public void resizeBy(Int32 x, Int32 y)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y);
			Invoker.Method(this, "resizeBy", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}