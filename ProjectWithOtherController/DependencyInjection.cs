﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryWithController;
public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services) =>
        services.AddTransient<TestService>();
}