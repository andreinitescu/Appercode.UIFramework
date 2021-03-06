﻿using Appercode.UI.Controls;

namespace Appercode.UI.Helpers
{
    public static class ResourceDictionaryManager
    {
        /// <summary>
        /// Method goes up by logical tree and searches fist occurrence of <paramref name="key"/> in Resources
        /// </summary>
        /// <param name="element">element to start searching</param>
        /// <param name="key">key of the resource</param>
        /// <returns></returns>
        public static object GetResourceFromLogicalTree(UIElement element, object key)
        {
            while (element != null)
            {
                var resources = element.InternalResources;
                if (resources != null)
                {
                    var resource = resources[key];
                    if (resource != null)
                    {
                        return resource;
                    }
                }

                element = element.Parent;
                if (element != null && element.IsTemplateRoot)
                {
                    break;
                }
            }

            return null;
        }

        #region Nested class StaticResourceLoader
        public class StaticResourceLoader<TResource>
        {
            private readonly UIElement element;
            private readonly object key;

            public StaticResourceLoader(UIElement element, object key)
            {
                this.element = element;
                this.key = key;
            }

            public TResource ActualResource
            {
                get
                {
                    return (TResource)GetResourceFromLogicalTree(this.element, this.key);
                }
            }
        }
        #endregion
    }
}