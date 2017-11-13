#if UNITY_ANDROID || UNITY_IPHONE || UNITY_STANDALONE_OSX || UNITY_TVOS
// WARNING: Do not modify! Generated file.

namespace UnityEngine.Purchasing.Security {
    public class GooglePlayTangle
    {
        private static byte[] data = System.Convert.FromBase64String("l85/PFMXmDV4w6keOkpw5ZrhthdOBLMI1NV/bOcX94XKYXrxw06NmNcHDl8peSqkvrUv5ldalo4niCImI6NyTYcc7O4GARVDW0RZtZ6vnOYRTnDiY8WPgEs0Ye9FS8du4a1kyNXwL4XIZYbkNUoWQQ5W081PHwlCGugNtwZdDT3q9jlTXmTZuFex2RKtH5y/rZCblLcb1RtqkJycnJidnmhUmMXRRtGxaLandM3CT93Zqq1gkcFB1lvlNxwgrKLghDzw9OTXBXAfnJKdrR+cl58fnJydIhy4QaprB5FqgtmDOKHxA0sE2tvRT2g8aHBD0UeVdCDnYKDG3t4CPHN6H5dSvmCYkIF6ITGreqNgjv5mFi0V6zVcLNVjKG5qwnG86J+enJ2c");
        private static int[] order = new int[] { 5,6,9,7,10,9,13,9,8,11,13,13,13,13,14 };
        private static int key = 157;

        public static readonly bool IsPopulated = true;

        public static byte[] Data() {
        	if (IsPopulated == false)
        		return null;
            return Obfuscator.DeObfuscate(data, order, key);
        }
    }
}
#endif
