﻿using Atlas.Actions;
using Atlas.Utilities;
using JetBrains.Annotations;

namespace demo_20.Actions
{
    /// <summary>
    /// Delete if not needed
    /// </summary>
    internal class ServiceLifetimeAction : IServiceLifetimeAction
    {
        public int Priority { get; } = LifetimeActionPriority.SomePriority;

        public ServiceLifetimeAction()
        {
        }

        public void OnStart()
        {
        }

        public void OnChange()
        {
        }

        public void OnStop()
        {
        }
    }
}
