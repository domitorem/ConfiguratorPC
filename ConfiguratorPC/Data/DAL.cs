using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorPC.Data
{
    sealed class DAL
    {
        /// Поле контекста данных
        private static ConfiguratorPCEntities context;

        /// Свойство контекста данных
        public static ConfiguratorPCEntities Context
        {
            get
            {
                if (context == null)
                {
                    context = new ConfiguratorPCEntities();
                    context.Configuration.AutoDetectChangesEnabled = false;
                }
                return context;
            }
        }

        private DAL() { }
    }
}