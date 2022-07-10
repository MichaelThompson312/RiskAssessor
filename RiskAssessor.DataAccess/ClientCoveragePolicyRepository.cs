using CsvHelper;
using CsvHelper.Configuration;
using RiskAssessor.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace RiskAssessor.DataAccess
{
    public interface IClientCoveragePolicyRepository
    {
        List<CoveragePolicy> LoadPolicyInformation();
        void WriteRiskAmountData(IEnumerable<ClientRiskAmount> clientRiskAmounts);
    }

    public class ClientCoveragePolicyRepository : IClientCoveragePolicyRepository
    {
        public List<CoveragePolicy> LoadPolicyInformation()
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = false
            };
            using var streamReader = File.OpenText(@"..\ClientCoveragePolicy.csv");
            using var csvReader = new CsvReader(streamReader, csvConfig);
            streamReader.ReadLine();
            var allPolicies = csvReader.GetRecords<CoveragePolicy>();

            return allPolicies.ToList();
        }

        public void WriteRiskAmountData(IEnumerable<ClientRiskAmount> clientRiskAmounts)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture){};

            using (TextWriter writer = new StreamWriter(@"..\RiskAmount.csv", false, Encoding.UTF8))
            {
                var csv = new CsvWriter(writer, csvConfig);
                csv.WriteRecords(clientRiskAmounts);
            }
        }
    }
}
