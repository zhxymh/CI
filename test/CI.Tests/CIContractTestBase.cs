using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace CI
{
    public class CIContractTestBase : DAppContractTestBase<CIContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal CIContractContainer.CIContractStub GetCIContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<CIContractContainer.CIContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}