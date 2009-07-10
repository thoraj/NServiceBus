﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using NServiceBus.ObjectBuilder.Common.Config;
using NServiceBus.ObjectBuilder.Unity;

namespace NServiceBus
{
   /// <summary>
   /// Contains extension methods for configuring object builder infrastructure through Unity container.
   /// </summary>
   public static class ConfigureUnityBuilder
   {
      /// <summary>
      /// Use the Unity builder.
      /// </summary>
      /// <param name="config"></param>
      /// <returns></returns>
      public static Configure CastleWindsorBuilder(this Configure config)
      {
         ConfigureCommon.With(config, new UnityObjectBuilder());
         return config;
      }

      /// <summary>
      /// Use the Unity builder.
      /// </summary>
      /// <param name="config"></param>
      /// <param name="container">Exisitng unity container.</param>
      /// <returns></returns>
      public static Configure CastleWindsorBuilder(this Configure config, IUnityContainer container)
      {
         ConfigureCommon.With(config, new UnityObjectBuilder(container));
         return config;
      }      
   }
}