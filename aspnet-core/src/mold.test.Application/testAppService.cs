using System;
using System.Collections.Generic;
using System.Text;
using mold.test.Localization;
using Volo.Abp.Application.Services;

namespace mold.test
{
    /* Inherit your application services from this class.
     */
    public abstract class testAppService : ApplicationService
    {
        protected testAppService()
        {
            LocalizationResource = typeof(testResource);
        }
    }
}
