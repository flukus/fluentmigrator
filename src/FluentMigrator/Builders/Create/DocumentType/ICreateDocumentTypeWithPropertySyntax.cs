using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentMigrator.Builders.Create.DocumentType {
	public interface ICreateDocumentTypeWithPropertySyntax {
		ICreateDocumentTypeWithPropertySyntax WithTab(string tabName, int tabOrder);
		ICreateDocumentTypeWithPropertySyntax WithProperty(string propertyName);

		ICreateDocumentTypeWithPropertySyntax Alias(string p);

		ICreateDocumentTypeWithPropertySyntax Type(string p);

		ICreateDocumentTypeWithPropertySyntax Mandatory();

		ICreateDocumentTypeWithPropertySyntax Tab(string p);

		ICreateDocumentTypeWithPropertySyntax Validation(string p);

		ICreateDocumentTypeWithPropertySyntax Description(string p);
	}
}
