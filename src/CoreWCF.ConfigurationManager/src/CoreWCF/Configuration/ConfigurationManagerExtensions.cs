﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace CoreWCF.Configuration
{
    public static class ConfigurationManagerExtensions
    {
        public static IServiceCollection AddServiceModelConfigurationManagerFile(this IServiceCollection builder, string path)
        {           
            builder.TryAddSingleton<IConfigurationHolder, ConfigurationHolder>();
            builder.TryAddSingleton<IBindingFactory, BindingFactory>();
            builder.AddSingleton<IConfigureOptions<ServiceModelOptions>>(ctx => new ConfigurationManagerServiceModelOptions(ctx, path));          

            return builder;
        }
    }
}
