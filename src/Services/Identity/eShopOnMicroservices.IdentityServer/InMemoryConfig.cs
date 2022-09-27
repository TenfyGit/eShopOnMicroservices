using IdentityServer4.Models;
using IdentityServer4.Test;

namespace eShopOnMicroservices.IdentityServer
{
    public static class InMemoryConfig
    {
        // 这个 Authorization Server 保护了哪些 API （资源）
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[]
            {
                    new ApiResource("Catalog.Api", "商品信息服务")
                    {
                        Scopes = { "scope1" }//不配置就返回invalid_scope
                    }
                };
        }
        // 哪些客户端 Client（应用） 可以使用这个 Authorization Server
        public static IEnumerable<Client> GetClients()
        {
            return new[]
            {
                    new Client
                    {
                        ClientId = "blogvuejs",//定义客户端 Id
                        ClientSecrets = new [] { new Secret("secret".Sha256()) },//Client用来获取token
                        AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,//这里使用的是通过用户名密码和ClientCredentials来换取token的方式. ClientCredentials允许Client只使用ClientSecrets来获取token. 这比较适合那种没有用户参与的api动作
                        AllowedScopes = new [] { "scope1" },// 允许访问的 API 资源
                        
                    }
                };
        }
        // 指定可以使用 Authorization Server 授权的 Users（用户）
        public static IEnumerable<TestUser> Users()
        {
            return new[]
            {
                    new TestUser
                    {
                        SubjectId = "1",
                        Username = "laozhang",
                        Password = "laozhang"
                    }
            };
        }
        public static IEnumerable<ApiScope> GetApiScopes() 
        {
            return new List<ApiScope>() {
                new ApiScope("scope1")
            };
        }
    }
}
