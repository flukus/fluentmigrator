using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentMigrator.Tests.Integration.Migrations.Umbraco {
	[Migration(201012203016)]
	public class _201012203016_CreateDocumentType : UmbracoMigration {
		public override void Up() {
			Create.DocumentType("MyDocumentType")
				.Alias("myDocType")
				.MasterDocumentType("MyMaster")
				.Icon("")
				.Thumbnail("")
				.Description("")
				.DefaultTemplate("")
				.WithAllowedTemplate("")
				.WithAllowedChildDocumentType("")
				//add a tab
				.WithTab("Properties Tab", 3)
				.WithProperty("SomeProperty").Alias("sProperty").Type("Text").Mandatory().Tab("Properties Tab").Validation("").Description("")
			;
		}

		public override void Down() {
		}
	}
}
