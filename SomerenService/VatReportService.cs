using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenService
{
	public class VatReportService : VatReportDao
	{
		private VatReportDao reportdb;

		public VatReportService()
		{
			reportdb = new VatReportDao();
		}

		public VatReport GetVatReport(DateOnly startDate, DateOnly endDate)
		{
			return reportdb.GetVatReport(startDate, endDate);
		}

		public List<int> GetAvailableYears()
		{
			return reportdb.GetAvailableYears();
		}
	}
}
