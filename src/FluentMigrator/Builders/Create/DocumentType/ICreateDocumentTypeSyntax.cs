using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Create.DocumentType {
	public interface ICreateDocumentTypeSyntax : ICreateDocumentTypeWithPropertySyntax, IFluentSyntax {

		ICreateDocumentTypeSyntax Alias(string p);

		ICreateDocumentTypeSyntax MasterDocumentType(string p);

		ICreateDocumentTypeSyntax Icon(string p);

		ICreateDocumentTypeSyntax Thumbnail(string p);

		ICreateDocumentTypeSyntax Description(string p);

		ICreateDocumentTypeSyntax DefaultTemplate(string p);

		ICreateDocumentTypeSyntax WithAllowedTemplate(string p);

		ICreateDocumentTypeSyntax WithAllowedChildDocumentType(string p);
	}
}
