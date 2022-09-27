using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace eShopOnMicroservices.IdentityServer.Security
{
    /// <summary>
    /// 签名证书类
    /// </summary>
    public static class Certificate
    {
        /// <summary>
        /// 获取签名证书
        /// </summary>
        /// <returns></returns>
        public static X509Certificate2 Get()
        {
            string currentDirectory = Path.GetDirectoryName(typeof(Program).Assembly.Location);
            string pfxPath = Path.Combine(currentDirectory, "Security", "eShopOnMicroservices.pfx");
            return new X509Certificate2(pfxPath, "123456");
        }
    }
}
