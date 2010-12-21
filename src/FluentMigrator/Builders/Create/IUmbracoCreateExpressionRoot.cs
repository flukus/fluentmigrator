using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Builders.Create.DocumentType;

namespace FluentMigrator.Builders {
	public interface IUmbracoCreateExpressionRoot {
		ICreateDocumentTypeSyntax DocumentType(string name);
	}
}
