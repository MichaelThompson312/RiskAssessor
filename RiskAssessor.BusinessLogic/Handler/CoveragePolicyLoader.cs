using RiskAssessor.Common;
using RiskAssessor.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiskAssessor.BusinessLogic.Handler
{

    public interface ICoveragePolicyLoader
    {
        void Handlepolicies();
    }

    public class CoveragePolicyLoader : ICoveragePolicyLoader
    {
        public CoveragePolicyLoader(IClientCoveragePolicyRepository clientCoveragePolicy, IRiskAmountMapper riskAmountMapper, IPolicyMapper policyMapper)
        {
            _clientCoveragePolicyRepository = clientCoveragePolicy;
            _riskAmountMapper = riskAmountMapper;
            _policyMapper = policyMapper;
        }

        private readonly IClientCoveragePolicyRepository _clientCoveragePolicyRepository;
        private readonly IRiskAmountMapper _riskAmountMapper;
        private readonly IPolicyMapper _policyMapper;

        public void Handlepolicies()
        {
            var policies = _clientCoveragePolicyRepository.LoadPolicyInformation();
            var mappedCondensedPolicies = _policyMapper.MapCoveragePolicy(policies);
            var clientRiskAmounts = _riskAmountMapper.Map(mappedCondensedPolicies);
            _clientCoveragePolicyRepository.WriteRiskAmountData(clientRiskAmounts);
        }
    }
}
