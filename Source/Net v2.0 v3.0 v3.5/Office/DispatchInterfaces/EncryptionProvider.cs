//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface EncryptionProvider SupportByLibrary Office, 12,14
	///</summary>
	[SupportByLibrary("Office", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class EncryptionProvider : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EncryptionProvider(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EncryptionProvider(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EncryptionProvider(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public EncryptionProvider()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="encprovdet">NetOffice.OfficeApi.Enums.EncryptionProviderDetail encprovdet</param>
		[SupportByLibrary("Office", 12,14)]
		public object GetProviderDetail(NetOffice.OfficeApi.Enums.EncryptionProviderDetail encprovdet)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(encprovdet);
			object returnItem = Invoker.MethodReturn(this, "GetProviderDetail", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="ParentWindow">object ParentWindow</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 NewSession(object parentWindow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(parentWindow);
			object returnItem = Invoker.MethodReturn(this, "NewSession", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="EncryptionData">object EncryptionData</param>
		/// <param name="PermissionsMask">ref UIntPtr PermissionsMask</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 Authenticate(object parentWindow, object encryptionData, ref UIntPtr permissionsMask)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(parentWindow, encryptionData, permissionsMask);
			object returnItem = Invoker.MethodReturn(this, "Authenticate", paramsArray);
			permissionsMask = (UIntPtr)paramsArray[2];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="SessionHandle">Int32 SessionHandle</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 CloneSession(Int32 sessionHandle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle);
			object returnItem = Invoker.MethodReturn(this, "CloneSession", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="SessionHandle">Int32 SessionHandle</param>
		[SupportByLibrary("Office", 12,14)]
		public void EndSession(Int32 sessionHandle)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle);
			Invoker.Method(this, "EndSession", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="SessionHandle">Int32 SessionHandle</param>
		/// <param name="EncryptionData">object EncryptionData</param>
		[SupportByLibrary("Office", 12,14)]
		public Int32 Save(Int32 sessionHandle, object encryptionData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle, encryptionData);
			object returnItem = Invoker.MethodReturn(this, "Save", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="SessionHandle">Int32 SessionHandle</param>
		/// <param name="StreamName">string StreamName</param>
		/// <param name="UnencryptedStream">object UnencryptedStream</param>
		/// <param name="EncryptedStream">object EncryptedStream</param>
		[SupportByLibrary("Office", 12,14)]
		public void EncryptStream(Int32 sessionHandle, string streamName, object unencryptedStream, object encryptedStream)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle, streamName, unencryptedStream, encryptedStream);
			Invoker.Method(this, "EncryptStream", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="SessionHandle">Int32 SessionHandle</param>
		/// <param name="StreamName">string StreamName</param>
		/// <param name="EncryptedStream">object EncryptedStream</param>
		/// <param name="UnencryptedStream">object UnencryptedStream</param>
		[SupportByLibrary("Office", 12,14)]
		public void DecryptStream(Int32 sessionHandle, string streamName, object encryptedStream, object unencryptedStream)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle, streamName, encryptedStream, unencryptedStream);
			Invoker.Method(this, "DecryptStream", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 12, 14
		/// </summary>
		/// <param name="SessionHandle">Int32 SessionHandle</param>
		/// <param name="ParentWindow">object ParentWindow</param>
		/// <param name="ReadOnly">bool ReadOnly</param>
		/// <param name="Remove">ref bool Remove</param>
		[SupportByLibrary("Office", 12,14)]
		public void ShowSettings(Int32 sessionHandle, object parentWindow, bool readOnly, ref bool remove)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,false,false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(sessionHandle, parentWindow, readOnly, remove);
			Invoker.Method(this, "ShowSettings", paramsArray, modifiers);
			remove = (bool)paramsArray[3];
		}

		#endregion
		#pragma warning restore
	}
}