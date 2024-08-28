//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.4.1+d72fc5c
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

namespace Wmca.Models.Content
{
	/// <summary>UForm</summary>
	[PublishedModel("uFormHexxu")]
	public partial class UFormHexxu : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		public new const string ModelTypeAlias = "uFormHexxu";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<UFormHexxu, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public UFormHexxu(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Bcc
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("bcc")]
		public virtual string Bcc => this.Value<string>(_publishedValueFallback, "bcc");

		///<summary>
		/// Cc
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cc")]
		public virtual string Cc => this.Value<string>(_publishedValueFallback, "cc");

		///<summary>
		/// Date format that the sender entered is invalid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dateFormatThatTheSenderEnteredIsInvalid")]
		public virtual string DateFormatThatTheSenderEnteredIsInvalid => this.Value<string>(_publishedValueFallback, "dateFormatThatTheSenderEnteredIsInvalid");

		///<summary>
		/// Date is earlier than minimum limit
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dateIsEarlierThanMinimumLimit")]
		public virtual string DateIsEarlierThanMinimumLimit => this.Value<string>(_publishedValueFallback, "dateIsEarlierThanMinimumLimit");

		///<summary>
		/// Date is later than maximum limit
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("dateIsLaterThanMaximumLimit")]
		public virtual string DateIsLaterThanMaximumLimit => this.Value<string>(_publishedValueFallback, "dateIsLaterThanMaximumLimit");

		///<summary>
		/// Demo mode
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[ImplementPropertyType("demoMode")]
		public virtual bool DemoMode => this.Value<bool>(_publishedValueFallback, "demoMode");

		///<summary>
		/// Do not store data
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[ImplementPropertyType("doNotStoreData")]
		public virtual bool DoNotStoreData => this.Value<bool>(_publishedValueFallback, "doNotStoreData");

		///<summary>
		/// Email address that the sender entered is invalid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("emailAddressThatTheSenderEnteredIsInvalid")]
		public virtual string EmailAddressThatTheSenderEnteredIsInvalid => this.Value<string>(_publishedValueFallback, "emailAddressThatTheSenderEnteredIsInvalid");

		///<summary>
		/// Exclude lines with blank mail-tags from output
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[ImplementPropertyType("excludeLinesWithBlankMailTagsFromOutput")]
		public virtual bool ExcludeLinesWithBlankMailTagsFromOutput => this.Value<bool>(_publishedValueFallback, "excludeLinesWithBlankMailTagsFromOutput");

		///<summary>
		/// File attachments
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("fileAttachments")]
		public virtual string FileAttachments => this.Value<string>(_publishedValueFallback, "fileAttachments");

		///<summary>
		/// Form
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("form")]
		public virtual string Form => this.Value<string>(_publishedValueFallback, "form");

		///<summary>
		/// From
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("from")]
		public virtual string From => this.Value<string>(_publishedValueFallback, "from");

		///<summary>
		/// Message body
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("messageBody")]
		public virtual string MessageBody => this.Value<string>(_publishedValueFallback, "messageBody");

		///<summary>
		/// Number format that the sender entered is invalid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("numberFormatThatTheSenderEnteredIsInvalid")]
		public virtual string NumberFormatThatTheSenderEnteredIsInvalid => this.Value<string>(_publishedValueFallback, "numberFormatThatTheSenderEnteredIsInvalid");

		///<summary>
		/// Number is larger than maximum limit
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("numberIsLargerThanMaximumLimit")]
		public virtual string NumberIsLargerThanMaximumLimit => this.Value<string>(_publishedValueFallback, "numberIsLargerThanMaximumLimit");

		///<summary>
		/// Number is smaller than minimum limit
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("numberIsSmallerThanMinimumLimit")]
		public virtual string NumberIsSmallerThanMinimumLimit => this.Value<string>(_publishedValueFallback, "numberIsSmallerThanMinimumLimit");

		///<summary>
		/// Redirect to page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("redirectToPage")]
		public virtual global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent RedirectToPage => this.Value<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedContent>(_publishedValueFallback, "redirectToPage");

		///<summary>
		/// Reply to
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("replyTo")]
		public virtual string ReplyTo => this.Value<string>(_publishedValueFallback, "replyTo");

		///<summary>
		/// Sender's message failed to send
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sendersMessageFailedToSend")]
		public virtual string SendersMessageFailedToSend => this.Value<string>(_publishedValueFallback, "sendersMessageFailedToSend");

		///<summary>
		/// Sender's message was sent successfully
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("sendersMessageSuccess")]
		public virtual string SendersMessageSuccess => this.Value<string>(_publishedValueFallback, "sendersMessageSuccess");

		///<summary>
		/// Subject
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("subject")]
		public virtual string Subject => this.Value<string>(_publishedValueFallback, "subject");

		///<summary>
		/// Telephone number that the sender entered is invalid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("telephoneNumberThatTheSenderEnteredIsInvalid")]
		public virtual string TelephoneNumberThatTheSenderEnteredIsInvalid => this.Value<string>(_publishedValueFallback, "telephoneNumberThatTheSenderEnteredIsInvalid");

		///<summary>
		/// There are terms that the sender must accept
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thereAreTermsThatTheSenderMustAccept")]
		public virtual string ThereAreTermsThatTheSenderMustAccept => this.Value<string>(_publishedValueFallback, "thereAreTermsThatTheSenderMustAccept");

		///<summary>
		/// There is a field that the sender must fill in
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thereIsAFieldThatTheSenderMustFillIn")]
		public virtual string ThereIsAfieldThatTheSenderMustFillIn => this.Value<string>(_publishedValueFallback, "thereIsAFieldThatTheSenderMustFillIn");

		///<summary>
		/// There is a field with input that is longer than the maximum allowed length
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thereIsAFieldWithInputThatIsLongerThanTheMaximumAllowedLength")]
		public virtual string ThereIsAfieldWithInputThatIsLongerThanTheMaximumAllowedLength => this.Value<string>(_publishedValueFallback, "thereIsAFieldWithInputThatIsLongerThanTheMaximumAllowedLength");

		///<summary>
		/// There is a field with input that is shorter than the minimum allowed length
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("thereIsAFieldWithInputThatIsShorterThanTheMinimumAllowedLength")]
		public virtual string ThereIsAfieldWithInputThatIsShorterThanTheMinimumAllowedLength => this.Value<string>(_publishedValueFallback, "thereIsAFieldWithInputThatIsShorterThanTheMinimumAllowedLength");

		///<summary>
		/// To
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("to")]
		public virtual string To => this.Value<string>(_publishedValueFallback, "to");

		///<summary>
		/// Uploaded file is not allowed for file type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("uploadedFileIsNotAllowedForFileType")]
		public virtual string UploadedFileIsNotAllowedForFileType => this.Value<string>(_publishedValueFallback, "uploadedFileIsNotAllowedForFileType");

		///<summary>
		/// Uploaded file is too large
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("uploadedFileIsTooLarge")]
		public virtual string UploadedFileIsTooLarge => this.Value<string>(_publishedValueFallback, "uploadedFileIsTooLarge");

		///<summary>
		/// Uploading a file fails for any reason
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("uploadingAFileFailsForAnyReason")]
		public virtual string UploadingAfileFailsForAnyReason => this.Value<string>(_publishedValueFallback, "uploadingAFileFailsForAnyReason");

		///<summary>
		/// URL that the sender entered is invalid
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("uRLThatTheSenderEnteredIsInvalid")]
		public virtual string URlthatTheSenderEnteredIsInvalid => this.Value<string>(_publishedValueFallback, "uRLThatTheSenderEnteredIsInvalid");

		///<summary>
		/// Use HTML content type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[ImplementPropertyType("useHTMLContentType")]
		public virtual bool UseHtmlcontentType => this.Value<bool>(_publishedValueFallback, "useHTMLContentType");

		///<summary>
		/// Use recaptcha
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[ImplementPropertyType("useRecaptcha")]
		public virtual bool UseRecaptcha => this.Value<bool>(_publishedValueFallback, "useRecaptcha");

		///<summary>
		/// Validation errors occurred
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.4.1+d72fc5c")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("validationErrorsOccurred")]
		public virtual string ValidationErrorsOccurred => this.Value<string>(_publishedValueFallback, "validationErrorsOccurred");
	}
}
