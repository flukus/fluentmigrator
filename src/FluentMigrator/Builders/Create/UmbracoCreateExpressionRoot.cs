using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Create{
	class UmbracoCreateExpressionRoot : CreateExpressionRoot {
		public UmbracoCreateExpressionRoot(IMigrationContext context) : base(context) {
		}
	}
}
