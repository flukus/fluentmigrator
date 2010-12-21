using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentMigrator.Builders;
using FluentMigrator.Builders.Create;

namespace FluentMigrator {
	public abstract class UmbracoMigration : Migration {
		public IUmbracoCreateExpressionRoot Create {
			get { return new UmbracoCreateExpressionRoot(_context); }
		}
	}
}
