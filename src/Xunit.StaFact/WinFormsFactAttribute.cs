﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the Ms-PL license. See LICENSE.txt file in the project root for full license information.

#if DESKTOP

namespace Xunit
{
    using System;
    using Xunit.Sdk;

    /// <summary>
    /// Identifies an xunit test that starts on an STA thread
    /// with a WindowsFormsSynchronizationContext.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    [XunitTestCaseDiscoverer("Xunit.Sdk.WinFormsFactDiscoverer", ThisAssembly.AssemblyName)]
    public class WinFormsFactAttribute : FactAttribute
    {
    }
}

#endif
