using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Create.DocumentType {
	public interface ICreateDocumentTypeSyntax : IFluentSyntax {
		ICreateDocumentTypeWithPropertySyntax WithTab(string tabName, int tabOrder);
		ICreateDocumentTypeWithPropertySyntax WithProperty(string propertyName);
	}
}
