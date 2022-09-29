namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEntityEventListenerSchema

	/// <exclude/>
	public class UsrRealtyEntityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEntityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEntityEventListenerSchema(UsrRealtyEntityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d6d79c71-40a9-48b4-ac13-b6b5d6a9e685");
			Name = "UsrRealtyEntityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a952ba2-ebf6-4de2-b3ff-387c292e1014");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,146,65,79,2,49,16,133,239,252,138,201,198,195,110,98,54,112,21,53,17,68,67,66,212,8,120,49,30,74,119,88,106,186,237,166,237,130,104,248,239,78,183,32,44,112,112,78,155,233,235,215,247,102,71,177,2,109,201,56,194,4,141,97,86,207,93,218,215,106,46,242,202,48,39,180,106,253,180,128,170,178,66,229,48,94,91,135,69,247,160,115,120,203,96,58,80,78,56,129,246,31,146,116,176,68,229,182,202,247,186,187,174,91,35,65,143,40,52,241,152,47,176,96,79,228,16,110,32,154,90,243,138,76,186,117,148,124,212,119,202,106,38,5,7,46,153,181,16,142,206,80,224,10,122,204,226,153,147,26,18,210,29,224,244,146,236,138,12,97,169,69,6,207,106,168,44,26,71,57,98,61,251,68,238,192,162,202,208,92,66,32,246,112,78,161,106,238,157,201,45,96,242,7,220,163,125,205,200,68,122,136,219,113,48,233,54,132,129,11,166,14,68,193,227,208,72,130,190,169,205,144,139,130,73,40,141,224,126,72,225,82,250,136,110,178,46,49,235,107,89,21,234,141,201,10,175,183,210,219,216,15,242,197,235,167,227,251,232,232,109,49,135,56,176,110,161,211,222,85,210,208,52,99,249,194,116,104,251,76,113,148,152,145,9,103,42,236,158,136,172,51,126,25,104,219,44,203,113,130,69,41,153,35,207,39,66,95,219,28,83,154,21,45,163,162,177,211,38,250,88,35,205,153,20,223,108,38,113,92,3,227,253,94,156,249,197,209,37,68,117,252,161,157,104,221,19,249,113,224,83,103,20,32,52,210,7,109,10,230,226,35,199,68,236,164,237,222,197,57,146,91,24,189,2,133,43,24,124,113,44,189,233,221,245,35,245,166,213,252,218,180,54,191,109,55,209,143,138,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("7e33a320-1a96-300a-dad5-583848c88b64"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("4a952ba2-ebf6-4de2-b3ff-387c292e1014"),
				CreatedInSchemaUId = new Guid("d6d79c71-40a9-48b4-ac13-b6b5d6a9e685"),
				ModifiedInSchemaUId = new Guid("d6d79c71-40a9-48b4-ac13-b6b5d6a9e685")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6d79c71-40a9-48b4-ac13-b6b5d6a9e685"));
		}

		#endregion

	}

	#endregion

}

