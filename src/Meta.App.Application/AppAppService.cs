using System;
using System.Collections.Generic;
using System.Text;
using Meta.App.Localization;
using Volo.Abp.Application.Services;

namespace Meta.App;

/* Inherit your application services from this class.
 */
public abstract class AppAppService : ApplicationService
{
    protected AppAppService()
    {
        LocalizationResource = typeof(AppResource);
    }
}
