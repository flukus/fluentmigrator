using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Infrastructure;
using FluentMigrator.Builders.Create.DocumentType;

namespace FluentMigrator.Builders.Create{
	class UmbracoCreateExpressionRoot : CreateExpressionRoot, IUmbracoCreateExpressionRoot {
		public UmbracoCreateExpressionRoot(IMigrationContext context) : base(context) {
		}

		public ICreateDocumentTypeSyntax DocumentType(string name) {
			throw new NotImplementedException();
		}
	}
}
