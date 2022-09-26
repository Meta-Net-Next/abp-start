using Meta.App.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Meta.App;

[DependsOn(
    typeof(AppEntityFrameworkCoreTestModule)
    )]
public class AppDomainTestModule : AbpModule
{

}
