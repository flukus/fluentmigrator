using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentMigrator.Tests.Integration.Migrations.Umbraco {
	[Migration(201012203016)]
	public class _201012203016_CreateDocumentType : UmbracoMigration {
		public override void Up() {
			Create.DocumentType("MyDocumentType")
				.WithProperty("SomeProperty")
			;
		}

		public override void Down() {
		}
	}
}
