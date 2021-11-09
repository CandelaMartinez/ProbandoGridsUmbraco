//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.17.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	// Mixin Content Type with alias "callToAction"
	/// <summary>Call to Action</summary>
	public partial interface ICallToAction : IPublishedElement
	{
		/// <summary>Call to Action Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		global::Umbraco.Web.Models.Link CallToActionLink { get; }

		/// <summary>Call to Action text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		string CallToActionText { get; }

		/// <summary>Call to Action Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		string CallToActionTitle { get; }
	}

	/// <summary>Call to Action</summary>
	[PublishedModel("callToAction")]
	public partial class CallToAction : PublishedElementModel, ICallToAction
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new const string ModelTypeAlias = "callToAction";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CallToAction, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public CallToAction(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Call to Action Link
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("callToActionLink")]
		public virtual global::Umbraco.Web.Models.Link CallToActionLink => GetCallToActionLink(this);

		/// <summary>Static getter for Call to Action Link</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public static global::Umbraco.Web.Models.Link GetCallToActionLink(ICallToAction that) => that.Value<global::Umbraco.Web.Models.Link>("callToActionLink");

		///<summary>
		/// Call to Action text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("callToActionText")]
		public virtual string CallToActionText => GetCallToActionText(this);

		/// <summary>Static getter for Call to Action text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public static string GetCallToActionText(ICallToAction that) => that.Value<string>("callToActionText");

		///<summary>
		/// Call to Action Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		[ImplementPropertyType("callToActionTitle")]
		public virtual string CallToActionTitle => GetCallToActionTitle(this);

		/// <summary>Static getter for Call to Action Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.17.0")]
		public static string GetCallToActionTitle(ICallToAction that) => that.Value<string>("callToActionTitle");
	}
}
