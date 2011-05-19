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
	/// DispatchInterface DiagramNode SupportByLibrary Office, 10,11,12,14
	///</summary>
	[SupportByLibrary("Office", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class DiagramNode : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public DiagramNode()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNodeChildren Children
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Children", paramsArray);
				NetOffice.OfficeApi.DiagramNodeChildren newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.DiagramNodeChildren;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape Shape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shape", paramsArray);
				NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.Shape;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNode Root
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Root", paramsArray);
				NetOffice.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.DiagramNode;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.IMsoDiagram Diagram
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Diagram", paramsArray);
				NetOffice.OfficeApi.IMsoDiagram newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.IMsoDiagram;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoOrgChartLayoutType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Layout", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.Shape TextShape
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextShape", paramsArray);
				NetOffice.OfficeApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.Shape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="Pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		/// <param name="NodeType">NetOffice.OfficeApi.Enums.MsoDiagramNodeType NodeType</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNode AddNode(NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos, NetOffice.OfficeApi.Enums.MsoDiagramNodeType nodeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pos, nodeType);
			object returnItem = Invoker.MethodReturn(this, "AddNode", paramsArray);
			NetOffice.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="TargetNode">NetOffice.OfficeApi.DiagramNode TargetNode</param>
		/// <param name="Pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void MoveNode(NetOffice.OfficeApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, pos);
			Invoker.Method(this, "MoveNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="TargetNode">NetOffice.OfficeApi.DiagramNode TargetNode</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void ReplaceNode(NetOffice.OfficeApi.DiagramNode targetNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode);
			Invoker.Method(this, "ReplaceNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="TargetNode">NetOffice.OfficeApi.DiagramNode TargetNode</param>
		/// <param name="SwapChildren">bool SwapChildren</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void SwapNode(NetOffice.OfficeApi.DiagramNode targetNode, bool swapChildren)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(targetNode, swapChildren);
			Invoker.Method(this, "SwapNode", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="CopyChildren">bool CopyChildren</param>
		/// <param name="TargetNode">NetOffice.OfficeApi.DiagramNode TargetNode</param>
		/// <param name="Pos">NetOffice.OfficeApi.Enums.MsoRelativeNodePosition Pos</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNode CloneNode(bool copyChildren, NetOffice.OfficeApi.DiagramNode targetNode, NetOffice.OfficeApi.Enums.MsoRelativeNodePosition pos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(copyChildren, targetNode, pos);
			object returnItem = Invoker.MethodReturn(this, "CloneNode", paramsArray);
			NetOffice.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		/// <param name="ReceivingNode">NetOffice.OfficeApi.DiagramNode ReceivingNode</param>
		[SupportByLibrary("Office", 10,11,12,14)]
		public void TransferChildren(NetOffice.OfficeApi.DiagramNode receivingNode)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(receivingNode);
			Invoker.Method(this, "TransferChildren", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNode NextNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextNode", paramsArray);
			NetOffice.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.DiagramNode;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary Office 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("Office", 10,11,12,14)]
		public NetOffice.OfficeApi.DiagramNode PrevNode()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "PrevNode", paramsArray);
			NetOffice.OfficeApi.DiagramNode newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.DiagramNode;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}