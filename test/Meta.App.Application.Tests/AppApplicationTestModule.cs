using Volo.Abp.Modularity;

namespace Meta.App;

[DependsOn(
    typeof(AppApplicationModule),
    typeof(AppDomainTestModule)
    )]
public class AppApplicationTestModule : AbpModule
{

}
