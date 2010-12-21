using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentMigrator.Builders.Create.DocumentType {
	public interface ICreateDocumentTypeWithPropertySyntax {
		ICreateDocumentTypeWithPropertySyntax WithProperty(string propertyName, string propertyAlias, string tabName);
	}
}
