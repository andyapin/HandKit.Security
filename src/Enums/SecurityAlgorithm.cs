namespace HandKit.Security
{
    /// <summary>
    /// Enum representing different security algorithms.
    /// </summary>
    public enum SecurityAlgorithm
    {
        /// <summary>
        /// HMAC using SHA256 algorithm.
        /// </summary>
        HmacSha256,

        /// <summary>
        /// HMAC using SHA384 algorithm.
        /// </summary>
        HmacSha384,

        /// <summary>
        /// HMAC using SHA512 algorithm.
        /// </summary>
        HmacSha512,

        /// <summary>
        /// RSA using SHA256 algorithm.
        /// </summary>
        RsaSha256,

        /// <summary>
        /// RSA using SHA384 algorithm.
        /// </summary>
        RsaSha384,

        /// <summary>
        /// RSA using SHA512 algorithm.
        /// </summary>
        RsaSha512,

        /// <summary>
        /// ECDSA using SHA256 algorithm.
        /// </summary>
        EcdsaSha256,

        /// <summary>
        /// ECDSA using SHA384 algorithm.
        /// </summary>
        EcdsaSha384,

        /// <summary>
        /// ECDSA using SHA512 algorithm.
        /// </summary>
        EcdsaSha512
    }
}
