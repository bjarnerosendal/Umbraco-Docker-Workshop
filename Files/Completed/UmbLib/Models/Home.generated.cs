//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v10.0.0-rc2+e0aa430
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace UmbLib.Models
{
	/// <summary>Home</summary>
	[PublishedModel("home")]
	public partial class Home : PublishedContentModel, IContentControls, IFooterControls, IHeaderControls, IMainImageControls, ISEocontrols
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		public new const string ModelTypeAlias = "home";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Home, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Home(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Main Content: Enter the main content for the page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainContent")]
		public virtual global::Newtonsoft.Json.Linq.JToken MainContent => global::UmbLib.Models.ContentControls.GetMainContent(this, _publishedValueFallback);

		///<summary>
		/// Social Links: Add any social links, using font awesome icons
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("socialLinks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::UmbLib.Models.IconLinkItem> SocialLinks => global::UmbLib.Models.FooterControls.GetSocialLinks(this, _publishedValueFallback);

		///<summary>
		/// Subtitle: Enter a subtitle for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("subtitle")]
		public virtual string Subtitle => global::UmbLib.Models.HeaderControls.GetSubtitle(this, _publishedValueFallback);

		///<summary>
		/// Title: Enter the title for the page. If this is empty the name of the page will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("title")]
		public virtual string Title => global::UmbLib.Models.HeaderControls.GetTitle(this, _publishedValueFallback);

		///<summary>
		/// Main Image: Choose the main image for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mainImage")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent MainImage => global::UmbLib.Models.MainImageControls.GetMainImage(this, _publishedValueFallback);

		///<summary>
		/// Meta Description: Enter the meta description for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaDescription")]
		public virtual string MetaDescription => global::UmbLib.Models.SEocontrols.GetMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Meta Keywords: Enter the keywords for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaKeywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> MetaKeywords => global::UmbLib.Models.SEocontrols.GetMetaKeywords(this, _publishedValueFallback);

		///<summary>
		/// Meta Name: Enter the meta name for this page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "10.0.0-rc2+e0aa430")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("metaName")]
		public virtual string MetaName => global::UmbLib.Models.SEocontrols.GetMetaName(this, _publishedValueFallback);
	}
}
