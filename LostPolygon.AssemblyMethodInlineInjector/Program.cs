﻿using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using LostPolygon.AssemblyMethodInlineInjector.Configuration;

namespace LostPolygon.AssemblyMethodInlineInjector {
    internal class Program {
        public static void Main(string[] args) {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

            string serializedInjectorConfiguration = File.ReadAllText(args[0]);
            InjectionConfiguration injectionConfiguration = XmlSerializationUtility.XmlDeserializeFromString<InjectionConfiguration>(serializedInjectorConfiguration);
            
            CompiledInjectionConfigurationBuilder compiledInjectionConfigurationBuilder = new CompiledInjectionConfigurationBuilder(injectionConfiguration);
            CompiledInjectionConfiguration compiledInjectionConfiguration = compiledInjectionConfigurationBuilder.Build();

            AssemblyMethodInlineInjector assemblyMethodInjector = new AssemblyMethodInlineInjector(compiledInjectionConfiguration);

            Stopwatch sw = Stopwatch.StartNew();
            assemblyMethodInjector.Inject();
            sw.Stop();
            Console.WriteLine("Injected in {0} ms", sw.ElapsedMilliseconds);

            foreach (CompiledInjectionConfiguration.InjecteeAssembly injecteeAssembly in compiledInjectionConfiguration.InjecteeAssemblies) {
                injecteeAssembly.AssemblyDefinitionData.AssemblyDefinition.Write(injecteeAssembly.SourceInjecteeAssembly.AssemblyPath);
            }
        }
    }
}